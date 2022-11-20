using estudiante20190487.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace estudiante20190487.Data.Context;

public class Estudiante20190487DbContext:DbContext

{

     public Estudiante20190487DbContext(DbContextOptions options):base(options)

     {

     }


     public virtual DbSet<estudiante> Productos {get; set;} = null!;

     
    
    
}
public interface Estudiante20190487{
    public  DbSet<estudiante> Productos {get; set;} 
}

