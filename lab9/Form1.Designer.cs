namespace lab9
{
    partial class Form
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.maxNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lifeTime = new System.Windows.Forms.NumericUpDown();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.canvasBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvasBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.37656F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.62345F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.maxNum, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lifeTime, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.startBtn, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.stopBtn, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.canvasBox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.38596F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.61404F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(563, 372);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(432, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Максимальное количество окружностей";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxNum
            // 
            this.maxNum.BackColor = System.Drawing.Color.Linen;
            this.maxNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxNum.Location = new System.Drawing.Point(432, 43);
            this.maxNum.Name = "maxNum";
            this.maxNum.Size = new System.Drawing.Size(128, 20);
            this.maxNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(432, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вркмя жизни окружности";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lifeTime
            // 
            this.lifeTime.BackColor = System.Drawing.Color.Linen;
            this.lifeTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lifeTime.Location = new System.Drawing.Point(432, 108);
            this.lifeTime.Name = "lifeTime";
            this.lifeTime.Size = new System.Drawing.Size(128, 20);
            this.lifeTime.TabIndex = 3;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.startBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Location = new System.Drawing.Point(432, 144);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(128, 23);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Старт";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.stopBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopBtn.Location = new System.Drawing.Point(432, 173);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(128, 25);
            this.stopBtn.TabIndex = 5;
            this.stopBtn.Text = "Стоп";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // canvasBox
            // 
            this.canvasBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.canvasBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasBox.Location = new System.Drawing.Point(3, 3);
            this.canvasBox.Name = "canvasBox";
            this.tableLayoutPanel1.SetRowSpan(this.canvasBox, 8);
            this.canvasBox.Size = new System.Drawing.Size(423, 366);
            this.canvasBox.TabIndex = 6;
            this.canvasBox.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(587, 396);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form";
            this.Text = "(Almost) Random circles";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvasBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown maxNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown lifeTime;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.PictureBox canvasBox;
    }
}

