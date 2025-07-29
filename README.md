# Genspark Azure Development Repository

## Overview

This repository contains three Azure-focused projects demonstrating practical implementations of core Azure services. Each project is designed to showcase different Azure capabilities and serves as learning material for Azure development and AZ-204 certification preparation.

## Repository Structure

```
Genspark/
├── az204-blob/           # Azure Blob Storage demonstration
├── az204-cosmos/         # Azure Cosmos DB implementation
├── Fucctions/           # Azure Functions project
└── README.md           # This documentation file
```

## Projects

### 1. Azure Blob Storage Project (`az204-blob/`)

**Purpose**: Demonstrates Azure Blob Storage operations including container management, file upload/download, and cleanup operations.

**Technology Stack**:
- .NET 7.0
- Azure.Storage.Blobs SDK

**Key Features**:
- Create blob containers with unique names
- Upload files to blob storage
- List blobs in containers
- Download files from blob storage
- Automatic cleanup of resources

**Main Operations**:
1. **Container Creation**: Creates a new container with a GUID-based unique name
2. **File Upload**: Creates and uploads a test file to the container
3. **Blob Listing**: Enumerates all blobs within the container
4. **File Download**: Downloads the uploaded file to a local path
5. **Resource Cleanup**: Removes containers and temporary files

### 2. Azure Cosmos DB Project (`az204-cosmos/`)

**Purpose**: Demonstrates Azure Cosmos DB setup and basic database operations using the SQL API.

**Technology Stack**:
- .NET 8.0
- Microsoft.Azure.Cosmos SDK

**Key Features**:
- Cosmos DB client initialization
- Database creation with conditional logic
- Container creation with partition key configuration
- Error handling for Cosmos DB operations

**Main Operations**:
1. **Client Setup**: Initializes CosmosClient with endpoint and primary key
2. **Database Creation**: Creates database if it doesn't exist
3. **Container Setup**: Creates container with `/LastName` partition key
4. **Error Handling**: Comprehensive exception handling for Cosmos operations

### 3. Azure Functions Project (`Fucctions/`)

**Purpose**: Demonstrates Azure Functions implementation using the isolated worker model with HTTP triggers.

**Technology Stack**:
- .NET 8.0
- Azure Functions v4
- ASP.NET Core integration

**Key Features**:
- HTTP-triggered Azure Function
- Anonymous authorization level
- Logging integration
- Modern isolated worker model

**Function Details**:
- **Function Name**: `myfunctionmiller`
- **Trigger Type**: HTTP (GET/POST)
- **Authorization**: Anonymous
- **Response**: Returns welcome message

## Prerequisites

### Development Environment
- .NET 8.0 SDK (for Cosmos DB and Functions projects)
- .NET 7.0 SDK (for Blob Storage project)
- Visual Studio Code or Visual Studio
- Azure CLI (optional, for deployment)

### Azure Resources Required
1. **Azure Storage Account** (for blob project)
2. **Azure Cosmos DB Account** (for cosmos project)
3. **Azure Functions App** (for functions project)

## Configuration

### Azure Blob Storage
Update the connection string in `az204-blob/Program.cs`:
```csharp
string storageConnectionString = "YOUR_STORAGE_CONNECTION_STRING";
```

### Azure Cosmos DB
Update the endpoint and key in `az204-cosmos/Program.cs`:
```csharp
private static readonly string EndpointUri = "YOUR_COSMOS_ENDPOINT";
private static readonly string PrimaryKey = "YOUR_COSMOS_KEY";
```

## Running the Projects

### Azure Blob Storage
```bash
cd az204-blob
dotnet run
```

### Azure Cosmos DB
```bash
cd az204-cosmos
dotnet run
```

### Azure Functions
```bash
cd Fucctions
dotnet run
```
The function will be available at: `http://localhost:7237/api/myfunctionmiller`

## Project Dependencies

### az204-blob
- No external NuGet packages explicitly defined
- Uses Azure.Storage.Blobs (likely added via implicit references)

### az204-cosmos
- Microsoft.Azure.Cosmos (implicitly referenced)

### Fucctions (Azure Functions)
- Microsoft.Azure.Functions.Worker (v2.0.0)
- Microsoft.Azure.Functions.Worker.Extensions.Http.AspNetCore (v2.0.0)
- Microsoft.Azure.Functions.Worker.Sdk (v2.0.0)

## Security Considerations

⚠️ **Important Security Notes**:

1. **Exposed Credentials**: The repository contains hardcoded connection strings and keys in source code. In production:
   - Use Azure Key Vault for secrets management
   - Implement managed identities where possible
   - Use environment variables for configuration

2. **Best Practices**:
   - Rotate keys regularly
   - Use least privilege access principles
   - Enable Azure Security Center recommendations

## Learning Objectives

This repository addresses key AZ-204 exam objectives:

### Develop Azure compute solutions
- ✅ Implement Azure Functions

### Develop for Azure storage
- ✅ Develop solutions that use Cosmos DB storage
- ✅ Develop solutions that use blob storage

### Implement Azure security
- 🔄 Authentication and authorization (to be implemented)
- 🔄 Secure data solutions (to be enhanced)

## Future Enhancements

### Recommended Improvements
1. **Security**:
   - Implement Azure Key Vault integration
   - Add managed identity authentication
   - Remove hardcoded credentials

2. **Functionality**:
   - Add CRUD operations for Cosmos DB
   - Implement blob metadata management
   - Add more Azure Functions triggers (Timer, Queue, etc.)

3. **Architecture**:
   - Add dependency injection
   - Implement configuration patterns
   - Add unit tests

4. **Deployment**:
   - Add ARM templates or Bicep files
   - Implement CI/CD pipelines
   - Add environment-specific configurations

## Troubleshooting

### Common Issues

1. **Connection String Errors**:
   - Verify Azure resource endpoints
   - Check access keys and permissions
   - Ensure firewall rules allow connections

2. **Package Restore Issues**:
   ```bash
   dotnet restore
   ```

3. **Function Runtime Issues**:
   - Verify Azure Functions Core Tools installation
   - Check port availability (default: 7237)

## Resources

### Documentation
- [Azure Blob Storage Documentation](https://docs.microsoft.com/azure/storage/blobs/)
- [Azure Cosmos DB Documentation](https://docs.microsoft.com/azure/cosmos-db/)
- [Azure Functions Documentation](https://docs.microsoft.com/azure/azure-functions/)

### AZ-204 Preparation
- [AZ-204 Study Guide](https://docs.microsoft.com/certifications/exams/az-204)
- [Azure Developer Learning Path](https://docs.microsoft.com/learn/paths/create-serverless-applications/)

## Contributing

When contributing to this repository:
1. Follow .NET coding conventions
2. Remove any hardcoded credentials before committing
3. Add appropriate error handling
4. Update documentation for new features

## License

This project is for educational purposes and learning Azure development concepts.

---

*Last Updated: July 29, 2025*
*Repository: Genspark Azure Development Examples*
