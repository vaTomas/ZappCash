using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ZappCash.classes;

namespace ZappCash.forms
{
    public partial class AccountsPage : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public AccountsPage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblAddAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            if (treeAccounts.SelectedNode != null)
            {
                MakeAcc MakeAcc = new MakeAcc(treeAccounts.SelectedNode.Name);
                MakeAcc.ShowDialog();
            }

            else
            {
                MakeAcc MakeAcc = new MakeAcc();
                MakeAcc.ShowDialog();
            }


            LoadItems();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FileManager.ResetDatabase();
            this.Close();
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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FileManager.OpenFile();
            LoadItems();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileManager.Save();
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            FileManager.SaveAs();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AccountsManager.New();
            LoadItems();
        }

        private void AccountsPage_Load(object sender, EventArgs e)
        {
            
            LoadItems();
        }


        private void LoadItems()
        {
            List<Account> accounts = AccountsManager.GetAccounts();

            treeAccounts.Nodes.Clear();
            foreach (Account account in accounts)
            {
                if (account.ParentId == null)
                {
                    TreeNode treeNode = new TreeNode();
                    treeNode.Name = account.Id;
                    string balance = String.Format("{0:n}", Convert.ToDouble($"{account.Balance}e-{account.Decimals}"));
                    treeNode.Text = $"{account.Attributes.Name} (Php {balance})";
                    treeAccounts.Nodes.Add(treeNode);
                    LoadAccounts(treeNode);

                }
            }
            treeAccounts.CollapseAll();
        }

        private void LoadAccounts(TreeNode parentNode)
        {
            List<Account> accountChildren = AccountsManager.GetAccountChildren(AccountId: parentNode.Name);
            foreach (Account childAccount in accountChildren)
            {
                TreeNode childNode = new TreeNode();
                childNode.Name = childAccount.Id;
                string balance = String.Format("{0:n}", Convert.ToDouble($"{childAccount.Balance}e-{childAccount.Decimals}"));
                childNode.Text = $"{childAccount.Attributes.Name} (Php {balance})";

                parentNode.Nodes.Add(childNode);

                LoadAccounts(childNode);
            }
        }

        private void picEdit_Click(object sender, EventArgs e)
        {

            if (treeAccounts.SelectedNode != null)
            {
                string accountId = treeAccounts.SelectedNode.Name;
                this.Hide();
                EditAccount editAccount = new EditAccount(AccountId: accountId);
                editAccount.ShowDialog();
                
                LoadItems();
                this.Show();
            }
            

        }

        private void treeAccounts_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (treeAccounts.SelectedNode == null)
            {
                return;
            }

            string accountId = treeAccounts.SelectedNode.Name;

            Account account = AccountsManager.GetAccount(accountId);

            //if (account.IsPlaceholder)
            //{
            //    this.Hide();
            //    EditAccount editAccount = new EditAccount();
            //    editAccount.ShowDialog();
            //    this.Show();
            //}

            if (!account.IsPlaceholder)
            {
                this.Hide();
                TransactionsPage transactionsPage = new TransactionsPage(accountId);
                transactionsPage.ShowDialog();

                LoadItems();
                this.Show();
            }
        }
    }
}
