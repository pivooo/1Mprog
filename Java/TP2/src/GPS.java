/**
 * Created by LJ_Q1_2015 on 14/11/2015.
 */
public class GPS {
    public static void main(String[] args){

        System.out.println("Welcome to the GPS");

        MapGraph superMap = new MapGraph(25);

        superMap.setNode("Anvers",3);
        superMap.setNode("Arlon",1);
        superMap.setNode("Bruges",3);
        superMap.setNode("Charleroi",3);
        superMap.setNode("Courtrai",4);
        superMap.setNode("Gand",4);
        superMap.setNode("Halle",3);
        superMap.setNode("Hasselt",3);
        superMap.setNode("La Panne",1);
        superMap.setNode("Le Roeulx",3);
        superMap.setNode("Louvain",3);
        superMap.setNode("Louvain-La-Neuve",3);
        superMap.setNode("Liege",4);
        superMap.setNode("Mons",2);
        superMap.setNode("Namur",4);
        superMap.setNode("Neufchateau",3);
        superMap.setNode("Nivelles",4);
        superMap.setNode("Ostende",2);
        superMap.setNode("Tournai",3);
        superMap.setNode("Tervuren",3);
        superMap.setNode("Wauthier-Braine",3);
        superMap.setNode("Woluwe-Saint-Lambert",3);
        superMap.setNode("Ypres", 1);
        superMap.setNode("Zaventem", 3);
        superMap.setNode("Zellik", 3);

        superMap.setLink("Anvers","Gand", 52);
        superMap.setLink("Anvers","Zaventem", 39);
        superMap.setLink("Anvers","Hasselt",71);
        superMap.setLink("Arlon","Neufchateau",34);
        superMap.setLink("Bruges","Ostende",20);
        superMap.setLink("Bruges","Courtrai",41);
        superMap.setLink("Bruges","Gand",38);
        superMap.setLink("Charleroi","Le Roeulx",30);
        superMap.setLink("Charleroi","Nivelles",21);
        superMap.setLink("Charleroi","Namur",40);
        superMap.setLink("Courtrai","Ypres",30);
        superMap.setLink("Courtrai","Gand",44);
        superMap.setLink("Courtrai","Tournai", 30);
        superMap.setLink("Gand","Zellik",47);
        superMap.setLink("Halle","Tournai",68);
        superMap.setLink("Halle","Zellik",20);
        superMap.setLink("Halle","Wauthier-Braine",9);
        superMap.setLink("Hasselt","Liege",47);
        superMap.setLink("Hasselt","Louvain",50);
        superMap.setLink("La Panne", "Ostende", 40);
        superMap.setLink("Le Roeulx","Nivelles",14);
        superMap.setLink("Le Roeulx","Mons",8);
        superMap.setLink("Louvain","Liege",78);
        superMap.setLink("Louvain","Woluwe-Saint-Lambert",19);
        superMap.setLink("Louvain-La-Neuve","Nivelles",25);
        superMap.setLink("Louvain-La-Neuve","Tervuren",21);
        superMap.setLink("Louvain-La-Neuve","Namur",32);
        superMap.setLink("Liege","Namur",60);
        superMap.setLink("Liege","Neufchateau",100);
        superMap.setLink("Mons", "Tournai", 41);
        superMap.setLink("Namur","Neufchateau",96);
        superMap.setLink("Nivelles","Wauthier-Braine",11);
        superMap.setLink("Tervuren","Wauthier-Braine",25);
        superMap.setLink("Tervuren", "Woluwe-Saint-Lambert",5);
        superMap.setLink("Woluwe-Saint-Lambert","Zaventem",3);
        superMap.setLink("Zaventem","Zellik",16);

        superMap.processShortestPath("Mons");
    }
}
