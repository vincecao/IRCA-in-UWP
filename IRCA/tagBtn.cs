using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace IRCA
{
    class tagBtn:Button
    {
        public Color _color;
        public int _id;

        public tagBtn(int _id, string name)
        {
            _color = radomColor();
            this._id = _id;

            Content = name;
            VerticalAlignment = VerticalAlignment.Stretch;
            Width = 75;
            BorderThickness = new Thickness(0);
            Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            Background = new SolidColorBrush(_color);            

        }

        private Color radomColor()
        {
            Random rnd = new Random();
            Byte[] b = new Byte[4];
            rnd.NextBytes(b);
            Color color = Color.FromArgb(125, b[1], b[2], b[3]);
            return color;
        }

    }
}
