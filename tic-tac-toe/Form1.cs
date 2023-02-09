namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void rb_X_playerone_CheckedChanged(object sender, EventArgs e)
        {
            rb_O_playertwo.Checked = true;
        }
        private void rb_O_playerone_CheckedChanged(object sender, EventArgs e)
        {
            rb_X_playertwo.Checked = true;
        }
        private void rb_X_playertwo_CheckedChanged(object sender, EventArgs e)
        {
            rb_O_playerone.Checked = true;
        }
        private void rb_O_playertwo_CheckedChanged(object sender, EventArgs e)
        {
            rb_X_playerone.Checked = true;
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            if(tb_playerone.Text == string.Empty || tb_playertwo.Text == string.Empty)
            {
                MessageBox.Show("plz enter your name first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show($"player {tb_playerone.Text} will play with letter {(rb_X_playerone.Checked ? "X" : "O")}\n" +
                $"player {tb_playertwo.Text} will play with letter {(rb_O_playertwo.Checked ? "O" : "X")}\n", "Start Game", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                myBoard myBoard = new myBoard();
                this.Hide();
                myBoard.ShowDialog();
                this.Close();
            }
           
        }
        
    }
}