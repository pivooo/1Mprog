import org.json.JSONException;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.URL;
import java.net.URLConnection;
import java.nio.charset.Charset;

/**
 * Created by pivooo on 22/11/2015.
 */
public class Champion {
    private String ID;

    Champion(){
        ID = "";
    }

    public void setID(String newID){
        ID = newID;
    }

    public String getName(){
        String myURL;
        String str="";
        myURL = "https://global.api.pvp.net/api/lol/static-data/euw/v1.2/champion/" + ID + "?api_key=" + Main.APIKey;
        String jsonData = callURL(myURL);
        JSONObject obj = null;
        try {
            obj = new JSONObject(jsonData);
        } catch (JSONException e) {
            e.printStackTrace();
        }
        try {
            return obj.get("name").toString();
        } catch (JSONException e) {
            return "";
        }
    }


    public static String callURL(String myURL) {
        //System.out.println("Requested URL:" + myURL);
        StringBuilder sb = new StringBuilder();
        URLConnection urlConn = null;
        InputStreamReader in = null;
        try {
            URL url = new URL(myURL);
            urlConn = url.openConnection();
            if (urlConn != null)
                urlConn.setReadTimeout(60 * 1000);
            if (urlConn != null && urlConn.getInputStream() != null) {
                in = new InputStreamReader(urlConn.getInputStream(),
                        Charset.defaultCharset());
                BufferedReader bufferedReader = new BufferedReader(in);
                if (bufferedReader != null) {
                    int cp;
                    while ((cp = bufferedReader.read()) != -1) {
                        sb.append((char) cp);
                    }
                    bufferedReader.close();
                }
            }
            in.close();
        } catch (Exception e) {
            throw new RuntimeException("Exception while calling URL:"+ myURL, e);
        }

        return sb.toString();
    }
}
