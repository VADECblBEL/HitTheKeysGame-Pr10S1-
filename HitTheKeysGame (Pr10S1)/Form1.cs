using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitTheKeysGame__Pr10S1_
{
  public partial class Form1 : Form
  {
    Random rnd = new Random();
    Stats statistics = new Stats();
    public Form1()
    {
      InitializeComponent();
      timer1.Enabled = true;
      timer1.Start();
    }

        private void timer1_Tick(object sender, EventArgs e)
        {
           listBox1.Items.Add((Keys)rnd.Next(65, 90)); 
           if (listBox1.Items.Count > 7) 
           {
             listBox1.Items.Clear(); 
             listBox1.Items.Add("Игра окончена!");
             timer1.Stop(); 
           }
        }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      if(listBox1.Items.Contains(e.KeyCode))
      {
        listBox1.Items.Remove(e.KeyCode);
        listBox1.Refresh();

        if (timer1.Interval > 400) timer1.Interval -= 10;
        if (timer1.Interval > 250) timer1.Interval -= 7;
        if (timer1.Interval > 100) timer1.Interval -= 2;

        DifficultyPB.Value = 800 - timer1.Interval;
        statistics.Update(true);
      }
      else
      {
        statistics.Update(false);
      }

      CorrectLabel.Text = "Correct: " + statistics.Correct;
      MissedLabel.Text = "Missed: " + statistics.Missed;
      TotalLabel.Text = "Total: " + statistics.Total;
      AccuracyLabel.Text = "Accuracy: " + statistics.Accuracy + "%";
    }
  }
}
