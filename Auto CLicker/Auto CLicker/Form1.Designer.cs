namespace Auto_CLicker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MS = new System.Windows.Forms.TextBox();
            this.MS_Thing = new System.Windows.Forms.Label();
            this.TotalAutoClicks = new System.Windows.Forms.Label();
            this.TAC_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeAutoClick_label = new System.Windows.Forms.Label();
            this.UntilStarts = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(15, 77);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // MS
            // 
            this.MS.Location = new System.Drawing.Point(12, 28);
            this.MS.Name = "MS";
            this.MS.Size = new System.Drawing.Size(100, 20);
            this.MS.TabIndex = 1;
            // 
            // MS_Thing
            // 
            this.MS_Thing.AutoSize = true;
            this.MS_Thing.Location = new System.Drawing.Point(12, 9);
            this.MS_Thing.Name = "MS_Thing";
            this.MS_Thing.Size = new System.Drawing.Size(379, 13);
            this.MS_Thing.TabIndex = 2;
            this.MS_Thing.Text = "Mili-seconds interval thing WHATEVER JUST UNDERSTAND WHAT IT IS!!1!";
            // 
            // TotalAutoClicks
            // 
            this.TotalAutoClicks.AutoSize = true;
            this.TotalAutoClicks.Location = new System.Drawing.Point(99, 61);
            this.TotalAutoClicks.Name = "TotalAutoClicks";
            this.TotalAutoClicks.Size = new System.Drawing.Size(13, 13);
            this.TotalAutoClicks.TabIndex = 3;
            this.TotalAutoClicks.Text = "0";
            // 
            // TAC_Label
            // 
            this.TAC_Label.AutoSize = true;
            this.TAC_Label.Location = new System.Drawing.Point(12, 61);
            this.TAC_Label.Name = "TAC_Label";
            this.TAC_Label.Size = new System.Drawing.Size(90, 13);
            this.TAC_Label.TabIndex = 4;
            this.TAC_Label.Text = "Total Auto-Clicks:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "To stop auto-clicking, simply press F9.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(552, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "To start auto-clicking, press the Start button and position your mouse at the  ta" +
    "rget position before the timer rans out.";
            // 
            // TimeAutoClick_label
            // 
            this.TimeAutoClick_label.AutoSize = true;
            this.TimeAutoClick_label.Location = new System.Drawing.Point(9, 251);
            this.TimeAutoClick_label.Name = "TimeAutoClick_label";
            this.TimeAutoClick_label.Size = new System.Drawing.Size(159, 13);
            this.TimeAutoClick_label.TabIndex = 7;
            this.TimeAutoClick_label.Text = "Time until the auto-clicker starts:";
            // 
            // UntilStarts
            // 
            this.UntilStarts.AutoSize = true;
            this.UntilStarts.Location = new System.Drawing.Point(165, 251);
            this.UntilStarts.Name = "UntilStarts";
            this.UntilStarts.Size = new System.Drawing.Size(13, 13);
            this.UntilStarts.TabIndex = 8;
            this.UntilStarts.Text = "0";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 317);
            this.Controls.Add(this.UntilStarts);
            this.Controls.Add(this.TimeAutoClick_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TAC_Label);
            this.Controls.Add(this.TotalAutoClicks);
            this.Controls.Add(this.MS_Thing);
            this.Controls.Add(this.MS);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox MS;
        private System.Windows.Forms.Label MS_Thing;
        private System.Windows.Forms.Label TotalAutoClicks;
        private System.Windows.Forms.Label TAC_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TimeAutoClick_label;
        private System.Windows.Forms.Label UntilStarts;
        private System.Windows.Forms.Timer timer2;
    }
}

