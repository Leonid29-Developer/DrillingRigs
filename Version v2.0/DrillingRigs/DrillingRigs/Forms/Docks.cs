using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using Excel = Microsoft.Office.Interop.Excel;
using Font = System.Drawing.Font;
using Label = System.Windows.Forms.Label;

namespace DrillingRigs
{
    public partial class Docks : Form
    {
        public Docks() => InitializeComponent();

        private void Docks_Load(object sender, EventArgs e)
        => OutData();

        /// <summary> Вывод всех докумнтов из каталога </summary>
        private void OutData()
        {
            try
            {
                Excel.Application EXCEL = new Excel.Application();
                Workbook wkb = EXCEL.Workbooks.Open
                    ($@"{Application.StartupPath}\Resources\БУ.xlsx", Type.Missing, true, Type.Missing, "LockEdit228");
                Worksheet Sheet = wkb.Sheets["Документы"] as Worksheet;
                TableData.Controls.Clear();

                Range RangeAll = Sheet.get_Range($"A:B");

                for (int I1 = 2; I1 <= RangeAll.Rows.Count; I1++)
                {
                    if (RangeAll[I1, 1].Text == "") break;

                    // Вывод конкретного документов
                    Panel MainPanel = new Panel()
                    {
                        Size = new Size(TableData.Width, 120),
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    {
                        // Код
                        Label Kod_Label = new Label()
                        {
                            Text = RangeAll[I1, 1].Text,
                            Font = new Font("Times New Roman", 14),
                            TextAlign = ContentAlignment.MiddleCenter,
                            AutoSize = false,
                            Size = new Size(120, MainPanel.Height),
                            BorderStyle = BorderStyle.FixedSingle,
                        };
                        MainPanel.Controls.Add(Kod_Label);

                        // Наименование 
                        Label Name_Label = new Label()
                        {
                            Text = RangeAll[I1, 2].Text,
                            Font = new Font("Times New Roman", 14),
                            TextAlign = ContentAlignment.MiddleLeft,
                            AutoSize = false,
                            Size = new Size(340, MainPanel.Height),
                            Left = Kod_Label.Width
                        };
                        MainPanel.Controls.Add(Name_Label);

                        // Кнопка "Открыть документ"
                        PictureBox Open_Button = new PictureBox()
                        {
                            Name = RangeAll[I1, 1].Text,
                            Size = new Size(60, 60),
                            BackgroundImageLayout = ImageLayout.Stretch,
                            BackgroundImage = Properties.Resources.StackOfPaper,
                            BorderStyle = BorderStyle.FixedSingle
                        };
                        {
                            Open_Button.Top = MainPanel.Height / 2 - Open_Button.Size.Height * 3 / 4;
                            Open_Button.Left = (Kod_Label.Width + Name_Label.Width) + (MainPanel.Width - (Kod_Label.Width + Name_Label.Width)) / 2 - Open_Button.Size.Width / 2;
                        }
                        Open_Button.Click += Button_Open_Click;
                        MainPanel.Controls.Add(Open_Button);

                        Label Open_Label = new Label()
                        {
                            Name = RangeAll[I1, 1].Text,
                            Text = "Открыть документ",
                            Font = new Font("Times New Roman", 10),
                            TextAlign = ContentAlignment.MiddleCenter,
                            AutoSize = false,
                            Size = new Size(120, 22)
                        };
                        {
                            Open_Label.Top = Open_Button.Top + Open_Button.Size.Height + 10;
                            Open_Label.Left = Open_Button.Left - (Open_Label.Size.Width - Open_Button.Width) / 2;
                        }
                        Open_Label.Click += Button_Open_Click;
                        MainPanel.Controls.Add(Open_Label);
                    }
                    TableData.Controls.Add(MainPanel);
                }

                EXCEL.Quit();
            }
            catch { }
        }

        private void Button_Open_Click(object sender, EventArgs e)
        {
            Control Button = (Control)sender;
            System.Diagnostics.Process.Start($@"{Application.StartupPath}\Documents\{Button.Name}.pdf");
        }

        // Назначаемые переменные из другой формы

        /// <summary> Имя документа  </summary>
        public static string DockName { set; private get; }

        /// <summary> Путь к PDF файлу </summary>
        public static string DockPath { set; private get; }

        private void DockAdd_Click(object sender, EventArgs e)
        {
            // Получение данных
            Excel.Application EXCEL = new Excel.Application(); //EXCEL.DisplayAlerts = true;
            Workbook Book = EXCEL.Workbooks.Open
                ($@"{Application.StartupPath}\Resources\БУ.xlsx", Type.Missing, false, Type.Missing,"LockEdit228");
            Worksheet Sheet = Book.Sheets["Документы"] as Worksheet;

            Range RangeAll = Sheet.get_Range($"A:A"); int IndexAdd = 0;
            List<string> KodList = new List<string>();
            for (int I1 = 2; I1 <= RangeAll.Rows.Count; I1++)
            {
                if (RangeAll[I1, 1].Text == "") { IndexAdd = I1; break; }
                KodList.Add(RangeAll[I1, 1].Text);
            }

            // Создание неповторяющегося кода
            int Kod = -1;
            while (Kod == -1)
            {
                Random Rand = new Random(); bool T = true;
                int Temp = Rand.Next(100000000, 999999999);
                foreach (string KodString in KodList)
                    if (KodString == Temp.ToString()) T = false;
                if (T) Kod = Temp;
            }

            // Регистрация нового документа
            if (new PDF_Register().ShowDialog() == DialogResult.OK)
            {
                File.Copy(DockPath, $@"{Application.StartupPath}\Documents\{Kod}.pdf");
                Sheet.Cells[IndexAdd, 1] = Kod; Sheet.Cells[IndexAdd, 2] = DockName;
                Book.Save(); EXCEL.Quit(); OutData();
            }
        }
    }
}