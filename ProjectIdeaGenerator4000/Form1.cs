namespace ProjectIdeaGenerator4000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateIdeaBTN_Click(object sender, EventArgs e)
        {
            GetIdea();
        }

        async void GetIdea()
        {
            projectIdeaLB.ForeColor = Color.White;
            string[] ideas = File.ReadAllLines("ideas.txt");
            Random rnd = new Random();

            //Intro part, just BS idk goin thru all to add anticipation

            for (int i = 0; i < 15; i++)
            {
                projectIdeaLB.Text = ideas
                    [rnd.Next(0, ideas.Length)];

                double rndDouble = rnd.NextDouble();

                projectIdeaLB.Font =
                    new Font(
                        FontFamily.Families[rnd.Next(0, FontFamily.Families.Length)],
                        (float)((rndDouble > 0.5 ? rndDouble : 0.5) * 30)
                    );

                if (checkBox1.Checked) SetDesktopLocation(Location.X + rnd.Next(-5, 5), Location.Y + rnd.Next(-5, 5));
                await Task.Delay(10);
            }


            //Main slowing down part

            int x = 10;
            for (int i = 0; i < 30; i++)
            {
                projectIdeaLB.Text = ideas
                    [rnd.Next(0, ideas.Length)];

                double rndDouble = rnd.NextDouble();

                projectIdeaLB.Font =
                    new Font(
                        FontFamily.Families[rnd.Next(0, FontFamily.Families.Length)],
                        (float)((rndDouble > 0.5 ? rndDouble : 0.5) * 30)
                    );
                if (checkBox1.Checked) SetDesktopLocation(Location.X + rnd.Next(-15, 15), Location.Y + rnd.Next(-15, 15));
                await Task.Delay(10 + (x * i));
            }

            //DING DING DING you won! oh wait no, you have a new project idea :)

            for (int i = 0; i < 3; i++)
            {
                projectIdeaLB.ForeColor = Color.Green;
                projectIdeaLB.Font = new Font("Segoe UI", 15);
                await Task.Delay(250);
                projectIdeaLB.ForeColor = Color.White;
                projectIdeaLB.Font = new Font("Segoe UI", (float)13.875);
                await Task.Delay(250);
            }
        }

        private void generateIdeaBTN_MouseHover(object sender, EventArgs e)
        {
            ToolTip ttip = new ToolTip();
            ttip.Show("BAZINGA! (From young sheldon), Click me to get a new project idea :D", this.generateIdeaBTN);
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            ToolTip ttip = new ToolTip();
            ttip.Show("Made with Love ❤️", this.label2);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
