package pooaula7;

/**
 *
 * @author sergio
 */
public class Lutador {
    //Atributos
    private String nome;
    private String nacionalidade;
    private int idade;
    private float altura;
    private float peso;
    private String categoria;
    private int vitorias, derrotas, empates;
    
    //Métodos Públicos
    public void apresentar(){
        System.out.println("Chegou a hora, vamos apresentar o lutador: " + getNome());
        System.out.println("Diretamente do: " + getNacionalidade());
        System.out.println("Com " + getIdade() + " e " + getAltura() + "m de altura, " );
        System.out.println("Pesando " + getPeso() + " kg");
        System.out.println("Com " + getVitorias() + " vitórias");
        System.out.println(getDerrotas()+ " derrotas e ");
        System.out.println(getEmpates() + " empates");
    }
    public void status(){
        System.out.println(getNome() + " é " + getCategoria());
        System.out.println("Venceu " + getVitorias() + " vezes ");
        System.out.println("Perdeu " + getDerrotas()+ " vezes e ");
        System.out.println("Empatou " + getEmpates() + " vezes");
    }
    public void ganharLuta(){
        this.setVitorias(getVitorias() + 1);
    }
    public void perderLuta(){
        this.setDerrotas(getDerrotas() + 1);
    }
    public void empatarLuta(){
        this.setEmpates(getEmpates() + 1);
    }
    //Métodos Especiais

    public Lutador(String nome, String nacionalidade, int idade, float altura, float peso, int vitorias, int derrotas, int empates) {
        this.nome = nome;
        this.nacionalidade = nacionalidade;
        this.idade = idade;
        this.altura = altura;
        this.setPeso(peso);
        this.vitorias = vitorias;
        this.derrotas = derrotas;
        this.empates = empates;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getNacionalidade() {
        return nacionalidade;
    }

    public void setNacionalidade(String nacionalidade) {
        this.nacionalidade = nacionalidade;
    }

    public int getIdade() {
        return idade;
    }

    public void setIdade(int idade) {
        this.idade = idade;
    }

    public float getAltura() {
        return altura;
    }

    public void setAltura(float altura) {
        this.altura = altura;
    }

    public float getPeso() {
        return peso;
    }

    public void setPeso(float peso) {
        this.peso = peso;        
        this.setCategoria();
    }

    public String getCategoria() {
        return categoria;
    }

    private void setCategoria() {
        if(this.peso < 52.2){
            this.categoria = "Inválido";
        }else if(this.peso <= 70.3){
            this.categoria = "Leve";
        }else if((this.peso <= 83.9) && (this.peso > 70.3)){
            this.categoria = "Médio";
        }else if((this.peso <= 120.2) && (this.peso > 83.9)){
            this.categoria = "Pesado";
        }else{
            this.categoria = "Inválido";
        }
    }

    public int getVitorias() {
        return vitorias;
    }

    public void setVitorias(int vitorias) {
        this.vitorias = vitorias;
    }

    public int getDerrotas() {
        return derrotas;
    }

    public void setDerrotas(int derrotas) {
        this.derrotas = derrotas;
    }

    public int getEmpates() {
        return empates;
    }

    public void setEmpates(int empates) {
        this.empates = empates;
    }
    
}
