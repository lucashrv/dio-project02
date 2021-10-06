using dio_avanade_project02.InputModel;
using dio_avanade_project02.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dio_avanade_project02.Services
{
    public interface IJogoService : IDisposable
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade);
        Task<JogoViewModel> Obter(Guid id);
        Task<JogoViewModel> Inserir(JogoInputModel jogo);
        Task Atualizar(Guid id, JogoInputModel jogo);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid id);
    }
}
