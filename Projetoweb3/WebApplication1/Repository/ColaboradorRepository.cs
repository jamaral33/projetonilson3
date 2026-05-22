using MySql.Data.MySqlClient;
using System.Data;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class ColaboradorRepository : IColaboradorRepository
    {

        private readonly string _conexaoMySql;

        public ColaboradorRepository(IConfiguration conf)
        {
            _conexaoMySql = conf.GetConnectionString("ConexaoMySql");
        }

        public void Atualizar(Colaborador colaborador)
        {
            throw new NotImplementedException();
        }

        public void AtualizaSenha(Colaborador colaborador)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Colaborador colaborador)
        {

            string comum = ColaboradorTipoConstant.Comum;

            using (var conexao = new MySqlConnection(_conexaoMySql))
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "insert into Colaborador(Nome, CPF, Telefone, Email, Senha, Tipo) " +
                    " values (@Nome, @CPF, @Telefone, @Email, @Senha, @Tipo)",
                    conexao
                );

                cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = colaborador.Nome;
                cmd.Parameters.Add("@CPF", MySqlDbType.VarChar).Value = colaborador.CPF;
                cmd.Parameters.Add("@Telefone", MySqlDbType.VarChar).Value = colaborador.Telefone;
                cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = colaborador.Email;
                cmd.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = colaborador.Senha;

                cmd.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public void Excluir(int Id)
        {
            throw new NotImplementedException();
        }

        public Colaborador Login(string Email, string Senha)
        {
            using (var conexao = new MySqlConnection(_conexaoMySql))
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "select * from Colaborador where Email = @Email and Senha = @Senha",
                    conexao
                );

                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
                cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = Senha;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                MySqlDataReader dr;

                Colaborador colaborador = new Colaborador();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    colaborador.Id = (Int32)(dr["Id"]);
                    colaborador.Nome = (string)(dr["Nome"]);
                    colaborador.Email = (string)(dr["Email"]);
                    colaborador.Senha = (string)(dr["Senha"]);
                    colaborador.Tipo = (string)(dr["tipo"]);
                }

                return colaborador;
            }
        }

        public Colaborador ObterColaborador(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Colaborador> ObterColaboradorPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Colaborador> ObterTodosColaboradores()
        {
            throw new NotImplementedException();
        }

        public IPagedList<Colaborador> ObterTodosColaboradores(int? pagina)
        {
            throw new NotImplementedException();
        }
    }
}
