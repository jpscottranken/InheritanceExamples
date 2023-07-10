using System;

namespace LetterLibrary
{
    public class CertifiedLetter : Letter
    {
        //  Instance variable
        protected string _trackingNumber;

        //  Full-Arg Constructor
        public CertifiedLetter(string recipient,
                               DateTime sentDate,
                               string trackingNumber)
                        : base(recipient, sentDate)
        {
            _trackingNumber = trackingNumber;
        }

        //  Getter
        public string TrackingNumber => _trackingNumber;

        //  Override the Price
        public override decimal Price => 0.65M;
        //public override decimal Price
        //{
        //    get
        //    {
        //        return 0.65M;
        //    }
        //}

        //  Override the ToString() method
        public override string ToString()
        {
            return (base.SentDate.ToString("MM/dd/yyyy") + ", " +
                    base.Recipient + ", " + Price.ToString("c") +
                   ", " + TrackingNumber);
        }
    }
}
