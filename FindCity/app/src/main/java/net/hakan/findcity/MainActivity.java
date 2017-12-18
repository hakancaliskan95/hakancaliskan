package net.hakan.findcity;

import android.content.DialogInterface;
import android.content.res.Resources;
import android.graphics.Color;
import android.os.Bundle;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.text.InputType;
import android.util.TypedValue;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.TableLayout;
import android.widget.TableRow;
import android.widget.TextView;

import java.util.Random;

public class MainActivity extends AppCompatActivity {
    String[] sehirler = new String[]{"ADANA", "KONYA", "ADIYAMAN", "KÜTAHYA", "AFYONKARAHİSAR", "MALATYA", "AĞRI", "MANİSA", "AMASYA", "KAHRAMANMARAŞ", "ANKARA", "MARDİN", "ANTALYA", "MUĞLA", "ARTVİN", "MUŞ", "AYDIN", "NEVŞEHİR", "BALIKESİR", "NİĞDE", "BİLECİK", "ORDU", "BİNGÖL", "RİZE", "BİTLİS", "SAKARYA", "BOLU", "SAMSUN", "BURDUR", "SİİRT", "BURSA", "SİNOP", "ÇANAKKALE", "SİVAS", "ÇANKIRI", "TEKİRDAĞ", "ÇORUM", "TOKAT", "DENİZLİ", "TRABZON", "DİYARBAKIR", "TUNCELİ", "EDİRNE", "ŞANLIURFA", "ELAZIĞ", "UŞAK", "ERZİNCAN", "VAN", "ERZURUM", "YOZGAT", "ESKİŞEHİR", "ZONGULDAK", "GAZİANTEP", "AKSARAY", "GİRESUN", "BAYBURT", "GÜMÜŞHANE", "KARAMAN", "HAKKARİ", "KIRIKKALE", "HATAY", "BATMAN", "ISPARTA", "ŞIRNAK", "MERSİN", "BARTIN", "İSTANBUL", "ARDAHAN", "İZMİR", "IĞDIR", "KARS", "YALOVA", "KASTAMONU", "KARABÜK", "KAYSERİ", "KİLİS", "KIRKLARELİ", "OSMANİYE", "KIRŞEHİR", "DÜZCE", "KOCAELİ"};
    String secilenSehir = "";
    LinearLayout llSehir;
    int ekranGenisligi = 0;
    int maksimumHarfDenemeSayisi = 0;
    int puan = 0;
    TextView tvHarfSiniri, tvPuan;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        ekranGenisligi = Resources.getSystem().getDisplayMetrics().widthPixels;
        tvHarfSiniri = (TextView) findViewById(R.id.tvHarfSiniri);
        tvPuan = (TextView) findViewById(R.id.tvPuan);
        llSehir = (LinearLayout) findViewById(R.id.llSehir);
        sehirSec();
    }

    public void sehirSec() {
        Random rnd = new Random();
        int index = rnd.nextInt(sehirler.length);
        secilenSehir = sehirler[index];
        llSehir.removeAllViews();
        for (int i = 0; i < secilenSehir.length(); i++) {
            TextView textView = new TextView(this);
            //textView.setHeight(dpToPx(20));
            //textView.setWidth(dpToPx(20));
            textView.setPadding(8, 0, 8, 0);
            textView.setTextSize(24);
            textView.setTextColor(Color.RED);
            textView.setText("_");
            llSehir.addView(textView);
        }
        butonYerlestir();
        maksimumHarfDenemeSayisi = 10 + new Random().nextInt(10);
        tvHarfSiniri.setText("Kalan Deneme Hakkınız:" + String.valueOf(maksimumHarfDenemeSayisi));
    }

    public void butonYerlestir() {
        TableLayout tlButon = (TableLayout) findViewById(R.id.tlButon);
        tlButon.removeAllViews();
        String[] alfabe = new String[]{"A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "İ", "I", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z"};
        TableRow tableRow = new TableRow(this);
        int genislik = (ekranGenisligi / 6) - 4;
        for (int i = 0; i < alfabe.length; i++) {
            if (i % 6 == 0) {
                tableRow = new TableRow(this);
                tlButon.addView(tableRow);
            }
            final Button btn = new Button(this);
            btn.setText(alfabe[i]);
            tableRow.addView(btn);
            ViewGroup.LayoutParams params = btn.getLayoutParams();
            params.width = genislik;
            params.height = genislik;
            btn.setLayoutParams(params);
            btn.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    maksimumHarfDenemeSayisi--;
                    if (maksimumHarfDenemeSayisi <= 0)
                        return;
                    // TODO: Oyun bitirilecek
                    String basilanHarf = btn.getText().toString();
                    int bilinenHarfSayisi = 0;
                    for (int j = 0; j < secilenSehir.length(); j++) {
                        if (secilenSehir.charAt(j) == basilanHarf.charAt(0)) {
                            TextView tv = (TextView) llSehir.getChildAt(j);
                            tv.setText(basilanHarf);
                            bilinenHarfSayisi++;
                        }
                    }
                    if (bilinenHarfSayisi > 0)
                        puan += bilinenHarfSayisi * 10;
                    else
                        puan -= 5;
                    if (puan < 0)
                        puan = 0;
                    tvPuan.setText("Puan Durumu:" + String.valueOf(puan));
                    btn.setEnabled(false);
                    tvHarfSiniri.setText("Kalan Deneme Hakkınız:" + String.valueOf(maksimumHarfDenemeSayisi));
                }
            });
        }
    }

    public int dpToPx(float dp) {
        return (int) TypedValue.applyDimension(TypedValue.COMPLEX_UNIT_DIP, dp, getResources().getDisplayMetrics());
    }

    public void sonrakiSehir(View view) {
        sehirSec();
    }

    public void tahminEt(View view) {
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setTitle("Tahmini Giriniz");
        //builder.setMessage("ŞEHİR");
        final EditText etTahmin = new EditText(this);
        String tahminEdilen = "";
        for (int i = 0; i < llSehir.getChildCount(); i++) {
            tahminEdilen += ((TextView) llSehir.getChildAt(i)).getText().toString();
        }
        etTahmin.setHint(tahminEdilen);
        etTahmin.setInputType(InputType.TYPE_CLASS_TEXT | InputType.TYPE_TEXT_FLAG_CAP_CHARACTERS);
        builder.setView(etTahmin);

        builder.setNegativeButton("İPTAL", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                dialog.dismiss();
            }
        });

        builder.setPositiveButton("TAMAM", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
              if( etTahmin.getText().toString().trim().equals(secilenSehir))
              {

                  int bilinmeyenHarfSayisi = 0;
                  for (int i = 0; i < llSehir.getChildCount(); i++) {
                      TextView textView =  (TextView) llSehir.getChildAt(i);
                      if(textView.getText().equals("_"))
                          bilinmeyenHarfSayisi++;

                      textView.setText( Character.toString( secilenSehir.charAt(i)));
                  }

                  puan += bilinmeyenHarfSayisi*20;
              }
              else
              {
                  puan-=50;
              }
                tvPuan.setText("Puan Durumu:" + String.valueOf(puan));
            }
        });

        builder.show();
    }
}
