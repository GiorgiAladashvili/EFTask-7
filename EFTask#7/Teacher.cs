namespace EFTask_7;

public class Teacher
{
	public int TeacherId { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Gender { get; set; }
	public string Subject { get; set; }

	// Many-to-Many relationship
	public ICollection<Pupil> Pupils { get; set; }
}
