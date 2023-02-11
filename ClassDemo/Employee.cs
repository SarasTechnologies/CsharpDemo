public class Employee
{
    // Field
    private static string defaultStatus = "Hired";

    // Property
    public string FirstName { get; set; }
	public string? LastName { get; set; }
	public string Address { get; set; }
	public int Age { get; set; }
	public string ContactNumber { get; set; }
    public string Status { get; set; } = defaultStatus; // Assigned default values to property

    // Constructor
	public Employee(string firstName, string address, int age, string contactNumber)
    {
        FirstName = firstName;
        Address = address;
        Age = age;
        ContactNumber = contactNumber;
    }

    // Method
    public bool IsHired()
    {
        if (Status == "Hired")
        {
            return true;
        }

        return false;
    }
}
