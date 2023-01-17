using MediatR;
using MSIUsers.Application.Models.Responses;

namespace MSIUsers.Application.Models.Requests;
public class AddSolicitacaoRequest : IRequest<AddSolicitacaoResponse>
{
    public string? Email { get; set; }
}