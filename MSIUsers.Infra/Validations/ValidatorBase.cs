using MSIUsers.Infra.Notifications;

namespace MSIUsers.Infra.Validations;
public abstract class ValidatorBase : IValidator
{
    protected readonly Notifier notifier;
    public ValidatorBase(Notifier notifier)
    {
        this.notifier = notifier;
    }
    public bool IsValid => !this.notifier.HasNotifications;
    public abstract void Validate();
}