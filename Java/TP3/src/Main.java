import sun.reflect.generics.tree.Tree;

import javax.xml.soap.Text;

public class Main {

    public static void main(String[] args) {
	// write your code here

        TextObject tempText = new TextObject();
        tempText.setTextContent("Titre Principal");
        tempText.setType(TextType.mainTitle);

        TextObject intro = new TextObject();
        intro.setTextContent("Introduction");
        intro.setType(TextType.chapter);

        TextObject introP1 = new TextObject();
        introP1.setTextContent("Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa.");
        introP1.setType(TextType.paragraph);

        TextObject introP2 = new TextObject();
        introP2.setTextContent("Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna. Nunc viverra imperdiet enim.");
        introP2.setType(TextType.paragraph);

        TextObject introP3 = new TextObject();
        introP3.setTextContent("Fusce est. Vivamus a tellus.");
        introP3.setType(TextType.paragraph);

        //Chap 1
        TextObject chap1 = new TextObject();
        chap1.setTextContent("Chapter 1");
        chap1.setType(TextType.chapter);

        TextObject chap1Part1 = new TextObject();
        chap1Part1.setTextContent("1.1");
        chap1Part1.setType(TextType.title);

        TextObject chap1Part1P1 = new TextObject();
        chap1Part1P1.setTextContent("Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede.");
        chap1Part1P1.setType(TextType.paragraph);

        TextObject chap1Part1P2 = new TextObject();
        chap1Part1P2.setTextContent("Mauris et orci. Aenean nec lorem.");
        chap1Part1P2.setType(TextType.paragraph);

        TextObject chap1Part1P3 = new TextObject();
        chap1Part1P3.setTextContent("In porttitor. Donec laoreet nonummy augue.");
        chap1Part1P3.setType(TextType.paragraph);

        TextObject chap1Part2 = new TextObject();
        chap1Part2.setTextContent("1.2");
        chap1Part2.setType(TextType.title);

        TextObject chap1Part2P1 = new TextObject();
        chap1Part2P1.setTextContent("Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend.");
        chap1Part2P1.setType(TextType.paragraph);

        TextObject chap1Part2P2 = new TextObject();
        chap1Part2P2.setTextContent("Ut nonummy. Fusce aliquet pede non pede.");
        chap1Part2P2.setType(TextType.paragraph);

        TextObject chap1Part2P3 = new TextObject();
        chap1Part2P3.setTextContent("Suspendisse dapibus lorem pellentesque magna. Integer nulla.");
        chap1Part2P3.setType(TextType.paragraph);

        //Chap2
        TextObject chap2 = new TextObject();
        chap2.setTextContent("Chapter 2");
        chap2.setType(TextType.chapter);

        TextObject chap2Part1 = new TextObject();
        chap2Part1.setTextContent("2.1");
        chap2Part1.setType(TextType.title);

        TextObject chap2Part1P1 = new TextObject();
        chap2Part1P1.setTextContent("Donec blandit feugiat ligula. Donec hendrerit, felis et imperdiet euismod, purus ipsum pretium metus, in lacinia nulla nisl eget sapien.");
        chap2Part1P1.setType(TextType.paragraph);

        TextObject chap2Part1P2 = new TextObject();
        chap2Part1P2.setTextContent("Donec ut est in lectus consequat consequat. Etiam eget dui.");
        chap2Part1P2.setType(TextType.paragraph);

        TextObject chap2Part1P3 = new TextObject();
        chap2Part1P3.setTextContent("Aliquam erat volutpat. Sed at lorem in nunc porta tristique.");
        chap2Part1P3.setType(TextType.paragraph);

        TextObject chap2Part2 = new TextObject();
        chap2Part2.setTextContent("2.2");
        chap2Part2.setType(TextType.title);

        TextObject chap2Part2P1 = new TextObject();
        chap2Part2P1.setTextContent("Proin nec augue. Quisque aliquam tempor magna.");
        chap2Part2P1.setType(TextType.paragraph);

        TextObject chap2Part2P2 = new TextObject();
        chap2Part2P2.setTextContent("Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nunc ac magna.");
        chap2Part2P2.setType(TextType.paragraph);

        TextObject chap2Part2P3 = new TextObject();
        chap2Part2P3.setTextContent("Maecenas odio dolor, vulputate vel, auctor ac, accumsan id, felis. Pellentesque cursus sagittis felis.");
        chap2Part2P3.setType(TextType.paragraph);

        //Concl

        TextObject concl = new TextObject();
        concl.setTextContent("Conclusion");
        concl.setType(TextType.chapter);

        TextObject conclP1 = new TextObject();
        conclP1.setTextContent("Pellentesque porttitor, velit lacinia egestas auctor, diam eros tempus arcu, nec vulputate augue magna vel risus. Cras non magna vel ante adipiscing rhoncus.");
        conclP1.setType(TextType.paragraph);

        TextObject conclP2 = new TextObject();
        conclP2.setTextContent("Vivamus a mi. Morbi neque.");
        conclP2.setType(TextType.paragraph);

        TextObject conclP3 = new TextObject();
        conclP3.setTextContent("Aliquam erat volutpat. Integer ultrices lobortis eros.");
        conclP3.setType(TextType.paragraph);



        //Construction arbre

        StdTree myTree = new StdTree();
        myTree.addRoot(tempText);
        //Intro
        myTree.addChild(intro);
        myTree.addChild(introP1);
        myTree.addSibling(introP2);
        myTree.addSibling(introP3);
        myTree.parent();
        myTree.parent();
        //Chap1
        myTree.addChild(chap1);
        myTree.addChild(chap1Part1);
        myTree.addChild(chap1Part1P1);
        myTree.addSibling(chap1Part1P2);
        myTree.addSibling(chap1Part1P3);
        myTree.parent();
        myTree.addSibling(chap1Part2);
        myTree.addChild(chap1Part2P1);
        myTree.addSibling(chap1Part2P2);
        myTree.addSibling(chap1Part2P3);
        myTree.parent();
        myTree.parent();
        myTree.parent();

        //Chap2

        myTree.addChild(chap2);
        myTree.addChild(chap2Part1);
        myTree.addChild(chap2Part1P1);
        myTree.addSibling(chap2Part1P2);
        myTree.addSibling(chap2Part1P3);
        myTree.parent();
        myTree.addSibling(chap2Part2);
        myTree.addChild(chap2Part2P1);
        myTree.addSibling(chap2Part2P2);
        myTree.addSibling(chap2Part2P3);
        myTree.parent();
        myTree.parent();
        myTree.parent();

        //Concl
        myTree.addChild(concl);
        myTree.addChild(conclP1);
        myTree.addSibling(conclP2);
        myTree.addSibling(conclP3);
        myTree.parent();
        myTree.parent();

        //Afficahge
        myTree.root();
        TextObject temp = (TextObject) myTree.getElement();
        System.out.println(temp.getTextContent());

        myTree.children(1);
        temp = (TextObject) myTree.getElement();
        System.out.println(temp.getTextContent());

        myTree.children(1);
        temp = (TextObject) myTree.getElement();
        System.out.println(temp.getTextContent());

        myTree.children(1);
        temp = (TextObject) myTree.getElement();
        System.out.println(temp.getTextContent());

        //myTree.root();
        TreeFct depth = new TreeFct();
        System.out.println(Integer.toString(depth.computeDepth(myTree)));

        //Index
        myTree.root();
        depth.computeIndex(myTree);



        /*
        Test partie 1
        if(tempText.getType() == TextType.mainTitle){

            System.out.println("Type OK!");
        }
        else{
            System.out.println("Type KO!");
        }

        System.out.println(tempText.getTextContent());
        System.out.println("Nbr Chars: " + Integer.toString(tempText.getNbrChars()));
        */
    }
}
