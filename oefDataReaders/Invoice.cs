using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefDataReaders
{
    class Invoice
    {
        private decimal _creditTotal;
        private DateTime _dueDate;
        private DateTime _invoiceDate;
        private int _invoiceID;
        private string _invoiceNumber;
        private decimal _invoiceTotal;
        private DateTime _paymentDate;
        private decimal _paymentTotal;
        private int _termsID;
        private int _vendorID;

        public Invoice(decimal creditTotal, DateTime dueDate, DateTime invoiceDate, int invoiceID, string invoiceNumber, decimal invoiceTotal, DateTime paymentDate, decimal paymentTotal, int termsID, int vendorID)
        {
            CreditTotal = creditTotal;
            DueDate = dueDate;
            InvoiceDate = invoiceDate;
            InvoiceID = invoiceID;
            InvoiceNumber = invoiceNumber;
            InvoiceTotal = invoiceTotal;
            PaymentDate = paymentDate;
            PaymentTotal = paymentTotal;
            TermsID = termsID;
            VendorID = vendorID;
        }

        public decimal CreditTotal { get => _creditTotal; set => _creditTotal = value; }
        public DateTime DueDate { get => _dueDate; set => _dueDate = value; }
        public DateTime InvoiceDate { get => _invoiceDate; set => _invoiceDate = value; }
        public int InvoiceID { get => _invoiceID; set => _invoiceID = value; }
        public string InvoiceNumber { get => _invoiceNumber; set => _invoiceNumber = value; }
        public decimal InvoiceTotal { get => _invoiceTotal; set => _invoiceTotal = value; }
        public DateTime PaymentDate { get => _paymentDate; set => _paymentDate = value; }
        public decimal PaymentTotal { get => _paymentTotal; set => _paymentTotal = value; }
        public int TermsID { get => _termsID; set => _termsID = value; }
        public int VendorID { get => _vendorID; set => _vendorID = value; }
    }
}
