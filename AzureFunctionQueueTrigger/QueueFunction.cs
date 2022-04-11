using Microsoft.Azure.Storage.Queue;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AzureFunctionQueueTrigger
{
    public class QueueFunction
    {
        [FunctionName("ListenTheQueueString")]
        public void ListenTheQueueString([QueueTrigger("myqueue", Connection = "AzureLocalStorageConnectionString")] string myQueueItem, ILogger log)
        {
            log.LogInformation($"String Queue : {myQueueItem}");
        }

        [FunctionName("ListenTheQueueCustomer")]
        public void ListenTheQueueCustomer([QueueTrigger("myqueue", Connection = "AzureLocalStorageConnectionString")] Customer customer, ILogger log)
        {
            log.LogInformation($"Customer Queue : {customer.FullName}");
        }

        [FunctionName("ListenTheCloudQueue")]
        public void ListenTheCloudQueue([QueueTrigger("myqueue", Connection = "AzureLocalStorageConnectionString")] CloudQueueMessage cloudQueueMessage, ILogger log)
        {
            log.LogInformation($"CloudQueueMessage Queue : {cloudQueueMessage.AsString}");
        }
    }
}
