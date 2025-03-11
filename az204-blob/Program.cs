using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

Console.WriteLine("Azure Blob Storage exercise\n");

// Run the examples asynchronously, wait for the results before proceeding
ProcessAsync().GetAwaiter().GetResult();

Console.WriteLine("Press enter to exit the sample application.");
Console.ReadLine();

static async Task ProcessAsync()
{
    // Copy the connection string from the portal in the variable below.
    string storageConnectionString = "DefaultEndpointsProtocol=https;AccountName=angleblobstorage;AccountKey=26SUk4HIS4xyEHXSIwGgTsOJBUQt6sG6YJl5zWdGMb5nHqBiIbT5mOZmQSsYuNLt5Sk22iYf9dcH+AStG770YA==;EndpointSuffix=core.windows.net";

    // Create a client that can authenticate with a connection string
    BlobServiceClient blobServiceClient = new BlobServiceClient(storageConnectionString);

    // COPY EXAMPLE CODE BELOW HERE

}