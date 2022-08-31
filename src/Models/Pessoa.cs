using src.Models;
using System.Collections.Generic;

namespace src.Models;

public class Pessoa{

    public Pessoa(){
        this.Nome = "template";
        this.Idade = 0;
        this.Ativado = true;
        this.Contratos = new List<Contrato>();
    }

    public Pessoa(string Nome, int Idade, string Cpf){
        this.Nome = Nome;
        this.Idade = Idade;
        this.Cpf = Cpf;
        this.Ativado = true;
        this.Contratos = new List<Contrato>();
    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Cpf { get; set; }
    public Boolean Ativado { get; set; }
    public List<Contrato> Contratos { get; set; }
    
}