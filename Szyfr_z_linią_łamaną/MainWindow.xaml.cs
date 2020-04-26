using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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


namespace Szyfr_z_linią_łamaną
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
          
        }
        public int N=5;
       

       public static String szyfrowanie(string tekst,int N)
        {
            int długość = tekst.Length;
            Console.WriteLine("Długość napisu: " + długość);

            char[,] tablica = new char[N, długość];

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




            char[] zaszyfrowane = new char[długość];
            int r = 0;
            foreach (char litera in tablica)
            {
                if (litera != '\0')
                {
                    zaszyfrowane[r] = litera;
                    r++;
                }
            }

            return new string(zaszyfrowane);
        }
        //szyfrowanie_end


        static String deszyfrowanie(string tekst, int N)
        {

            int długość = tekst.Length;
            Console.WriteLine("Długość napisu: " + długość);
            int s = 1;
            int j = N - s;
            int z = 2 * (N - 1);
            int i = 0;
            int p = 0;
            char[,] tablica = new char[N, długość];
            char[] odszyfrowane = new char[długość];
            
            if(długość<N)
            {
               
                for (i = długość - 1; i > -1; i--)
                {
                    odszyfrowane[p] += tekst[i];
                    p++;
                }
                return new string(odszyfrowane);
            }

            else
            { 
            while (i != N)
            {
                tablica[i, j] = tekst[p];
                p++;
                if (i != 0 & j + i * 2 < długość & i != N - 1)
                {
                    tablica[i, j + i * 2] = tekst[p];
                    p++;
                }
                j = j + z;
                if (j >= długość)
                {
                    i++;
                    s++;
                    j = N - s;
                }
            }


            i = N;
            j = -1;
            z = 0;
            bool reverse = true;
            for (p = 0; p < długość; p++)
            {
                if (reverse == true)
                {
                    i--;
                    j++;
                    z++;
                }
                else
                {
                    i++;
                    j++;
                    z++;
                }
                odszyfrowane[p] = tablica[i, j];
                if (z == N)
                {
                    {
                        z = 1;

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

        }
            return new string(odszyfrowane);
        }
        //deszyfrowanie_end


        static String odczyt_z_pliku(String path)
        {
            string s = File.ReadAllText(path, Encoding.Default);
            return s;
        }

        String tekst;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            tekst = textBox1.Text;
            textBox2.Text = szyfrowanie(tekst,N);

        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            tekst = textBox3.Text;
            textBox4.Text = deszyfrowanie(tekst,N);

        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            checkBox2.IsChecked = false;
            textBox1.IsEnabled = true;
            textBox1.Clear();
            textBox2.Clear();


            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Document"; // Default file name
            dlg.DefaultExt = ".txt"; // Default file extension
            dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            // Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                string path = dlg.FileName;
                textBox1.Text = odczyt_z_pliku(path);
            }


        }

        private void checkBox2_Checked(object sender, RoutedEventArgs e)
        {
            checkBox1.IsChecked = false;
            textBox1.IsEnabled = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void checkBox3_Checked(object sender, RoutedEventArgs e)
        {
            checkBox4.IsChecked = false;
            textBox3.IsEnabled = true;
            textBox4.Clear();
            textBox3.Clear();
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Document"; // Default file name
            dlg.DefaultExt = ".txt"; // Default file extension
            dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension
            // Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();
            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                string path = dlg.FileName;
                textBox3.Text = odczyt_z_pliku(path);
            }
        }

        private void checkBox4_Checked(object sender, RoutedEventArgs e)
        {
            checkBox3.IsChecked = false;
            textBox3.IsEnabled = true;
            textBox3.Clear();
            textBox4.Clear();
            textBox3.Focus();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Ustawienia u = new Ustawienia();
            u.textBox1.Text = N.ToString();
            u.ShowDialog();
            N = u.Key;
            
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Ustawienia u = new Ustawienia();
            u.textBox1.Text = N.ToString();
            u.ShowDialog();
            N = u.Key;

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
           Zasada_działania zd = new Zasada_działania();
            zd.ShowDialog();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (.txt)|.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            Nullable<bool> result = saveFileDialog1.ShowDialog();
            if (result == true)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    byte[] buffer = Encoding.Default.GetBytes(textBox2.Text);
                    myStream.Write(buffer, 0, buffer.Length);

                    myStream.Close();
                }
            }

        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (.txt)|.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            Nullable<bool> result = saveFileDialog1.ShowDialog();
            if (result == true)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    byte[] buffer = Encoding.Default.GetBytes(textBox3.Text);
                    myStream.Write(buffer, 0, buffer.Length);

                    myStream.Close();
                }
            }

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (.txt)|.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            Nullable<bool> result = saveFileDialog1.ShowDialog();
            if (result == true)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    byte[] buffer = Encoding.Default.GetBytes(textBox1.Text);
                    myStream.Write(buffer, 0, buffer.Length);

                    myStream.Close();
                }
            }

        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (.txt)|.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            Nullable<bool> result = saveFileDialog1.ShowDialog();
            if (result == true)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    byte[] buffer = Encoding.Default.GetBytes(textBox4.Text);
                    myStream.Write(buffer, 0, buffer.Length);

                    myStream.Close();
                }
            }

        }
    }
}
