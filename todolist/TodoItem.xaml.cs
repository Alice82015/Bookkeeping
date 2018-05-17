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
    /// TodoItem.xaml 的互動邏輯
    /// </summary>
    public partial class TodoItem : UserControl
    {
        public TodoItem()
        {
            InitializeComponent();
        }
        // 自訂方法 : 取得輸入文字
        public string GetTaskName()
        {
            return TaskName.Text;
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
