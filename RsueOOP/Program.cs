using System;
using ClassLibraryRsueOOP;

namespace RsueOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Input();
            client.Output();

            PhysicalPerson physicalPerson = new PhysicalPerson();
            physicalPerson.Input();
            physicalPerson.Output();

            Company company = new Company();
            company.Input();
            company.Output();

        }
    }
}
