using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Linq;

namespace Mobile.ModelView
{
    public class CalculationViewModel : INotifyPropertyChanged
    {
        #region Properties

        private Dictionary<char, int> dictiOfMathSymbol = new Dictionary<char, int>()
        {
            {'+',0 },
            {'-',1 },
            {'*',2 },
            {'/',2 }
        };

        public string S { get; set; } = "0";

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

        private bool _isSimpleKeyboardEnable;

        public bool IsSimpleKeyBoardVisible
        {
            get { return _isSimpleKeyboardEnable;}
            set { _isSimpleKeyboardEnable = value; NotifyPropertyChanged("IsSimpleKeyBoardVisible"); }
        }

        private bool _isScientificKeyboardEnable;

        public bool IsScienteficVisible
        {
            get { return _isScientificKeyboardEnable; }
            set { _isScientificKeyboardEnable = value; NotifyPropertyChanged("IsScienteficVisible"); }
        }
        #endregion

        #region Constructor

        public CalculationViewModel()
        {}

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
                        Result = "";
                    }

                    break;
                case "C":
                    if (!String.IsNullOrEmpty(FormulaLbl))
                    {
                        FormulaLbl = FormulaLbl.Remove(FormulaLbl.Length - 1);
                        Calculate();
                    }
                    else
                    {
                        FormulaLbl = "0";
                    }

                    break;
                case "Sin":
                    if (String.IsNullOrEmpty(FormulaLbl))
                    {
                        FormulaLbl = FormulaLbl + "sin()";
                    }
                    else if(!String.IsNullOrEmpty(FormulaLbl))
                    {
                        if (FormulaLbl.Contains("sin"))
                        {
                            if (value.Contains("sin"))
                            {
                                value = value.Remove(value.Length - 1);
                                FormulaLbl = FormulaLbl.Remove(FormulaLbl.Length - 1) + ")";
                            }
                            else if (!value.Contains("sin"))
                            {
                                FormulaLbl = FormulaLbl.Remove(FormulaLbl.Length - 1) + value + ")";
                            }

                            char lastCharOfFormula = FormulaLbl[FormulaLbl.Length - 1];
                            foreach (var pair in dictiOfMathSymbol)
                            {
                                if (lastCharOfFormula == pair.Key)
                                {
                                    FormulaLbl = FormulaLbl + "sin()";
                                    break;
                                }
                                else
                                {
                                    FormulaLbl = FormulaLbl + "*sin()";
                                    break;
                                }
                            }
                        }
                        else
                        {
                            char lastCharOfFormula = FormulaLbl[FormulaLbl.Length - 1];
                            foreach (var pair in dictiOfMathSymbol)
                            {
                                if (lastCharOfFormula == pair.Key)
                                {
                                    FormulaLbl = FormulaLbl + "sin()";
                                    break;
                                }
                                else
                                {
                                    FormulaLbl = FormulaLbl + "*sin()";
                                    break;
                                }
                            }
                        }
                    }
                    break;
                default:
                    //if (FormulaLbl.Contains("sin"))
                    //{
                    //    if (value.Contains(")"))
                    //    {
                    //        value = value.Remove(value.Length - 1);
                    //        FormulaLbl = FormulaLbl.Remove(FormulaLbl.Length - 1) + ")";
                    //    }
                    //    else if(!value.Contains(")"))
                    //    {
                    //        FormulaLbl = FormulaLbl.Remove(FormulaLbl.Length - 1) + value + ")";
                    //    }
                    //    else
                    //    {
                    //        FormulaLbl = FormulaLbl + value;
                    //    }
                        
                    //}
                    //else
                    //{
                        FormulaLbl = FormulaLbl + value;
                    //}
                    
                    
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
