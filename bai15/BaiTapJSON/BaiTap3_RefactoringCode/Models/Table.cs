using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap3_RefactoringCode.Models
{
    class Table
    {
        public int tableID { get; set; }
        public bool isPaid { get; set; }

        public Table(int tableId)
        {
            this.tableID = tableId;
            isPaid = false;
        }
    }
}
