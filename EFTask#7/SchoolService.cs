namespace EFTask_7;

public class SchoolService
{
	private readonly SchoolContext _context;
	public SchoolService(SchoolContext context)
	{
		_context = context;
	}

	// Get all teacher by pupil's name
	public Teacher[] GetAllTeachersByStudent(string studentName)
	{
		var teachers = _context.Teachers
			.Where(t => t.Pupils.Any(p => p.FirstName == studentName))
			.ToArray();

		return teachers;
	}

	// Add a new teacher
	public void AddTeacher(Teacher teacher)
	{
		_context.Teachers.Add(teacher);
		_context.SaveChanges();
	}
	// Add a new pupil
	public void AddPupil(Pupil pupil)
	{
		_context.Pupils.Add(pupil);
		_context.SaveChanges();
	}

	// Get all teachers
	public List<Teacher> GetAllTeachers()
	{
		return _context.Teachers.ToList();
	}
	// Get all pupils
	public List<Pupil> GetAllPupils()
	{
		return _context.Pupils.ToList();
	}
}
