using Api_Tcc.Models;
using Api_Tcc.Models.Enuns;
using Microsoft.EntityFrameworkCore;

namespace Api_Tcc.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Almoxarife>().HasData
            (
                new Usuario() { Id = 1, Nome = "Frodo", Classe = TipoClasseEnum.Almoxarife},
                new Usuario() { Id = 2, Nome = "Sam",Classe = TipoClasseEnum.Almoxarife}
            );


            modelBuilder.Entity<Professor>().HasData
            (
                new Usuario() { Id = 1, Nome = "Frodo", Classe = TipoClasseEnum.Professor},
                new Usuario() { Id = 2, Nome = "Sam",Classe = TipoClasseEnum.Professor}
            );


            modelBuilder.Entity<Usuario>().HasData
            (
                new Usuario() { Id = 1, Nome = "Frodo", Classe = TipoClasseEnum.},
                new Usuario() { Id = 2, Nome = "Sam",Classe = TipoClasseEnum.Professor}
            );
            
             //Início da criação do usuário padrão.
            Usuario user = new Usuario();
            Criptografia.CriarPasswordHash("123456", out byte[] hash, out byte[]salt);
            user.Id = 1;
            user.Username = "UsuarioAdmin";
            user.PasswordString = string.Empty;
            user.PasswordHash = hash;
            user.PasswordSalt = salt;
            user.Perfil = "Almoxarife/Professor";
            user.Email = "seuEmail@gmail.com";

            modelBuilder.Entity<Usuario>().HasData(user);            
            //Fim da criação do usuário padrão.   

            //Define que se o Perfil não for informado, o valor padrão será jogador
            modelBuilder.Entity<Usuario>().Property(u => u.Perfil).HasDefaultValue("Jogador");
        }//Fim do método OnModelCreating
    }
}
