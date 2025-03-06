using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

public static class Prompt
{
    public static string ShowDialog(string text, string caption)
    {
        Form prompt = new Form()
        {
            Width = 300,
            Height = 150,
            Text = caption
        };

        Label lblText = new Label() { Left = 10, Top = 20, Text = text, Width = 250 };
        TextBox textBox = new TextBox() { Left = 10, Top = 50, Width = 250 };
        Button btnOk = new Button() { Text = "OK", Left = 200, Top = 80, Width = 60 };
        btnOk.Click += (sender, e) => { prompt.Close(); };

        prompt.Controls.Add(lblText);
        prompt.Controls.Add(textBox);
        prompt.Controls.Add(btnOk);

        prompt.ShowDialog();
        return textBox.Text;
    }
}


