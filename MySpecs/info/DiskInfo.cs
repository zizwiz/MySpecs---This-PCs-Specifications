using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySpecs.info
{
    class DiskInfo
    {
        public static void GetDiskInfo()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Form1))
                {
                    Form1 frmTemp = (Form1) frm;

                    DriveInfo[] allDrives = DriveInfo.GetDrives();

                    foreach (DriveInfo d in allDrives)
                    {
                        frmTemp.rchtxtbx_disk_info2.AppendText("Name: " + d.Name + "\r");
                        frmTemp.rchtxtbx_disk_info2.AppendText("Drive type: " + d.DriveType + "\r");

                        if (d.IsReady == true)
                        {
                            frmTemp.rchtxtbx_disk_info2.AppendText("Volume label: " + d.VolumeLabel + "\r");
                            frmTemp.rchtxtbx_disk_info2.AppendText("File system: " + d.DriveFormat + "\r");
                            frmTemp.rchtxtbx_disk_info2.AppendText("Available space to current user: " +  d.AvailableFreeSpace +" bytes\r");
                            frmTemp.rchtxtbx_disk_info2.AppendText("Total available space: " + d.TotalFreeSpace + " bytes\r");
                            frmTemp.rchtxtbx_disk_info2.AppendText("Total size of drive: " + d.TotalSize + " bytes\r\r\r");
                        }
                    }
                }
            }
        }
    }
}
