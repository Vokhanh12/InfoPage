using System.ComponentModel.DataAnnotations.Schema;

namespace MyApplication.Enties{
[Table("Users")]
public class User
{
    [Column("id")]
    public string Id { get; set; }
    [Column("firstName")]
    public string FirstName { get; set; }
    [Column("lastName")]
    public string LastName { get; set; }
    [Column("joining_date")]
    public DateTime JoiningDate { get; set; }
    [Column("officialJoining_date")]
    public DateTime OfficialJoiningDate { get; set; }
    [Column("seniority_date")]
    public DateTime SeniorityDate { get; set; }
    [Column("workGroup")]
    public string WorkGroup { get; set; }
    [Column("department")]
    public string Department { get; set; }
    [Column("jobTitle")]
    public string JobTitle { get; set; }

    public User() {}

    public User(string id, string firstName, string lastName, DateTime joiningDate, DateTime officialJoiningDate, DateTime seniorityDate, string workGroup, string department, string jobTitle)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        JoiningDate = joiningDate;
        OfficialJoiningDate = officialJoiningDate;
        SeniorityDate = seniorityDate;
        WorkGroup = workGroup;
        Department = department;
        JobTitle = jobTitle;
    }
}
}

