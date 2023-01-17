namespace MSIUsers.Infra.Responses;
public abstract class ResponseBase
{
    private readonly int statusDefault;
    public int StatusDefault => statusDefault;

    public int Status { get => this.BuilderStatus(); }
    public DateTime Dth { get => DateTime.Now; }
    private object? content;
    public object? Content { get => content; }

    private ICollection<string>? notifications;
    public ICollection<string>? Notifications { get => notifications; }

    public bool HasNotifications { get => this.notifications != null && this.notifications.Any(); }
    public bool HasContent { get => this.content != null; }
    public void SetContent(object content) => this.content = content;
    public void SetNotifications(ICollection<string> notifications) => this.notifications = notifications;

    protected ResponseBase(int statusDefault)
    {
        this.statusDefault = statusDefault;
    }
}