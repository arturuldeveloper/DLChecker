using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace DriversLicenseExam
{
    public partial class Form1 : Form
    {
        // Correct answers array
        private readonly string[] correctAnswers = {
            "B", "D", "A", "A", "C", "A", "B", "A", "C", "D",
            "B", "C", "D", "A", "D", "C", "C", "B", "D", "A"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Correct_Click(object sender, EventArgs e)
        {

        }

        private void btn_ReadResults_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the file name from the TextBox
                string fileName = txtBox_FileName.Text;

                // Check if the file exists
                if (!File.Exists(fileName))
                {
                    MessageBox.Show("The specified file does not exist. Please check the file name.");
                    return;
                }

                // Read student answers from the text file
                string[] studentAnswers = File.ReadAllLines(fileName);

                // Check if there are exactly 20 answers
                if (studentAnswers.Length != 20)
                {
                    MessageBox.Show("The answer file must contain exactly 20 answers.");
                    return;
                }

                // Initialize counters
                int correctCount = 0;
                int incorrectCount = 0;
                var incorrectQuestions = new System.Collections.Generic.List<int>();

                // Compare student answers with correct answers
                for (int i = 0; i < correctAnswers.Length; i++)
                {
                    if (studentAnswers[i].Trim().ToUpper() == correctAnswers[i])
                    {
                        correctCount++;
                    }
                    else
                    {
                        incorrectCount++;
                        incorrectQuestions.Add(i + 1); // Store question number
                    }
                }

                // Determine if the student passed (15 or more correct answers)
                bool passed = correctCount >= 15;
                lbl_Results.Text = passed ? "Pass" : "Fail";

                // Display results
                lbl_Correct.Text = $"{correctCount}";
                lbl_Incorrect.Text = $"{incorrectCount}";
                lst_IncorrectQuestions.Items.Clear();
                lst_IncorrectQuestions.Items.AddRange(incorrectQuestions.Select(q => $"{q}").ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btn_ClearAll_Click(object sender, EventArgs e)
        {
            txtBox_FileName.Clear();
            lbl_Results.Text = string.Empty;
            lbl_Correct.Text = string.Empty;
            lbl_Incorrect.Text = string.Empty;
            lst_IncorrectQuestions.Items.Clear();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            // Create an instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*", // Filter for text files
                Title = "Select a File"
            };

            // Show the dialog and check if the user clicked OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path and display it in the TextBox
                txtBox_FileName.Text = openFileDialog.FileName;
            }
        }
    }
}
