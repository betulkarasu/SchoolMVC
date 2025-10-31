using Microsoft.AspNetCore.Mvc;
using projects.Models;

namespace projects.Controllers;

public class SchoolController : Controller

{
    public IActionResult Index()

    {
        SchoolModel schoolModel = new SchoolModel();

        schoolModel.StdName = "Betul";
        schoolModel.StdLastName = "Karasu";
        schoolModel.Class = "4. sınıf";
        schoolModel.Credit = 55;
        schoolModel.SectionCode = "COME310";
        schoolModel.Assignments = true;
        schoolModel.Deadline = false;
        schoolModel.LastDeadline = "1 EKİM";
        schoolModel.GPA = 3.40;
        schoolModel.InstructorName = "Zeynep";
        schoolModel.IsGraduated = true;
        schoolModel.IsPassed = true;
        schoolModel.SectionCount = 7;
        schoolModel.ProgramDays = "Pazartesi";
        schoolModel.SectionName = "Introduction to Algorithm";


        return View(schoolModel);
    

    }


    public IActionResult List()
    {
        List<SchoolModel> StudentInformations = new List<SchoolModel>();

        SchoolModel Student1 = new SchoolModel();
        SchoolModel Student2 = new SchoolModel();
        SchoolModel Student3 = new SchoolModel();
        SchoolModel Student4 = new SchoolModel();
        SchoolModel Stundet5 = new SchoolModel();
        SchoolModel Student6 = new SchoolModel();

        Student1.StdName = "Azra";
        Student2.StdName = "Ebru";
        Student3.StdName = "Gamze";
        Student4.StdName = "Deniz";
        Student6.StdName = "Berkay";

        Student1.StdLastName = "KAYA";
        Student2.StdLastName = "KAYA";
        Student3.StdLastName = "KAYA";
        Student4.StdLastName = "KAYA";
        Student6.StdLastName = "KAAY";

        Student1.Class = "3. Sınıf";
        Student2.Class = "2. Sınıf";
        Student3.Class = "4. Sınıf";
        Student4.Class = "4. Sınıf";
        Student6.Class = "1. Sınıf";


        Student1.Credit = 45;
        Student2.Credit = 30;
        Student3.Credit = 25;
        Student4.Credit = 55;
        Student6.Credit = 20;

        Student1.IsGraduated = false;
        Student2.IsGraduated = false;
        Student3.IsGraduated = false;
        Student4.IsGraduated = true;
        Student6.IsGraduated = false;


        Student1.GPA = 3.00;
        Student2.GPA = 2.45;
        Student3.GPA = 1.80;
        Student4.GPA = 4.00;
        Student6.GPA = 3.20;

        StudentInformations.Add(Student1);
        StudentInformations.Add(Student2);
        StudentInformations.Add(Student3);
        StudentInformations.Add(Student4);
        StudentInformations.Add(Student6);


        return View(StudentInformations);


    }


    public IActionResult DersProgrami()
    {

        List<SchoolModel> DersProgramı = new List<SchoolModel>();

        SchoolModel Akademisyen = new SchoolModel();
        SchoolModel DersAdı = new SchoolModel();
        SchoolModel DersKodu = new SchoolModel();
        SchoolModel DersOdevi = new SchoolModel();
        SchoolModel DersGünü = new SchoolModel();
        SchoolModel SonTeslim = new SchoolModel();
        SchoolModel DersSinifi = new SchoolModel();


        Akademisyen.InstructorName = "Elif";
        DersAdı.SectionName = "Computer Arch";
        DersKodu.SectionCode = "COME103";
        DersOdevi.Assignments = true;
        DersGünü.ProgramDays = "Salı";
        SonTeslim.LastDeadline = "15 Kasım";
        DersSinifi.Class = "Derslik 310";


        Akademisyen.InstructorName = "Gökay";
        DersAdı.SectionName = "Computer Networks";
        DersKodu.SectionCode = "COME303";
        DersOdevi.Assignments = false;
        DersGünü.ProgramDays = "Çarşamba";
        SonTeslim.LastDeadline = "20 Kasım";
        DersSinifi.Class = "Derslik 10";


        Akademisyen.InstructorName = "Ege";
        DersAdı.SectionName = "Data Structure";
        DersKodu.SectionCode = "COME205";
        DersOdevi.Assignments = true;
        DersGünü.ProgramDays = "Cuma";
        SonTeslim.LastDeadline = "2 Kasım";
        DersSinifi.Class = "Derslik 113";

        DersProgramı.Add(Akademisyen);
        DersProgramı.Add(DersAdı);
        DersProgramı.Add(DersKodu);
        DersProgramı.Add(DersOdevi);
        DersProgramı.Add(DersGünü);
        DersProgramı.Add(SonTeslim);
        DersProgramı.Add(DersSinifi);

        return View(DersProgramı);


    }

}