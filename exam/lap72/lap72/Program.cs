using System;
using System.Collections;

namespace WeekdayHashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo một hashtable lưu danh sách các ngày trong tuần với key từ 1-8
            Hashtable weekdays = new Hashtable()
            {
                { 1, "Monday" },
                { 2, "Tuesday" },
                { 3, "Wednesday" },
                { 4, "Thursday" },
                { 5, "Friday" },
                { 6, "Saturday" },
                { 7, "Sunday" },
            };

            // Tìm ngày Tuesday, in ra thông báo nếu tìm thấy hoặc không
            if (weekdays.ContainsValue("Tuesday"))
            {
                Console.WriteLine("Tìm thấy ngày Tuesday trong danh sách các ngày trong tuần.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy ngày Tuesday trong danh sách các ngày trong tuần.");
            }

            // In ra các ngày trong tuần bao gồm cả key và value.
            Console.WriteLine("Danh sách các ngày trong tuần:");
            foreach (var key in weekdays.Keys)
            {
                Console.WriteLine("{0}: {1}", key, weekdays[key]);
            }
        }
    }
}

