using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Mobile.ModelView
{
    public class CalculationViewModel : INotifyPropertyChanged
    {
        #region Properties

        private string _formulaLbl;

        public string FormulaLbl
        {
            get { return _formulaLbl; }
            set
            {
                _formulaLbl = value;
                NotifyPropertyChanged("FormulaLbl");
            }
        }

        private string _result;

        public string Result
        {
            get { return _result;}
            set { _result = value; NotifyPropertyChanged("Result"); }
        }

        #endregion

        #region Constructor

        public CalculationViewModel()
        {
        }

        #endregion

        #region Methods

        public void AddToFormula(string value)
        {
            switch (value)
            {
                case "AC":
                    if (!String.IsNullOrEmpty(FormulaLbl))
                    {
                        FormulaLbl = "";
                    }

                    break;
                case "C":
                    if (!String.IsNullOrEmpty(FormulaLbl))
                    {
                        FormulaLbl = FormulaLbl.Remove(FormulaLbl.Length - 1);
                    }

                    break;
                default:
                    FormulaLbl = FormulaLbl + value;
                    break;
            }
        }

        public void Calculate()
        {
            try
            {
                org.mariuszgromada.math.mxparser.Expression calculation;
                calculation = new org.mariuszgromada.math.mxparser.Expression(FormulaLbl); //5*60
                Result = calculation.calculate().ToString(); //300
            }
            catch (Exception e)
            {

            }
        }

        #endregion

        #region INotify Event

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
