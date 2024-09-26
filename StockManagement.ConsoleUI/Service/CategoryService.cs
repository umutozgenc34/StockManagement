using StockManagement.ConsoleUI.Data;
using StockManagement.ConsoleUI.Models;

namespace StockManagement.ConsoleUI.Service;

public class CategoryService
{
    CategoryData categoryData = new CategoryData();


    public List<Category> GetAllCategories()
    {
        return categoryData.GetAll();
    }

    public void GetById (int id)
    {
        Category category = categoryData.GetById(id);
        Console.WriteLine(category);
    }

    public Category Add(Category category)
    {
        Console.WriteLine("Kategori Eklendi");
        return categoryData.Add(category);
        
    }

    public void DeleteById (int id)
    {
        Category category = categoryData.GetById(id);
        if (category is null)
        {
            Console.WriteLine($"Araç buluamadı Id : {id}");
            return;
        }

        Console.WriteLine($"Araç silindi {category}");
    }

    public void Update(Category category)
    {
        Console.WriteLine("Araç güncellendi");
        categoryData.Update(category);
    }

}