
namespace TitlesAndTextUpdater.GUI
{
    partial class TextParametersPrompt
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
            this.fontColorCheckbox = new System.Windows.Forms.CheckBox();
            this.fontColorLabel = new System.Windows.Forms.Label();
            this.fontColorButton = new System.Windows.Forms.Button();
            this.fontColorDialog = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.fontColorTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.8273F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.1727F));
            this.tableLayoutPanel1.Controls.Add(this.fontColorCheckbox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fontColorLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(363, 42);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // fontColorCheckbox
            // 
            this.fontColorCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fontColorCheckbox.AutoSize = true;
            this.fontColorCheckbox.Location = new System.Drawing.Point(12, 14);
            this.fontColorCheckbox.Name = "fontColorCheckbox";
            this.fontColorCheckbox.Size = new System.Drawing.Size(15, 14);
            this.fontColorCheckbox.TabIndex = 9;
            this.fontColorCheckbox.UseVisualStyleBackColor = true;
            // 
            // fontColorLabel
            // 
            this.fontColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fontColorLabel.AutoSize = true;
            this.fontColorLabel.Location = new System.Drawing.Point(62, 14);
            this.fontColorLabel.Name = "fontColorLabel";
            this.fontColorLabel.Size = new System.Drawing.Size(31, 13);
            this.fontColorLabel.TabIndex = 10;
            this.fontColorLabel.Text = "Color";
            // 
            // fontColorButton
            // 
            this.fontColorButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fontColorButton.BackColor = System.Drawing.Color.Black;
            this.fontColorButton.Location = new System.Drawing.Point(3, 6);
            this.fontColorButton.Name = "fontColorButton";
            this.fontColorButton.Size = new System.Drawing.Size(64, 23);
            this.fontColorButton.TabIndex = 11;
            this.fontColorButton.UseVisualStyleBackColor = false;
            this.fontColorButton.Click += new System.EventHandler(this.fontColorButton_Click);
            // 
            // fontColorDialog
            // 
            this.fontColorDialog.AnyColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.30769F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.69231F));
            this.tableLayoutPanel2.Controls.Add(this.fontColorButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.fontColorTextBox, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(99, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(260, 36);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // fontColorTextBox
            // 
            this.fontColorTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fontColorTextBox.Location = new System.Drawing.Point(73, 8);
            this.fontColorTextBox.Name = "fontColorTextBox";
            this.fontColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.fontColorTextBox.TabIndex = 12;
            // 
            // TextParametersPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TextParametersPrompt";
            this.Text = "TextParametersPrompt";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox fontColorCheckbox;
        private System.Windows.Forms.Label fontColorLabel;
        private System.Windows.Forms.Button fontColorButton;
        private System.Windows.Forms.ColorDialog fontColorDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox fontColorTextBox;
    }
}