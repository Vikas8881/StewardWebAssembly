using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Model;
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
        new IdentityRole { Name = "Admin", NormalizedName = "ADMIN",Id="de4ccc9c-2743-4c14-aa50-394d66c3b17b" },
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


            builder.Entity<GenDiagnosis>().HasData(
                new GenDiagnosis { Id = 1, Diagnosis = "ABD DISTENTION OCCASIONALLY" },
                new GenDiagnosis { Id = 2, Diagnosis = "ABDOMEN" },
                new GenDiagnosis { Id = 3, Diagnosis = "ABDOMINAL CRAMPS" },
                new GenDiagnosis { Id = 4, Diagnosis = "ACUTE RETENTION OF URINE TWICE" },
                new GenDiagnosis { Id = 5, Diagnosis = "ACUTE RESPIRATORY TRACT INFECTION" },
                new GenDiagnosis { Id = 6, Diagnosis = "ACUTE CHEST PAIN" },
                new GenDiagnosis { Id = 7, Diagnosis = "ACUTE RHINITIS" },
                   new GenDiagnosis { Id = 8, Diagnosis = "ACUTE KIDNEY INJURY" },
                   new GenDiagnosis { Id = 9, Diagnosis = "ACUTE GASTROENTERITIS" },
                   new GenDiagnosis { Id = 10, Diagnosis = "ACUTE LOW BACK PAIN" },
                   new GenDiagnosis { Id = 11, Diagnosis = "ACUTE RHINOSINUSITIS" },
                   new GenDiagnosis { Id = 12, Diagnosis = "ACUTE BRONCHITIS" },
                   new GenDiagnosis { Id = 13, Diagnosis = "ACUTE ABDOMINAL PAIN" },
                   new GenDiagnosis { Id = 14, Diagnosis = "Acne" },
                   new GenDiagnosis { Id = 15, Diagnosis = "ACID ERUCTATION ACID PEPTIC DISEASE ACIDITY" },
                   new GenDiagnosis { Id = 16, Diagnosis = "ACANTHOSIS NIGRICANS" },
                   new GenDiagnosis { Id = 17, Diagnosis = "ACHE ACHYMOSIS" },
                   new GenDiagnosis { Id = 18, Diagnosis = "ACNE VULGARIS" },
                   new GenDiagnosis { Id = 19, Diagnosis = "ACROMEGALY" },
                   new GenDiagnosis { Id = 20, Diagnosis = "ACUTE BRONCHITIS" },
                   new GenDiagnosis { Id = 21, Diagnosis = "ACUTE CHEST PAIN" },
                   new GenDiagnosis { Id = 23, Diagnosis = "ACUTE DIARRHOEA" },
                   new GenDiagnosis { Id = 24, Diagnosis = "ACUTE EXACERBATION" },
                   new GenDiagnosis { Id = 25, Diagnosis = "ACUTE FEBRILE ILLNESS" },
                   new GenDiagnosis { Id = 26, Diagnosis = "ACUTE GASTROENTERITIS" },
                   new GenDiagnosis { Id = 27, Diagnosis = "ACUTE GASTRITIS" },
                   new GenDiagnosis { Id = 28, Diagnosis = "ACUTE KIDNEY INJURY" },
                   new GenDiagnosis { Id = 29, Diagnosis = "ACUTE LOW BACK PAIN" },
                   new GenDiagnosis { Id = 30, Diagnosis = "ACUTE OTITIS EXTERNA" },
                   new GenDiagnosis { Id = 31, Diagnosis = "ACUTE RETENTION OF URINE TWICE" },
                   new GenDiagnosis { Id = 32, Diagnosis = "ACUTE RESPIRATORY TRACT INFECTION" },
                   new GenDiagnosis { Id = 33, Diagnosis = "ACUTE RHINITIS" },
                   new GenDiagnosis { Id = 34, Diagnosis = "ACUTE RHINOSINUSITIS" },
                   new GenDiagnosis { Id = 35, Diagnosis = "ACUTE VERTIGO" },
                   new GenDiagnosis { Id = 36, Diagnosis = "ADMIT" },
                   new GenDiagnosis { Id = 37, Diagnosis = "AEROPHAGIA" },
                   new GenDiagnosis { Id = 38, Diagnosis = "AFTER DEFECATION" },
                   new GenDiagnosis { Id = 39, Diagnosis = "AFEBRILE" },
                   new GenDiagnosis { Id = 40, Diagnosis = "AGGRESSIVE" },
                   new GenDiagnosis { Id = 41, Diagnosis = "AGITATED DEPRESSION" },
                   new GenDiagnosis { Id = 42, Diagnosis = "AGGRESSION" },
                   new GenDiagnosis { Id = 43, Diagnosis = "AGITATION" },
                   new GenDiagnosis { Id = 44, Diagnosis = "AGORAPHOBIA" },
                   new GenDiagnosis { Id = 45, Diagnosis = "AGGRESSION LESS" },
                   new GenDiagnosis { Id = 46, Diagnosis = "AHO RTA" },
                   new GenDiagnosis { Id = 47, Diagnosis = "AID TYPE 1" },
                   new GenDiagnosis { Id = 48, Diagnosis = "AIR HUNGER" },
                   new GenDiagnosis { Id = 49, Diagnosis = "AID TYPE 2" },
                   new GenDiagnosis { Id = 50, Diagnosis = "ALBUMINURIA" },
                   new GenDiagnosis { Id = 51, Diagnosis = "ALCHOL INTAKE DAILY" },
                   new GenDiagnosis { Id = 52, Diagnosis = "ALCOHOLIC" },
                   new GenDiagnosis { Id = 53, Diagnosis = "ALLERGY" },
                   new GenDiagnosis { Id = 54, Diagnosis = "ALLERGIC WHOLE BODY RASHES" },
                   new GenDiagnosis { Id = 55, Diagnosis = "ALLERGIC BRONCHITIS" },
                   new GenDiagnosis { Id = 56, Diagnosis = "ALLERGIC CONJUNCTIVITIS" },
                   new GenDiagnosis { Id = 57, Diagnosis = "ALLERGIC RHINITIS" },
                   new GenDiagnosis { Id = 58, Diagnosis = "ALLERGIC RASHES" },
                   new GenDiagnosis { Id = 59, Diagnosis = "ALLERGIC COUGH" },
                   new GenDiagnosis { Id = 60, Diagnosis = "ALOPECIA" },
                   new GenDiagnosis { Id = 61, Diagnosis = "ALTERNATING CONSTIPATENT" },
                   new GenDiagnosis { Id = 62, Diagnosis = "ALTERED TASTE" },
                   new GenDiagnosis { Id = 63, Diagnosis = "ALTERATION OF TASTE" },
                   new GenDiagnosis { Id = 64, Diagnosis = "ALTERED BOWEL HABIT" },
                   new GenDiagnosis { Id = 65, Diagnosis = "ALTERED SENSORIUM" },
                   new GenDiagnosis { Id = 66, Diagnosis = "ALTERED VOICE" },
                   new GenDiagnosis { Id = 67, Diagnosis = "ALTERED SLEEP" },
                   new GenDiagnosis { Id = 68, Diagnosis = "AMPTATION BELOW KNEE" },
                   new GenDiagnosis { Id = 69, Diagnosis = "AMOTIVATION" },
                   new GenDiagnosis { Id = 70, Diagnosis = "AMENORRHEA" },
                   new GenDiagnosis { Id = 71, Diagnosis = "AMNESIA" },
                   new GenDiagnosis { Id = 72, Diagnosis = "ANAEMIA" },
                   new GenDiagnosis { Id = 73, Diagnosis = "ANAL ITCHING" },
                   new GenDiagnosis { Id = 74, Diagnosis = "ANAL BURNING" },
                   new GenDiagnosis { Id = 75, Diagnosis = "ANASARCA" },
                   new GenDiagnosis { Id = 76, Diagnosis = "ANAL FISSURE" },
                   new GenDiagnosis { Id = 77, Diagnosis = "ANAL PAIN" },
                   new GenDiagnosis { Id = 78, Diagnosis = "ANDROGENETIC ALOPECIA" },
                   new GenDiagnosis { Id = 79, Diagnosis = "ANEMIA" },
                   new GenDiagnosis { Id = 80, Diagnosis = "ANERGIA" },
                   new GenDiagnosis { Id = 81, Diagnosis = "ANGER" },
                   new GenDiagnosis { Id = 82, Diagnosis = "ANGINA" },
                   new GenDiagnosis { Id = 83, Diagnosis = "ANHEDONIA" },
                   new GenDiagnosis { Id = 84, Diagnosis = "ANKLE SWELLING" },
                   new GenDiagnosis { Id = 85, Diagnosis = "ANKLE JOINT PAIN" },
                   new GenDiagnosis { Id = 86, Diagnosis = "ANKLE PAIN" },
                   new GenDiagnosis { Id = 87, Diagnosis = "ANKLE INJURY" }
                );

        }
    }
}
