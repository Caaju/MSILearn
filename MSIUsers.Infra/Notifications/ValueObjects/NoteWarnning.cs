using MSIUsers.Infra.Notifications.Enums;

namespace MSIUsers.Infra.Notifications.ValueObjects;

public class NoteWarnning : NoteBase
{
    public NoteWarnning(string? note) : base(NoteType.Warnning, note)
    {
    }
}