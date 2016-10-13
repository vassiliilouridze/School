package com.henallux.vassili.labo2;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    EditText editText;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        editText = (EditText) findViewById(R.id.editText);

        Button btnGoToChildactivity = (Button) findViewById(R.id.GoToChildactivity);
        btnGoToChildactivity.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v){
                Intent intent = new Intent(MainActivity.this, ChildActivity.class);
                intent.putExtra("editText", editText.getText().toString());
                startActivityForResult(intent,1);
            }
        });
    }

    @Override
    public void onActivityResult(int requestCode, int resultCode, Intent intent){
        super.onActivityResult(requestCode,resultCode,intent);
        if(requestCode == 1){
            switch(resultCode){
                case 0 :
                    Toast.makeText(MainActivity.this, "Result code = 0", Toast.LENGTH_LONG).show();
                    break;
                case 1 :
                    Toast.makeText(MainActivity.this, "Result code = 1", Toast.LENGTH_LONG).show();
                    break;
            }
        }
    }
}
