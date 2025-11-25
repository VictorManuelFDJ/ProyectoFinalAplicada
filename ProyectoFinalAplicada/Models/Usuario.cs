using System.ComponentModel.DataAnnotations;

namespace ProyectoFinalAplicada.Models;

public class Usuario
{
    [Key]
    public int UsuarioId {  get; set; }

    [Required]
    public string Nombre { get; set; }
    [Required]
    public string Clave { get; set; }
    [Required]
    public string Rol { get; set; }




}
