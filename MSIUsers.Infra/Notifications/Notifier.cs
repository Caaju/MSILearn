using MSIUsers.Infra.Extensions.Notifications;
using MSIUsers.Infra.Notifications.Enums;
using MSIUsers.Infra.Notifications.ValueObjects;

namespace MSIUsers.Infra.Notifications;
public abstract class Notifier
{
    private readonly ICollection<NoteBase> notifications;
    public Notifier()
    {
        notifications = new HashSet<NoteBase>();
    }
    public void AddNotification(NoteBase note)
    {
        this.notifications.Add(note);
    }

    public bool ExistNoteError()
    {
        return notifications.Any(n => n.NoteType.Equals(NoteType.Error));
    }
    public bool HasNotifications => this.notifications.Any();
    public ICollection<NoteBase> Notifications => notifications;
    public void Notify(string note, NoteType noteType)
    {
        if(noteType==NoteType.Warnning)
            this.AddWarningNote("E-mail não informado.");
    }
}