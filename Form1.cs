using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IT151MatchingGame
{
    public partial class Form1 : Form
    {
        Int32[,] miGameBoard = new Int32[12,12];
        MersenneTwister r = new MersenneTwister();
        Int32 miFirstClick = 0; // Value from the location of the first click in a pair
        Int32 miSecondClick = 0; // Value from location of second click in a pair
        Int32 miClicker = 0; // Counts the number of clicks after last pair
        Int32 miX = 0; // X-coordinate of the first click of a pair
        Int32 miY = 0; // Y-coordinate of the first click of a pair
        Int32 miX2 = 0; // X-coordinate of the second click of a pair
        Int32 miY2 = 0; // Y-coordinate of the second click of a pair
        Label[,] lblTiles = new Label[12, 12];
        
        public Form1()
        {
            InitializeComponent();
        }

        private void DoWork(Int32 xCoordinate, Int32 yCoordinate)
        {
            Int32 iXCoordinate = 6, iYCoordinate = 6;

            for (Int32 j = 0; j < 12; j++)
            {
                for (Int32 i = 0; i < 12; i++)
                {
                    var CurrPoint = new Point(iXCoordinate, iYCoordinate);
                    lblTiles[j, i] = new Label();
                    lblTiles[j, i].Location = CurrPoint;
                    lblTiles[j, i].BackColor = Color.White;
                    lblTiles[j, i].BorderStyle = BorderStyle.FixedSingle;
                    lblTiles[j, i].Size = new Size(35, 35);
                    iXCoordinate += 34;
                    this.Controls.Add(lblTiles[j, i]);
                }
                iXCoordinate = 6;
                iYCoordinate += 34;
            }
            
            this.Refresh();
         }

        private void StartGame()
        {
            // Declare and initialize local variables
            Int32 iRandom = 0;

            // Zero out the game board
            for (Int32 j = 0; j < 12; j++)
            {
                for (Int32 i = 0; i < 12; i++)
                {
                    miGameBoard[j, i] = 0;
                }
            }

            // Set up a FOR loop 2 X 72 loops
            for (Int32 i = 0; i < 72; i++)
            {
                iRandom = r.Next(1, 501);
                for (Int32 j = 0; j < 2; j++)
                {
                    miX = r.Next(0, 12);
                    miY = r.Next(0, 12);

                    while (miGameBoard[miX, miY] > 0)
                    {
                        miX = r.Next(0, 12);
                        miY = r.Next(0, 12);
                    }

                    miGameBoard[miX, miY] = iRandom;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // Traverse the 2D array behind the game board and reveal all values.
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            // Tell 'em how to play.
        }

        private void lblTile0000_Click(object sender, EventArgs e)
        {
            miClicker++;
            Boolean bMatch = false;
            lblTile0000.Text = miGameBoard[0, 0].ToString();
            switch (miClicker)
            {
                case 1:
                    miFirstClick = miGameBoard[0, 0];
                    
                    miClicker++;
                    break;
                case 2:
                    miSecondClick = miGameBoard[0, 0];
                    bMatch = (miFirstClick == miSecondClick);

                    break;
            }
        }

        private void lblTile0211_Click(object sender, EventArgs e)
        {
            DoWork(2, 11);
        }

        private void lblTile0210_Click(object sender, EventArgs e)
        {
            DoWork(2, 10);
        }

        private void lblTile0209_Click(object sender, EventArgs e)
        {
            DoWork(2, 9);
        }

        private void lblTile0208_Click(object sender, EventArgs e)
        {
            DoWork(2, 8);
        }

        private void lblTile0207_Click(object sender, EventArgs e)
        {
            DoWork(2, 7);
        }

        private void lblTile0206_Click(object sender, EventArgs e)
        {
            DoWork(2, 6);
        }

        private void lblTile0205_Click(object sender, EventArgs e)
        {
            DoWork(2, 5);
        }

        private void lblTile0204_Click(object sender, EventArgs e)
        {
            DoWork(2, 4);
        }

        private void lblTile0203_Click(object sender, EventArgs e)
        {
            DoWork(2, 3);
        }

        private void lblTile0202_Click(object sender, EventArgs e)
        {
            DoWork(2, 2);
        }

        private void lblTile0201_Click(object sender, EventArgs e)
        {
            DoWork(2, 1);
        }

        private void lblTile0200_Click(object sender, EventArgs e)
        {
            DoWork(2, 0);
        }

        private void lblTile0111_Click(object sender, EventArgs e)
        {
            DoWork(1, 11);
        }

        private void lblTile0110_Click(object sender, EventArgs e)
        {
            DoWork(1, 10);
        }

        private void lblTile0109_Click(object sender, EventArgs e)
        {
            DoWork(1, 9);
        }

        private void lblTile0108_Click(object sender, EventArgs e)
        {
            DoWork(1, 8);
        }

        private void lblTile0107_Click(object sender, EventArgs e)
        {
            DoWork(1, 7);
        }

        private void lblTile0106_Click(object sender, EventArgs e)
        {
            DoWork(1, 6);
        }

        private void lblTile0105_Click(object sender, EventArgs e)
        {
            DoWork(1, 5);
        }

        private void lblTile0104_Click(object sender, EventArgs e)
        {
            DoWork(1, 4);
        }

        private void lblTile0103_Click(object sender, EventArgs e)
        {
            DoWork(1, 3);
        }

        private void lblTile0102_Click(object sender, EventArgs e)
        {
            DoWork(1, 2);
        }

        private void lblTile0101_Click(object sender, EventArgs e)
        {
            DoWork(1, 1);
        }

        private void lblTile0100_Click(object sender, EventArgs e)
        {
            DoWork(1, 0);
        }

        private void lblTile1111_Click(object sender, EventArgs e)
        {
            DoWork(11, 11);
        }

        private void lblTile1110_Click(object sender, EventArgs e)
        {
            DoWork(11, 10);
        }

        private void lblTile1109_Click(object sender, EventArgs e)
        {
            DoWork(11, 9);
        }

        private void lblTile1108_Click(object sender, EventArgs e)
        {
            DoWork(11, 8);
        }

        private void lblTile1107_Click(object sender, EventArgs e)
        {
            DoWork(11, 7);
        }

        private void lblTile1106_Click(object sender, EventArgs e)
        {
            DoWork(11, 6);
        }

        private void lblTile1105_Click(object sender, EventArgs e)
        {
            DoWork(11, 5);
        }

        private void lblTile1104_Click(object sender, EventArgs e)
        {
            DoWork(11, 4);
        }

        private void lblTile1103_Click(object sender, EventArgs e)
        {
            DoWork(11, 3);
        }

        private void lblTile1102_Click(object sender, EventArgs e)
        {
            DoWork(11, 2);
        }

        private void lblTile1101_Click(object sender, EventArgs e)
        {
            DoWork(11, 1);
        }

        private void lblTile1100_Click(object sender, EventArgs e)
        {
            DoWork(11, 0);
        }

        private void lblTile1011_Click(object sender, EventArgs e)
        {
            DoWork(10, 11);
        }

        private void lblTile1010_Click(object sender, EventArgs e)
        {
            DoWork(10, 10);
        }

        private void lblTile1009_Click(object sender, EventArgs e)
        {
            DoWork(10, 9);
        }

        private void lblTile1008_Click(object sender, EventArgs e)
        {
            DoWork(10, 8);
        }

        private void lblTile1007_Click(object sender, EventArgs e)
        {
            DoWork(10, 7);
        }

        private void lblTile1006_Click(object sender, EventArgs e)
        {
            DoWork(10, 6);
        }

        private void lblTile1005_Click(object sender, EventArgs e)
        {
            DoWork(10, 5);
        }

        private void lblTile1004_Click(object sender, EventArgs e)
        {
            DoWork(10, 4);
        }

        private void lblTile1003_Click(object sender, EventArgs e)
        {
            DoWork(10, 3);
        }

        private void lblTile1002_Click(object sender, EventArgs e)
        {
            DoWork(10, 2);
        }

        private void lblTile1001_Click(object sender, EventArgs e)
        {
            DoWork(10, 1);
        }

        private void lblTile1000_Click(object sender, EventArgs e)
        {
            DoWork(10, 0);
        }

        private void lblTile0911_Click(object sender, EventArgs e)
        {
            DoWork(9, 11);
        }

        private void lblTile0910_Click(object sender, EventArgs e)
        {
            DoWork(9, 10);
        }

        private void lblTile0909_Click(object sender, EventArgs e)
        {
            DoWork(9, 9);
        }

        private void lblTile0908_Click(object sender, EventArgs e)
        {
            DoWork(9, 8);
        }

        private void lblTile0907_Click(object sender, EventArgs e)
        {
            DoWork(9, 7);
        }

        private void lblTile0906_Click(object sender, EventArgs e)
        {
            DoWork(9, 6);
        }

        private void lblTile0905_Click(object sender, EventArgs e)
        {
            DoWork(9, 5);
        }

        private void lblTile0904_Click(object sender, EventArgs e)
        {
            DoWork(9, 4);
        }

        private void lblTile0903_Click(object sender, EventArgs e)
        {
            DoWork(9, 3);
        }

        private void lblTile0902_Click(object sender, EventArgs e)
        {
            DoWork(9, 2);
        }

        private void lblTile0901_Click(object sender, EventArgs e)
        {
            DoWork(9, 1);
        }

        private void lblTile0900_Click(object sender, EventArgs e)
        {
            DoWork(9, 0);
        }

        private void lblTile0811_Click(object sender, EventArgs e)
        {
            DoWork(8, 11);
        }

        private void lblTile0810_Click(object sender, EventArgs e)
        {
            DoWork(8, 10);
        }

        private void lblTile0809_Click(object sender, EventArgs e)
        {
            DoWork(8, 9);
        }

        private void lblTile0808_Click(object sender, EventArgs e)
        {
            DoWork(8, 8);
        }

        private void lblTile0807_Click(object sender, EventArgs e)
        {
            DoWork(8, 7);
        }

        private void lblTile0806_Click(object sender, EventArgs e)
        {
            DoWork(8, 6);
        }

        private void lblTile0805_Click(object sender, EventArgs e)
        {
            DoWork(8, 5);
        }

        private void lblTile0804_Click(object sender, EventArgs e)
        {
            DoWork(8, 4);
        }

        private void lblTile0803_Click(object sender, EventArgs e)
        {
            DoWork(8, 3);
        }

        private void lblTile0802_Click(object sender, EventArgs e)
        {
            DoWork(8, 2);
        }

        private void lblTile0801_Click(object sender, EventArgs e)
        {
            DoWork(8, 1);
        }

        private void lblTile0800_Click(object sender, EventArgs e)
        {
            DoWork(8, 0);
        }

        private void lblTile0711_Click(object sender, EventArgs e)
        {
            DoWork(7, 11);
        }

        private void lblTile0710_Click(object sender, EventArgs e)
        {
            DoWork(7, 10);
        }

        private void lblTile0709_Click(object sender, EventArgs e)
        {
            DoWork(7, 9);
        }

        private void lblTile0708_Click(object sender, EventArgs e)
        {
            DoWork(7, 8);
        }

        private void lblTile0707_Click(object sender, EventArgs e)
        {
            DoWork(7, 7);
        }

        private void lblTile0706_Click(object sender, EventArgs e)
        {
            DoWork(7, 6);
        }

        private void lblTile0705_Click(object sender, EventArgs e)
        {
            DoWork(7, 5);
        }

        private void lblTile0704_Click(object sender, EventArgs e)
        {
            DoWork(7, 4);
        }

        private void lblTile0703_Click(object sender, EventArgs e)
        {
            DoWork(7, 3);
        }

        private void lblTile0702_Click(object sender, EventArgs e)
        {
            DoWork(7, 2);
        }

        private void lblTile0701_Click(object sender, EventArgs e)
        {
            DoWork(7, 1);
        }

        private void lblTile0700_Click(object sender, EventArgs e)
        {
            DoWork(7, 0);
        }

        private void lblTile0611_Click(object sender, EventArgs e)
        {
            DoWork(6, 11);
        }

        private void lblTile0610_Click(object sender, EventArgs e)
        {
            DoWork(6, 10);
        }

        private void lblTile0609_Click(object sender, EventArgs e)
        {
            DoWork(6, 9);
        }

        private void lblTile0608_Click(object sender, EventArgs e)
        {
            DoWork(6, 8);
        }

        private void lblTile0607_Click(object sender, EventArgs e)
        {
            DoWork(6, 7);
        }

        private void lblTile0606_Click(object sender, EventArgs e)
        {
            DoWork(6, 6);
        }

        private void lblTile0605_Click(object sender, EventArgs e)
        {
            DoWork(6, 5);
        }

        private void lblTile0604_Click(object sender, EventArgs e)
        {
            DoWork(6, 4);
        }

        private void lblTile0603_Click(object sender, EventArgs e)
        {
            DoWork(6, 3);
        }

        private void lblTile0602_Click(object sender, EventArgs e)
        {
            DoWork(6, 2);
        }

        private void lblTile0601_Click(object sender, EventArgs e)
        {
            DoWork(6, 1);
        }

        private void lblTile0600_Click(object sender, EventArgs e)
        {
            DoWork(6, 0);
        }

        private void lblTile0511_Click(object sender, EventArgs e)
        {
            DoWork(5, 11);
        }

        private void lblTile0510_Click(object sender, EventArgs e)
        {
            DoWork(5, 10);
        }

        private void lblTile0509_Click(object sender, EventArgs e)
        {
            DoWork(5, 9);
        }

        private void lblTile0508_Click(object sender, EventArgs e)
        {
            DoWork(5, 8);
        }

        private void lblTile0507_Click(object sender, EventArgs e)
        {
            DoWork(5, 7);
        }

        private void lblTile0506_Click(object sender, EventArgs e)
        {
            DoWork(5, 6);
        }

        private void lblTile0505_Click(object sender, EventArgs e)
        {
            DoWork(5, 5);
        }

        private void lblTile0504_Click(object sender, EventArgs e)
        {
            DoWork(5, 4);
        }

        private void lblTile0503_Click(object sender, EventArgs e)
        {
            DoWork(5, 3);
        }

        private void lblTile0502_Click(object sender, EventArgs e)
        {
            DoWork(5, 2);
        }

        private void lblTile0501_Click(object sender, EventArgs e)
        {
            DoWork(5, 1);
        }

        private void lblTile0500_Click(object sender, EventArgs e)
        {
            DoWork(5, 0);
        }

        private void lblTile0411_Click(object sender, EventArgs e)
        {
            DoWork(4, 11);
        }

        private void lblTile0410_Click(object sender, EventArgs e)
        {
            DoWork(4, 10);
        }

        private void lblTile0409_Click(object sender, EventArgs e)
        {
            DoWork(4, 9);
        }

        private void lblTile0408_Click(object sender, EventArgs e)
        {
            DoWork(4, 8);
        }

        private void lblTile0407_Click(object sender, EventArgs e)
        {
            DoWork(4, 7);
        }

        private void lblTile0406_Click(object sender, EventArgs e)
        {
            DoWork(4, 6);
        }

        private void lblTile0405_Click(object sender, EventArgs e)
        {
            DoWork(4, 5);
        }

        private void lblTile0404_Click(object sender, EventArgs e)
        {
            DoWork(4, 4);
        }

        private void lblTile0403_Click(object sender, EventArgs e)
        {
            DoWork(4, 3);
        }

        private void lblTile0402_Click(object sender, EventArgs e)
        {
            DoWork(4, 2);
        }

        private void lblTile0401_Click(object sender, EventArgs e)
        {
            DoWork(4, 1);
        }

        private void lblTile0400_Click(object sender, EventArgs e)
        {
            DoWork(4, 0);
        }

        private void lblTile0311_Click(object sender, EventArgs e)
        {
            DoWork(3, 11);
        }

        private void lblTile0310_Click(object sender, EventArgs e)
        {
            DoWork(3, 10);
        }

        private void lblTile0309_Click(object sender, EventArgs e)
        {
            DoWork(3, 9);
        }

        private void lblTile0308_Click(object sender, EventArgs e)
        {
            DoWork(3, 8);
        }

        private void lblTile0307_Click(object sender, EventArgs e)
        {
            DoWork(3, 7);
        }

        private void lblTile0306_Click(object sender, EventArgs e)
        {
            DoWork(3, 6);
        }

        private void lblTile0305_Click(object sender, EventArgs e)
        {
            DoWork(3, 5);
        }

        private void lblTile0304_Click(object sender, EventArgs e)
        {
            DoWork(3, 4);
        }

        private void lblTile0303_Click(object sender, EventArgs e)
        {
            DoWork(3, 3);
        }

        private void lblTile0302_Click(object sender, EventArgs e)
        {
            DoWork(3, 2);
        }

        private void lblTile0301_Click(object sender, EventArgs e)
        {
            DoWork(3, 1);
        }

        private void lblTile0300_Click(object sender, EventArgs e)
        {
            DoWork(3, 0);
        }

        private void lblTile0011_Click(object sender, EventArgs e)
        {
            DoWork(0, 11);
        }

        private void lblTile0010_Click(object sender, EventArgs e)
        {
            DoWork(0, 10);
        }

        private void lblTile0009_Click(object sender, EventArgs e)
        {
            DoWork(0, 9);
        }

        private void lblTile0008_Click(object sender, EventArgs e)
        {
            DoWork(0, 8);
        }

        private void lblTile0007_Click(object sender, EventArgs e)
        {
            DoWork(0, 7);
        }

        private void lblTile0006_Click(object sender, EventArgs e)
        {
            DoWork(0, 6);
        }

        private void lblTile0005_Click(object sender, EventArgs e)
        {
            DoWork(0, 5);
        }

        private void lblTile0004_Click(object sender, EventArgs e)
        {
            DoWork(0, 4);
        }

        private void lblTile0003_Click(object sender, EventArgs e)
        {
            DoWork(0, 3);
        }

        private void lblTile0002_Click(object sender, EventArgs e)
        {
            DoWork(0, 2);
        }

        private void lblTile0001_Click(object sender, EventArgs e)
        {
            DoWork(0, 1);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            DoWork(0,0);
        }
    }
}
