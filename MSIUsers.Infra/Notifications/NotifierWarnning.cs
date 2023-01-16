using MSIUsers.Infra.Notifications.Enums;
using MSIUsers.Infra.Notifications.ValueObjects;

namespace MSIUsers.Infra.Notifications;
public sealed class NotifierWarnning : Notifier
{
    public override ICollection<NoteBase> GetNotification()
    {
        return this._notifications
        .Where(note => note.NoteType.Equals(NoteType.Warnning))
        .ToHashSet();
    }

    public static NoteWarnning CreateNotification(string note)
    {
        return new NoteWarnning(note);
    }
}