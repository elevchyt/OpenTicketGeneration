namespace TicketPrinter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.locationTb = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.exportBt = new System.Windows.Forms.Button();
            this.codeTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browseTb = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(104, 34);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(114, 20);
            this.nameTb.TabIndex = 2;
            this.toolTip1.SetToolTip(this.nameTb, "The name of the person who owns this ticket.");
            // 
            // locationTb
            // 
            this.locationTb.Location = new System.Drawing.Point(104, 86);
            this.locationTb.Name = "locationTb";
            this.locationTb.Size = new System.Drawing.Size(114, 20);
            this.locationTb.TabIndex = 3;
            this.toolTip1.SetToolTip(this.locationTb, "The location of the event/travel destination/etc of this ticket.");
            // 
            // dateBox
            // 
            this.dateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBox.Location = new System.Drawing.Point(104, 60);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(114, 20);
            this.dateBox.TabIndex = 4;
            this.dateBox.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // exportBt
            // 
            this.exportBt.Location = new System.Drawing.Point(251, 363);
            this.exportBt.Name = "exportBt";
            this.exportBt.Size = new System.Drawing.Size(105, 23);
            this.exportBt.TabIndex = 9;
            this.exportBt.Text = "EXPORT TICKET";
            this.toolTip1.SetToolTip(this.exportBt, "Generate the PDF for this ticket.");
            this.exportBt.UseVisualStyleBackColor = true;
            this.exportBt.Click += new System.EventHandler(this.ExportBt_Click);
            // 
            // codeTb
            // 
            this.codeTb.Location = new System.Drawing.Point(104, 112);
            this.codeTb.Name = "codeTb";
            this.codeTb.Size = new System.Drawing.Size(114, 20);
            this.codeTb.TabIndex = 11;
            this.toolTip1.SetToolTip(this.codeTb, "(Optional) Any discount or other special code goes here.");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "(Optional) Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Date:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(36, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // browseTb
            // 
            this.browseTb.Location = new System.Drawing.Point(50, 187);
            this.browseTb.Name = "browseTb";
            this.browseTb.Size = new System.Drawing.Size(89, 23);
            this.browseTb.TabIndex = 15;
            this.browseTb.Text = "BROWSE";
            this.toolTip1.SetToolTip(this.browseTb, "(Optional) Add an image as a ticket logo, if the image is bigger than 120x120 it " +
        "will be stretched to fit.");
            this.browseTb.UseVisualStyleBackColor = true;
            this.browseTb.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(61, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Logo Image";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(33, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "(JPG, PNG, GIF 120x120)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(92, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "OPEN TICKET GENERATION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(2, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "Developed by Eleftherios Hytiroglou";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 398);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.browseTb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.codeTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exportBt);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.locationTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Open Ticket Generation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox locationTb;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.Button exportBt;
        private System.Windows.Forms.TextBox codeTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button browseTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label8;
    }
}

