using System.ComponentModel.DataAnnotations;

namespace Revisao_Prova_EX2.Models
{
    public class Projeto
    {
        [Required] // Nome obrigatório
        [StringLength(50, MinimumLength = 3)] // Entre 3 e 50 caracteres
        public string NomeProjeto { get; set; }

        [Required] // Email obrigatório
        [EmailAddress] // Validação de e-mail
        public string Email { get; set; }

        [Required] // Turma obrigatória
        [Range(1, 8)] // Turma entre 1 e 8
        public int Turma { get; set; }

        [Required] // Descrição obrigatória
        [StringLength(500)] // Máximo 500 caracteres
        public string DescricaoProjeto { get; set; }

        [Required] // Número obrigatório
        [Range(10, 99)] // Número entre 10 e 99
        public int NumeroProjeto { get; set; }
    }
}
