using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsertCreatorApp.customExceptions
{
    class valueTooLargeException:Exception
    {
        public valueTooLargeException()
        {

        }
        public void show()
        {
            MessageBox.Show("value too large", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
