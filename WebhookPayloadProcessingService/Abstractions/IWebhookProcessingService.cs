namespace WebhookExample.Core.Abstractions;
public interface IWebhookProcessingService<T> where T : class
{
    public bool Process(T payload);
}
