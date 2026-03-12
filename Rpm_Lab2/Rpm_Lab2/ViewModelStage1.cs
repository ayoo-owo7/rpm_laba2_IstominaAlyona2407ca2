using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpm_Lab2
{
    public class MainViewModelStage1
    {
        public ObservableCollection<Figure> Figures { get; set; } = new();

        public ObservableCollection<string> Themes { get; set; } = new()
    {
        "Red", "Blue", "Green", "Light", "Dark", "Colorful"
    };

        public string SelectedTheme { get; set; } = "Red";

        public void CreateFigures()
        {
            Figures.Clear();

            CircleCreator circleCreator;
            SquareCreator squareCreator;
            TriangleCreator triangleCreator;

            switch (SelectedTheme)
            {
                case "Red":
                    circleCreator = new RedCircleCreator();
                    squareCreator = new RedSquareCreator();
                    triangleCreator = new RedTriangleCreator();
                    break;
                case "Blue":
                    circleCreator = new BlueCircleCreator();
                    squareCreator = new BlueSquareCreator();
                    triangleCreator = new BlueTriangleCreator();
                    break;
                case "Green":
                    circleCreator = new GreenCircleCreator();
                    squareCreator = new GreenSquareCreator();
                    triangleCreator = new GreenTriangleCreator();
                    break;
                case "Light":
                    circleCreator = new LightCircleCreator();
                    squareCreator = new LightSquareCreator();
                    triangleCreator = new LightTriangleCreator();
                    break;
                case "Dark":
                    circleCreator = new DarkCircleCreator();
                    squareCreator = new DarkSquareCreator();
                    triangleCreator = new DarkTriangleCreator();
                    break;
                case "Colorful":
                    circleCreator = new ColorfulCircleCreator();
                    squareCreator = new ColorfulSquareCreator();
                    triangleCreator = new ColorfulTriangleCreator();
                    break;
                default:
                    return;
            }

            Figures.Add(circleCreator.CreateCircle());
            Figures.Add(squareCreator.CreateSquare());
            Figures.Add(triangleCreator.CreateTriangle());
        }
    }
}
