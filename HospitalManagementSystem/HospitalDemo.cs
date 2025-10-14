using System;

public class HospitalDemo
{
    public void Run()
    {
        Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ЛІКАРНЕЮ ===\n");

        Hospital hospital = new Hospital();

        Console.WriteLine("--- ДОДАВАННЯ ЛІКАРІВ ---");
        Doctor doctor1 = new Doctor(1, "Іванов Іван Іванович", "Терапевт");
        Doctor doctor2 = new Doctor(2, "Петрова Олена Петрівна", "Хірург");
        Doctor doctor3 = new Doctor(3, "Сидоренко Марія Олександрівна", "Кардіолог");

        hospital.AddDoctor(doctor1);
        hospital.AddDoctor(doctor2);
        hospital.AddDoctor(doctor3);

        // Реєстрація пацієнтів
        Console.WriteLine("\n--- РЕЄСТРАЦІЯ ПАЦІЄНТІВ ---");
        Patient patient1 = new Patient(1, "Коваленко Петро", 45);
        Patient patient2 = new Patient(2, "Шевченко Анна", 32);
        Patient patient3 = new Patient(3, "Мельник Олег", 58);
        Patient patient4 = new Patient(4, "Бойко Наталія", 28);

        hospital.RegisterPatient(patient1);
        hospital.RegisterPatient(patient2);
        hospital.RegisterPatient(patient3);
        hospital.RegisterPatient(patient4);

        Console.WriteLine("\n--- СТВОРЕННЯ ПАЛАТ ---");
        HospitalRoom room1 = new HospitalRoom(101, 2);
        HospitalRoom room2 = new HospitalRoom(102, 3);
        HospitalRoom room3 = new HospitalRoom(103, 1);

        hospital.CreateRoom(room1);
        hospital.CreateRoom(room2);
        hospital.CreateRoom(room3);

        Console.WriteLine("\n--- ГОСПІТАЛІЗАЦІЯ ПАЦІЄНТІВ ---");
        hospital.HospitalizePatient(1, 101);
        hospital.HospitalizePatient(2, 101);
        hospital.HospitalizePatient(3, 102);


        Console.WriteLine("\n--- СТВОРЕННЯ МЕДИЧНИХ ЗАПИСІВ ---");
        MedicalRecord record1 = new MedicalRecord(patient1, doctor1, new DateTime(2025, 10, 10), "Огляд, діагноз: ГРВІ");
        MedicalRecord record2 = new MedicalRecord(patient1, doctor3, new DateTime(2025, 10, 12), "Консультація кардіолога, ЕКГ в нормі");
        MedicalRecord record3 = new MedicalRecord(patient2, doctor2, new DateTime(2025, 10, 13), "Підготовка до операції");

        hospital.AddMedicalRecord(record1);
        hospital.AddMedicalRecord(record2);
        hospital.AddMedicalRecord(record3);


        Console.WriteLine("\n--- ІСТОРІЯ ПАЦІЄНТА ---");
        var history = hospital.GetPatientHistory(1);
        if (history.Count > 0)
        {
            Console.WriteLine($"Історія хвороби пацієнта: {patient1.Name}");
            foreach (var record in history)
            {
                Console.WriteLine($"  Дата: {record.Date.ToShortDateString()}");
                Console.WriteLine($"  Лікар: {record.Doctor.Name}");
                Console.WriteLine($"  Опис: {record.Description}\n");
            }
        }
        else
        {
            Console.WriteLine("Медичних записів не знайдено");
        }

  
        Console.WriteLine(hospital.GetStatistics());
    }
}