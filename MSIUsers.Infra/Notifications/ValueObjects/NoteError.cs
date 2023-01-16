using MSIUsers.Infra.Notifications.Enums;

namespace MSIUsers.Infra.Notifications.ValueObjects;
public class NoteError : NoteBase
{
    public NoteError(string? note) : base(NoteType.Error, note)
    {
    }
}