using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSoapDB_AzureClient.ServiceReference1;

namespace StudentSoapDB_AzureClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StudentClient client = new StudentClient("BasicHttpBinding_IStudent"))
            {
                //Firkantede klammer efter Student klasse er fordi GetallStudent har Ilist<Student> som datatype. 
                Student[] allstudents = client.GetAllStudents();
                foreach (var st in allstudents)
                {
                    Console.WriteLine(st.StudentName);
                }


                Console.WriteLine("Studerendes navn med id 4:");
                Student stu = client.GetStudentById(4);
                Console.WriteLine(stu.StudentName);

                Console.WriteLine("Studerendes id med navn test");
                Student stu2 = client.GetStudentByName("test");
                Console.WriteLine(stu2.StudentId);


            }

            Console.ReadLine();
        }
    }
}
