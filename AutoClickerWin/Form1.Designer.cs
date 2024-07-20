namespace AutoClickerWin
{
    partial class AutoClicker
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.RollButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.GroupBoxOnOf = new System.Windows.Forms.GroupBox();
            this.ButtonOne = new System.Windows.Forms.RadioButton();
            this.ButtonDouble = new System.Windows.Forms.RadioButton();
            this.GroupBoxLeftRight = new System.Windows.Forms.GroupBox();
            this.ButtonRight = new System.Windows.Forms.RadioButton();
            this.ButtonLeft = new System.Windows.Forms.RadioButton();
            this.LabelY = new System.Windows.Forms.Label();
            this.LabelX = new System.Windows.Forms.Label();
            this.TextBoxForY = new System.Windows.Forms.TextBox();
            this.TextBoxForX = new System.Windows.Forms.TextBox();
            this.ButtonPickLoc = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxForSecs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxForMins = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RollButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.GroupBoxOnOf.SuspendLayout();
            this.GroupBoxLeftRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TopPanel.Controls.Add(this.RollButton);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(350, 30);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // RollButton
            // 
            this.RollButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RollButton.Image = global::AutoClickerWin.Properties.Resources.yellowcircle;
            this.RollButton.Location = new System.Drawing.Point(282, 2);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(25, 25);
            this.RollButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RollButton.TabIndex = 1;
            this.RollButton.TabStop = false;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Image = global::AutoClickerWin.Properties.Resources.redcircle;
            this.CloseButton.Location = new System.Drawing.Point(313, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 25);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseButton.TabIndex = 1;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "AutoClicker";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.MainPanel.Controls.Add(this.GroupBoxOnOf);
            this.MainPanel.Controls.Add(this.GroupBoxLeftRight);
            this.MainPanel.Controls.Add(this.LabelY);
            this.MainPanel.Controls.Add(this.LabelX);
            this.MainPanel.Controls.Add(this.TextBoxForY);
            this.MainPanel.Controls.Add(this.TextBoxForX);
            this.MainPanel.Controls.Add(this.ButtonPickLoc);
            this.MainPanel.Controls.Add(this.ButtonStop);
            this.MainPanel.Controls.Add(this.ButtonStart);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.TextBoxForSecs);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.TextBoxForMins);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 30);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(350, 270);
            this.MainPanel.TabIndex = 1;
            // 
            // GroupBoxOnOf
            // 
            this.GroupBoxOnOf.Controls.Add(this.ButtonOne);
            this.GroupBoxOnOf.Controls.Add(this.ButtonDouble);
            this.GroupBoxOnOf.Location = new System.Drawing.Point(177, 109);
            this.GroupBoxOnOf.Name = "GroupBoxOnOf";
            this.GroupBoxOnOf.Size = new System.Drawing.Size(161, 38);
            this.GroupBoxOnOf.TabIndex = 14;
            this.GroupBoxOnOf.TabStop = false;
            // 
            // ButtonOne
            // 
            this.ButtonOne.AutoSize = true;
            this.ButtonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonOne.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonOne.Location = new System.Drawing.Point(6, 12);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(54, 19);
            this.ButtonOne.TabIndex = 2;
            this.ButtonOne.Text = "ONE";
            this.ButtonOne.UseVisualStyleBackColor = true;
            this.ButtonOne.Click += new System.EventHandler(this.ButtonOne_Click);
            // 
            // ButtonDouble
            // 
            this.ButtonDouble.AutoSize = true;
            this.ButtonDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDouble.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonDouble.Location = new System.Drawing.Point(66, 12);
            this.ButtonDouble.Name = "ButtonDouble";
            this.ButtonDouble.Size = new System.Drawing.Size(78, 19);
            this.ButtonDouble.TabIndex = 2;
            this.ButtonDouble.Text = "DOUBLE";
            this.ButtonDouble.UseVisualStyleBackColor = true;
            this.ButtonDouble.CheckedChanged += new System.EventHandler(this.ButtonDouble_CheckedChanged);
            this.ButtonDouble.Click += new System.EventHandler(this.ButtonDouble_Click);
            // 
            // GroupBoxLeftRight
            // 
            this.GroupBoxLeftRight.Controls.Add(this.ButtonRight);
            this.GroupBoxLeftRight.Controls.Add(this.ButtonLeft);
            this.GroupBoxLeftRight.Location = new System.Drawing.Point(6, 109);
            this.GroupBoxLeftRight.Name = "GroupBoxLeftRight";
            this.GroupBoxLeftRight.Size = new System.Drawing.Size(161, 38);
            this.GroupBoxLeftRight.TabIndex = 13;
            this.GroupBoxLeftRight.TabStop = false;
            // 
            // ButtonRight
            // 
            this.ButtonRight.AutoSize = true;
            this.ButtonRight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonRight.Location = new System.Drawing.Point(76, 12);
            this.ButtonRight.Name = "ButtonRight";
            this.ButtonRight.Size = new System.Drawing.Size(70, 20);
            this.ButtonRight.TabIndex = 1;
            this.ButtonRight.Text = "RIGHT";
            this.ButtonRight.UseVisualStyleBackColor = true;
            this.ButtonRight.Click += new System.EventHandler(this.ButtonRight_Click);
            // 
            // ButtonLeft
            // 
            this.ButtonLeft.AutoSize = true;
            this.ButtonLeft.Checked = true;
            this.ButtonLeft.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonLeft.Location = new System.Drawing.Point(6, 12);
            this.ButtonLeft.Name = "ButtonLeft";
            this.ButtonLeft.Size = new System.Drawing.Size(61, 20);
            this.ButtonLeft.TabIndex = 0;
            this.ButtonLeft.TabStop = true;
            this.ButtonLeft.Text = "LEFT";
            this.ButtonLeft.UseVisualStyleBackColor = true;
            this.ButtonLeft.CheckedChanged += new System.EventHandler(this.ButtonLeft_CheckedChanged);
            this.ButtonLeft.Click += new System.EventHandler(this.ButtonLeft_Click);
            // 
            // LabelY
            // 
            this.LabelY.AutoSize = true;
            this.LabelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelY.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelY.Location = new System.Drawing.Point(122, 150);
            this.LabelY.Name = "LabelY";
            this.LabelY.Size = new System.Drawing.Size(19, 20);
            this.LabelY.TabIndex = 12;
            this.LabelY.Text = "Y";
            // 
            // LabelX
            // 
            this.LabelX.AutoSize = true;
            this.LabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelX.Location = new System.Drawing.Point(29, 150);
            this.LabelX.Name = "LabelX";
            this.LabelX.Size = new System.Drawing.Size(20, 20);
            this.LabelX.TabIndex = 11;
            this.LabelX.Text = "X";
            // 
            // TextBoxForY
            // 
            this.TextBoxForY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxForY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxForY.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBoxForY.Location = new System.Drawing.Point(99, 173);
            this.TextBoxForY.MaxLength = 2;
            this.TextBoxForY.Name = "TextBoxForY";
            this.TextBoxForY.ReadOnly = true;
            this.TextBoxForY.Size = new System.Drawing.Size(68, 36);
            this.TextBoxForY.TabIndex = 10;
            this.TextBoxForY.Text = "0";
            this.TextBoxForY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxForX
            // 
            this.TextBoxForX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxForX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxForX.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBoxForX.Location = new System.Drawing.Point(6, 173);
            this.TextBoxForX.MaxLength = 2;
            this.TextBoxForX.Name = "TextBoxForX";
            this.TextBoxForX.ReadOnly = true;
            this.TextBoxForX.Size = new System.Drawing.Size(68, 36);
            this.TextBoxForX.TabIndex = 9;
            this.TextBoxForX.Text = "0";
            this.TextBoxForX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonPickLoc
            // 
            this.ButtonPickLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPickLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPickLoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonPickLoc.Location = new System.Drawing.Point(177, 166);
            this.ButtonPickLoc.Name = "ButtonPickLoc";
            this.ButtonPickLoc.Size = new System.Drawing.Size(161, 43);
            this.ButtonPickLoc.TabIndex = 8;
            this.ButtonPickLoc.Text = "PICK LOCATION (F3)";
            this.ButtonPickLoc.UseVisualStyleBackColor = true;
            this.ButtonPickLoc.Click += new System.EventHandler(this.ButtonPickLoc_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonStop.Location = new System.Drawing.Point(177, 215);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(161, 43);
            this.ButtonStop.TabIndex = 7;
            this.ButtonStop.Text = "STOP (F12)";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonStart.Location = new System.Drawing.Point(6, 215);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(161, 43);
            this.ButtonStart.TabIndex = 6;
            this.ButtonStart.Text = "START (F2)";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(284, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "SECS";
            // 
            // TextBoxForSecs
            // 
            this.TextBoxForSecs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxForSecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxForSecs.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBoxForSecs.Location = new System.Drawing.Point(177, 35);
            this.TextBoxForSecs.MaxLength = 2;
            this.TextBoxForSecs.Name = "TextBoxForSecs";
            this.TextBoxForSecs.Size = new System.Drawing.Size(100, 36);
            this.TextBoxForSecs.TabIndex = 4;
            this.TextBoxForSecs.Text = "0";
            this.TextBoxForSecs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxForSecs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxForSecs_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(121, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "MINS";
            // 
            // TextBoxForMins
            // 
            this.TextBoxForMins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxForMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxForMins.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBoxForMins.Location = new System.Drawing.Point(12, 35);
            this.TextBoxForMins.MaxLength = 2;
            this.TextBoxForMins.Name = "TextBoxForMins";
            this.TextBoxForMins.Size = new System.Drawing.Size(100, 36);
            this.TextBoxForMins.TabIndex = 2;
            this.TextBoxForMins.Text = "0";
            this.TextBoxForMins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxForMins.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxForMins_KeyDown);
            this.TextBoxForMins.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxForMins_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Click options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Click interval";
            // 
            // AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutoClicker";
            this.Text = "Form1";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RollButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.GroupBoxOnOf.ResumeLayout(false);
            this.GroupBoxOnOf.PerformLayout();
            this.GroupBoxLeftRight.ResumeLayout(false);
            this.GroupBoxLeftRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox RollButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxForSecs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxForMins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton ButtonOne;
        private System.Windows.Forms.GroupBox GroupBoxOnOf;
        private System.Windows.Forms.RadioButton ButtonDouble;
        private System.Windows.Forms.GroupBox GroupBoxLeftRight;
        private System.Windows.Forms.RadioButton ButtonRight;
        private System.Windows.Forms.RadioButton ButtonLeft;
        private System.Windows.Forms.Label LabelY;
        private System.Windows.Forms.Label LabelX;
        private System.Windows.Forms.TextBox TextBoxForY;
        private System.Windows.Forms.TextBox TextBoxForX;
        private System.Windows.Forms.Button ButtonPickLoc;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button ButtonStart;
    }
}

