namespace JJ.Presentation.QuestionAndAnswer.WinForms
{
	partial class RandomQuestionForm
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
			this.buttonShowAnswer = new System.Windows.Forms.Button();
			this.labelQuestion = new System.Windows.Forms.Label();
			this.buttonNextQuestion = new System.Windows.Forms.Button();
			this.labelAnswerText = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.labelAnswerTitle = new System.Windows.Forms.Label();
			this.textBoxUserAnswer = new System.Windows.Forms.TextBox();
			this.buttonHideAnswer = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonShowAnswer
			// 
			this.buttonShowAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonShowAnswer.Location = new System.Drawing.Point(147, 380);
			this.buttonShowAnswer.Name = "buttonShowAnswer";
			this.buttonShowAnswer.Size = new System.Drawing.Size(94, 30);
			this.buttonShowAnswer.TabIndex = 0;
			this.buttonShowAnswer.Text = "buttonShowAnser";
			this.buttonShowAnswer.UseVisualStyleBackColor = true;
			this.buttonShowAnswer.Click += new System.EventHandler(this.buttonShowAnswer_Click);
			// 
			// labelQuestion
			// 
			this.labelQuestion.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelQuestion.Location = new System.Drawing.Point(10, 10);
			this.labelQuestion.Name = "labelQuestion";
			this.labelQuestion.Size = new System.Drawing.Size(580, 56);
			this.labelQuestion.TabIndex = 1;
			this.labelQuestion.Text = "labelQuestion";
			// 
			// buttonNextQuestion
			// 
			this.buttonNextQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonNextQuestion.Location = new System.Drawing.Point(363, 380);
			this.buttonNextQuestion.Name = "buttonNextQuestion";
			this.buttonNextQuestion.Size = new System.Drawing.Size(94, 30);
			this.buttonNextQuestion.TabIndex = 2;
			this.buttonNextQuestion.Text = "buttonNextQuestion";
			this.buttonNextQuestion.UseVisualStyleBackColor = true;
			this.buttonNextQuestion.Click += new System.EventHandler(this.buttonNextQuestion_Click);
			// 
			// labelAnswerText
			// 
			this.labelAnswerText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAnswerText.Location = new System.Drawing.Point(99, 141);
			this.labelAnswerText.Name = "labelAnswerText";
			this.labelAnswerText.Padding = new System.Windows.Forms.Padding(6);
			this.labelAnswerText.Size = new System.Drawing.Size(469, 136);
			this.labelAnswerText.TabIndex = 5;
			this.labelAnswerText.Text = "labelAnswerText";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.labelAnswerTitle, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBoxUserAnswer, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelAnswerText, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 81);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(6);
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(577, 283);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// labelAnswerTitle
			// 
			this.labelAnswerTitle.AutoSize = true;
			this.labelAnswerTitle.Location = new System.Drawing.Point(9, 6);
			this.labelAnswerTitle.Name = "labelAnswerTitle";
			this.labelAnswerTitle.Size = new System.Drawing.Size(84, 13);
			this.labelAnswerTitle.TabIndex = 4;
			this.labelAnswerTitle.Text = "labelAnswerTitle";
			// 
			// textBoxUserAnswer
			// 
			this.textBoxUserAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxUserAnswer.Location = new System.Drawing.Point(99, 9);
			this.textBoxUserAnswer.Multiline = true;
			this.textBoxUserAnswer.Name = "textBoxUserAnswer";
			this.textBoxUserAnswer.Size = new System.Drawing.Size(469, 129);
			this.textBoxUserAnswer.TabIndex = 5;
			this.textBoxUserAnswer.TextChanged += new System.EventHandler(this.textBoxUserAnswer_TextChanged);
			// 
			// buttonHideAnswer
			// 
			this.buttonHideAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonHideAnswer.Location = new System.Drawing.Point(147, 380);
			this.buttonHideAnswer.Name = "buttonHideAnswer";
			this.buttonHideAnswer.Size = new System.Drawing.Size(94, 30);
			this.buttonHideAnswer.TabIndex = 7;
			this.buttonHideAnswer.Text = "buttonHideAnser";
			this.buttonHideAnswer.UseVisualStyleBackColor = true;
			this.buttonHideAnswer.Click += new System.EventHandler(this.buttonHideAnswer_Click);
			// 
			// RandomQuestionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 423);
			this.Controls.Add(this.buttonHideAnswer);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.buttonNextQuestion);
			this.Controls.Add(this.labelQuestion);
			this.Controls.Add(this.buttonShowAnswer);
			this.Name = "RandomQuestionForm";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RandomQuestionForm_FormClosed);
			this.Load += new System.EventHandler(this.RandomQuestionForm_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonShowAnswer;
		private System.Windows.Forms.Label labelQuestion;
		private System.Windows.Forms.Button buttonNextQuestion;
		private System.Windows.Forms.Label labelAnswerText;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label labelAnswerTitle;
		private System.Windows.Forms.TextBox textBoxUserAnswer;
		private System.Windows.Forms.Button buttonHideAnswer;
	}
}

