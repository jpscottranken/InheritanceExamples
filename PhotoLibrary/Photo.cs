using System;

namespace PhotoLibrary
{
    public class Photo
    {
        //  Instance variables
        protected decimal _width;
        protected decimal _height;

        //  Full-Arg Constructor
        public Photo(decimal width, decimal height)
        {
            _width  = width;
            _height = height;
        }

        //  Getters and setters
        public decimal Width => _width;
        public decimal Height => _height;

        public override string ToString()
        {
            return Width + " x " + Height;
        }
    }
}
