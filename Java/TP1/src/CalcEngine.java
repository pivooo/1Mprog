import javafx.scene.text.Text;

import java.util.InputMismatchException;

/**
 * Created by la120887 on 12/11/2015.
 */

public class CalcEngine {
    private int A;
    private int B;
    private CalcState st;
    private Text t;
    public void erase(){
        A = 0;
        B = 0;
        st = CalcState.ST_NOP;
        t.setText(Integer.toString(A));
    }

    CalcEngine(Text externalText){
       t=externalText;
        erase();
    }

    public void updateNumber(int input){
        B *= 10;
        B += input;
        t.setText(Integer.toString(B));
    }

    public void process(CalcState newSt){
        switch(st){
            case ST_NOP:
                A = B;
                break;
            case ST_ADD:
                A += B;
                break;
            case ST_SUB:
                A -= B;
                break;
            case ST_MUL:
                A *= B;
                break;
            case ST_DIV:
                A /= B;
                break;
        }
        B = 0;
        t.setText(Integer.toString(A));
        st = newSt;
    }
}
