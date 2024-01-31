using System;

class Fraction
    {
        // Attributes
        private int _top;
        private int _bottom;

        //Default Constructor
        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

        // Constructor: Whole number
        public Fraction(int wholeNum)
        {
            _top = wholeNum;
            _bottom = 1;
        }

        // Constructor: True Fraction
        public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;
        }

        // Getters & Setters
        public int GetTop()
        {
            return _top;
        }

        public int Bottom()
        {
            return _bottom;
        }

        public void SetTop(int top)
        {
            _top = top;
        }

        public void SetBottom(int bottom)
        {
            _bottom = bottom;
        }

        // Methods
        public string GetFractionString()
        {
            string text = $"{_top}/{_bottom}";
            return text;
        }
        
        public string GetMixedFractionString()
        {
            if (_top >= _bottom)
            {
                int mixedWhole = _top / _bottom;
                int mixedTop = _top % _bottom;
                if (mixedTop != 0)
                {
                    string text = $"{mixedWhole} {mixedTop}/{_bottom}";
                    return text;
                }
                else{
                    string text = $"{mixedWhole}";
                    return text;
                }
            }
            else{
                string text = $"{_top}/{_bottom}";
                return text;
            }
        }

        public double GetDecimalValue()
        {
            double value = (double)_top / (double)_bottom;
            return value;
        }
    }