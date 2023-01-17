namespace MSIUsers.Infra.Validations;
public interface ICustomValidator
{
    bool IsValid { get; }
    void Validate();
}