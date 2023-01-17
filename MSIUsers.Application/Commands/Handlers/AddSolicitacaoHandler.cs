using MediatR;
using MSIUsers.Application.Models.Requests;
using MSIUsers.Application.Models.Responses;
using MSIUsers.Application.Validations;
using MSIUsers.Domain.Commands.Handlers;
using MSIUsers.Infra.Notifications;
using MSIUsers.Infra.Responses;

namespace MSIUsers.Application.Commands.Handlers;
public class AddSolicitacaoHandler : Notifier, IAddSolicitacaoHandler, IRequestHandler<AddSolicitacaoRequest, AddSolicitacaoResponse>
{
    public async Task<AddSolicitacaoResponse> Handle(AddSolicitacaoRequest request, CancellationToken cancellationToken)
    {
        var  response=new AddSolicitacaoResponse();

        var validator = new AddSolicitacaoValidator(request.Email, this);
        validator.Validate();

        if(validator.IsValid)
        {
            response.Builder(this.Notifications);
        }

        return await Task.FromResult<AddSolicitacaoResponse>(response);
    }
}