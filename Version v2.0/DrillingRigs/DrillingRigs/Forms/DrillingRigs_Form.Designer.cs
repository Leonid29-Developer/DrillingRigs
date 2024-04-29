namespace DrillingRigs
{
    partial class DrillingRigs_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrillingRigs_Form));
            this.DrillingRig1 = new System.Windows.Forms.PictureBox();
            this.DrillingRig2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.PictureBox();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.Description = new System.Windows.Forms.Label();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Label_Text = new System.Windows.Forms.Label();
            this.Button_Documents = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DrillingRig1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrillingRig2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // DrillingRig1
            // 
            this.DrillingRig1.BackgroundImage = global::DrillingRigs.Properties.Resources.Наземные_буровые_установки;
            this.DrillingRig1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DrillingRig1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DrillingRig1.Location = new System.Drawing.Point(39, 39);
            this.DrillingRig1.Margin = new System.Windows.Forms.Padding(30);
            this.DrillingRig1.Name = "DrillingRig1";
            this.DrillingRig1.Size = new System.Drawing.Size(300, 300);
            this.DrillingRig1.TabIndex = 0;
            this.DrillingRig1.TabStop = false;
            this.DrillingRig1.Click += new System.EventHandler(this.DrillingRig1_Click);
            // 
            // DrillingRig2
            // 
            this.DrillingRig2.BackgroundImage = global::DrillingRigs.Properties.Resources.Передвижные_буровые_установки;
            this.DrillingRig2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DrillingRig2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DrillingRig2.Location = new System.Drawing.Point(408, 39);
            this.DrillingRig2.Margin = new System.Windows.Forms.Padding(30);
            this.DrillingRig2.Name = "DrillingRig2";
            this.DrillingRig2.Size = new System.Drawing.Size(300, 300);
            this.DrillingRig2.TabIndex = 1;
            this.DrillingRig2.TabStop = false;
            this.DrillingRig2.Click += new System.EventHandler(this.DrillingRig2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.5F);
            this.label1.Location = new System.Drawing.Point(39, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Наземные буровые установки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.5F);
            this.label2.Location = new System.Drawing.Point(408, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Передвижные буровые установки";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Back_Button
            // 
            this.Back_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_Button.BackgroundImage")));
            this.Back_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back_Button.Location = new System.Drawing.Point(19, 458);
            this.Back_Button.Margin = new System.Windows.Forms.Padding(10);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(50, 50);
            this.Back_Button.TabIndex = 4;
            this.Back_Button.TabStop = false;
            this.Back_Button.Visible = false;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Table
            // 
            this.Table.ColumnCount = 1;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Table.Location = new System.Drawing.Point(320, 104);
            this.Table.Margin = new System.Windows.Forms.Padding(10);
            this.Table.Name = "Table";
            this.Table.RowCount = 1;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table.Size = new System.Drawing.Size(408, 404);
            this.Table.TabIndex = 5;
            this.Table.Visible = false;
            // 
            // Description
            // 
            this.Description.AutoEllipsis = true;
            this.Description.Font = new System.Drawing.Font("Times New Roman", 13.5F);
            this.Description.Location = new System.Drawing.Point(316, 25);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(412, 85);
            this.Description.TabIndex = 6;
            this.Description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Description.Visible = false;
            // 
            // Picture
            // 
            this.Picture.BackgroundImage = global::DrillingRigs.Properties.Resources.Наземные_буровые_установки;
            this.Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Picture.Location = new System.Drawing.Point(25, 25);
            this.Picture.Margin = new System.Windows.Forms.Padding(30);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(275, 275);
            this.Picture.TabIndex = 7;
            this.Picture.TabStop = false;
            this.Picture.Visible = false;
            // 
            // Label_Text
            // 
            this.Label_Text.Font = new System.Drawing.Font("Times New Roman", 13.5F);
            this.Label_Text.Location = new System.Drawing.Point(25, 312);
            this.Label_Text.Name = "Label_Text";
            this.Label_Text.Size = new System.Drawing.Size(275, 35);
            this.Label_Text.TabIndex = 8;
            this.Label_Text.Text = "Наземные буровые установки";
            this.Label_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Text.Visible = false;
            // 
            // Button_Documents
            // 
            this.Button_Documents.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_Documents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Button_Documents.Font = new System.Drawing.Font("Times New Roman", 13.5F);
            this.Button_Documents.Location = new System.Drawing.Point(249, 458);
            this.Button_Documents.Margin = new System.Windows.Forms.Padding(240, 0, 240, 0);
            this.Button_Documents.Name = "Button_Documents";
            this.Button_Documents.Size = new System.Drawing.Size(249, 50);
            this.Button_Documents.TabIndex = 9;
            this.Button_Documents.Text = "Каталог документов";
            this.Button_Documents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Documents.Click += new System.EventHandler(this.Button_Documents_Click);
            // 
            // DrillingRigs_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 527);
            this.Controls.Add(this.Button_Documents);
            this.Controls.Add(this.Label_Text);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrillingRig2);
            this.Controls.Add(this.DrillingRig1);
            this.Name = "DrillingRigs_Form";
            ((System.ComponentModel.ISupportInitialize)(this.DrillingRig1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrillingRig2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DrillingRig1;
        private System.Windows.Forms.PictureBox DrillingRig2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Back_Button;
        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Label Label_Text;
        private System.Windows.Forms.Label Button_Documents;
    }
}

