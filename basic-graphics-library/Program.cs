using System.Numerics;
using System.Threading.Channels;

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
    
        // Scaling
        Vector2 vec2ToScale = a;
        Vector3 vec3ToScale = new Vector3(5, 3, -4);

        Console.WriteLine($"Vector before scaling: [{vec2ToScale[0]}, {vec2ToScale[1]}]");
        Vector2 res2 = Transform.Scale(vec2ToScale, 0.5f, 0.5f);
        Console.WriteLine($"Vector after scaling : [{res2[0]}, {res2[1]}]");
        
        Console.WriteLine($"Vector before scaling: [{vec3ToScale[0]}, {vec3ToScale[1]}, {vec3ToScale[2]}]");
        Vector3 res3 = Transform.Scale(vec3ToScale, 0.5f, 0.5f, 0.5f);
        Console.WriteLine($"Vector after scaling : [{res3[0]}, {res3[1]}, {res3[2]}]");
    }
}