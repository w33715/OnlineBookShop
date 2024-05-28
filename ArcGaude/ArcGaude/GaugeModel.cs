namespace ArcGaude
{
    public class GaugeModel : ViewModelBase
    {
        private int _max;
        public int Max
        {
            get { return _max; }
            set
            {
                _max = value;
                OnPropertyChanged("Max");
            }
        }
        private int _min;
        public int Min
        {
            get { return _min; }
            set
            {
                _min = value;
                OnPropertyChanged("Min");
            }
        }
        private int _value;
        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged("Value");
            }
        }
        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged("Title");
            }
        }
        private int _unit;
        public int Unit
        {
            get { return _unit; }
            set
            {
                _unit = value;
                OnPropertyChanged("Unit");
            }
        }
        private string _tickUnit;
        public string TickUnit
        {
            get { return _tickUnit; }
            set
            {
                _tickUnit = value;
                OnPropertyChanged("TickUnit");
            }
        }
        private int _value_string;
        public int ValueString
        {
            get { return _value_string; }
            set
            {
                _value_string = value;
                OnPropertyChanged("ValueString");
            }
        }

    }

}
