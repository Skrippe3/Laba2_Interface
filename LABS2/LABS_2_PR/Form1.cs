using System.Xml.Serialization;
using System.Collections.Generic;
using ClassLibrary2;
using System;
using System.Threading.Tasks;

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

        private async void button3_Click(object sender, EventArgs e)
        {
            //SaveToXmlAsync<T>();

            Administration admin = new Administration();
            admin.FillData(txtAdminPosition.Text, txtAdminResponsibilities.Text, txtAdminSubordinates.Text);

            admins.Add(admin);
            await SaveToXmlAsync(admins, Path.Combine([Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "admin.xml"]));
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            worker.FillData(txtWorkerExperience.Text, txtWorkerQualification.Text, txtWorkerSpecialty.Text);
            workers.Add(worker);
            await SaveToXmlAsync(workers, "worker.xml");
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            HumanResources hr = new HumanResources();
            hr.FillData(txtHRAccounting.Text, txtHRCount.Text, txtHRMethods.Text);

            HR.Add(hr);
            await SaveToXmlAsync(HR, "hr.xml");
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            Engineer engineer = new Engineer();
            engineer.FillData(txtEngineerExperience.Text, txtEngineerQualification.Text,txtEngineerSpecialization.Text);

            engineers.Add(engineer);
            await SaveToXmlAsync(engineers, "engineer.xml");
        }

        public async Task SaveToXmlAsync<T>(List<T> data, string filePath)
        {
            await Task.Run(() =>
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));

                using (var fs = new StreamWriter(filePath))
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
