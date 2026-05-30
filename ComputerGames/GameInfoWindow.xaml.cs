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
    /// Логика взаимодействия для GameInfoWindow.xaml
    /// </summary>
    public partial class GameInfoWindow : Window
    {


        public GameInfoWindow(Game game)
        {
            InitializeComponent();
            TitleBlock.Text = game.Title;
            GenreBlock.Text = $"Жанр: {game.Genre}";
            RatingBlock.Text = $"Рейтинг: {game.Rating}";
            AgeBlock.Text = $"Возраст: {game.AgeRating}+";
            ReleaseBlock.Text = $"Дата выхода: {game.ReleaseDate:dd.MM.yyyy}";
            ModeBlock.Text = $"Тип: {game.GameMode}";

            try
            {
                GameImage.Source =
                    new BitmapImage(new Uri(game.ImageURL));
            }
            catch
            {
                System.Windows.MessageBox.Show("Не удалось загрузить изображение");
            }
        }
    }
}
