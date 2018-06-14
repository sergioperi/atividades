package heranca;

/**
 *
 * @author sergio
 */
public class Bolsista extends Aluno {
    private float bolsa;
    
    public void renovarBolsa(){
        System.out.println("Renovando Bolsa do aluno " + this.getNome());
    }
    
    @Override
    public void pagarMensalidade(){
        System.out.println(this.getNome() + " é bolsista, pagamento facilitado!");
    }

    public float getBolsa() {
        return bolsa;
    }

    public void setBolsa(float bolsa) {
        this.bolsa = bolsa;
    }
    
    
}
