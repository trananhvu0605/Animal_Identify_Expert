using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Animal_Identify2
{
    public partial class Xem_hinh_form : Form
    {
        public Xem_hinh_form()
        {
            InitializeComponent();
        }

        public Xem_hinh_form(int n)
        {
            number = n;
            InitializeComponent();
        }

        List<Image> listImage = new List<Image>();
        int number = 0;

        private void AddHinh()
        {
            string source = Application.StartupPath.ToString();
            listImage.Add(Image.FromFile(source + "\\Image\\ech.jpg")); //0
            listImage.Add(Image.FromFile(source + "\\Image\\ky_nhong.jpg")); //1
            listImage.Add(Image.FromFile(source + "\\Image\\ran.jpg")); //2
            listImage.Add(Image.FromFile(source + "\\Image\\ca_sau.jpg")); //3
            listImage.Add(Image.FromFile(source + "\\Image\\rua.jpg")); //4
            listImage.Add(Image.FromFile(source + "\\Image\\ca_map.jpg")); //5
            listImage.Add(Image.FromFile(source + "\\Image\\ca.jpg")); //6
            listImage.Add(Image.FromFile(source + "\\Image\\chuot_chui.jpg")); //7
            listImage.Add(Image.FromFile(source + "\\Image\\kangaroo.jpg")); //8
            listImage.Add(Image.FromFile(source + "\\Image\\no.jpg")); //9
            listImage.Add(Image.FromFile(source + "\\Image\\tho.jpg")); //10
            listImage.Add(Image.FromFile(source + "\\Image\\ca_heo.jpg")); //11
            listImage.Add(Image.FromFile(source + "\\Image\\ca_voi.jpg")); //12
            listImage.Add(Image.FromFile(source + "\\Image\\ngua.jpg")); //13
            listImage.Add(Image.FromFile(source + "\\Image\\te_giac.jpg")); //14
            listImage.Add(Image.FromFile(source + "\\Image\\lac_da.jpg")); //15
            listImage.Add(Image.FromFile(source + "\\Image\\huou_cao_co.jpg")); //0
            listImage.Add(Image.FromFile(source + "\\Image\\huou_nai.jpg")); //0
            listImage.Add(Image.FromFile(source + "\\Image\\bo.jpg")); //0
            listImage.Add(Image.FromFile(source + "\\Image\\cuu.jpg")); //0
            listImage.Add(Image.FromFile(source + "\\Image\\ha_ma.jpg")); //0
            listImage.Add(Image.FromFile(source + "\\Image\\soi.jpg")); //0
            listImage.Add(Image.FromFile(source + "\\Image\\meo.jpg")); //0
            listImage.Add(Image.FromFile(source + "\\Image\\hai_tuong.jpg")); //0
            listImage.Add(Image.FromFile(source + "\\Image\\ho.jpg")); //0
            listImage.Add(Image.FromFile(source + "\\Image\\khi_dau_cho.jpg")); //0
            listImage.Add(Image.FromFile(source + "\\Image\\gorilla.jpg")); //0
            listImage.Add(Image.FromFile(source + "\\Image\\MrBean.jpg")); //0
            listImage.Add(Image.FromFile(source + "\\Image\\khi.jpg")); //0
            listImage.Add(Image.FromFile(source + "\\Image\\doi.jpg")); //0
            listImage.Add(Image.FromFile(source + "\\Image\\chim.jpg")); //0
        }
        public void DisplayImage(int index)
        {
            AddHinh();
            pictureBox1.Image = listImage[index];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void GetValue(int value)
        {
            number = value;
        } 

        private void Xem_hinh_form_Load(object sender, EventArgs e)
        {
            DisplayImage(number);
        }
    }
}
