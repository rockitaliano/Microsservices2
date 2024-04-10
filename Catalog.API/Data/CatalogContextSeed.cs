using Catalog.API.Entities;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct) { productCollection.InsertManyAsync(GetMyPrducts()); }
        }

        private static IEnumerable<Product> GetMyPrducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id="dosfge98qyh498frqfuqhw-f0hqwe9f",
                    Name="Xiaomi",
                    Category= "Smart Phone",
                    Description="Telefone xingling bom demais para ser chines",
                    Image = "product-1.png",
                    Price= 999.00M
                },
                new Product()
                {
                    Id= "fnqjiowpfn-943nvqnf9-3f9q3nfvqn",
                    Name="Xiaomi 11T",
                    Category="SmartPhone",
                    Description="Outro Telefone xingLink bom para jogar COD",
                    Image = "product-2.png",
                    Price = 1241.00M
                }
            };
        }
    }
}
