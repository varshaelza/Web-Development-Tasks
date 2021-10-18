using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Varsha_BankingLIB
{
    public abstract class Accounts
    {
        #region Variables
        //string v_accNo;
        //string v_accName;
        ////string v_accType;
        //double v_accBalance;
        //bool v_accIsactive;
        #endregion

        #region Properties
        public string AccNo { get; set; }

        public string AccName { get; set; }

        public double AccBalance { get; set; }

        public bool AccIsactive { get; set; }

        //public string AccNo
        //{
        //    get
        //    {
        //        return v_accNo;
        //    }
        //    set
        //    {
        //        v_accNo = value;
        //    }
        //}
        //public string AccName
        //{
        //    get
        //    {
        //        return v_accName;
        //    }
        //    set
        //    {
        //        v_accName = value;
        //    }
        //}
        //public string AccType
        //{
        //    get
        //    {
        //        return v_accType;
        //    }
        //    set
        //    {
        //        v_accType = value;
        //    }
        //}
        //public double AccBalance
        //{
        //    get
        //    {
        //        return v_accBalance;
        //    }
        //    set
        //    {
        //        v_accBalance = value;
        //    }
        //}
        //public bool AccIsactive
        //{
        //    get
        //    {
        //        return v_accIsactive;
        //    }
        //    set
        //    {
        //        v_accIsactive = value;
        //    }
        //}

        #endregion

        #region Constructors
        public Accounts()
        {

        }
        public Accounts(string p_accName,double p_accBalance,bool p_accIsactive,string filepath)
        {
            
            this.AccName = p_accName;
            this.AccBalance = p_accBalance;
            this.AccIsactive = p_accIsactive;
            int baseNo;
            if(filepath.EndsWith("autoSavNo.txt"))
            {
                baseNo = 5000;
            }
            else if(filepath.EndsWith("autoCurNo.txt"))
            {
                baseNo = 2000;
            }
            else
            {
                baseNo = 3000;
            }
            FileStream accFile;
            StreamWriter wr;
            StreamReader rd;
            if(!File.Exists(filepath))
            {
                accFile = new FileStream(filepath,FileMode.Create,FileAccess.Write);
                wr = new StreamWriter(accFile);
                wr.WriteLine(baseNo);
                wr.Close();
                accFile.Close();
            }
            
            accFile = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            rd = new StreamReader(accFile);
            int number = Convert.ToInt32(rd.ReadLine());
            number++;
            rd.Close();
            accFile.Close();

            accFile = new FileStream(filepath, FileMode.Create, FileAccess.Write);
            wr = new StreamWriter(accFile);
            wr.WriteLine(number);
            wr.Close();
            accFile.Close();
            if (filepath.EndsWith("autoSavNo.txt"))
            {
                this.AccNo = "SAV" + number.ToString();
            }
            else if (filepath.EndsWith("autoCurNo.txt"))
            {
                this.AccNo = "CUR" + number.ToString();
            }
            else
            {
                this.AccNo = "PF" + number.ToString();
            }
            this.SerializeAcc();

        }
        #endregion

        #region Methods
        public virtual bool Withdraw(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Cannot withdraw amount less than 0");
                return false;
            }
            else
            {
                this.AccBalance = this.AccBalance - amount;
                return true;
            }
        }

        public virtual bool Deposit(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Cannot deposit amount less than 0");
                return false;
            }
            else
            {
                this.AccBalance = this.AccBalance + amount;
                return true;
            }
        }

        public bool Transfer(string receiverAccNo)
        {
            bool receiverFound = false ,transferSuccessful=false;
            double amount;
            try
            {
                if (receiverAccNo.StartsWith("SAV"))
                {
                    Console.WriteLine("Enter Amount to be transferred");
                    amount = Convert.ToDouble(Console.ReadLine());
                    Savings receiverObj = new Savings();
                    receiverFound = receiverObj.DeserializeAcc("C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Project\\Accounts\\Savings Accounts\\" + receiverAccNo + ".xml");
                    transferSuccessful = this.Withdraw(amount);
                    if (transferSuccessful)
                    {
                        transferSuccessful = receiverObj.Deposit(amount);
                        if (transferSuccessful)
                        {
                            receiverObj.SerializeAcc();
                        }
                    }


                }
                else if (receiverAccNo.StartsWith("CUR"))
                {
                    Console.WriteLine("Enter Amount to be transferred");
                    amount = Convert.ToDouble(Console.ReadLine());
                    Current receiverObj = new Current();
                    receiverFound = receiverObj.DeserializeAcc("C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Project\\Accounts\\Current Accounts\\" + receiverAccNo + ".xml");
                    transferSuccessful = this.Withdraw(amount);
                    if (transferSuccessful)
                    {
                        transferSuccessful = receiverObj.Deposit(amount);
                        if (transferSuccessful)
                        {
                            receiverObj.SerializeAcc();
                        }
                    }
                    

                }
                else
                {
                    Console.WriteLine("Enter Amount to be transferred");
                    amount = Convert.ToDouble(Console.ReadLine());
                    PF receiverObj = new PF();
                    receiverFound = receiverObj.DeserializeAcc("C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Project\\Accounts\\PF Accounts\\" + receiverAccNo + ".xml");
                    transferSuccessful = this.Withdraw(amount);
                    if (transferSuccessful)
                    {
                        transferSuccessful = receiverObj.Deposit(amount);
                        if (transferSuccessful)
                        {
                            receiverObj.SerializeAcc();
                        }
                    }

                }
                return transferSuccessful;
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("Recipient Account not found");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return receiverFound;

        }
        #endregion

        #region Serialization and Deserialization
        public void SerializeAcc()
        {
            FileStream myFile = null;
            try
            {

                if (this.AccNo.StartsWith("SAV"))
                {
                    myFile = new FileStream("C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Project\\Accounts\\Savings Accounts\\" + this.AccNo + ".xml", FileMode.Create, FileAccess.Write);
                    XmlSerializer xs = new XmlSerializer(typeof(Savings));
                    xs.Serialize(myFile, this);
                    myFile.Close();
                }
                else if (this.AccNo.StartsWith("CUR"))
                {
                    myFile = new FileStream("C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Project\\Accounts\\Current Accounts\\" + this.AccNo + ".xml", FileMode.Create, FileAccess.Write);
                    XmlSerializer xs = new XmlSerializer(typeof(Current));
                    xs.Serialize(myFile, this);
                    myFile.Close();
                }
                else 
                {
                    myFile = new FileStream("C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Project\\Accounts\\PF Accounts\\" + this.AccNo + ".xml", FileMode.Create, FileAccess.Write);
                    XmlSerializer xs = new XmlSerializer(typeof(PF));
                    xs.Serialize(myFile, this);
                    myFile.Close();
                }
                //Console.WriteLine("Object is Serialized");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (myFile != null)
                {
                    myFile.Close();
                }
            }
        }

        public bool DeserializeAcc(string objpath)
        {
            
            XmlSerializer xs ;
            FileStream myFile = null;
            Accounts obj=null;
            try
            {
                myFile = new FileStream(objpath, FileMode.Open, FileAccess.Read);
                if (objpath.Contains("Savings Accounts"))
                {
                    xs = new XmlSerializer(typeof(Savings));
                    obj = (Savings)xs.Deserialize(myFile);
                    myFile.Close();
                }
                else if (objpath.Contains("Current Accounts"))
                {
                    xs = new XmlSerializer(typeof(Current));
                    obj = (Current)xs.Deserialize(myFile);
                    myFile.Close();
                }
                else
                {
                    xs = new XmlSerializer(typeof(PF));
                    obj = (PF)xs.Deserialize(myFile);
                    myFile.Close();
                }
                this.AccNo = obj.AccNo;
                this.AccName = obj.AccName;
                this.AccBalance = obj.AccBalance;
                this.AccIsactive = obj.AccIsactive;

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No Such Employee");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (myFile != null)
                {
                    myFile.Close();
                }
                
               
            }
            return true;
        }
        #endregion



       
    }
}


