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
        {   //Blocks does not seem to be initialized???
            Rules rules = new Rules();
            Position position = new Position();
            Blocks[] blocks0 = new Blocks[9];
            Blocks[] blocks1 = new Blocks[9];
            Blocks[] blocks2 = new Blocks[9];
            Blocks[] blocks3 = new Blocks[9];
            Blocks[] blocks4 = new Blocks[9];
            Blocks[] blocks5 = new Blocks[9];
            Blocks[] blocks6 = new Blocks[9];
            Blocks[] blocks7 = new Blocks[9];
            Blocks[] blocks8 = new Blocks[9];
            Square[] squares = new Square[9];
            squares[0] = new Square(blocks0);
            squares[1] = new Square(blocks1);
            squares[2] = new Square(blocks2);
            squares[3] = new Square(blocks3);
            squares[4] = new Square(blocks4);
            squares[5] = new Square(blocks5);
            squares[6] = new Square(blocks6);
            squares[7] = new Square(blocks7);
            squares[8] = new Square(blocks8);

            Player player1 = new Player(1);
            Player player2 = new Player(2);
            Player[] players = new Player[2];
            
            players[0] = player1;
            players[1] = player2;
            Board board = new Board(squares, players);     //insert everything in constructor
            Motor motor = new Motor(board, rules, position);


            System.Console.WriteLine(motor.Move(squares[0], 0, player1) ? "Success!" : "Position taken");
            System.Console.WriteLine(motor.Move(squares[0], 1, player2) ? "Success!" : "Position taken");

            System.Console.WriteLine(motor.Move(squares[0], 2, player1) ? "Success!" : "Position taken");

            System.Console.WriteLine(motor.Move(squares[0], 1, player2) ? "Success!" : "Position taken");
            System.Console.WriteLine(motor.Move(squares[0], 0, player1) ? "Success!" : "Position taken");

            System.Console.WriteLine(motor.Move(squares[0], 2, player2) ? "Success!" : "Position taken");


            System.Console.WriteLine(motor.Move(squares[0], 0, player1) ? "Success!" : "Position taken");


            System.Console.WriteLine(motor.Move(squares[0], 5, player2) ? "Success!" : "Position taken");

            System.Console.WriteLine(motor.Move(squares[0], 0, player1) ? "Success!" : "Position taken");

            System.Console.WriteLine(motor.Move(squares[0], 8, player2) ? "Success!" : "Position taken");





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
