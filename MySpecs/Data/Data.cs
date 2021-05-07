using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySpecs.Properties;

namespace MySpecs.Data
{
    class Data
    {

        public static void MakeData()
        {
            //To Do put this into a loop.

            string data = Resources.Hardware_Info;
            byte[] info = new UTF8Encoding(true).GetBytes(data);
            FileStream fs = new FileStream(Path.GetFullPath(Application.StartupPath + "\\Hardware Info.txt"), FileMode.OpenOrCreate);
            fs.Write(info, 0, info.Length);
            fs.Close();

            data = Resources.Account_Info;
            info = new UTF8Encoding(true).GetBytes(data);
            fs = new FileStream(Path.GetFullPath(Application.StartupPath + "\\Account Info.txt"), FileMode.OpenOrCreate);
            fs.Write(info, 0, info.Length);
            fs.Close();

            data = Resources.Data_Storage;
            info = new UTF8Encoding(true).GetBytes(data);
            fs = new FileStream(Path.GetFullPath(Application.StartupPath + "\\Data Storage.txt"), FileMode.OpenOrCreate);
            fs.Write(info, 0, info.Length);
            fs.Close();

            data = Resources.Developer;
            info = new UTF8Encoding(true).GetBytes(data);
            fs = new FileStream(Path.GetFullPath(Application.StartupPath + "\\Developer.txt"), FileMode.OpenOrCreate);
            fs.Write(info, 0, info.Length);
            fs.Close();

            data = Resources.Memory;
            info = new UTF8Encoding(true).GetBytes(data);
            fs = new FileStream(Path.GetFullPath(Application.StartupPath + "\\Memory.txt"), FileMode.OpenOrCreate);
            fs.Write(info, 0, info.Length);
            fs.Close();

            data = Resources.Network;
            info = new UTF8Encoding(true).GetBytes(data);
            fs = new FileStream(Path.GetFullPath(Application.StartupPath + "\\Network.txt"), FileMode.OpenOrCreate);
            fs.Write(info, 0, info.Length);
            fs.Close();

            data = Resources.System_Info;
            info = new UTF8Encoding(true).GetBytes(data);
            fs = new FileStream(Path.GetFullPath(Application.StartupPath + "\\System Info.txt"), FileMode.OpenOrCreate);
            fs.Write(info, 0, info.Length);
            fs.Close();

            data = Resources.Utility;
            info = new UTF8Encoding(true).GetBytes(data);
            fs = new FileStream(Path.GetFullPath(Application.StartupPath + "\\Utility.txt"), FileMode.OpenOrCreate);
            fs.Write(info, 0, info.Length);
            fs.Close();
        }
    }
}
