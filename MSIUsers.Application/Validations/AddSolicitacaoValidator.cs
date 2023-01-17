using MSIUsers.Domain.ValueObjects;
using MSIUsers.Infra.Notifications;
using MSIUsers.Infra.Notifications.Enums;
using MSIUsers.Infra.Validations;
using MSIUsers.Infra.Validations.ObjectValidator;

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
        if (string.IsNullOrEmpty(this.email)) this.notifier.Notify("E-mail não informado.",NoteType.Warnning);
        else ValidarEmail(new EmailObject(this.email));
    }

    private void ValidarEmail(EmailObject email)
    {
        var validator=new EmailObjectValidator(email,this.notifier);
        validator.Validate();
    }
}