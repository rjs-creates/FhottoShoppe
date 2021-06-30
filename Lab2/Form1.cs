//*********************************************************************
//Program: Lab2.Form1  – Photo Editor with special effects
//Description: Creating a photo editor which loads and peforms different effects on a picture
//Date: Feb. 13/2020
//Author: Rajeshwar Singh(r25)
//Course: CMPE1600
//Class: A03
//Instructor: Kevin Moore
//***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        string _sFileName = "";            //FileName of the image
        Color _oldPixel;                   //Old Color of individual pixel
        Color _newPixel;                   //New Color of individual pixel
        int[] RGB = new int[3];            //Array of red,green and blue components of a pixel

        public Form1()
        {
            InitializeComponent();
        }
        //*********************************************************************
        //Method: public void LabelChange()
        //Purpose: To Change the labels for the trackbar depending on checked radiobuttons
        //Parameters:No parameters
        //Returns: void
        //*********************************************************************
        public void LabelChange()
        {
            //if radio button for contrast was checked
            if (radioButtonContrast.Checked)
            {
                //Changing slider position to 0
                trackBarRGB.Value = 0;

                //3 labels for trackbars
                label1.Text = "Less";
                label3.Text = "More";
                label2.Text = Convert.ToString(trackBarRGB.Value);      
            }

            //if radio button for Tint was checked
            else if (radioButtonTint.Checked)
            {
                //Changing slider position to 50
                trackBarRGB.Value = 50;

                //3 labels for trackbars
                label1.Text = "Red";
                label2.Text = Convert.ToString(50 - trackBarRGB.Value);
                label3.Text = "Green";             
            }

            //if radio button for Noise or B&W was checked
            else
            {
                //Changing slider position to 0
                trackBarRGB.Value = 0;

                //3 labels for trackbars
                label1.Text = "Less";
                label2.Text = Convert.ToString(trackBarRGB.Value);
                label3.Text = "More";
            }
        }

        //*********************************************************************
        //Method: public void Contrast()
        //Purpose: To change contrast of evey single pixel of an image
        //Parameters:No parameters
        //Returns: void
        //*********************************************************************
        public void Contrast()
        {
            //Bitmap intialization for the image in picturebox
            Bitmap bm = new Bitmap(pictureBoxEditor.Image);

            //loop for every column
            for (int i = 0; i < bm.Width; i++)
            {
                //Loop for every pixel
                for (int j = 0; j < bm.Height; j++)
                {
                    //Old Color of the selected pixel
                    _oldPixel = bm.GetPixel(i, j);

                    //Entering the Red,Green and blue component to the color array
                    RGB[0] = _oldPixel.R;
                    RGB[1] = _oldPixel.G;
                    RGB[2] = _oldPixel.B;

                    //Changing Red,blue and green component
                    for(int b = 0; b < 3; b++)
                    {
                        //if the color component is greater than 128
                        if(RGB[b] > 128)
                        {
                           //Adding 1/ 5 of trackbar value
                           RGB[b] += Convert.ToInt32(trackBarRGB.Value / 5.0);
                        }
                        else
                        {
                            //Subtracting 1/ 5 of trackbar value
                            RGB[b] -= Convert.ToInt32(trackBarRGB.Value / 5.0);
                        }

                        //If the component is bigger than 255
                        //Limit the value to 255
                        if (RGB[b] > 255)
                            RGB[b] = 255;

                        //If the component is smaller than 0
                        //Limit the value to 0
                        if (RGB[b] < 0)
                            RGB[b] = 0;
                    }

                    //New color of the pixel
                    _newPixel = Color.FromArgb(RGB[0], RGB[1], RGB[2]);

                    //setting the color to pixel
                    bm.SetPixel(i, j, _newPixel);
                }
                //Incrementing the progress bar after every single column of pixels are done
                progressBar1.Value = (int)((i / (double)(bm.Width-1) * 100));
            }
            //Changing to default after completion
            progressBar1.Value = 0;

            //Changing the image
            pictureBoxEditor.Image = bm;
        }

        //*********************************************************************
        //Method: public void BlackWhite()
        //Purpose: To change every single pixel component to a close average and those turn it black or white
        //Parameters:No parameters
        //Returns: void
        //*********************************************************************
        public void BlackWhite()
        {
            //Bitmap intialization for the image in picturebox
            Bitmap bm = new Bitmap(pictureBoxEditor.Image);

            double average;               //Average value for the red,blue and green component
            double trackbarValue;         //Trackbar value

            //Manipulating the trackbar value to suit calcultaion
            trackbarValue = trackBarRGB.Value / 100.0;

            //loop for every column
            for (int i = 0; i < bm.Width; i++)
            {
                //Loop for every pixel
                for (int j = 0; j < bm.Height; j++)
                {
                    //Old Color of the pixel selected pixel
                    _oldPixel = bm.GetPixel(i, j);

                    //Entering the Red,Green and blue component to the color array
                    RGB[0] = _oldPixel.R;
                    RGB[1] = _oldPixel.G;
                    RGB[2] = _oldPixel.B;

                    //Calculating the average for every pixel
                    average =(int) ((double)(RGB[0] + RGB[1] + RGB[2]) / 3);

                    //Changing Red,blue and green component
                    for (int b = 0; b < 3; b++)
                    {
                        //Changing the value of each component so it gets closer to the average
                        RGB[b] += (int) ((average - RGB[b]) * trackbarValue);

                        //If the component is bigger than 255
                        //Limit the value to 255
                        if (RGB[b] > 255)
                            RGB[b] = 255;

                        //If the component is smaller than 0
                        //Limit the value to 0
                        if (RGB[b] < 0)
                            RGB[b] = 0;
                    }

                    //New color of the pixel
                    _newPixel = Color.FromArgb(RGB[0], RGB[1], RGB[2]);

                    //setting the color to pixel
                    bm.SetPixel(i, j, _newPixel);
                }
                //Incrementing the progress bar after every single column of pixels are done
                progressBar1.Value = (int)((i / (double)(bm.Width - 1) * 100));
            }

            //Changing to default after completion
            progressBar1.Value = 0;

            //Changing the image
            pictureBoxEditor.Image = bm;
        }

        //*********************************************************************
        //Method: public void Tint()
        //Purpose: To add a tint of red or green to every single pixel of the image
        //Parameters:No parameters
        //Returns: void
        //*********************************************************************
        public void Tint()
        {
            //Bitmap intialization for the image in picturebox
            Bitmap bm = new Bitmap(pictureBoxEditor.Image);

            int trackbarValue;             //Trackbar value      

            //Trackbar Value
            trackbarValue = trackBarRGB.Value;

            //loop for every column
            for (int i = 0; i < bm.Width; i++)
            {
                //Loop for every pixel
                for (int j = 0; j < bm.Height; j++)
                {
                    //Old Color of the pixel selected pixel
                    _oldPixel = bm.GetPixel(i, j);

                    //Entering the Red,Green and blue component to the color array
                    RGB[0] = _oldPixel.R;
                    RGB[1] = _oldPixel.G;
                    RGB[2] = _oldPixel.B;

                    //Adding to green component if trackbar value is greater than 50
                    if (trackbarValue > 50)
                    {
                        //Adding to green
                        RGB[1] += (trackbarValue-50);
                    }
                    //Adding to Red component if trackbar value is less than 50
                    else
                    {
                        //Adding to Red
                        RGB[0] += (50 - trackbarValue);
                    }

                    //Changing Red,blue and green component
                    for (int b = 0; b < 3; b++)
                    {
                        //If the component is bigger than 255
                        //Limit the value to 255
                        if (RGB[b] > 255)
                            RGB[b] = 255;

                        //If the component is smaller than 0
                        //Limit the value to 0
                        if (RGB[b] < 0)
                            RGB[b] = 0;
                    }

                    //New color of the pixel
                    _newPixel = Color.FromArgb(RGB[0], RGB[1], RGB[2]);

                    //setting the color to pixel
                    bm.SetPixel(i, j, _newPixel);
                }
                //Incrementing the progress bar after every single column of pixels are done
                progressBar1.Value = (int)((i / (double)(bm.Width - 1) * 100));
            }
            //Changing to default after completion
            progressBar1.Value = 0;

            //Changing the image
            pictureBoxEditor.Image = bm;       
        }

        //*********************************************************************
        //Method: public void Noise()
        //Purpose: To add noise to an image by adding or subtracting from each color component
        //Parameters:No parameters
        //Returns: void
        //*********************************************************************
        public void Noise()
        {
            //Bitmap intialization for the image in picturebox
            Bitmap bm = new Bitmap(pictureBoxEditor.Image);

            //Random number generator
            Random rng = new Random(); ;

            int trackbarValue;                  //The value from the trackbar

            //Setting the value for trackbar
            trackbarValue = trackBarRGB.Value;

            //loop for every column
            for (int i = 0; i < bm.Width; i++)
            {
                //Loop for every pixel
                for (int j = 0; j < bm.Height; j++)
                {
                    //Old Color of the pixel selected pixel
                    _oldPixel = bm.GetPixel(i, j);

                    //Entering the Red,Green and blue component to the color array
                    RGB[0] = _oldPixel.R;
                    RGB[1] = _oldPixel.G;
                    RGB[2] = _oldPixel.B;

                    //Changing Red,blue and green component
                    for (int b = 0; b < 3; b++)
                    {
                        //Add random value to color between the positive and negative trackbar limits
                        RGB[b] += (rng.Next(-trackbarValue, trackbarValue));

                        //If the component is bigger than 255
                        //Limit the value to 255
                        if (RGB[b] > 255)
                            RGB[b] = 255;

                        //If the component is smaller than 0
                        //Limit the value to 0
                        if (RGB[b] < 0)
                            RGB[b] = 0;
                    }

                    //New color of the pixel
                    _newPixel = Color.FromArgb(RGB[0], RGB[1], RGB[2]);

                    //setting the color to pixel
                    bm.SetPixel(i, j, _newPixel);
                }
                //Incrementing the progress bar after every single column of pixels are done
                progressBar1.Value = (int)((i / (double)(bm.Width - 1) * 100));
            }
            //Changing to default after completion
            progressBar1.Value = 0;

            //Changing the image
            pictureBoxEditor.Image = bm;
        }

        //If user clicks on Load button to load the image
        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            //trying to open an open file dialog
            try
            {
                //Declaring the open file dialog
                OpenFileDialog openFile = new OpenFileDialog();

                //Filtering the files with default set to Bmp files
                openFile.Filter = "Bmp Files|*.bmp*|Jpg Files|*.jpg;*jpeg*|Png Files|*.png*|All files|*.*";

                //Seting Filter index and Restoring the directory
                openFile.FilterIndex = 1;
                openFile.RestoreDirectory = true;

                //if user wants to open the open dialog
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    //Filename of the file to be opened
                    _sFileName = openFile.FileName;

                    //Loading the image in picture box
                    pictureBoxEditor.Load(_sFileName);

                    //Zooming in or out of the image so it fits the picturebox
                    pictureBoxEditor.SizeMode = PictureBoxSizeMode.Zoom;
                }
                //Enabling the transform button once an image is loaded
                buttonTransform.Enabled = true;
            }
            //catching any error
            catch (Exception error)
            {
                //displayin the error
                Console.WriteLine(error.Message);
            }

        }

        //Occurs everytime user clicks on Transform button to make changes to the image
        //Examine which radio button is checked and perform the required task
        private void ButtonTransform_Click(object sender, EventArgs e)
        {
            //if radio button for contrast was checked
            if (radioButtonContrast.Checked)
            {
                //Calling the contrast method
                Contrast();
            }

            //if radio button for Tint was checked
            else if (radioButtonTint.Checked)
            {
                //Calling the Tint method
                Tint();
            }

            //if radio button for Black and white was checked
            else if (radioButtonBW.Checked)
            {
                //Calling the Black and white method
                BlackWhite();
            }

            //if radio button for Noise was checked
            else
            {
                //Calling the Noise method
                Noise();
            }
            
        }

        //Occurs everytime user starts the program
        //Changes the labels of trackbars
        private void Form1_Load(object sender, EventArgs e)
        {
            LabelChange();
        }

        //Occurs everytime user scrolls the trackbar
        //Changes the label2 of trackbars
        private void trackBarRGB_Scroll(object sender, EventArgs e)
        {
            //if radio button for Tint was checked
            if (radioButtonTint.Checked)
            {
                //if the value of trackbar is greater than 50
                if (trackBarRGB.Value > 50)
                {
                    //Change the middle label
                    label2.Text = "To Green: " + Convert.ToString(trackBarRGB.Value - 50);
                }

                //if the value of trackbar is less than 50
                else
                {
                    //Change the middle label
                    label2.Text = "To Red: " + Convert.ToString(50 - trackBarRGB.Value);
                }
            }

            //Just change the middle value of label to current value of trackbar
            else
            {
                label2.Text = Convert.ToString(trackBarRGB.Value);
            }
        }

        //Occurs everytime user checks or unchecks tint Radiobutton
        //Calls label change method to change the labels
        private void RadioButtonTint_CheckedChanged(object sender, EventArgs e)
        {
            LabelChange();
        }

        //Occurs everytime user checks or unchecks Black and white Radiobutton
        //Calls label change method to change the labels
        private void RadioButtonBW_CheckedChanged(object sender, EventArgs e)
        {
            LabelChange();
        }

        //Occurs everytime user checks or unchecks Noise Radiobutton
        //Calls label change method to change the labels
        private void RadioButtonNoise_CheckedChanged(object sender, EventArgs e)
        {
            LabelChange();
        }

        //Occurs everytime user checks or unchecks Contrast Radiobutton
        //Calls label change method to change the labels
        private void RadioButtonContrast_CheckedChanged(object sender, EventArgs e)
        {
            LabelChange();
        }
    }
}
