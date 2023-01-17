using MSIUsers.Infra.Extensions.Notifications;
using MSIUsers.Infra.Notifications;
using MSIUsers.Infra.Validations;

namespace MSIUsers.Application.Validations;
public class AddSolicitacaoValidator : ValidatorBase
{
    private readonly string? email;

    public AddSolicitacaoValidator(string? email, Notifier notifier) : base(notifier)
    {
        this.email = email;
    }

    public override void Validate()
    {
        if (string.IsNullOrEmpty(this.email)) notifier.AddWarningNote("E-mail não informado.");
    }
}