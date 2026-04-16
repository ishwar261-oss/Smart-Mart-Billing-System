namespace SmartMartBillingSystem
{
    partial class SmartMartBillingSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartMartBillingSystem));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblAddress = new Label();
            panel2 = new Panel();
            lblGSTIN = new Label();
            lblShopName = new Label();
            pnlCorner = new Panel();
            checkedListBox1 = new CheckedListBox();
            pnlItmEtry = new Panel();
            btnUpdate = new Button();
            btnAddItem = new Button();
            btnEdit = new Button();
            btnRemoveItm = new Button();
            txtPrice = new TextBox();
            lblPrice = new Label();
            ndeQty = new NumericUpDown();
            lblQty = new Label();
            txtItemName = new TextBox();
            lblItmName = new Label();
            pnlSumShow = new Panel();
            txtPaidAmt = new TextBox();
            PicQR = new PictureBox();
            lblUPI_ID = new Label();
            lblChange = new Label();
            lblPaidAmt = new Label();
            rcUPI = new RadioButton();
            label1 = new Label();
            rbCash = new RadioButton();
            panel4 = new Panel();
            lblSum_sgst = new Label();
            lblSum_cgst = new Label();
            lblSum_PayAmt = new Label();
            lblSum_StrDisc = new Label();
            panel3 = new Panel();
            lblSum_TotAmt = new Label();
            dgvItems = new DataGridView();
            pnlDgvTitle = new Panel();
            lblbilldtlTitle = new Label();
            pnlSummTitle = new Panel();
            lblbillsumTitle = new Label();
            pnlItmHeading = new Panel();
            lblItemetry = new Label();
            pnlbtm = new Panel();
            lblBtmToAmt = new Label();
            lblBtmToItm = new Label();
            btnNew_Bill = new Button();
            btnPrint_bill = new Button();
            btnExit = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            pnlItmEtry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ndeQty).BeginInit();
            pnlSumShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicQR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            pnlDgvTitle.SuspendLayout();
            pnlSummTitle.SuspendLayout();
            pnlItmHeading.SuspendLayout();
            pnlbtm.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(lblAddress);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblGSTIN);
            panel1.Controls.Add(lblShopName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1382, 140);
            panel1.TabIndex = 0;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(543, 105);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(290, 28);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Latur , Maharashtra - 413512";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Snow;
            panel2.Location = new Point(200, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 3);
            panel2.TabIndex = 2;
            // 
            // lblGSTIN
            // 
            lblGSTIN.AutoSize = true;
            lblGSTIN.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGSTIN.ForeColor = Color.Snow;
            lblGSTIN.Location = new Point(500, 67);
            lblGSTIN.Name = "lblGSTIN";
            lblGSTIN.Size = new Size(361, 38);
            lblGSTIN.TabIndex = 2;
            lblGSTIN.Text = "GSTIN : 33DIZ9145768IDZ";
            // 
            // lblShopName
            // 
            lblShopName.AutoSize = true;
            lblShopName.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShopName.ForeColor = Color.Snow;
            lblShopName.Location = new Point(261, -10);
            lblShopName.Name = "lblShopName";
            lblShopName.Size = new Size(877, 81);
            lblShopName.TabIndex = 1;
            lblShopName.Text = "SMART MART SUPERMARKET";
            lblShopName.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlCorner
            // 
            pnlCorner.BackColor = Color.SlateGray;
            pnlCorner.Location = new Point(0, 140);
            pnlCorner.Name = "pnlCorner";
            pnlCorner.Size = new Size(100, 850);
            pnlCorner.TabIndex = 7;
            pnlCorner.Paint += panel3_Paint_1;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(1296, 597);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(8, 4);
            checkedListBox1.TabIndex = 1;
            // 
            // pnlItmEtry
            // 
            pnlItmEtry.BackColor = SystemColors.GradientActiveCaption;
            pnlItmEtry.Controls.Add(btnUpdate);
            pnlItmEtry.Controls.Add(btnAddItem);
            pnlItmEtry.Controls.Add(btnEdit);
            pnlItmEtry.Controls.Add(btnRemoveItm);
            pnlItmEtry.Controls.Add(txtPrice);
            pnlItmEtry.Controls.Add(lblPrice);
            pnlItmEtry.Controls.Add(ndeQty);
            pnlItmEtry.Controls.Add(lblQty);
            pnlItmEtry.Controls.Add(txtItemName);
            pnlItmEtry.Controls.Add(lblItmName);
            pnlItmEtry.Location = new Point(115, 205);
            pnlItmEtry.Name = "pnlItmEtry";
            pnlItmEtry.Size = new Size(250, 500);
            pnlItmEtry.TabIndex = 2;
            pnlItmEtry.Paint += pnlItmEtry_Paint;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.GradientActiveCaption;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.DarkSlateGray;
            btnUpdate.Location = new Point(57, 453);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 33);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update Item";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += button4_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.AutoSize = true;
            btnAddItem.BackColor = Color.ForestGreen;
            btnAddItem.FlatStyle = FlatStyle.Popup;
            btnAddItem.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddItem.Location = new Point(37, 268);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(175, 50);
            btnAddItem.TabIndex = 8;
            btnAddItem.Text = "\U0001f6d2 ADD ITEM";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.GradientActiveCaption;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.DarkSlateGray;
            btnEdit.Location = new Point(57, 401);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(130, 33);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit Item";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRemoveItm
            // 
            btnRemoveItm.AutoSize = true;
            btnRemoveItm.BackColor = SystemColors.GradientActiveCaption;
            btnRemoveItm.FlatStyle = FlatStyle.Flat;
            btnRemoveItm.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveItm.ForeColor = Color.DarkSlateGray;
            btnRemoveItm.Location = new Point(57, 350);
            btnRemoveItm.Name = "btnRemoveItm";
            btnRemoveItm.Size = new Size(130, 35);
            btnRemoveItm.TabIndex = 6;
            btnRemoveItm.Text = "Remove Item";
            btnRemoveItm.UseVisualStyleBackColor = false;
            btnRemoveItm.Click += btnRemoveItm_Click;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.MenuBar;
            txtPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(20, 220);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(81, 27);
            txtPrice.TabIndex = 5;
            txtPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.Black;
            lblPrice.Location = new Point(20, 188);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(68, 28);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price : ";
            // 
            // ndeQty
            // 
            ndeQty.BackColor = SystemColors.MenuBar;
            ndeQty.Location = new Point(20, 135);
            ndeQty.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            ndeQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ndeQty.Name = "ndeQty";
            ndeQty.Size = new Size(102, 27);
            ndeQty.TabIndex = 3;
            ndeQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            ndeQty.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQty.ForeColor = Color.Black;
            lblQty.Location = new Point(20, 101);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(102, 28);
            lblQty.TabIndex = 2;
            lblQty.Text = "Quantity : ";
            // 
            // txtItemName
            // 
            txtItemName.BackColor = SystemColors.ButtonFace;
            txtItemName.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtItemName.Location = new Point(20, 50);
            txtItemName.Name = "txtItemName";
            txtItemName.PlaceholderText = "Enter Item Name..";
            txtItemName.Size = new Size(209, 30);
            txtItemName.TabIndex = 1;
            txtItemName.Tag = "";
            txtItemName.TextChanged += textBox1_TextChanged;
            // 
            // lblItmName
            // 
            lblItmName.AutoSize = true;
            lblItmName.BackColor = SystemColors.GradientActiveCaption;
            lblItmName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItmName.ForeColor = Color.Black;
            lblItmName.Location = new Point(20, 15);
            lblItmName.Name = "lblItmName";
            lblItmName.Size = new Size(122, 28);
            lblItmName.TabIndex = 0;
            lblItmName.Text = "Item Name : ";
            // 
            // pnlSumShow
            // 
            pnlSumShow.BackColor = SystemColors.ActiveCaption;
            pnlSumShow.Controls.Add(txtPaidAmt);
            pnlSumShow.Controls.Add(PicQR);
            pnlSumShow.Controls.Add(lblUPI_ID);
            pnlSumShow.Controls.Add(lblChange);
            pnlSumShow.Controls.Add(lblPaidAmt);
            pnlSumShow.Controls.Add(rcUPI);
            pnlSumShow.Controls.Add(label1);
            pnlSumShow.Controls.Add(rbCash);
            pnlSumShow.Controls.Add(panel4);
            pnlSumShow.Controls.Add(lblSum_sgst);
            pnlSumShow.Controls.Add(lblSum_cgst);
            pnlSumShow.Controls.Add(lblSum_PayAmt);
            pnlSumShow.Controls.Add(lblSum_StrDisc);
            pnlSumShow.Controls.Add(panel3);
            pnlSumShow.Controls.Add(lblSum_TotAmt);
            pnlSumShow.Location = new Point(1039, 205);
            pnlSumShow.Name = "pnlSumShow";
            pnlSumShow.Size = new Size(331, 500);
            pnlSumShow.TabIndex = 3;
            pnlSumShow.Paint += pnlSumShow_Paint;
            // 
            // txtPaidAmt
            // 
            txtPaidAmt.Location = new Point(145, 285);
            txtPaidAmt.Name = "txtPaidAmt";
            txtPaidAmt.Size = new Size(83, 27);
            txtPaidAmt.TabIndex = 12;
            txtPaidAmt.TextChanged += txtPaidAmt_TextChanged_1;
            // 
            // PicQR
            // 
            PicQR.BackgroundImage = (Image)resources.GetObject("PicQR.BackgroundImage");
            PicQR.Location = new Point(126, 367);
            PicQR.Name = "PicQR";
            PicQR.Size = new Size(102, 110);
            PicQR.TabIndex = 11;
            PicQR.TabStop = false;
            // 
            // lblUPI_ID
            // 
            lblUPI_ID.AutoSize = true;
            lblUPI_ID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUPI_ID.ForeColor = Color.Black;
            lblUPI_ID.Location = new Point(42, 318);
            lblUPI_ID.Name = "lblUPI_ID";
            lblUPI_ID.Size = new Size(249, 23);
            lblUPI_ID.TabIndex = 9;
            lblUPI_ID.Text = "UPI ID  : SmartMart5768@ybl";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChange.ForeColor = Color.Black;
            lblChange.Location = new Point(10, 341);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(203, 23);
            lblChange.TabIndex = 9;
            lblChange.Text = "Change Returned : ₹ 0.00";
            lblChange.Click += lblChange_Click;
            // 
            // lblPaidAmt
            // 
            lblPaidAmt.AutoSize = true;
            lblPaidAmt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaidAmt.ForeColor = Color.Black;
            lblPaidAmt.Location = new Point(10, 285);
            lblPaidAmt.Name = "lblPaidAmt";
            lblPaidAmt.Size = new Size(128, 23);
            lblPaidAmt.TabIndex = 9;
            lblPaidAmt.Text = "Paid Amount  : ";
            // 
            // rcUPI
            // 
            rcUPI.AutoSize = true;
            rcUPI.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rcUPI.ForeColor = Color.Black;
            rcUPI.Location = new Point(191, 240);
            rcUPI.Name = "rcUPI";
            rcUPI.Size = new Size(58, 27);
            rcUPI.TabIndex = 10;
            rcUPI.Text = "UPI";
            rcUPI.UseVisualStyleBackColor = true;
            rcUPI.CheckedChanged += rcUPI_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(5, 218);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 9;
            label1.Text = "Payment Mode  :";
            // 
            // rbCash
            // 
            rbCash.AutoSize = true;
            rbCash.Checked = true;
            rbCash.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbCash.ForeColor = Color.Black;
            rbCash.Location = new Point(191, 205);
            rbCash.Name = "rbCash";
            rbCash.Size = new Size(74, 27);
            rbCash.TabIndex = 9;
            rbCash.TabStop = true;
            rbCash.Text = "CASH";
            rbCash.UseVisualStyleBackColor = true;
            rbCash.CheckedChanged += rbCash_CheckedChanged;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Location = new Point(9, 190);
            panel4.Name = "panel4";
            panel4.Size = new Size(293, 3);
            panel4.TabIndex = 10;
            // 
            // lblSum_sgst
            // 
            lblSum_sgst.AutoSize = true;
            lblSum_sgst.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSum_sgst.Location = new Point(84, 115);
            lblSum_sgst.Name = "lblSum_sgst";
            lblSum_sgst.Size = new Size(196, 25);
            lblSum_sgst.TabIndex = 8;
            lblSum_sgst.Text = "SGST (2.5%) :    ₹ 0.00";
            lblSum_sgst.Click += lblSum_sgst_Click;
            // 
            // lblSum_cgst
            // 
            lblSum_cgst.AutoSize = true;
            lblSum_cgst.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSum_cgst.Location = new Point(84, 85);
            lblSum_cgst.Name = "lblSum_cgst";
            lblSum_cgst.Size = new Size(196, 25);
            lblSum_cgst.TabIndex = 9;
            lblSum_cgst.Text = "CGST (3.3%) :    ₹ 0.00";
            // 
            // lblSum_PayAmt
            // 
            lblSum_PayAmt.AutoSize = true;
            lblSum_PayAmt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSum_PayAmt.ForeColor = Color.DarkSlateGray;
            lblSum_PayAmt.Location = new Point(29, 157);
            lblSum_PayAmt.Name = "lblSum_PayAmt";
            lblSum_PayAmt.Size = new Size(262, 28);
            lblSum_PayAmt.TabIndex = 8;
            lblSum_PayAmt.Text = "Payable Amount :    ₹ 0.00";
            lblSum_PayAmt.Click += lblSum_PayAmt_Click;
            // 
            // lblSum_StrDisc
            // 
            lblSum_StrDisc.AutoSize = true;
            lblSum_StrDisc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSum_StrDisc.Location = new Point(19, 50);
            lblSum_StrDisc.Name = "lblSum_StrDisc";
            lblSum_StrDisc.Size = new Size(274, 28);
            lblSum_StrDisc.TabIndex = 8;
            lblSum_StrDisc.Text = "STORE DISCOUNT :    ₹ 0.00";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Location = new Point(9, 150);
            panel3.Name = "panel3";
            panel3.Size = new Size(293, 3);
            panel3.TabIndex = 8;
            // 
            // lblSum_TotAmt
            // 
            lblSum_TotAmt.AutoSize = true;
            lblSum_TotAmt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSum_TotAmt.Location = new Point(33, 16);
            lblSum_TotAmt.Name = "lblSum_TotAmt";
            lblSum_TotAmt.Size = new Size(262, 28);
            lblSum_TotAmt.TabIndex = 8;
            lblSum_TotAmt.Text = "TOTAL AMOUNT :    ₹ 0.00";
            // 
            // dgvItems
            // 
            dgvItems.BackgroundColor = SystemColors.ScrollBar;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvItems.DefaultCellStyle = dataGridViewCellStyle1;
            dgvItems.GridColor = Color.Silver;
            dgvItems.Location = new Point(370, 205);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 51;
            dgvItems.Size = new Size(665, 460);
            dgvItems.TabIndex = 5;
            dgvItems.CellContentClick += dgvItems_CellContentClick;
            // 
            // pnlDgvTitle
            // 
            pnlDgvTitle.BackColor = SystemColors.HotTrack;
            pnlDgvTitle.Controls.Add(lblbilldtlTitle);
            pnlDgvTitle.Location = new Point(370, 155);
            pnlDgvTitle.Name = "pnlDgvTitle";
            pnlDgvTitle.Size = new Size(665, 50);
            pnlDgvTitle.TabIndex = 6;
            // 
            // lblbilldtlTitle
            // 
            lblbilldtlTitle.AutoSize = true;
            lblbilldtlTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbilldtlTitle.ForeColor = Color.White;
            lblbilldtlTitle.Location = new Point(219, 0);
            lblbilldtlTitle.Name = "lblbilldtlTitle";
            lblbilldtlTitle.Size = new Size(240, 38);
            lblbilldtlTitle.TabIndex = 0;
            lblbilldtlTitle.Text = "BILLING DETAILS";
            lblbilldtlTitle.Click += lblbilldtlTitle_Click;
            // 
            // pnlSummTitle
            // 
            pnlSummTitle.BackColor = SystemColors.ActiveCaption;
            pnlSummTitle.Controls.Add(lblbillsumTitle);
            pnlSummTitle.Location = new Point(1039, 155);
            pnlSummTitle.Name = "pnlSummTitle";
            pnlSummTitle.Size = new Size(331, 50);
            pnlSummTitle.TabIndex = 0;
            // 
            // lblbillsumTitle
            // 
            lblbillsumTitle.AutoSize = true;
            lblbillsumTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbillsumTitle.ForeColor = Color.Black;
            lblbillsumTitle.Location = new Point(77, 5);
            lblbillsumTitle.Name = "lblbillsumTitle";
            lblbillsumTitle.Size = new Size(185, 31);
            lblbillsumTitle.TabIndex = 0;
            lblbillsumTitle.Text = "BILL SUMMARY";
            lblbillsumTitle.Click += lblbillsumTitle_Click;
            // 
            // pnlItmHeading
            // 
            pnlItmHeading.BackColor = SystemColors.GradientActiveCaption;
            pnlItmHeading.Controls.Add(lblItemetry);
            pnlItmHeading.Location = new Point(115, 155);
            pnlItmHeading.Name = "pnlItmHeading";
            pnlItmHeading.Size = new Size(250, 50);
            pnlItmHeading.TabIndex = 0;
            // 
            // lblItemetry
            // 
            lblItemetry.AutoSize = true;
            lblItemetry.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemetry.ForeColor = Color.Black;
            lblItemetry.Location = new Point(57, 5);
            lblItemetry.Name = "lblItemetry";
            lblItemetry.Size = new Size(146, 31);
            lblItemetry.TabIndex = 0;
            lblItemetry.Text = "ITEM ENTRY";
            // 
            // pnlbtm
            // 
            pnlbtm.BackColor = SystemColors.ActiveCaption;
            pnlbtm.Controls.Add(lblBtmToAmt);
            pnlbtm.Controls.Add(lblBtmToItm);
            pnlbtm.Location = new Point(370, 666);
            pnlbtm.Name = "pnlbtm";
            pnlbtm.Size = new Size(665, 39);
            pnlbtm.TabIndex = 8;
            // 
            // lblBtmToAmt
            // 
            lblBtmToAmt.AutoSize = true;
            lblBtmToAmt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBtmToAmt.Location = new Point(530, 5);
            lblBtmToAmt.Name = "lblBtmToAmt";
            lblBtmToAmt.Size = new Size(83, 28);
            lblBtmToAmt.TabIndex = 9;
            lblBtmToAmt.Text = " ₹  0.00";
            // 
            // lblBtmToItm
            // 
            lblBtmToItm.AutoSize = true;
            lblBtmToItm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBtmToItm.ForeColor = Color.White;
            lblBtmToItm.Location = new Point(15, 5);
            lblBtmToItm.Name = "lblBtmToItm";
            lblBtmToItm.Size = new Size(137, 28);
            lblBtmToItm.TabIndex = 9;
            lblBtmToItm.Text = "Total Item : 0";
            // 
            // btnNew_Bill
            // 
            btnNew_Bill.BackColor = SystemColors.HotTrack;
            btnNew_Bill.FlatStyle = FlatStyle.Popup;
            btnNew_Bill.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew_Bill.ForeColor = SystemColors.ControlLightLight;
            btnNew_Bill.Location = new Point(370, 735);
            btnNew_Bill.Name = "btnNew_Bill";
            btnNew_Bill.Size = new Size(180, 60);
            btnNew_Bill.TabIndex = 9;
            btnNew_Bill.Text = "📃 New Bill";
            btnNew_Bill.UseVisualStyleBackColor = false;
            btnNew_Bill.Click += btnNew_Bill_Click;
            // 
            // btnPrint_bill
            // 
            btnPrint_bill.BackColor = Color.DarkOrange;
            btnPrint_bill.FlatStyle = FlatStyle.Popup;
            btnPrint_bill.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint_bill.ForeColor = SystemColors.ButtonHighlight;
            btnPrint_bill.Location = new Point(613, 735);
            btnPrint_bill.Name = "btnPrint_bill";
            btnPrint_bill.Size = new Size(180, 60);
            btnPrint_bill.TabIndex = 10;
            btnPrint_bill.Text = "🖨️ Print Bill";
            btnPrint_bill.UseVisualStyleBackColor = false;
            btnPrint_bill.Click += btnPrint_bill_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Firebrick;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(860, 735);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(180, 60);
            btnExit.TabIndex = 12;
            btnExit.Text = "🚪 Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // SmartMartBillingSystem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1382, 803);
            Controls.Add(btnExit);
            Controls.Add(btnPrint_bill);
            Controls.Add(btnNew_Bill);
            Controls.Add(pnlbtm);
            Controls.Add(dgvItems);
            Controls.Add(pnlCorner);
            Controls.Add(pnlItmHeading);
            Controls.Add(pnlSummTitle);
            Controls.Add(pnlDgvTitle);
            Controls.Add(pnlSumShow);
            Controls.Add(pnlItmEtry);
            Controls.Add(checkedListBox1);
            Controls.Add(panel1);
            ForeColor = Color.Snow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SmartMartBillingSystem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Smart MartBilling System";
            Load += SmartMartBillingSystem_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlItmEtry.ResumeLayout(false);
            pnlItmEtry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ndeQty).EndInit();
            pnlSumShow.ResumeLayout(false);
            pnlSumShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicQR).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            pnlDgvTitle.ResumeLayout(false);
            pnlDgvTitle.PerformLayout();
            pnlSummTitle.ResumeLayout(false);
            pnlSummTitle.PerformLayout();
            pnlItmHeading.ResumeLayout(false);
            pnlItmHeading.PerformLayout();
            pnlbtm.ResumeLayout(false);
            pnlbtm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblShopName;
        private CheckedListBox checkedListBox1;
        private Label lblAddress;
        private Panel panel2;
        private Label lblGSTIN;
        private Panel pnlItmEtry;
        private Panel pnlSumShow;
        private DataGridView dgvItems;
        private Panel pnlDgvTitle;
        private Panel pnlSummTitle;
        private Panel pnlItmHeading;
        private Label lblItemetry;
        private Label lblbilldtlTitle;
        private Label lblbillsumTitle;
        private Label lblItmName;
        private TextBox txtItemName;
        private NumericUpDown ndeQty;
        private Label lblQty;
        private Label lblPrice;
        private TextBox txtPrice;
        private Button btnUpdate;
        private Button btnAddItem;
        private Button btnEdit;
        private Button btnRemoveItm;
        private Panel pnlCorner;
        private Label lblSum_TotAmt;
        private Panel panel3;
        private Label lblSum_StrDisc;
        private Label lblSum_sgst;
        private Label lblSum_cgst;
        private Label lblSum_PayAmt;
        private Panel pnlbtm;
        private Label lblBtmToAmt;
        private Label lblBtmToItm;
        private Panel panel4;
        private Label label1;
        private RadioButton rbCash;
        private RadioButton rcUPI;
        private Label lblPaidAmt;
        private Label lblChange;
        private Label lblUPI_ID;
        private PictureBox PicQR;
        private Button btnNew_Bill;
        private Button btnExit;
        private Button btnPrint_bill;
        private TextBox txtPaidAmt;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}
