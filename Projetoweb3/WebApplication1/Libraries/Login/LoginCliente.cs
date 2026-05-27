using System.Globalization;
using Newtonsoft.Json;
using WebApplication1.Libraries.Sessao;
using WebApplication1.Models;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace WebApplication1.Libraries.Login
{
    public class LoginCliente
    {
        private String Key = "Login Cliente";
        private Sessao.Sessao _sessao;
        public LoginCliente(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }
        public void Login(Cliente cliente)
        {
            string clienteJSONString = JsonConvert.SerializeObject(cliente);
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
    }
}