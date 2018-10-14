using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobile.ModelView;
using Xamarin.Forms;

namespace Mobile
{
    public partial class MainPage : ContentPage
    {
        ModelView.CalculationViewModel _calculationView;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = _calculationView = new CalculationViewModel();
        }

        private void SevenBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("7");
        }

        private void EightBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("8");
        }

        private void NineBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("9");
        }

        private void FourBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("4");
        }

        private void FiveBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("5");
        }

        private void SixBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("6");
        }

        private void OneBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("1");
        }

        private void TwoBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("2");
        }

        private void ThreeBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("3");
        }

        private void CommaBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula(".");
        }

        private void ZeroBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("0");
        }

        private void CancelBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("C");
        }

        private void DividedBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("/");
        }

        private void MultipleBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("*");
        }

        private void MinusBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("-");
        }

        private void PlusBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("+");
        }

        private void EqualBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.Calculate();
        }

        private void AllClearBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("AC");
        }
    }
}
