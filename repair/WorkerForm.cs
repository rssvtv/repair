using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repair
{
    public partial class WorkerForm : Form
    {
        private List<RepairApplication> applications; // Список заявок на ремонт

        public WorkerForm(List<RepairApplication> applications)
        {
            InitializeComponent();
            this.applications = applications; // Передаем список заявок
            UpdateApplicationList(); // Обновляем список заявок при загрузке формы
        }

        private void UpdateApplicationList()
        {
            listBoxApplications.Items.Clear();
            foreach (var application in applications)
            {
                listBoxApplications.Items.Add(application.ToString());
            }
        }

        private void btnAssignSpecialist_Click(object sender, EventArgs e)
        {
            // Получаем номер заявки и информацию о специалисте и дате
            string applicationNumber = txtApplicationNumber.Text.Trim();
            string specialistName = txtSpecialistName.Text.Trim();
            DateTime assignmentDate = dateTimePickerAssignmentDate.Value;

            // Поиск заявки по номеру
            var application = applications.Find(app => app.ApplicationNumber == applicationNumber);
            if (application != null)
            {
                // Здесь можно добавить логику назначения специалиста и даты
                // Например, можно создать новый класс для хранения информации о назначении
                MessageBox.Show($"Заявка {applicationNumber} назначена специалисту {specialistName} на {assignmentDate.ToShortDateString()}");
            }
            else
            {
                MessageBox.Show("Заявка с таким номером не найдена.");
            }
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            UpdateApplicationList(); // Обновляем список заявок
            MessageBox.Show("Данные обновлены.");
        }
    }
}
