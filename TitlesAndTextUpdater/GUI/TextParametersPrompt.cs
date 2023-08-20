using ScriptPortal.Vegas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitlesAndTextUpdater.GUI
{
    public partial class TextParametersPrompt : Form
    {
        public TextParametersPrompt()
        {
            InitializeComponent();
        }

        public TextParametersPrompt(OFXParameters parameters)
        {
            InitializeComponent();

            if (parameters.FirstOrDefault(p => p.Name == "TextColor") is OFXRGBAParameter fontColorParam)
            {
                OFXColor color = fontColorParam.Value;
                fontColorButton.BackColor = Color.FromArgb((int)color.A * 255, (int)color.R * 255, (int)color.G * 255, (int)color.B * 255);
                fontColorTextBox.Text = $"{color.R:0.0}, {color.G:0.0}, {color.B:0.0}, {color.A:0.0}";
            }
        }

        private void fontColorButton_Click(object sender, EventArgs e)
        {
            if (fontColorDialog.ShowDialog() == DialogResult.OK)
            {
                fontColorButton.BackColor = fontColorDialog.Color;
                fontColorTextBox.Text = $"{fontColorDialog.Color.R / 255m:0.0}, " +
                                        $"{fontColorDialog.Color.G / 255m:0.0}, " +
                                        $"{fontColorDialog.Color.B / 255m:0.0}, " +
                                        $"{fontColorDialog.Color.A / 255m:0.0}";
            }
        }
    }
}
