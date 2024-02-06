using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MySpecs.fonts;
using MySpecs.info;
using MySpecs.memory;
using MySpecs.usb;

namespace MySpecs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }


        public void addItemToListBox(string item)
        {
            lstbx_fonts.Items.Add(item);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Data.Data.MakeData();
            cmbobx_info_type.SelectedIndex = 0; //add here so we can start with something in the box.
            lbl_version.Text = "v" + Assembly.GetExecutingAssembly().GetName().Version;

            //Populate the data
            os.GetOwnerInfo();
            os.GetOSInfo();
            DiskInfo.GetDiskInfo();

            LoadFonts.ListFonts();

            memory_usage.ShowMemUsage();

            usb_devices.GetUSBInfo();

        }

        private void lstbx_fonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFonts.ShowSampleFont();
        }

        private void cmbobx_info_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cmbobx_info_category.Items.Clear();

            string[] lineOfContents = File.ReadAllLines(cmbobx_info_type.Text + ".txt");

            foreach (var line in lineOfContents)
            {
                cmbobx_info_category.Items.Add(line);
            }

            cmbobx_info_category.SelectedIndex = 0;
        }

        private void cmbobx_info_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            hardware.GetInfo(cmbobx_info_category.Text);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lvwInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
