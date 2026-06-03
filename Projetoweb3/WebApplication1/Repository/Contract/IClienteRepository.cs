using System.Threading.Tasks;
<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
=======
>>>>>>> 64309fa5bb016cb7f8069abf670c5af2ec60790a
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