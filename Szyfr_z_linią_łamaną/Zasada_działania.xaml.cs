using System;
using System.Collections.Generic;
using System.Data;
using System.Media;
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
  
    public partial class Zasada_działania : Window
    {
        public Zasada_działania()
        {
            InitializeComponent();
           
        }

        static char[,] szyfrowanie_tablica(string tekst, int N)
        {
            int długość = tekst.Length;
            Console.WriteLine("Długość napisu: " + długość);

            char[,] tablica = new char[N, długość];

            for (int a = 0; a < N; a++)
            {
                for (int b = 0; b < długość; b++)
                    tablica[a,b] ='*'; 

            }

            int i = N;
            int j = -1;
            int pom = 0;
            bool reverse = true;
            for (int p = 0; p < długość; p++)
            {
                if (reverse == true)
                {
                    i--;
                    j++;
                    pom++;
                }
                else
                {
                    i++;
                    j++;
                    pom++;
                }
                tablica[i, j] = tekst[p];


                if (pom == N)
                {
                    {
                        pom = 1;

                        if (reverse == false)
                        {
                            reverse = true;
                        }
                        else
                        {
                            reverse = false;
                        }
                    }
                }
            }
            return tablica;
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            string tekst = textBox.Text;
           
            try
            {
                int N = int.Parse(textBox1.Text);
                if (N <= 1)
                {
                    MessageBox.Show("Błędna wartość klucza");

                }           
                char[,] tablica = szyfrowanie_tablica(tekst, N);
                textBox2.Clear();
                var dataTable = GetTable(tekst, N, tablica);
                dgData.ItemsSource = dataTable.DefaultView;
            }
            catch
            {
                MessageBox.Show("Błędna wartość klucza");
            }


        }

        static DataTable GetTable(String tekst,int N, char[,] tablica)
        {
            var dataTable = new DataTable();
            int długość = tekst.Length;
            for (int i = 0; i < długość; i++)
            {
                dataTable.Columns.Add(i.ToString(), typeof(String));
            }

            object[] rows = new object[N];
          for (int k = 0; k < N; k++)
            {
                String[] row = new String[długość];
                for (int z = 0; z < długość; z++)
                {
                    row[z] = tablica[k, z].ToString();
                }
                rows[k] = row;
            }


            foreach (String[] rowArray in rows)
            {
                dataTable.Rows.Add(rowArray);
            }
            return dataTable;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string tekst = textBox.Text;
            int N = int.Parse(textBox1.Text); 
            textBox2.Text = MainWindow.szyfrowanie(tekst, N);
        }

        private void dgData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
