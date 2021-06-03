
namespace MSSQL_exercise
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.db_Interface = new System.Windows.Forms.TabControl();
            this.InsertPage = new System.Windows.Forms.TabPage();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PlaceOfBdayLabel = new System.Windows.Forms.Label();
            this.BdayLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.BdayBox = new System.Windows.Forms.TextBox();
            this.BornPlaceBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.SelectPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.requestBox = new System.Windows.Forms.TextBox();
            this.db_Interface.SuspendLayout();
            this.InsertPage.SuspendLayout();
            this.SelectPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // db_Interface
            // 
            this.db_Interface.Controls.Add(this.InsertPage);
            this.db_Interface.Controls.Add(this.SelectPage);
            this.db_Interface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_Interface.Location = new System.Drawing.Point(0, 0);
            this.db_Interface.Name = "db_Interface";
            this.db_Interface.SelectedIndex = 0;
            this.db_Interface.Size = new System.Drawing.Size(408, 460);
            this.db_Interface.TabIndex = 0;
            // 
            // InsertPage
            // 
            this.InsertPage.BackColor = System.Drawing.Color.Linen;
            this.InsertPage.Controls.Add(this.InsertBtn);
            this.InsertPage.Controls.Add(this.EmailLabel);
            this.InsertPage.Controls.Add(this.PhoneLabel);
            this.InsertPage.Controls.Add(this.PlaceOfBdayLabel);
            this.InsertPage.Controls.Add(this.BdayLabel);
            this.InsertPage.Controls.Add(this.SurnameLabel);
            this.InsertPage.Controls.Add(this.NameLabel);
            this.InsertPage.Controls.Add(this.EmailBox);
            this.InsertPage.Controls.Add(this.NameBox);
            this.InsertPage.Controls.Add(this.BdayBox);
            this.InsertPage.Controls.Add(this.BornPlaceBox);
            this.InsertPage.Controls.Add(this.PhoneBox);
            this.InsertPage.Controls.Add(this.SurnameBox);
            this.InsertPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertPage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InsertPage.Location = new System.Drawing.Point(4, 25);
            this.InsertPage.Name = "InsertPage";
            this.InsertPage.Padding = new System.Windows.Forms.Padding(3);
            this.InsertPage.Size = new System.Drawing.Size(384, 421);
            this.InsertPage.TabIndex = 0;
            this.InsertPage.Text = "Insert Data";
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(79, 341);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(211, 72);
            this.InsertBtn.TabIndex = 12;
            this.InsertBtn.Text = "Insert This Data";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EmailLabel.Location = new System.Drawing.Point(61, 291);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(74, 29);
            this.EmailLabel.TabIndex = 11;
            this.EmailLabel.Text = "Email";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PhoneLabel.Location = new System.Drawing.Point(61, 242);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(83, 29);
            this.PhoneLabel.TabIndex = 10;
            this.PhoneLabel.Text = "Phone";
            // 
            // PlaceOfBdayLabel
            // 
            this.PlaceOfBdayLabel.AutoSize = true;
            this.PlaceOfBdayLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlaceOfBdayLabel.Location = new System.Drawing.Point(30, 188);
            this.PlaceOfBdayLabel.Name = "PlaceOfBdayLabel";
            this.PlaceOfBdayLabel.Size = new System.Drawing.Size(131, 29);
            this.PlaceOfBdayLabel.TabIndex = 9;
            this.PlaceOfBdayLabel.Text = "Born Place";
            // 
            // BdayLabel
            // 
            this.BdayLabel.AutoSize = true;
            this.BdayLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BdayLabel.Location = new System.Drawing.Point(61, 143);
            this.BdayLabel.Name = "BdayLabel";
            this.BdayLabel.Size = new System.Drawing.Size(100, 29);
            this.BdayLabel.TabIndex = 8;
            this.BdayLabel.Text = "Birthday";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SurnameLabel.Location = new System.Drawing.Point(61, 91);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(110, 29);
            this.SurnameLabel.TabIndex = 7;
            this.SurnameLabel.Text = "Surname";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameLabel.Location = new System.Drawing.Point(61, 37);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(78, 29);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(177, 291);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(152, 34);
            this.EmailBox.TabIndex = 5;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(177, 37);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(152, 34);
            this.NameBox.TabIndex = 4;
            // 
            // BdayBox
            // 
            this.BdayBox.Location = new System.Drawing.Point(177, 138);
            this.BdayBox.Name = "BdayBox";
            this.BdayBox.Size = new System.Drawing.Size(152, 34);
            this.BdayBox.TabIndex = 3;
            // 
            // BornPlaceBox
            // 
            this.BornPlaceBox.Location = new System.Drawing.Point(177, 188);
            this.BornPlaceBox.Name = "BornPlaceBox";
            this.BornPlaceBox.Size = new System.Drawing.Size(152, 34);
            this.BornPlaceBox.TabIndex = 2;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(177, 239);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(152, 34);
            this.PhoneBox.TabIndex = 1;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(177, 88);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(152, 34);
            this.SurnameBox.TabIndex = 0;
            // 
            // SelectPage
            // 
            this.SelectPage.Controls.Add(this.tableLayoutPanel1);
            this.SelectPage.Location = new System.Drawing.Point(4, 25);
            this.SelectPage.Name = "SelectPage";
            this.SelectPage.Padding = new System.Windows.Forms.Padding(3);
            this.SelectPage.Size = new System.Drawing.Size(400, 431);
            this.SelectPage.TabIndex = 1;
            this.SelectPage.Text = "Select Data";
            this.SelectPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.requestBox, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 425);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(3, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataView.Location = new System.Drawing.Point(3, 3);
            this.dataView.Name = "dataView";
            this.dataView.RowHeadersWidth = 51;
            this.dataView.RowTemplate.Height = 24;
            this.dataView.Size = new System.Drawing.Size(388, 291);
            this.dataView.TabIndex = 1;
            // 
            // requestBox
            // 
            this.requestBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.requestBox.Location = new System.Drawing.Point(3, 342);
            this.requestBox.Multiline = true;
            this.requestBox.Name = "requestBox";
            this.requestBox.Size = new System.Drawing.Size(388, 80);
            this.requestBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(408, 460);
            this.Controls.Add(this.db_Interface);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "DataBase Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.db_Interface.ResumeLayout(false);
            this.InsertPage.ResumeLayout(false);
            this.InsertPage.PerformLayout();
            this.SelectPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl db_Interface;
        private System.Windows.Forms.TabPage InsertPage;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label PlaceOfBdayLabel;
        private System.Windows.Forms.Label BdayLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox BdayBox;
        private System.Windows.Forms.TextBox BornPlaceBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TabPage SelectPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.TextBox requestBox;
    }
}