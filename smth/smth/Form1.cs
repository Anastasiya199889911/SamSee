using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smth
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.BLACK);
            //Accent - цвет переключателей в radiobutton и checkbox
            //TextShade - цвет надписи наименования формы
            //1 Primery - цвет полосы, где название формы и цвет подчеркивания подписи текста
            //2 Primary - цвет заголовка окна при темном дизайне
            //3 Primery - цвет заголовка окна при светлом дизайне
        }

        private void Form1_MaximumSizeChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //Панель верхнего меню
            tableLayoutPanel1.Width = Size.Width;
            tableLayoutPanel1.Height = 60;

            //Панель поиска
            UserPanel.Width = 95;
            UserPanel.Height = Size.Height;

            //Панель поиска по параметрам
            SearchByCategoryPanel.Width = Size.Width - 95;
            SearchByCategoryPanel.Height = Size.Height-60;
            //Панель категорий в поиске по категориям
            CategoryTablePanel1.Width = Size.Width - 95;
            CategoryTablePanel1.Height = 40;
            //Панель категорий с выпадающими списками в поиске по категориям
            CategoryTablePanel2.Width = Size.Width - 95;
            CategoryTablePanel2.Height = 40;
            //Панель категорий кнопка поиск в поиске по категориям
            SearchByCategoryButtonPanel.Width = Size.Width - 95;
            SearchByCategoryButtonPanel.Height = 40;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void SearchByCategoryButton_Click(object sender, EventArgs e)
        {
            SearchByCategoryPanel.Visible = true;
        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void GanreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
