using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalSystem
{
    internal class Appointment
    {
        //خصاءص
        public int Id { get; private set; }
        public int PatientId { get; private set; }
        public int DoctorId { get; private set; }
        public  DateTime Date { get;private set; }
    //constructor
    public  Appointment(int id, int patientId, int doctorId,  DateTime date){
        Id = id;
        PatientId = patientId;
        DoctorId = doctorId;
        Date = date;
}
//Update Date
public void UpdateDate(DateTime newDate)
{
    Date = newDate;
}
        //PrintDate
        public void printData()
        {
            Console.WriteLine("Appointment   Info:");
            Console.WriteLine($"Id         :     {Id}");
            Console.WriteLine($"PatientId  :     {PatientId}");
            Console.WriteLine($"DoctorId   :    {DoctorId}");
            Console.WriteLine($"Date       :    {Date}");
            Console.WriteLine("-----------------------------------");

        }
    }
}
