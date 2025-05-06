

using MyDto;
using SearchProject;

namespace GUI
{

    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            TextBox input = sender as TextBox;
            listBox1.DataSource = BLL.Answer(textBox2.Text);

            if (BLL.X == 1)
                label2.Text = "נמצאה תוצאה אחת ויחידה ";
            else if (BLL.X > 1)
                label2.Text = " נמצאו " + BLL.X.ToString() + " תוצאות  ";
            else
                label2.Text = "לא אותרו תוצאות העונות לחיפוש שלך ";

            button2.Click += button2_Click_1;

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            TextBox input = sender as TextBox;
            listBox1.DataSource = BLL.Answer(textBox2.Text);
            if (BLL.X == 1)
                label2.Text = "נמצאה תוצאה אחת ויחידה ";
            else if (BLL.X > 1)
                label2.Text = " נמצאו " + BLL.X.ToString() + " תוצאות  ";
            else
                label2.Text = "לא אותרו תוצאות העונות לחיפוש שלך ";
        }
        int c = 0;
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (c == 0)
            {
                int x = 1;
                for (int i = 1514; i >= 1488; i--)
                {
                    Button b = new Button();
                    //קביעת ערכים למגוון מאפיינים
                    b.Size = new Size(45, 52);//גודל
                    b.Location = new Point(x * b.Width, 0);//מיקום
                    b.Text = ((char)i).ToString();
                    b.Font = new Font("Fb Pashtut", 16);
                    b.Click += B_Click;

                    //שיוך אירוע לפקד

                    panel1.Controls.Add(b);
                    b.BackColor = Color.Aqua;
                    x = x + 1;
                    b.BackColor = Color.White;
                    c = 1;
                    button3.Text = "להסתרת מקלדת\r\n⌨️";
                }
                //panel1.BackColor = Color.White;
            }
            else
            {
                int x = 1;
        
                c = 0;
                
                panel1.Controls.Clear();

                button3.Text = "להצגת מקלדת\r\n⌨️";

            }
            //יצירת פקד
        }
        string m = "";
        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            listBox1.DataSource = null;
            label2.Text = "";
        }
        private void B_Click(object sender, EventArgs e)
        {
            textBox2.Text += (sender as Button).Text[0].ToString();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox input = sender as TextBox;
            listBox1.DataSource = SearchProject.BLL.Answer(textBox2.Text);

            if (SearchProject.BLL.X == 1)
                label2.Text = "נמצאה תוצאה אחת ויחידה ";
            else if (SearchProject.BLL.X > 1)
                label2.Text = " נמצאו " + SearchProject.BLL.X.ToString() + " תוצאות  ";
            else
                label2.Text = "לא אותרו תוצאות העונות לחיפוש שלך ";

            //button2.Click += but÷ton2_Click_1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox input = sender as TextBox;
            listBox1.DataSource = SearchProject.BLL.RT(textBox2.Text);

            if (SearchProject.BLL.Y == 1)
                label2.Text = "נמצאה תוצאה אחת ויחידה ";
            else if (SearchProject.BLL.Y > 1)
                label2.Text = " נמצאו " + SearchProject.BLL.Y.ToString() + " תוצאות  ";
            else
                label2.Text = "לא אותרו תוצאות העונות לחיפוש שלך ";

        }
    }
}
