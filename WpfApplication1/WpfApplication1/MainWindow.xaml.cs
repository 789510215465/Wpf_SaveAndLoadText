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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
private void SaveBtn_Click(object sender, RoutedEventArgs e)
    {
        // 存檔(路徑,文字內容)
        Microsoft.Win32.SaveFileDialog dig = new Microsoft.Win32.SaveFileDialog();

        // 顯示視窗
        Nullable<bool> result = dig.ShowDialog();

        // 當按下儲存後之反應
        if (result == true)
        {
            System.IO.File.WriteAllText(dig.FileName, Textarea.Text);
        }
    }

        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            // 產生儲存檔案視窗 OpenFileDialog
            Microsoft.Win32.OpenFileDialog dig = new Microsoft.Win32.OpenFileDialog();

            // 顯示視窗
            Nullable<bool> result = dig.ShowDialog();

            // 當按下儲存後之反應
            if (result == true)
            {
                 Textarea.Text = System.IO.File.ReadAllText(dig.FileName);
            }
        }
    }   
}