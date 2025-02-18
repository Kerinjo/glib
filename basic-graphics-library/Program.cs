namespace basic_graphics_library;

class Program
{
    static void Main(string[] args)
    {
        Vector2 a = new Vector2(4, 3);
        Vector2 b = new Vector2(-4.2f, 7);
        Vector2 zero = new Vector2(); 

        Console.WriteLine(b[0]);
        
        Vector2 third = a + b;
        Console.WriteLine($"{third[0]}, {third[1]}"); 
    }
}