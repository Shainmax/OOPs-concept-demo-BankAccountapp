namespace BankAccountapp
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();

        public Form1()
        {
            InitializeComponent();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Ownertxt.Text))
            { return; }

            if(IntrestRateNum.Value > 0)
            {
                SavingAccount savingAccount = new SavingAccount(Ownertxt.Text, IntrestRateNum.Value);
                BankAccounts.Add(savingAccount);

            }
            else {
                BankAccount bankAccount = new BankAccount(Ownertxt.Text);
                BankAccounts.Add(bankAccount);
            }
            

            RefreshGrid();
            Ownertxt.Text = string.Empty;


        }

        private void RefreshGrid()
        {
            BankAccountGrid.DataSource = null;
            BankAccountGrid.DataSource = BankAccounts;
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountGrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
            {
                BankAccount SelectBankAccount = BankAccountGrid.SelectedRows[0].DataBoundItem as BankAccount;
                string message = SelectBankAccount.Deposit(AmountNum.Value);
                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);
            }
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountGrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
            {
                BankAccount SelectBankAccount = BankAccountGrid.SelectedRows[0].DataBoundItem as BankAccount;
                string message = SelectBankAccount.Withdraw(AmountNum.Value);
                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);
            }
        }

       
    }
}
