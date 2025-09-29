namespace EFTask_7;

public class Pupil
{
	public int PupilId { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Gender { get; set; }
	public string Class { get; set; }

	// Many-to-Many relationship
	public ICollection<Teacher> Teachers { get; set; }
}
