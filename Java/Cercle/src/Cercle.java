/**
 * Created by pivooo on 4/01/2016.
 */
public class Cercle {
    private int xpos;               // Vous pouvez le faire en float/double si vous voulez
    private int ypos;
    private int rayon;

    Cercle(int x,int y,int z){
        xpos = x;
        ypos = y;
        rayon = z;
    }

    Cercle(){
        // Si pas de paramètre, cercle "par défaut" => centre à l'origine et rayon = 1
        xpos = 0;
        ypos = 0;
        rayon = 1;
    }

    public void setXpos(int xpos) {
        this.xpos = xpos;       // this pas obligatoire, j'ai même pas écrit cette fonction vous taper setXpos et ça vous la propose toute seul (alternative en dessous)
        /*
         xpos = newXpos;        // Si on considère que newXpos est le paramètre d'entrée
          */
    }

    public void setYpos(int newypos) {
        ypos = newypos;
    }

    public void setRayon(int rayon) {
        this.rayon = rayon;
    }

    public int getXpos() {
        return xpos;
    }

    public int getYpos() {
        return ypos;
    }

    public int getRayon() {
        return rayon;
    }

    private double distcentre(Cercle c){
        // Calcul la distance entre les centres de ce cercle et du cercle en paramètre
        // Je fais en plusieurs lignes pour lisibilité
        int dx = xpos - c.getXpos();
        int dy = ypos - c.getYpos();
        dx = dx * dx;
        dy = dy * dy;
        return Math.sqrt(dx+dy);
        // Math.sqrt fournie par le prof
    }

    public double distcercle(Cercle c){
        // Calcul de la distance entre deux cercles
        // dist = distcentre - r1 - r2
        return distcentre(c)-rayon-c.getRayon();
    }

    public void printinfo(){
        System.out.println("Cercle cree en " + Integer.toString(xpos) + "," + Integer.toString(ypos) + " et de rayon " + Integer.toString(rayon));
    }
}
