﻿//--------------------------------------------------------------------------------- 
// <copyright file="Program.cs" company="Microsoft">
// Microsoft (R)  Azure SDK 
// Software Development Kit 
//  
// Copyright (c) Microsoft Corporation. All rights reserved.   
// 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND,  
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES  
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.  
// </copyright>
//---------------------------------------------------------------------------------

namespace DocumentDB.GetStarted
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;
    using Microsoft.Azure.Documents;
    using Microsoft.Azure.Documents.Client;
    using Newtonsoft.Json;
    using SmartMonitoring.Framework.DocumentDB;
    using SmartMonitoring.Framework.Models.Core;
    using System.Collections;
    using System.Collections.Generic;
       using System.Linq.Expressions;
    /// <summary>
    /// This GetStarted sample demonstrates the creation of resources and execution of simple queries.  
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "For illustration purposes.")]
    public class Program
    {
        /// <summary>
        /// The Azure DocumentDB endpoint for running this GetStarted sample.
        /// </summary>
        private const string EndpointUrl = "https://localhost:8081";

        /// <summary>
        /// The primary key for the Azure DocumentDB account.
        /// </summary>
        private const string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        /// <summary>
        /// The DocumentDB client instance.
        /// </summary>
        private DocumentClient client;
        private DocumentDbRepository<Family> repDb;
        /// <summary>
        /// The main method for the demo
        /// </summary>
        /// <param name="args">Command line arguments</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting");

            try
            {
                Program p = new Program();
                p.GetStartedDemo().Wait();
            }
            catch (DocumentClientException de)
            {
                Exception baseException = de.GetBaseException();
                Console.WriteLine("{0} error occurred: {1}, Message: {2}", de.StatusCode, de.Message, baseException.Message);
            }
            catch (Exception e)
            {
                Exception baseException = e.GetBaseException();
                Console.WriteLine("Error: {0}, Message: {1}", e.Message, baseException.Message);
            }
            finally
            {
                Console.WriteLine("End of demo, press any key to exit.");
                Console.ReadKey();
            }
        }


        public string GetCollectionName()
        {
            return "FamilyCollection";
        }
        /// <summary>
        /// Run the get started demo for Azure DocumentDB. This creates a database, collection, two documents, executes a simple query 
        /// and cleans up.
        /// </summary>
        /// <returns>The Task for asynchronous completion.</returns>
        private async Task GetStartedDemo()
        {
                        // Create a new instance of the DocumentClient
                  this.client = new DocumentClient(new Uri(EndpointUrl), PrimaryKey);

            //  await this.client.CreateDatabaseIfNotExistsAsync(new Database { Id = "FamilyDB" });

            // await this.client.CreateDocumentCollectionIfNotExistsAsync(UriFactory.CreateDatabaseUri("FamilyDB"), new DocumentCollection { Id = "FamilyCollection" });

              await this.client.CreateDatabaseIfNotExistsAsync(new Database { Id = "SchoolWayzDB" });

             await this.client.CreateDocumentCollectionIfNotExistsAsync(UriFactory.CreateDatabaseUri("SchoolWayzDB"), new DocumentCollection { Id = "schoolwayz" });

            /*
            // Insert a document, here we create a Family object
            Family andersenFamily = new Family
            {
                Id = "Andersen.1",
                LastName = "Andersen",
                Parents = new Parent[]
                {
                    new Parent { FirstName = "Thomas" },
                    new Parent { FirstName = "Mary Kay" }
                },
                Children = new Child[]
                {
                    new Child
                    {
                        FirstName = "Henriette Thaulow",
                        Gender = "female",
                        Grade = 5,
                        Pets = new Pet[]
                        {
                            new Pet { GivenName = "Fluffy" }
                        }
                    }
                },
                District = "WA5",
                Address = new Address { State = "WA", County = "King", City = "Seattle" },
                IsRegistered = true
            };

            await this.CreateFamilyDocumentIfNotExists("FamilyDB", "FamilyCollection", andersenFamily);

            Family andersonFamilyDocument = await this.client.ReadDocumentAsync<Family>(UriFactory.CreateDocumentUri("FamilyDB", "FamilyCollection", andersenFamily.Id));

            Console.WriteLine("\nRead family {0}", andersonFamilyDocument.Id);

            this.WriteToConsoleAndPromptToContinue("{0}", andersonFamilyDocument);

            Family wakefieldFamily = new Family
            {
                Id = "Wakefield.7",
                LastName = "Wakefield",
                Parents = new Parent[]
                {
                    new Parent { FamilyName = "Wakefield", FirstName = "Robin" },
                    new Parent { FamilyName = "Miller", FirstName = "Ben" }
                },
                Children = new Child[]
                {
                    new Child
                    {
                        FamilyName = "Merriam",
                        FirstName = "Jesse",
                        Gender = "female",
                        Grade = 8,
                        Pets = new Pet[]
                        {
                            new Pet { GivenName = "Goofy" },
                            new Pet { GivenName = "Shadow" }
                        }
                    },
                    new Child
                    {
                        FamilyName = "Miller",
                        FirstName = "Lisa",
                        Gender = "female",
                        Grade = 1
                    }
                },
                District = "NY23",
                Address = new Address { State = "NY", County = "Manhattan", City = "NY" },
                IsRegistered = false
            };

            await this.CreateFamilyDocumentIfNotExists("FamilyDB", "FamilyCollection", wakefieldFamily);

            Family wakefieldFamilyDocument = await this.client.ReadDocumentAsync<Family>(UriFactory.CreateDocumentUri("FamilyDB", "FamilyCollection", wakefieldFamily.Id));

            Console.WriteLine("\nRead family {0}", wakefieldFamilyDocument.Id);

            this.WriteToConsoleAndPromptToContinue("{0}", wakefieldFamilyDocument);

            this.ExecuteSimpleQuery("FamilyDB", "FamilyCollection");

            */

            // Check Repositry for First and Default
            //Family obj = await repDb.FirstOrDefaultAsync(x => x.Id == "Andersen.1");

            //bool val = await this.LoadCacheFirstOrDefault(x => x.Id == "Andersen.1");



            // Activate Instance using Reflection
            Type typearg = Type.GetType("SmartMonitoring.Framework.Models.Core.Patron,SmartMonitoring.Framework.Models");
            Type genericRepositry = typeof(Repositry<>);
            Type constructedRepositry = genericRepositry.MakeGenericType(typearg);


            // IRepositry rep = (IRepositry)Activator.CreateInstance(constructedRepositry);

            Repositry<Patron> rep = new Repositry<Patron>();


            //IRepositry rep = new Repositry<Patron>();

            //bool val = await rep.LoadCacheFirstOrDefault(x => x.Id == "f2c255be-abeb-47c9-821d-aff6473b84f7");
            //var val = (await rep.Query()).Where(p => p.type.Equals("Patron")).ToList<Patron>().First();

            bool val = await rep.LoadCacheFirstOrDefault(p => p.type.Equals("Patron"));


            if (val != null)
            {
                Console.WriteLine("Executed Fine");
            }else
            {
                Console.WriteLine("Executed Bad");
            }
            // Clean up/delete the database and client
           // await this.client.DeleteDatabaseAsync(UriFactory.CreateDatabaseUri("FamilyDB"));
        }

        
        /// <summary>
        /// Create the Family document in the collection if another by the same ID doesn't already exist.
        /// </summary>
        /// <param name="databaseName">The name/ID of the database.</param>
        /// <param name="collectionName">The name/ID of the collection.</param>
        /// <param name="family">The family document to be created.</param>
        /// <returns>The Task for asynchronous execution.</returns>
        private async Task CreateFamilyDocumentIfNotExists(string databaseName, string collectionName, Family family)
        {
            try
            {
                await this.client.ReadDocumentAsync(UriFactory.CreateDocumentUri(databaseName, collectionName, family.Id));
            }
            catch (DocumentClientException de)
            {
                if (de.StatusCode == HttpStatusCode.NotFound)
                {
                    await this.client.CreateDocumentAsync(UriFactory.CreateDocumentCollectionUri(databaseName, collectionName), family);
                    this.WriteToConsoleAndPromptToContinue("\nCreated Family {0}", family.Id);
                }
                else
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Execute a simple query using LINQ and SQL. Here we filter using the "LastName" property.
        /// </summary>
        /// <param name="databaseName">The name/ID of the database.</param>
        /// <param name="collectionName">The name/ID of the collection.</param>
        private void ExecuteSimpleQuery(string databaseName, string collectionName)
        {
            // Set some common query options
            FeedOptions queryOptions = new FeedOptions { MaxItemCount = -1, EnableCrossPartitionQuery = true };

            // Run a simple query via LINQ. DocumentDB indexes all properties, so queries can be completed efficiently and with low latency.
            // Here we find the Andersen family via its LastName
            IQueryable<Family> familyQuery = this.client.CreateDocumentQuery<Family>(
                UriFactory.CreateDocumentCollectionUri(databaseName, collectionName), queryOptions)
                .Where(f => f.LastName == "Andersen");

            // The query is executed synchronously here, but can also be executed asynchronously via the IDocumentQuery<T> interface
            Console.WriteLine("\nRunning LINQ query...");
            foreach (Family family in familyQuery)
            {
                Console.WriteLine("\nRead {0}", family);
            }

            // Now execute the same query via direct SQL
            IQueryable<Family> familyQueryInSql = this.client.CreateDocumentQuery<Family>(
                UriFactory.CreateDocumentCollectionUri(databaseName, collectionName),
                "SELECT * FROM Family WHERE Family.LastName = 'Andersen'",
                queryOptions);

            Console.WriteLine("\nRunning direct SQL query...");
            foreach (Family family in familyQueryInSql)
            {
                Console.WriteLine("\nRead {0}", family);
            }

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }

        /// <summary>
        /// Write to the console, and prompt to continue.
        /// </summary>
        /// <param name="format">The string to be displayed.</param>
        /// <param name="args">Optional arguments.</param>
        private void WriteToConsoleAndPromptToContinue(string format, params object[] args)
        {
            Console.WriteLine(format, args);
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
       

        public class Family : BaseFamily
        {
            

            public string LastName { get; set; }

            public string District { get; set; }

            public Parent[] Parents { get; set; }

            public Child[] Children { get; set; }

            public Address Address { get; set; }

            public bool IsRegistered { get; set; }

            public override string ToString()
            {
                return JsonConvert.SerializeObject(this);
            }
        }

        /// <summary>
        /// A parent class used within Family
        /// </summary>
        public class Parent
        {
            public string FamilyName { get; set; }

            public string FirstName { get; set; }
        }

        /// <summary>
        /// A child class used within Family
        /// </summary>
        public class Child
        {
            public string FamilyName { get; set; }

            public string FirstName { get; set; }

            public string Gender { get; set; }

            public int Grade { get; set; }

            public Pet[] Pets { get; set; }
        }

        /// <summary>
        /// A pet class that belongs to a Child
        /// </summary>
        public class Pet
        {
            public string GivenName { get; set; }
        }

        /// <summary>
        /// An address class containing data attached to a Family.
        /// </summary>
        public class Address
        {
            public string State { get; set; }

            public string County { get; set; }

            public string City { get; set; }
        }
    }

   
    public interface IRepositry
    {
        Task<bool> LoadCacheFirstOrDefault(Func<BaseModel, bool> selector);
    }
    public interface IRepositry<TValue> : IRepositry where TValue : BaseModel
    {
        new Task<bool> LoadCacheFirstOrDefault(Func<TValue, bool> selector);
    }
    public class Repositry<TValue> : IRepositry<TValue> where TValue : BaseModel
    {
        public string GetCollectionName()
        {
            return "schoolwayz";
        }

    //     <Parameter Name = "DocumentDB.EndpointURL" Value="https://dev-schoolwayz-db.documents.azure.com:443/" />
    //<Parameter Name = "DocumentDB.AuthorizationKey" Value="UTusjz7ILvSWKZPAvzsOeeddXVnLlzjEADqxBHpd8k5QY5OpQetP1pvYuuAY5IoswMEzra2XDAAoyYp56FPChw==" />
  
        private const string EndpointUrl = "https://dev-schoolwayz-db.documents.azure.com:443/";
       // private const string EndpointUrl = "https://localhost:8081";
        /// <summary>
        /// The primary key for the Azure DocumentDB account.
        /// </summary>
        //private const string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";
        private const string PrimaryKey = "UTusjz7ILvSWKZPAvzsOeeddXVnLlzjEADqxBHpd8k5QY5OpQetP1pvYuuAY5IoswMEzra2XDAAoyYp56FPChw==";
        private DocumentClient client;
        private DocumentDbRepository<TValue> repDb;
        public Repositry()
        {



        }

        public async Task<bool> LoadDb()
        {
            this.client = new DocumentClient(new Uri(EndpointUrl), PrimaryKey);

            await this.client.CreateDatabaseIfNotExistsAsync(new Database { Id = "SchoolWayzDB" });

            await this.client.CreateDocumentCollectionIfNotExistsAsync(UriFactory.CreateDatabaseUri("SchoolWayzDB"), new DocumentCollection { Id = "schoolwayz" });


//            await this.client.CreateDatabaseIfNotExistsAsync(new Database { Id = "FamilyDB" });

  //          await this.client.CreateDocumentCollectionIfNotExistsAsync(UriFactory.CreateDatabaseUri("FamilyDB"), new DocumentCollection { Id = "FamilyCollection" });


            repDb = new DocumentDbRepository<TValue>(this.client, "SchoolWayzDB", GetCollectionName, null);

            return true;
        }
        public async Task<bool> LoadCacheFirstOrDefault(Func<TValue, bool> selector)
        {
            try
            {
                await this.LoadDb();
                bool loadflag = false;

                //TValue obj = (await repDb.WhereAsync(x => x.type.Equals("Patron"))).ToList<TValue>().First();
                TValue obj = (await repDb.FirstOrDefaultAsync(x => x.type == "Patron"));
                //IEnumerable<TValue> obj = (await repDb.FirstOrDefaultAsync(x => x.type == "Patron")).ToList();
                //TValue obj = (await repDb.QueryAsync()).Where(x => x.type.Equals("Patron")).FirstOrDefault();
                //List obj = (await this.repDb.FirstOrDefaultAsync(x => x.type == "Patron"));
                //List<TValue> obj = (await repDb.WhereAsync(x => x.type.Equals("Patron"))).ToList<TValue>();
                ////TValue obj = (await repDb.QueryAsync()).Where(x => x.type.Equals("Patron")).ToList<TValue>().First();

                //  TValue obj = (await repDb.WhereAsync(x => selector.Invoke(x))).ToList<TValue>().First();
                // TValue obj = (await repDb.WhereAsync(x => x.type.Equals("Patron"))).ToList<TValue>().First();
                if (obj != null)
                {
                    // Add to Cache without syncing with DB, becasue it's loading itself from DB

                    // mark the load flag to true;
                    loadflag = true;

                }

                return loadflag;

            }
            catch (Exception exc)
            {

                return false;
            }
        }

      

        Task<bool> IRepositry.LoadCacheFirstOrDefault(Func<BaseModel, bool> selector)
        {
            return this.LoadCacheFirstOrDefault(selector);
        }

        public async Task<IQueryable<TValue>> Query()
        {
            return await this.repDb.QueryAsync();
        }

    }


    public class BaseFamily
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }
    /// <summary>
    /// A Family class, e.g. storing census data about families within the United States. We use this data model throughout the 
    /// sample to show how you can store objects within your application logic directly as JSON within Azure DocumentDB. 
    /// </summary>
}
