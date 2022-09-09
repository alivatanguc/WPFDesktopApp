namespace WPFDesktopApp
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
            if(disposing && (components != null))
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
            this.BtnBrowswer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.UP = new System.Windows.Forms.Button();
            this.DOWN = new System.Windows.Forms.Button();
            this.EXPORTJSON = new System.Windows.Forms.Button();
            this.SAVE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 13;
            // 
            // BtnBrowswer
            // 
            this.BtnBrowswer.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnBrowswer.Location = new System.Drawing.Point(623, 41);
            this.BtnBrowswer.Name = "BtnBrowswer";
            this.BtnBrowswer.Size = new System.Drawing.Size(111, 38);
            this.BtnBrowswer.TabIndex = 2;
            this.BtnBrowswer.Text = "Browser";
            this.BtnBrowswer.UseVisualStyleBackColor = false;
            this.BtnBrowswer.Click += new System.EventHandler(this.BtnBrowswer_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(64, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(553, 20);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(13440, 957);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UP
            // 
            this.UP.BackColor = System.Drawing.Color.White;
            this.UP.Location = new System.Drawing.Point(650, 121);
            this.UP.Name = "UP";
            this.UP.Size = new System.Drawing.Size(64, 34);
            this.UP.TabIndex = 9;
            this.UP.Text = "UP";
            this.UP.UseVisualStyleBackColor = false;
            this.UP.Click += new System.EventHandler(this.UP_Click);
            // 
            // DOWN
            // 
            this.DOWN.BackColor = System.Drawing.Color.White;
            this.DOWN.Location = new System.Drawing.Point(650, 161);
            this.DOWN.Name = "DOWN";
            this.DOWN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DOWN.Size = new System.Drawing.Size(64, 38);
            this.DOWN.TabIndex = 10;
            this.DOWN.Text = "DOWN";
            this.DOWN.UseVisualStyleBackColor = false;
            this.DOWN.Click += new System.EventHandler(this.DOWN_Click);
            // 
            // EXPORTJSON
            // 
            this.EXPORTJSON.BackColor = System.Drawing.Color.LightCyan;
            this.EXPORTJSON.Location = new System.Drawing.Point(64, 121);
            this.EXPORTJSON.Name = "EXPORTJSON";
            this.EXPORTJSON.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EXPORTJSON.Size = new System.Drawing.Size(127, 37);
            this.EXPORTJSON.TabIndex = 11;
            this.EXPORTJSON.Text = "EXPORT TO JSON";
            this.EXPORTJSON.UseVisualStyleBackColor = false;
            this.EXPORTJSON.Click += new System.EventHandler(this.EXPORTJSON_Click);
            // 
            // SAVE
            // 
            this.SAVE.BackColor = System.Drawing.Color.LightCyan;
            this.SAVE.Location = new System.Drawing.Point(224, 121);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(91, 37);
            this.SAVE.TabIndex = 12;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = false;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1501, 659);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.EXPORTJSON);
            this.Controls.Add(this.DOWN);
            this.Controls.Add(this.UP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnBrowswer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "UploadTextApp";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBrowswer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button UP;
        private System.Windows.Forms.Button DOWN;
        private System.Windows.Forms.Button EXPORTJSON;
        private System.Windows.Forms.Button SAVE;
    }
}

