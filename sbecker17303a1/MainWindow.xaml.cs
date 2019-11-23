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

namespace sbecker17303a1
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

        private void CalcButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox0.Text = Ex3aLoops.Calc0(inputTextBox0a.Text, inputTextBox0b.Text, inputTextBox0c.Text);
            resultTextBo10.Text = Ex3aLoops.Calc1(inputTextBox1a.Text, inputTextBox1b.Text, inputTextBox1c.Text);
            resultTextBo20.Text = Ex3aLoops.Calc2(inputTextBox2a.Text, inputTextBox2b.Text, inputTextBox2c.Text);
            resultTextBox30.Text = Ex3aLoops.Calc3(
                inputTextBox3a.Text, inputTextBox3b.Text, inputTextBox3c.Text);
            resultTextBox40.Text = Ex3aLoops.Calc4(
                inputTextBox4a.Text, inputTextBox4b.Text, inputTextBox4c.Text);
            resultTextBox50.Text = Ex3aLoops.Calc5(
                inputTextBox5a.Text, inputTextBox5b.Text, inputTextBox5c.Text);
            resultTextBox60.Text = Ex3aLoops.Calc6(
                inputTextBox6a.Text, inputTextBox6b.Text);
            resultTextBox70.Text = Ex3aLoops.Calc7(
                inputTextBox7a.Text, inputTextBox7b.Text);
            resultTextBox80.Text = Ex3aLoops.Calc8(
                inputTextBox8a.Text, inputTextBox8b.Text);
        }
    }
}
