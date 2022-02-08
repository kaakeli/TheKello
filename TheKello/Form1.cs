using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheKello
{
    public partial class TheKello : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        

        public TheKello()
        {
            InitializeComponent();
            
            //this.TransparencyKey = (BackColor);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            //if (Properties.Settings.Default.F1Size.Width == 0) Properties.Settings.Default.Upgrade();

            //if (Properties.Settings.Default.F1Size.Width == 0 || Properties.Settings.Default.F1Size.Height == 0)
            //{
            //    // first start
            //    // optional: add default values
            //}
            //else
            //{
            //    this.WindowState = Properties.Settings.Default.F1State;

            //    // we don't want a minimized window at startup
            //    if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;

            //    this.Location = Properties.Settings.Default.F1Location;
            //    this.Size = Properties.Settings.Default.F1Size;
            //}
        }
        // FORM MOVE
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        // LABEL BUTTON
        private void Label1_Click(object sender, EventArgs e)
        {
            //this.TransparencyKey = (BackColor);

            DialogResult fontResult = fontDialog1.ShowDialog();
            if (fontResult == DialogResult.OK)
            {
                label1.Font = fontDialog1.Font;
            }

        }

        // EXIT BUTTON
        private void Button1_Click(object sender, EventArgs e)
        {            
            Application.Exit();
        }

        // COLOR
        private void Color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            label1.ForeColor = colorDialog1.Color;
        }

        // SAVE APPSETTINGS
        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            //Properties.Settings.Default.F1State = this.WindowState;
            //if (this.WindowState == FormWindowState.Normal)
            //{
            //    // save location and size if the state is normal
            //    Properties.Settings.Default.F1Location = this.Location;
            //    Properties.Settings.Default.F1Size = this.Size;
            //}
            //else
            //{
            //    // save the RestoreBounds if the form is minimized or maximized!
            //    Properties.Settings.Default.F1Location = this.RestoreBounds.Location;
            //    Properties.Settings.Default.F1Size = this.RestoreBounds.Size;
            //}

            //// don't forget to save the settings
            //Properties.Settings.Default.Save();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.TransparencyKey = (BackColor);
        }        

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            label1.BackColor = colorDialog2.Color;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    
}
