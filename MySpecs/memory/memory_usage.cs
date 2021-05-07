using System.Windows.Forms;
using howto_listview_extensions;
using howto_show_computer_memory;
using System.Management;

namespace MySpecs.memory
{
    class memory_usage
    {


        // Prepare the ListView and display values.
        public static void ShowMemUsage()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Form1))
                {
                    Form1 frmTemp = (Form1)frm;

                    // Make the columns.
                    frmTemp.lvwInfo.View = View.Details;
                    frmTemp.lvwInfo.SetColumnHeaders(new object[]
            {
                "Property", HorizontalAlignment.Left,
                "Value", HorizontalAlignment.Right
            });

            // Add the values.
            ManagementObjectSearcher os_searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

            foreach (ManagementObject mobj in os_searcher.Get())
            {
                GetInfo(mobj, "FreePhysicalMemory");
                GetInfo(mobj, "FreeSpaceInPagingFiles");
                GetInfo(mobj, "FreeVirtualMemory");
                GetInfo(mobj, "SizeStoredInPagingFiles");
                GetInfo(mobj, "TotalSwapSpaceSize");
                GetInfo(mobj, "TotalVirtualMemorySize");
                GetInfo(mobj, "TotalVisibleMemorySize");
            }

            // Size the columns.
            frmTemp.lvwInfo.SizeColumnsToFitDataAndHeaders();
        }
    }
}



        // Add information about the property to the ListView.
        private static void GetInfo(ManagementObject mobj, string property_name)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Form1))
                {
                    Form1 frmTemp = (Form1)frm;


                    object property_obj = mobj[property_name];
                    if (property_obj == null)
                    {
                        frmTemp.lvwInfo.AddRow(property_name, "");
                    }
                    else
                    {
                        ulong property_value = (ulong)property_obj * 1024;
                        frmTemp.lvwInfo.AddRow(property_name,
                            property_value.ToFileSizeApi());
                    }
                }
            }
        }





    }
}
