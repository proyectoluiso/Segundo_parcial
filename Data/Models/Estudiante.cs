namespace estudiante20190487.Data.Models;
using System.ComponentModel.DataAnnotations;
public class estudiante

{
   [Key]
   public string? estudianteID {get;set;} 
   public string? nombre {get;set;} 

public string? apellido {get;set;} 

public string? fechanacimiento {get;set;} 

public string? matricula {get;set;} 
public string? carrera {get;set;} 

}
