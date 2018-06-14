
package objetoanonimo;


public class ObjetoAnonimo {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        /*pessoa p = new pessoa();
        System.out.println(p.grito());Utilizando objeto*/
        System.out.println(new pessoa().grito());//Objeto anônimo
    }
    
}


class pessoa{
    String nome;
    String som;
    
    public String grito(){
        return som = "Cruzeiroooooo";
    }
}