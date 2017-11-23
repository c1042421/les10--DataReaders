using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace oefDataReaders
{
    class DM_Invoice
    {

      
        public static List<Invoice> GetInvoices()
        {
            List<Invoice> invoices = new List<Invoice>();
            OleDbConnection con;
            OleDbCommand cmd;

            try
            {
                decimal creditTotal, invoiceTotal, paymentTotal;
                int termsId, vendorId, invoiceID;
                DateTime dueDate, invoiceDate, paymentDate;

                con = new OleDbConnection(Properties.Settings.Default.conString);
                cmd = new OleDbCommand("select * from Invoices", con);

                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    decimal.TryParse(reader["CreditTotal"].ToString(), out creditTotal);
                    decimal.TryParse(reader["InvoiceTotal"].ToString(), out invoiceTotal);
                    decimal.TryParse(reader["PaymentTotal"].ToString(), out paymentTotal);
                    int.TryParse(reader["TermsID"].ToString(), out termsId);
                    int.TryParse(reader["VendorID"].ToString(), out vendorId);
                    int.TryParse(reader["InvoiceID"].ToString(), out invoiceID);
                    DateTime.TryParse(reader["InvoiceDate"].ToString(), out invoiceDate);
                    DateTime.TryParse(reader["DueDate"].ToString(), out dueDate);
                    DateTime.TryParse(reader["PaymentDate"].ToString(), out paymentDate);

                    invoices.Add(new Invoice(creditTotal, dueDate, invoiceDate, invoiceID, reader["InvoiceNumber"].ToString(), invoiceTotal, paymentDate, paymentTotal, termsId, vendorId));
                }
                con.Close();
            }
            catch (Exception e)
            {
                throw e;
            }

            return invoices;
        }
      
        public static decimal GetTotalBalanceDue()
        {
            return (decimal)0.0;
        }

        public static decimal GetVendorBalanceDue(int vendorID)
        {
            return (decimal)0.0;
        }

        public List<Invoice> GetVendorInvoices()
        {
            List<Invoice> invoices = new List<Invoice>();
            return invoices;
        }

    }
}
