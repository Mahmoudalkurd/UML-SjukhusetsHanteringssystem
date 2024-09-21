

using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

public class Employee
{
    private string name;
    private string phone;
    private string email;
    private Department department;

    public Employee(string name, string phone, string email)
    {
        Name = name;
        Phone = phone;
        Email = email;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public Department WorkingDepartment
    {
        set { department = value; }
        get { return department; }

}

public class Doctor : Employee
{
    private string speciality;

    public Doctor(string name, string phone, string email, string speciality) : base(name, phone, email)
    {
        Speciality = speciality;
    }

    public string Speciality
    {
        get { return speciality; }
        set { speciality = value; }
    }

    public void prescribeMedicine(Patient patient)
    {
        Console.WriteLine("Prescribing medicine...");
    }

    public void requestTreatment(Patient patient)
    {
        Console.WriteLine("Request treatmment...");
    }
}
public class Nurse: Employee
{
    public Nurse(string name, string phone, string email ) : base(name, phone, email)
    {
       
    }
    public void helpDoctor(Doctor doctor)
    {
        Console.WriteLine($"{Name} is helping {doctor.Name}");
    }

    public void careForPatient(Patient patient)
    {
        Console.WriteLine("Caring for patient..");
    }
}

public class Patient
{
    private string name;
    private int id;
    private Journal patientjournal;

    public Patient(string name, int id, Journal journal)
    {
        Name = name;
        Id = id;
        Patientjournal = journal;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Journal Patientjournal
    {
        get { return patientjournal; }
        set { patientjournal = value; }
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
}

public class Journal
{
    private bool visited;
    private string treatments;
    private string diagnoses;

    public Journal(bool visited, string treatments, string diagnoses)
    {
        VisitedBefore = visited;
        Treatments = treatments;
        Diagnoses = diagnoses;
    }

    public bool VisitedBefore {
        get { return visited; }
        set { visited = value; }
    }

    public string Treatments { 
        get { return treatments; } 
        set { treatments = value; } 
    }

    public string Diagnoses { get { return diagnoses; } set {  diagnoses = value; } }
}

public class Department
{
    private string name;

    public Department(string name)
    {
        Name = name;
    }

    public string Name {
        get { return name; }
        set {  name = value; }
    }
}

