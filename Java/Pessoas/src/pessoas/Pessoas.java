package pessoas;

import java.util.ArrayList;
import java.util.Collections;

public class Pessoas implements Comparable<Pessoas> {

    String nome;
    int idade;
    
    Pessoas(String name, int old){
        this.nome = name;
        this.idade = old;
    }
       
    public String toString(){
        return nome + ":" + idade;
    }
    
    public static void main(String[] args) {
        ArrayList<Pessoas> pessoa = new ArrayList<Pessoas>();
        pessoa.add( new Pessoas("Sérgio", 18));
        pessoa.add(new Pessoas("Francisco", 20));
        pessoa.add(new Pessoas("Vasconcelos", 25));
        pessoa.add(new Pessoas("Peri", 16));
        pessoa.add(new Pessoas("Sérgio", 22));
        
        Collections.sort(pessoa);
        
        for(Pessoas p : pessoa){
            System.out.println(p);
        }
    }

    
    public int compareTo(Pessoas o) {
        //return this.idade - o.idade;
        //-----------------------------------
        //return this.nome.compareTo(o.nome);
        //-----------------------------------
        /*if(this.idade < o.idade){
            return -1;
        }
        if(this.idade > o.idade){
            return 1;
        }
        return 0;*/
        //-----------------------------------
        if(this.nome.compareTo(o.nome) == 0){
            return this.idade - o.idade;
        }
        else{
            return this.nome.compareTo(o.nome);
        }
        
    }    
}
