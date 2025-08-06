namespace Numeronym_Generator
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			labelDescription = new Label();
			labelInputDescription = new Label();
			textBoxInput = new TextBox();
			textBoxOutput = new TextBox();
			labelOutputDescriptionn = new Label();
			SuspendLayout();
			// 
			// labelDescription
			// 
			labelDescription.AutoEllipsis = true;
			labelDescription.Location = new Point(12, 9);
			labelDescription.Name = "labelDescription";
			labelDescription.Size = new Size(320, 61);
			labelDescription.TabIndex = 0;
			labelDescription.Text = resources.GetString("labelDescription.Text");
			// 
			// labelInputDescription
			// 
			labelInputDescription.AutoEllipsis = true;
			labelInputDescription.AutoSize = true;
			labelInputDescription.Location = new Point(12, 89);
			labelInputDescription.Name = "labelInputDescription";
			labelInputDescription.Size = new Size(212, 15);
			labelInputDescription.TabIndex = 1;
			labelInputDescription.Text = "Enter a word, e. g. 'internationalization'";
			// 
			// textBoxInput
			// 
			textBoxInput.Location = new Point(12, 107);
			textBoxInput.Name = "textBoxInput";
			textBoxInput.Size = new Size(320, 23);
			textBoxInput.TabIndex = 2;
			textBoxInput.TextChanged += TextBoxInput_TextChanged;
			// 
			// textBoxOutput
			// 
			textBoxOutput.Location = new Point(12, 166);
			textBoxOutput.Name = "textBoxOutput";
			textBoxOutput.ReadOnly = true;
			textBoxOutput.Size = new Size(320, 23);
			textBoxOutput.TabIndex = 4;
			// 
			// labelOutputDescriptionn
			// 
			labelOutputDescriptionn.AutoEllipsis = true;
			labelOutputDescriptionn.AutoSize = true;
			labelOutputDescriptionn.Location = new Point(12, 148);
			labelOutputDescriptionn.Name = "labelOutputDescriptionn";
			labelOutputDescriptionn.Size = new Size(222, 15);
			labelOutputDescriptionn.TabIndex = 3;
			labelOutputDescriptionn.Text = "Your numeronym will be here, e. g. 'i18n'";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(344, 201);
			Controls.Add(textBoxOutput);
			Controls.Add(labelOutputDescriptionn);
			Controls.Add(textBoxInput);
			Controls.Add(labelInputDescription);
			Controls.Add(labelDescription);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Numeronym Generator";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label labelDescription;
		private Label labelInputDescription;
		private TextBox textBoxInput;
		private TextBox textBoxOutput;
		private Label labelOutputDescriptionn;
	}
}
