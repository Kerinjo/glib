using System;

namespace basic_graphics_library;

public class Vector3
{
    private float[] _coordinates;

    public Vector3(float x, float y, float z)
    {
        _coordinates = [x, y, z];
    }

    public Vector3()
    {
        _coordinates = [0, 0, 0];
    }

    // Operator overloading
    // Indexing
    public float this[int i]
    {
        get => _coordinates[i];
        set => _coordinates[i] = value;
    }

    // Addition
    public static Vector3 operator +(Vector3 a, Vector3 b)
    {
        return new Vector3(
            a[0] + b[0],
            a[1] + b[1],
            a[2] + b[2]);
    }

    // Subtraction
    public static Vector3 operator -(Vector3 a, Vector3 b)
    {
        return new Vector3(
            a[0] - b[0],
            a[1] - b[1],
            a[2] - b[1]);
    }

    // Dot product
    public static float operator *(Vector3 a, Vector3 b)
    {
        return a[0] * a[1] + b[0] * b[1] + a[2] * b[2];
    }

    // Cross product
    public static Vector3 operator ^(Vector3 a, Vector3 b)
    {
        return new Vector3(
            a[1] * b[2] - a[2] * b[1],
            a[2] * b[0] - a[0] * b[2],
            a[0] * b[1] - a[1] * b[0]);
    }
    
    // // Scalar multiplication
    public static Vector3 operator *(Vector3 a, float k)
    {
        return new Vector3(k * a[0], k * a[1], k * a[2]);
    }
    
    // Scalar division
    public static Vector3 operator /(Vector3 a, float k)
    {
        return new Vector3(a[0] / k, a[1] / k, a[2] / k);
    }
}
