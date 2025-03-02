using System.Xml.Serialization;
using System.Collections.Generic;
using ClassLibrary2;
using System;

namespace LABS_2_PR
{
    public partial class Form1 : Form
    {
        public List<Worker> workers = new List<Worker>();
        public List<Engineer> engineers = new List<Engineer>();
        public List<HumanResources> HR = new List<HumanResources>();
        public List<Administration> admins = new List<Administration>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateObject_Click(object sender, EventArgs e)
        {
            panelCreateObject.Visible = true; // Показываем панель
        }


        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await LoadXmlAsync<Engineer>();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SaveToXmlAsync<T>();

            Administration admin = new Administration();
            admin.FillData(txtAdminPosition.Text, txtAdminResponsibilities.Text, txtAdminSubordinates.Text);

            admins.Add(admin);
            MessageBox.Show("Данные успешно сохранены!");
        }

        public async Task SaveToXmlAsync<T>(List<T> data)
        {
            await Task.Run(() =>
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));

                using (FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate))
                {
                    xmlSerializer.Serialize(fs, data);

                    MessageBox.Show("Данные успешно сохранены!");
                }
            });
        }

        public async Task LoadXmlAsync<T>()
        {
            await Task.Run(() =>
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));

                // десериализуем объект
                using (FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate))
                {
                    List<T>? data = xmlSerializer.Deserialize(fs) as List<T>;
                    MessageBox.Show("Данные загружены успешно!");

                    return data;
                }
            });
        }
    }
}
