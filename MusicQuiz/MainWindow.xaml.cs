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
using System.Xml.Serialization.Configuration;

namespace MusicQuiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();
        private string rootPath = (@"C:\Users\Colin\source\repos\MusicQuiz\MusicQuiz\Themes\");
        private string theme = (@"MovieQuotes1\");
        
        public MainWindow()
        {
            InitializeComponent();
            SetAndHideAnswers();
        }

        private void PlaySound(string soundPath)
        {
            mediaPlayer.Open(new Uri(soundPath));
            mediaPlayer.Play();
        }

        string[] answers = System.IO.File.ReadAllLines(@"C:\Users\Colin\source\repos\MusicQuiz\MusicQuiz\Themes\MovieQuotes1\Answers.txt");

        // Create a dropdown menu to change the theme.

        private void SetAndHideAnswers()
        {
            HideAnswers();
            answers = System.IO.File.ReadAllLines(rootPath + theme + "Answers.txt");
            Answer1.Text = answers[0];
            Answer2.Text = answers[1];
            Answer3.Text = answers[2];
            Answer4.Text = answers[3];
            Answer5.Text = answers[4];
            Answer6.Text = answers[5];
            Answer7.Text = answers[6];
            Answer8.Text = answers[7];
            Answer9.Text = answers[8];
            Answer10.Text = answers[9];
        }

        private void Button1_Click(object sender, RoutedEventArgs e){PlaySound(rootPath + theme + "1.mp3");}
        private void Button2_Click(object sender, RoutedEventArgs e) { PlaySound(rootPath + theme + "2.mp3"); }
        private void Button3_Click(object sender, RoutedEventArgs e) { PlaySound(rootPath + theme + "3.mp3"); }
        private void Button4_Click(object sender, RoutedEventArgs e) { PlaySound(rootPath + theme + "4.mp3"); }
        private void Button5_Click(object sender, RoutedEventArgs e) { PlaySound(rootPath + theme + "5.mp3"); }
        private void Button6_Click(object sender, RoutedEventArgs e) { PlaySound(rootPath + theme + "6.mp3"); }
        private void Button7_Click(object sender, RoutedEventArgs e) { PlaySound(rootPath + theme + "7.mp3"); }
        private void Button8_Click(object sender, RoutedEventArgs e) { PlaySound(rootPath + theme + "8.mp3"); }
        private void Button9_Click(object sender, RoutedEventArgs e) { PlaySound(rootPath + theme + "9.mp3"); }
        private void Button10_Click(object sender, RoutedEventArgs e) { PlaySound(rootPath + theme + "10.mp3"); }

        private void Button1Answer_Click(object sender, RoutedEventArgs e){if(Answer1.Visibility == Visibility.Hidden){Answer1.Visibility = Visibility.Visible;}else{Answer1.Visibility = Visibility.Hidden;}}
        private void Button2Answer_Click(object sender, RoutedEventArgs e) { if (Answer2.Visibility == Visibility.Hidden) { Answer2.Visibility = Visibility.Visible; } else { Answer2.Visibility = Visibility.Hidden; } }
        private void Button3Answer_Click(object sender, RoutedEventArgs e) { if (Answer3.Visibility == Visibility.Hidden) { Answer3.Visibility = Visibility.Visible; } else { Answer3.Visibility = Visibility.Hidden; } }
        private void Button4Answer_Click(object sender, RoutedEventArgs e) { if (Answer4.Visibility == Visibility.Hidden) { Answer4.Visibility = Visibility.Visible; } else { Answer4.Visibility = Visibility.Hidden; } }
        private void Button5Answer_Click(object sender, RoutedEventArgs e) { if (Answer5.Visibility == Visibility.Hidden) { Answer5.Visibility = Visibility.Visible; } else { Answer5.Visibility = Visibility.Hidden; } }
        private void Button6Answer_Click(object sender, RoutedEventArgs e) { if (Answer6.Visibility == Visibility.Hidden) { Answer6.Visibility = Visibility.Visible; } else { Answer6.Visibility = Visibility.Hidden; } }
        private void Button7Answer_Click(object sender, RoutedEventArgs e) { if (Answer7.Visibility == Visibility.Hidden) { Answer7.Visibility = Visibility.Visible; } else { Answer7.Visibility = Visibility.Hidden; } }
        private void Button8Answer_Click(object sender, RoutedEventArgs e) { if (Answer8.Visibility == Visibility.Hidden) { Answer8.Visibility = Visibility.Visible; } else { Answer8.Visibility = Visibility.Hidden; } }
        private void Button9Answer_Click(object sender, RoutedEventArgs e) { if (Answer9.Visibility == Visibility.Hidden) { Answer9.Visibility = Visibility.Visible; } else { Answer9.Visibility = Visibility.Hidden; } }
        private void Button10Answer_Click(object sender, RoutedEventArgs e) { if (Answer10.Visibility == Visibility.Hidden) { Answer10.Visibility = Visibility.Visible; } else { Answer10.Visibility = Visibility.Hidden; } }

        private void Game1_Selected(object sender, RoutedEventArgs e)
        {
            theme = (@"Game1\");
            SetAndHideAnswers();
            BGMovieQuote();
        }

        private void Test_Selected(object sender, RoutedEventArgs e)
        {
            theme = (@"Test\");
            SetAndHideAnswers();
            BGMovieQuote();
        }

        private void MovieQuiz1_Selected(object sender, RoutedEventArgs e)
        {
            theme = (@"MovieQuotes1\");
            SetAndHideAnswers();
            BGMovieQuote();
        }
        private void MovieQuiz2_Selected(object sender, RoutedEventArgs e)
        {
            theme = (@"MovieQuotes2\");
            SetAndHideAnswers();
            BGMovieQuote();
        }

        private void MovieQuiz3_Selected(object sender, RoutedEventArgs e)
        {
            theme = (@"MovieQuotes3\");
            SetAndHideAnswers();
            BGMovieQuote();
        }

        private void MovieQuiz4_Selected(object sender, RoutedEventArgs e)
        {
            theme = (@"MovieQuotes4\");
            SetAndHideAnswers();
            BGMovieQuote();
        }

        private void MovieQuiz5_Selected(object sender, RoutedEventArgs e)
        {
            theme = (@"MovieQuotes5\");
            SetAndHideAnswers();
            BGMovieQuote();
        }

        private void MovieQuiz6_Selected(object sender, RoutedEventArgs e)
        {
            theme = (@"MovieQuotes6\");
            SetAndHideAnswers();
            BGMovieQuote();
        }

        private void MovieQuiz7_Selected(object sender, RoutedEventArgs e)
        {
            theme = (@"MovieQuotes7\");
            SetAndHideAnswers();
            BGMovieQuote();
        }

        public void HideAnswers()
        {
            Answer1.Visibility = Visibility.Hidden;
            Answer2.Visibility = Visibility.Hidden;
            Answer3.Visibility = Visibility.Hidden;
            Answer4.Visibility = Visibility.Hidden;
            Answer5.Visibility = Visibility.Hidden;
            Answer6.Visibility = Visibility.Hidden;
            Answer7.Visibility = Visibility.Hidden;
            Answer8.Visibility = Visibility.Hidden;
            Answer9.Visibility = Visibility.Hidden;
            Answer10.Visibility = Visibility.Hidden;
        }

        private void HideButton(object sender, RoutedEventArgs e)
        {
            HideAnswers();
        }



        private void BritpopIntros1_Selected(object sender, RoutedEventArgs e)
        {
            theme = (@"Britpop1\");
            SetAndHideAnswers();
            BGBritpop();
        }

        private void DanceMusic1_Selected(object sender, RoutedEventArgs e)
        {
            theme = (@"DanceMusic1\");
            SetAndHideAnswers();
            BGDanceMusic();
        }

        private void MovieScores1_Selected(object sender, RoutedEventArgs e)
        {
            theme = (@"MovieScores1\");
            SetAndHideAnswers();
            BGMovieScore();
        }

        private void Cartoons90s1_Selected(object sender, RoutedEventArgs e)
        {
            theme = (@"90sCartoons1\");
            SetAndHideAnswers();
            BGCartoon();
        }

        private void ClassicSongs1_Selected(object sender, RoutedEventArgs e)
        {
            theme = (@"ClassicSongs1\");
            SetAndHideAnswers();
            BGClassicSongs();
        }

        private void BGBritpop()
        {
            string packUri = "pack://application:,,,/MusicQuiz;component/Images/britpop.png";
            BGImage.Source = new ImageSourceConverter().ConvertFromString(packUri) as ImageSource;
        }

        private void BGMovieQuote()
        {
            string packUri = "pack://application:,,,/MusicQuiz;component/Images/moviequote.png";
            BGImage.Source = new ImageSourceConverter().ConvertFromString(packUri) as ImageSource;
        }

        private void BGMovieScore()
        {
            string packUri = "pack://application:,,,/MusicQuiz;component/Images/moviescore.png";
            BGImage.Source = new ImageSourceConverter().ConvertFromString(packUri) as ImageSource;
        }
        private void BGDanceMusic()
        {
            string packUri = "pack://application:,,,/MusicQuiz;component/Images/dancemusic.png";
            BGImage.Source = new ImageSourceConverter().ConvertFromString(packUri) as ImageSource;
        }
        private void BGCartoon()
        {
            string packUri = "pack://application:,,,/MusicQuiz;component/Images/cartoon.png";
            BGImage.Source = new ImageSourceConverter().ConvertFromString(packUri) as ImageSource;
        }
        private void BGClassicSongs()
        {
            string packUri = "pack://application:,,,/MusicQuiz;component/Images/classicsongs.png";
            BGImage.Source = new ImageSourceConverter().ConvertFromString(packUri) as ImageSource;
        }

        private void Silence(object sender, RoutedEventArgs e)
        {
            PlaySound(rootPath + "silence.mp3");
        }
    }
}
