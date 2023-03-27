using Azure.Storage.Blobs;

namespace Ecomm.Helper
{
    public static class FileHelper
    {
        public static async Task<string> UploadImage(IFormFile file)
        {
            string connectionString = @"DefaultEndpointsProtocol=https;AccountName=employeeaccountstroge;AccountKey=ReuHj/1wj+91+JokuDHuyYdYmuRmQolqVUWPUOw+SohqXwem0RQF5UtyMdHiSJBQtpABF0n1hW4s+AStSpVG8A==;EndpointSuffix=core.windows.net";
            string containerName = "bookphotos";
            BlobContainerClient containerClient = new BlobContainerClient(connectionString, containerName);
            BlobClient blobClient = containerClient.GetBlobClient(file.FileName);
            MemoryStream ms = new MemoryStream();
            await file.CopyToAsync(ms);
            ms.Position = 0;
            await blobClient.UploadAsync(ms);
            return blobClient.Uri.AbsoluteUri;
   
        }
        public static async Task<string> UploadUrl(IFormFile file)
        {
            string connectionString = @"DefaultEndpointsProtocol=https;AccountName=employeeaccountstroge;AccountKey=ReuHj/1wj+91+JokuDHuyYdYmuRmQolqVUWPUOw+SohqXwem0RQF5UtyMdHiSJBQtpABF0n1hW4s+AStSpVG8A==;EndpointSuffix=core.windows.net";
            string containerName = "bookurl";
            BlobContainerClient containerClient = new BlobContainerClient(connectionString, containerName);
            BlobClient blobClient = containerClient.GetBlobClient(file.FileName);
            MemoryStream ms = new MemoryStream();
            await file.CopyToAsync(ms);
            ms.Position = 0;
            await blobClient.UploadAsync(ms);
            return blobClient.Uri.AbsoluteUri;

        }
    }
}
