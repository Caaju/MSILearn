using FluentValidation;
using MSIUsers.Domain.ValueObjects;
using MSIUsers.Infra.Notifications;
using MSIUsers.Infra.Notifications.Enums;

namespace MSIUsers.Infra.Validations.ObjectValidator;
public class EmailObjectValidator : ObjectValidatorBase<string>, ICustomValidator
{
    private readonly EmailObject email;

    public EmailObjectValidator(EmailObject email, Notifier notifier)
    : base(notifier)
    {
        this.email = email;
    }

    public override void SetRole()
    {
        RuleFor(email => email)
            .NotNull()
            .NotEmpty()
            .EmailAddress();
    }

    public override void Validate()
    {
        var result = this.Validate(this.email.Value);
        if (!result.IsValid) this.notifier.Notify("E-mail não informado.", NoteType.Warnning);
    }
}