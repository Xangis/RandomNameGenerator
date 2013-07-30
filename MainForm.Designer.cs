namespace RandomNameGenerator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnOdd = new System.Windows.Forms.Button();
            this.btnStrange = new System.Windows.Forms.Button();
            this.name1 = new System.Windows.Forms.TextBox();
            this.name5 = new System.Windows.Forms.TextBox();
            this.name4 = new System.Windows.Forms.TextBox();
            this.name3 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.TextBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(7, 16);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(75, 26);
            this.btnNormal.TabIndex = 0;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnOdd
            // 
            this.btnOdd.Location = new System.Drawing.Point(88, 16);
            this.btnOdd.Name = "btnOdd";
            this.btnOdd.Size = new System.Drawing.Size(75, 26);
            this.btnOdd.TabIndex = 1;
            this.btnOdd.Text = "Odd";
            this.btnOdd.UseVisualStyleBackColor = true;
            this.btnOdd.Click += new System.EventHandler(this.btnOdd_Click);
            // 
            // btnStrange
            // 
            this.btnStrange.Location = new System.Drawing.Point(169, 16);
            this.btnStrange.Name = "btnStrange";
            this.btnStrange.Size = new System.Drawing.Size(75, 26);
            this.btnStrange.TabIndex = 2;
            this.btnStrange.Text = "Strange";
            this.btnStrange.UseVisualStyleBackColor = true;
            this.btnStrange.Click += new System.EventHandler(this.btnStrange_Click);
            // 
            // name1
            // 
            this.name1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name1.Location = new System.Drawing.Point(32, 62);
            this.name1.Name = "name1";
            this.name1.ReadOnly = true;
            this.name1.Size = new System.Drawing.Size(264, 19);
            this.name1.TabIndex = 23;
            this.name1.Text = "Click a button to generate names.";
            // 
            // name5
            // 
            this.name5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name5.Location = new System.Drawing.Point(32, 218);
            this.name5.Name = "name5";
            this.name5.ReadOnly = true;
            this.name5.Size = new System.Drawing.Size(264, 19);
            this.name5.TabIndex = 27;
            // 
            // name4
            // 
            this.name4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name4.Location = new System.Drawing.Point(32, 179);
            this.name4.Name = "name4";
            this.name4.ReadOnly = true;
            this.name4.Size = new System.Drawing.Size(264, 19);
            this.name4.TabIndex = 26;
            // 
            // name3
            // 
            this.name3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name3.Location = new System.Drawing.Point(32, 140);
            this.name3.Name = "name3";
            this.name3.ReadOnly = true;
            this.name3.Size = new System.Drawing.Size(264, 19);
            this.name3.TabIndex = 25;
            // 
            // name2
            // 
            this.name2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name2.Location = new System.Drawing.Point(32, 101);
            this.name2.Name = "name2";
            this.name2.ReadOnly = true;
            this.name2.Size = new System.Drawing.Size(264, 19);
            this.name2.TabIndex = 24;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(250, 16);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 26);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 290);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.name3);
            this.Controls.Add(this.name4);
            this.Controls.Add(this.name5);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.btnStrange);
            this.Controls.Add(this.btnOdd);
            this.Controls.Add(this.btnNormal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Random Name Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnOdd;
        private System.Windows.Forms.Button btnStrange;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.TextBox name5;
        private System.Windows.Forms.TextBox name4;
        private System.Windows.Forms.TextBox name3;
        private System.Windows.Forms.TextBox name2;
        private System.Windows.Forms.Button btnAbout;
    }
}

