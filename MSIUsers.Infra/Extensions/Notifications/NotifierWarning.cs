using MSIUsers.Infra.Notifications;
using MSIUsers.Infra.Notifications.Enums;
using MSIUsers.Infra.Notifications.ValueObjects;

namespace MSIUsers.Infra.Extensions.Notifications;
public static class NotifierWarning
{
    public static ICollection<string> GetWarningNotification(this Notifier notifier)
    {
        return notifier
                .Notifications
                .Where(note => note.NoteType.Equals(NoteType.Warnning))
                .Select(note => note.Note)
            .ToHashSet<string>();
    }
    public static void AddWarningNote(this Notifier notifier, string note)
    {
        notifier.AddNotification(new NoteWarnning(note));
    }
}