using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AfreecatvExplorer
{
    public partial class MainWindow : Window
    {
        private readonly String version = "1.0.0";

        public MainWindow()
        {
            InitializeComponent();
            Bitmap logo = AfreecatvExplorer.Properties.Resources.Afreecalogo;
            MemoryStream logoStream = new MemoryStream();
            logo.Save(logoStream, System.Drawing.Imaging.ImageFormat.Png);
            logoStream.Seek(0, SeekOrigin.Begin);
            BitmapFrame newImg = BitmapFrame.Create(logoStream);
            Logo.Source = newImg;

            ProgramName.Text = "AfreecatvExplorer v" + version;
            printLog(Log, ProgramName.Text + " was loaded successfully.");
        }

        private void onClickSimpleMode(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrEmpty(this.ID.Text))
            {
                MessageBox.Show("You must enter the bj unique ID or main website address.");
                return;
            }
        }
   
        private void onClickAdvencedMoade(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(this.ID.Text))
            {
                MessageBox.Show("You must enter the bj unique ID or main website address.");
                return;
            }
        }
 
        public static void printLog(Object controlType, String message)
        {
            TextBox box = (TextBox)controlType;
            box.Text = new StringBuilder("[" + DateTime.Now.ToString("G") + "] " + message).ToString();
        }
    }
}
