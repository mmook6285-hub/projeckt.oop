using System;
using System.Collections.Generic;
using System.Text;

namespace hospitalSystem
{
    internal class PatintMangmint : LLnterface
    {
        private List<Patient> patients;
        public PatintMangmint()
        {
            patients = new List<Patient>();
        }
        public void AddPatient(Patient patient) {
            patients.Add(patient);
        }

        public void DelForName(string name ) {

            patients.RemoveAll(p => p.Name == name );

        }

        // Show Data
        public void PrintData() {

            foreach (Patient pat in patients) {

                Console.WriteLine($" this Id : {pat.IdPatient} \nname patint is : {pat.Name} \nAge patint is {pat.Age} \nGender patint is :{pat.Gender}");

            }        }

        // Find Patient By Name
        public Patient FindPatintForName(string name) {

            return patients.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
