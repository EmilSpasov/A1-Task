using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using A1Db.Data;
using A1Db.Data.Models;
using LumenWorks.Framework.IO.Csv;

namespace A1Db
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new A1DbContext();

            context.Database.EnsureCreated();

            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Files\offers.csv");

            var csvTable = new DataTable();
           
            using (var csvReader = new CsvReader(new StreamReader(File.OpenRead(path)), true))
            {
                csvTable.Load(csvReader);
            }
            
            var data = new List<Offer>();

            csvTable.Columns.Add("val");

            for (int i = 0; i < csvTable.Rows.Count; i++)
            {
                var column1 = csvTable.Rows[i][0].ToString();
                var column2 = csvTable.Rows[i][1].ToString();

                var currentRow = string.Join(".", new string[] { column1, column2 }.Where(s => !string.IsNullOrEmpty(s)));
              
                var values = currentRow.Split(";");

                var id = int.Parse(values[0]);
                var monthlyFee = double.Parse(values[1]);
                var newContactsForMonth = int.Parse(values[2]);
                var sameContactsForMonth = int.Parse(values[3]);
                var cancelledContactsForMonth = int.Parse(values[4]);

                var offer = new Offer
                {
                    MonthlyFee = monthlyFee,
                    NewContractsForMonth = newContactsForMonth,
                    SameContractsForMonth = sameContactsForMonth,
                    CancelledContractsForMonth = cancelledContactsForMonth,
                };

                if (context.Offers.All(x => x.Id != id))
                {
                    data.Add(offer);
                }
            }

            context.Offers.AddRange(data);
            context.SaveChanges();
        }
    }
}
