using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FactorialCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void xCalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            Factorial();
            Permutations();
            Combinations();
        }

        public void Factorial()
        {
            double number = 0;
            int factorial = 1;
            Double.TryParse(xNumber.Text, out number);

            // Forumala to determine Factorial
            for (int x = 1; x <= number; x++)
            {
                factorial = factorial * x;
            }

            // Display Answer
            xResponeBlock.Text = ($"{number}! =");
            xResponeBlock.FontSize = 24;
            xAnswerBlock.Text = factorial.ToString();
        }

        public void Permutations()
        {
            double n = 0;
            double nFact = 1;
            double r = 0;

            Double.TryParse(xNObjects.Text, out n);
            Double.TryParse(xRSample.Text, out r);

            double nMinusR = n - r;
            double nMinusRFact = 1;

            for (int x = 1; x <= n; x++)
            {
                nFact = nFact * x;
            }

            for (int x = 1; x <= nMinusR; x++)
            {
                nMinusRFact = nMinusRFact * x;
            }

            double permutationsAnswer = nFact / nMinusRFact;
            xPermutationAnswer.Text = permutationsAnswer.ToString();

        }

        public void Combinations()
        {
            double n = 0;
            double nFact = 1;
            double r = 0;
            double rFact = 1;

            Double.TryParse(xNObjects.Text, out n);
            Double.TryParse(xRSample.Text, out r);

            double nMinusR = n - r;
            double nMinusRFact = 1;

            for (int x = 1; x <= n; x++)
            {
                nFact = nFact * x;
            }

            for (int x = 1; x <= r; x++)
            {
                rFact = rFact * x;
            }

            for (int x = 1; x <= nMinusR; x++)
            {
                nMinusRFact = nMinusRFact * x;
            }

            double combinationAnswer = nFact / (rFact * nMinusRFact);

            xCombinationAnswer.Text = combinationAnswer.ToString();
        }

        private void xExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}