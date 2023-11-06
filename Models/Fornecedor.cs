namespace LHPet.Models;
public class Fornecedor

{
public int Id { get; set; }
public string Nome { get; set; }
public string CNPJ { get; set; }
public string Email { get; set; }
public Fornecedor(int id, string nome, string CNPJ, 
string email)
{
this.Id = id;
this.Nome = nome;
this.CNPJ = CNPJ;
this.Email = email;
}
}
