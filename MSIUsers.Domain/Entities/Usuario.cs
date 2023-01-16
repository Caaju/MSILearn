namespace MSIUsers.Domain.Entities;
public class Usuario
{
    public string? Id { get; set; }
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public string? Senha { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime? DataAtivacao { get; set; }
    public DateTime? DataInativacao { get; set; }
    public Guid SolicitacaoId { get; set; }
}