using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using RegisteredOwnerInfo;
using Microsoft.Win32;

namespace MySpecs.info
{
    class os
    {
        public static void GetOSInfo()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Form1))
                {
                    Form1 frmTemp = (Form1) frm;


                    // Get OS info
                    frmTemp.lbl_os_desc.Text = "OS = " + RuntimeInformation.OSDescription;
                    frmTemp.lbl_os_arch.Text = "OS Architecture = " + RuntimeInformation.OSArchitecture.ToString();
                    frmTemp.lbl_framework.Text = "Framework = " + RuntimeInformation.FrameworkDescription;
                    frmTemp.lbl_process_arch.Text =
                        "Processor Architecture = " + RuntimeInformation.ProcessArchitecture.ToString();

                }
            }
        }

        public static void GetOwnerInfo()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Form1))
                {
                    Form1 frmTemp = (Form1)frm;

                    //Get Owner and Company
                    object owner_string = "", company_string = "";
                    OperatingSystem os_info = System.Environment.OSVersion;
                    if (os_info.Platform == PlatformID.Win32Windows)
                    {
                        // Windows 98?
                        owner_string = RegistryTools.GetRegistryValue(
                            Registry.LocalMachine,
                            @"SOFTWARE\Microsoft\Windows\CurrentVersion\",
                            "RegisteredOwner", "Unknown");
                        company_string = RegistryTools.GetRegistryValue(
                            Registry.LocalMachine,
                            @"SOFTWARE\Microsoft\Windows\CurrentVersion\",
                            "RegisteredOrganization", "Unknown");
                    }
                    else if (os_info.Platform == PlatformID.Win32NT)
                    {
                        // Windows NT.
                        owner_string = RegistryTools.GetRegistryValue(
                            Registry.LocalMachine,
                            @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\",
                            "RegisteredOwner", "Unknown");
                        company_string = RegistryTools.GetRegistryValue(
                            Registry.LocalMachine,
                            @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\",
                            "RegisteredOrganization", "Unknown");
                    }

                    frmTemp.lbl_owner_name.Text = "Owner = " + owner_string;
                    frmTemp.lbl_owner_company.Text = "Company = " + company_string;
                }
            }
        }
    }
}
