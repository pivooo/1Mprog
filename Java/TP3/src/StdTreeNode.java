/**
 * Created by LJ_Q1_2015 on 21/11/2015.
 */
public class StdTreeNode {
    public Object content;
    public StdTreeNode parent;
    public StdTreeNode children;
    public StdTreeNode nextSibling;

    StdTreeNode(Object newContent){
        content = newContent;
        parent = null;
        children = null;
        nextSibling = null;
    }
}
