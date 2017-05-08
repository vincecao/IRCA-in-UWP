using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace IRCA
{
    class myCanvas : Canvas
    {
        public Color _color;
        public int _id;
        
        public myCanvas(int _id, Color _color)
        {
            this._id = _id;
            this._color = _color;

            Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));

        }
    }
}
