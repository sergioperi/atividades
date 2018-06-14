
package pessoas;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;


public class Pessoas {

    String nome;
    int idade;
    
    public Pessoas(String name, int old){
        this.nome = name;
        this.idade = old;
    }
    
    public String toString(){
        return nome + ":" + idade;
    }
    
       
    public static void main(String[] args) {
        ArrayList<Pessoas> pessoa = new ArrayList<>();
        pessoa.add(new Pessoas("Zezinho", 5));
        pessoa.add(new Pessoas("Joãozinho", 3));
        pessoa.add(new Pessoas("Mariazinha", 4));
        pessoa.add(new Pessoas("Lilizinha", 6));
        
        Collections.sort(pessoa, new compara());
        
        for(Pessoas p : pessoa){
            System.out.println(p);
        }
    }   
    
}

class compara implements Comparator<Pessoas>{

    
    public int compare(Pessoas o1, Pessoas o2) {
        //return o1.idade - o2.idade;
        return o1.nome.compareTo(o2.nome);
    }
    
}
