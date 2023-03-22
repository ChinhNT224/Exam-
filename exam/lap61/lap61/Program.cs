using System;

class Program
{
    static void Main()
    {
        try
        {
            object obj = "Hello world";
            int num = (int)obj; // Gây ra ngoại lệ InvalidCastException

            int[] arr = new int[5];
            arr[10] = 42; // Gây ra ngoại lệ IndexOutOfRangeException

            object[] objects = new object[5];
            objects[0] = "one";
            objects[1] = "two";
            objects[2] = "three";
            int[] numbers = (int[])objects; // Gây ra ngoại lệ ArrayTypeMismatchException
        }
        catch (InvalidCastException e)
        {
            Console.WriteLine("InvalidCastException: " + e.Message);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("IndexOutOfRangeException: " + e.Message);
        }
        catch (ArrayTypeMismatchException e)
        {
            Console.WriteLine("ArrayTypeMismatchException: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Kết thúc chương trình");
        }
    }
}
