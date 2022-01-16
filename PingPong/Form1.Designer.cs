namespace PingPong
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
            this.gamePanel = new System.Windows.Forms.Panel();
            this.gameBall = new System.Windows.Forms.Panel();
            this.backpanel = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.result = new System.Windows.Forms.Label();
            this.loseLabel = new System.Windows.Forms.Label();
            this.backpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.Red;
            this.gamePanel.Location = new System.Drawing.Point(326, 376);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(98, 23);
            this.gamePanel.TabIndex = 0;
            // 
            // gameBall
            // 
            this.gameBall.BackColor = System.Drawing.Color.Blue;
            this.gameBall.Location = new System.Drawing.Point(151, 111);
            this.gameBall.Name = "gameBall";
            this.gameBall.Size = new System.Drawing.Size(23, 24);
            this.gameBall.TabIndex = 1;
            // 
            // backpanel
            // 
            this.backpanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.backpanel.Controls.Add(this.loseLabel);
            this.backpanel.Controls.Add(this.result);
            this.backpanel.Controls.Add(this.gameBall);
            this.backpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backpanel.Location = new System.Drawing.Point(0, 0);
            this.backpanel.Name = "backpanel";
            this.backpanel.Size = new System.Drawing.Size(800, 450);
            this.backpanel.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(667, 9);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(118, 42);
            this.result.TabIndex = 3;
            this.result.Text = "Счет: 0";
            // 
            // loseLabel
            // 
            this.loseLabel.AutoSize = true;
            this.loseLabel.Font = new System.Drawing.Font("Palatino Linotype", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loseLabel.Location = new System.Drawing.Point(242, 185);
            this.loseLabel.Name = "loseLabel";
            this.loseLabel.Size = new System.Drawing.Size(284, 73);
            this.loseLabel.TabIndex = 4;
            this.loseLabel.Text = "game over";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.backpanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.backpanel.ResumeLayout(false);
            this.backpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Panel gameBall;
        private System.Windows.Forms.Panel backpanel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label loseLabel;
    }
}

