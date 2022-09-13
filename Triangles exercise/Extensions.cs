namespace Triangles_exercise;

public static class Extensions
{
    public static bool IsAlmostEqual(this double source, double value)
    {
        return Math.Abs(source - value) < 1e-9;
    }
}