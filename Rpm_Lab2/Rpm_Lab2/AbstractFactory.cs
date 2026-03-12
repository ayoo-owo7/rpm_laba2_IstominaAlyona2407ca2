using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Rpm_Lab2
{
    public interface IFigureFactory
    {
        Circle CreateCircle();
        Square CreateSquare();
        Triangle CreateTriangle();
    }

    public class RedFactory : IFigureFactory
    {
        public Circle CreateCircle() => new Circle { Color = Colors.Red };
        public Square CreateSquare() => new Square { Color = Colors.Red };
        public Triangle CreateTriangle() => new Triangle { Color = Colors.Red };
    }

    public class BlueFactory : IFigureFactory
    {
        public Circle CreateCircle() => new Circle { Color = Colors.Blue };
        public Square CreateSquare() => new Square { Color = Colors.Blue };
        public Triangle CreateTriangle() => new Triangle { Color = Colors.Blue };
    }

    public class GreenFactory : IFigureFactory
    {
        public Circle CreateCircle() => new Circle { Color = Colors.Green };
        public Square CreateSquare() => new Square { Color = Colors.Green };
        public Triangle CreateTriangle() => new Triangle { Color = Colors.Green };
    }

    public class LightFactory : IFigureFactory
    {
        public Circle CreateCircle() => new Circle { Color = Colors.LightGray };
        public Square CreateSquare() => new Square { Color = Colors.LightGray };
        public Triangle CreateTriangle() => new Triangle { Color = Colors.LightGray };
    }

    public class DarkFactory : IFigureFactory
    {
        public Circle CreateCircle() => new Circle { Color = Colors.DarkGray };
        public Square CreateSquare() => new Square { Color = Colors.DarkGray };
        public Triangle CreateTriangle() => new Triangle { Color = Colors.DarkGray };
    }

    public class ColorfulFactory : IFigureFactory
    {
        public Circle CreateCircle() => new Circle { Color = Colors.Gold };
        public Square CreateSquare() => new Square { Color = Colors.Gold };
        public Triangle CreateTriangle() => new Triangle { Color = Colors.Gold };
    }

}
