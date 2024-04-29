using DrillingRigs.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace DrillingRigs
{
    public partial class DrillingRigs_Form : Form
    {
        public DrillingRigs_Form() => InitializeComponent();

        private void ReActive(bool T)
        {
            DrillingRig1.Visible = T; label1.Visible = T; 
            DrillingRig2.Visible = T;label2.Visible = T;
            Picture.Visible = !T; Label_Text.Visible = !T;
            Back_Button.Visible = !T; Table.Visible = !T;
        }

        private void DrillingRig1_Click(object sender, EventArgs e)
        {
            Picture.BackgroundImage = DrillingRig1.BackgroundImage; Label_Text.Text = label1.Text;
            ReActive(false); TableFill_Stage1(label1.Text);
        }

        private void DrillingRig2_Click(object sender, EventArgs e)
        {
            Picture.BackgroundImage = DrillingRig2.BackgroundImage; Label_Text.Text = label2.Text;
            ReActive(false); TableFill_Stage1(label2.Text); 
        }

        private void Back_Button_Click(object sender, EventArgs e)
        { ReActive(true); Description.Visible = false; EXCEL.Quit(); }

        private Excel.Application EXCEL { get; set; }
        private Excel.Worksheet Sheet { get; set; }

        private void TableFill_Stage1(string SheetName)
        {
            EXCEL = new Excel.Application();
            //Excel.Workbook wkb = EXCEL.Workbooks.Open(@"C:\Users\leoni\Desktop\Новая папка (4)\3\БУ.xlsx");
            Excel.Workbook wkb = EXCEL.Workbooks.Open($@"{Application.StartupPath}\Resources\БУ.xlsx");
            Sheet = wkb.Sheets[SheetName] as Excel.Worksheet;
            Table.Controls.Clear(); Description.Visible = false;

            switch (SheetName)
            {
                case "Наземные буровые установки":
                    {
                        Excel.Range Ranged = Sheet.get_Range($"A:A"); int I1 = 0;
                        if (Ranged != null) foreach (Excel.Range RName in Ranged)
                            {
                                if (I1 != 0) if (RName.Text == "") break;
                                    else CreatePanel_Stage1(RName.Text, I1); I1++;
                            }
                    }
                    break;
                case "Передвижные буровые установки":
                    {
                        Excel.Range Ranged = Sheet.get_Range($"A:A"); int I1 = 0;
                        if (Ranged != null) foreach (Excel.Range RName in Ranged)
                            {
                                if (I1 != 0) if (RName.Text == "") break;
                                    else CreatePanel_Stage1(RName.Text, I1); I1++;
                            }
                    }
                    break;
            }

            Table.AutoScroll = false; Table.HorizontalScroll.Enabled = false; Table.HorizontalScroll.Visible = false;
            Table.AutoScroll = true;
        }

        private void TableFill_Stage2(object sender, EventArgs e)
        {
            var Element = (Label)sender; string[] Log = Element.Name.Split('_');
            Table.Controls.Clear(); Description.Visible = true;

            Excel.Range RangeHead = Sheet.get_Range($"A1:M1"); int I = 1;
            Excel.Range Ranged = Sheet.get_Range($"A{Convert.ToInt32(Log[1])+1}: M{Convert.ToInt32(Log[1])+1}");
            if (Ranged != null) foreach (Excel.Range RText in Ranged)
                    if (RText.Text != "-" & RText.Text != "")
                    {
                        if (I == 1)
                        {
                            Picture.BackgroundImage = Resources.ResourceManager.GetObject(RText.Text/*.Replace(' ', '_')*/);
                            Label_Text.Text = RText.Text;
                        }
                        if (I == 2) { Description.Text = RText.Text; }
                        if (I > 2) CreatePanel_Stage2(RangeHead[I].Text, RText.Text);

                        Table.AutoScroll = false; Table.HorizontalScroll.Enabled = false; 
                        Table.HorizontalScroll.Visible = false; Table.AutoScroll = true;  I++;
                    }
        }

        private void CreatePanel_Stage1(string Name, int Index)
        {
            Panel Main_Panel = new Panel
            {
                Name = $"RName_{Index}",
                Size = new Size(Table.Width - 23, 50),
                BorderStyle = BorderStyle.FixedSingle,
            };
            {
                // Наименование
                Label Named = new Label
                {
                    Name = $"RName_{Index}",
                    Text = Name,
                    AutoSize = false,
                    Size = new Size(Main_Panel.Width, Main_Panel.Height),
                    Font = new Font("Times New Roman", 18),
                    TextAlign = ContentAlignment.MiddleLeft
                };

                Named.Click += TableFill_Stage2; Main_Panel.Controls.Add(Named);
            }

            Table.Controls.Add(Main_Panel);
        }

        private void CreatePanel_Stage2(string HeadName, string Text)
        {
            Panel Main_Panel = new Panel
            {
                Size = new Size(Table.Width - 23, 100),
                BorderStyle = BorderStyle.FixedSingle,
            };
            {
                // Заголовок
                Label HeadNamed = new Label
                {
                    Text = HeadName,
                    AutoSize = false,
                    Size = new Size(Main_Panel.Width, Main_Panel.Height*2/3),
                    Font = new Font("Times New Roman", 14),
                    TextAlign = ContentAlignment.MiddleLeft
                };

                // Текст
                Label Named = new Label
                {
                    Text = "➤ "+Text,
                    AutoSize = false,
                    Size = new Size(Main_Panel.Width, Main_Panel.Height/3),
                    Font = new Font("Times New Roman", 14),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Top = Main_Panel.Height * 2 / 3
                };

                Main_Panel.Controls.Add(HeadNamed); Main_Panel.Controls.Add(Named);
            }

            Table.Controls.Add(Main_Panel);
        }
    }

    class Elements
    {
        public Control Control { get; private set; }
        public Size Size { get; private set; }
        public Point Location { get; private set; }

        public Elements(Control NewControl, Size NewSize, Point NewLocation)
        { Control = NewControl; Size = NewSize; Location = NewLocation; }

        public void ResetPosition()
        { Control.Size = Size; Control.Location = Location; Control.Visible = true; }

        public void SetPosition(Size NewSize, Point NewLocation, Control DeActivate)
        { Control.Size = NewSize; Control.Location = NewLocation; DeActivate.Visible = false; }
    }
}
