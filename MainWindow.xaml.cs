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
using WeigthLoss.Interface;
using WeigthLoss.Models;

namespace WeigthLoss
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

        private void MinButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ImgClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        private void ToolBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            DateTime date = DateTime.Now;

            string[] str = { tbName.Text, tbFname.Text, tbAge.Text, txWeigth.Text, tbHeigth.Text, date.ToString() };

            IPeople people = new People();

            lblRezult.Text = people.IMT(double.Parse(tbHeigth.Text), double.Parse(txWeigth.Text),str);
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (InfoGrid.Visibility == Visibility.Hidden)
            {
                lbSpisok.Items.Clear();
                InfoGrid.Visibility = Visibility.Visible;
                ListView list = GetPlayers.GetAll();
                if (list.Items.Count > 0)
                {
                    foreach (var item in list.Items)
                    {
                        lbSpisok.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Список пуст.", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                InfoGrid.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            TextBox[] texBocks = { tbName, tbFname, tbAge, tbHeigth, txWeigth };
            TexBocks.TBDef(texBocks);
            lblRezult.Text = null;
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            TextBox[] texBocks = { tbName, tbFname, tbAge, tbHeigth, txWeigth };
            TexBocks.TBDef(texBocks);
            lblRezult.Text = null;
        }
    }
}
