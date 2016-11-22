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
using UltimateTTTT.Entities;
using UltimateTTTT.Logic;
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
            Rules rules = new Rules();
            Position position = new Position();
            Blocks[] blocks = new Blocks[9];
            Square[] squares = new Square[9];
            Player player1 = new Player(1);
            Player player2 = new Player(2);
            Player[] players = new Player[2];
            int counter = 0;

            for (int i = 0; i < squares.Length; i++)
            {
                for (int j = 0; j < blocks.Length; j++)
                {
                    blocks[j] = new Blocks();
                    //blocks[j].SetOwner(player1);
                }
                squares[i] = new Square(blocks);
            }
            
            players[0] = player1;
            players[1] = player2;
            Board board = new Board(squares, players);     //insert everything in constructor
            Motor motor = new Motor(board, rules);
            



            if (motor.Move(position, 0, 0, 0, players[0]))
            {
                System.Console.WriteLine("Success!");
            }
            else
            {
                //taken position, should not be clickable in finished product.
                System.Console.WriteLine("Position taken");
            }
            
            
            

            


            InitializeComponent();
        }
    }
}
/*
            for (int i = 0; i < squares.Length; i++)
            {
                for (int j = 0; j < blocks.Length; j++)
                {
                    counter++;
                    System.Console.WriteLine("block: " + counter + " " +  blocks[j].GetOwner());
                }

            }*/
