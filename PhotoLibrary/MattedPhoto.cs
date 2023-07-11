using System;

namespace PhotoLibrary
{
    public class MattedPhoto : Photo
    {
        //  Color Enumeration
        public enum Color
        {
            BLACK = 0,
            RED   = 1,
            GREEN = 2,
            BLUE  = 4,
            WHITE = 7
        }

        //  Instance Variable
        protected Color _color;

        //  Full-Arg Constructor
        public MattedPhoto(decimal w, decimal h, Color c)
                    : base(w, h)
        {
            _color = c;
        }

        //  Getter and Setter
        public Color TheColor => _color;

        //  Override the ToString() Method
        public override string ToString()
        {
            return base.ToString() + " Matted  " +
                   TheColor.ToString();
        }
    }
}
