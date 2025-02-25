namespace basic_graphics_library;

public static class Transform
{
    public static Vector2 Scale(Vector2 vec, float scaleX, float scaleY)
    {
        return new Vector2(vec[0] * scaleX, vec[1] * scaleY);
    }

    public static Vector3 Scale(Vector3 vec, float scaleX, float scaleY, float scaleZ)
    {
        return new Vector3(vec[0] * scaleX, vec[1] * scaleY, vec[2] * scaleZ);
    }
    /*    
    [x] - scaling
    [] - shearing
    [] - rotation
    [] - reflection
    */
}