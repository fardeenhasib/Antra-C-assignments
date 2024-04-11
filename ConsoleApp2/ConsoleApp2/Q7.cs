using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2;

using System;

class Color
{
    private int red;
    private int green;
    private int blue;
    private int alpha;

    public Color(int red, int green, int blue, int alpha)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
        this.alpha = alpha;
    }
    public Color(int red, int green, int blue) : this(red, green, blue, 255)
    {
    }
    public int Red
    {
        get { return red; }
        set { red = value; }
    }

    public int Green
    {
        get { return green; }
        set { green = value; }
    }

    public int Blue
    {
        get { return blue; }
        set { blue = value; }
    }

    public int Alpha
    {
        get { return alpha; }
        set { alpha = value; }
    }

    public int GetGrayscale()
    {
        return (red + green + blue) / 3;
    }
}

class Ball
{
    private int size;
    private Color color;
    private int throwCount;
    private bool popped;

    public Ball(int size, Color color)
    {
        this.size = size;
        this.color = color;
    }

    public void Pop()
    {
        size = 0;
        popped = true;
    }
    public void Throw()
    {
        if (!popped)
            throwCount++;
    }

    public int GetThrowCount()
    {
        return throwCount;
    }
}
