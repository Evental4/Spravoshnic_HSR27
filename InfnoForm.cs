﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spravoshnic_HSR
{
    public partial class InfnoForm : Form
    {
        Pers pers;
        public InfnoForm (Pers _pers)
        {
            InitializeComponent();

            pers = _pers;
            Text = pers.name;
            label1.Text = pers.name;
            HpLabel.Text = pers.Hp;
            DefLabel.Text = pers.Def;
            AtcLabel.Text = pers.Atc;
            SpidLabel.Text = pers.Spid;
            RancsLabel.Text = pers.Rancs_pop;

            pictureBox1.Load("../../Pictures/" + pers.name + ".png");


            rolelabel.Text = pers.role;
            tiplabel.Text = pers.tip;
            pytelabel.Text = pers.pyte;

            #region tip
            if (pers.tip == "Физический")
            {
                TippictureBox.Load("../../Pictures/Тип_урона_Физический.png");
            }
            if (pers.tip == "Ветреной")
            {
                TippictureBox.Load("../../Pictures/Тип_урона_Ветреной.png");
            }
            if (pers.tip == "Леденой")
            {
                TippictureBox.Load("../../Pictures/Тип_урона_Леденой.png");
            }
            if (pers.tip == "Мнимый")
            {
                TippictureBox.Load("../../Pictures/Тип_урона_Мнимый.png");
            }
            if (pers.tip == "Электрический")
            {
                TippictureBox.Load("../../Pictures/Тип_урона_Электрический.png");
            }
            if (pers.tip == "Огненый")
            {
                TippictureBox.Load("../../Pictures/Тип_урона_Огненый.png");
            }
            if (pers.tip == "Квантовый")
            {
                TippictureBox.Load("../../Pictures/Тип_урона_Квантовый.png");
            }
            #endregion

            #region pyte
            if (pers.pyte == "Разрушение")
            {
                PytepictureBox.Load("../../Pictures/Путь_Разрушение.png");
            }
            if (pers.pyte == "Небытие")
            {
                PytepictureBox.Load("../../Pictures/Путь_Небытие.png");
            }
            if (pers.pyte == "Гармония")
            {
                PytepictureBox.Load("../../Pictures/Путь_Гармония.png");
            }
            if (pers.pyte == "Сохранение")
            {
                PytepictureBox.Load("../../Pictures/Путь_Сохранение.png");
            }
            if (pers.pyte == "Охота")
            {
                PytepictureBox.Load("../../Pictures/Путь_Охота.png");
            }
            if (pers.pyte == "Эрудикция")
            {
                PytepictureBox.Load("../../Pictures/Путь_Эрудикция.png");
            }
            if (pers.pyte == "Изобилие")
            {
                PytepictureBox.Load("../../Pictures/Путь_Изобилие.png");
            }
            #endregion
            try
            {
                InfotextBox.Text = System.IO.File.ReadAllText("../../Pictures/" + pers.name + ".txt");
            }
            catch (Exception) { }
        }

        //добавление в изб
        private void AddSelectBTN_Click_1(object sender, EventArgs e)
        {
            if (SelectForm.my_pers_list.ContainsKey(pers))
            {
                SelectForm.my_pers_list[pers]++;
            }
            else
            {
                SelectForm.my_pers_list.Add(pers, 1);
            }
        }
        //переход на сайт
        private void label2_Click_1(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(pers.Web);
            }
            catch (Exception) { }

        }
    }
}

