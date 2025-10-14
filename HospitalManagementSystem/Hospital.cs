using System;
using System.Numerics;

public class Hospital
{
    public List<Doctor> Doctors;
    public List<Patient> Patients;
    public List<MedicalRecord> Records;  
    public List<HospitalRoom> Rooms;

    public Hospital()
    {
        Doctors = new List<Doctor>();
        Patients = new List<Patient>();
        Records = new List<MedicalRecord>();  
        Rooms = new List<HospitalRoom>();
    }

    public void AddDoctor(Doctor doctor)
    {
        Doctors.Add(doctor);
        Console.WriteLine($"Лікар {doctor.Name} ({doctor.Specialization}) доданий до системи");
    }

    public void RegisterPatient(Patient patient)
    {
        Patients.Add(patient);
        Console.WriteLine($"Пацієнт {patient.Name}, {patient.Age} років, зареєстрований");
    }

    public void CreateRoom(HospitalRoom room)
    {
        Rooms.Add(room);
        Console.WriteLine($"Палата №{room.RoomNumber} створена (місткість: {room.Capacity}");
    }

    public void HospitalizePatient(int patientId, int roomNumber)
    {
        Patient patient = Patients.Find(p => p.Id == patientId);
        HospitalRoom room = Rooms.Find(r => r.RoomNumber == roomNumber);
        if (patient == null)
        {
            Console.WriteLine($"Пацієнт з ID {patientId} не знайдений!");
            return;
        }
        if (room == null)
        {
            Console.WriteLine($"Палата №{roomNumber} не знайдена!");
            return;
        }
        room.AddPatient(patient);
    }

    public void AddMedicalRecord(MedicalRecord record)
    {
        Records.Add(record); 
        Console.WriteLine($"Медичний запис створено: {record.Patient.Name} -> {record.Doctor.Name}");
    }

    public List<MedicalRecord> GetPatientHistory(int patientId)
    {
        return Records.FindAll(r => r.Patient.Id == patientId);  
    }

    public string GetStatistics()
    {
        int totalPatientsInRooms = 0;
        foreach (HospitalRoom room in Rooms)
        {
            totalPatientsInRooms += room.Patients.Count;
        }

        return $"\n=== СТАТИСТИКА ЛІКАРНІ ===\n" +
               $"Кількість лікарів: {Doctors.Count}\n" +
               $"Кількість зареєстрованих пацієнтів: {Patients.Count}\n" +
               $"Кількість палат: {Rooms.Count}\n" +
               $"Кількість пацієнтів у палатах: {totalPatientsInRooms}\n" +
               $"Кількість медичних записів: {Records.Count}\n";  
    }
}