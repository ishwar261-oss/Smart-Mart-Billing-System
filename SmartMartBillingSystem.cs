using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SmartMartBillingSystem
{
    public partial class SmartMartBillingSystem : Form
    {
        public SmartMartBillingSystem()
        {
            InitializeComponent();
        }

        int Item_No = 0;
        double Total_Amount = 0;
        double Discount_Amount = 0;
        double Store_Discount = 8;  // Our Stores Gives 8% Discount over Total Amount 
        double cgst = 0;
        double sgst = 0;
        double SGSTRate = 2.5;
        double CGSTRate = 3.3;
        double Payable_Amount = 0;
        int Edit_RowIndex = -1;

        // Methid to calculate all things 
        void Calculate_Amount()
        {
            // All Amount & Tax Calculations..
            Discount_Amount = (Total_Amount * Store_Discount) / 100;

            double Taxable_Amount = Total_Amount - Discount_Amount;

            sgst = (Taxable_Amount * SGSTRate) / 100;
            cgst = (Taxable_Amount * CGSTRate) / 100;

            Payable_Amount = Taxable_Amount + sgst + cgst;

            // Assigning Calculated values to Controls
            lblSum_TotAmt.Text = "TOTAL AMOUNT :    ₹ " + Total_Amount.ToString("0.00");
            lblSum_StrDisc.Text = "STORE DISCOUNT :    ₹ " + Discount_Amount.ToString("0.00");
            lblSum_cgst.Text = "CGST (3.3%) :    ₹ " + cgst.ToString("0.00");
            lblSum_sgst.Text = "SGST (2.5%) :    ₹ " + sgst.ToString("0.00");

            lblSum_PayAmt.Text = "Payable Amount :    ₹ " + Payable_Amount.ToString("0.00"); // dISPLAY FINAL PAYABLE AMOUNT..

            lblBtmToItm.Text = "Total Item : " + Item_No.ToString("0"); // display total number of iems & updates

            lblBtmToAmt.Text = " ₹ " + Total_Amount.ToString("0.00");// Total Amount at bottom of DGV
        }

        private void SmartMartBillingSystem_Load(object sender, EventArgs e)
        {
            // to display cash payment mode by default 
            lblPaidAmt.Visible = true;
            txtPaidAmt.Visible = true;
            lblChange.Visible = true;

            lblUPI_ID.Visible = false;
            PicQR.Visible = false;

            dgvItems.ColumnCount = 5;

            // Column names
            dgvItems.Columns[0].Name = "No";
            dgvItems.Columns[1].Name = "Item Name";
            dgvItems.Columns[2].Name = "Qty";
            dgvItems.Columns[3].Name = "Price";
            dgvItems.Columns[4].Name = "Total";

            // Column widths
            dgvItems.Columns[0].Width = 50;
            dgvItems.Columns[1].Width = 275;
            dgvItems.Columns[2].Width = 80;
            dgvItems.Columns[3].Width = 127;
            dgvItems.Columns[4].Width = 130;

            // DataGridView settings
            dgvItems.AllowUserToAddRows = false;
            dgvItems.ReadOnly = true;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Select full row when clicked
            dgvItems.MultiSelect = false;

            dgvItems.RowHeadersVisible = false;

            dgvItems.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgvItems.DefaultCellStyle.ForeColor = Color.Black;

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void tnEdit_Click(object sender, EventArgs e)
        {

        }

        private void PnlItmEtry_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void pnlItmEtry_Paint(object sender, EventArgs e)
        {

        }
        private void lblbilldtlTitle_Click(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btnRemoveItm_Click(object sender, EventArgs e)
        {
            if (dgvItems.Rows.Count == 0)
            {
                MessageBox.Show("Error : Please Select A Row To Remove..!!");
                return;
            }

            DataGridViewRow row = dgvItems.SelectedRows[0]; // Get Selected Row..

            //Reads the value from column index 4 (Total column) of that row and converts it to double.
            double Item_Total = Convert.ToDouble(row.Cells[4].Value);


            Total_Amount -= Item_Total; // Decrease Total Amount by Subtracting Removed Item Total..

            Item_No--; // Decrease Total Item Count by 1..

            if (Total_Amount < 0)
                Total_Amount = 0;

            dgvItems.Rows.Remove(row); // Remove Selected Row from DataGridView..                                                                                 

            Calculate_Amount(); //Recalculete After Removing Item

            //Reset Chsh Chabge
            txtPaidAmt.Clear();
            lblChange.Text = "Change Return : ₹ 0.00";
        }

        // Method of Edit Item Button Click Event
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Error : Please Select A Row To Edit..!!");
                return;
            }

            DataGridViewRow row = dgvItems.SelectedRows[0]; // Get Selected Row..

            //Saves the index of the selected row so we know which row to update later.
            Edit_RowIndex = row.Index;

            //Puts the selected items name, quantity, and price back into the input controls for editing.
            txtItemName.Text = row.Cells[1].Value.ToString();
            ndeQty.Value = Convert.ToInt32(row.Cells[2].Value);
            txtPrice.Text = row.Cells[3].Value.ToString();

            //Subtracts the old item total so it not be counted twice when updated. (remove old total of item)
            Total_Amount -= Convert.ToDouble(row.Cells[4].Value);

            //Prevents adding a new item while editing
            btnAddItem.Enabled = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Edit_RowIndex == -1)
                return;

            // Getting Edited Values from Input Controls..
            string Item_name = txtItemName.Text;
            int Qty = (int)ndeQty.Value;
            double Price = Convert.ToDouble(txtPrice.Text);

            // Calculating Total for Edited Item..
            double Total = Qty * Price;

            // Getting the Row to be Edited using Saved Row Index..
            DataGridViewRow row = dgvItems.Rows[Edit_RowIndex];

            // Assigning Edited Values to the Selected Row.. to update
            row.Cells[1].Value = Item_name;
            row.Cells[2].Value = Total;
            row.Cells[3].Value = Price;
            row.Cells[4].Value = Total;

            Total_Amount += Total; // updates all payable amoutn labl

            // Calculate All Amounts Again After Editing Item..
            Calculate_Amount();

            // Reset Edit State
            Edit_RowIndex = -1;

            btnAddItem.Enabled = true; // Enable Add Item Button Again..

            // Clear Inputs Contros to take input for other items..
            txtItemName.Clear();
            txtPrice.Clear();
            ndeQty.Value = 1;

            txtItemName.Focus(); // take cursor again to first textbox..

        }

        private void btnNew_Bill_Click(object sender, EventArgs e)
        {
            dgvItems.Rows.Clear();

            Item_No = 0;
            Total_Amount = 0;
            Discount_Amount = 0;
            cgst = 0;
            sgst = 0;
            Payable_Amount = 0;
            Edit_RowIndex = -1;

            txtItemName.Clear();
            ndeQty.Value = 1;
            txtPrice.Clear();
            txtPaidAmt.Clear();

            lblSum_TotAmt.Text = "TOTAL AMOUNT :    ₹ 0.00";
            lblSum_StrDisc.Text = "STORE DISCOUNT :    ₹ 0.00";
            lblSum_cgst.Text = "CGST (3.3%) :    ₹ 0.00";
            lblSum_sgst.Text = "SGST (2.5%) :    ₹ 0.00";

            lblSum_PayAmt.Text = "Payable Amount :    ₹ 0.00";

            lblBtmToItm.Text = "Total Item : 0";
            lblBtmToAmt.Text = " ₹ 0.00";
            lblChange.Text = "Change Returned : ₹ 0.00";

            rbCash.Checked = true;

            btnAddItem.Enabled = true;

            txtItemName.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                 "Are you sure you want to exit?",
                     "Exit Application",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pnlSumShow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblChange_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text == "" || txtPrice.Text == "" || ndeQty.Value == 0)
            {
                MessageBox.Show("Please Enter Details For The Items First..!!");
                return;
            }

            // Getting Item Details from Input Controls..
            string Item_Name = txtItemName.Text;
            int Qty = (int)ndeQty.Value;
            double Price = Convert.ToDouble(txtPrice.Text);
            double Total = Qty * Price;

            Item_No++; // Increment Item Number.. by 1

            dgvItems.Rows.Add(Item_No, Item_Name, Qty, Price, Total); // Adding Items into Data Grid View after pressing [ Add Item ] button..

            Total_Amount += Total; // updates all payable amoutn lables

            Calculate_Amount();

            // Clear Inputs to take input for other items..
            txtItemName.Clear();
            txtPrice.Clear();
            ndeQty.Value = 1;
            txtItemName.Focus();  // take cursor again to first textbox.. 
        }

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbCash.Checked)
                return;


            lblPaidAmt.Visible = true;
            txtPaidAmt.Visible = true;
            lblChange.Visible = true;

            lblUPI_ID.Visible = false;
            PicQR.Visible = false;

        }

        private void rcUPI_CheckedChanged(object sender, EventArgs e)
        {
            if (!rcUPI.Checked)
                return;


            lblPaidAmt.Visible = false;
            txtPaidAmt.Visible = false;
            lblChange.Visible = false;

            lblUPI_ID.Visible = true;
            PicQR.Visible = true;

            PicQR.BringToFront();

        }
        private void txtPaidAmt_TextChanged_1(object sender, EventArgs e)
        {
            if (!rbCash.Checked)
                return;

            double paid = 0;                           //out is used to send a value back from a method
            double.TryParse(txtPaidAmt.Text, out paid);  //taking text from textbox and converting into double to store into paid; 

            double change = paid - Payable_Amount; //calculating change

            if (change >= 0)
                lblChange.Text = "Change Returned : ₹ " + change.ToString("0.00");
            else
                lblChange.Text = "Insuffecient Amount..!!!";

        }

        private void lblSum_PayAmt_Click(object sender, EventArgs e)
        {

        }
        private void lblSum_sgst_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_bill_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }


        private void lblbillsumTitle_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Graphics g = e.Graphics;
            int y = 20;

            Font Title = new Font("Consolas", 14, FontStyle.Bold);
            Font Bold = new Font("Consolas", 10, FontStyle.Bold);
            Font Normal = new Font("Consolas", 10);

            int Left = 20; //property to align text pasition from left 
                           // int Right = 420; //property to align text pasition from right

            // -------- Header --------
            g.DrawString(" SMART MART SUPERMARKET ", Title, Brushes.Black, Left + 100, y);
            y += 25; // spacing between two lines

            g.DrawString("GSTIN : 33DIZ9145768IDZ", Normal, Brushes.Black, Left + 140, y);
            y += 20;

            g.DrawString("Latur, Maharashtra", Normal, Brushes.Black, Left + 155, y);
            y += 20;

            g.DrawString(new string('=', 55), Normal, Brushes.Black, Left, y);
            y += 25;

            g.DrawString("BILL DETAILS", Bold, Brushes.Black, Left + 140, y); y += 20;

            g.DrawString(new string('-', 55), Normal, Brushes.Black, Left, y); y += 20;

            // Billing Details...
            g.DrawString("Cashier Name : MEERA ", Normal, Brushes.Black, Left, y); y += 20;

            g.DrawString("Counter No : 14 ", Normal, Brushes.Black, Left, y); y += 20;

            string Bill_N0 = "DI-" + DateAndTime.Now.ToString("yyyyMMddHHmmss");
            g.DrawString("Bill No : " + Bill_N0, Normal, Brushes.Black, Left, y); y += 20;

            g.DrawString("Bill Date : " + DateAndTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), Normal, Brushes.Black, Left, y); y += 20;

            g.DrawString(new string('-', 55), Normal, Brushes.Black, Left, y); y += 20;

            // --------- items Detais header ------------ (Title only)
            g.DrawString("No  Item                     Qty      Price     Total", Bold, Brushes.Black, Left, y); y += 20;

            // items..
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                string Item_Row = $"{row.Cells[0].Value,-3} {row.Cells[1].Value,-22} {row.Cells[2].Value,5} {row.Cells[3].Value,9} {row.Cells[4].Value,10}";
                g.DrawString(Item_Row, Normal, Brushes.Black, Left, y); y += 20;
            }

            g.DrawString(new string('-', 55), Normal, Brushes.Black, Left, y); y += 20;

            // ===== AMOUNTS (LEFT ALIGNED) =====
            g.DrawString("Total Amount      : Rs. " + Total_Amount.ToString("0.00"), Normal, Brushes.Black, Left, y); y += 20;

            g.DrawString("Store Discount    : Rs. " + Discount_Amount.ToString("0.00"), Normal, Brushes.Black, Left, y); y += 20;

            g.DrawString("CGST (3.3%)       : Rs. " + cgst.ToString("0.00"), Normal, Brushes.Black, Left, y); y += 20;

            g.DrawString("SGST (2.5%)       : Rs. " + sgst.ToString("0.00"), Normal, Brushes.Black, Left, y); y += 20;

            g.DrawString(new string('-', 55), Normal, Brushes.Black, Left, y); y += 20;

            g.DrawString("Payable Amount    : Rs. " + Payable_Amount.ToString("0.00"), Bold, Brushes.Black, Left, y); y += 20;

            g.DrawString("YOU HAVE SAVED    : Rs. " + Discount_Amount.ToString("0.00"), Bold, Brushes.Black, Left + 90, y); y += 20;

            g.DrawString(new string('-', 55), Normal, Brushes.Black, Left, y); y += 20;

            // ---------- PAYMENT ----------
            if (rbCash.Checked)
            {
                g.DrawString("Payment Mode  : CASH", Normal, Brushes.Black, Left, y); y += 20;
                g.DrawString("Paid Amount   : Rs. " + txtPaidAmt.Text, Normal, Brushes.Black, Left, y); y += 20;
                g.DrawString(lblChange.Text.Replace("Change Returned :", "Change Return :"), Normal, Brushes.Black, Left, y);
            }
            else
            {
                g.DrawString("Payment Mode  : UPI", Normal, Brushes.Black, Left, y); y += 20;
                g.DrawString("Paid via UPI", Normal, Brushes.Black, Left, y);
            }

            y += 30;

            g.DrawString("Thank you for shopping with us :)", Bold, Brushes.Black, Left + 90, y);

            g.DrawString(new string('=', 55), Normal, Brushes.Black, Left, y + 20);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
