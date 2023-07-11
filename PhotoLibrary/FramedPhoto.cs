using System;

namespace PhotoLibrary
{
    public class FramedPhoto : Photo
    {
        //  Material Enumeration
        public enum Material
        {
            PINE    = 0,
            OAK     = 1,
            STEEL   = 2,
            SILVER  = 3,
            GOLD    = 4
        }

        //  Style Enumeration
        public enum Style
        {
            SIMPLE   = 0,
            MODERN   = 1,
            ANTIQUE  = 2,
            VINTAGE  = 3,
            ECLECTIC = 4
        }

        //  Instance variables
        protected Material _material;
        protected Style    _style;

        //  Full-Arg Constructor
        public FramedPhoto(decimal w, decimal h,
                           Material m, Style s)
                    : base(w, h)    
        {
            _material = m;
            _style    = s;
        }

        //  Getters and Setters
        public Material TheMaterial => _material;
        public Style    TheStyle => _style;

        //  Override the ToString() Method
        public override string ToString()
        {
            return base.ToString() + " Framed " +
                   TheMaterial.ToString() + " " +
                   TheStyle.ToString();
        }
    }
}
