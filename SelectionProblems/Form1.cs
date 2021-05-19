using Microsoft.VisualBasic;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace SelectionProblems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Write a program which will accept as input a persons show size and then make a comment depending on the size. Use 
         * the following three size categories: 
         * a) size 4 and under
         * b) between 5 and 9
         * c) greater than 9
         */
        private void BtnSizeSelector_Click(object sender, EventArgs e)
        {
            int size;

            size = Convert.ToInt32(Interaction.InputBox("Please enter your size.", "Size", ""));

            if (size <= 4)
            {
                MessageBox.Show("Your size is a Small");
            }
            else if (size >= 5 && size <= 9)
            {
                MessageBox.Show("Your size is Medium");
            }
            else
            {
                MessageBox.Show("Your size is a Large");
            }
        }

        /*
         * Write a program which will accept 4 marks and determine the average. Once the average is determined the program
         * should display either “You have a passing grade” or “Sorry you have a failing grade”
         */
        private void BtnPassOrFail_Click(object sender, EventArgs e)
        {
            float mark1;
            float mark2;
            float mark3;
            float mark4;
            float average;

            mark1 = float.Parse(Interaction.InputBox("Please enter your first mark", "Mark one", ""), CultureInfo.InvariantCulture);
            mark2 = float.Parse(Interaction.InputBox("Please enter your second mark", "Mark one", ""), CultureInfo.InvariantCulture);
            mark3 = float.Parse(Interaction.InputBox("Please enter your third mark", "Mark one", ""), CultureInfo.InvariantCulture);
            mark4 = float.Parse(Interaction.InputBox("Please enter your fourth mark", "Mark one", ""), CultureInfo.InvariantCulture);

            average = (mark1 + mark2 + mark3 + mark4) / 4;

            if (average > 49)
            {
                MessageBox.Show("You have a passing grade.");
            }
            else
            {
                MessageBox.Show("You have a failing grade");
            }

        }

        /*
         * Write a program which accepts a mark and then determines the letter grade to assign it. Letter grades are assigned follows:
         * 0 <= mark < 50 F
         * 50 <= mark < 60 D
         * 60 <= mark < 70 C
         * 70 <= mark < 80 B
         * 80 <= mark < 100 A
         */
        private void BtnGrading_Click(object sender, EventArgs e)
        {
            int mark;

            mark = Convert.ToInt32(Interaction.InputBox("Please enter your mark", "", ""));

            if (mark < 50)
            {
                MessageBox.Show("Your Grade is a F.");
            }
            else if (mark <= 50 && mark < 60)
            {
                MessageBox.Show("Your Grade is a D.");
            }
            else if (mark <= 60 && mark < 70)
            {
                MessageBox.Show("Your mark is a C.");
            }
            else if (mark <= 70 && mark < 80)
            {
                MessageBox.Show("Your mark is a B.");
            }
            else
            {
                MessageBox.Show("Your mark is an A.");
            }
        }

        /*
         * A gas company measures the amount of gas its customers use in hundreds of cubic feet (ccf) and charges them
         * according to the following schedule:
         * first 8 ccf 50 cents each
         * more than 8 ccf 30 cents each
         * Note that the 30 cent rate applies only to usage above 8 ccf. A customer who uses 10 ccf is charged 50 cents for the
         * first 8 ccf and 30 cents for the next 2 ccf. Write a program to calculate customer’s bills.
         */
        private void BtnGasRates_Click(object sender, EventArgs e)
        {
            int amount;
            int remaining;

            amount = Convert.ToInt32(Interaction.InputBox("Please enter your amount used.", "", ""));

            if (amount <= 8)
            {
                amount *= 50;
            }
            else
            {
                remaining = amount - 8;
                remaining *= 30;

                amount = (8 * 50) + remaining;
            }
            MessageBox.Show("Your bill this month was R" + amount);

        }

        /*
         * Assume that the cost, not including tax, for sending a telegram from Hamilton to Montreal is $4.50 for the first twenty
         * words or less, plus $.17 for each additional word beyond twenty. Write a program which accepts the number of words
         * and then determines the total cost.
         */
        private void BtnTelegram_Click(object sender, EventArgs e)
        {
            float baseCost = 4.50f;
            float extraWordCost = 0.17f;
            int numberOfWords;
            float remaining;
            float totalCost = 0;

            numberOfWords = Convert.ToInt32(Interaction.InputBox("Please enter the amount of words.", "Word Calculator", ""));

            if (numberOfWords <= 20)
            {
                totalCost = baseCost * numberOfWords;
            }
            else
            {
                remaining = numberOfWords - 20;
                remaining *= extraWordCost;

                totalCost = (baseCost * 20) + remaining;
            }
            MessageBox.Show("The Total Cost for this Telegram is R" + totalCost);

        }

        /*
         * An electric company measures the amount of electricity its customer use in kilowatt hours (kWh) and charges them
         * according to the following schedule:
         * first 12 kWh or less $2.80
         * next 78 kWh 8 cents each kWh
         * excess above 90 kWh 6 cents each kWh
         * Note that the minimum bill is $2.80. Write a program to calculate a customers bill.
         */
        private void BtnElectricityRates_Click(object sender, EventArgs e)
        {
            int amountOfkWh;
            float remaining;
            float bill = 0;

            amountOfkWh = Convert.ToInt32(Interaction.InputBox("Please enter the amount of kWh.", "kWh Calculator.", ""));

            if (amountOfkWh <= 12)
            {
                bill = 2.80f;
            }
            else if (amountOfkWh > 12 && amountOfkWh <= 90)
            {
                bill = 2.80f;
                remaining = (amountOfkWh - 12) * 0.8f;
                bill += remaining;
            }
            else if (amountOfkWh > 90)
            {
                bill = 2.80f + (78 * 0.80f) + ((amountOfkWh - 90) * 0.06f);
            }

            MessageBox.Show("Your bill is R" + bill);
        }

        /*
         * Write a program which determines the amount of Federal Income Tax one owes when given the taxable income.
         * Federal tax is determined as follows:
         * Taxable Income                                                   Tax
         * $1295 or less                                                    6%
         * greater than 1295 and less than or equal to 2590                 $78 + 16% on next 1295
         * greater than 2590 and less than or equal to 5180                 $285 + 17% on next 2590
         * greater than 5180 and less than or equal to 7770                 $725 + 18% on next 2590
         * greater than 7770 and less than or equal to 12950                $1191 + 19% on next 5180
         * greater than 12950 and less than or equal to 18130               $2176 + 20% on next 5180
         * greater than 18130 and less than or equal to 23310               $3212 + 23% on next 5180
         * greater than 23310 and less than or equal to 36260               $4403 + 25% on next 12950
         * greater than 36260 and less than or equal to 62160               $7641 + 30% on next 25900
         * greater than 62160                                               $15411 + 34% on remainder
         */
        private void BtnTaxBracket_Click(object sender, EventArgs e)
        {
            float grossIncome = 0;
            float tax = 0;

            grossIncome = float.Parse(Interaction.InputBox("Please enter your gross income.", "Tax Calculator.", ""), CultureInfo.InvariantCulture);

            if (grossIncome <= 1295)
                tax = grossIncome * 0.06f;

            else if (grossIncome > 1295 && grossIncome <= 2590)
                tax = ((grossIncome - 1295) * 0.16f) + 78;

            else if (grossIncome > 2590 && grossIncome <= 5180)
                tax = ((grossIncome - 2590) * 0.17f) + 285;

            else if (grossIncome > 5180 && grossIncome <= 7770)
                tax = ((grossIncome - 2590) * 0.18f) + 725;

            else if (grossIncome > 7770 && grossIncome <= 12950)
                tax = ((grossIncome - 5180) * 0.19f) + 1191;

            else if (grossIncome > 12950 && grossIncome <= 18130)
                tax = ((grossIncome - 5180) * 0.20f) + 2176;

            else if (grossIncome > 18130 && grossIncome <= 23310)
                tax = ((grossIncome - 5180) * 0.23f) + 3212;

            else if (grossIncome > 23310 && grossIncome <= 36260)
                tax = ((grossIncome - 12950) * 0.25f) + 4403;

            else if (grossIncome > 36260 && grossIncome <= 62160)
                tax = ((grossIncome - 25900) * 0.30f) + 7641;

            else
                tax = ((grossIncome - 25900) * 0.34f) + 15411;

            MessageBox.Show("The amount of tax owed on R" + grossIncome + " is R" + tax);
        }
    }
}
