//Program1
//CIS-199-50
//Due 9/28/2023
//By: A1029
//The program calculates the total area that needs paint, the cost of paint, cost of coat, cost of labor, and total cost after asking the user for related information.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelLength_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void totalArea_Click(object sender, EventArgs e)
        {

        }
        //Triggers after clicking the calculate button
        private void calculateBut_Click(object sender, EventArgs e)
        {
            //declairs each variable as double because they will or may have decimals 
            double extra, //is the excess 10% appied
                width, //width of the room 
                length, //length of the room
                paintPrice, //price of the paint
                area, // the width * length of the room
                paintCost, //cost of the paint based on area
                coatsCost, //cost based on how many coats of paint are needed
                laborCost, //cost of workers based on work applied
                totalCost; //total cost of labor coats and paint

            int colors, //ammount of colors
                coats, //ammount of coats
                light; //if the user wants lighting or not based on 1 or 0

            //takes the data entered by the user and changes it to either a double or a int from the text box that they enter it in and definds a variable with that data.
            width = double.Parse(widthBox.Text);
            length = double.Parse(lengthBox.Text);
            colors = int.Parse(colorsBox.Text);
            paintPrice = double.Parse(paintBox.Text);
            coats = int.Parse(CoatsBox.Text);
            light = int.Parse(lightBox.Text);
            extra = 0.1;

            //completes the calulations to find the area and related costs.
            area = width * length;
            laborCost = light * 75 + area * 6.50;
            paintCost = (area * paintPrice) * (1+extra) + colors * 8.50;
            coatsCost = coats * 10;
            totalCost = laborCost + paintCost + coatsCost;

            //takes the values defined by the equations and prints them in text boxes as currency values.
            TotalArea.Text = $"{area:C}";
            PaintingCost.Text = $"{paintCost:C}";
            CoatsCost.Text = $"{coatsCost:C}";
            LaborCost.Text = $"{laborCost:C}";
            TotalCost.Text = $"{totalCost:C}";
        }
    }
}
