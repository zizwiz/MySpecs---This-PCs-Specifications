using System.Management;
using System.Windows.Forms;

namespace MySpecs.usb
{
    class usb_devices
    {


        public static void GetUSBInfo()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Form1))
                {
                    Form1 frmTemp = (Form1) frm;

                    ManagementObjectSearcher device_searcher =
                        new ManagementObjectSearcher("SELECT * FROM Win32_USBHub");
                    foreach (ManagementObject usb_device in device_searcher.Get())
                    {
                        ListViewItem new_item = frmTemp.lvwDevices.Items.Add(
                            usb_device.Properties["DeviceID"].Value.ToString());
                        new_item.SubItems.Add(
                            usb_device.Properties["PNPDeviceID"].Value.ToString());
                        new_item.SubItems.Add(
                            usb_device.Properties["Description"].Value.ToString());
                    }
                }
            }
        }
    }
}
