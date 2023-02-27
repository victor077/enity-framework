// See https://aka.ms/new-console-template for more information
using CursoEFCore.Data;
using CursoEFCore.Domain;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        using var db = new AplicationContext();

        db.Database.Migrate(); // faz com que a conexão seja feita de maneira automatica no seu banco de dados

        // var dbContext = new AplicationContext();

        // dbContext.Clientes.Where(clienteEspecifico => clienteEspecifico.Id == 1).Select(cliente);

        // faça algo com o objeto "cliente" aqui

        Console.ReadKey();
    }
}