using System.ComponentModel.DataAnnotations;

namespace Pro_ResetProgra.Models
{
    public class piezas
    {
        [Key]
            public int IdPiezasMaquina {get; set;}
            [Required]
            public string pienzamaquina {get; set;}
    }
}