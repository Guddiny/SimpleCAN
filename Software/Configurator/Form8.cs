﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace USB_termo_2
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();


        }

        private void Form8_Load(object sender, EventArgs e) //Действия при загрузке формы 
        {
            Form1 main = this.Owner as Form1; // применяем стандартные значения из первой формы (Form1) для полей
            if (main != null)
            {
                textBox1.Text = main.Msg7_1;
                textBox2.Text = main.Msg7_2;
                textBox3.Text = main.Msg7_3;
                textBox4.Text = main.Msg7_4;
                textBox5.Text = main.Msg7_5;
                textBox6.Text = main.Msg7_6;
                textBox7.Text = main.Msg7_7;
                textBox8.Text = main.Msg7_8;
                textBox9.Text = main.Msg7_9;
                textBox10.Text = main.Msg7_10;
                textBox11.Text = main.Msg7_11;
                textBox12.Text = main.Msg7_12;
                textBox13.Text = main.Msg7_13;
                textBox14.Text = main.Msg7_14;
                textBox15.Text = main.Msg7_15;
                textBox16.Text = main.Msg7_16;
                textBox17.Text = main.Msg7_17;
                textBox18.Text = main.Msg7_18;
                textBox19.Text = main.Msg7_19;
                comboBox1.SelectedItem = main.Msg7_20;


            }
        }

        private void button2_Click(object sender, EventArgs e) // применяем новые значения для первой формы (Form1) из полей
        {
            Form1 main = this.Owner as Form1; // применяем новые значения для первой формы (Form1) из полей
            if (main != null)
            {
                main.Msg7_1 = textBox1.Text;
                main.Msg7_2 = textBox2.Text;
                main.Msg7_3 = textBox3.Text;
                main.Msg7_4 = textBox4.Text;
                main.Msg7_5 = textBox5.Text;
                main.Msg7_6 = textBox6.Text;
                main.Msg7_7 = textBox7.Text;
                main.Msg7_8 = textBox8.Text;
                main.Msg7_9 = textBox9.Text;
                main.Msg7_10 = textBox10.Text;
                main.Msg7_11 = textBox11.Text;
                main.Msg7_12 = textBox12.Text;
                main.Msg7_13 = textBox13.Text;
                main.Msg7_14 = textBox14.Text;
                main.Msg7_15 = textBox15.Text;
                main.Msg7_16 = textBox16.Text;
                main.Msg7_17 = textBox17.Text;
                main.Msg7_18 = textBox18.Text;
                main.Msg7_19 = textBox19.Text;
                main.Msg7_20 = (string)comboBox1.SelectedItem;
                main.comboBox10.SelectedItem = "2";
            }

            Close();
        }

        private void button1_Click(object sender, EventArgs e) // Сбрасываем значения полей к стандартным 
        {
            textBox1.Text = textBox2.Text = textBox3.Text =
                textBox4.Text = textBox5.Text = textBox6.Text =
                textBox7.Text = textBox8.Text = textBox9.Text =
                textBox11.Text = textBox12.Text = textBox13.Text =
                textBox14.Text = textBox15.Text = textBox16.Text =
                textBox17.Text = textBox18.Text = textBox19.Text = "0";
            textBox10.Text = "5"; //поле времени
            comboBox1.SelectedItem = "1"; // поле количества ячеек в посылке
        }

        private void button3_Click(object sender, EventArgs e) // Кнопка "Отмена"
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // Активация-деактивация текстбоксов
        {
            switch (Convert.ToInt16(comboBox1.SelectedItem))
            {
                case 1:
                    textBox2.Enabled = true; textBox12.Enabled = true;
                    textBox3.Enabled = false; textBox13.Enabled = false;
                    textBox4.Enabled = false; textBox14.Enabled = false;
                    textBox5.Enabled = false; textBox15.Enabled = false;
                    textBox6.Enabled = false; textBox16.Enabled = false;
                    textBox7.Enabled = false; textBox17.Enabled = false;
                    textBox8.Enabled = false; textBox18.Enabled = false;
                    textBox9.Enabled = false; textBox19.Enabled = false;
                    break;

                case 2:
                    textBox2.Enabled = true; textBox12.Enabled = true;
                    textBox3.Enabled = true; textBox13.Enabled = true;
                    textBox4.Enabled = false; textBox14.Enabled = false;
                    textBox5.Enabled = false; textBox15.Enabled = false;
                    textBox6.Enabled = false; textBox16.Enabled = false;
                    textBox7.Enabled = false; textBox17.Enabled = false;
                    textBox8.Enabled = false; textBox18.Enabled = false;
                    textBox9.Enabled = false; textBox19.Enabled = false;
                    break;
                case 3:
                    textBox2.Enabled = true; textBox12.Enabled = true;
                    textBox3.Enabled = true; textBox13.Enabled = true;
                    textBox4.Enabled = true; textBox14.Enabled = true;
                    textBox5.Enabled = false; textBox15.Enabled = false;
                    textBox6.Enabled = false; textBox16.Enabled = false;
                    textBox7.Enabled = false; textBox17.Enabled = false;
                    textBox8.Enabled = false; textBox18.Enabled = false;
                    textBox9.Enabled = false; textBox19.Enabled = false;
                    break;
                case 4:
                    textBox2.Enabled = true; textBox12.Enabled = true;
                    textBox3.Enabled = true; textBox13.Enabled = true;
                    textBox4.Enabled = true; textBox14.Enabled = true;
                    textBox5.Enabled = true; textBox15.Enabled = true;
                    textBox6.Enabled = false; textBox16.Enabled = false;
                    textBox7.Enabled = false; textBox17.Enabled = false;
                    textBox8.Enabled = false; textBox18.Enabled = false;
                    textBox9.Enabled = false; textBox19.Enabled = false;
                    break;
                case 5:
                    textBox2.Enabled = true; textBox12.Enabled = true;
                    textBox3.Enabled = true; textBox13.Enabled = true;
                    textBox4.Enabled = true; textBox14.Enabled = true;
                    textBox5.Enabled = true; textBox15.Enabled = true;
                    textBox6.Enabled = true; textBox16.Enabled = true;
                    textBox7.Enabled = false; textBox17.Enabled = false;
                    textBox8.Enabled = false; textBox18.Enabled = false;
                    textBox9.Enabled = false; textBox19.Enabled = false;
                    break;
                case 6:
                    textBox2.Enabled = true; textBox12.Enabled = true;
                    textBox3.Enabled = true; textBox13.Enabled = true;
                    textBox4.Enabled = true; textBox14.Enabled = true;
                    textBox5.Enabled = true; textBox15.Enabled = true;
                    textBox6.Enabled = true; textBox16.Enabled = true;
                    textBox7.Enabled = true; textBox17.Enabled = true;
                    textBox8.Enabled = false; textBox18.Enabled = false;
                    textBox9.Enabled = false; textBox19.Enabled = false;
                    break;
                case 7:
                    textBox2.Enabled = true; textBox12.Enabled = true;
                    textBox3.Enabled = true; textBox13.Enabled = true;
                    textBox4.Enabled = true; textBox14.Enabled = true;
                    textBox5.Enabled = true; textBox15.Enabled = true;
                    textBox6.Enabled = true; textBox16.Enabled = true;
                    textBox7.Enabled = true; textBox17.Enabled = true;
                    textBox8.Enabled = true; textBox18.Enabled = true;
                    textBox9.Enabled = false; textBox19.Enabled = false;
                    break;
                case 8:
                    textBox2.Enabled = true; textBox12.Enabled = true;
                    textBox3.Enabled = true; textBox13.Enabled = true;
                    textBox4.Enabled = true; textBox14.Enabled = true;
                    textBox5.Enabled = true; textBox15.Enabled = true;
                    textBox6.Enabled = true; textBox16.Enabled = true;
                    textBox7.Enabled = true; textBox17.Enabled = true;
                    textBox8.Enabled = true; textBox18.Enabled = true;
                    textBox9.Enabled = true; textBox19.Enabled = true;
                    break;
            }


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar <= 96 || e.KeyChar >= 103) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar <= 96 || e.KeyChar >= 103) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }



    }
}
