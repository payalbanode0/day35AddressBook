using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinq
{
    public class AddressBookDataTable
    {
        //UC 3 Insert New Contact to Address Book
        public void AddToTable(DataTable addressBook)
        {
            addressBook.TableName = "AddressBook";
            //Adding FirstName ,LastName,Address,City,State,PhoneNumber and Email.
            addressBook.Rows.Add("Payal", "Banode", "25-4-710", "Nagpur", "Maharashtra", "8793819197", "payalbanode@gmail.com");
            addressBook.Rows.Add("Eren", "Jeager", "Shinsengumi", "Wall Maria", "Attak on Titan", "7958977310", "erenjeager@gmail.com");
            addressBook.Rows.Add("Sasuke", "Uchiha", "4-3-333", "Leaf Village", "Naruto", "9106529025", "schihasasuke@gmail.com");
            addressBook.Rows.Add("Kamado", "Tanjiro", "mt Kumotori", "Okutama", "Demon Slayer", "7578977310", "kamadoTanjiro@gmail.com");
            Display(addressBook);
        }

        public void Display(DataTable addressBook)
        {
            foreach (DataRow row in addressBook.Rows)
            {
                string firstName = row["FirstName"].ToString();
                string lastName = row["LastName"].ToString();
                string address = row["Address"].ToString();
                string city = row["City"].ToString();
                string state = row["State"].ToString();
                string phoneNumber = row["PhoneNumber"].ToString();
                string email = row["Email"].ToString();
                Console.WriteLine("\nFirst Name : " + firstName + ", Last Name : " + lastName + ", Address : " + address + ", City : " + city + ", State : " + state +
                    ", Phone Number : " + phoneNumber + ", Email : " + email);
            }
        }
        //UC 4 
        public void EditRecord(DataTable addressBook)
        {

            Console.WriteLine("Enter a Name to Search");
            string fname = Console.ReadLine();
            foreach (DataRow row in addressBook.Rows)
            {

                if (Convert.ToString(row["FirstName"]) == fname)
                {
                    Console.WriteLine("Enter First Name to Replace all the row values");
                    row["FirstName"] = Console.ReadLine();
                    Console.WriteLine("Enter LastName");
                    row["LastName"] = Console.ReadLine();
                    Console.WriteLine("Enter Address");
                    row["Address"] = Console.ReadLine();
                    Console.WriteLine("Enter City");
                    row["City"] = Console.ReadLine();
                    Console.WriteLine("Enter State");
                    row["State"] = Console.ReadLine();
                    Console.WriteLine("Enter Phone Number");
                    row["PhoneNumber"] = Console.ReadLine();
                    Console.WriteLine("Enter Email");
                    row["Email"] = Console.ReadLine();
                    addressBook.AcceptChanges();
                }
            }
            Display(addressBook);
        }
    }
}