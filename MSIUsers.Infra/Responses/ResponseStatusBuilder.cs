namespace MSIUsers.Infra.Responses;
public static class ResponseStatusBuilder
{
    public static int BuilderStatus(this ResponseBase response)
    {
        if(response.HasNotifications) return 400;
        else if(!response.HasContent) return 204;
        else return response.StatusDefault;
    }
}