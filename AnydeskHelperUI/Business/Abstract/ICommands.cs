using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnydeskHelperUI.Abstract
{
   public interface ICommands
    {
        SecureString AdminPassword();
        string SetPath(string path);
        string FindAnydeskId(string anydesk);
        string ReadAnydeskPath(string fileName);
        void ProcessStart(string appName);
        void ProcessStart(string appName, string argumentString);
        void Copy(string sourceDir, string targetDir);
        void CreateBatFile(string password, string anydeskId);
        void CreateVPNSettings(string status);
    }
}
