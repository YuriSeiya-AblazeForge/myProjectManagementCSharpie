public class Color
{
    public static Color Red => new (230,0,0);

    public byte R { get; set; }
    public byte G { get; set; }
    public byte B { get; set; }

    public Color(byte r, byte g, byte b)
    {
        R = r;
        G = g;
        B = b;
    }

    public override string ToString()
    {
        return $"RGB({R}, {G}, {B})";
    }
}
