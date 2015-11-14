import javafx.application.Application;
import javafx.geometry.Insets;
import javafx.geometry.Pos;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.layout.HBox;
import javafx.scene.text.Font;
import javafx.stage.Stage;
import javafx.event.ActionEvent;
import javafx.scene.layout.GridPane;
import javafx.scene.text.Text;

/**
 * Created by la120887 on 12/11/2015.
 */
public class PocketCalculator extends Application {
    @Override
    public void start(Stage primaryStage){
        primaryStage.setTitle("Pocket Calculator");
        primaryStage.show();

        // Texte
        Text resultDisplay = new Text("Test afficheur");
        resultDisplay.setText("Test afficheur");

        // Appel Moteur
        CalcEngine ce = new CalcEngine(resultDisplay);

        // Bouttons
        Button b0 = new Button("0");
        Button b1 = new Button("1");
        Button b2 = new Button("2");
        Button b3 = new Button("3");
        Button b4 = new Button("4");
        Button b5 = new Button("5");
        Button b6 = new Button("6");
        Button b7 = new Button("7");
        Button b8 = new Button("8");
        Button b9 = new Button("9");
        Button bclear = new Button("C");
        Button bequal = new Button("=");
        Button bplus = new Button("+");
        Button bminus = new Button("-");
        Button btimes = new Button("*");
        Button bdivide = new Button("/");


        b0.setOnAction((ActionEvent e)->{
            ce.updateNumber(0);
        });
        b1.setOnAction((ActionEvent e)->{
            ce.updateNumber(1);
        });
        b2.setOnAction((ActionEvent e)->{
            ce.updateNumber(2);
        });
        b3.setOnAction((ActionEvent e)->{
            ce.updateNumber(3);
        });
        b4.setOnAction((ActionEvent e)->{
            ce.updateNumber(4);
        });
        b5.setOnAction((ActionEvent e)->{
            ce.updateNumber(5);
        });
        b6.setOnAction((ActionEvent e)->{
            ce.updateNumber(6);
        });
        b7.setOnAction((ActionEvent e)->{
            ce.updateNumber(7);
        });
        b8.setOnAction((ActionEvent e)->{
            ce.updateNumber(8);
        });
        b9.setOnAction((ActionEvent e)->{
            ce.updateNumber(9);
        });
        bclear.setOnAction((ActionEvent e)->{
            ce.erase();
        });
        bequal.setOnAction((ActionEvent e)->{
            ce.process(CalcState.ST_NOP);
        });
        bplus.setOnAction((ActionEvent e)->{
            ce.process(CalcState.ST_ADD);
        });
        bminus.setOnAction((ActionEvent e)->{
            ce.process(CalcState.ST_SUB);
        });
        btimes.setOnAction((ActionEvent e)->{
            ce.process(CalcState.ST_MUL);
        });
        bdivide.setOnAction((ActionEvent e)->{
            ce.process(CalcState.ST_DIV);
        });


        // Grille - Mise en forme
        HBox hbox = new HBox();
        hbox.setPadding(new Insets(10,10,10,10));
        hbox.getChildren().add(resultDisplay);
        hbox.setAlignment(Pos.BOTTOM_RIGHT);
        hbox.setStyle("-fx-border-style: solid;" + "-fx-border-width: 2;" + "-fx-border-color: black");

        GridPane grid = new GridPane();
        primaryStage.setScene(new Scene(grid, 300, 275));
        //grid.setGridLinesVisible(true);
        grid.add(hbox, 0, 0, 4, 1);
        grid.add(b7, 0, 1, 1, 1);
        grid.add(b8, 1, 1, 1, 1);
        grid.add(b9, 2, 1, 1, 1);
        grid.add(bplus, 3, 1, 1, 1);
        grid.add(b4, 0, 2, 1, 1);
        grid.add(b5, 1, 2, 1, 1);
        grid.add(b6, 2, 2, 1, 1);
        grid.add(bminus, 3, 2, 1, 1);
        grid.add(b1, 0, 3, 1, 1);
        grid.add(b2, 1, 3, 1, 1);
        grid.add(b3, 2, 3, 1, 1);
        grid.add(btimes, 3, 3, 1, 1);
        grid.add(bclear,0 , 4, 1, 1);
        grid.add(b0, 1, 4, 1, 1);
        grid.add(bequal, 2, 4, 1, 1);
        grid.add(bdivide, 3, 4, 1, 1);

        grid.setAlignment(Pos.CENTER);
        b0.setFont(Font.font("Lucida Console", 20));
        b1.setFont(Font.font("Lucida Console", 20));
        b2.setFont(Font.font("Lucida Console", 20));
        b3.setFont(Font.font("Lucida Console", 20));
        b4.setFont(Font.font("Lucida Console", 20));
        b5.setFont(Font.font("Lucida Console", 20));
        b6.setFont(Font.font("Lucida Console", 20));
        b7.setFont(Font.font("Lucida Console", 20));
        b8.setFont(Font.font("Lucida Console", 20));
        b9.setFont(Font.font("Lucida Console", 20));
        bclear.setFont(Font.font("Lucida Console", 20));
        bequal.setFont(Font.font("Lucida Console", 20));
        bplus.setFont(Font.font("Lucida Console", 20));
        bminus.setFont(Font.font("Lucida Console", 20));
        btimes.setFont(Font.font("Lucida Console", 20));
        bdivide.setFont(Font.font("Lucida Console", 20));

        resultDisplay.setFont(Font.font("Lucida Console", 20));

        grid.setHgap(10);
        grid.setVgap(10);


    }
    public static void main(String[] args) {
        launch(args);
    }
}