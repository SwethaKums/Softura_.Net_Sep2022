namespace EmployeeApp.Models
{
    public class EmployeeDetails
    {
        public int EmpId { get; set; }
    
        public string EmpFirstName { get; set; }

        public string EmpLastName { get; set; }

        public string EmpGender { get; set; }


        public static List<EmployeeDetails> GetEmployeeDetails()
        {
            List<EmployeeDetails> empDetails = new List<EmployeeDetails>()
            {
                new EmployeeDetails(){EmpId=1,EmpFirstName="swetha",EmpLastName="kumar",EmpGender="female"},
                new EmployeeDetails(){EmpId=2,EmpFirstName="divya",EmpLastName="venkat",EmpGender="female"},
                new EmployeeDetails(){EmpId=3,EmpFirstName="sandhya",EmpLastName="venkat",EmpGender="female"},
                new EmployeeDetails(){EmpId=4,EmpFirstName="sumithra",EmpLastName="babu",EmpGender="female"}
            };
            return empDetails;
        }
    }
}
