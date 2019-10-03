using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tinhdiemsinhvien
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

        private void btnhuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnkq_Click(object sender, RoutedEventArgs e)
        {
            double dvan = double.Parse(txtdiemvan.Text);
            double dtoan = double.Parse(txtdiemtoan.Text);
            double dtb = 0.000F;
            dtb= (dvan+dtoan)/2.000F;


            
            if (rbtot.IsChecked == true)
            {
                if (dtb >= 8.0) 
                {
                    MessageBox.Show("Tên SV: " + txtten.Text + "\n" + "Mã SV: " + txtma.Text + "\n" + "Điểm trung bình: " + dtb + "\n" + "Khen thưởng: " + "Sinh viên Tốt");
                }
                else
                    MessageBox.Show("Tên SV: " + txtten.Text + "\n" + "Mã SV: " + txtma.Text + "\n" + "Điểm trung bình: " + dtb + "\n" + "Khen thưởng: " + "Sinh viên Khá");
       
            }

            if (rbkha.IsChecked == true)
            {
                if (dtb >= 7.0)
                {
                    MessageBox.Show("Tên SV: " + txtten.Text + "\n" + "Mã SV: " + txtma.Text + "\n" + "Điểm trung bình: " + dtb + "\n" + "Khen thưởng: " + "Sinh viên Khá");
                }
                else
                    MessageBox.Show("Tên SV: " + txtten.Text + "\n" + "Mã SV: " + txtma.Text + "\n" + "Điểm trung bình: " + dtb + "\n" + "Khen thưởng: " + "Không khen thưởng");
       
            }

            if (rbyeu.IsChecked == true)
            {
                MessageBox.Show("Tên SV: " + txtten.Text + "\n" + "Mã SV: " + txtma.Text + "\n" + "Điểm trung bình: " + dtb + "\n" + "Khen thưởng: " + "Không khen thưởng");
      
            }
            
        }
        
    }
    class sinhvien
    {
        sinhvien dat = new sinhvien();

    }
        
}
