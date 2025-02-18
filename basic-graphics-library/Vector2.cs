using System;

namespace basic_graphics_library;

public class Vector2
{
    private float[] _coordinates;
    
    public Vector2(float x, float y)
    {
        _coordinates = [x, y];
    }

    public Vector2()
    {
        _coordinates = [0, 0];
    }
    
    // Operator overloading
    // Indexing
    public float this[int i]
    {
        get => _coordinates[i];
        set => _coordinates[i] = value;
    }
    
    // Addition
    public static Vector2 operator +(Vector2 a, Vector2 b)
    {
        return new Vector2(
            a[0] + b[0],
            a[1] + b[1]);
    }
    
    // Subtraction
    public static Vector2 operator -(Vector2 a, Vector2 b)
    {
        return new Vector2(
            a[0] - b[0],
            a[1] - b[1]);
    }
    
    // // Dot product
    // public static float operator *(Vector2 a, Vector2 b)
    // {
    //     TODO
    // }
    //
    // // Cross product
    // public static Vector2 operator ^(Vector2 a, Vector2 b);
    // {
    //     TODO
    // }
    //
    // // Scalar multiplication
    // public static Vector2 operator *(Vector2 a, float k)
    // {
    //     TODO
    // }
    //
    // // Scalar division
    // public static Vector2 operator /(Vector2 a, float k)
    // {
    //     TODO
    // }
}