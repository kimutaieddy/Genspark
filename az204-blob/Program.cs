using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

Console.WriteLine("Azure Blob Storage Example\n");

await ProcessAsync();

static async Task ProcessAsync()
{
    string storageConnectionString = "YOUR_CONNECTION_STRING";

    // Create a Blob Service Client
    BlobServiceClient blobServiceClient = new BlobServiceClient(storageConnectionString);

    // Create a container
    string containerName = "testcontainer" + Guid.NewGuid().ToString();
    BlobContainerClient containerClient = await blobServiceClient.CreateBlobContainerAsync(containerName);
    Console.WriteLine($"Container '{containerName}' created.");

    // Upload a file
    string localFilePath = "testfile.txt";
    await File.WriteAllTextAsync(localFilePath, "Hello, Azure Blob Storage!");
    BlobClient blobClient = containerClient.GetBlobClient("testfile.txt");
    await blobClient.UploadAsync(File.OpenRead(localFilePath));
    Console.WriteLine("File uploaded.");

    // List blobs
    Console.WriteLine("Listing blobs:");
    await foreach (BlobItem blob in containerClient.GetBlobsAsync())
    {
        Console.WriteLine("\t" + blob.Name);
    }

    // Download the file
    string downloadedFilePath = "downloaded_testfile.txt";
    BlobDownloadInfo download = await blobClient.DownloadAsync();
    using FileStream downloadFile = File.OpenWrite(downloadedFilePath);
    await download.Content.CopyToAsync(downloadFile);
    Console.WriteLine("File downloaded.");

    // Clean up
    await containerClient.DeleteAsync();
    File.Delete(localFilePath);
    File.Delete(downloadedFilePath);
    Console.WriteLine("Cleanup completed.");
}
