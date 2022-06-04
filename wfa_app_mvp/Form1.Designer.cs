namespace wfa_app_mvp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_users_delete = new System.Windows.Forms.Button();
            this.btn_users_update = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_users_ID = new System.Windows.Forms.TextBox();
            this.com_users_vezife = new System.Windows.Forms.ComboBox();
            this.btn_users_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_users_yas = new System.Windows.Forms.TextBox();
            this.txt_users_soyad = new System.Windows.Forms.TextBox();
            this.txt_users_ad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(633, 263);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_users_delete);
            this.groupBox1.Controls.Add(this.btn_users_update);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_users_ID);
            this.groupBox1.Controls.Add(this.com_users_vezife);
            this.groupBox1.Controls.Add(this.btn_users_add);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_users_yas);
            this.groupBox1.Controls.Add(this.txt_users_soyad);
            this.groupBox1.Controls.Add(this.txt_users_ad);
            this.groupBox1.Location = new System.Drawing.Point(641, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert";
            // 
            // btn_users_delete
            // 
            this.btn_users_delete.Location = new System.Drawing.Point(297, 97);
            this.btn_users_delete.Name = "btn_users_delete";
            this.btn_users_delete.Size = new System.Drawing.Size(75, 26);
            this.btn_users_delete.TabIndex = 13;
            this.btn_users_delete.Text = "delete";
            this.btn_users_delete.UseVisualStyleBackColor = true;
            this.btn_users_delete.Click += new System.EventHandler(this.btn_users_delete_Click);
            // 
            // btn_users_update
            // 
            this.btn_users_update.Location = new System.Drawing.Point(297, 65);
            this.btn_users_update.Name = "btn_users_update";
            this.btn_users_update.Size = new System.Drawing.Size(75, 26);
            this.btn_users_update.TabIndex = 12;
            this.btn_users_update.Text = "Update";
            this.btn_users_update.UseVisualStyleBackColor = true;
            this.btn_users_update.Click += new System.EventHandler(this.btn_users_update_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID";
            // 
            // txt_users_ID
            // 
            this.txt_users_ID.Location = new System.Drawing.Point(57, 12);
            this.txt_users_ID.Name = "txt_users_ID";
            this.txt_users_ID.ReadOnly = true;
            this.txt_users_ID.Size = new System.Drawing.Size(137, 20);
            this.txt_users_ID.TabIndex = 10;
            // 
            // com_users_vezife
            // 
            this.com_users_vezife.FormattingEnabled = true;
            this.com_users_vezife.Location = new System.Drawing.Point(57, 122);
            this.com_users_vezife.Name = "com_users_vezife";
            this.com_users_vezife.Size = new System.Drawing.Size(137, 21);
            this.com_users_vezife.TabIndex = 9;
            this.com_users_vezife.SelectedIndexChanged += new System.EventHandler(this.com_users_vezife_SelectedIndexChanged);
            // 
            // btn_users_add
            // 
            this.btn_users_add.Location = new System.Drawing.Point(216, 65);
            this.btn_users_add.Name = "btn_users_add";
            this.btn_users_add.Size = new System.Drawing.Size(75, 26);
            this.btn_users_add.TabIndex = 0;
            this.btn_users_add.Text = "Insert";
            this.btn_users_add.UseVisualStyleBackColor = true;
            this.btn_users_add.Click += new System.EventHandler(this.btn_users_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "vezife";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "yas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ad";
            // 
            // txt_users_yas
            // 
            this.txt_users_yas.Location = new System.Drawing.Point(57, 90);
            this.txt_users_yas.Name = "txt_users_yas";
            this.txt_users_yas.Size = new System.Drawing.Size(137, 20);
            this.txt_users_yas.TabIndex = 3;
            // 
            // txt_users_soyad
            // 
            this.txt_users_soyad.Location = new System.Drawing.Point(57, 64);
            this.txt_users_soyad.Name = "txt_users_soyad";
            this.txt_users_soyad.Size = new System.Drawing.Size(137, 20);
            this.txt_users_soyad.TabIndex = 2;
            // 
            // txt_users_ad
            // 
            this.txt_users_ad.Location = new System.Drawing.Point(57, 38);
            this.txt_users_ad.Name = "txt_users_ad";
            this.txt_users_ad.Size = new System.Drawing.Size(137, 20);
            this.txt_users_ad.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 314);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_users_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_users_yas;
        private System.Windows.Forms.TextBox txt_users_soyad;
        private System.Windows.Forms.TextBox txt_users_ad;
        private System.Windows.Forms.ComboBox com_users_vezife;
        private System.Windows.Forms.Button btn_users_delete;
        private System.Windows.Forms.Button btn_users_update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_users_ID;
    }
}

