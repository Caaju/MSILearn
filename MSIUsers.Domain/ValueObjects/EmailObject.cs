namespace MSIUsers.Domain.ValueObjects;
public class EmailObject
{
    private readonly string? value;
    public string? Value => value;
    public EmailObject(string? value)
    {
        this.value = value;
    }
}