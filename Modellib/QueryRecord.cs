using System;
using System.Collections.Generic;
using System.Text;

namespace Modellib
{
    public class QueryRecord
    {
        private int _MinyearOfPublication;
        private int _MaxyearOfPublication;
        private double _minDuration;
        private double _maxDuration;

        public QueryRecord(int minyearOfPublication, int maxyearOfPublication, double minDuration, double maxDuration)
        {
            _MinyearOfPublication = minyearOfPublication;
            _MaxyearOfPublication = maxyearOfPublication;
            _minDuration = minDuration;
            _maxDuration = maxDuration;
        }

        public int MinyearOfPublication
        {
            get { return _MinyearOfPublication; }
            set { _MinyearOfPublication = value; }
        }

        public int MaxyearOfPublication
        {
            get { return _MaxyearOfPublication; }
            set { _MaxyearOfPublication = value; }
        }

        public double MinDuration
        {
            get { return _minDuration; }
            set { _minDuration = value; }
        }

        public double MaxDuration
        {
            get { return _maxDuration; }
            set { _maxDuration = value; }
        }


        public override string ToString()
        {
            return $"{nameof(MinyearOfPublication)}: {MinyearOfPublication}, {nameof(MaxyearOfPublication)}: {MaxyearOfPublication}, {nameof(MinDuration)}: {MinDuration}, {nameof(MaxDuration)}: {MaxDuration}";
        }
    }
}
