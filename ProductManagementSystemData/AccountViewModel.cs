using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystemData
{
    class AccountViewModel
    {
    }

    public class RegisterViewModel : tblUserMaster
    {
        public string ConfirmPassword { get; set; }
    }
}
