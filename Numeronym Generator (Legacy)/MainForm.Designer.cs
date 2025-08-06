namespace Numeronym_Generator_Legacy
{
	partial class NumeronymGeneratorForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumeronymGeneratorForm));
			this.labelDescription = new System.Windows.Forms.Label();
			this.textBoxInput = new System.Windows.Forms.TextBox();
			this.labelInputDescription = new System.Windows.Forms.Label();
			this.labelOutputDescription = new System.Windows.Forms.Label();
			this.textBoxOutput = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// labelDescription
			// 
			this.labelDescription.AutoEllipsis = true;
			this.labelDescription.Location = new System.Drawing.Point(12, 9);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(320, 60);
			this.labelDescription.TabIndex = 0;
			this.labelDescription.Text = resources.GetString("labelDescription.Text");
			// 
			// textBoxInput
			// 
			this.textBoxInput.Location = new System.Drawing.Point(12, 89);
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.Size = new System.Drawing.Size(320, 20);
			this.textBoxInput.TabIndex = 2;
			this.textBoxInput.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
			// 
			// labelInputDescription
			// 
			this.labelInputDescription.AutoEllipsis = true;
			this.labelInputDescription.AutoSize = true;
			this.labelInputDescription.Location = new System.Drawing.Point(13, 73);
			this.labelInputDescription.Name = "labelInputDescription";
			this.labelInputDescription.Size = new System.Drawing.Size(188, 13);
			this.labelInputDescription.TabIndex = 1;
			this.labelInputDescription.Text = "Enter a word, e. g. \'internationalization\'";
			// 
			// labelOutputDescription
			// 
			this.labelOutputDescription.AutoEllipsis = true;
			this.labelOutputDescription.AutoSize = true;
			this.labelOutputDescription.Location = new System.Drawing.Point(14, 153);
			this.labelOutputDescription.Name = "labelOutputDescription";
			this.labelOutputDescription.Size = new System.Drawing.Size(196, 13);
			this.labelOutputDescription.TabIndex = 3;
			this.labelOutputDescription.Text = "Your numeronym will be here, e. g. \'i18n\'";
			// 
			// textBoxOutput
			// 
			this.textBoxOutput.Location = new System.Drawing.Point(12, 169);
			this.textBoxOutput.Name = "textBoxOutput";
			this.textBoxOutput.ReadOnly = true;
			this.textBoxOutput.Size = new System.Drawing.Size(320, 20);
			this.textBoxOutput.TabIndex = 4;
			// 
			// NumeronymGeneratorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 201);
			this.Controls.Add(this.labelOutputDescription);
			this.Controls.Add(this.textBoxOutput);
			this.Controls.Add(this.labelInputDescription);
			this.Controls.Add(this.textBoxInput);
			this.Controls.Add(this.labelDescription);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "NumeronymGeneratorForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Numeronym Generator (Legacy)";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.TextBox textBoxInput;
		private System.Windows.Forms.Label labelInputDescription;
		private System.Windows.Forms.Label labelOutputDescription;
		private System.Windows.Forms.TextBox textBoxOutput;
	}
}

