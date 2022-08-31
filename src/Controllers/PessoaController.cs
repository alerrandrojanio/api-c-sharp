using Microsoft.AspNetCore.Mvc;
using src.Models;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoaController : ControllerBase{

    [HttpGet]
    public Pessoa get(){
        Pessoa pessoa = new Pessoa("ale", 23, "12345678");
        Contrato contrato = new Contrato("abc123", 50.43);
        Contrato contrato2 = new Contrato("123abc", 27.09);

        pessoa.Contratos.Add(contrato);
        pessoa.Contratos.Add(contrato2);
        
        return pessoa;
    }

    [HttpPost]
    public Pessoa Post(Pessoa pessoa){
        return pessoa;
    }

    [HttpPut("{id}")]
    public string Update([FromRoute]int id, [FromBody]Pessoa pessoa){
        Console.WriteLine(id);
        Console.WriteLine(pessoa);
        return "Dados do id " + id + " atualizados!";
    }

    [HttpDelete("{id}")]
    public string Delete([FromRoute]int id){

        return "Deletada pessoa de " + id; 
    }

}