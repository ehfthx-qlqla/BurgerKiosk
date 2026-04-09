namespace BurgerKiosk
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
            lblAppName = new Label();
            lblMenu = new Label();
            rdoHamBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoChickenBurger = new RadioButton();
            picHamBurger = new PictureBox();
            picBulgogiBurger = new PictureBox();
            picChickenBurger = new PictureBox();
            chkPotato = new CheckBox();
            chkCola = new CheckBox();
            chkCheese = new CheckBox();
            chkSauce = new CheckBox();
            grpMenu = new GroupBox();
            lblExtraMenu = new Label();
            grpOption = new GroupBox();
            grpOrder = new GroupBox();
            lblTotalCost = new Label();
            lblOrder = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnInit = new Button();
            ((System.ComponentModel.ISupportInitialize)picHamBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).BeginInit();
            grpMenu.SuspendLayout();
            grpOption.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("한컴 말랑말랑 Bold", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(77, 54);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(569, 93);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "버거 주문 키오스크";
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("한컴 말랑말랑 Bold", 22F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblMenu.ForeColor = Color.IndianRed;
            lblMenu.Location = new Point(31, 27);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(187, 57);
            lblMenu.TabIndex = 3;
            lblMenu.Text = "메뉴 선택";
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AccessibleDescription = "rdoHamBurger";
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("한컴 말랑말랑 Regular", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoHamBurger.Location = new Point(31, 124);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(141, 50);
            rdoHamBurger.TabIndex = 0;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            rdoHamBurger.CheckedChanged += Menu_CheckedChanged;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("한컴 말랑말랑 Regular", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoBulgogiBurger.Location = new Point(31, 263);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(200, 50);
            rdoBulgogiBurger.TabIndex = 1;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            rdoBulgogiBurger.CheckedChanged += Menu_CheckedChanged;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("한컴 말랑말랑 Regular", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoChickenBurger.Location = new Point(31, 419);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(173, 50);
            rdoChickenBurger.TabIndex = 2;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            rdoChickenBurger.CheckedChanged += Menu_CheckedChanged;
            // 
            // picHamBurger
            // 
            picHamBurger.Image = Properties.Resources.goaqjrj;
            picHamBurger.Location = new Point(235, 96);
            picHamBurger.Name = "picHamBurger";
            picHamBurger.Size = new Size(173, 145);
            picHamBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picHamBurger.TabIndex = 5;
            picHamBurger.TabStop = false;
            // 
            // picBulgogiBurger
            // 
            picBulgogiBurger.Image = Properties.Resources.qnfrhrlqjrj1;
            picBulgogiBurger.Location = new Point(235, 236);
            picBulgogiBurger.Name = "picBulgogiBurger";
            picBulgogiBurger.Size = new Size(173, 150);
            picBulgogiBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picBulgogiBurger.TabIndex = 6;
            picBulgogiBurger.TabStop = false;
            // 
            // picChickenBurger
            // 
            picChickenBurger.Image = Properties.Resources.clzlsqjrj;
            picChickenBurger.Location = new Point(235, 381);
            picChickenBurger.Name = "picChickenBurger";
            picChickenBurger.Size = new Size(173, 154);
            picChickenBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picChickenBurger.TabIndex = 7;
            picChickenBurger.TabStop = false;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("한컴 말랑말랑 Regular", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkPotato.Location = new Point(31, 138);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(174, 50);
            chkPotato.TabIndex = 0;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            chkPotato.CheckedChanged += Menu_CheckedChanged;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("한컴 말랑말랑 Regular", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkCola.Location = new Point(31, 236);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(108, 50);
            chkCola.TabIndex = 1;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            chkCola.CheckedChanged += Menu_CheckedChanged;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("한컴 말랑말랑 Regular", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkCheese.Location = new Point(31, 336);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(181, 50);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            chkCheese.CheckedChanged += Menu_CheckedChanged;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("한컴 말랑말랑 Regular", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkSauce.Location = new Point(31, 432);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(179, 50);
            chkSauce.TabIndex = 3;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            chkSauce.CheckedChanged += Menu_CheckedChanged;
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(picHamBurger);
            grpMenu.Controls.Add(lblMenu);
            grpMenu.Controls.Add(picBulgogiBurger);
            grpMenu.Controls.Add(picChickenBurger);
            grpMenu.Controls.Add(rdoHamBurger);
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Location = new Point(77, 209);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(450, 543);
            grpMenu.TabIndex = 1;
            grpMenu.TabStop = false;
            // 
            // lblExtraMenu
            // 
            lblExtraMenu.AutoSize = true;
            lblExtraMenu.Font = new Font("한컴 말랑말랑 Bold", 22F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblExtraMenu.ForeColor = Color.IndianRed;
            lblExtraMenu.Location = new Point(18, 27);
            lblExtraMenu.Name = "lblExtraMenu";
            lblExtraMenu.Size = new Size(187, 57);
            lblExtraMenu.TabIndex = 8;
            lblExtraMenu.Text = "추가 옵션";
            // 
            // grpOption
            // 
            grpOption.Controls.Add(lblExtraMenu);
            grpOption.Controls.Add(chkPotato);
            grpOption.Controls.Add(chkCola);
            grpOption.Controls.Add(chkSauce);
            grpOption.Controls.Add(chkCheese);
            grpOption.Location = new Point(542, 209);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(236, 543);
            grpOption.TabIndex = 2;
            grpOption.TabStop = false;
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblTotalCost);
            grpOrder.Controls.Add(lblOrder);
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Location = new Point(857, 209);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(415, 440);
            grpOrder.TabIndex = 14;
            grpOrder.TabStop = false;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("한컴 말랑말랑 Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTotalCost.ForeColor = Color.CadetBlue;
            lblTotalCost.Location = new Point(29, 356);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(152, 46);
            lblTotalCost.TabIndex = 13;
            lblTotalCost.Text = "총 금액 : ";
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Font = new Font("한컴 말랑말랑 Bold", 22F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblOrder.ForeColor = Color.IndianRed;
            lblOrder.Location = new Point(29, 27);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(186, 57);
            lblOrder.TabIndex = 12;
            lblOrder.Text = "주문 내역";
            // 
            // lstOrder
            // 
            lstOrder.Font = new Font("한컴 말랑말랑 Bold", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(29, 117);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(310, 209);
            lstOrder.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.YellowGreen;
            btnOrder.Font = new Font("한컴 말랑말랑 Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOrder.Location = new Point(857, 677);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(185, 75);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnInit
            // 
            btnInit.BackColor = Color.IndianRed;
            btnInit.Font = new Font("한컴 말랑말랑 Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnInit.Location = new Point(1087, 677);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(185, 75);
            btnInit.TabIndex = 4;
            btnInit.Text = "초기화";
            btnInit.UseVisualStyleBackColor = false;
            btnInit.Click += btnInit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 818);
            Controls.Add(btnInit);
            Controls.Add(btnOrder);
            Controls.Add(grpOrder);
            Controls.Add(grpOption);
            Controls.Add(grpMenu);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            Load += Form1_Load;
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)picHamBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).EndInit();
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private Label lblMenu;
        private RadioButton rdoHamBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoChickenBurger;
        private PictureBox picHamBurger;
        private PictureBox picBulgogiBurger;
        private PictureBox picChickenBurger;
        private CheckBox chkPotato;
        private CheckBox chkCola;
        private CheckBox chkCheese;
        private CheckBox chkSauce;
        private GroupBox grpMenu;
        private Label lblExtraMenu;
        private GroupBox grpOption;
        private GroupBox grpOrder;
        private Label lblOrder;
        private ListBox lstOrder;
        private Button btnOrder;
        private Label lblTotalCost;
        private Button btnInit;
    }
}
