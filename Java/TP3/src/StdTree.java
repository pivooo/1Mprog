/**
 * Created by LJ_Q1_2015 on 21/11/2015.
 */
public class StdTree {
    private StdTreeNode root;
    private StdTreeNode position;
    private int size;

    StdTree(){
        root = null;
        position = null;
        size = 0;
    }

    public Object getElement(){
        return position.content;
    }

    public void root(){
        position = root;
    }

    public void parent(){
        position = position.parent;
    }

    public int nbrChildren(){
        StdTreeNode temp;
        int num;

        num = 0;
        if(position.children != null){
            num = 1;
            temp = position.children;

            while(temp.nextSibling != null){
                num++;
                temp = temp.nextSibling;
            }
        }
        return num;
    }

    public void children(int index){
        int i;

        position = position.children;
        for(i = 0; i < index; i++){
            position = position.nextSibling;
        }
    }

    public void nextSibling(){
        position = position.nextSibling;
    }

    public boolean isLastSibling(){
        if(position.nextSibling == null){
            return true;
        }
        else{
            return false;
        }
    }

    public boolean isInternal(){
        if(position.children != null){
            return true;
        }
        else{
            return false;
        }
    }

    public boolean isExternal(){
        if(position.children == null){
            return true;
        }
        else{
            return false;
        }
    }

    public boolean isRoot(){
        if(position.parent == null){
            return true;
        }
        else{
            return false;
        }
    }

    public int getSize(){
        return size;
    }

    public boolean isEmpty(){
        if(root == null){
            return true;
        }
        else{
            return false;
        }
    }

    public void addRoot(Object newContent){
        root = new StdTreeNode(newContent);
        position = root;
        size++;
    }

    public void addChild(Object newContent){
        StdTreeNode temp = new StdTreeNode(newContent);
        temp.parent = position;
        if(position.children == null){
            position.children = temp;
        }
        else{
            position = position.children;
            while(position.nextSibling != null){
                position = position.nextSibling;
            }
            position.nextSibling = temp;
        }
        position = temp;
        size++;
    }

    public void addSibling(Object newContent){
        StdTreeNode temp = new StdTreeNode(newContent);
        temp.parent = position.parent;
        position.nextSibling = temp;
        position = temp;
        size++;
    }

    public void setContent(Object newContent){
        position.content = newContent;
    }

    public void remove(){
        StdTreeNode temp,nextSib;

        if(isRoot()){
            root = null;
            position = null;
        }
        else{
            temp = position;
            nextSib = position.nextSibling;
            position = position.parent;
            if(position.children == temp){
                position.children = nextSib;
            }
            else{
                position = position.children;
                while(position.nextSibling != temp){
                    position = position.nextSibling;
                }
                position.nextSibling = nextSib;
                position = position.parent;
            }
        }

        size = recomputeSize();

    }

    public int recomputeSize(){
        StdTreeNode temp;
        int computedSize = 0;

        temp = root;
        if(temp == null){
            return 0;
        }
        while(true) {
            if (temp != null) {
                computedSize++;
            }
            if (temp.children != null) {
                temp = temp.children;
            } else {
                while (temp.nextSibling == null) {
                    temp = temp.parent;
                    if (temp == null) {
                        return size;
                    }
                }
                temp = temp.nextSibling;
            }
        }
    }
}
