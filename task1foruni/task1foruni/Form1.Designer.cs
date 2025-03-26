namespace task1foruni
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
            this.dataGridViewforshowdata = new System.Windows.Forms.DataGridView();
            this.dataGridViewforseeresult = new System.Windows.Forms.DataGridView();
            this.buttonSELECT = new System.Windows.Forms.Button();
            this.buttonUPDATE = new System.Windows.Forms.Button();
            this.buttonINSERT = new System.Windows.Forms.Button();
            this.buttonDELETE = new System.Windows.Forms.Button();
            this.numBookId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.txtPublishedYear = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewforshowdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewforseeresult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBookId)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewforshowdata
            // 
            this.dataGridViewforshowdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewforshowdata.Location = new System.Drawing.Point(412, 86);
            this.dataGridViewforshowdata.Name = "dataGridViewforshowdata";
            this.dataGridViewforshowdata.Size = new System.Drawing.Size(376, 228);
            this.dataGridViewforshowdata.TabIndex = 0;
            this.dataGridViewforshowdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewforshowdata_CellContentClick);
            // 
            // dataGridViewforseeresult
            // 
            this.dataGridViewforseeresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewforseeresult.Location = new System.Drawing.Point(714, 261);
            this.dataGridViewforseeresult.Name = "dataGridViewforseeresult";
            this.dataGridViewforseeresult.Size = new System.Drawing.Size(10, 10);
            this.dataGridViewforseeresult.TabIndex = 0;
            // 
            // buttonSELECT
            // 
            this.buttonSELECT.Location = new System.Drawing.Point(105, 305);
            this.buttonSELECT.Name = "buttonSELECT";
            this.buttonSELECT.Size = new System.Drawing.Size(98, 40);
            this.buttonSELECT.TabIndex = 1;
            this.buttonSELECT.Text = "SELECT";
            this.buttonSELECT.UseVisualStyleBackColor = true;
            this.buttonSELECT.Click += new System.EventHandler(this.buttonSELECT_Click);
            // 
            // buttonUPDATE
            // 
            this.buttonUPDATE.Location = new System.Drawing.Point(159, 16);
            this.buttonUPDATE.Name = "buttonUPDATE";
            this.buttonUPDATE.Size = new System.Drawing.Size(98, 40);
            this.buttonUPDATE.TabIndex = 1;
            this.buttonUPDATE.Text = "UPDATE";
            this.buttonUPDATE.UseVisualStyleBackColor = true;
            this.buttonUPDATE.Click += new System.EventHandler(this.buttonUPDATE_Click);
            // 
            // buttonINSERT
            // 
            this.buttonINSERT.Location = new System.Drawing.Point(105, 221);
            this.buttonINSERT.Name = "buttonINSERT";
            this.buttonINSERT.Size = new System.Drawing.Size(98, 40);
            this.buttonINSERT.TabIndex = 1;
            this.buttonINSERT.Text = "INSERT";
            this.buttonINSERT.UseVisualStyleBackColor = true;
            this.buttonINSERT.Click += new System.EventHandler(this.buttonINSERT_Click);
            // 
            // buttonDELETE
            // 
            this.buttonDELETE.Location = new System.Drawing.Point(159, 82);
            this.buttonDELETE.Name = "buttonDELETE";
            this.buttonDELETE.Size = new System.Drawing.Size(98, 40);
            this.buttonDELETE.TabIndex = 1;
            this.buttonDELETE.Text = "DELETE";
            this.buttonDELETE.UseVisualStyleBackColor = true;
            this.buttonDELETE.Click += new System.EventHandler(this.buttonDELETE_Click);
            // 
            // numBookId
            // 
            this.numBookId.Location = new System.Drawing.Point(445, 210);
            this.numBookId.Name = "numBookId";
            this.numBookId.Size = new System.Drawing.Size(120, 20);
            this.numBookId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(265, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "მონიშნეთ სასურველი სტრიქონი წაშლისთვის ან განახლებსთვის";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(618, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "data from sql";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(565, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 3;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(258, 175);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(120, 20);
            this.txtTitle.TabIndex = 4;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(258, 233);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(120, 20);
            this.txtAuthorName.TabIndex = 5;
            // 
            // txtPublishedYear
            // 
            this.txtPublishedYear.Location = new System.Drawing.Point(258, 294);
            this.txtPublishedYear.Name = "txtPublishedYear";
            this.txtPublishedYear.Size = new System.Drawing.Size(120, 20);
            this.txtPublishedYear.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(258, 358);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(120, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "for book title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "for author ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "for published year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "for price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtPublishedYear);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDELETE);
            this.Controls.Add(this.buttonINSERT);
            this.Controls.Add(this.buttonUPDATE);
            this.Controls.Add(this.buttonSELECT);
            this.Controls.Add(this.dataGridViewforshowdata);
            this.Controls.Add(this.dataGridViewforseeresult);
            this.Controls.Add(this.numBookId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewforshowdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewforseeresult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBookId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewforshowdata;
        private System.Windows.Forms.DataGridView dataGridViewforseeresult;
        private System.Windows.Forms.Button buttonSELECT;
        private System.Windows.Forms.Button buttonUPDATE;
        private System.Windows.Forms.Button buttonINSERT;
        private System.Windows.Forms.Button buttonDELETE;
        private System.Windows.Forms.NumericUpDown numBookId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtPublishedYear;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

