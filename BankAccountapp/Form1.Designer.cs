namespace BankAccountapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            Ownertxt = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountGrid = new DataGridView();
            DepositBtn = new Button();
            WithdrawBtn = new Button();
            CreateAccountBtn = new Button();
            label3 = new Label();
            IntrestRateNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IntrestRateNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 32);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Owner";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 178);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Amount";
            label2.Click += label2_Click;
            // 
            // Ownertxt
            // 
            Ownertxt.Location = new Point(192, 29);
            Ownertxt.Name = "Ownertxt";
            Ownertxt.Size = new Size(175, 27);
            Ownertxt.TabIndex = 2;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(201, 178);
            AmountNum.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(165, 27);
            AmountNum.TabIndex = 3;
            // 
            // BankAccountGrid
            // 
            BankAccountGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountGrid.Location = new Point(390, 32);
            BankAccountGrid.Name = "BankAccountGrid";
            BankAccountGrid.RowHeadersWidth = 51;
            BankAccountGrid.Size = new Size(379, 148);
            BankAccountGrid.TabIndex = 4;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(390, 196);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(165, 29);
            DepositBtn.TabIndex = 5;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(604, 196);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(165, 29);
            WithdrawBtn.TabIndex = 6;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(192, 119);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(175, 29);
            CreateAccountBtn.TabIndex = 7;
            CreateAccountBtn.Text = "Create account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 76);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 8;
            label3.Text = "Intrest Rate(%)";
            //label3.Click += label3_Click;
            // 
            // IntrestRateNum
            // 
            IntrestRateNum.Location = new Point(192, 74);
            IntrestRateNum.Name = "IntrestRateNum";
            IntrestRateNum.Size = new Size(174, 27);
            IntrestRateNum.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IntrestRateNum);
            Controls.Add(label3);
            Controls.Add(CreateAccountBtn);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(BankAccountGrid);
            Controls.Add(AmountNum);
            Controls.Add(Ownertxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)IntrestRateNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Ownertxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountGrid;
        private Button DepositBtn;
        private Button WithdrawBtn;
        private Button CreateAccountBtn;
        private Label label3;
        private NumericUpDown IntrestRateNum;
    }
}
