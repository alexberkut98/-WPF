using Prism.Mvvm;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Попытка_в_WPF
{
    public class VM : INotifyPropertyChanged
    {
        readonly Calculate _calculate = new Calculate();

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public VM()
        {
            PlusCommand = new DelegateCommand(() => Result=_calculate.Plus(_number1, _number2));
            MinusCommand = new DelegateCommand(() => Result = _calculate.Minus(_number1, _number2));
        }
        private int _number1;
        public int Number1
        {
            get 
            { 
                return _number1; 
            }
            set
            {
                _number1 = value;           
            }
        }

        private int _number2;
        public int Number2
        {
            get 
            { 
                return _number2; 
            }
            set 
            {
                _number2 = value;  
            }
        }

        private int _result;
        public int Result
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
                OnPropertyChanged("Result");
            }
        }

        public DelegateCommand PlusCommand { get; }
        public DelegateCommand MinusCommand { get; }
    }
}
