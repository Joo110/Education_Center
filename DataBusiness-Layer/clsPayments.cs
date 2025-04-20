using DataAccessLayar_EC_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusiness_EC_
{
    public class clsPayments
    {
        public static DataTable GetAllPayments()
        {
            return clsPaymentsData.GetAllPayments();
        }

        public static int Count()
            => clsPaymentsData.GetAllPaymentsCount();
    }
}
