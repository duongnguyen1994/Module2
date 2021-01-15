using BaiTap3_RefactoringCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap3_RefactoringCode.Data
{
    class DataRoot
    {
        public List<Drink> drinks { get; set; }
        public List<Table> tables { get; set; }
    }
}
