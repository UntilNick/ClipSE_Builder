using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClipPurSEditionBuilder.License
{
    internal class HardwareID
    {
        public static string GET_ID = ReturnHWID().Result;

        private static async Task<string> ReturnHWID()
        {
            var HardData = new StringBuilder();

            try
            {
                Task.WaitAll((Task)Task.Run(() =>
                {
                    try
                    {
                        using (ManagementObjectCollection ProcessorWin = new ManagementObjectSearcher("SELECT * FROM Win32_Processor").Get())
                        {
                            foreach (ManagementObject obj in ProcessorWin)
                            {
                                HardData.Append(obj["ProcessorId"]?.ToString().Substring(0, 4));
                                break;
                            }
                        }

                        using (ManagementObjectCollection BiosWin = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS").Get())
                        {
                            foreach (ManagementObject bios_Collection in BiosWin)
                            {
                                HardData.Append(bios_Collection["Version"]?.ToString().Substring(0, 4));
                                break;
                            }
                        }

                        using (ManagementObjectCollection HardDrive = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive").Get())
                        {
                            foreach (ManagementObject hdd_Collection in HardDrive)
                            {
                                HardData.Append(hdd_Collection["Signature"]?.ToString().Substring(0, 4));
                                break;
                            }
                        }
                    }
                    catch { }
                }));
            }
            catch { }
            byte[] bytes = null, hashedBytes = null;
            try
            {
                bytes = Encoding.UTF8.GetBytes(HardData?.ToString());
                using (var Hash = SHA256.Create())
                {
                    hashedBytes = Hash.ComputeHash(bytes);
                }

                return await Task.FromResult(Convert.ToBase64String(hashedBytes).Substring(0x19));
            }
            catch { return GET_ID; }
        }
    }
}