namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        private Rectangle oneButtonOriginalRectangle;
        private Rectangle twoButtonOriginalRectangle;
        private Rectangle threeButtonOriginalRectangle;
        private Rectangle fourButtonOriginalRectangle;
        private Rectangle fiveButtonOriginalRectangle;
        private Rectangle sixButtonOriginalRectangle;
        private Rectangle sevenButtonOriginalRectangle;
        private Rectangle eightButtonOriginalRectangle;
        private Rectangle nineButtonOriginalRectangle;
        private Rectangle zeroButtonOriginalRectangle;
        private Rectangle backSpaceButtonOriginalRectangle;
        private Rectangle plusMinusButtonOriginalRectangle;
        private Rectangle clearButtonOriginalRectangle;
        private Rectangle decimalButtonOriginalRectangle;
        private Rectangle squareRootButtonOriginalRectangle;
        private Rectangle multiplyButtonOriginalRectangle;
        private Rectangle divideButtonOriginalRectangle;
        private Rectangle minusButtonOriginalRectangle;
        private Rectangle equalButtonOriginalRectangle;
        private Rectangle plusButtonOriginalRectangle;
        private Rectangle displayLabelOriginalRectangle;
        private Size originalFormSize;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            originalFormSize = this.Size;
            oneButtonOriginalRectangle = new Rectangle(oneButton.Location.X, oneButton.Location.Y, oneButton.Width, oneButton.Height);
            twoButtonOriginalRectangle = new Rectangle(twoButton.Location.X, twoButton.Location.Y, twoButton.Width, twoButton.Height);
            threeButtonOriginalRectangle = new Rectangle(threeButton.Location.X, threeButton.Location.Y, threeButton.Width, threeButton.Height);
            fourButtonOriginalRectangle = new Rectangle(fourButton.Location.X, fourButton.Location.Y, fourButton.Width, fourButton.Height);
            fiveButtonOriginalRectangle = new Rectangle(fiveButton.Location.X, fiveButton.Location.Y, fiveButton.Width, fiveButton.Height);
            sixButtonOriginalRectangle = new Rectangle(sixButton.Location.X, sixButton.Location.Y, sixButton.Width, sixButton.Height);
            sevenButtonOriginalRectangle = new Rectangle(sevenButton.Location.X, sevenButton.Location.Y, sevenButton.Width, sevenButton.Height);
            eightButtonOriginalRectangle = new Rectangle(eightButton.Location.X, eightButton.Location.Y, eightButton.Width, eightButton.Height);
            nineButtonOriginalRectangle = new Rectangle(nineButton.Location.X, nineButton.Location.Y, nineButton.Width, nineButton.Height);
            zeroButtonOriginalRectangle = new Rectangle(zeroButton.Location.X, zeroButton.Location.Y, zeroButton.Width, zeroButton.Height);
            backSpaceButtonOriginalRectangle = new Rectangle(backSpaceButton.Location.X, backSpaceButton.Location.Y, backSpaceButton.Width, backSpaceButton.Height);
            plusMinusButtonOriginalRectangle = new Rectangle(plusMinusButton.Location.X, plusMinusButton.Location.Y, plusMinusButton.Width, plusMinusButton.Height);
            clearButtonOriginalRectangle = new Rectangle(clearButton.Location.X, clearButton.Location.Y, clearButton.Width, clearButton.Height);
            decimalButtonOriginalRectangle = new Rectangle(decimalButton.Location.X, decimalButton.Location.Y, decimalButton.Width, decimalButton.Height);
            squareRootButtonOriginalRectangle = new Rectangle(squareRootButton.Location.X, squareRootButton.Location.Y, squareRootButton.Width, squareRootButton.Height);
            multiplyButtonOriginalRectangle = new Rectangle(multiplyButton.Location.X, multiplyButton.Location.Y, multiplyButton.Width, multiplyButton.Height);
            divideButtonOriginalRectangle = new Rectangle(divideButton.Location.X, divideButton.Location.Y, divideButton.Width, divideButton.Height);
            minusButtonOriginalRectangle = new Rectangle(minusButton.Location.X, minusButton.Location.Y, minusButton.Width, minusButton.Height);
            equalButtonOriginalRectangle = new Rectangle(equalButton.Location.X, equalButton.Location.Y, equalButton.Width, equalButton.Height);
            plusButtonOriginalRectangle = new Rectangle(plusButton.Location.X, plusButton.Location.Y, plusButton.Width, plusButton.Height);
            displayLabelOriginalRectangle = new Rectangle(displayLabel.Location.X, displayLabel.Location.Y, displayLabel.Width, displayLabel.Height);
        }
        private void Calculator_Resize(object sender, EventArgs e)
        {
            resizeControl(oneButtonOriginalRectangle, oneButton);
            resizeControl(twoButtonOriginalRectangle, twoButton);
            resizeControl(threeButtonOriginalRectangle, threeButton);
            resizeControl(fourButtonOriginalRectangle, fourButton);
            resizeControl(fiveButtonOriginalRectangle, fiveButton);
            resizeControl(sixButtonOriginalRectangle, sixButton);
            resizeControl(sevenButtonOriginalRectangle, sevenButton);
            resizeControl(eightButtonOriginalRectangle, eightButton);
            resizeControl(nineButtonOriginalRectangle, nineButton);
            resizeControl(zeroButtonOriginalRectangle, zeroButton);
            resizeControl(backSpaceButtonOriginalRectangle, backSpaceButton);
            resizeControl(plusMinusButtonOriginalRectangle, plusMinusButton);
            resizeControl(clearButtonOriginalRectangle, clearButton);
            resizeControl(decimalButtonOriginalRectangle, decimalButton);
            resizeControl(squareRootButtonOriginalRectangle, squareRootButton);
            resizeControl(multiplyButtonOriginalRectangle, multiplyButton);
            resizeControl(divideButtonOriginalRectangle, divideButton);
            resizeControl(minusButtonOriginalRectangle, minusButton);
            resizeControl(equalButtonOriginalRectangle, equalButton);
            resizeControl(plusButtonOriginalRectangle, plusButton);
            resizeControl(displayLabelOriginalRectangle, displayLabel);
        }

        private void resizeControl(Rectangle OriginalControlRect, Control control)
        {
            float xAxis = (float)(this.Width) / (float)(originalFormSize.Width);
            float yAxis = (float)(this.Height) / (float)(originalFormSize.Height);

            int newXPosition = (int)(OriginalControlRect.X * xAxis);
            int newYPosition = (int)(OriginalControlRect.Y * yAxis);

            int newWidth = (int)(OriginalControlRect.Width * xAxis);
            int newHight = (int)(OriginalControlRect.Height * yAxis);

            control.Location = new Point(newXPosition, newYPosition);
            control.Size = new Size(newWidth, newHight);
        }

        float num1, num2, result;
        char operation;
        bool dec = false;

        private void changeLabel(int numPressed)
        {
            if (dec == true)
            {
                int decimalCount = 0;
                foreach (char c in displayLabel.Text)
                {
                    if (c == '.')
                    {
                        decimalCount++;
                    }
                }
                if (decimalCount < 1)
                {
                    displayLabel.Text = displayLabel.Text + ".";
                }
                dec = false;
            }
            else
            {
                if(displayLabel.Text.Equals("0") == true && displayLabel.Text != null)
                {
                    displayLabel.Text = numPressed.ToString();
                }
                else if(displayLabel.Text.Equals("-0") == true)
                {
                    displayLabel.Text = "-" + numPressed.ToString();
                }
                else
                {
                    displayLabel.Text = displayLabel.Text + numPressed.ToString();
                }
            }
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            changeLabel(0);
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            changeLabel(1);

        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            changeLabel(2);

        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            changeLabel(3);

        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            changeLabel(4);

        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            changeLabel(5);

        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            changeLabel(6);

        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            changeLabel(7);

        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            changeLabel(8);

        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            changeLabel(9);

        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            dec = true;
            changeLabel(0);
        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {

        }

        private void squareRootButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {

        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {

        }

        private void divideButton_Click(object sender, EventArgs e)
        {

        }

        private void minusButton_Click(object sender, EventArgs e)
        {

        }

        private void plusButton_Click(object sender, EventArgs e)
        {

        }

        private void equalsButton_Click(object sender, EventArgs e)
        {

        }

    }
}
