using Revisao_Prova_EX2.Models;

namespace Revisao_Prova_EX2.Repositories
{
    public interface IVisitaRepository
    {
        void Registrar(Visita visita); // Registra visita
        List<Visita> ConsultarPorProjeto(int numeroProjeto); // Consulta visitas de um projeto
    }
}
