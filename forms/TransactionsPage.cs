﻿using System;
using System.Drawing;
using System.Windows.Forms;
using ZappCash.classes;
using ZappCash.forms.MessageBoxForms;
using ZappCash.forms.MessageBoxForms.EditOrDelete;
using ZappCash.packages;

namespace ZappCash.forms
{
    public partial class TransactionsPage : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private Account account { get; set; }
        public TransactionsPage(string AccountId)
        {
            InitializeComponent();
            this.account = AccountsManager.GetAccount(AccountId);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseApplication();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            this.Hide();
            AddTransactions AddTransactions = new AddTransactions(account.Id);
            AddTransactions.ShowDialog();
            LoadItems();
            this.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            try
            {
                FileManager.OpenFile();
            }
            catch
            {
                this.Hide();
                NoNameMB noNameMB = new NoNameMB("Unsupported File");
                noNameMB.ShowDialog();
                this.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileManager.Save();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileManager.SaveAs();
        }

        private void TransactionsPage_Load(object sender, EventArgs e)
        {
            label1.Text = $"{account.Attributes.Name} Transactions";
            LoadItems();

        }

        private void LoadItems()
        {
            listTransactions.Items.Clear();
            foreach (Transaction transaction in account.Transactions)
            {
                string amount;

                if (transaction.Amount < 0)
                {
                    amount = String.Format("Php ({0:n})", Convert.ToDouble($"{-transaction.Amount}e-{account.Decimals}"));
                }
                else
                {
                    amount = String.Format("Php {0:n}", Convert.ToDouble($"{transaction.Amount}e-{account.Decimals}"));
                }

                string balance;
                if (transaction.Balance < 0)
                {
                    balance = String.Format("Php ({0:n})", Convert.ToDouble($"{-transaction.Balance}e-{account.Decimals}"));
                }
                else
                {
                    balance = String.Format("Php {0:n}", Convert.ToDouble($"{transaction.Balance}e-{account.Decimals}"));
                }

                string[] row = { zc_dateTime.dateTimeToString(transaction.Date), transaction.Number, transaction.Description, AccountsManager.GetAccount(transaction.TransferId).Attributes.Name, amount, balance };
                ListViewItem listViewItem = new ListViewItem(row);
                if (transaction.Balance < 0)
                {
                    listViewItem.SubItems[5].ForeColor = Color.Red;
                    listViewItem.UseItemStyleForSubItems = false;
                }
                listViewItem.Name = transaction.Id;
                listTransactions.Items.Add(listViewItem);
            }
        }

        private void listTransactions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Hide();

            string transactionId = listTransactions.SelectedItems[0].Name;
            EditTransaction editTransaction = new EditTransaction(this.account.Id, transactionId);
            editTransaction.ShowDialog();

            if (editTransaction.DialogResult == DialogResult.Abort) { this.Close(); return; }

            LoadItems();
            this.Show();
        }

        private void CloseApplication()
        {
            if (!FileManager.IsAllSaved())
            {
                this.Hide();
                ExitConfirmation exitConfirmation = new ExitConfirmation();
                exitConfirmation.ShowDialog();

                if (exitConfirmation.DialogResult == DialogResult.Cancel)
                {
                    this.Show();
                    return;
                }

                if (exitConfirmation.DialogResult == DialogResult.Yes)
                {
                    FileManager.Save();
                }
            }


            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
