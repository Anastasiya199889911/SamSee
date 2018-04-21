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
using System.Xml;
using HtmlAgilityPack;

using OpenQA.Selenium;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace smth
{
    public partial class Form1 : MaterialForm
    {
        List<Ganre> ganre = new List<Ganre>();
        List<Country> country = new List<Country>();
        List<Rating> rating = new List<Rating>();
        List<Year> year = new List<Year>();
        List<Film> film;
        List<string> filmways;
        List<string> parserezult;
        Random rand = new Random();
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
            Point point = new Point();
            point.X = 95;
            point.Y = 85;
            SearchByCategoryPanel.Location = point;
            SearchRandomPanel.Location = point;
            SearchIntelligentPanel.Location = point;

            XmlDocument doc = new XmlDocument();
            //
            doc.Load("ganre.xml");
            foreach (XmlNode node in doc.DocumentElement)
            {
                string name = node.Attributes[0].Value;
                int id = int.Parse(node["id"].InnerText);
                string way = node["way"].InnerText;
                int pages = int.Parse(node["pages"].InnerText);
                ganre.Add(new Ganre(id, name, way, pages));
            }
            for (int i = 0; i < ganre.Count(); i++)
            {
                GanreComboBox.Items.Add(ganre[i].GetName());
            }
            //
            doc.Load("country.xml");
            foreach (XmlNode node in doc.DocumentElement)
            {
                string name = node.Attributes[0].Value;
                int id = int.Parse(node["id"].InnerText);
                country.Add(new Country(id, name));
            }
            for (int i = 0; i < country.Count(); i++)
            {
                CountryComboBox.Items.Add(country[i].GetName());
            }
            //
            doc.Load("rating.xml");
            foreach (XmlNode node in doc.DocumentElement)
            {
                string name = node.Attributes[0].Value;
                int id = int.Parse(node["id"].InnerText);
                if (id == 1)
                    name = "<" + name;
                rating.Add(new Rating(id, name));
            }
            for (int i = 0; i < rating.Count(); i++)
            {
                RatingComboBox.Items.Add(rating[i].GetName());
            }
            //
            doc.Load("year.xml");
            foreach (XmlNode node in doc.DocumentElement)
            {
                string name = node.Attributes[0].Value;
                int id = int.Parse(node["id"].InnerText);
                int start = int.Parse(node["start"].InnerText);
                int end = int.Parse(node["end"].InnerText);
                year.Add(new Year(id, name, start, end));
            }
            YearComboBox.Items.Add("<" + year[0].GetName());
            for (int i = 1; i < year.Count(); i++)
            {
                YearComboBox.Items.Add(year[i].GetName());
            }
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
            SearchByCategoryPanel.Height = Size.Height - 60;
            //Панель категорий в поиске по категориям
            CategoryTablePanel1.Width = Size.Width - 95;
            CategoryTablePanel1.Height = 40;
            //Панель категорий с выпадающими списками в поиске по категориям
            CategoryTablePanel2.Width = Size.Width - 95;
            CategoryTablePanel2.Height = 50;
            //Панель категорий кнопка поиск в поиске по категориям
            SearchByCategorySearchTablePanel.Width = Size.Width - 95;
            SearchByCategorySearchTablePanel.Height = 80;
            SearchByCategorySearchButton.Width = Size.Width - 95;
            SearchByCategorySearchButton.Height = 80;

            //Панель рандомного поиска
            SearchRandomPanel.Width = Size.Width - 95;
            SearchRandomPanel.Height = Size.Height - 60;
            //Панлеь рандомного поиска кнопка поиска
            SearchRandomSearchTablePanel.Width = Size.Width - 95;
            SearchRandomSearchTablePanel.Height = 80;
            SearchRandomSearchButton.Width = Size.Width - 95;
            SearchRandomSearchButton.Height = 80;

            //Панель интеллектуального поиска
            SearchIntelligentPanel.Width = Size.Width - 95;
            SearchIntelligentPanel.Height = Size.Height - 60;
            //Панлеь интелектуального поиска кнопка поиска
            SearchIntelligentSearchTablePanel.Width = Size.Width - 95;
            SearchIntelligentSearchTablePanel.Height = 80;
            SearchIntelligentSearchButton.Width = Size.Width - 95;
            SearchIntelligentSearchButton.Height = 80;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SearchByCategoryButton_Click(object sender, EventArgs e)
        {
            SearchRandomPanel.Visible = false;
            SearchIntelligentPanel.Visible = false;
            SearchByCategoryPanel.Visible = true;
        }


        private void SearchRandomButton_Click(object sender, EventArgs e)
        {
            SearchByCategoryPanel.Visible = false;
            SearchIntelligentPanel.Visible = false;
            SearchRandomPanel.Visible = true;
        }

        private void SearchIntelligentButton_Click(object sender, EventArgs e)
        {
            SearchByCategoryPanel.Visible = false;
            SearchRandomPanel.Visible = false;
            SearchIntelligentPanel.Visible = true;
        }
        private void LoadGanre()
        {

        }
        //public void SearchFilmByCategory(int pages,string way=null)
        //{
        //    string element;
        //    int count = 0;
        //    List<string> filmways=new List<string>();
        //    for (int i = 1; i <= pages; i++)
        //    {
        //        string html = way + i + "/";

        //        HtmlDocument HD = new HtmlDocument();
        //        var web = new HtmlWeb
        //        {
        //            AutoDetectEncoding = false,
        //            OverrideEncoding = Encoding.UTF8,
        //        };
        //        HD = web.Load(html);

        //        // Собственно, здесь и производится выборка интересующих нам нодов
        //        // В данном случае выбираем блочные элементы с классом eTitle
        //        HtmlNodeCollection NoAltElements = HD.DocumentNode.SelectNodes("//div[@class='posttitle']");
        //        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

        //        // Проверяем наличие узлов
        //        if (NoAltElements != null)
        //        {
        //            foreach (var tag in NoAltElements)
        //            {
        //                element = tag.InnerHtml;
        //                doc.LoadHtml(element);
        //                HtmlNodeCollection bodyNode = doc.DocumentNode.SelectNodes("//a");
        //                if (bodyNode != null)
        //                {
        //                    foreach (var tag1 in bodyNode)
        //                    {
        //                        filmways.Add(tag1.Attributes["href"].Value);
        //                        count++;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        public void SearchWayFilmByCategory(int pages, string way = null)
        {
            filmways = new List<string>();
            string element;
            if (way != null)
            {
                //парсим ссылки
                //List<string> fi = new List<string>();

                for (int i = 0; i < 5; i++)
                {
                    int page = rand.Next(1, pages);
                    string html = way + page + "/";
                    HtmlDocument HD = new HtmlDocument();
                    var web = new HtmlWeb
                    {
                        AutoDetectEncoding = false,
                        OverrideEncoding = Encoding.UTF8,
                    };
                    HD = web.Load(html);

                    // Собственно, здесь и производится выборка интересующих нам нодов
                    // В данном случае выбираем блочные элементы с классом eTitle
                    HtmlNodeCollection NoAltElements = HD.DocumentNode.SelectNodes("//div[@class='shorposterbox']");
                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

                    // Проверяем наличие узлов
                    if (NoAltElements != null)
                    {
                        foreach (var tag in NoAltElements)
                        {
                            element = tag.InnerHtml;
                            doc.LoadHtml(element);
                            HtmlNodeCollection bodyNode = doc.DocumentNode.SelectNodes("//div[@class='postertitle']/h2/a");
                            if (bodyNode != null)
                            {
                                foreach (var tag1 in bodyNode)
                                {
                                    filmways.Add(tag1.InnerText);
                                }
                            }
                            bodyNode = doc.DocumentNode.SelectNodes("//div[@class='rating']/ul/li[@class='current-rating']");
                            if (bodyNode != null)
                            {
                                foreach (var tag1 in bodyNode)
                                {
                                    filmways.Add(tag1.InnerText);
                                }
                            }
                            HtmlNodeCollection bodyNode1 = doc.DocumentNode.SelectNodes("//div[@class='shortboxh']/div/span[@class='orange']");
                            if (bodyNode1 != null)
                            {
                                foreach (var tag2 in bodyNode1)
                                {
                                    filmways.Add(tag2.InnerText);
                                }
                            }
                            HtmlNodeCollection bodyNode2 = doc.DocumentNode.SelectNodes("//div[@class='shortboxh']/div[@class='shorttext']");
                            if (bodyNode2 != null)
                            {
                                foreach (var tag3 in bodyNode2)
                                {
                                    filmways.Add(tag3.InnerText);
                                }
                            }
                        }
                    }
                }

                film = new List<Film>();
                for (int i = 0; i < filmways.Count(); i = i + 9)
                {
                    Film f = new Film();
                    f.SetName(filmways[i]);
                    f.SetRating(Convert.ToInt32(filmways[i + 1]));
                    f.SetYear(filmways[i + 2]);
                    f.SetCountry(filmways[i + 3]);
                    f.SetGanre(filmways[i + 4]);
                    f.SetProducer(filmways[i + 5]);
                    film.Add(f);
                }

            }
            else
            {

            }
        }
        public void ParseWayFilmByCategory()
        {
            //parserezult = new List<string>();
            //string element;
            //film = new List<Film>();
            //for (int k = 0; k < filmways.Count(); k++)
            //{
            //    //парсим фильмы в класс Film
            //    string html = filmways[k];

            //    HtmlDocument HD = new HtmlDocument();
            //    var web = new HtmlWeb
            //    {
            //        AutoDetectEncoding = false,
            //        OverrideEncoding = Encoding.UTF8,
            //    };
            //    HD = web.Load(html);

            //    // Собственно, здесь и производится выборка интересующих нам нодов
            //    // В данном случае выбираем блочные элементы с классом eTitle
            //    HtmlNodeCollection NoAltElements = HD.DocumentNode.SelectNodes("//div[@class='info']");
            //    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

            //    // Проверяем наличие узлов
            //    if (NoAltElements != null)
            //    {
            //        foreach (var tag in NoAltElements)
            //        {
            //            element = tag.InnerHtml;
            //            doc.LoadHtml(element);
            //            HtmlNodeCollection bodyNode = doc.DocumentNode.SelectNodes("//td");
            //            if (bodyNode != null)
            //            {
            //                foreach (var tag1 in bodyNode)
            //                {
            //                    parserezult.Add(tag1.InnerText);
            //                }
            //            }
            //        }
            //    }
            //    Film f = new Film();
            //    for (int i = 0; i < parserezult.Count(); i++)
            //    {
            //        if (parserezult[i] == "Название:")
            //            f.SetName(parserezult[i + 1]);
            //        if (parserezult[i] == "Год:")
            //        {
            //            f.SetYear(Convert.ToInt32(parserezult[i + 1]));
            //        }
            //        if (parserezult[i] == "Жанр:")
            //        {
            //            List<string> g = new List<string>();
            //            string[] strsplit = parserezult[i + 1].Split(',');
            //            for (int s = 0; s < strsplit.Count(); s++)
            //            {
            //                strsplit[s] = strsplit[s].Replace(" ", "");
            //                for (int j = 0; j < ganre.Count(); j++)
            //                {
            //                    if (strsplit[s] == ganre[j].GetName())
            //                    {
            //                        g.Add(ganre[j].GetName());
            //                        break;
            //                    }
            //                }
            //            }
            //            f.SetGanre(g);
            //        }
            //        if (parserezult[i] == "Режиссер:")
            //            f.SetProducer(parserezult[i + 1]);
            //        if (parserezult[i] == "Страна:")
            //            f.SetCountry(parserezult[i + 1]);

            //    }
            //    film.Add(f);
            //}

        }

        private void SearchByCategorySearchButton_Click(object sender, EventArgs e)
        {
            string not = "-Не выбрано-";
            do
            {
                if (GanreComboBox.Text != not)
                {
                    for (int i = 0; i < ganre.Count(); i++)
                    {
                        if (ganre[i].GetName() == GanreComboBox.Text)
                        {
                            SearchWayFilmByCategory(ganre[i].GetPages(), ganre[i].GetWay());
                            break;
                        }
                    }
                    if (YearComboBox.Text != not)
                    {
                        int start = 0;
                        int end = 0;
                        for (int i = 0; i < year.Count(); i++)
                        {
                            if (year[i].GetName() == YearComboBox.Text)
                            {
                                start = year[i].GetStart();
                                end = year[i].GetEnd();
                                break;
                            }
                        }
                        for (int i = 0; i < film.Count(); i++)
                        {
                            if (start >= Convert.ToInt32(film[i].GetYear()) || Convert.ToInt32(film[i].GetYear()) >= end)
                            {
                                film.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                    if (CountryComboBox.Text != not)
                    {
                        for (int i = 0; i < film.Count(); i++)
                        {
                            if (film[i].GetCountry() != CountryComboBox.Text)
                            {
                                film.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                }
                else
                {

                }
            }
            while (film.Count == 0);
            CategoryOuntputFilmTablepanel.Visible = true;
            int p = rand.Next(0, film.Count());
            CategoryNameFilmTextBox.Text = film[p].GetName();
            CategoryYearFilmTextBox.Text = film[p].GetYear();
            CategoryGanreFilmTextBox.Text = film[p].GetGanre();
            CategoryCountryFilmTextBox.Text = film[p].GetCountry();
            CategoryRatingFilmTextBox.Text = Convert.ToString(film[p].GetRating());
            CategoryProducerFilmTextBox.Text = film[p].GetProducer();

        }
    }
}
