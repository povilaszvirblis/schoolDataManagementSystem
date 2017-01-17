namespace SchoolDataManagementSystem
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.studentsButton = new System.Windows.Forms.Button();
            this.teachersButton = new System.Windows.Forms.Button();
            this.lessonsButton = new System.Windows.Forms.Button();
            this.guardiansButton = new System.Windows.Forms.Button();
            this.coursesButton = new System.Windows.Forms.Button();
            this.evaluationsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.averageButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.hoursButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.studentsButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.teachersButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lessonsButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.guardiansButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.coursesButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.evaluationsButton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 211);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // studentsButton
            // 
            this.studentsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.studentsButton.Location = new System.Drawing.Point(3, 4);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(261, 23);
            this.studentsButton.TabIndex = 0;
            this.studentsButton.Text = "Mokiniai";
            this.studentsButton.UseVisualStyleBackColor = true;
            this.studentsButton.Click += new System.EventHandler(this.studentsButton_Click);
            // 
            // teachersButton
            // 
            this.teachersButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.teachersButton.Location = new System.Drawing.Point(3, 34);
            this.teachersButton.Name = "teachersButton";
            this.teachersButton.Size = new System.Drawing.Size(261, 23);
            this.teachersButton.TabIndex = 1;
            this.teachersButton.Text = "Mokytojai";
            this.teachersButton.UseVisualStyleBackColor = true;
            this.teachersButton.Click += new System.EventHandler(this.teachersButton_Click);
            // 
            // lessonsButton
            // 
            this.lessonsButton.AutoSize = true;
            this.lessonsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lessonsButton.Location = new System.Drawing.Point(3, 63);
            this.lessonsButton.Name = "lessonsButton";
            this.lessonsButton.Size = new System.Drawing.Size(261, 34);
            this.lessonsButton.TabIndex = 2;
            this.lessonsButton.Text = "Pamokos";
            this.lessonsButton.UseVisualStyleBackColor = true;
            this.lessonsButton.Click += new System.EventHandler(this.lessonsButton_Click);
            // 
            // guardiansButton
            // 
            this.guardiansButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guardiansButton.Location = new System.Drawing.Point(270, 4);
            this.guardiansButton.Name = "guardiansButton";
            this.guardiansButton.Size = new System.Drawing.Size(261, 23);
            this.guardiansButton.TabIndex = 3;
            this.guardiansButton.Text = "Globejai";
            this.guardiansButton.UseVisualStyleBackColor = true;
            this.guardiansButton.Click += new System.EventHandler(this.guardiansButton_Click);
            // 
            // coursesButton
            // 
            this.coursesButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.coursesButton.Location = new System.Drawing.Point(270, 34);
            this.coursesButton.Name = "coursesButton";
            this.coursesButton.Size = new System.Drawing.Size(261, 23);
            this.coursesButton.TabIndex = 4;
            this.coursesButton.Text = "Dalykai";
            this.coursesButton.UseVisualStyleBackColor = true;
            this.coursesButton.Click += new System.EventHandler(this.coursesButton_Click);
            // 
            // evaluationsButton
            // 
            this.evaluationsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.evaluationsButton.Location = new System.Drawing.Point(270, 63);
            this.evaluationsButton.Name = "evaluationsButton";
            this.evaluationsButton.Size = new System.Drawing.Size(261, 34);
            this.evaluationsButton.TabIndex = 5;
            this.evaluationsButton.Text = "Įvertinimai";
            this.evaluationsButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.averageButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(155, 211);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // averageButton
            // 
            this.averageButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.averageButton.Location = new System.Drawing.Point(3, 3);
            this.averageButton.Name = "averageButton";
            this.averageButton.Size = new System.Drawing.Size(149, 205);
            this.averageButton.TabIndex = 0;
            this.averageButton.Text = "Mokinių vidurkiai";
            this.averageButton.UseVisualStyleBackColor = true;
            this.averageButton.Click += new System.EventHandler(this.averageButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.hoursButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(379, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(155, 211);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // hoursButton
            // 
            this.hoursButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.hoursButton.Location = new System.Drawing.Point(3, 3);
            this.hoursButton.Name = "hoursButton";
            this.hoursButton.Size = new System.Drawing.Size(149, 205);
            this.hoursButton.TabIndex = 0;
            this.hoursButton.Text = "Mokinių darbo krūvis";
            this.hoursButton.UseVisualStyleBackColor = true;
            this.hoursButton.Click += new System.EventHandler(this.hoursButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(155, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(224, 211);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 211);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mokyklos duomenų bazė";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button studentsButton;
        private System.Windows.Forms.Button teachersButton;
        private System.Windows.Forms.Button lessonsButton;
        private System.Windows.Forms.Button guardiansButton;
        private System.Windows.Forms.Button coursesButton;
        private System.Windows.Forms.Button evaluationsButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button averageButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button hoursButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
    }
}

