namespace Tic_Tac_Toe_3._0
{
    public partial class Form1 : Form
    {
        public enum Player
        {
            X, O
        }
        //custom string for inputs X and O

        bool turn = true;
        int turn_count = 0;
        Player currentPlayer;
        Random random = new Random();
        int Player1WinCount = 0;
        int CPUWinCount = 0;
        int DrawsCount = 0;
        List<Button> buttons;

        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;
            
                currentPlayer = Player.X;
                button.Text = currentPlayer.ToString();
                button.Enabled = false;
                button.BackColor = Color.Green;
                buttons.Remove(button);
                //to avoid choosing the same box
                CheckGame();
            CPUTimer.Start();

        }

        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void CheckGame()
        {//Vetical
            if (A1.Text == "X" && A2.Text == "X" && A3.Text == "X"
                || B1.Text == "X" && B2.Text == "X" && B3.Text == "X"
                || C1.Text == "X" && C2.Text == "X" && C3.Text == "X"
                //Horizontal
                || A1.Text == "X" && B1.Text == "X" && C1.Text == "X"
                || A2.Text == "X" && B2.Text == "X" && C2.Text == "X"
                || A3.Text == "X" && B3.Text == "X" && C3.Text == "X"
                //diagonal
                || A1.Text == "X" && B2.Text == "X" && C3.Text == "X"
                || A3.Text == "X" && B2.Text == "X" && C1.Text == "X"
                )
            {
                CPUTimer.Stop();
                MessageBox.Show("Player1 Wins");
                Player1WinCount++;
                label1.Text = "Player1 Wins: " + Player1WinCount;
                RestartGame();
            }

            else if (A1.Text == "O" && A2.Text == "O" && A3.Text == "O"
                || B1.Text == "O" && B2.Text == "O" && B3.Text == "O"
                || C1.Text == "O" && C2.Text == "O" && C3.Text == "O"
                //Horizontal
                || A1.Text == "O" && B1.Text == "O" && C1.Text == "O"
                || A2.Text == "O" && B2.Text == "O" && C2.Text == "O"
                || A3.Text == "O" && B3.Text == "O" && C3.Text == "O"
                //diagonal
                || A1.Text == "O" && B2.Text == "O" && C3.Text == "O"
                || A3.Text == "O" && B2.Text == "O" && C1.Text == "O"
                )
            {
                CPUTimer.Stop();
                MessageBox.Show("CPU Wins");
                CPUWinCount++;
                label2.Text = "CPU Wins: " + CPUWinCount;
                RestartGame();

            }

            else if (turn_count == 9)
            {
                MessageBox.Show("Draw, Try being better!");
                DrawsCount++;
                label3.Text = "Draws: " + DrawsCount;
                RestartGame();
            }
        }

        private void RestartGame()
        {
            buttons = new List<Button> { A1, A2, A3, B1, B2, B3, C1, C2, C3 };

            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = "";
                x.BackColor = DefaultBackColor;
                turn_count = 0;
            }
        }

        private void CPUmove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.Red;
                buttons.RemoveAt(index);
                CheckGame();
                CPUTimer.Stop();
            }
        }
    }
}