
namespace RamseyONLINE
{
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_close = new System.Windows.Forms.Button();
            this.button_again = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.08494F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.23556F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.59456F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.08494F));
            this.tableLayoutPanel1.Controls.Add(this.button_close, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_again, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_result, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.81651F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.72477F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.2142F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(366, 436);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_close
            // 
            this.button_close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.button_close, 2);
            this.button_close.Location = new System.Drawing.Point(39, 355);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(101, 51);
            this.button_close.TabIndex = 0;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_again
            // 
            this.button_again.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.button_again, 2);
            this.button_again.Location = new System.Drawing.Point(222, 355);
            this.button_again.Name = "button_again";
            this.button_again.Size = new System.Drawing.Size(101, 51);
            this.button_again.TabIndex = 1;
            this.button_again.Text = "Play again";
            this.button_again.UseVisualStyleBackColor = true;
            this.button_again.Click += new System.EventHandler(this.button_again_Click);
            // 
            // label_result
            // 
            this.label_result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_result.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_result, 4);
            this.label_result.Location = new System.Drawing.Point(157, 217);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(51, 20);
            this.label_result.TabIndex = 2;
            this.label_result.Text = "label1";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 436);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ResultForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_again;
        private System.Windows.Forms.Label label_result;
    }
}