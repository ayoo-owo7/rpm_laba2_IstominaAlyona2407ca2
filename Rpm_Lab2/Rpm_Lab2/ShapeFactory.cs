using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Rpm_Lab2
{
    public abstract class CircleCreator
    {
        public abstract Circle CreateCircle();
    }

    public class RedCircleCreator : CircleCreator
    {
        public override Circle CreateCircle() => new Circle { Color = Colors.Red };
    }
    public class BlueCircleCreator : CircleCreator
    {
        public override Circle CreateCircle() => new Circle { Color = Colors.Blue };
    }
    public class GreenCircleCreator : CircleCreator
    {
        public override Circle CreateCircle() => new Circle { Color = Colors.Green };
    }
    public class LightCircleCreator : CircleCreator
    {
        public override Circle CreateCircle() => new Circle { Color = Colors.LightGray };
    }
    public class DarkCircleCreator : CircleCreator
    {
        public override Circle CreateCircle() => new Circle { Color = Colors.DarkGray };
    }
    public class ColorfulCircleCreator : CircleCreator
    {
        public override Circle CreateCircle() => new Circle { Color = Colors.Gold };
    }

    public abstract class SquareCreator
    {
        public abstract Square CreateSquare();
    }

    public class RedSquareCreator : SquareCreator
    {
        public override Square CreateSquare() => new Square { Color = Colors.Red };
    }
    public class BlueSquareCreator : SquareCreator
    {
        public override Square CreateSquare() => new Square { Color = Colors.Blue };
    }
    public class GreenSquareCreator : SquareCreator
    {
        public override Square CreateSquare() => new Square { Color = Colors.Green };
    }
    public class LightSquareCreator : SquareCreator
    {
        public override Square CreateSquare() => new Square { Color = Colors.LightGray };
    }
    public class DarkSquareCreator : SquareCreator
    {
        public override Square CreateSquare() => new Square { Color = Colors.DarkGray };
    }
    public class ColorfulSquareCreator : SquareCreator
    {
        public override Square CreateSquare() => new Square { Color = Colors.Gold };
    }

    public abstract class TriangleCreator
    {
        public abstract Triangle CreateTriangle();
    }

    public class RedTriangleCreator : TriangleCreator
    {
        public override Triangle CreateTriangle() => new Triangle { Color = Colors.Red };
    }
    public class BlueTriangleCreator : TriangleCreator
    {
        public override Triangle CreateTriangle() => new Triangle { Color = Colors.Blue };
    }
    public class GreenTriangleCreator : TriangleCreator
    {
        public override Triangle CreateTriangle() => new Triangle { Color = Colors.Green };
    }
    public class LightTriangleCreator : TriangleCreator
    {
        public override Triangle CreateTriangle() => new Triangle { Color = Colors.LightGray };
    }
    public class DarkTriangleCreator : TriangleCreator
    {
        public override Triangle CreateTriangle() => new Triangle { Color = Colors.DarkGray };
    }
    public class ColorfulTriangleCreator : TriangleCreator
    {
        public override Triangle CreateTriangle() => new Triangle { Color = Colors.Gold };
    }

}
