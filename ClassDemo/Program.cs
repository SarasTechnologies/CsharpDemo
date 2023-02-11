// Initialize class and create employee object
// Pass the values to constructor
Employee employee = new Employee("James", "Chennai", 30, "+91-12345 67890");

// Set the LastName property value
employee.LastName = "Bennett";

// Get and display the property values
Console.WriteLine("First Name: {0}", employee.FirstName);
Console.WriteLine("Last Name: {0}", employee.LastName);
Console.WriteLine("Address: {0}", employee.Address);
Console.WriteLine("Age: {0}", employee.Age);
Console.WriteLine("Contact Number: {0}", employee.ContactNumber);

// Call the method
Console.WriteLine("Hiring status: {0}", employee.IsHired());