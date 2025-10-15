# Genspark Repository Brief

## Quick Overview

The **Genspark** repository is an educational collection of Azure development projects focused on practical implementations of core Microsoft Azure services. It serves as hands-on learning material for developers preparing for the **AZ-204: Developing Solutions for Microsoft Azure** certification.

## Purpose

This repository demonstrates real-world Azure development patterns and provides working examples of:
- Cloud storage solutions with Azure Blob Storage
- NoSQL database operations with Azure Cosmos DB  
- Serverless computing with Azure Functions

## What's Inside

The repository contains **three standalone .NET projects**, each targeting a specific Azure service:

### 1. Azure Blob Storage (`az204-blob/`)
- Upload, download, and manage files in Azure Blob Storage
- Container lifecycle management
- .NET 7.0 with Azure.Storage.Blobs SDK

### 2. Azure Cosmos DB (`az204-cosmos/`)
- Connect to and configure Azure Cosmos DB
- Database and container provisioning
- Partition key implementation with SQL API
- .NET 8.0 with Microsoft.Azure.Cosmos SDK

### 3. Azure Functions (`Fucctions/`)
- HTTP-triggered serverless function
- Modern isolated worker model
- ASP.NET Core integration
- .NET 8.0 with Azure Functions v4

## Technology Stack

- **Languages**: C# (.NET 7.0 & 8.0)
- **Cloud Platform**: Microsoft Azure
- **Key SDKs**: Azure.Storage.Blobs, Microsoft.Azure.Cosmos, Azure.Functions.Worker
- **Development Tools**: Visual Studio Code, Azure CLI

## Quick Start

Each project can be run independently:

```bash
# Run Azure Blob Storage demo
cd az204-blob && dotnet run

# Run Azure Cosmos DB demo  
cd az204-cosmos && dotnet run

# Run Azure Functions locally
cd Fucctions && dotnet run
# Access at: http://localhost:7237/api/myfunctionmiller
```

**Note**: Azure credentials and connection strings must be configured before running (see README.md for details).

## Target Audience

- Azure developers learning cloud development patterns
- Students preparing for AZ-204 certification
- Developers exploring Azure PaaS services
- Teams seeking reference implementations of Azure services

## Security Note

⚠️ This repository contains **example/demo code** with hardcoded credentials for educational purposes. These should **never** be used in production. For production deployments:
- Use Azure Key Vault for secrets management
- Implement managed identities
- Follow Azure security best practices

## Learning Alignment

This repository covers key AZ-204 exam domains:
- ✅ Develop Azure compute solutions (Azure Functions)
- ✅ Develop for Azure storage (Blob Storage, Cosmos DB)
- 🔄 Implement Azure security (to be enhanced)

## Next Steps

1. Review the comprehensive [README.md](README.md) for detailed documentation
2. Set up Azure resources (Storage Account, Cosmos DB, Functions App)
3. Configure connection strings in each project
4. Run projects locally to understand Azure service interactions
5. Explore code implementations and Azure SDK usage patterns

## Contributing

Contributions are welcome! Please follow .NET coding conventions, remove hardcoded credentials, and update documentation for any new features.

---

**Repository**: Genspark Azure Development Examples  
**License**: Educational purposes  
**Last Updated**: October 2025
