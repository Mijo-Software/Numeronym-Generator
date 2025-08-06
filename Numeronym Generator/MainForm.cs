namespace Numeronym_Generator
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private static string ToNumeronym(string word)
		{
			if (string.IsNullOrWhiteSpace(value: word) || word.Length <= 2)
			{
				return word;
			}

			int middleCount = word.Length - 2;
			return $"{word[index: 0]}{middleCount}{word[^1]}";
		}

		private void TextBoxInput_TextChanged(object sender, EventArgs e)
		{
			textBoxOutput.Text = string.Join(separator: " ",
				value: textBoxInput.Text.Split(separator: ' ')
				.Select(selector: word => ToNumeronym(word: word))
				.ToArray());

		}
	}
}
