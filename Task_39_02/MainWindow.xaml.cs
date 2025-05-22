using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;

namespace Task_39_02
{
    public partial class MainWindow : Window
    {
        private List<string> shoppingList = new List<string>(); // Используем List<string>
        private const string DefaultFileName = "shopping_list.txt";

        public MainWindow()
        {
            InitializeComponent();
            LoadListFromFile(); // Загружаем список при старте
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string newItem = txtNewItem.Text.Trim();
            if (!string.IsNullOrEmpty(newItem))
            {
                shoppingList.Add(newItem);
                UpdateListBox();
                txtNewItem.Clear();
            }
        }
        private void UpdateListBox()
        {
            lstItems.Items.Clear();
            foreach (string item in shoppingList)
            {
                lstItems.Items.Add(item);
            }
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.FileName = DefaultFileName; // Имя по умолчанию

            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    File.WriteAllLines(saveFileDialog.FileName, shoppingList);
                    MessageBox.Show("Список покупок успешно сохранен!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        private void LoadListFromFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialog.FileName = DefaultFileName;

            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    shoppingList.Clear();
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    shoppingList.AddRange(lines);
                    UpdateListBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                // Если файл не выбран, можно создать пустой
                UpdateListBox();
            }
        }
    }
}