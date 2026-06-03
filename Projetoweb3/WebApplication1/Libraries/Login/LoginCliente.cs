using System.Globalization;
using Newtonsoft.Json;
using WebApplication1.Libraries.Sessao;
using WebApplication1.Models;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace WebApplication1.Libraries.Login
{
    public class LoginCliente
    {
<<<<<<< HEAD
        private String Key = "Login.Cliente";
=======
        private String Key = "Login Cliente";
>>>>>>> 64309fa5bb016cb7f8069abf670c5af2ec60790a
        private Sessao.Sessao _sessao;
        public LoginCliente(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }
        public void Login(Cliente cliente)
        {
<<<<<<< HEAD
            //Serializar
            string clienteJSONString = JsonConvert.SerializeObject(cliente);

=======
            string clienteJSONString = JsonConvert.SerializeObject(cliente);
>>>>>>> 64309fa5bb016cb7f8069abf670c5af2ec60790a
            _sessao.Cadastrar(Key, clienteJSONString);
        }
        public Cliente GetCliente()
        {
            if (_sessao.Existe(Key))

            {
                string clienteJSONString = _sessao.Consultar(Key);
                return JsonConvert.DeserializeObject<Cliente>(clienteJSONString);
            }
            else
            {
                return null;
            }
        }
        public void Logout()
        {
            _sessao.RemoverTodos();
        }
    }
}