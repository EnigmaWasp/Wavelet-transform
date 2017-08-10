using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xaml;
using System.Threading;

namespace Simplex_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread thread1 = new Thread(new ThreadStart(thr1));
        Thread thread2 = new Thread(new ThreadStart(thr1));
        Thread thread3 = new Thread(new ThreadStart(thr1));
        Thread thread4 = new Thread(new ThreadStart(thr1));
        Thread thread5 = new Thread(new ThreadStart(thr1));
        Thread thread6 = new Thread(new ThreadStart(thr1));
        Thread thread7 = new Thread(new ThreadStart(thr1));
        static void thr1()
        {
            for (int i = 0; i <= 199; i++)
            {
                for (int j = 0; j <= 99999; j++)
                {

                }
            }
        }
        private void Main_calc()
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            textBox1.Clear();
            textBox2.Clear();
            double[,] table = { {6, 1,  2}, 
                                {8, 2,  1}, 
                                {1, - 1, 1},                                 
                                {0, -3, -2} };

            double[] result = new double[2];
            double[,] table_result;
            Simplex S = new Simplex(table);
            table_result = S.Calculate(result);
            for (int i = 0; i < table_result.GetLength(0); i++)
            {
                for (int j = 0; j < table_result.GetLength(1); j++)
                    richTextBox1.AppendText(Math.Round(table_result[i, j], 2).ToString() + "  ");
                richTextBox1.AppendText("\n");
            }
            textBox1.Text = Math.Round(result[0], 2).ToString();
            textBox2.Text = Math.Round(result[1], 2).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear(); 
            int[,] arr = GetArray();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                
                {
                    richTextBox2.AppendText(arr[i, 0].ToString() + "x" + j+1+ "+ ");
                    richTextBox2.AppendText(arr[i, 1].ToString() + "x2" + "<= ");
                    richTextBox2.AppendText(arr[i, 2].ToString());
                }
                richTextBox2.AppendText("\n");
            }


        }
        static int[,] GetArray()
        {
            string s = textBox8.Text;




































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































            string[,] arr1 = ;
            int[,] array = { {1,2,6}, 
                             {2,1,8}, 
                             {-1,1,1},                                 
                             {-3,-2,0} };
            return array;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //Ввод параметров графа
                int n = 0, s = 0, m, k = 0, mod_e;      // mod_e - Кол-во ребер (во всем графе)
                mod_e = k;                      // k - счетчик массивов ребер
                int[] a = new int[200];         // массив начал ребер
                int[] b = new int[200];         // массив концов ребер
                int[] w = new int[200];         // массив весов ребер
                int[] d = new int[200];         // массив расстояний
                string mm, aa, bb, ww, dd;
                string[] result;

                n = int.Parse(textBox3.Text);       // Количество вершин            
                s = int.Parse(textBox4.Text); // Стартовая вершина
                // Задание массивов ребер            
                aa = textBox5.Text;
                bb = textBox6.Text;
                ww = textBox7.Text;
                //массив расстояний 
               // result = aa.Split(",", StringSplitOptions.None);
                for (int i = 1; i <= n; i++) // Задание массивов ребер
                {
                   // foreach (string s in result)
                    {
                       // string s1 = aa.Split(",", StringSplitOptions.RemoveEmptyEntries);
                        //m = Convert.ToInt32(s1, 16);
                        m = int.Parse(Console.ReadLine());
                        for (int j = 1; j <= m; j++)
                        {
                            a[k] = i;
                           // Console.WriteLine("\nВведите номер конечной вершины для " + j + "-го ребра, исходящего из " + i + ":");
                            b[k] = int.Parse(Console.ReadLine());
                          //  Console.WriteLine("\nВведите вес " + j + "-го ребра, исходящего из " + i + ":");
                            w[k] = int.Parse(Console.ReadLine());
                            k++;
                        }
                    }
                    mod_e++;
                }
                for (int i = 1; i <= n; i++) d[i] = 999999;
                d[s] = 0;
                for (int i = 1; i < n; i++)
                {
                    if (i == s) i++;
                    else
                    {
                        for (int j = 1; j <= mod_e; j++)
                        {
                            if (d[b[j]] > (d[a[j]] + w[j])) d[b[j]] = d[a[j]] + w[j];
                            j++;
                        }
                        i++;
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("При вводе данных произошла ошибка!");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            thread1.Start();

            //
            for (int i = 0; i <= 100; i++)
            {


                if (thread1.IsAlive == true)
                    progressBar1.Increment(i++);
                else
                {
                    progressBar1.Increment(i--);
                }
            }
        }
    }
}