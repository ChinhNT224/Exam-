using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class ListExtension
{
    public static void AddIfNotExists<T>(this List<T> list, T item)
    {
        if (!list.Contains(item))
        {
            list.Add(item);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<string> fruits = new List<string>() { "apple", "banana", "orange" };

        fruits.AddIfNotExists("apple"); // không thêm vào vì "apple" đã tồn tại trong danh sách
        fruits.AddIfNotExists("grape"); // thêm "grape" vào danh sách vì chưa tồn tại

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}

