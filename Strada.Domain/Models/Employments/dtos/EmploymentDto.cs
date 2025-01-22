﻿namespace Strada.Domain.Models.Employments.dtos
{
    public class EmploymentDto
    {
        public int Id { get; set; }
        public string? Company { get; set; }
        public int MonthsOfExperience { get; set; }
        public int Salary { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
