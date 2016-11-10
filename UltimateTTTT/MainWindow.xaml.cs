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
using UltimateTTTT.Logic.Entities;

namespace UltimateTTTT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Blocks[] blocks = new Blocks[9];
            Square[] squares = new Square[9];
            Player player1 = new Player(1);
            Player player2 = new Player(2);
            int counter = 0;
            

            for (int i = 0; i < squares.Length; i++)
            {
                for (int j = 0; j < blocks.Length; j++)
                {
                    blocks[j] = new Blocks();
                    blocks[j].setOwner(player1);
                }
                squares[i] = new Square(blocks);
            }
            for (int i = 0; i < squares.Length; i++)
                
            {
                for (int j = 0; j < blocks.Length; j++)
                {
                    counter++;
                    System.Console.WriteLine("block: " + counter + " " +  blocks[j].getOwner());
                }

            }
            Board board = new Board();      //insert squares

            InitializeComponent();
        }
    }
}
