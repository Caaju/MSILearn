using MediatR;
using MSIUsers.Application.Models.Requests;
using MSIUsers.Domain.Commands.Handlers;
using MSIUsers.Infra.Notifications;

namespace MSIUsers.Application.Commands.Handlers;
public class AddSolicitacaoHandler : Notifier, IAddSolicitacaoHandler, IRequestHandler<AddSolicitacaoRequest>
{
    public Task<Unit> Handle(AddSolicitacaoRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}