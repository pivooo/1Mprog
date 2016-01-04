public class Main {

    public static void main(String[] args) {
	// write your code here
        //exemple calcul aire & peri d'un rectange
        int largeur=6;
        Rectangle r1 = new Rectangle(6,largeur);
        System.out.println(r1.getAire());
        r1 = new Rectangle(8,2);
        System.out.println(r1.getAire());
    }
}
