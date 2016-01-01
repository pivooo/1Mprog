/**
 * Created by la120887 on 25/11/2015.
 */
public class TextObject {
    private String textContent;
    private TextType type;

    public void setType(TextType newType){
        type = newType;
    }

    public void setTextContent(String newContent){
        textContent = newContent;
    }

    public TextType getType(){
        return type;
    }

    public String getTextContent(){
        return textContent;
    }

    public int getNbrChars(){
        return textContent.length();
    }
}
