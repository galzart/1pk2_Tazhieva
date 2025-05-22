using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;
using System.Windows.Controls;

namespace StudentApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student> students = new List<Student>();
        private const string FileName = "students.dat";

        public MainWindow()
        {
            InitializeComponent();
            LoadStudents();
            UpdateListBox();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Проверка на заполненность полей
            if (string.IsNullOrEmpty(txtLastName.Text) ||
                string.IsNullOrEmpty(txtFirstName.Text) ||
                string.IsNullOrEmpty(txtPatronymic.Text) ||
                string.IsNullOrEmpty(txtGroup.Text) ||
                (rbMale.IsChecked != true && rbFemale.IsChecked != true))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return; // Прекратить сохранение данных
            }

            Gender selectedGender = rbMale.IsChecked == true ? Gender.Male : Gender.Female;

            Student student = new Student
            {
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                Patronymic = txtPatronymic.Text,
                Group = txtGroup.Text,
                Gender = selectedGender,
                BirthDate = dpBirthDate.SelectedDate ?? DateTime.Now // DateTime.Now для случая, если дата не выбрана
            };

            students.Add(student);
            UpdateListBox();

            // Очистка полей ввода
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtPatronymic.Text = "";
            txtGroup.Text = "";
            rbMale.IsChecked = false;
            rbFemale.IsChecked = false;
            dpBirthDate.SelectedDate = null;
        }

        private void UpdateListBox()
        {
            lbStudents.Items.Clear();
            foreach (var student in students)
            {
                lbStudents.Items.Add(student.ToString());
            }
        }

        private void LoadStudents()
        {
            if (File.Exists(FileName))
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream(FileName, FileMode.Open))
                    {
                        students = (List<Student>)formatter.Deserialize(fs);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(FileName, FileMode.Create))
                {
                    formatter.Serialize(fs, students);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
            }
        }
    }

    [Serializable]
    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string Group { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName} {Patronymic}, Группа: {Group}, Пол: {Gender}, Дата рождения: {BirthDate.ToShortDateString()}";
        }
    }

    public enum Gender
    {
        Male,
        Female
    }
}