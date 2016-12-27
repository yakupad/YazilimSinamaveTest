using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimSinamaveTest
{
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }
        yazilimsinamaEntities db = new yazilimsinamaEntities();
        private void frmLog_Load(object sender, EventArgs e)
        {
            foreach (var item in db.tblUserLogDetails)
            {
                listBox1.Items.Add(item.UserLogsID+"--> ["+item.LogDate + "] " + item.Username + "  " + item.UserLogDescription);
            }
        }
    }
}
