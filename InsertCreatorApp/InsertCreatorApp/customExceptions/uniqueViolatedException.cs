using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsertCreatorApp.customExceptions
{
    public class uniqueViolatedException:Exception
    {
        public uniqueViolatedException()
        {

        }
        public void show()
        {
            MessageBox.Show("unique restriction was violated", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
