namespace EFTask_7;

internal class Program
{
	static void Main(string[] args)
	{
		using (var context = new SchoolContext())
		{
			// Database
			context.Database.EnsureCreated();

			// Seed
			if (!context.Teachers.Any() && !context.Pupils.Any())
			{
				var pupil1 = new Pupil { FirstName = "George", LastName = "Anderson", Gender = "Male", Class = "10A" };
				var pupil2 = new Pupil { FirstName = "Anna", LastName = "Taylor", Gender = "Female", Class = "10B" };
				var pupil3 = new Pupil { FirstName = "David", LastName = "Thomas", Gender = "Male", Class = "11A" };
				var pupil4 = new Pupil { FirstName = "Emma", LastName = "Moore", Gender = "Female", Class = "11B" };
				var pupil5 = new Pupil { FirstName = "James", LastName = "Martin", Gender = "Male", Class = "10A" };

				context.Pupils.AddRange(pupil1, pupil2, pupil3, pupil4, pupil5);

				var teacher1 = new Teacher { FirstName = "John", LastName = "Smith", Gender = "Male", Subject = "Math", Pupils = new List<Pupil> { pupil1, pupil2 } };
				var teacher2 = new Teacher { FirstName = "Emily", LastName = "Johnson", Gender = "Female", Subject = "English", Pupils = new List<Pupil> { pupil1, pupil3 } };
				var teacher3 = new Teacher { FirstName = "Michael", LastName = "Brown", Gender = "Male", Subject = "Physics", Pupils = new List<Pupil> { pupil4, pupil5 } };
				var teacher4 = new Teacher { FirstName = "Sophia", LastName = "Davis", Gender = "Female", Subject = "History", Pupils = new List<Pupil> { pupil2, pupil4 } };
				var teacher5 = new Teacher { FirstName = "Daniel", LastName = "Wilson", Gender = "Male", Subject = "Biology", Pupils = new List<Pupil> { pupil1, pupil5 } };

				context.Teachers.AddRange(teacher1, teacher2, teacher3, teacher4, teacher5);

				context.SaveChanges();
			}

			// Test
			var service = new SchoolService(context);
			var teachersOfGeorge = service.GetAllTeachersByStudent("George");

			Console.WriteLine("Teachers who teach George:");
			foreach (var teacher in teachersOfGeorge)
			{
				Console.WriteLine($"{teacher.FirstName} {teacher.LastName} - {teacher.Subject}");
			}
		}
	}
}

