using Solid_Principles.SRP.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.SRP.Bad
{
    public class BadCustomerProcess
    {
        public void InsertCustomer(Customer newCustomer)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                //Adding  new Customer
                sb.Append(newCustomer.Id);
                sb.AppendLine();
                sb.Append(newCustomer.CompanyName);
                sb.AppendLine();
                sb.Append(newCustomer.ContactName);
                sb.AppendLine();
                sb.Append(newCustomer.Address);
                File.WriteAllText(@"C:\CustomerData.txt", sb.ToString());

                //Keeping logs of adding process:
                sb = new StringBuilder();
                sb.Append("Registration Elimination Date: ");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Customer Id:");
                sb.Append(newCustomer.Id);
                sb.AppendLine();
                sb.Append("Company Name:");
                sb.Append(newCustomer.CompanyName);
                sb.AppendLine();
                sb.Append("ContactName: ");
                sb.Append(newCustomer.ContactName);
                sb.AppendLine();
                sb.Append("Customer Address: ");
                sb.Append(newCustomer.Address);
                File.WriteAllText(@"C:\CustomerLog.txt", sb.ToString());


            }
            catch (Exception ex)
            {
                //Failure to keep error logs if an error is added in the add operation
                sb = new StringBuilder();
                sb.Append("Error Date:");
                sb.Append(DateTime.Now);
                sb.AppendLine();
                sb.Append("Eror Message: ");
                sb.Append(ex.Message);
                File.WriteAllText(@"C:\CustomerLog.txt", sb.ToString());
                System.Windows.Forms.MessageBox.Show("Eror..!");

            }
        }
        
    }

    
}
