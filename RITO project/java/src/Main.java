public class Main {
    public static String APIKey = "61779544-090b-497a-add9-6fed9250bcd9";

    public static void main(String[] args) {
	// write your code here

        System.out.println("Hello world!");
        String region;
        String summonerName;
        region = "euw";
        summonerName = "schefff";
        Summoner summoner = new Summoner(region,summonerName);
        summoner.getInfo();

        Game game = new Game(summoner);
        game.getData();
        game.getBanned();
        game.getPlayers();
        game.printInfo();

    }


}
