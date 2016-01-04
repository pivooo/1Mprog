public class Main {

    public static void main(String[] args) {
	// write your code here
        // Création et affichage premier cercle (avec paramètres)
        Cercle c1 = new Cercle(5,0,2);
        c1.printinfo();
        // Création et affichage second cercle (par défaut)
        Cercle c2 = new Cercle();
        c2.printinfo();
        // Affichage de la distance entre les cercles
        System.out.println("La distance entre les cercles est de " + Double.toString(c1.distcercle(c2)));
    }
}
