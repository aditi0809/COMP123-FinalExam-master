﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
            Program.character.Firstname = textBox1.Text;
            Program.character.Lastname = LastNameTextBox.Text;


        }

        private void NextButton_Click(object sender, EventArgs e)
        {
           AbilityGeneratorForm Abilitygeneratorform = new AbilityGeneratorForm();
            Abilitygeneratorform.Show();
            this.Hide();
        }
    }
}
