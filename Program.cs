using CleanArchitectureExample.Application.Services;
using CleanArchitectureExample.Core.Entities;
using CleanArchitectureExample.Infrastructure.Repositories;
using System;

namespace CleanArchitectureExample.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var productRepository = new InMemoryProductRepository();
            var productService = new ProductService(productRepository);

            var product = new Product
            {
                Id = 1,
                Name = "pera",
                Price = 1m
            };

            productService.CreateProduct(product);

            var products = productService.GetAllProducts();

            Console.WriteLine("Products in the repository:");
            foreach (var p in products)
            {
                Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Price: {p.Price}");
            }
        }
    }
}