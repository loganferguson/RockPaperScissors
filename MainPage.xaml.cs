using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RockPaperScissors
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            blockEnemy.Text = "SHOOT!";
            btnPlayAgain.IsEnabled = false;
        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private void btnRock_Click(object sender, RoutedEventArgs e)
        {
            int enemyAnswer = RandomNumber(1, 4);
            btnRock.IsEnabled = false;
            btnPaper.IsEnabled = false;
            btnScissors.IsEnabled = false;
            btnPlayAgain.IsEnabled = true;
            
                        if (enemyAnswer == 1)
                    {
                        blockEnemy.Text = "STALEMATE!";
                        staleMate.Text = "XXXX";
                    }
                        else if (enemyAnswer== 2)
                    {
                        blockEnemy.Text = "PAPER";
                        youLose.Text = "You Lose!";
                    }
                    else
                    {
                        blockEnemy.Text = "SCISSORS";
                        youWin.Text = "You Win!";
                    }
        }
                private void btnRock_PointerEntered(object sender, PointerRoutedEventArgs e)
                {
                    btnRock.Content = "ROCK";
                }

                private void btnRock_PointerExited(object sender, PointerRoutedEventArgs e)
                {
                    btnRock.Content = "";
                }

        private void btnPaper_Click(object sender, RoutedEventArgs e)
        {
            int enemyAnswer = RandomNumber(1, 4);
            btnRock.IsEnabled = false;
            btnPaper.IsEnabled = false;
            btnScissors.IsEnabled = false;
            btnPlayAgain.IsEnabled = true;

                    if (enemyAnswer == 1)
                    {
                        blockEnemy.Text = "ROCK";
                        youWin.Text = "You Win!";
                    }
                    else if (enemyAnswer == 2)
                    {
                        blockEnemy.Text = "STALEMATE!";
                        staleMate.Text = "XXXX";
                    }
                    else
                    {
                        blockEnemy.Text = "SCISSORS";
                        youLose.Text = "You Lose!";
                    }
                    
        }
                private void btnPaper_PointerEntered(object sender, PointerRoutedEventArgs e)
                {
                    btnPaper.Content = "PAPER";
                }

                private void btnPaper_PointerExited(object sender, PointerRoutedEventArgs e)
                {
                    btnPaper.Content = "";
                }

        private void btnScissors_Click(object sender, RoutedEventArgs e)
                {
            int enemyAnswer = RandomNumber(1, 4);
            btnRock.IsEnabled = false;
            btnPaper.IsEnabled = false;
            btnScissors.IsEnabled = false;
            btnPlayAgain.IsEnabled = true;

                    if (enemyAnswer == 1)
                    {
                        blockEnemy.Text = "ROCK";
                    youLose.Text = "You Lose!"; 
                    }
                    else if (enemyAnswer == 2)
                    {
                        blockEnemy.Text = "PAPER";
                        youWin.Text = "You Win!";
                    }
                    else
                    {
                        blockEnemy.Text = "STALEMATE!";
                        staleMate.Text = "XXXX";
                    }
        }
                private void btnScissors_PointerEntered(object sender, PointerRoutedEventArgs e)
                {
                    btnScissors.Content = "SCISSORS";
                }

                private void btnScissors_PointerExited(object sender, PointerRoutedEventArgs e)
                {
                    btnScissors.Content = "";
                }
        private void btnPlayAgain_Click(object sender, RoutedEventArgs e)
        {
            btnRock.IsEnabled = true;
            btnPaper.IsEnabled = true;
            btnScissors.IsEnabled = true;
            btnPlayAgain.IsEnabled = false;
            youLose.Text = "";
            youWin.Text = "";
            staleMate.Text = "";
            blockEnemy.Text = "SHOOT!";
        }

        //public string scoreBoard()
        //{
        //    int i = 0;

        //    for (i = 1; i < 4; i++)
        //    {
        //        if (btnPlayAgain.IsEnabled == true && youWin.Text == "YouWin")
        //        {

        //        }
        //    }
        //}
    }

}
