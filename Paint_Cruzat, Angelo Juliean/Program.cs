using System;

namespace Paint_Cruzat__Angelo_Juliean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
public class Canvas
{
    string _currentTool;

    public void setCurrentTool(string tool)
    {
        this._currentTool = tool;
    }

    public void mouseOver()
    {
        if (_currentTool == "pencil")
        {
            Console.WriteLine("Show pencil icon");
        }
        else if (_currentTool == "square")
        {
            Console.WriteLine("Show square icon");
        }
        else if (_currentTool == "eraser")
        {
            Console.WriteLine("Show an eraser icon");
        }
    }

    public void mouseUp()
    {
        if (_currentTool == "pencil")
        {
            Console.WriteLine("Draw a line.");
        }
        else if (_currentTool == "square")
        {
            Console.WriteLine("Draw a square.");
        }
        else if (_currentTool == "eraser")
        {
            Console.WriteLine("Erase the selected object.");
        }
    }
}
