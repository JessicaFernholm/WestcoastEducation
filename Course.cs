using System.Text.Json;

namespace WestcoastEducation;

public class Course
{
    private IList<Kurs> _kurser = new List<Kurs>();

    public Course()
    {
        LoadFromFile("courses.json");
    }
     public void Show()
    {
        Console.WriteLine("Kursmeny");
        foreach (var kurs in _kurser)
        {
            Console.WriteLine($"- {kurs.Namn} ({kurs.Längd} veckor)");
            Console.WriteLine("");
        }
    }
    private void LoadFromFile(string filePath)
    {
        if(!File.Exists(filePath))
        {
            Console.WriteLine($"Hittade inte {filePath}.");
            return;
        }
         
         string json = File.ReadAllText("courses.json");
        _kurser = JsonSerializer.Deserialize<List<Kurs>>(json) ?? new List<Kurs>();

    } 
}
