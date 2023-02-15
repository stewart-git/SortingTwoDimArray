namespace SortingArray
{
    partial class DataTableForm
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
            this.ButtonFill = new System.Windows.Forms.Button();
            this.ListViewDisplay = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonFill
            // 
            this.ButtonFill.Location = new System.Drawing.Point(12, 12);
            this.ButtonFill.Name = "ButtonFill";
            this.ButtonFill.Size = new System.Drawing.Size(75, 23);
            this.ButtonFill.TabIndex = 0;
            this.ButtonFill.Text = "Fill Table";
            this.ButtonFill.UseVisualStyleBackColor = true;
            this.ButtonFill.Click += new System.EventHandler(this.ButtonFill_Click);
            // 
            // ListViewDisplay
            // 
            this.ListViewDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ListViewDisplay.Location = new System.Drawing.Point(12, 41);
            this.ListViewDisplay.Name = "ListViewDisplay";
            this.ListViewDisplay.Size = new System.Drawing.Size(307, 397);
            this.ListViewDisplay.TabIndex = 1;
            this.ListViewDisplay.UseCompatibleStateImageBehavior = false;
            this.ListViewDisplay.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Col_1";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Col_2";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Col_3";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Col_4r";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Col_5";
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(93, 12);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(75, 23);
            this.ButtonSort.TabIndex = 2;
            this.ButtonSort.Text = "Sort";
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // DataTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 450);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.ListViewDisplay);
            this.Controls.Add(this.ButtonFill);
            this.Name = "DataTableForm";
            this.Text = "Data Tables";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ButtonFill;
        private ListView ListViewDisplay;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button ButtonSort;
    }
}