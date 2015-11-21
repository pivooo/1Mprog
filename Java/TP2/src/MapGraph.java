/**
 * Created by LJ_Q1_2015 on 13/11/2015.
 */
public class MapGraph {
    private GraphElement[] map;

    MapGraph(int nodeNbr){
        map = new GraphElement[nodeNbr];
    }

    public void setNode(String nodeName, int linkNbr){
        int i;
        for (i = 0; i < map.length; i++) {
            if (map[i] == null) {
                map[i] = new GraphElement(nodeName, linkNbr);
                break;
            }
        }
    }

    private GraphElement findNode(String Name){
        int i;
        for (i = 0; i < map.length; i++) {
            if (map[i].getName().equals(Name)) {
                return map[i];
            }
        }
        return null;
    }

    public void setLink(String nodeAName,String nodeBName, int dist) {
        GraphElement nodeA,nodeB;

        nodeA = findNode(nodeAName);
        nodeB = findNode(nodeBName);

        nodeA.setLink(nodeB,dist);
        nodeB.setLink(nodeA,dist);
    }

    public void processShortestPath(String originName){
        GraphElement origin,temp;
        int i,traveledDist = 0;
        DijkstraTable solTable = new DijkstraTable(map.length);
        origin = findNode(originName);

        System.out.println("Point de départ: " + origin.getName());
        System.out.println("Distance parcourue: " + Integer.toString(traveledDist) + " km !");


        solTable.add(0,origin.getName(),"/");
        solTable.printTable();

        DijkstraTable tempTable = new DijkstraTable(map.length);
        while(true) {
            // 2: discovering nodes
            for (i = 0; i < origin.getLinkNbr(); i++) {
                temp = origin.getNextDest(i);
                if (!solTable.find(temp.getName())) {
                    // next destination is not yet solved
                    if (!tempTable.find(temp.getName())) {
                        tempTable.add(traveledDist + origin.getNextDist(i), temp.getName(), origin.getName());
                    } else {
                        // next destination was discovered before
                        if (traveledDist + origin.getNextDist(i) < tempTable.getDist(tempTable.findIndex(temp.getName()))) {
                            tempTable.update(traveledDist + origin.getNextDist(i), temp.getName(), origin.getName());
                        }
                    }
                }
            }

            // Dijkstra ends
            if (tempTable.getDest(0) == null) {
                break;
            }
            System.out.println("");
            System.out.println("Destinations Possibles:");
            tempTable.printTable();

            //3: Next solution
            i = tempTable.getMinIndex();
            solTable.add(tempTable.getDist(i), tempTable.getDest(i), tempTable.getPrevD(i));
            origin = findNode(tempTable.getDest(i));
            traveledDist = tempTable.getDist(i);
            tempTable.remove(i);
            System.out.println("Distance parcourue " + Integer.toString(traveledDist) + "km!");


        }
        solTable.printTable();






        /*          VERSION DE BASE
        for(i = 0; i < origin.getLinkNbr() ; i++){

                temp = origin.getNextDest(i);
                tempTable.add(traveledDist + origin.getNextDist(i) , temp.getName() , origin.getName());
            }
        tempTable.printTable();
        solTable.add(traveledDist + tempTable.getDist(tempTable.getMinIndex()),tempTable.getDest(tempTable.getMinIndex()),tempTable.getPrevD(tempTable.getMinIndex()));
        origin = findNode(tempTable.getDest(tempTable.getMinIndex()));
        traveledDist = tempTable.getDist(tempTable.getMinIndex());
        tempTable.remove(tempTable.getMinIndex());
        System.out.println("Distance parcourue: " + Integer.toString(traveledDist) + " km !");
        solTable.printTable();
        */



    }
}
