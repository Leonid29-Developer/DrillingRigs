namespace DrillingRigs
{
    partial class Docks
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
            this.DockAdd = new System.Windows.Forms.Label();
            this.TableData = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // DockAdd
            // 
            this.DockAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DockAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DockAdd.Location = new System.Drawing.Point(178, 524);
            this.DockAdd.Margin = new System.Windows.Forms.Padding(169, 0, 169, 0);
            this.DockAdd.Name = "DockAdd";
            this.DockAdd.Size = new System.Drawing.Size(263, 44);
            this.DockAdd.TabIndex = 0;
            this.DockAdd.Text = "Добавить новый документ";
            this.DockAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DockAdd.Click += new System.EventHandler(this.DockAdd_Click);
            // 
            // TableData
            // 
            this.TableData.ColumnCount = 1;
            this.TableData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableData.Location = new System.Drawing.Point(0, 0);
            this.TableData.Name = "TableData";
            this.TableData.RowCount = 1;
            this.TableData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableData.Size = new System.Drawing.Size(619, 579);
            this.TableData.TabIndex = 1;
            // 
            // Docks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 579);
            this.Controls.Add(this.DockAdd);
            this.Controls.Add(this.TableData);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Docks";
            this.Load += new System.EventHandler(this.Docks_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DockAdd;
        private System.Windows.Forms.TableLayoutPanel TableData;
    }
}