namespace MSIUsers.Domain.Entities;
public class Solicitacao
{
    public string? Id { get; set; }
    public Guid SolicitacaoId { get; set; }
    public string? Email { get; set; }
    public string? Senha { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime? DataExpiracao { get; set; }
    public DateTime? DataAtivacao { get; set; }
}