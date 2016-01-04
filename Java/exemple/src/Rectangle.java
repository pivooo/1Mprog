/**
 * Created by pivooo on 2/01/2016.
 */
public class Rectangle {
    private int longueur;
    private int largeur;

    Rectangle(int x,int y){
        largeur = y;
        longueur = x;
    }

    public int getAire(){
        return largeur*longueur;
    }

    public int getPeri(){
        return 2*(largeur+longueur);
    }

    public
}
