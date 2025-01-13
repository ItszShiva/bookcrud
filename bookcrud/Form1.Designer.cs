namespace bookcrud
{
    partial class print
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtti = new System.Windows.Forms.TextBox();
            this.txtau = new System.Windows.Forms.TextBox();
            this.txtpr = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.gv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(281, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "BOOK ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "BOOK ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "BOOK PRICE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "BOOK AUTHOR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "BOOK TITILE";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(353, 210);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(242, 22);
            this.txtid.TabIndex = 5;
            this.txtid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtti
            // 
            this.txtti.Location = new System.Drawing.Point(353, 260);
            this.txtti.Name = "txtti";
            this.txtti.Size = new System.Drawing.Size(242, 22);
            this.txtti.TabIndex = 6;
            this.txtti.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtau
            // 
            this.txtau.Location = new System.Drawing.Point(353, 331);
            this.txtau.Name = "txtau";
            this.txtau.Size = new System.Drawing.Size(242, 22);
            this.txtau.TabIndex = 7;
            // 
            // txtpr
            // 
            this.txtpr.Location = new System.Drawing.Point(353, 392);
            this.txtpr.Name = "txtpr";
            this.txtpr.Size = new System.Drawing.Size(242, 22);
            this.txtpr.TabIndex = 8;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.Blue;
            this.add.Location = new System.Drawing.Point(170, 467);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(127, 45);
            this.add.TabIndex = 9;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.Blue;
            this.update.Location = new System.Drawing.Point(323, 467);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(127, 45);
            this.update.TabIndex = 10;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.Red;
            this.delete.Location = new System.Drawing.Point(468, 467);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(127, 45);
            this.delete.TabIndex = 11;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // find
            // 
            this.find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find.ForeColor = System.Drawing.Color.Blue;
            this.find.Location = new System.Drawing.Point(626, 467);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(127, 45);
            this.find.TabIndex = 12;
            this.find.Text = "FIND";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Blue;
            this.button5.Location = new System.Drawing.Point(798, 467);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 45);
            this.button5.TabIndex = 13;
            this.button5.Text = "PRINT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // gv
            // 
            this.gv.BackgroundColor = System.Drawing.SystemColors.Info;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(626, 185);
            this.gv.Name = "gv";
            this.gv.RowHeadersWidth = 51;
            this.gv.RowTemplate.Height = 24;
            this.gv.Size = new System.Drawing.Size(333, 250);
            this.gv.TabIndex = 14;
            // 
            // print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 733);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.find);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.txtpr);
            this.Controls.Add(this.txtau);
            this.Controls.Add(this.txtti);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "print";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtti;
        private System.Windows.Forms.TextBox txtau;
        private System.Windows.Forms.TextBox txtpr;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView gv;
    }
}

