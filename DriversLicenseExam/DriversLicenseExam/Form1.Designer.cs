namespace DriversLicenseExam
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.txtBox_FileName = new System.Windows.Forms.TextBox();
            this.btn_ReadResults = new System.Windows.Forms.Button();
            this.btn_ClearAll = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Res = new System.Windows.Forms.Label();
            this.lbl_Results = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Correct = new System.Windows.Forms.Label();
            this.lbl_Incorrect = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_IncorrectQuestions = new System.Windows.Forms.ListBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.Location = new System.Drawing.Point(46, 57);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(115, 25);
            this.lbl_FileName.TabIndex = 0;
            this.lbl_FileName.Text = "File Name:";
            this.lbl_FileName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBox_FileName
            // 
            this.txtBox_FileName.Location = new System.Drawing.Point(186, 57);
            this.txtBox_FileName.Name = "txtBox_FileName";
            this.txtBox_FileName.Size = new System.Drawing.Size(300, 31);
            this.txtBox_FileName.TabIndex = 1;
            // 
            // btn_ReadResults
            // 
            this.btn_ReadResults.Location = new System.Drawing.Point(51, 147);
            this.btn_ReadResults.Name = "btn_ReadResults";
            this.btn_ReadResults.Size = new System.Drawing.Size(174, 80);
            this.btn_ReadResults.TabIndex = 2;
            this.btn_ReadResults.Text = "Read Results";
            this.btn_ReadResults.UseVisualStyleBackColor = true;
            this.btn_ReadResults.Click += new System.EventHandler(this.btn_ReadResults_Click);
            // 
            // btn_ClearAll
            // 
            this.btn_ClearAll.Location = new System.Drawing.Point(274, 147);
            this.btn_ClearAll.Name = "btn_ClearAll";
            this.btn_ClearAll.Size = new System.Drawing.Size(174, 80);
            this.btn_ClearAll.TabIndex = 3;
            this.btn_ClearAll.Text = "Clear All";
            this.btn_ClearAll.UseVisualStyleBackColor = true;
            this.btn_ClearAll.Click += new System.EventHandler(this.btn_ClearAll_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(508, 147);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(174, 80);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_Res
            // 
            this.lbl_Res.AutoSize = true;
            this.lbl_Res.Location = new System.Drawing.Point(51, 266);
            this.lbl_Res.Name = "lbl_Res";
            this.lbl_Res.Size = new System.Drawing.Size(90, 25);
            this.lbl_Res.TabIndex = 5;
            this.lbl_Res.Text = "Results:";
            // 
            // lbl_Results
            // 
            this.lbl_Results.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Results.Location = new System.Drawing.Point(51, 333);
            this.lbl_Results.Name = "lbl_Results";
            this.lbl_Results.Size = new System.Drawing.Size(628, 52);
            this.lbl_Results.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total Correct:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Inorrect:";
            // 
            // lbl_Correct
            // 
            this.lbl_Correct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Correct.Location = new System.Drawing.Point(51, 491);
            this.lbl_Correct.Name = "lbl_Correct";
            this.lbl_Correct.Size = new System.Drawing.Size(285, 52);
            this.lbl_Correct.TabIndex = 9;
            this.lbl_Correct.Click += new System.EventHandler(this.lbl_Correct_Click);
            // 
            // lbl_Incorrect
            // 
            this.lbl_Incorrect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Incorrect.Location = new System.Drawing.Point(403, 491);
            this.lbl_Incorrect.Name = "lbl_Incorrect";
            this.lbl_Incorrect.Size = new System.Drawing.Size(285, 52);
            this.lbl_Incorrect.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 646);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Incorrect Questions:";
            // 
            // lst_IncorrectQuestions
            // 
            this.lst_IncorrectQuestions.FormattingEnabled = true;
            this.lst_IncorrectQuestions.ItemHeight = 25;
            this.lst_IncorrectQuestions.Location = new System.Drawing.Point(51, 703);
            this.lst_IncorrectQuestions.Name = "lst_IncorrectQuestions";
            this.lst_IncorrectQuestions.Size = new System.Drawing.Size(637, 379);
            this.lst_IncorrectQuestions.TabIndex = 12;
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(538, 57);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(144, 36);
            this.btn_Browse.TabIndex = 14;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 1141);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.lst_IncorrectQuestions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Incorrect);
            this.Controls.Add(this.lbl_Correct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Results);
            this.Controls.Add(this.lbl_Res);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_ClearAll);
            this.Controls.Add(this.btn_ReadResults);
            this.Controls.Add(this.txtBox_FileName);
            this.Controls.Add(this.lbl_FileName);
            this.Name = "Form1";
            this.Text = "Drivers License Exam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_FileName;
        private System.Windows.Forms.TextBox txtBox_FileName;
        private System.Windows.Forms.Button btn_ReadResults;
        private System.Windows.Forms.Button btn_ClearAll;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Res;
        private System.Windows.Forms.Label lbl_Results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Correct;
        private System.Windows.Forms.Label lbl_Incorrect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_IncorrectQuestions;
        private System.Windows.Forms.Button btn_Browse;
    }
}

