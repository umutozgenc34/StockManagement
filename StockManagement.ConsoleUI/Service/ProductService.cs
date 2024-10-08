﻿using StockManagement.ConsoleUI.Data;
using StockManagement.ConsoleUI.Models;
using StockManagement.ConsoleUI.Models.Dtos;

namespace StockManagement.ConsoleUI.Service;

public class ProductService
{
    ProductData productData = new ProductData();

    CategoryService categoryService = new CategoryService();

    public void GetAll()
    {
        List<Product> products = productData.GetAll();

        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
    }

    public void GetById(Guid id)
    {
        Product? product = productData.GetById(id);

        if (product is null)
        {
            Console.WriteLine($"Aradığınız Id ye göre ürün bulunamadı :{id}");
            return;
        }

        Console.WriteLine(product);
    }

    public void TotalProductPriceSum()
    {
        double total = productData.TotalProductPriceSum();
        Console.WriteLine($"Ürünlerin Fiyat toplamı : {total}");
    }

    public void GetAllPriceRange(double min, double max)
    {
        List<Product> filteredData = productData.GetAllPriceRange(min, max);

        foreach (Product product in filteredData)
        {
            Console.WriteLine(product);
        }
    }

    public void GetAllProductNameContains(string text)
    {
        List<Product> filteredProduct = productData.GetAllProductNameContains(text);

        foreach (Product product in filteredProduct)
        {
            Console.WriteLine(product);
        }
    }

    public void Delete(Guid id)
    {
        Product? product = productData.Delete(id);

        if (product is null)
        {
            Console.WriteLine($"Ürün Bulunamadı : Id= {id}");
            return;
        }
        Console.WriteLine("Ürün Silindi.");
        Console.WriteLine(product);
    }

    public void GetAllProductsByStockRange(int min, int max)
    {
        List<Product> products = productData.GetAllProductsByStockRange(min, max);
        products.ForEach(x => Console.WriteLine(x));
    }


    public void GetAllProductsOrderByDescendingName()
    {
        List<Product> filtered = productData.GetAllProductsOrderByDescendingName();
        filtered.ForEach(x => Console.WriteLine(x));
    }

    public void GetAllProductsOrderByAscendingName()
    {
        List<Product> filtered = productData.GetAllProductsOrderByAscendingName();
        filtered.ForEach(x => Console.WriteLine(x));
    }

    public void GetExpensiveProduct()
    {
        Product product = productData.GetExpensiveProduct();
        Console.WriteLine($"En pahalı ürün : {product}");
    }

    public void GetCheapProduct()
    {
        Product product = productData.GetCheapProduct();
        Console.WriteLine($"En pahalı ürün : {product}");
    }

    public void GetDetails()
    {
        List<Category> categories = categoryService.GetAllCategories();
        List<ProductDetailDto> details = productData.GetDetails(categories);
        details.ForEach(x => Console.WriteLine(x));
    }

    public void GetDetailsV2()
    {
        List<Category> categories = categoryService.GetAllCategories();
        List<ProductDetailDto> details = productData.GetDetailsV2(categories);
        details.ForEach(x => Console.WriteLine(x));
    }

    public void GetDetailById(Guid id)
    {
        List<Category> categories = categoryService.GetAllCategories();

        ProductDetailDto? detail = productData.GetDetailById(id, categories);
        if (detail is null)
        {
            Console.WriteLine($"Ürün Bulunamadı : Id= {id}");
            return;
        }

        Console.WriteLine(detail);
    }
}