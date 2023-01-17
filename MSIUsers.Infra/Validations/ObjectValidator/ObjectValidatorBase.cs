using FluentValidation;
using MSIUsers.Infra.Notifications;

namespace MSIUsers.Infra.Validations.ObjectValidator;
public abstract class ObjectValidatorBase<TObject> : AbstractValidator<TObject>, ICustomValidator
{
    protected readonly Notifier notifier;
    public ObjectValidatorBase(Notifier notifier)
    {
        this.notifier = notifier;
        SetRole();
    }
    public bool IsValid => !this.notifier.HasNotifications;
    public abstract void Validate();
    public abstract void SetRole();
}