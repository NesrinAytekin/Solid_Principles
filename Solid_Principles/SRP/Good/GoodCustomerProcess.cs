using Solid_Principles.SRP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.SRP.Good
{
    public class GoodCustomerProcess
    {
        Logger logger;
        string log;
        public GoodCustomerProcess()
        {
            logger = new Logger();
        }
        public bool InsertCustomer(Customer customer)
        {
            StringBuilder sb  = new StringBuilder();

            try
            {
                sb.Append(customer.Id);
                sb.AppendLine();
                sb.Append(customer.CompanyName);
                sb.AppendLine();
                sb.Append(customer.ContactName);
                sb.AppendLine();
                sb.Append(customer.Address);

                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\Log.txt", log);

                log = logger.BuildLog("Customer Insert Successfull: " + customer.Id);
                logger.LogFile(@"C:\Log.txt", log);

                return true;
            }
            catch (Exception ex)
            {

                log = logger.BuildLog("Error Message:" + ex.Message);
                logger.LogFile(@"C:\Log.txt", log);
                return false;
            }

        }
    }

    
}
