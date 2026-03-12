using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Rpm_Lab2
{
    public abstract class Figure
    {
            private Color _color;

            public Color Color
            {
                get => _color;
                set
                {
                    _color = value;
                    Visual = CreateUIElement();
                }
            }
            public UIElement Visual { get; protected set; }

            public abstract UIElement CreateUIElement(double size = 50);

            protected Figure()
            {
                Visual = CreateUIElement();
            }
    }

    public class Circle : Figure
    {
        public override UIElement CreateUIElement(double size = 50)
        {
            return new Ellipse
            {
                Width = size,
                Height = size,
                Fill = new SolidColorBrush(Color),
                Margin = new Thickness(5)
            };
        }
    }

    public class Square : Figure
    {
        public override UIElement CreateUIElement(double size = 50)
        {
            return new Rectangle
            {
                Width = size,
                Height = size,
                Fill = new SolidColorBrush(Color),
                Margin = new Thickness(5)
            };
        }
    }

    public class Triangle : Figure
    {
        public override UIElement CreateUIElement(double size = 50)
        {
            var polygon = new Polygon
            {
                Points = new PointCollection
            {
                new Point(size / 2, 0),
                new Point(0, size),
                new Point(size, size)
            },
                Fill = new SolidColorBrush(Color),
                Margin = new Thickness(5),
                Width = size,
                Height = size,
                Stretch = Stretch.Fill
            };
            return polygon;
        }
    }

}
