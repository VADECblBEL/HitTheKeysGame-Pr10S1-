namespace HitTheKeysGame__Pr10S1_
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.CorrectLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.MissedLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.TotalLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.AccuracyLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.DifficultyPB = new System.Windows.Forms.ToolStripProgressBar();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // listBox1
      // 
      this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 108;
      this.listBox1.Location = new System.Drawing.Point(0, 0);
      this.listBox1.MultiColumn = true;
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(856, 131);
      this.listBox1.TabIndex = 0;
      // 
      // timer1
      // 
      this.timer1.Interval = 800;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CorrectLabel,
            this.MissedLabel,
            this.TotalLabel,
            this.AccuracyLabel,
            this.toolStripStatusLabel1,
            this.DifficultyPB});
      this.statusStrip1.Location = new System.Drawing.Point(0, 109);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(856, 22);
      this.statusStrip1.SizingGrip = false;
      this.statusStrip1.TabIndex = 1;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // CorrectLabel
      // 
      this.CorrectLabel.Name = "CorrectLabel";
      this.CorrectLabel.Size = new System.Drawing.Size(58, 17);
      this.CorrectLabel.Text = "Correct: 0";
      // 
      // MissedLabel
      // 
      this.MissedLabel.Name = "MissedLabel";
      this.MissedLabel.Size = new System.Drawing.Size(56, 17);
      this.MissedLabel.Text = "Missed: 0";
      // 
      // TotalLabel
      // 
      this.TotalLabel.Name = "TotalLabel";
      this.TotalLabel.Size = new System.Drawing.Size(44, 17);
      this.TotalLabel.Text = "Total: 0";
      // 
      // AccuracyLabel
      // 
      this.AccuracyLabel.Name = "AccuracyLabel";
      this.AccuracyLabel.Size = new System.Drawing.Size(78, 17);
      this.AccuracyLabel.Text = "Accuracy: 0%";
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(503, 17);
      this.toolStripStatusLabel1.Spring = true;
      this.toolStripStatusLabel1.Text = "Difficulty";
      this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // DifficultyPB
      // 
      this.DifficultyPB.Maximum = 701;
      this.DifficultyPB.Name = "DifficultyPB";
      this.DifficultyPB.Size = new System.Drawing.Size(100, 16);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(856, 131);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.listBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.KeyPreview = true;
      this.Name = "Form1";
      this.Text = "Hit the keys!";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel CorrectLabel;
        private System.Windows.Forms.ToolStripStatusLabel MissedLabel;
        private System.Windows.Forms.ToolStripStatusLabel TotalLabel;
        private System.Windows.Forms.ToolStripStatusLabel AccuracyLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar DifficultyPB;
    }
}

