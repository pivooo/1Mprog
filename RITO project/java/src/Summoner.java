import org.json.JSONObject;
import org.json.JSONException;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.URL;
import java.net.URLConnection;
import java.nio.charset.Charset;

/**
 * Created by pivooo on 21/11/2015.
 */
public class Summoner {
    private String name;
    public Region region;
    private JSONObject info;
    private Champion champion;

    Summoner(String summonerRegion,String summonerName){
        Region temp = new Region(summonerRegion);
        region = temp;
        name = summonerName;
    }


    public String formatName(){
        return name.replaceAll("\\s+","").toLowerCase();
    }

    public void getInfo() {
        String myURL;
        myURL = "https://" + region.getRegion() + ".api.pvp.net/api/lol/euw/v1.4/summoner/by-name/" + formatName() + "?api_key=" + Main.APIKey;
        String jsonData = callURL(myURL);
        JSONObject obj = null;
        try {
            obj = new JSONObject(jsonData);
        } catch (JSONException e) {
            e.printStackTrace();
        }
        info = obj;
    }

    public void printInfo(){
        System.out.println("Player : " + name);
        System.out.println("----------------------");
        System.out.println("");
    }

    public String getName(){
        return name;
    }

    public String getID(){
        String str="";
        try {
            str = info.get(formatName()).toString();
            JSONObject obj = new JSONObject(str);
            str = obj.get("id").toString();
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return str;
    }

    public void setChampion(String newID){
        champion = new Champion();
        champion.setID(newID);
    }

    public String getChampion(){
        return champion.getName();
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


