using System;
using System.Collections.Generic;

namespace SchoolApp.Models;

public partial class Teacher
{
    public int Id { get; set; }

    public string Institution { get; set; } = null!;      // Για αποφυγή του warning

    public string? PhoneNumber { get; set; }

    public int UserId { get; set; }      // FK της DB

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    public virtual User User { get; set; } = null!;    // navigation - same as UserId. With UserId Queries
}
