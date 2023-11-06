namespace LHPet.Models;
public class Cliente
{
/* No trecho de código a seguir são criados os 
atributos de Cliente e seus getters e setters
correspondentes. */
public int Id { get; set; }
public string Nome { get; set; }
public string CPF { get; set; }
public string Email { get; set; }
public string Paciente { get; set; }
/* Nesse trecho do código, é criado o Construtor do 
model Cliente e determinado quais parâmetros são 
necessários na criação das instâncias. */
public Cliente(int id, string nome, string CPF, 
string email, string paciente)
{
this.Id = id;
this.Nome = nome;
this.CPF = CPF;
this.Email = email;
this.Paciente = paciente;
}
}
