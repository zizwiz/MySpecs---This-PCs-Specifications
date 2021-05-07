using System;
using System.Drawing;
using System.Management;
using System.Windows.Forms;
using CenteredMessagebox;

namespace MySpecs.info
{
    class hardware
    {

        public static void GetInfo(string Key)
        {

            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Form1))
                {
                    Form1 frmTemp = (Form1) frm;

                    frmTemp.lstview_data.Items.Clear();

                    ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_" + Key);

                    try
                    {
                        foreach (ManagementObject share in searcher.Get())
                        {
                            ListViewGroup grp;

                            try
                            {
                                grp = frmTemp.lstview_data.Groups.Add(share["Name"].ToString(), share["Name"].ToString());
                            }
                            catch
                            {
                                grp = frmTemp.lstview_data.Groups.Add(share.ToString(), share.ToString());
                            }

                            if (share.Properties.Count <= 0)
                            {
                                MsgBox.Show("No Information Available", "No Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            foreach (PropertyData PC in share.Properties)
                            {

                                ListViewItem item = new ListViewItem(grp);
                                if (frmTemp.lstview_data.Items.Count % 2 != 0)
                                    item.BackColor = Color.White;
                                else
                                    item.BackColor = Color.WhiteSmoke;

                                item.Text = PC.Name;

                                if (PC.Value != null && PC.Value.ToString() != "")
                                {
                                    switch (PC.Value.GetType().ToString())
                                    {
                                        case "System.String[]":
                                            string[] str = (string[])PC.Value;

                                            string str2 = "";
                                            foreach (string st in str)
                                                str2 += st + " ";

                                            item.SubItems.Add(str2);

                                            break;
                                        case "System.UInt16[]":
                                            ushort[] shortData = (ushort[])PC.Value;


                                            string tstr2 = "";
                                            foreach (ushort st in shortData)
                                                tstr2 += st.ToString() + " ";

                                            item.SubItems.Add(tstr2);

                                            break;

                                        default:
                                            item.SubItems.Add(PC.Value.ToString());
                                            break;
                                    }
                                }
                                
                                frmTemp.lstview_data.Items.Add(item);
                            }
                        }
                    }


                    catch (Exception exp)
                    {
                        MsgBox.Show("No Data\n" + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //Resize the list view columns
                    int HeaderWidth = (frmTemp.lstview_data.Parent.Width - 2) / frmTemp.lstview_data.Columns.Count;
                    foreach (ColumnHeader header in frmTemp.lstview_data.Columns)
                    {
                        header.Width = HeaderWidth;
                    }

                }
            }
        }
    }
}
