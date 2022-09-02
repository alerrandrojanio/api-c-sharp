using Microsoft.AspNetCore.Mvc;
using src.Models;
using src.Persistence;
using Microsoft.EntityFrameworkCore;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoaController : ControllerBase{

    private DatabaseContext _context { get; set; }

    public PessoaController(DatabaseContext context){
        this._context = context;
    }

    [HttpGet]
    public List<Pessoa> get(){
        //Pessoa pessoa = new Pessoa("ale", 23, "12345678");
        //Contrato contrato = new Contrato("abc123", 50.43);
        //pessoa.Contratos.Add(contrato);

        return _context.Pessoas.Include( p => p.Contratos).ToList();
    }

    [HttpPost]
    public Pessoa Post([FromBody]Pessoa pessoa){
        _context.Pessoas.Add(pessoa);
        _context.SaveChanges();

        return pessoa;
    }

    [HttpPut("{id}")]
    public string Update([FromRoute]int id, [FromBody]Pessoa pessoa){
        _context.Pessoas.Update(pessoa);
        _context.SaveChanges();

        return "Dados do id " + id + " atualizados!";
    }

    [HttpDelete("{id}")]
    public string Delete([FromRoute]int id){
        var result = _context.Pessoas.SingleOrDefault(e => e.Id == id);

        _context.Pessoas.Remove(result);
        _context.SaveChanges();

        return "Deletada pessoa de " + id; 
    }

}