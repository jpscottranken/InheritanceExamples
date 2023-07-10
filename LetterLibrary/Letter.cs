using System;

namespace LetterLibrary
{
    public class Letter
    {
        //  Instance variables
        protected string   _recipient;
        protected DateTime _sentDate;

        //  Full-Arg Constructor
        public Letter(string recipient, DateTime sentDate)
        {
            _recipient = recipient;
            _sentDate  = sentDate;
        }

        //  Getters
        public string Recipient => _recipient;
        public DateTime SentDate => _sentDate;

        public virtual decimal Price => 0.50M;

        //  Override the ToString() method
        public override string ToString()
        {
            return (SentDate.ToString("MM/dd/yyyy") + ", " +
                   Recipient + ", " + Price.ToString("c"));
        }
    }
}
