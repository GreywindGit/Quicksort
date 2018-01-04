namespace Quicksort
{
    partial class formQuickSort
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
            this.tbUnsorted = new System.Windows.Forms.TextBox();
            this.tbSorted = new System.Windows.Forms.TextBox();
            this.labUnsorted = new System.Windows.Forms.Label();
            this.labSorted = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUnsorted
            // 
            this.tbUnsorted.Location = new System.Drawing.Point(12, 86);
            this.tbUnsorted.Multiline = true;
            this.tbUnsorted.Name = "tbUnsorted";
            this.tbUnsorted.Size = new System.Drawing.Size(162, 400);
            this.tbUnsorted.TabIndex = 0;
            // 
            // tbSorted
            // 
            this.tbSorted.Location = new System.Drawing.Point(289, 86);
            this.tbSorted.Multiline = true;
            this.tbSorted.Name = "tbSorted";
            this.tbSorted.Size = new System.Drawing.Size(162, 400);
            this.tbSorted.TabIndex = 1;
            // 
            // labUnsorted
            // 
            this.labUnsorted.AutoSize = true;
            this.labUnsorted.Location = new System.Drawing.Point(12, 57);
            this.labUnsorted.Name = "labUnsorted";
            this.labUnsorted.Size = new System.Drawing.Size(82, 17);
            this.labUnsorted.TabIndex = 2;
            this.labUnsorted.Text = "Sortable list";
            // 
            // labSorted
            // 
            this.labSorted.AutoSize = true;
            this.labSorted.Location = new System.Drawing.Point(289, 56);
            this.labSorted.Name = "labSorted";
            this.labSorted.Size = new System.Drawing.Size(48, 17);
            this.labSorted.TabIndex = 3;
            this.labSorted.Text = "Result";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(171, 509);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(121, 45);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // formQuickSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 593);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.labSorted);
            this.Controls.Add(this.labUnsorted);
            this.Controls.Add(this.tbSorted);
            this.Controls.Add(this.tbUnsorted);
            this.Name = "formQuickSort";
            this.Text = "Quicksort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUnsorted;
        private System.Windows.Forms.TextBox tbSorted;
        private System.Windows.Forms.Label labUnsorted;
        private System.Windows.Forms.Label labSorted;
        private System.Windows.Forms.Button btnSort;
    }
}

