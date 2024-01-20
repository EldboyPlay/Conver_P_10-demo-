using System.Globalization;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using ���������;

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


        // ---------- �������� ������� � ���������� ����� ----------------
        private void LoadHistory()
        {
            if (File.Exists("ConversionHistory.txt"))
            {
                conversionHistory = File.ReadAllLines("ConversionHistory.txt").ToList();
            }
        }


        // ������� ������������ �����������
        private List<string> conversionHistory = new List<string>();


        // ���������� Timer �� ������������ ���� System.Windows.Forms
        private System.Windows.Forms.Timer resetButtonTextTimer = new System.Windows.Forms.Timer();



        private void InitializeComboBox()
        {
            // ���������� comboBoxBase ���������� �� 2 �� 16
            for (int i = 2; i <= 16; i++)
            {
                comboBoxBase.Items.Add(i);
            }
            comboBoxBase.SelectedIndex = 0; // ��������� ���������� ��������

            // ������ �� ���������� ������� ��� ����� ������������� 
            comboBoxBase.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        // ================================================================
        // -------- ���������������� ������ "��������������" --------
        // ================================================================
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            try
            {
                var P_num = textBoxNumber.Text;
                if (string.IsNullOrWhiteSpace(P_num))
                {
                    MessageBox.Show("����������, ������� ����� ��� �����������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (comboBoxBase.SelectedItem == null)
                {
                    MessageBox.Show("����������, �������� ��������� ������� ���������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(comboBoxBase.SelectedItem.ToString(), out int P))
                {
                    MessageBox.Show("������������ ��������� ������� ���������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = ���������.Conver_P_10.dval(P_num, P);
                textBoxResult.Text = result.ToString(CultureInfo.InvariantCulture);

                // ������ � ������� (�����������, ��� ����� ���������� ����������)
                try
                {
                    string newEntry = $"{DateTime.Now}: {P_num} � ������� � ���������� {P} ����� {result}";
                    File.AppendAllText("ConversionHistory.txt", newEntry + Environment.NewLine);
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"������ ������ � ����: {ex.Message}", "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        // ------------ ������ "���������� ���������" --------------
        private void buttonCopy_Click_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxResult.Text);

            // �������� sender �� null � �� ��, ��� ��� Button
            if (sender is Button btn)
            {
                btn.Text = "�����������";

                // ������������� ������ ��� ������ ������ ������
                resetButtonTextTimer.Interval = 2000; // �������� � 2 �������
                resetButtonTextTimer.Tick += (sender, e) =>
                {
                    btn.Text = "���������� ���������";
                    resetButtonTextTimer.Stop();
                };
                resetButtonTextTimer.Start();
            }
        }



        // ----------------- ������� ���� ����� -------------------

        private void exitMenuItem_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void historyMenuItem_Click_Click(object sender, EventArgs e)
        {
            string historyText = string.Join(Environment.NewLine, conversionHistory);
            MessageBox.Show(historyText, "������� �����������");
        }

        private void helpMenuItem_Click_Click(object sender, EventArgs e)
        {
            string helpText = "������� �� ������������� ��������� '��������� ����� �� ��������� ������ ���������':\n\n" +
              "- ���� �����: ������� ����� � ��������� ����, ������� �� ������ �������������. " +
              "����� ������ ��������������� ��������� ������� ���������.\n\n" +
              "- ����� ��������� ������� ���������: ����������� ���������� ������ ��� ������ ��������� ������� ��������� �������� �����. " +
              "�� ������ ������� ��������� �� 2 �� 16, ������� ��������, ������������, ���������� � ����������������� �������.\n\n" +
              "- �����������: ������� ������ '��������������', ����� ������������� ��������� ����� �� ��������� ������� ��������� � ���������� �������. " +
              "��������� ����� ��������� � ���� ��� ����������.\n\n" +
              "- ������� �����������: ������ �������� ����������� ������������ � ���� 'ConversionHistory.txt', ������� ����� ����� � ���������� ���������. " +
              "���� ���� �������� ������ ���� ������������� �����������.\n\n" +
              "- ����������� ����������: ����������� ������ '����������' (���� ��� ������������), ����� ����������� ��������� ����������� � ����� ������.\n\n" +
              "��� ������������� ������, ��������� ������� ��������������� ��������� �� ������, ������� ��������� ������������ ���������.";

            MessageBox.Show(helpText, "������� �� ������������� ���������");
        }


        // ������� ���������� ����....

    }

}

