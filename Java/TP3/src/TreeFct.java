/**
 * Created by la120887 on 25/11/2015.
 */
public class TreeFct {

    public int computeDepth(StdTree t){
        int parentDepth = 0;
        if(t.isRoot()){
            return parentDepth;
        }
        t.parent();
        parentDepth = computeDepth(t);
        return parentDepth +1;
    }

    public void computeIndex(StdTree t){
        TextObject temp = (TextObject) t.getElement();
        if(t.isInternal())
            System.out.println(temp.getTextContent());
        if(t.isInternal()) {
            for (int i = 0; i < t.nbrChildren(); i++) {
                t.children(i);
                computeIndex(t);
                t.parent();
            }
        }

    }

    public int computeNbrChars(StdTree t) {
        return 0;
    }
}
