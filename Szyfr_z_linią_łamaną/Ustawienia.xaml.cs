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
using System.Windows.Shapes;

namespace Szyfr_z_linią_łamaną
{
    
    public partial class Ustawienia : Window
    {
        public Ustawienia()
        {
            InitializeComponent();
        }

        public int Key
        { get; set; }
        

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Key = int.Parse(textBox1.Text);
                if (this.Key <= 1)
                {
                    MessageBox.Show("Błędna wartość");

                }
                else
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Błędna wartość");

            }

        }

   
    }
}
