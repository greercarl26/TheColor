Color black = new Color(0, 0, 0);
Color white = Color.Purple;

Console.WriteLine($"({black.R}, {black.G}, {black.B})");
Console.WriteLine($"({white.R},{white.G}, {white.B})");

class Color
{
    //Properties
    public int R { get; }
    public int G { get; }
    public int B { get; }
    //Constrctors 
    public Color(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }
    // Static Properties
    public static Color White { get; } = new Color(255, 255, 255);
    public static Color Black { get; } = new Color(0, 0, 0);
    public static Color Red { get; } = new Color(255, 0, 0);
    public static Color Orange { get; } = new Color(255, 165, 0);
    public static Color Yellow { get; } = new Color(255, 255, 0);
    public static Color Green { get; } = new Color(0, 128, 0);
    public static Color Blue { get; } = new Color(0, 0, 255);
    public static Color Purple { get; } = new Color(128, 0, 128);

}