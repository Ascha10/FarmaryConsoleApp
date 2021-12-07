using FarmaryConsoleApp;

List<Doctor> doctors = new List<Doctor>();


void farmaryMenu()
{
    Console.WriteLine("Please Select an Operation");
    Console.WriteLine("1. Add Doctor");
    Console.WriteLine("2. Display Doctor");
    Console.WriteLine("3. Add Patient To Doctor");
    Console.WriteLine("4. Display All Doctors");
    Console.WriteLine("5. Display DiaryPatient");
    Console.WriteLine("6. Display DiaryPatient Of 5 Patient Per Day");
    int options = int.Parse(Console.ReadLine());


    switch (options)
    {
        case 1:
            AddDoctor();
            break;

        case 2:
            Console.WriteLine("Please Enter Doctor Name");
            string doctorName = Console.ReadLine();
            DisplayDoctor(doctorName);
            break;

        case 3:
            Console.WriteLine("Please Enter Doctor Name To Add Patient");
            string doctor = Console.ReadLine();
            AddPatientToDoctor(doctor);
            break;

        case 4:
            DisplayAllDoctor();
            break;

        case 5:
            Console.WriteLine("Please Enter Number Of Weeks");
            int numberOfWeeks = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Number Of Days");
            int numberOfDays = int.Parse(Console.ReadLine());

            Schedule.DiaryPatient(numberOfWeeks, numberOfDays);
            break;

        case 6:
            Console.WriteLine("Please Enter Number Of Weeks");
            int numOfWeeks = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Number Of Days");
            int numOfDays = int.Parse(Console.ReadLine());

            Schedule.DiaryPatientOf5perDay(numOfWeeks, numOfDays);
            break;

        default:
            farmaryMenu();
            break;
    }
    farmaryMenu();
}

farmaryMenu();

void AddDoctor()
{
    Doctor newDoctor = new Doctor(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine());
    Console.WriteLine($"{newDoctor.firstName} {newDoctor.lastName} {newDoctor.role} {newDoctor.patients} {newDoctor.dateOfBirth}");
    doctors.Add(newDoctor);

    FileStream doctorFileObject = new FileStream($@"C:\test\Doctors\{newDoctor.firstName}.txt",FileMode.Append);
    using(StreamWriter writeToFile = new StreamWriter(doctorFileObject))
    {
        writeToFile.WriteLine($"{newDoctor.firstName} {newDoctor.lastName} {newDoctor.role} {newDoctor.patients} {newDoctor.dateOfBirth}");
    }

    int counter = 0;
    FileStream allDoctorsFileObject = new FileStream(@"C:\test\Doctors\allDoctors.txt", FileMode.Append);
    using (StreamWriter writeToDoctorsFile = new StreamWriter(allDoctorsFileObject))
    {
        writeToDoctorsFile.WriteLine($"id:{counter++} {newDoctor.firstName} {newDoctor.lastName} {newDoctor.role} {newDoctor.patients} {newDoctor.dateOfBirth},");
    }
}

void DisplayDoctor(string nameOfDoctor)
{
    foreach (Doctor doctor in doctors)
    {
        if (nameOfDoctor == doctor.firstName) {
            Console.WriteLine($"{doctor.firstName} {doctor.lastName} {doctor.role} {doctor.patients} {doctor.dateOfBirth}");
        }
    }
}

void DisplayAllDoctor()
{
    FileStream allDoctorsFileObject = new FileStream(@"C:\test\Doctors\allDoctors.txt", FileMode.Open);
    using (StreamReader readFromDoctorsFile = new StreamReader(allDoctorsFileObject))
    {
        for(int i = 0; i < readFromDoctorsFile.Peek(); i++)
        {
            Console.WriteLine(readFromDoctorsFile.ReadLine());
        }
    }
}

void AddPatientToDoctor(string nameOfDoctor)
{
    doctors.Sort();
    foreach (Doctor doctor in doctors)
    {
        if (nameOfDoctor == doctor.firstName)
        {
            Console.WriteLine("Before Update");
            Console.WriteLine($"{doctor.firstName} {doctor.lastName} {doctor.role} {doctor.patients} {doctor.dateOfBirth}");
            doctor.patients += 1;
            Console.WriteLine("After Update");
            Console.WriteLine($"{doctor.firstName} {doctor.lastName} {doctor.role} {doctor.patients} {doctor.dateOfBirth}");
        }
        Console.WriteLine($"{doctor.firstName} {doctor.lastName} {doctor.role} {doctor.patients} {doctor.dateOfBirth}");
    }
}



