using System.ComponentModel.DataAnnotations;

namespace ClienteAPI.Models
{
    public class TiposDocumentos
    {
        [Key]
        public int ID { get; set; }
        public string Descripcion { get; set; } = string.Empty;
    }
}