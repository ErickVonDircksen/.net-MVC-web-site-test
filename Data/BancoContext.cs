using Microsoft.EntityFrameworkCore;
using ControleDeContatos.Models;
using ControleDeContatos.Data;


namespace ControleDeContatos.Data{

public class BancoContext : DbContext
{
    public BancoContext(DbContextOptions<BancoContext> options) : base(options)
    {
      
    }

    public DbSet<ContatoModel>? Contato {get;set;}
}

}