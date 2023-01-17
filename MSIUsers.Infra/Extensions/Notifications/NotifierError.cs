using MSIUsers.Infra.Notifications;
using MSIUsers.Infra.Notifications.Enums;
using MSIUsers.Infra.Notifications.ValueObjects;

namespace MSIUsers.Infra.Extensions.Notifications;
public static class NotifierError
{
    public static ICollection<string> GetErrorNotification(this Notifier notifier)
    {
        return notifier
                .Notifications
                .Where(note => note.NoteType.Equals(NoteType.Error))
                .Select(note => note.Note)
            .ToHashSet<string>();
    }
    public static void AddErrorNote(this Notifier notifier, string note)
    {
        notifier.AddNotification(new NoteError(note));
    }
}