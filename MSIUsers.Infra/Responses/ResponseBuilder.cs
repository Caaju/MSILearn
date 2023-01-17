using MSIUsers.Infra.Notifications;

namespace MSIUsers.Infra.Responses;
public static class ResponseBuilder
{
    public static void Builder<TResponse>(this TResponse response, ICollection<string> notifications)
    where TResponse : ResponseBase
    {
        response.SetNotifications(notifications);
    }

    public static void Builder<TResponse>(this TResponse response, object content)
    where TResponse : ResponseBase
    {
        response.SetContent(content);
    }
}