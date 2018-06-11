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

namespace todolist
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

        // 新增按鈕按下事件
        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            // 產生 TodoItem
            TodoItem item = new TodoItem();
            item.ItemName = "New";
            item.DeleteItem += new EventHandler(DeleteItem);

            // 放到清單中
            TotoItemList.Children.Add(item);
        }

        // 刪除事件
        private void DeleteItem(object sender, EventArgs e)
        {
            TotoItemList.Children.Remove((TodoItem)sender);
        }

        // 關閉視窗事件
        private void Window_Closed(object sender, EventArgs e)
        {
            // 新增一個串列裝每個項目轉成的文字
            List<string> datas = new List<string>();

            // 存檔
            System.IO.File.WriteAllLines(@"C:\temp\data.txt", datas);
        }

        // 開啟視窗事件
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // 開檔
            string[] lines = System.IO.File.ReadAllLines(@"C:\temp\data.txt");

            // 分析每一行
            foreach (string line in lines)
            {
                // 用 | 符號拆開
                string[] parts = line.Split('|');

                // 建立 TodoItem
                TodoItem item = new TodoItem();
                item.ItemName = parts[1];
                item.DeleteItem += new EventHandler(DeleteItem);

                // 放到清單中
                TotoItemList.Children.Add(item);
            }
            }
    }
}
