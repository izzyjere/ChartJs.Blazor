using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJs.Blazor
{
    public enum GradientMode
    {
        Radial,
        Linear,
        Conic
    }
   
    public class Color
    {
        readonly string value;
        private Color(string _value)
        {
            value = _value;
        }
        public static Color FromRGB(string r, string g, string b, float opacity = 1) 
        {   
            if(opacity<0)
            {
                throw new ArgumentException("Opacity cannot be negative.");
            }
           return new Color($"rgb({r},{g},{b},{opacity})"); 
        }
        public static Color FromHex(string hexValue)
        {
            if(hexValue.StartsWith("#"))
            {
                return new Color(hexValue);
            }
           return new Color($"#{hexValue}");
        }
        public static Color FromHSL(double hue,double saturation,double lightness, double opacity=1)
        {
            return new Color($"hsl({hue},{saturation},{lightness},{opacity})");
        }
        public static Color FromLabel(ColorLabel color)
        {
            return new Color(color.ToString());
        }
        public override string ToString()
        {
            return value; 
        }
    }
}
