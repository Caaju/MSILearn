namespace MSIUsers.Infra.Validations;
public interface IValidator
{
    bool IsValid { get; }
    void Validate();
}