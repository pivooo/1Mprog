import org.json.JSONArray;
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
public class Game {
    private Summoner[] summoner;
    private Champion[] bannedChamp;
    private JSONObject data;
    private boolean ingame;
    private boolean draft;

    Game(Summoner summy){
        summoner = new Summoner[10];
        bannedChamp = new Champion[6];
        summoner[0] = summy;
        ingame = true;
        draft = true;

    }

    public void getData(){
        String myURL;
        myURL = "https://" + summoner[0].region.getRegion() + ".api.pvp.net/observer-mode/rest/consumer/getSpectatorGameInfo/" + summoner[0].region.getServer() + "/" + summoner[0].getID() + "?api_key=" + Main.APIKey;
        String jsonData = callURL(myURL);
        if(ingame) {
            JSONObject obj = null;
            try {
                obj = new JSONObject(jsonData);
            } catch (JSONException e) {
                e.printStackTrace();
            }
            data = obj;
        }
    }

    public void getBanned() {
        String str="";
        JSONArray banned = new JSONArray();
        try {
            banned = data.getJSONArray("bannedChampions");
        } catch (JSONException e) {
            e.printStackTrace();
        }
            for (int i = 0; i < 6; i++) {
                try {
                    str = banned.getJSONObject(i).get("championId").toString();
                } catch (JSONException e) {
                    draft = false;
                }
                if(draft) {
                    bannedChamp[i] = new Champion();
                    bannedChamp[i].setID(str);
                }
            }
    }

    public void getPlayers(){
        String str="";
        JSONArray players = new JSONArray();
        try {
            players = data.getJSONArray("participants");
        } catch (JSONException e) {
            e.printStackTrace();
        }
        for (int i = 0; i < 10; i++) {
            try {
                str = players.getJSONObject(i).get("summonerName").toString();
            } catch (JSONException e) {
                e.printStackTrace();
            }
            summoner[i] = new Summoner(summoner[0].region.getRegion(), str);
            try {
                summoner[i].setChampion(players.getJSONObject(i).get("championId").toString());
            } catch (JSONException e) {
                e.printStackTrace();
            }
        }

    }

    public void printInfo() {
        if (ingame) {
            //System.out.println(data.toString());
            System.out.println("IN GAME");
            System.out.println("");
            if(draft){
                System.out.println("Banned: ");
                for(int i=0 ; i<6 ; i++){
                    System.out.println(bannedChamp[i].getName());
                }
            }
            System.out.println("");
            System.out.println("Team 1");
            System.out.println("");
            for(int i=0 ; i<5 ; i++){
                System.out.println(summoner[i].getName() + "             " + summoner[i].getChampion());
            }
            System.out.println("_________________");
            System.out.println("Team 2");
            System.out.println("");
            for(int i=5 ; i<10 ; i++){
                System.out.println(summoner[i].getName() + "             " + summoner[i].getChampion());
            }
            System.out.println("");

        }
        else
            System.out.println("NOT IN GAME");
    }

    public String callURL(String myURL) {
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
            ingame = false;
        }

        return sb.toString();
    }
}

