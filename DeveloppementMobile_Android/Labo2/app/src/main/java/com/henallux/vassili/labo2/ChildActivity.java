package com.henallux.vassili.labo2;

import android.content.Context;
import android.content.Intent;
import android.net.Uri;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import static com.henallux.vassili.labo2.R.id.editText;

public class ChildActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_child);

        Bundle bundle = this.getIntent().getExtras();
        String messageFromParent = bundle.getString("editText");

        Context context = getApplicationContext();
        Toast toast = Toast.makeText(context, messageFromParent, Toast.LENGTH_LONG);
        toast.show();

        Button sendResultToParent = (Button) findViewById(R.id.sendResultToParent);
        sendResultToParent.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v){
                setResult(1);
                finish();
            }
        });

        Button makePhoneCall = (Button) findViewById(R.id.phoneCall);
        makePhoneCall.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v){
                android.net.Uri uri = Uri.parse("tel:0497123654");
                Intent intent = new Intent(Intent.ACTION_DIAL,uri);
                startActivity(intent);
            }
        });

        Button goToInternet = (Button) findViewById(R.id.internet);
        goToInternet.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v){
                android.net.Uri uri = Uri.parse("http://www.google.com/#q=henallux");
                Intent intent = new Intent(Intent.ACTION_VIEW,uri);
                startActivity(intent);
            }
        });
    }
}
