﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog
{
    public partial class StaticsForm : Form
    {
        public StaticsForm()
        {
            InitializeComponent();
        }

        Color panTotalColor;
        Color panMaleColor;
        Color panFemaleColor;

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void StaticsForm_Load(object sender, EventArgs e)
        {
            panTotalColor = panelTotal.BackColor;
            panMaleColor = panelMale.BackColor;
            panFemaleColor = panelFemale.BackColor;

            STUDENT student = new STUDENT();
            double totalStudents = Convert.ToDouble(student.totalStudent());
            double totalMaleStudents = Convert.ToDouble(student.totalMaleStudents());
            double totalFemaleStudents = Convert.ToDouble(student.totalFemaleStudents());

            double malePercentage = totalMaleStudents * 100 / totalStudents;
            double FemalePercentage = totalFemaleStudents * 100 / totalStudents;

            labelTotal.Text = "Total studenți: " + totalStudents.ToString();
            labelMale.Text = "Elevi: " + malePercentage.ToString("0.00")+"%";
            labelFemale.Text = "Eleve: " + FemalePercentage.ToString("0.00")+"%";


        }

        private void labelTotal_MouseEnter(object sender, EventArgs e)
        {
            panelTotal.BackColor = Color.White;
            labelTotal.ForeColor = panTotalColor;

        }

        private void labelTotal_MouseLeave(object sender, EventArgs e)
        {
            panelTotal.BackColor = panTotalColor; 
            labelTotal.ForeColor = Color.White;
        }

        private void labelMale_MouseEnter(object sender, EventArgs e)
        {
            panelMale.BackColor = Color.White;
            labelMale.ForeColor = panMaleColor;
        }

        private void labelMale_MouseLeave(object sender, EventArgs e)
        {
            panelMale.BackColor = panMaleColor;
            labelMale.ForeColor = Color.White;
        }

        private void labelFemale_MouseEnter(object sender, EventArgs e)
        {
            panelFemale.BackColor = Color.White;
            labelFemale.ForeColor = panFemaleColor;
        }

        private void labelFemale_MouseLeave(object sender, EventArgs e)
        {
            panelFemale.BackColor = panFemaleColor;
            labelFemale.ForeColor = Color.White;
        }
    }
}
