using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Mapper
{
    public class BackUpRestoreMapper
    {
        private BackUpRestoreDAL backUp = new BackUpRestoreDAL();
        public void RealizarBackUp(string backupPath)
        {
            backUp.RealizarBackUp(backupPath);
        }
        public void RealizarRestore(string restorePath)
        {
            backUp.RealizarRestore(restorePath);
        }
    }
}
