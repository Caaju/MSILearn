using MSIUsers.Infra.Notifications.Enums;
using MSIUsers.Infra.Notifications.ValueObjects;

namespace MSIUsers.Infra.Notifications;
public abstract class Notifier
{
    protected readonly ICollection<NoteBase> _notifications;
    public Notifier()
    {
        _notifications = new HashSet<NoteBase>();
    }
    public void AddNotification(NoteBase note)
    {
        this._notifications.Add(note);
    }

    public bool ExistNoteError()
    {
        return _notifications.Any(n => n.NoteType.Equals(NoteType.Error));
    }

    public virtual ICollection<NoteBase> GetNotification()
    {
        throw new NotImplementedException("Implementação deve estar na classe concreta");
    }
    
}