package pooaula7;

/**
 *
 * @author sergio
 */
public class PooAula7 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Lutador l[] = new Lutador[6];
        l[0] = new Lutador("Pretty Boy", "Brasil", 31, 1.75f, 68.9f, 11, 2, 1);
        l[1] = new Lutador("Big Boy", "Brasil", 20, 1.95f, 120f, 11, 0, 2);
        l[2] = new Lutador("Half Boy", "Brasil", 25, 1.85f, 98f, 11, 0, 2);
        l[3] = new Lutador("Woman Boy", "argentina", 31, 1.75f, 68.9f, 0, 20, 0);
        l[4] = new Lutador("More Less Boy", "Alemanha", 31, 1.75f, 68.9f, 0, 10, 1);
        l[5] = new Lutador("Donkey Boy", "portugal", 38, 1.80f, 78f, 11, 1, 2);
        /*l[0].apresentar();
        l[0].status();
        l[1].apresentar();
        l[1].status();
        l[2].apresentar();
        l[2].status();
        l[3].apresentar();
        l[3].status();
        l[4].apresentar();
        l[4].status();
        l[5].apresentar();
        l[5].status();*/
        
        Luta UEC01 = new Luta();
        UEC01.marcarLuta(l[0], l[2]);
        UEC01.Lutar();
        l[0].status();
        l[2].status();
    }
    
}
