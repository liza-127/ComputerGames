using Model.Core;
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
using System.Windows.Shapes;

namespace ComputerGames
{
    /// <summary>
    /// Логика взаимодействия для CatalogMain.xaml
    /// </summary>
    public partial class CatalogMain : Window
    {

        private GameCatalog _catalog = new GameCatalog();
        private GameCatalog ListGame = new GameCatalog();



        public CatalogMain()
        {
            InitializeComponent();

            PlatformCombox.ItemsSource = _catalog.SortGames(_catalog.GetAllGames());
            MaxBlock.Text = ListGame.MaxRating(ListGame.GetAllGames()).ToString();
            MinBlock.Text = ListGame.MinRating(ListGame.GetAllGames()).ToString();
            SrBlock.Text = ListGame.AverageRating(ListGame.GetAllGames()).ToString();
            MidBlock.Text = ListGame.MedianRating(ListGame.GetAllGames()).ToString();



        }
        // Этот метод автоматически срабатывает при выборе платформы или режима
        private void FilterGames(object sender, SelectionChangedEventArgs e)
        {
            // Проверка, чтобы избежать ошибок при первоначальной загрузке окна
            if (PlatformCombox == null || _catalog.GetAllGames() == null) return;


            List<Game> Games = _catalog.SortGames(_catalog.GetAllGames());

            // Получаем выбранные значения в виде строк
            string Platform = (PlatformSort.SelectedItem as ComboBoxItem)?.Content?.ToString(); // PlatformSort.SelectedItem  - элемент который на данный момент выбран Content? - то что хранит платформа 
            string Mode = (RejimSort.SelectedItem as ComboBoxItem)?.Content?.ToString();


            if (Platform != "Выберите вариант...")
            {

                Games = _catalog.SortPlatform(Games, Platform);
                MaxBlock.Text = ListGame.MaxRating(Games).ToString();
                MinBlock.Text = ListGame.MinRating(Games).ToString();
                SrBlock.Text = ListGame.AverageRating(Games).ToString();
                MidBlock.Text = ListGame.MedianRating(Games).ToString();
            }


            if (Mode != "Выберите вариант...")
            {

                Games = _catalog.SortMode(Games, Mode);
                MaxBlock.Text = ListGame.MaxRating(Games).ToString();
                MinBlock.Text = ListGame.MinRating(Games).ToString();
                SrBlock.Text = ListGame.AverageRating(Games).ToString();
                MidBlock.Text = ListGame.MedianRating(Games).ToString();
            }


            PlatformCombox.ItemsSource = Games;
        }
        private void CloseButton(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        private void ButtonGeneration(object sender, RoutedEventArgs e)
        {
            //добавлять или удалять игру 
        }
        //сделать метод что при выборе джисона или хмл сохраняется в папку файл с сереализацией а потом наверное она высвечиваться в кнопке "InformationButton"

        private void InformationButton(object sender, RoutedEventArgs e)
        {
            // должна высвечиваться информация о выбраном обьекте 
        }

          //еще наверное сделать сохранение??





    }
}





    


