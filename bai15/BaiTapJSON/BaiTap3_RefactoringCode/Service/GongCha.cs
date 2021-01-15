using BaiTap3_RefactoringCode.Data;
using BaiTap3_RefactoringCode.Help;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap3_RefactoringCode.Service
{
    class GongCha : BaseService
    {
        public DataRoot dataRoot { get; set; }
        public GongCha()
        {
            dataRoot = Helper.ReadFile<DataRoot>(rootPath);
        }
    }
}
