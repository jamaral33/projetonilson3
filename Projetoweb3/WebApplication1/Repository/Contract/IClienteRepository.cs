using System.Threading.Tasks;
using WebApplication1.Models;
using X.PagedList;

namespace AppLoginAspCore.Repositories.Contract
{
    public interface IClienteRepository
    {
        // Login Cliente
        Cliente Login(string Email, string Senha);

        //CRUD
        void Cadastrar(Cliente cliente);

        void Atualizar(Cliente cliente);

        void Excluir(int Id);

        Cliente ObterCliente(int Id);

        IEnumerable<Cliente> ObterTodosClientes();

         IPagedList<Cliente> ObterTodosClientes(int? pagina, string pesquisa);
    }
}