using MSIUsers.Domain.Entities;

namespace MSIUsers.Domain.Repositories;
public interface ISolicitacaoRepository
{
    void Add(Solicitacao solicitacao);
}