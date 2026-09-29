using System.Collections.Generic;
using Revisao_Prova_EX2.Models;

namespace Revisao_Prova_EX2.Repositories
{
    public interface IProjetoRepository
    {
        void Adicionar(Projeto projeto); // Adiciona projeto
        List<Projeto> Listar(); // Lista todos os projetos
        Projeto BuscarPorNumero(int numero); // Busca projeto pelo número
    }
}