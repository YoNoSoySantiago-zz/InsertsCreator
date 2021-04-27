using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsertCreatorApp.customExceptions
{
    public class notNullViolatedException:Exception
    {
        
        public notNullViolatedException()
        {
            
        }
        public void show()
        {
            MessageBox.Show("non-null restriction was violated", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
