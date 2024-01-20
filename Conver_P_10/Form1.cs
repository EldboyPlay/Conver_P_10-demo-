using System.Globalization;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using Конвертор;

namespace Conver_P_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            LoadHistory();

        }


        // ---------- Загрузка истории с текстового файла ----------------
        private void LoadHistory()
        {
            if (File.Exists("ConversionHistory.txt"))
            {
                conversionHistory = File.ReadAllLines("ConversionHistory.txt").ToList();
            }
        }


        // История отслеживание результатов
        private List<string> conversionHistory = new List<string>();


        // Используем Timer из пространства имен System.Windows.Forms
        private System.Windows.Forms.Timer resetButtonTextTimer = new System.Windows.Forms.Timer();



        private void InitializeComboBox()
        {
            // Заполнение comboBoxBase значениями от 2 до 16
            for (int i = 2; i <= 16; i++)
            {
                comboBoxBase.Items.Add(i);
            }
            comboBoxBase.SelectedIndex = 0; // Установка начального значения

            // Защита от случайного нажатия или ввода пользователем 
            comboBoxBase.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        // ================================================================
        // -------- Программирование кнопки "Конвертировать" --------
        // ================================================================
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            try
            {
                var P_num = textBoxNumber.Text;
                if (string.IsNullOrWhiteSpace(P_num))
                {
                    MessageBox.Show("Пожалуйста, введите число для конвертации.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (comboBoxBase.SelectedItem == null)
                {
                    MessageBox.Show("Пожалуйста, выберите основание системы счисления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(comboBoxBase.SelectedItem.ToString(), out int P))
                {
                    MessageBox.Show("Некорректное основание системы счисления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = Конвертор.Conver_P_10.dval(P_num, P);
                textBoxResult.Text = result.ToString(CultureInfo.InvariantCulture);

                // Запись в историю (предполагая, что такой функционал существует)
                try
                {
                    string newEntry = $"{DateTime.Now}: {P_num} в системе с основанием {P} равно {result}";
                    File.AppendAllText("ConversionHistory.txt", newEntry + Environment.NewLine);
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Ошибка записи в файл: {ex.Message}", "Ошибка файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        // ------------ Кнопка "Копировать результат" --------------
        private void buttonCopy_Click_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxResult.Text);

            // Проверка sender на null и на то, что это Button
            if (sender is Button btn)
            {
                btn.Text = "Скопировано";

                // Устанавливаем таймер для сброса текста кнопки
                resetButtonTextTimer.Interval = 2000; // Задержка в 2 секунды
                resetButtonTextTimer.Tick += (sender, e) =>
                {
                    btn.Text = "Копировать результат";
                    resetButtonTextTimer.Stop();
                };
                resetButtonTextTimer.Start();
            }
        }



        // ----------------- ВЕРХНЕЕ МЕНЮ ФОРМЫ -------------------

        private void exitMenuItem_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void historyMenuItem_Click_Click(object sender, EventArgs e)
        {
            string historyText = string.Join(Environment.NewLine, conversionHistory);
            MessageBox.Show(historyText, "История конвертаций");
        }

        private void helpMenuItem_Click_Click(object sender, EventArgs e)
        {
            string helpText = "Справка по использованию программы 'Конвертер чисел из различных систем счисления':\n\n" +
              "- Ввод числа: Введите число в текстовое поле, которое вы хотите преобразовать. " +
              "Число должно соответствовать выбранной системе счисления.\n\n" +
              "- Выбор основания системы счисления: Используйте выпадающий список для выбора основания системы счисления входного числа. " +
              "Вы можете выбрать основание от 2 до 16, включая двоичную, восьмеричную, десятичную и шестнадцатеричную системы.\n\n" +
              "- Конвертация: Нажмите кнопку 'Конвертировать', чтобы преобразовать введенное число из выбранной системы счисления в десятичную систему. " +
              "Результат будет отображен в поле для результата.\n\n" +
              "- История конвертаций: Каждая успешная конвертация записывается в файл 'ConversionHistory.txt', который можно найти в директории программы. " +
              "Этот файл содержит детали всех произведенных конвертаций.\n\n" +
              "- Копирование результата: Используйте кнопку 'Копировать' (если она присутствует), чтобы скопировать результат конвертации в буфер обмена.\n\n" +
              "При возникновении ошибок, программа выведет соответствующее сообщение об ошибке, помогая правильно использовать интерфейс.";

            MessageBox.Show(helpText, "Справка по использованию программы");
        }


        // Будущие обновления кода....

    }

}

