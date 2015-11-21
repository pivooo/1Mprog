public class MapAnalyzer {

    public static void main(String[] args) {
        String A = "Mons";
        String B = "Charleroi";
        String C = "Bruxelles";


	// write your code here
        System.out.println("Hello world!");
        MapGraph superMap = new MapGraph(3);
        superMap.setNode(A,2);
        superMap.setNode(B,2);
        superMap.setNode(C,2);

        superMap.setLink(A,B,30);
        superMap.setLink(A,C,65);
        superMap.setLink(B,C,20);

        superMap.processShortestPath(A);

    }
}
