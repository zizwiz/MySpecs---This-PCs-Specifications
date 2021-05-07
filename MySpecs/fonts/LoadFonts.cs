using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using CenteredMessagebox;

namespace MySpecs.fonts
{
    class LoadFonts
    {
        

        public static void ListFonts()
        {
            //Change Form1 to whatever your form is called
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Form1))
                {
                    Form1 frmTemp = (Form1)frm;
                    
                    // List the font families.
                    InstalledFontCollection installedFonts = new InstalledFontCollection();

                    foreach (FontFamily fontFamily in installedFonts.Families)
                    {
                        frmTemp.addItemToListBox(fontFamily.Name);
                    }

                    frmTemp.lstbx_fonts.SelectedIndex = 0;
                }
            }

            
        }


        // Display a sample of the selected font.
        public static void ShowSampleFont()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Form1))
                {
                    Form1 frmTemp = (Form1) frm;

                    // Display the font family's name.
                    frmTemp.lbl_fonts.Text = frmTemp.lstbx_fonts.Text;

                    float font_size = 20;
                    if (frmTemp.txtbx_size.Text == "") frmTemp.lbl_fonts.Text = "";
                        if (frmTemp.txtbx_size.Text != "") font_size = float.Parse(frmTemp.txtbx_size.Text);
                    if (font_size > 36)
                    {
                        font_size = 20;
                        frmTemp.txtbx_size.Text = "36";
                        MsgBox.Show("Max Size allowed is 36", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Compose the font style.
                    FontStyle font_style = FontStyle.Regular;
                    if (frmTemp.chkbx_bold.Checked) font_style |= FontStyle.Bold;
                    if (frmTemp.chkbx_italic.Checked) font_style |= FontStyle.Italic;
                    if (frmTemp.chk_underline.Checked) font_style |= FontStyle.Underline;
                    if (frmTemp.chkbx_strikethough.Checked) font_style |= FontStyle.Strikeout;
                    
                    // Use the font but drop through till you find correct style.
                    Font font = MakeFont(frmTemp.lstbx_fonts.Text, font_size, font_style);
                    if (font != null)
                    {
                        frmTemp.lbl_fonts.Font = font;
                    }
                    else
                    {
                        MsgBox.Show("Font Does Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Make a font with the given family name, size, and style.
        private static Font MakeFont(string family, float size, FontStyle style)
        {
            try
            {
                return new Font(family, size, style);
            }
            catch
            {
                return null;
            }
        }
    }
}
