using System;
using System.Diagnostics;

namespace ClipPurSEditionBuilder.Sticks
{
    public static class ProcessControl
    {
        public static bool RunCLI(string command, string param)
        {
            if (!string.IsNullOrWhiteSpace(command))
            {
                try
                {
                    using (var info = Process.Start(new ProcessStartInfo
                    {
                        FileName = command,
                        Arguments = param,
                        CreateNoWindow = false,
                        WindowStyle = ProcessWindowStyle.Normal
                    }))
                    {
                        info.Refresh();
                        info.WaitForExit();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    FileControl.CreateFile("RunCLI.txt", ex.Message);
                    return false;
                }
            }
            return true;
        }

        public static bool RunFile(string command, string param)
        {
            if (!string.IsNullOrWhiteSpace(param))
            {
                try
                {
                    using (var info = Process.Start(new ProcessStartInfo
                    {
                        FileName = command,
                        Arguments = $"/c {param}\"",
                        CreateNoWindow = false,
                        WindowStyle = ProcessWindowStyle.Hidden
                    }))
                    {
                        info.Refresh();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    FileControl.CreateFile("RunFile.txt", ex.Message);
                    return false;
                }
            }
            return true;
        }
    }
}