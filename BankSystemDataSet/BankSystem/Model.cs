using System;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text;
using System.Configuration;
using System.Windows.Forms;

namespace BankSystemDataSet
{
    class Model
    {
        string connectionString = ConfigurationManager.ConnectionStrings[".BankSystemConnectionString"].ConnectionString;
        DataSet bankSystemDataSet;
        SqlDataAdapter debitorsDA, creditsDA;
        SqlDataAdapter paymentsDA;
        SqlCommandBuilder debitorCB, creditCB, paymentCB;

        public Model()
        {
            bankSystemDataSet = new DataSet("BankSystem");
            debitorsDA = new SqlDataAdapter("SELECT * FROM Debitors", connectionString);

            //Можно писать так, если есть ограничения для использования коммандБилдера
            //debitorsDA.InsertCommand = new SqlCommand();
            //debitorsDA.InsertCommand.Connection = new SqlConnection(connectionString);
            //debitorsDA.InsertCommand.CommandType = CommandType.Text;
            //debitorsDA.InsertCommand.CommandText = ("INSERT INTO Debitors (ID, Name, PostIndex, PhoneNumber)"+
            //                                        "VALUES (@Id, @Name, @PostIndex, @PhoneNumber)");
            //debitorsDA.InsertCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.UniqueIdentifier, 0, "ID"));
            //debitorsDA.InsertCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 0, "Name"));
            //debitorsDA.InsertCommand.Parameters.Add(new SqlParameter("@PostIndex", SqlDbType.NVarChar, 0, "PostIndex"));
            //debitorsDA.InsertCommand.Parameters.Add(new SqlParameter("@PhoneNumber", SqlDbType.NVarChar, 0, "PhoneNumber"));
            
            creditsDA = new SqlDataAdapter("SELECT * FROM Credits", connectionString);
            paymentsDA = new SqlDataAdapter("SELECT * FROM Payments", connectionString);

            debitorCB = new SqlCommandBuilder(debitorsDA);
            creditCB = new SqlCommandBuilder(creditsDA);

            paymentsDA.InsertCommand = new SqlCommand("SavePayment");
            paymentsDA.InsertCommand.Connection = new SqlConnection(connectionString);
            paymentsDA.InsertCommand.CommandType = CommandType.StoredProcedure;
            //paymentsDA.InsertCommand.CommandText = ("INSERT INTO Payments" +
            //    "(Payments.ID, Payments.CreditID, Payments.Amount, Payments.PaymentDate)" +
            //    "VALUES (@ID, @CreditID, @Amount, @PaymentDate);" +
            //    "UPDATE Credits SET Credits.Balance = (Credits.Balance - @Amount)"+
            //    "WHERE Credits.ID = @CreditID");
            paymentsDA.InsertCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.UniqueIdentifier, 0, "ID"));
            paymentsDA.InsertCommand.Parameters.Add(new SqlParameter("@CreditID", SqlDbType.UniqueIdentifier, 0, "CreditID"));
            paymentsDA.InsertCommand.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Decimal, 0, "Amount"));
            paymentsDA.InsertCommand.Parameters.Add(new SqlParameter("@PaymentDate", SqlDbType.DateTime, 0, "PaymentDate"));

            //paymentCB = new SqlCommandBuilder(paymentsDA);
        }

        public DataSet GetDBData()
        {
            try
            {
                debitorsDA.Fill(bankSystemDataSet, "tableOfDebitors");
            creditsDA.Fill(bankSystemDataSet, "tableOfCredits");
            paymentsDA.Fill(bankSystemDataSet, "tableOfPayments");


                bankSystemDataSet.Tables[0].PrimaryKey = new DataColumn[] { bankSystemDataSet.Tables[0].Columns[0] };
                bankSystemDataSet.Tables[0].Columns[0].Unique = true;
                bankSystemDataSet.Tables[1].PrimaryKey = new DataColumn[] { bankSystemDataSet.Tables[1].Columns[0] };
                bankSystemDataSet.Tables[1].Columns[0].Unique = true;
                bankSystemDataSet.Tables[2].PrimaryKey = new DataColumn[] { bankSystemDataSet.Tables[2].Columns[0] };
                bankSystemDataSet.Tables[2].Columns[0].Unique = true;


                DataRelation dr = new DataRelation("DebitorsCredits",
                                      bankSystemDataSet.Tables["tableOfDebitors"].Columns["ID"],
                                      bankSystemDataSet.Tables["tableOfCredits"].Columns["DebitorID"]);
                bankSystemDataSet.Relations.Add(dr);

                dr = new DataRelation("CreditsPayments",
                    bankSystemDataSet.Tables["tableOfCredits"].Columns["ID"],
                    bankSystemDataSet.Tables["tableOfPayments"].Columns["CreditID"]);
                bankSystemDataSet.Relations.Add(dr);
            }
            catch (Exception e)
            {

                //MessageBox.Show(e.Message);
            }

            return bankSystemDataSet;
        }

        internal bool SaveChanges(DataSet bankSystemDataSet)
        {
            try
            {
                  debitorsDA.Update(bankSystemDataSet.Tables["tableOfDebitors"]);
                creditsDA.Update(bankSystemDataSet.Tables["tableOfCredits"]);
                paymentsDA.Update(bankSystemDataSet.Tables["tableOfPayments"]);
            }
            
            catch (ArgumentException)
            {
                return false;
            }
            catch (InvalidConstraintException)
            {
                return false;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;
        }
    }
}
