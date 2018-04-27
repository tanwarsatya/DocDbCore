using System;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents;

namespace SmartMonitoring.Framework.DocumentDB
{
    public class DocumentDbInitializer : IDocumentDbInitializer
    {
        public IDocumentClient GetClient(string endpointUrl, string authorizationKey, ConnectionPolicy connectionPolicy = null)
        {

            ConnectionPolicy defaultPolicy = new ConnectionPolicy();
            defaultPolicy.ConnectionMode = ConnectionMode.Direct;
            defaultPolicy.ConnectionProtocol = Protocol.Tcp;

            if (string.IsNullOrWhiteSpace(endpointUrl))
                throw new ArgumentNullException("endpointUrl");

            if (string.IsNullOrWhiteSpace(authorizationKey))
                throw new ArgumentNullException("authorizationKey");

            var documentClient = new DocumentClient(new Uri(endpointUrl), authorizationKey, connectionPolicy ?? defaultPolicy);


            return (IDocumentClient)documentClient;
        }
    }
}