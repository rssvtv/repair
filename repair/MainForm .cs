using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace repair
{
    public partial class MainForm : Form
    {
        private List<RepairApplication> applications; // Список заявок на ремонт
        private List<string> feedbacks; // Список отзывов

        public MainForm()
        {
            InitializeComponent();
            applications = new List<RepairApplication>(); // Инициализация списка заявок
            feedbacks = new List<string>(); // Инициализация списка отзывов
            InitializeComboBoxes(); // Инициализация комбобоксов
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Можно добавить код, который будет выполняться при загрузке формы
        }

        private void InitializeComboBoxes()
        {
            comboBoxType.Items.Add("Аппаратная");
            comboBoxType.Items.Add("Программная");
            comboBoxType.Items.Add("Сетевые проблемы");
            comboBoxType.Items.Add("Другое");

            comboBoxEquipmentType.Items.Add("Ноутбук");
            comboBoxEquipmentType.Items.Add("Настольный ПК");
            comboBoxEquipmentType.Items.Add("Принтер");
            comboBoxEquipmentType.Items.Add("Сервер");
            comboBoxEquipmentType.Items.Add("Сетевое оборудование");
            comboBoxEquipmentType.Items.Add("Другое");
        }

        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            string applicationNumber = txtApplicationNumber.Text.Trim();
            DateTime applicationDate = dateTimePicker.Value;
            string problemDescription = txtProblemDescription.Text.Trim();
            string contactInfo = txtContactInfo.Text.Trim();
            string faultType = comboBoxType.SelectedItem?.ToString();
            string equipmentType = comboBoxEquipmentType.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(applicationNumber) &&
                !string.IsNullOrEmpty(problemDescription) &&
                !string.IsNullOrEmpty(contactInfo) &&
                !string.IsNullOrEmpty(faultType) &&
                !string.IsNullOrEmpty(equipmentType))
            {
                applications.Add(new RepairApplication(applicationNumber, applicationDate, problemDescription, contactInfo, faultType, equipmentType));
                MessageBox.Show("Заявка добавлена!");
                ClearFields();
                UpdateApplicationStatus();
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
            }
        }

        private void ClearFields()
        {
            txtApplicationNumber.Clear();
            txtProblemDescription.Clear();
            txtContactInfo.Clear();
            comboBoxType.SelectedIndex = -1;
            comboBoxEquipmentType.SelectedIndex = -1;
        }

        private void btnViewStatus_Click(object sender, EventArgs e)
        {
            // Получаем статус заявки (в данном случае просто пример)
            string applicationStatus = GetApplicationStatus();

            // Отображаем статус заявки в MessageBox
            MessageBox.Show(applicationStatus, "Статус заявки", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLeaveFeedback_Click(object sender, EventArgs e)
        {
            string feedback = txtFeedback.Text.Trim();
            if (!string.IsNullOrEmpty(feedback))
            {
                feedbacks.Add(feedback);
                MessageBox.Show("Отзыв оставлен!");
                txtFeedback.Clear();
            }
            else
            {
                MessageBox.Show("Введите текст отзыва.");
            }
        }

        private void UpdateApplicationStatus()
        {
            listBoxStatus.Items.Clear();
            foreach (var application in applications)
            {
                listBoxStatus.Items.Add(application.ToString());
            }
        }

        private string GetApplicationStatus()
        {
            // Здесь можно реализовать логику для получения статуса заявки
            // Например, возвращаем сообщение о количестве заявок
            return $"Всего заявок: {applications.Count}";
        }

        private void btnOpenWorkerForm_Click(object sender, EventArgs e)
        {
            WorkerForm workerForm = new WorkerForm(applications); // Передаем список заявок
            workerForm.Show(); // Открываем форму работника
        }
    }

    public class RepairApplication // Класс для заявки на ремонт
    {
        public string ApplicationNumber { get; }
        public DateTime ApplicationDate { get; }
        public string ProblemDescription { get; }
        public string ContactInfo { get; }
        public string FaultType { get; }
        public string EquipmentType { get; }

        public RepairApplication(string applicationNumber, DateTime applicationDate, string problemDescription, string contactInfo, string faultType, string equipmentType)
        {
            ApplicationNumber = applicationNumber;
            ApplicationDate = applicationDate;
            ProblemDescription = problemDescription;
            ContactInfo = contactInfo;
            FaultType = faultType;
            EquipmentType = equipmentType;
        }

        public override string ToString()
        {
            return $"{ApplicationNumber} - {ApplicationDate.ToShortDateString()} - {ProblemDescription} - {ContactInfo} - {FaultType} - {EquipmentType}";
        }
    }
}

