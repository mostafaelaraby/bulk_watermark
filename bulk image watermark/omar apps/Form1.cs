using System;
using System.Drawing.Drawing2D;
using System.Web;
using System.Drawing.Imaging;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace  watermark_generator

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void select_watermark_image_Click(object sender, EventArgs e)
        {
            openfiledialog_watermark.ShowDialog();
            watermark_image.Text = openfiledialog_watermark.FileName;
        }

        private void select_images_Click(object sender, EventArgs e)
        {
            openfiledialog_images.ShowDialog();
            openfiledialog_images.Multiselect = true;
            images.Text = openfiledialog_images.FileName;
        }

        private void select_output_folder_Click(object sender, EventArgs e)
        {
            output.ShowDialog();
            output_text.Text = output.SelectedPath;
        }
    Image thumbnail;

    private void ThumbnailImageCreation_Load(object sender, EventArgs e,int logo_width,int logo_height)
    {
        Image img = Image.FromFile(openfiledialog_watermark.FileName);
        thumbnail = img.GetThumbnailImage(logo_width,logo_height,null, IntPtr.Zero);
        
    }

   
        private void Start_Click_1(object sender, EventArgs e)
        {
            if ((openfiledialog_watermark.FileName == "openFileDialog1" || openfiledialog_watermark.FileName == "") && (openfiledialog_images.FileName == "select images" || openfiledialog_images.FileName == "") && output.SelectedPath == "")
            {
                MessageBox.Show("please choose images and the place where they will be exported to!");
            }
            else if (openfiledialog_watermark.FileName == "openFileDialog1" || openfiledialog_watermark.FileName == "")
            {
                MessageBox.Show("please choose watermark!");
            }
            else if (openfiledialog_images.FileName == "select images" || openfiledialog_images.FileName == "")
            {
                MessageBox.Show("please choose  the images you want to add the watermark to!");
            }
            else if (output.SelectedPath == "")
            {
                MessageBox.Show("please choose the directory that the images will be exported to!");
            }
            else if (openfiledialog_watermark.FileName != "openFileDialog1" || openfiledialog_images.FileName != "select images" || output.SelectedPath != "")
            {
                Image[] image = new Image[openfiledialog_images.FileNames.Count()];
                Image logo = Image.FromFile(openfiledialog_watermark.FileName); //This is your watermark 
                progressBar1.Step = 100 / openfiledialog_images.FileNames.Count();
                float trancparency2 = Convert.ToSingle((1 - ((trancparency.Value) / 100)));
                int logo2_width = logo.Width;
                int logo2_height = logo.Height;
                if (watermark_position.Text == "Top Right")
                {
                    for (int i = 0; i < openfiledialog_images.FileNames.Count(); i++)
                    {
                        image[i] = Image.FromFile(openfiledialog_images.FileNames[i]);
                        Bitmap TransparentLogo;
                        if (scale.Checked == true)
                        {
                            logo2_height = logo.Height / 2;
                            logo2_width = logo.Width / 2;
                            if (logo2_height > image[i].Height / 2 && logo2_width > image[i].Width / 2)
                            {
                                for (int i1 = 0; i1 < logo.Height / 2; i1++)
                                {
                                    switch (logo2_height < image[i].Height / 2)
                                    {
                                        case true: break;
                                        case false: logo2_height /= 2; break;
                                    }
                                }
                                for (int i4 = 0; i4 < logo.Height / 2; i4++)
                                {
                                    switch (logo2_width < image[i].Width / 2)
                                    {
                                        case true: break;
                                        case false: logo2_width /= 2; break;
                                    }
                                }

                            }
                            else if (logo2_height > image[i].Height / 2)
                            {
                                for (int i2 = 0; i2 < logo.Height / 2; i2++)
                                {
                                    switch (logo2_height < image[i].Height / 2)
                                    {
                                        case true: break;
                                        case false: logo2_height /= 2; break;
                                    }
                                }
                            }
                            else if (logo2_width > image[i].Width / 2)
                            {
                                for (int i3 = 0; i3 < logo.Height / 2; i3++)
                                {
                                    switch (logo2_width < image[i].Width / 2)
                                    {
                                        case true: break;
                                        case false: logo2_width /= 2; break;
                                    }
                                }
                            }
                        }
                        TransparentLogo = new Bitmap(logo2_width, logo2_height);
                        if (logo2_height != logo.Height || logo2_width != logo.Width)
                        {
                            ThumbnailImageCreation_Load(sender, e, logo2_width, logo2_height);
                            Graphics g = System.Drawing.Graphics.FromImage(image[i]); //Create graphics object of the background image //So that you can draw your logo on it

                            Graphics TGraphics = Graphics.FromImage(TransparentLogo);//Create a graphics object so that //we can draw //on the blank bitmap image object
                            ColorMatrix ColorMatrix = new ColorMatrix(); //An image is represenred as a 5X4 matrix(i.e 4 //columns and 5 //rows) 
                            ColorMatrix.Matrix33 = trancparency2;//the 3rd element of the 4th row represents the transparency 
                            ImageAttributes ImgAttributes = new ImageAttributes();//an ImageAttributes object is used to set all //the alpha //values.This is done by initializing a color matrix and setting the alpha scaling value in the matrix.The address of //the color matrix is passed to the SetColorMatrix method of the //ImageAttributes object, and the //ImageAttributes object is passed to the DrawImage method of the Graphics object.
                            ImgAttributes.SetColorMatrix(ColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                            TGraphics.DrawImage(thumbnail, new Rectangle(0, 0, TransparentLogo.Width, TransparentLogo.Height), 0, 0, thumbnail.Width, thumbnail.Height, GraphicsUnit.Pixel, ImgAttributes);

                            TGraphics.Dispose();
                            g.DrawImage(TransparentLogo, image[i].Width - TransparentLogo.Width, 0);
                            string x = output.SelectedPath + "\\" + i+ ".jpeg";
                            image[i].Save(@x, ImageFormat.Jpeg);
                        }
                        else
                        {
                            Graphics g = System.Drawing.Graphics.FromImage(image[i]); //Create graphics object of the background image //So that you can draw your logo on it

                            Graphics TGraphics = Graphics.FromImage(TransparentLogo);//Create a graphics object so that //we can draw //on the blank bitmap image object
                            ColorMatrix ColorMatrix = new ColorMatrix(); //An image is represenred as a 5X4 matrix(i.e 4 //columns and 5 //rows) 
                            ColorMatrix.Matrix33 = trancparency2;//the 3rd element of the 4th row represents the transparency 
                            ImageAttributes ImgAttributes = new ImageAttributes();//an ImageAttributes object is used to set all //the alpha //values.This is done by initializing a color matrix and setting the alpha scaling value in the matrix.The address of //the color matrix is passed to the SetColorMatrix method of the //ImageAttributes object, and the //ImageAttributes object is passed to the DrawImage method of the Graphics object.
                            ImgAttributes.SetColorMatrix(ColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                            TGraphics.DrawImage(logo, new Rectangle(0, 0, TransparentLogo.Width, TransparentLogo.Height), 0, 0, TransparentLogo.Width, TransparentLogo.Height, GraphicsUnit.Pixel, ImgAttributes);

                            TGraphics.Dispose();
                            g.DrawImage(TransparentLogo, image[i].Width - TransparentLogo.Width, 0);
                            string x = output.SelectedPath + "\\" + i+ ".jpeg";
                            image[i].Save(@x, ImageFormat.Jpeg);
                        }
                        progressBar1.PerformStep();
                    }
                }
                else if (watermark_position.Text == "Top Left")
                {
                    for (int i = 0; i < openfiledialog_images.FileNames.Count(); i++)
                    {
                        image[i] = Image.FromFile(openfiledialog_images.FileNames[i]);
                        Bitmap TransparentLogo;
                        if (scale.Checked == true)
                        {
                            logo2_height = logo.Height / 2;
                            logo2_width = logo.Width / 2;
                            if (logo2_height > image[i].Height / 2 && logo2_width > image[i].Width / 2)
                            {
                                for (int i1 = 0; i1 < logo.Height / 2; i1++)
                                {
                                    switch (logo2_height < image[i].Height / 2)
                                    {
                                        case true: break;
                                        case false: logo2_height /= 2; break;
                                    }
                                }
                                for (int i4 = 0; i4 < logo.Height / 2; i4++)
                                {
                                    switch (logo2_width < image[i].Width / 2)
                                    {
                                        case true: break;
                                        case false: logo2_width /= 2; break;
                                    }
                                }

                            }
                            else if (logo2_height > image[i].Height / 2)
                            {
                                for (int i2 = 0; i2 < logo.Height / 2; i2++)
                                {
                                    switch (logo2_height < image[i].Height / 2)
                                    {
                                        case true: break;
                                        case false: logo2_height /= 2; break;
                                    }
                                }
                            }
                            else if (logo2_width > image[i].Width / 2)
                            {
                                for (int i3 = 0; i3 < logo.Height / 2; i3++)
                                {
                                    switch (logo2_width < image[i].Width / 2)
                                    {
                                        case true: break;
                                        case false: logo2_width /= 2; break;
                                    }
                                }
                            }
                        }
                        TransparentLogo = new Bitmap(logo2_width, logo2_height);
                        if (logo2_height != logo.Height || logo2_width != logo.Width)
                        {
                            ThumbnailImageCreation_Load(sender, e, logo2_width, logo2_height);
                            Graphics g = System.Drawing.Graphics.FromImage(image[i]); //Create graphics object of the background image //So that you can draw your logo on it

                            Graphics TGraphics = Graphics.FromImage(TransparentLogo);//Create a graphics object so that //we can draw //on the blank bitmap image object
                            ColorMatrix ColorMatrix = new ColorMatrix(); //An image is represenred as a 5X4 matrix(i.e 4 //columns and 5 //rows) 
                            ColorMatrix.Matrix33 = trancparency2;//the 3rd element of the 4th row represents the transparency 
                            ImageAttributes ImgAttributes = new ImageAttributes();//an ImageAttributes object is used to set all //the alpha //values.This is done by initializing a color matrix and setting the alpha scaling value in the matrix.The address of //the color matrix is passed to the SetColorMatrix method of the //ImageAttributes object, and the //ImageAttributes object is passed to the DrawImage method of the Graphics object.
                            ImgAttributes.SetColorMatrix(ColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                            TGraphics.DrawImage(thumbnail, new Rectangle(0, 0, TransparentLogo.Width, TransparentLogo.Height), 0, 0, thumbnail.Width, thumbnail.Height, GraphicsUnit.Pixel, ImgAttributes);

                            TGraphics.Dispose();
                            g.DrawImage(TransparentLogo, 0, 0);
                            string x = output.SelectedPath + "\\" + i + ".jpeg";
                            image[i].Save(@x, ImageFormat.Jpeg);
                        }
                        else
                        {
                            Graphics g = System.Drawing.Graphics.FromImage(image[i]); //Create graphics object of the background image //So that you can draw your logo on it

                            Graphics TGraphics = Graphics.FromImage(TransparentLogo);//Create a graphics object so that //we can draw //on the blank bitmap image object
                            ColorMatrix ColorMatrix = new ColorMatrix(); //An image is represenred as a 5X4 matrix(i.e 4 //columns and 5 //rows) 
                            ColorMatrix.Matrix33 = trancparency2;//the 3rd element of the 4th row represents the transparency 
                            ImageAttributes ImgAttributes = new ImageAttributes();//an ImageAttributes object is used to set all //the alpha //values.This is done by initializing a color matrix and setting the alpha scaling value in the matrix.The address of //the color matrix is passed to the SetColorMatrix method of the //ImageAttributes object, and the //ImageAttributes object is passed to the DrawImage method of the Graphics object.
                            ImgAttributes.SetColorMatrix(ColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap); TGraphics.DrawImage(logo, new Rectangle(0, 0, TransparentLogo.Width, TransparentLogo.Height), 0, 0, TransparentLogo.Width, TransparentLogo.Height, GraphicsUnit.Pixel, ImgAttributes);
                            TGraphics.Dispose();
                            g.DrawImage(TransparentLogo, 0, 0);
                            string x = output.SelectedPath + "\\" + i + ".jpeg";
                            image[i].Save(@x, ImageFormat.Jpeg);
                        }
                        progressBar1.PerformStep();
                    }
                }
                else if (watermark_position.Text == "Bottom Right")
                {
                    for (int i = 0; i < openfiledialog_images.FileNames.Count(); i++)
                    {
                        image[i] = Image.FromFile(openfiledialog_images.FileNames[i]);
                        Bitmap TransparentLogo;
                        if (scale.Checked == true)
                        {
                            logo2_height = logo.Height / 2;
                            logo2_width = logo.Width / 2;
                            if (logo2_height > image[i].Height / 2 && logo2_width > image[i].Width / 2)
                            {
                                for (int i1 = 0; i1 < logo.Height / 2; i1++)
                                {
                                    switch (logo2_height < image[i].Height / 2)
                                    {
                                        case true: break;
                                        case false: logo2_height /= 2; break;
                                    }
                                }
                                for (int i4 = 0; i4 < logo.Height / 2; i4++)
                                {
                                    switch (logo2_width < image[i].Width / 2)
                                    {
                                        case true: break;
                                        case false: logo2_width /= 2; break;
                                    }
                                }

                            }
                            else if (logo2_height > image[i].Height / 2)
                            {
                                for (int i2 = 0; i2 < logo.Height / 2; i2++)
                                {
                                    switch (logo2_height < image[i].Height / 2)
                                    {
                                        case true: break;
                                        case false: logo2_height /= 2; break;
                                    }
                                }
                            }
                            else if (logo2_width > image[i].Width / 2)
                            {
                                for (int i3 = 0; i3 < logo.Height / 2; i3++)
                                {
                                    switch (logo2_width < image[i].Width / 2)
                                    {
                                        case true: break;
                                        case false: logo2_width /= 2; break;
                                    }
                                }
                            }
                        }
                        TransparentLogo = new Bitmap(logo2_width, logo2_height);
                        if (logo2_height != logo.Height || logo2_width != logo.Width)
                        {
                            ThumbnailImageCreation_Load(sender, e, logo2_width, logo2_height);
                            Graphics g = System.Drawing.Graphics.FromImage(image[i]); //Create graphics object of the background image //So that you can draw your logo on it

                            Graphics TGraphics = Graphics.FromImage(TransparentLogo);//Create a graphics object so that //we can draw //on the blank bitmap image object
                            ColorMatrix ColorMatrix = new ColorMatrix(); //An image is represenred as a 5X4 matrix(i.e 4 //columns and 5 //rows) 
                            ColorMatrix.Matrix33 = trancparency2;//the 3rd element of the 4th row represents the transparency 
                            ImageAttributes ImgAttributes = new ImageAttributes();//an ImageAttributes object is used to set all //the alpha //values.This is done by initializing a color matrix and setting the alpha scaling value in the matrix.The address of //the color matrix is passed to the SetColorMatrix method of the //ImageAttributes object, and the //ImageAttributes object is passed to the DrawImage method of the Graphics object.
                            ImgAttributes.SetColorMatrix(ColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                            TGraphics.DrawImage(thumbnail, new Rectangle(0, 0, TransparentLogo.Width, TransparentLogo.Height), 0, 0, thumbnail.Width, thumbnail.Height, GraphicsUnit.Pixel, ImgAttributes);

                            TGraphics.Dispose();
                            g.DrawImage(TransparentLogo, (image[i].Width) - TransparentLogo.Width, (image[i].Height) - TransparentLogo.Height);
                            string x = output.SelectedPath + "\\" + i + ".jpeg";
                            image[i].Save(@x, ImageFormat.Jpeg);
                        }
                        else
                        {
                            Graphics g = System.Drawing.Graphics.FromImage(image[i]); //Create graphics object of the background image //So that you can draw your logo on it
                            Graphics TGraphics = Graphics.FromImage(TransparentLogo);//Create a graphics object so that //we can draw //on the blank bitmap image object
                            ColorMatrix ColorMatrix = new ColorMatrix(); //An image is represenred as a 5X4 matrix(i.e 4 //columns and 5 //rows) 
                            ColorMatrix.Matrix33 = trancparency2;//the 3rd element of the 4th row represents the transparency 
                            ImageAttributes ImgAttributes = new ImageAttributes();//an ImageAttributes object is used to set all //the alpha //values.This is done by initializing a color matrix and setting the alpha scaling value in the matrix.The address of //the color matrix is passed to the SetColorMatrix method of the //ImageAttributes object, and the //ImageAttributes object is passed to the DrawImage method of the Graphics object.
                            ImgAttributes.SetColorMatrix(ColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap); TGraphics.DrawImage(logo, new Rectangle(0, 0, TransparentLogo.Width, TransparentLogo.Height), 0, 0, TransparentLogo.Width, TransparentLogo.Height, GraphicsUnit.Pixel, ImgAttributes);
                            TGraphics.Dispose();
                            g.DrawImage(TransparentLogo, (image[i].Width) - TransparentLogo.Width, (image[i].Height) - TransparentLogo.Height);
                            string x = output.SelectedPath + "\\" + i + ".jpeg";
                            image[i].Save(@x, ImageFormat.Jpeg);
                        }
                        progressBar1.PerformStep();
                    }
                }
                else if (watermark_position.Text == "Bottom Left")
                {
                    for (int i = 0; i < openfiledialog_images.FileNames.Count(); i++)
                    {
                        image[i] = Image.FromFile(openfiledialog_images.FileNames[i]);
                        Bitmap TransparentLogo;
                        if (scale.Checked == true)
                        {
                            logo2_height = logo.Height / 2;
                            logo2_width = logo.Width / 2;
                            if (logo2_height > image[i].Height / 2 && logo2_width > image[i].Width / 2)
                            {
                                for (int i1 = 0; i1 < logo.Height / 2; i1++)
                                {
                                    switch (logo2_height < image[i].Height / 2)
                                    {
                                        case true: break;
                                        case false: logo2_height /= 2; break;
                                    }
                                }
                                for (int i4 = 0; i4 < logo.Height / 2; i4++)
                                {
                                    switch (logo2_width < image[i].Width / 2)
                                    {
                                        case true: break;
                                        case false: logo2_width /= 2; break;
                                    }
                                }

                            }
                            else if (logo2_height > image[i].Height / 2)
                            {
                                for (int i2 = 0; i2 < logo.Height / 2; i2++)
                                {
                                    switch (logo2_height < image[i].Height / 2)
                                    {
                                        case true: break;
                                        case false: logo2_height /= 2; break;
                                    }
                                }
                            }
                            else if (logo2_width > image[i].Width / 2)
                            {
                                for (int i3 = 0; i3 < logo.Height / 2; i3++)
                                {
                                    switch (logo2_width < image[i].Width / 2)
                                    {
                                        case true: break;
                                        case false: logo2_width /= 2; break;
                                    }
                                }
                            }
                        }
                        TransparentLogo = new Bitmap(logo2_width, logo2_height);
                        if (logo2_height != logo.Height || logo2_width != logo.Width)
                        {
                            ThumbnailImageCreation_Load(sender, e, logo2_width, logo2_height);
                            Graphics g = System.Drawing.Graphics.FromImage(image[i]); //Create graphics object of the background image //So that you can draw your logo on it

                            Graphics TGraphics = Graphics.FromImage(TransparentLogo);//Create a graphics object so that //we can draw //on the blank bitmap image object
                            ColorMatrix ColorMatrix = new ColorMatrix(); //An image is represenred as a 5X4 matrix(i.e 4 //columns and 5 //rows) 
                            ColorMatrix.Matrix33 = trancparency2;//the 3rd element of the 4th row represents the transparency 
                            ImageAttributes ImgAttributes = new ImageAttributes();//an ImageAttributes object is used to set all //the alpha //values.This is done by initializing a color matrix and setting the alpha scaling value in the matrix.The address of //the color matrix is passed to the SetColorMatrix method of the //ImageAttributes object, and the //ImageAttributes object is passed to the DrawImage method of the Graphics object.
                            ImgAttributes.SetColorMatrix(ColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                            TGraphics.DrawImage(thumbnail, new Rectangle(0, 0, TransparentLogo.Width, TransparentLogo.Height), 0, 0, thumbnail.Width, thumbnail.Height, GraphicsUnit.Pixel, ImgAttributes);
                            TGraphics.Dispose();
                            g.DrawImage(TransparentLogo, 0, (image[i].Height) - TransparentLogo.Height);
                            string x = output.SelectedPath + "\\" + i + ".jpeg";
                            image[i].Save(@x, ImageFormat.Jpeg);
                        }
                        else
                        {
                            Graphics g = System.Drawing.Graphics.FromImage(image[i]); //Create graphics object of the background image //So that you can draw your logo on it
                            Graphics TGraphics = Graphics.FromImage(TransparentLogo);//Create a graphics object so that //we can draw //on the blank bitmap image object
                            ColorMatrix ColorMatrix = new ColorMatrix(); //An image is represenred as a 5X4 matrix(i.e 4 //columns and 5 //rows) 
                            ColorMatrix.Matrix33 = trancparency2;//the 3rd element of the 4th row represents the transparency 
                            ImageAttributes ImgAttributes = new ImageAttributes();//an ImageAttributes object is used to set all //the alpha //values.This is done by initializing a color matrix and setting the alpha scaling value in the matrix.The address of //the color matrix is passed to the SetColorMatrix method of the //ImageAttributes object, and the //ImageAttributes object is passed to the DrawImage method of the Graphics object.
                            ImgAttributes.SetColorMatrix(ColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap); TGraphics.DrawImage(logo, new Rectangle(0, 0, TransparentLogo.Width, TransparentLogo.Height), 0, 0, TransparentLogo.Width, TransparentLogo.Height, GraphicsUnit.Pixel, ImgAttributes);
                            TGraphics.Dispose();
                            g.DrawImage(TransparentLogo, 0, (image[i].Height) - TransparentLogo.Height);
                            string x = output.SelectedPath + "\\" + i + ".jpeg";
                            image[i].Save(@x, ImageFormat.Jpeg);
                        }
                        progressBar1.PerformStep();
                    }
                }
                else
                {
                    MessageBox.Show("Please specify the watermark position");
                }
            }
            progressBar1.PerformStep();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            openfiledialog_watermark.Reset();
            watermark_image.Text = openfiledialog_watermark.FileName;
            openfiledialog_images.Reset();
            images.Text = openfiledialog_images.FileName;
            output.Reset();
            output_text.Text = output.SelectedPath;
        }

        

       
    }
}
