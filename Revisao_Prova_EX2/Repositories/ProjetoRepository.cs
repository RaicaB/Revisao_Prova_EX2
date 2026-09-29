using Revisao_Prova_EX2.Models;
using Revisao_Prova_EX2.Repositories;

namespace Revisao_Prova_EX2.Repositories

{
    public class ProjetoRepository : IProjetoRepository
    {
        private static List<Projeto> projetos = new List<Projeto>(); // Lista em memória

        public void Adicionar(Projeto projeto)
        {
            // Regra de negócio: não permitir número duplicado
            if (projetos.Any(p => p.NumeroProjeto == projeto.NumeroProjeto))
                throw new System.Exception("Já existe projeto com este número!");

            projetos.Add(projeto); // Adiciona projeto
        }

        public List<Projeto> Listar()
        {
            return projetos; // Retorna todos os projetos
        }

        public Projeto BuscarPorNumero(int numero)
        {
            return projetos.FirstOrDefault(p => p.NumeroProjeto == numero); // Busca projeto pelo número
        }
    }
}
