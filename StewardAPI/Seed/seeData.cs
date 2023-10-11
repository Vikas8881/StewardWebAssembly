using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Model;
using StewardAPI.Models;

namespace StewardAPI.Seed
{
    public static class ModelBuilderExtensions
    {

        public static void Seed(this ModelBuilder builder)
        {

            // Seed Roles

            List<IdentityRole> roles = new List<IdentityRole>()
    {
        new IdentityRole { Name = "Admin", NormalizedName = "ADMIN",Id="de4ccc9c-2743-4c14-aa50-394d66c3b17b"},
        new IdentityRole { Name = "User", NormalizedName = "USER",Id= "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc" }
    };

            builder.Entity<IdentityRole>().HasData(roles);

            // -----------------------------------------------------------------------------

            // Seed Users

            var passwordHasher = new PasswordHasher<ApplicationUser>();

            List<ApplicationUser> users = new List<ApplicationUser>()
    {
         // imporant: don't forget NormalizedUserName, NormalizedEmail 
                 new ApplicationUser {
                     FirstName="Vikas",
                     LastName="Malik",
                     UserName = "vikasmalik8881@gmail.com",
                     NormalizedUserName = "VIKASMALIK8881@GMAIL.COM",
                     Email = "vikasmalik8881@gmail.com",
                     NormalizedEmail = "VIKASMALIK8881@GMAIL.COM",
                     HospitalID="Vikas0001"
               },

                new ApplicationUser {
                     FirstName="Vikas",
                     LastName="Malik",
                     UserName = "Vmalik@gmail.com",
                     NormalizedUserName = "VMALIK@GMAIL.COM",
                     Email = "Vmalik@gmail.com",
                     NormalizedEmail = "VMALIK@GMAIL.COM",
                      HospitalID="Vikas0002"
              },
    };


            builder.Entity<ApplicationUser>().HasData(users);

            ///----------------------------------------------------

            // Seed UserRoles


            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();

            // Add Password For All Users

            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "Urmylifeak@123");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "Urmylifeak@123");

            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[1].Id,
                RoleId =
            roles.First(q => q.Name == "User").Id
            });

            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[0].Id,
                RoleId =
            roles.First(q => q.Name == "Admin").Id
            });


            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);


            //builder.Entity<GenDignosis>().HasData(
              
            //    new GenDignosis { DignosisId = 1, DignosisName = "ABD DISTENTION OCCASIONALLY", valueID=Guid.NewGuid().ToString()},
            //    new GenDignosis { DignosisId = 1, DignosisName = "ABD DISTENTION OCCASIONALLY" , valueID=Guid.NewGuid().ToString() },
            //    new GenDignosis { DignosisId = 2, DignosisName = "ABDOMEN" , valueID=Guid.NewGuid().ToString() },
            //    new GenDignosis { DignosisId = 3, DignosisName = "ABDOMINAL CRAMPS" , valueID=Guid.NewGuid().ToString() },
            //    new GenDignosis { DignosisId = 4, DignosisName = "ACUTE RETENTION OF URINE TWICE" , valueID=Guid.NewGuid().ToString() },
            //    new GenDignosis { DignosisId = 5, DignosisName = "ACUTE RESPIRATORY TRACT INFECTION" , valueID=Guid.NewGuid().ToString() },
            //    new GenDignosis { DignosisId = 6, DignosisName = "ACUTE CHEST PAIN" , valueID=Guid.NewGuid().ToString() },
            //    new GenDignosis { DignosisId = 7, DignosisName = "ACUTE RHINITIS" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 8, DignosisName = "ACUTE KIDNEY INJURY" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 9, DignosisName = "ACUTE GASTROENTERITIS" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 10, DignosisName = "ACUTE LOW BACK PAIN" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 11, DignosisName = "ACUTE RHINOSINUSITIS" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 12, DignosisName = "ACUTE BRONCHITIS" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 13, DignosisName = "ACUTE ABDOMINAL PAIN" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 14, DignosisName = "Acne" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 15, DignosisName = "ACID ERUCTATION ACID PEPTIC DISEASE ACIDITY" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 16, DignosisName = "ACANTHOSIS NIGRICANS" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 17, DignosisName = "ACHE ACHYMOSIS" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 18, DignosisName = "ACNE VULGARIS" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 19, DignosisName = "ACROMEGALY" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 20, DignosisName = "ACUTE BRONCHITIS" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 21, DignosisName = "ACUTE CHEST PAIN" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 23, DignosisName = "ACUTE DIARRHOEA" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 24, DignosisName = "ACUTE EXACERBATION" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 25, DignosisName = "ACUTE FEBRILE ILLNESS" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 26, DignosisName = "ACUTE GASTROENTERITIS" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 27, DignosisName = "ACUTE GASTRITIS" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 28, DignosisName = "ACUTE KIDNEY INJURY" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 29, DignosisName = "ACUTE LOW BACK PAIN" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 30, DignosisName = "ACUTE OTITIS EXTERNA" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 31, DignosisName = "ACUTE RETENTION OF URINE TWICE" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 32, DignosisName = "ACUTE RESPIRATORY TRACT INFECTION" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 33, DignosisName = "ACUTE RHINITIS" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 34, DignosisName = "ACUTE RHINOSINUSITIS" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 35, DignosisName = "ACUTE VERTIGO" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 36, DignosisName = "ADMIT" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 37, DignosisName = "AEROPHAGIA" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 38, DignosisName = "AFTER DEFECATION" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 39, DignosisName = "AFEBRILE" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 40, DignosisName = "AGGRESSIVE" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 41, DignosisName = "AGITATED DEPRESSION" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 42, DignosisName = "AGGRESSION" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 43, DignosisName = "AGITATION" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 44, DignosisName = "AGORAPHOBIA" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 45, DignosisName = "AGGRESSION LESS" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 46, DignosisName = "AHO RTA" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 47, DignosisName = "AID TYPE 1" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 48, DignosisName = "AIR HUNGER" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 49, DignosisName = "AID TYPE 2" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 50, DignosisName = "ALBUMINURIA" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 51, DignosisName = "ALCHOL INTAKE DAILY" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 52, DignosisName = "ALCOHOLIC" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 53, DignosisName = "ALLERGY" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 54, DignosisName = "ALLERGIC WHOLE BODY RASHES" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 55, DignosisName = "ALLERGIC BRONCHITIS" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 56, DignosisName = "ALLERGIC CONJUNCTIVITIS" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 57, DignosisName = "ALLERGIC RHINITIS" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 58, DignosisName = "ALLERGIC RASHES" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 59, DignosisName = "ALLERGIC COUGH" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 60, DignosisName = "ALOPECIA" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 61, DignosisName = "ALTERNATING CONSTIPATENT" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 62, DignosisName = "ALTERED TASTE" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 63, DignosisName = "ALTERATION OF TASTE" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 64, DignosisName = "ALTERED BOWEL HABIT" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 65, DignosisName = "ALTERED SENSORIUM" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 66, DignosisName = "ALTERED VOICE" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 67, DignosisName = "ALTERED SLEEP" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 68, DignosisName = "AMPTATION BELOW KNEE" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 69, DignosisName = "AMOTIVATION" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 70, DignosisName = "AMENORRHEA" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 71, DignosisName = "AMNESIA" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 72, DignosisName = "ANAEMIA" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 73, DignosisName = "ANAL ITCHING" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 74, DignosisName = "ANAL BURNING" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 75, DignosisName = "ANASARCA" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 76, DignosisName = "ANAL FISSURE" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 77, DignosisName = "ANAL PAIN" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 78, DignosisName = "ANDROGENETIC ALOPECIA" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 79, DignosisName = "ANEMIA" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 80, DignosisName = "ANERGIA" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 81, DignosisName = "ANGER" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 82, DignosisName = "ANGINA" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 83, DignosisName = "ANHEDONIA" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 84, DignosisName = "ANKLE SWELLING" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 85, DignosisName = "ANKLE JOINT PAIN" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 86, DignosisName = "ANKLE PAIN" , valueID=Guid.NewGuid().ToString() },
            //       new GenDignosis { DignosisId = 87, DignosisName = "ANKLE INJURY" }
            //    );

        }
    }
}
