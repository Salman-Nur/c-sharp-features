using System.Numerics;

var adderss = new Address()
{
    Street = "Kazi Road",
    City = "Bagura",
    Country = "Bangladesh"
};

var sessions = new List<Session>()
{
    new Session()  { DurationInHour = 9, LearningObjective = "item 1"},
    new Session()  {DurationInHour = 5, LearningObjective = "item 2"}
};

var topic = new Topic()
{
    Title = "Java",
    Description = "Basic java topic",
    Sessions = sessions
};

var instructor = new Instructor
{
    Name = "Tareq",
    Email = "tareq@gmail.com",
    PresentAddress = adderss,
    PermanentAddress = adderss,
    PhoneNumbers = new List<Phone> 
    { 
        new Phone { CountryCode ="gsgsg", Extension="ghd", Number= "jh" },
        new Phone { CountryCode ="fsg", Extension="rge", Number= "gh" }
                                   
    }
};
var admissionTest = new AdmissionTest()
{
    StartDateTime = DateTime.Now,
    EndDateTime = DateTime.Now,
    TestFees = 323.342
};

var course = new Course
{
    Topics = new List<Topic> { topic, topic },
    Tests = null
};



//string Json = JsonFormatter.Convert(course);

public class Course
{
    public string Title { get; set; }
    public Instructor Teacher { get; set; }
    public List<Topic> Topics { get; set; }
    public double Fees { get; set; }
    public List<AdmissionTest> Tests { get; set; }
}

public class AdmissionTest
{
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }
    public double TestFees { get; set; }
}

public class Topic
{
    public string Title { get; set; }
    public string Description { get; set; }
    public List<Session> Sessions { get; set; }
}

public class Session
{
    public int DurationInHour { get; set; }
    public string LearningObjective { get; set; }
}

public class Instructor
{
    public string Name { get; set; }
    public string Email { get; set; }
    public Address PresentAddress { get; set; }
    public Address PermanentAddress { get; set; }
    public List<Phone> PhoneNumbers { get; set; }
}

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
}

public class Phone
{
    public string Number { get; set; }
    public string Extension { get; set; }
    public string CountryCode { get; set; }
}