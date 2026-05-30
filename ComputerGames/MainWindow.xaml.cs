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
using System;
using System.IO;
using System.Windows.Forms;


namespace ComputerGames
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        private static string selectFolderPath;
   
        public MainWindow()
        {
            InitializeComponent();
            //selectFolderPath = "не выбрана";
            if (selectFolderPath != "не выбрана")
            {
                SavePath.Text = "выбрана";
            }



        }
        static MainWindow()
        {
            selectFolderPath = "не выбрана";
        
        }
        private void Goto_Catalog(object sender, RoutedEventArgs e)
        {
            if (selectFolderPath != "не выбрана")
            {
                CatalogMain catalogMain = new CatalogMain();
                catalogMain.Show();
                this.Close();
            }
            else
            {
                // System.Windows.MessageBox.Show - выплывющее окно 
                System.Windows.MessageBox.Show("Вы не выбрали папку для сохранения!","Ошибка", MessageBoxButton.OK);

                    return;
                
            }
         
           
        }
        private void LoadingPathClick(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog(); // создаем окно выбора папки 
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) // dialog.ShowDialog()  - открываем проводник и далее проверяем нажал ли пользователь ок
            {
               
                SavePath.Text = "выбрана"; 
                selectFolderPath = dialog.SelectedPath; // сохраняем путь файла который мы выбрали 
            }
        }

    }
}