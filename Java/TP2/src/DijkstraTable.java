/**
 * Created by LJ_Q1_2015 on 14/11/2015.
 */
public class DijkstraTable {
    private int[] distFromOrigin;
    private String[] dest;
    private String[] prevDest;

    DijkstraTable(int size){
        distFromOrigin = new int[size];
        dest = new String[size];
        prevDest = new String[size];
    }

    public void add(int newDist, String newDest, String newPrevD){
        int i;
        for(i = 0; i < dest.length; i++){
            if(dest[i] == null){
                distFromOrigin[i] = newDist;
                dest[i] = newDest;
                prevDest[i] = newPrevD;
                break;
            }
        }
    }

    public void update(int newDist, String Dest, String newPrevD){
        int i;
        i = findIndex(Dest);
        distFromOrigin[i] = newDist;
        prevDest[i] = newPrevD;
    }

    public void remove(int index){
        int i;
        for(i = index; i < (dest.length-1); i++){
            distFromOrigin[i] = distFromOrigin[i+1];
            dest[i] = dest[i+1];
            prevDest[i] = prevDest[i+1];
        }
        distFromOrigin[dest.length-1] = 0;
        dest[dest.length-1] = null;
        prevDest[dest.length-1]=null;
    }

    public void printTable(){
        int i;
        for(i = 0; i < dest.length; i++){
            if(dest[i] != null) {
                System.out.print("D: " + Integer.toString(distFromOrigin[i]));
                System.out.print(" City: " + dest[i]);
                System.out.println(" Prev: " + prevDest[i]);
            }
            else{
                break;
            }
        }
    }

    public boolean find(String destName){
        int i;
        for(i = 0; i < dest.length; i++) {
            if (dest[i] != null) {
                if(dest[i].equals(destName)){
                    return true;
                }
            }
            else{
                break;
            }
        }
        return false;
    }

    public int findIndex(String destName){
        int i;
        for(i = 0; i < dest.length; i++) {
            if (dest[i] != null) {
                if(dest[i].equals(destName)){
                    return i;
                }
            }
            else{
                break;
            }
        }
        return -1;
    }

    public int getMinIndex(){
        int i,min,minIndex;

        min = distFromOrigin[0];
        minIndex = 0;

        for(i = 1; i < dest.length; i++){
            if(dest[i]!=null){
                if(distFromOrigin[i] < min){
                    min = distFromOrigin[i];
                    minIndex = i;
                }
            }
            else{
                break;
            }
        }
        return minIndex;
    }

    public int getDist(int index){
        return distFromOrigin[index];
    }

    public String getDest(int index){
        return dest[index];
    }

    public String getPrevD(int index){
        return prevDest[index];
    }
}
