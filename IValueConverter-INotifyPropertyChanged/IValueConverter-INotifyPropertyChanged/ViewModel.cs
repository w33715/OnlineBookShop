using System.ComponentModel;

namespace IValueConverter_INotifyPropertyChanged
{
    public class ViewModel
    {
        int value1;
        int value2;

        public int Value1
        {
            get
            {
                return value1;
            }
            set
            {
                value1 = value;
                RaisePropertyChanged("Sum");
            }
        }
        public int Value2
        {
            get
            {
                return value2;
            }
            set
            {
                value2 = value;
                RaisePropertyChanged("Sum");
            }
        }
        int sum;
        public int Sum
        {
            get
            {
                return value1 + value2;
            }
            set
            {
                sum = value;

            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
