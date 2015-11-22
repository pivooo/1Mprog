/**
 * Created by pivooo on 22/11/2015.
 */
public class Region {
    private String region;
    private String server;

    Region(String summonerRegion){
        region = summonerRegion.toLowerCase();
        switch(summonerRegion){
            case "euw":
                server = "EUW1";
                break;
            case "na":
                server = "NA1";
                break;
            case "br":
                server = "BR";
                break;
            case "lan":
                server = "LA1";
                break;
            case "las":
                server = "LA2";
                break;
            case "oce":
                server = "OC1";
                break;
            case "eune":
                server = "EUN1";
                break;
            case "tr":
                server = "TR1";
                break;
            case "ru":
                server = "RU";
                break;
            case "kr":
                server = "KR";
                break;
        }
    }

    public String getRegion() {
        return region;
    }

    public String getServer() {
        return server;
    }
}
