using Revisao_Prova_EX2.Models;
using Revisao_Prova_EX2.Repositories;

namespace Revisao_Prova_EX2.Repositories
{ 

    public class VisitaRepository : IVisitaRepository
    {
        private static List<Visita> visitas = new List<Visita>(); // Lista em memória

        public void Registrar(Visita visita)
        {
            visitas.Add(visita); // Adiciona visita
        }

        public List<Visita> ConsultarPorProjeto(int numeroProjeto)
        {
            // Filtra visitas pelo número do projeto
            return visitas.Where(v => v.NumeroProjeto == numeroProjeto).ToList();
        }
    }
}
