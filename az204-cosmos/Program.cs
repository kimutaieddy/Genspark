using System;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;

class Program
{
    // Replace with your Cosmos DB values
    private static readonly string EndpointUri = "https://cosmoscarti.documents.azure.com/";
    private static readonly string PrimaryKey = "<bwIbDTUmbWBSidjPXIjAThpGsn5I2Co86sOdYHbvdcjAZA8DlEZ3VyHLaYMqa7tb4LiBmttXmiFhACDb4HvQiQ>";

    private CosmosClient cosmosClient;
    private Database database;
    private Container container;

    private string databaseId = "az204Database";
    private string containerId = "az204Container";

    public static async Task Main(string[] args)
    {
        try
        {
            Console.WriteLine("Beginning operations...\n");
            Program p = new Program();
            await p.CosmosAsync();
        }
        catch (CosmosException ex)
        {
            Console.WriteLine($"CosmosDB Error: {ex.StatusCode} - {ex.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"General Error: {e.Message}");
        }
        finally
        {
            Console.WriteLine("End of program, press any key to exit.");
            Console.ReadKey();
        }
    }

    public async Task CosmosAsync()
    {
        this.cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);

        await this.CreateDatabaseAsync();
        await this.CreateContainerAsync();
    }

    private async Task CreateDatabaseAsync()
    {
        this.database = await this.cosmosClient.CreateDatabaseIfNotExistsAsync(databaseId);
        Console.WriteLine($"Created Database: {this.database.Id}\n");
    }

    private async Task CreateContainerAsync()
    {
        this.container = await this.database.CreateContainerIfNotExistsAsync(containerId, "/LastName");
        Console.WriteLine($"Created Container: {this.container.Id}\n");
    }
}
