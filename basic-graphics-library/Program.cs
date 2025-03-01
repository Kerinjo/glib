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

        
        Console.WriteLine(res2);
        Console.WriteLine(res3);
        
        
        // Matrix2D
        Matrix2D m1 = Matrix2D.Parse("[[12, 1], [13, -9]]");
        Matrix2D m2 = Matrix2D.Parse("[[100, 14], [1, 4]]");

        Console.WriteLine("Matrix mult:");
        Console.WriteLine(m1 * m2);
        Console.WriteLine($"Det: {m2.Det()}");

        Console.WriteLine(Matrix2D.Transpose(m1));
        
        var A = new Matrix2D(1, 1, 1, 0);
        var B = new Matrix2D(0.5f, 0, 0, 1.5f);

        Console.WriteLine(A * 1.7f);
        Console.WriteLine(A + B);

        // next up vectors with matrices
    }
}