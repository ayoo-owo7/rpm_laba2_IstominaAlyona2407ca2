using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Rpm_Lab2.IFigureFactory;

namespace Rpm_Lab2
{
    public class MainViewModelStage2
    {
        private IFigureFactory _currentFactory;

        public ObservableCollection<Figure> Figures { get; set; } = new();

        public ObservableCollection<string> Themes { get; set; } = new()
    {
        "Red", "Blue", "Green", "Light", "Dark", "Colorful"
    };

        public string SelectedTheme { get; set; } = "Red";

        public MainViewModelStage2()
        {
            UpdateFactory();
            CreateFigures();
        }

        private void UpdateFactory()
        {
            switch (SelectedTheme)
            {
                case "Red": _currentFactory = new RedFactory(); break;
                case "Blue": _currentFactory = new BlueFactory(); break;
                case "Green": _currentFactory = new GreenFactory(); break;
                case "Light": _currentFactory = new LightFactory(); break;
                case "Dark": _currentFactory = new DarkFactory(); break;
                case "Colorful": _currentFactory = new ColorfulFactory(); break;
                default: _currentFactory = new RedFactory(); break;
            }
        }

        public void CreateFigures()
        {
            Figures.Clear();
            UpdateFactory();

            Figures.Add(_currentFactory.CreateCircle());
            Figures.Add(_currentFactory.CreateSquare());
            Figures.Add(_currentFactory.CreateTriangle());
        }
    }
}
