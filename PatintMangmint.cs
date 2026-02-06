using System;
using System.Collections.Generic;
using System.Text;

namespace hospitalSystem
{
    internal class PatintMangmint
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
        public void GetData() {

            foreach (Patient pat in patients) {

                Console.WriteLine($"name patint is : {pat.Name} \nAge patint is {pat.Age} \nGender patint is :{pat.Gender}");

            }        }

        // Find Patient By Name
        public Patient FindPatintForName(string name) {

            return patients.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
