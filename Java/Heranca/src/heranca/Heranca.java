package heranca;

/**
 *
 * @author sergio
 */
public class Heranca {

   
    public static void main(String[] args) {
        Visitante v1 = new Visitante();
        v1.setNome("Pipoca");
        v1.setIdade(5);
        v1.setSexo("F");
        System.out.println(v1.toString());
        Aluno a1 = new Aluno();
        a1.setNome("Ilana");
        a1.setIdade(31);
        a1.setSexo("F");
        a1.setMatricula(101285);
        a1.pagarMensalidade();   
        System.out.println(a1.toString());
        Bolsista b1 = new Bolsista();
        b1.setNome("Amor");
        b1.setMatricula(130787);
        b1.setSexo("F");
        b1.setBolsa(10.5f);
        b1.pagarMensalidade();
        
    }
    
}
