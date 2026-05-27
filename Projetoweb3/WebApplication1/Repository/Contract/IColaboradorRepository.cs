using WebApplication1.Models;
using X.PagedList;

public interface IColaboradorRepository
{
    Colaborador Login(string Email, string Senha);

    void Cadastrar(Colaborador colaborador);

    void Atualizar(Colaborador colaborador);

    void AtualizaSenha(Colaborador colaborador);

    void Excluir(int Id);

    Colaborador ObterColaborador(int Id);

    List<Colaborador> ObterColaboradorPorEmail(string email);

    IEnumerable<Colaborador> ObterTodosColaboradores();

    IPagedList<Colaborador> ObterTodosColaboradores(int? pagina);
}

