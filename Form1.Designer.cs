namespace DeulCalculator
{
    partial class calculator
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculator));
            this.player1minus = new System.Windows.Forms.Button();
            this.player1life = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.player2minus = new System.Windows.Forms.Button();
            this.player2life = new System.Windows.Forms.TextBox();
            this.player1plus = new System.Windows.Forms.Button();
            this.player2plus = new System.Windows.Forms.Button();
            this.ac = new System.Windows.Forms.Button();
            this.lifeChange = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.num00 = new System.Windows.Forms.Button();
            this.num000 = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.player1half = new System.Windows.Forms.Button();
            this.player2half = new System.Windows.Forms.Button();
            this.player1change = new System.Windows.Forms.Button();
            this.player2change = new System.Windows.Forms.Button();
            this.rollDice = new System.Windows.Forms.Button();
            this.tossCoin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // player1minus
            // 
            this.player1minus.Location = new System.Drawing.Point(12, 48);
            this.player1minus.Name = "player1minus";
            this.player1minus.Size = new System.Drawing.Size(75, 23);
            this.player1minus.TabIndex = 0;
            this.player1minus.Text = "-";
            this.player1minus.UseVisualStyleBackColor = true;
            this.player1minus.Click += new System.EventHandler(this.player1minus_Click);
            // 
            // player1life
            // 
            this.player1life.Location = new System.Drawing.Point(12, 12);
            this.player1life.Name = "player1life";
            this.player1life.Size = new System.Drawing.Size(75, 21);
            this.player1life.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // player2minus
            // 
            this.player2minus.Location = new System.Drawing.Point(197, 48);
            this.player2minus.Name = "player2minus";
            this.player2minus.Size = new System.Drawing.Size(75, 23);
            this.player2minus.TabIndex = 3;
            this.player2minus.Text = "-";
            this.player2minus.UseVisualStyleBackColor = true;
            this.player2minus.Click += new System.EventHandler(this.player2minus_Click);
            // 
            // player2life
            // 
            this.player2life.Location = new System.Drawing.Point(197, 12);
            this.player2life.Name = "player2life";
            this.player2life.Size = new System.Drawing.Size(75, 21);
            this.player2life.TabIndex = 4;
            // 
            // player1plus
            // 
            this.player1plus.Location = new System.Drawing.Point(12, 77);
            this.player1plus.Name = "player1plus";
            this.player1plus.Size = new System.Drawing.Size(75, 23);
            this.player1plus.TabIndex = 5;
            this.player1plus.Text = "+";
            this.player1plus.UseVisualStyleBackColor = true;
            this.player1plus.Click += new System.EventHandler(this.player1plus_Click);
            // 
            // player2plus
            // 
            this.player2plus.Location = new System.Drawing.Point(197, 77);
            this.player2plus.Name = "player2plus";
            this.player2plus.Size = new System.Drawing.Size(75, 23);
            this.player2plus.TabIndex = 6;
            this.player2plus.Text = "+";
            this.player2plus.UseVisualStyleBackColor = true;
            this.player2plus.Click += new System.EventHandler(this.player2plus_Click);
            // 
            // ac
            // 
            this.ac.Location = new System.Drawing.Point(106, 77);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(75, 23);
            this.ac.TabIndex = 7;
            this.ac.Text = "AC";
            this.ac.UseVisualStyleBackColor = true;
            this.ac.Click += new System.EventHandler(this.ac_Click);
            // 
            // lifeChange
            // 
            this.lifeChange.Location = new System.Drawing.Point(106, 48);
            this.lifeChange.Name = "lifeChange";
            this.lifeChange.Size = new System.Drawing.Size(75, 21);
            this.lifeChange.TabIndex = 8;
            this.lifeChange.TextChanged += new System.EventHandler(this.lifeChange_TextChanged);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(12, 106);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(75, 23);
            this.num1.TabIndex = 9;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(106, 106);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(75, 23);
            this.num2.TabIndex = 10;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(197, 106);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(75, 23);
            this.num3.TabIndex = 11;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(12, 135);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(75, 23);
            this.num4.TabIndex = 12;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(106, 135);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(75, 23);
            this.num5.TabIndex = 13;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(197, 135);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(75, 23);
            this.num6.TabIndex = 14;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(12, 164);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(75, 23);
            this.num7.TabIndex = 15;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(106, 164);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(75, 23);
            this.num8.TabIndex = 16;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(197, 164);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(75, 23);
            this.num9.TabIndex = 17;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num0
            // 
            this.num0.Location = new System.Drawing.Point(12, 193);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(75, 23);
            this.num0.TabIndex = 18;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // num00
            // 
            this.num00.Location = new System.Drawing.Point(106, 193);
            this.num00.Name = "num00";
            this.num00.Size = new System.Drawing.Size(75, 23);
            this.num00.TabIndex = 19;
            this.num00.Text = "00";
            this.num00.UseVisualStyleBackColor = true;
            this.num00.Click += new System.EventHandler(this.num00_Click);
            // 
            // num000
            // 
            this.num000.Location = new System.Drawing.Point(197, 193);
            this.num000.Name = "num000";
            this.num000.Size = new System.Drawing.Size(75, 23);
            this.num000.TabIndex = 20;
            this.num000.Text = "000";
            this.num000.UseVisualStyleBackColor = true;
            this.num000.Click += new System.EventHandler(this.num000_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(106, 12);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 21;
            this.reset.Text = "New Game";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // player1half
            // 
            this.player1half.Location = new System.Drawing.Point(12, 222);
            this.player1half.Name = "player1half";
            this.player1half.Size = new System.Drawing.Size(75, 23);
            this.player1half.TabIndex = 22;
            this.player1half.Text = "1/2";
            this.player1half.UseVisualStyleBackColor = true;
            this.player1half.Click += new System.EventHandler(this.player1half_Click);
            // 
            // player2half
            // 
            this.player2half.Location = new System.Drawing.Point(197, 222);
            this.player2half.Name = "player2half";
            this.player2half.Size = new System.Drawing.Size(75, 23);
            this.player2half.TabIndex = 23;
            this.player2half.Text = "1/2";
            this.player2half.UseVisualStyleBackColor = true;
            this.player2half.Click += new System.EventHandler(this.player2half_Click);
            // 
            // player1change
            // 
            this.player1change.Location = new System.Drawing.Point(12, 251);
            this.player1change.Name = "player1change";
            this.player1change.Size = new System.Drawing.Size(75, 23);
            this.player1change.TabIndex = 24;
            this.player1change.Text = "ChangeTo";
            this.player1change.UseVisualStyleBackColor = true;
            this.player1change.Click += new System.EventHandler(this.player1change_Click);
            // 
            // player2change
            // 
            this.player2change.Location = new System.Drawing.Point(197, 251);
            this.player2change.Name = "player2change";
            this.player2change.Size = new System.Drawing.Size(75, 23);
            this.player2change.TabIndex = 25;
            this.player2change.Text = "ChangeTo";
            this.player2change.UseVisualStyleBackColor = true;
            this.player2change.Click += new System.EventHandler(this.player2change_Click);
            // 
            // rollDice
            // 
            this.rollDice.Location = new System.Drawing.Point(106, 222);
            this.rollDice.Name = "rollDice";
            this.rollDice.Size = new System.Drawing.Size(75, 23);
            this.rollDice.TabIndex = 26;
            this.rollDice.Text = "RollDice";
            this.rollDice.UseVisualStyleBackColor = true;
            this.rollDice.Click += new System.EventHandler(this.rollDice_Click);
            // 
            // tossCoin
            // 
            this.tossCoin.Location = new System.Drawing.Point(106, 251);
            this.tossCoin.Name = "tossCoin";
            this.tossCoin.Size = new System.Drawing.Size(75, 23);
            this.tossCoin.TabIndex = 27;
            this.tossCoin.Text = "TossCoin";
            this.tossCoin.UseVisualStyleBackColor = true;
            this.tossCoin.Click += new System.EventHandler(this.tossCoin_Click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.tossCoin);
            this.Controls.Add(this.rollDice);
            this.Controls.Add(this.player2change);
            this.Controls.Add(this.player1change);
            this.Controls.Add(this.player2half);
            this.Controls.Add(this.player1half);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.num000);
            this.Controls.Add(this.num00);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.lifeChange);
            this.Controls.Add(this.ac);
            this.Controls.Add(this.player2plus);
            this.Controls.Add(this.player1plus);
            this.Controls.Add(this.player2life);
            this.Controls.Add(this.player2minus);
            this.Controls.Add(this.player1life);
            this.Controls.Add(this.player1minus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calculator";
            this.Text = "Yu-Gi-Oh!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button player1minus;
        private System.Windows.Forms.TextBox player1life;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button player2minus;
        private System.Windows.Forms.TextBox player2life;
        private System.Windows.Forms.Button player1plus;
        private System.Windows.Forms.Button player2plus;
        private System.Windows.Forms.Button ac;
        private System.Windows.Forms.TextBox lifeChange;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button num00;
        private System.Windows.Forms.Button num000;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button player1half;
        private System.Windows.Forms.Button player2half;
        private System.Windows.Forms.Button player1change;
        private System.Windows.Forms.Button player2change;
        private System.Windows.Forms.Button rollDice;
        private System.Windows.Forms.Button tossCoin;
    }
}

