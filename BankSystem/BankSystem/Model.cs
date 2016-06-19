using System;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text;

namespace BankSystem
{
    class Model
    {
        string connectionString = @"Data Source = Alice-PC\SQLEXPRESS; Initial Catalog = BankSystem; Integrated Security = True;";

        public bool SaveDBToFile(Func<string, string, string, bool> sectionSaver)
        {
            bool success = false;
            bool successOfDebitorsSaving = sectionSaver("Debitors.csv", "Debitors", @"""ID"";""Name"";""Post Index"";""Phone Number""") ;
            bool successOfCreditsSaving=sectionSaver("Credits.csv", "Credits", @"""ID"";""DebitorID"";""Amount"";""Balance"";""Open Date""") ;
            bool successOfPaymentsSaving= sectionSaver("Payments.csv", "Payments", @"""ID"";""CreditID"";""Amount"";""Payment Date""");

            if (successOfDebitorsSaving == true && successOfCreditsSaving == true && successOfPaymentsSaving == true)
                success = true;
            else
                success = false;

            return success;
        }

        public bool SaveDBSection(string filename, string section, string header)
        {
            bool success;
            var file = new StreamWriter(new FileStream(filename, FileMode.Create), Encoding.GetEncoding(1251));
            string query;

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    query = string.Format("SELECT * FROM {0}",section);
                    var command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    file.WriteLine("File begins");
                    file.WriteLine(header);

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            
                            var cortage = new StringBuilder();
                            
                            for (int i=0; i < reader.FieldCount; i++)
                            {
                                //var date = new DateTime();
                                //if (reader.GetValue(i).GetType() == date.GetType())
                                //    cortage.Append(reader.GetDateTime(i).ToString());
                                //else
                                cortage.Append(reader.GetValue(i).ToString());
                                if (i != reader.FieldCount - 1)
                                    cortage.Append(@""";""");
                               
                            }                          
                            

                            file.WriteLine(@"""" + cortage.ToString() + @"""", Encoding.ASCII);
                                                       
                        }
                    }

                    else
                    {
                        file.WriteLine("No data to save");
                    }

                    file.WriteLine("End of file");

                    file.Dispose();
                    success = true;
                }

                catch
                {
                    success = false;
                }
            }

            return success;
        }

        public ArrayList GetAllDebitors()
        {
            var allDebitors = new ArrayList();
            using (var connection = new SqlConnection(connectionString))
            {            
            var allDebitosrSelection = new SqlCommand("SELECT * FROM Debitors ORDER BY Name", connection);
                try {
                    connection.Open();
                    var dataReader = allDebitosrSelection.ExecuteReader();



                    if (dataReader.HasRows)
                    {
                        foreach (var result in dataReader)
                            allDebitors.Add(result);
                    }
                }
                catch
                {

                }

            //connection.Dispose();
        }
            return allDebitors;
        }

        internal ArrayList GetAllCreditsOfDebitor(string debitorID)
        {
            var allCreditsOfDebitor = new ArrayList();
            using (var connection = new SqlConnection(connectionString))
            {
                string query = String.Format("SELECT * FROM Credits WHERE DebitorID='{0}' ORDER BY OpenDate", debitorID);
                var selection = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    var dataReader = selection.ExecuteReader();
                    foreach (var e in dataReader)
                    {
                        allCreditsOfDebitor.Add(e);
                    }
                }
                catch (Exception)
                {

                    throw new Exception();
                }
               
            }
            return allCreditsOfDebitor;
        }

        internal object GetAllPaymentsForCredit(string creditID)
        {
            var allPayments = new ArrayList();
            using (var connection = new SqlConnection(connectionString))
            {
                string query = String.Format("SELECT * FROM Payments WHERE CreditID='{0}' ORDER BY PaymentDate", creditID);
                var selection = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    var dataReader = selection.ExecuteReader();
                    foreach (var e in dataReader)
                    {
                        allPayments.Add(e);
                    }
                }
                catch (Exception)
                {
                    throw new Exception();
                }

            }
            return allPayments;
        }

        public bool SaveNewDebitor (string id, string name, string postNumber, string phoneNumber)
        {
            bool success = false;
            string query = string.Format("INSERT INTO DEBITORS" +
                                         "(ID, Name, PostIndex, PhoneNumber)" +
                                         "VALUES ('{0}', '{1}','{2}', '{3}')", id, name, postNumber, (phoneNumber!=string.Empty)?phoneNumber:null);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var addDebitor = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    if (addDebitor.ExecuteNonQuery()==1)
                        success = true;
                }
                catch
                {
                   
                }
                return success;
            }
        }

        public bool SaveNewCredit(Guid id, Guid debitorID, int amount, decimal balance, DateTime openDate)
        {
            bool success = false;
            string query = String.Format("INSERT INTO CREDITS" +
                "(ID, DebitorID, Amount, Balance, OpenDate)" +
                 "VALUES (@ID, @debitorID, @amount, @balance, @opendate)");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var addNewCredit = new SqlCommand(query, connection);
                var parameter = new SqlParameter();
                parameter.ParameterName = @"ID";
                parameter.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
                parameter.Value = id;
                addNewCredit.Parameters.Add(parameter);
                addNewCredit.Parameters.Add(new SqlParameter(@"debitorID", debitorID));
                addNewCredit.Parameters.Add(new SqlParameter(@"amount", amount));
                addNewCredit.Parameters.Add(new SqlParameter(@"balance", balance));
                addNewCredit.Parameters.Add(new SqlParameter(@"opendate", openDate));      



                try
                {
                    if (addNewCredit.ExecuteNonQuery() == 1)
                        success = true;
                }
                catch (Exception)
                {

                    throw;
                }
                return success;
            }
        }

        public bool SaveNewPayment(Guid id, Guid creditID, decimal amount, DateTime paymentDate)
        {
            bool success = false;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction sqlTransaction = connection.BeginTransaction();
                var command = connection.CreateCommand();
                command.Transaction = sqlTransaction;

                try
                {
                    string paymentAmount = amount.ToString(CultureInfo.InvariantCulture.NumberFormat);

                    string query = string.Format("INSERT INTO Payments (ID, CreditID, Amount, PaymentDate)" +
                                                   "VALUES ('{0}','{1}','{2}','{3}')", id, creditID, paymentAmount, paymentDate);
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                   
                    query = string.Format("UPDATE Credits SET Balance = (Balance - {0})" +
                                            "WHERE ID='{1}' ", paymentAmount,creditID);
                    command.CommandText = query;
                    command.ExecuteNonQuery();

                   sqlTransaction.Commit();
                    success = true;
                }

                catch (Exception)
                {
                    sqlTransaction.Rollback();
                    success = false;
                }

                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Dispose();
                    //if (sqlTransaction. != null)
                    //    success = false;
                }

            }

            return success;
        }

        internal ArrayList SearchDebitor (string name, string postIndex, string phonenumber)
        {
            var debitors = new ArrayList();
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    var command = new SqlCommand("SearchDebitor", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@debName", name));
                    command.Parameters.Add(new SqlParameter("@debPostIndex", postIndex));
                    command.Parameters.Add(new SqlParameter("@debPhoneNumber", phonenumber));

                    var list = command.ExecuteReader();
                    if (list.HasRows)
                    {
                        foreach (var row in list)
                            debitors.Add(row);
                    }

                   
                }

                catch
                {

                }
                return debitors;
            }
        }

    }
}
