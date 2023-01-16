using MSIUsers.Infra.Notifications.Enums;

namespace MSIUsers.Infra.Notifications.ValueObjects;
public abstract class NoteBase
{
   private readonly NoteType _noteType;
   private readonly string? _note;

    protected NoteBase(NoteType noteType, string? note)
    {
        _noteType = noteType;
        _note = note;
    }

    public NoteType NoteType => _noteType;

    public string? Note => _note;
}