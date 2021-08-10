using AnydeskHelperUI.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TroubleshooterUI.Utilities.Log.Concrete;

namespace AnydeskHelperUI.Concrete
{
    public class Commands : ICommands
    {
        public SecureString AdminPassword()
        {
            var pass = new SecureString();
            pass.AppendChar('!');
            

            return pass;
        }
        public string FindAnydeskId(string anydesk)
        {
            string path = @"C:\ProgramData\AnyDesk\ad_msi\system.conf";

            IEnumerable<string> lines = File.ReadAllLines(path);

            string input = "anynet.id=";

            IEnumerable<string> matches = !String.IsNullOrEmpty(input)
                                          ? lines.Where(line => line.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                                          : Enumerable.Empty<string>();
            foreach (var match in matches)
            {
                string[] id = Regex.Split(match, @"\W+");
                anydesk = id[3];
            }
            return anydesk;
        }
        public string SetPath(string path)
        {
            string fileName = $"Settings\\settings";

            // Check if file already exists. If yes, delete it.     
            if (!File.Exists(fileName))
            {
                string PathWithCommas = $"\"{path}\"";
                using (FileStream fs = File.Create(fileName))
                {
                    Byte[] title = new UTF8Encoding(true).GetBytes(PathWithCommas);
                    fs.Write(title, 0, title.Length);
                    return path;
                }
            }
            else
            {
                return ReadAnydeskPath(fileName);
            }
        }




        public string ReadAnydeskPath(string fileName)
        {
            return File.ReadAllText(fileName);
        }

        public void Copy(string sourceDir, string targetDir)
        {
            Directory.CreateDirectory(targetDir);

            foreach (var file in Directory.GetFiles(sourceDir))
                File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)), true);

            foreach (var directory in Directory.GetDirectories(sourceDir))
                Copy(directory, Path.Combine(targetDir, Path.GetFileName(directory)));
        }

        public void ProcessStart(string appName)
        {
            var psi = new ProcessStartInfo
            {
                FileName = appName,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };
            Process.Start(psi);
        }

        public void ProcessStart(string appName, string argumentString)
        {
            var psi = new ProcessStartInfo
            {
                FileName = appName,
                Arguments = argumentString,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };
            Process.Start(psi);
        }

        public void CreateBatFile(string password, string anydeskId)
        {
            string fileName = $"Settings\\connectionWithPassword.bat";

            if (File.Exists(fileName))
                File.Delete(fileName);

            using (FileStream fs = File.Create(fileName))
            {
                Byte[] title = new UTF8Encoding(true).GetBytes($"echo {password} | {ReadAnydeskPath("Settings\\settings")} {anydeskId} --with-password");
                fs.Write(title, 0, title.Length);
            }
        }

        public void CreateVPNSettings(string status)
        {
            string fileName = $"Settings\\vpnconnectionstatus";

            if (File.Exists(fileName))
                File.Delete(fileName);

            using (FileStream fs = File.Create(fileName))
            {
                Byte[] title = new UTF8Encoding(true).GetBytes(status);
                fs.Write(title, 0, title.Length);
            }
        }
    }
}
