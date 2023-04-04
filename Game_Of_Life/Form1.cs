using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        private bool keyPressed;
        private int gameSpeed;
        public Thread thread;
        //Graphics grid;
        //protected Graphics grid = null;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            BringToFront();
            KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        //Exit Program by pressing down ESC key
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Environment.Exit(Environment.ExitCode);
            }
        }

        //Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
        
        //Start Button
        private void btnStart_Click(object sender, EventArgs e)
        {
            //bool value = (btnStart.Tag as bool?) ?? true;
            //btnStart.Tag = !value;
            //btnStart.Text = (value ? "Start" : "Stop");
            keyPressed = false;
            thread = new Thread(game);
            thread.IsBackground = true;
            btnStart.Enabled = false;
            btnNew.Select();
            thread.Start();
            int gameSpeed = (trackGameSpeed.Value);
        }

        // Game of Life BEGINS!
        private void game()
        {
            //Set values

            Graphics grid = pictureBox1.CreateGraphics();               //
            grid.Clear(this.BackColor);                                 //Clear grid to background colour
            SolidBrush aliveBrush = new SolidBrush(colorDialog1.Color); //Alive brush colour set by user input
            SolidBrush deadBrush = new SolidBrush(colorDialog2.Color);  //Dead brush colour set by user input
            int noOfBoxes = int.Parse(noOfBoxesInput.Text);             //No of Boxes is user input, default is 100
            int boxSize = int.Parse(boxSizeInput.Text);                 //Box Size is user input, default is 5
            //int boxSpacing = 1;                                       //Box spacing
            int[,] currentPopulation = new int[noOfBoxes, noOfBoxes];   //Array to store current population
            int[,] newPopulation = new int[noOfBoxes, noOfBoxes];       //Array to store the new calculated population
            int xCoordinate = 0;                                        //Set x coordinate in array to 0
            int yCoordinate = 0;                                        //Set y coordinate in array to 0
            int noOfAliveNeighbours = 0;                                //set no of alive neighbours to 0
            //int populationGen = 0;                                    //set generation to 0
            DateTime date = DateTime.Now;                               //Gets time, to use as random seed
            int time = int.Parse(date.ToString("HHmmss"));              //Converts the time above in to an int
            Random randNo = new Random(time);                           //random number generator using time as seed
            //Random randNo = new Random();                             //Basic Random Number generator

            //Randomly set array currentPopulation
            for (xCoordinate = 0; xCoordinate < noOfBoxes; xCoordinate++)
            {
                for (yCoordinate = 0; yCoordinate < noOfBoxes; yCoordinate++)
                {
                    
                    currentPopulation[xCoordinate, yCoordinate] = randNo.Next(0, 2);
                }
            }

            {
                    do
                    {
                    //Application.DoEvents();
                    Thread.Sleep(gameSpeed);

                        for (xCoordinate = 0; xCoordinate < noOfBoxes; xCoordinate++)
                        {
                            for (yCoordinate = 0; yCoordinate < noOfBoxes; yCoordinate++)
                            {
                                if (currentPopulation[xCoordinate, yCoordinate] == 1) grid.FillRectangle(aliveBrush, xCoordinate * boxSize, yCoordinate * boxSize, boxSize, boxSize);  
                                else grid.FillRectangle(deadBrush, xCoordinate * boxSize, yCoordinate * boxSize, boxSize, boxSize);
                            }
                        }
                        for (xCoordinate = 1; xCoordinate < noOfBoxes - 1; xCoordinate++)
                        {

                            for (yCoordinate = 1; yCoordinate < noOfBoxes - 1; yCoordinate++)
                            {
                                //Checking for neighbouring cells that are alive
                                noOfAliveNeighbours = 0;
                                if (currentPopulation[xCoordinate - 1, yCoordinate + 1] == 1) noOfAliveNeighbours++;    //TOP LEFT. If equal to 1 add 1 to numOfAliveNeighbours
                                if (currentPopulation[xCoordinate, yCoordinate + 1] == 1) noOfAliveNeighbours++;        //TOP MIDDLE. If equal to 1 add 1 to numOfAliveNeighbours
                                if (currentPopulation[xCoordinate + 1, yCoordinate + 1] == 1) noOfAliveNeighbours++;    //TOP RIGHT. If equal to 1 add 1 to numOfAliveNeighbours
                                if (currentPopulation[xCoordinate - 1, yCoordinate] == 1) noOfAliveNeighbours++;        //MIDDLE LEFT. If equal to 1 add 1 to numOfAliveNeighbours
                                if (currentPopulation[xCoordinate + 1, yCoordinate] == 1) noOfAliveNeighbours++;        //MIDDLE RIGHT. If equal to 1 add 1 to numOfAliveNeighbours
                                if (currentPopulation[xCoordinate - 1, yCoordinate - 1] == 1) noOfAliveNeighbours++;    //BOTTOM LEFT. If equal to 1 add 1 to numOfAliveNeighbours
                                if (currentPopulation[xCoordinate, yCoordinate - 1] == 1) noOfAliveNeighbours++;        //BOTTOM MIDDLE. If equal to 1 add 1 to numOfAliveNeighbours
                                if (currentPopulation[xCoordinate + 1, yCoordinate - 1] == 1) noOfAliveNeighbours++;    //BOTTOM RIGHT. If equal to 1 add 1 to numOfAliveNeighbours

                                //Applying the rules
                                //Rule 1: Any live cell with less than 2 live neighbours dies by underpopulation
                                if (currentPopulation[xCoordinate, yCoordinate] == 1 && noOfAliveNeighbours < 2) newPopulation[xCoordinate, yCoordinate] = 0;
                                //Rule 2: Any live cell with two or three live neighbours survives to next gen
                                if (currentPopulation[xCoordinate, yCoordinate] == 1 && noOfAliveNeighbours == 2 | noOfAliveNeighbours ==3) newPopulation[xCoordinate, yCoordinate] = 1;
                                //Rule 3: Any live cell with more than three live neighbours dies by overpopulation
                                if (currentPopulation[xCoordinate, yCoordinate] == 1 && noOfAliveNeighbours > 3) newPopulation[xCoordinate, yCoordinate] = 0;
                                //Rule 4: Any dead cell with exactly 3 neighbours become alive as if by reproduction
                                if (currentPopulation[xCoordinate, yCoordinate] == 0 && noOfAliveNeighbours == 3) newPopulation[xCoordinate, yCoordinate] = 1;
                            }
                        }


                        for (xCoordinate = 0; xCoordinate < noOfBoxes; xCoordinate++)
                        {
                            for (yCoordinate = 0; yCoordinate < noOfBoxes; yCoordinate++)
                            {
                                currentPopulation[xCoordinate, yCoordinate] = newPopulation[xCoordinate, yCoordinate];
                            // newPopulation[xCoordinate, yCoordinate] = 0;
                            }
                        }
                    //         populationGen++;
                    }  // closes do

                while (!keyPressed);
            }
                } // closes  private

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] currentPopulation = new int[0, 0];   //Array to store current population
            int[,] newPopulation = new int[0, 0];
            thread.Abort();
            thread = new Thread(game);
            thread.IsBackground = true;
            thread.Start();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAliveColour_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                SolidBrush aliveBrush = new SolidBrush(colorDialog1.Color);
            }
        }

        private void btnDeadColour_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                SolidBrush deadBrush = new SolidBrush(colorDialog2.Color);
            }
        }

        private void btnConsoleColour_Click(object sender, EventArgs e)
        {
            if (colorDialog3.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog3.Color;
            }
        }

        private void trackGameSpeed_Scroll(object sender, EventArgs e)
        {
            //MessageBox.Show(trackGameSpeed.Value.ToString()); //DEBUG - See trackbar value
            gameSpeed = (trackGameSpeed.Value);
        }
    }
}

