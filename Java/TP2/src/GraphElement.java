/**
 * Created by la120887 on 18/11/2015.
 */
public class GraphElement {
    private String name;
    private int[] distances;
    private GraphElement[] destinations;

    GraphElement(String nodeName, int linkNbr){
        name = nodeName;
        destinations = new GraphElement[linkNbr];
        distances = new int[linkNbr];
    }

    public String getName(){
        return name;
    }

    public int getLinkNbr(){
        return destinations.length;
    }

    public GraphElement getNextDest(int index){
        return destinations[index];
    }

    public int getNextDist(int index){
        return distances[index];
    }

    public void setLink(GraphElement dest, int dist){
        int i;
        for(i = 0; i < destinations.length; i++){
            if(destinations[i] == null){
                distances[i] = dist;
                destinations[i] = dest;
                break;
            }
        }
    }
}
