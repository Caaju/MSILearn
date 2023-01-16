using MediatR;

namespace MSIUsers.Application.Models.Requests;
public class AddSolicitacaoRequest : IRequest
{
    public string? Email { get; set; }
}