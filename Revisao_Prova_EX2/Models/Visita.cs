using System.ComponentModel.DataAnnotations;

namespace Revisao_Prova_EX2.Models
{
    public class Visita
    {
        [Required] // RA obrigatório
        public string RaAluno { get; set; }

        [Required] // Data obrigatória
        public DateTime DataVisita { get; set; }

        [Required] // Número do projeto obrigatório
        public int NumeroProjeto { get; set; }

        [Required] // Nota obrigatória
        [Range(0, 5)] // Nota entre 0 e 5
        public int Nota { get; set; }
    }
}
