using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_2._1.Models;

namespace WebAPI_2._1.Data
{
    public class DummyData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<HealthContext>();
                context.Database.EnsureCreated();

                if (context.Ailments != null && context.Ailments.Any())
                    return;

                var ailments = GetAilments().ToArray();
                context.Ailments.AddRange(ailments);
                context.SaveChanges();

                var medications = GetMedications().ToArray();
                context.Medications.AddRange(medications);
                context.SaveChanges();

                var patients = GetPatients(context).ToArray();
                context.Patients.AddRange(patients);
                context.SaveChanges();
            }


        }

        public static List<Ailment> GetAilments()
        {
            List<Ailment> ailments = new List<Ailment>()
                {
                    new Ailment {Name="Cold"}
                };
            return ailments;
        }

        public static List<Medication> GetMedications()
        {
            List<Medication> medications = new List<Medication>()
                {
                    new Medication {Name="Tylenol", Doses="2"}
                };
            return medications;
        }

        public static List<Patient> GetPatients(HealthContext db)
        {
            List<Patient> patients = new List<Patient>()
            {
                new Patient
                {
                    Name = "Jose",
                    Ailments = new List<Ailment>(db.Ailments.Take(1)),
                    Medications = new List<Medication>(db.Medications.Take(1)),
                }
            };

            return patients;
        }
    }
}
