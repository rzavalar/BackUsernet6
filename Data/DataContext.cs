namespace BackUsernet6.Data
{
    public class DataContext
    {
        public DataContext(DbContextOptions<DataContext> options):base (options)
        {
            
        }

        //Pluralisar nombre de entidad
        public DbSet<Users> User{get;set;}

    }
}