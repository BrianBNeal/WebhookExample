using WebhookExample.Core.Abstractions;
using WebhookExample.Core.Models;

namespace WebhookExample.Core.Services;
public class PayloadAProcessor : IWebhookProcessingService<PayloadA>
{
    public bool Process(PayloadA payload)
    {
        //do things and publish events here

        return payload != null;
    }
}
