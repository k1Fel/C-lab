﻿using System;

public class HospitalRoom
{
	public int RoomNumber { get; private set; }
	public int Capacity { get; private set; }
	public List<Patient> Patients ; 
    public HospitalRoom(int roomNumber, int capacity)
	{
		RoomNumber = roomNumber;
		Capacity = capacity;
        Patients = new List<Patient>();
    }

	public void AddPatient(Patient patient) {
		if (Patients.Count < Capacity)
		{
			Patients.Add(patient);
			Console.WriteLine($"Пацієнт {patient.Name} доданий у палату №{RoomNumber}");
        }
		else
		{
			Console.WriteLine($"Палата #{RoomNumber} переповнена! Неможливо додати пацієнта");
		}
    }
}
