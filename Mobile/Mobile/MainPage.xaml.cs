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
        #region Constructor

        ModelView.CalculationViewModel _calculationView;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = _calculationView = new CalculationViewModel();

            _calculationView.IsScienteficVisible = false;
            _calculationView.IsSimpleKeyBoardVisible = true;
        }

        #endregion

        #region Option Buttons

        private void NormalKeyboard_OnClicked(object sender, EventArgs e)
        {
            _calculationView.IsScienteficVisible = false;
            _calculationView.IsSimpleKeyBoardVisible = true;
        }

        private void ScientificKeyboard_OnClicked(object sender, EventArgs e)
        {
            _calculationView.IsScienteficVisible = true;
            _calculationView.IsSimpleKeyBoardVisible = false;
        }

        #endregion

        #region Simple Keyboard

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

        #endregion

        #region Scientific Keyboard

        private void ScieSevenBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("7");
        }

        private void ScieEightBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("8");
        }

        private void ScieNineBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("9");
        }

        private void ScieFourBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("4");
        }

        private void ScieFiveBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("5");
        }

        private void ScieSixBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("6");
        }

        private void ScieOneBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("1");
        }

        private void ScieTwoBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("2");
        }

        private void ScieThreeBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("3");
        }

        private void ScieCommaBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula(".");
        }

        private void ScieZeroBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("0");
        }

        private void ScieCancelBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("C");
        }

        private void ScieDividedBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("/");
        }

        private void ScieMultipleBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("*");
        }

        private void ScieMinusBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("-");
        }

        private void SciePlusBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("+");
        }

        private void ScieEqualBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("=");
        }

        private void ScieAllClearBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("AC");
        }

        private void ScieInvBtn_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ScieSinBtn_OnClicked(object sender, EventArgs e)
        {
            _calculationView.AddToFormula("Sin");
        }

        private void ScieInBtn_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SciePBtn_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ScieCosBtn_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ScieLogBtn_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ScieEBtn_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ScieTanBtn_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ScieSquareRootBtn_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ScieAnsBtn_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ScieEXPBtn_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SciePowertn_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ScieX_Btn_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ScieRadBtn_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ScieDegBtn_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ScieLeftPareBtn_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ScieRightPareBtn_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SciePercentageBtn_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion



    }
}
