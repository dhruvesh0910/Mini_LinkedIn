using mini_linkedIn.Models;
using System;
using System.Linq;

namespace mini_linkedIn.Data
{
    public static class DbInitializer
    {
        public static void Initialize(LinkedInContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.WorkExperiences.Any())
            {
                return;   // DB has been seeded
            }


            var users = new User[]
           {
                new User{UserID=100, FirstName="Dhruvesh", LastName="Patel", UserName="pate2306", PassWord="private", MobileNo=9999999999, EmailID="xyz@pqr.com"},
                new User{UserID=101, FirstName="Dhruvesh", LastName="Patel", UserName="pate2306", PassWord="private", MobileNo=9999999999, EmailID="xyz@pqr.com"},
                new User{UserID=102, FirstName="Dhruvesh", LastName="Patel", UserName="pate2306", PassWord="private", MobileNo=9999999999, EmailID="xyz@pqr.com"},
                new User{UserID=103, FirstName="Dhruvesh", LastName="Patel", UserName="pate2306", PassWord="private", MobileNo=9999999999, EmailID="xyz@pqr.com"},
                new User{UserID=104, FirstName="Dhruvesh", LastName="Patel", UserName="pate2306", PassWord="private", MobileNo=9999999999, EmailID="xyz@pqr.com"},
                new User{UserID=105, FirstName="Dhruvesh", LastName="Patel", UserName="pate2306", PassWord="private", MobileNo=9999999999, EmailID="xyz@pqr.com"},
           };
            foreach (User user in users)
            {
                context.Users.Add(user);
            }
            context.SaveChanges();

            var WorkExperineces = new WorkExperience[]
           {
                new WorkExperience{WorkID=1, Position="Software Developer", Area="Informatin technology", StartYear=2013, EndYear=2020, YearOfExperience=6, Description="bajsbcaj", UserID=100},
                new WorkExperience{WorkID=2, Position="Software Developer", Area="Informatin technology", StartYear=2013, EndYear=2020, YearOfExperience=6, Description="bajsbcaj", UserID=100},
                new WorkExperience{WorkID=3, Position="Software Developer", Area="Informatin technology", StartYear=2013, EndYear=2020, YearOfExperience=6, Description="bajsbcaj", UserID=100},
                new WorkExperience{WorkID=4, Position="Software Developer", Area="Informatin technology", StartYear=2013, EndYear=2020, YearOfExperience=6, Description="bajsbcaj", UserID=100},
                new WorkExperience{WorkID=5, Position="Software Developer", Area="Informatin technology", StartYear=2013, EndYear=2020, YearOfExperience=6, Description="bajsbcaj", UserID=100},
                new WorkExperience{WorkID=6, Position="Software Developer", Area="Informatin technology", StartYear=2013, EndYear=2020, YearOfExperience=6, Description="bajsbcaj", UserID=100}
           };
            foreach (WorkExperience we in WorkExperineces)
            {
                context.WorkExperiences.Add(we);
            }
            context.SaveChanges();

            var educations = new Education[]
           {
                new Education{EducationID=1, Title="Computer Programmer - Diploma", CollegeName="Sheridan College", GPA=3.9, StartYear=2020, EndYear=2021, UserID=100},
                new Education{EducationID=2, Title="Chemical Laboratory Technician - Diploma", CollegeName="Georgian College", GPA=2.9, StartYear=2020, EndYear=2021, UserID=101},
                new Education{EducationID=3, Title="Computer System Technician - Diploma", CollegeName="Sheridan College", GPA=3.1, StartYear=2020, EndYear=2021, UserID=102 },
                new Education{EducationID=4, Title="Computer Programmer - Diploma", CollegeName="Humber College", GPA=4.0, StartYear=2020, EndYear=2021, UserID=102},
                new Education{EducationID=5, Title="Mobile Application Development - Diploma", CollegeName="Seneca College", GPA=3.68, StartYear=2020, EndYear=2021, UserID=101}
           };
            foreach (Education education in educations)
            {
                context.Educations.Add(education);
            }
            context.SaveChanges();
            var references = new Reference[]
            {
                new Reference{RefID=1, Name="Jason Devdatt", CompanyName="JetAsprin", Role="Managing Junior Project Leaders", Position="Senior Project Manager", EmailID="xyz@pqr.com", WorkID=1},
                new Reference{RefID=2, Name="Jason Devdatt", CompanyName="JetAsprin", Role="Managing Junior Project Leaders", Position="Senior Project Manager", EmailID="xyz@pqr.com", WorkID=2},
                new Reference{RefID=3, Name="Jason Devdatt", CompanyName="JetAsprin", Role="Managing Junior Project Leaders", Position="Senior Project Manager", EmailID="xyz@pqr.com", WorkID=1},
                new Reference{RefID=4, Name="Jason Devdatt", CompanyName="JetAsprin", Role="Managing Junior Project Leaders", Position="Senior Project Manager", EmailID="xyz@pqr.com", WorkID=3},
                new Reference{RefID=5, Name="Jason Devdatt", CompanyName="JetAsprin", Role="Managing Junior Project Leaders", Position="Senior Project Manager", EmailID="xyz@pqr.com", WorkID=4}
            };
            foreach (Reference reference in references)
            {
                context.References.Add(reference);
            }
            context.SaveChanges();
            var achievements = new Achievement[]
            {
                new Achievement{AchievementID=1, Title="Academic Excellence Award",Year=2016,Description="Securing 2nd position throught year 2015 with 9.0 CPI", UserID=100},
                new Achievement{AchievementID=2,Title="Academic Excellence Award",Year=2017,Description="Securing 2nd position throught year 2016 with 8.96", UserID=100},
                new Achievement{AchievementID=3,Title="Academic Excellence Award",Year=2018,Description="Securing 2nd position throught year 2017 with 9.31 CGPA", UserID=100},
                new Achievement{AchievementID=4,Title="Academic Excellence Award",Year=2019,Description="Securing 2nd position throught year 2018 with 9.1 CGPA", UserID=100},
                new Achievement{AchievementID=5,Title="Academic Excellence Award",Year=2012,Description="Securing 1nd position throught year 2011 with 4.0 GPA", UserID=101},
                new Achievement{AchievementID=6,Title="Academic Excellence Award",Year=2013,Description="Securing 1nd position throught year 2012 with 8.96", UserID=102},
                new Achievement{AchievementID=7,Title="Academic Excellence Award",Year=2014,Description="Securing 3nd position throught year 2013 with 9.31 CGPA", UserID=103},
                new Achievement{AchievementID=8,Title="Academic Excellence Award",Year=2020,Description="Securing 1nd position throught year 2019 with 9.1 CGPA", UserID=101},
                new Achievement{AchievementID=9,Title="Academic Excellence Award",Year=2016,Description="Devang Mehta Award", UserID=105},
                new Achievement{AchievementID=10,Title="Academic Excellence Award",Year=2011,Description="Securing 2nd position throught year 2010 with 8.96", UserID=104},
                new Achievement{AchievementID=11,Title="Academic Excellence Award",Year=2012,Description="Securing 3nd position throught year 2011 with 9.31 CGPA", UserID=104},
                new Achievement{AchievementID=12,Title="Academic Excellence Award",Year=2009,Description="Securing 2nd position throught year 2008 with 9.1 CGPA", UserID=101}
            };
            foreach (Achievement achievement in achievements)
            {
                context.Achievements.Add(achievement);
            }
            context.SaveChanges();

            var projects = new Project[]
           {
                new Project{ProjectID=1, Title="Online Mall", TechnologyUsed="Android Studio, JSON Parsing", LanguageUsed="Java, Php, Volly, JSON Parse", StartYear=2017, EndYear=2017, Description="Project as a part of study", UserID=100},
                new Project{ProjectID=2, Title="MediCare", TechnologyUsed="Android Studio, JSON Parsing", LanguageUsed="Java, Php, Volly, JSON Parse", StartYear=2018, EndYear=2018, Description="Project as a part of study", UserID=101},
                new Project{ProjectID=3, Title="IoT based Smart Helmet for Auto Ignition and Alcohol Detection", TechnologyUsed="Android Studio, JSON Parsing", LanguageUsed="Java, Php, Volly, JSON Parse", StartYear=2019, EndYear=2019, Description="Project as a part of study", UserID=102 },
                new Project{ProjectID=4, Title="Black Jack Game", TechnologyUsed="Android Studio, JSON Parsing", LanguageUsed="Java, Php, Volly, JSON Parse", StartYear=2021, EndYear=2021, Description="Project as a part of study", UserID=102},
                new Project{ProjectID=5, Title="Memory Game", TechnologyUsed="Android Studio, JSON Parsing", LanguageUsed="Java, Php, Volly, JSON Parse", StartYear=2021, EndYear=2021, Description="Project as a part of study", UserID=101}
           };
            foreach (Project project in projects)
            {
                context.Projects.Add(project);
            }
            context.SaveChanges();

            var interests = new Interest[]
            {
                new Interest{HobbyID=1,Name="Playing Football", UserID=100},
                new Interest{HobbyID=2, Name="Reading Novel", UserID=100},
                new Interest{HobbyID=3, Name="Traveling", UserID=100},
                new Interest{HobbyID=4, Name="Dancing", UserID=100},
                new Interest{HobbyID=5, Name="Listening Music", UserID=100}
            };
            foreach (Interest hobby in interests)
            {
                context.Interests.Add(hobby);
            }
            context.SaveChanges();

        }
     }      
}
