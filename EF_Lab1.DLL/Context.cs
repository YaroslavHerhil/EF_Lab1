using EF_Lab1.DLL.Modules;
using Microsoft.EntityFrameworkCore;
namespace EF_Lab1.DLL
{
    public class Context : DbContext
    {
        private string _connectString => "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GameData;Integrated Security=True;Connect Timeout=30;";
        public DbSet<Game> Games { get; set; } //Unlimited games, and no games

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectString);
        }
    }
}
