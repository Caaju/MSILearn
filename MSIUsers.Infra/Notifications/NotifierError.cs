using MSIUsers.Infra.Notifications.Enums;
using MSIUsers.Infra.Notifications.ValueObjects;

namespace MSIUsers.Infra.Notifications;
public sealed class NotifierError : Notifier
{
    public override ICollection<NoteBase> GetNotification()
    {
        return this._notifications
        .Where(note => note.NoteType.Equals(NoteType.Error))
        .ToHashSet();
    }

    public static NoteError CreateNotification(string note)
    {
        return new NoteError(note);
    }
}