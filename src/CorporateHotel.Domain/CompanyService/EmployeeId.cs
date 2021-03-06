﻿namespace CorporateHotel.Domain
{
    public class EmployeeId
    {

    }

    public class Employee
    {
        private readonly string name;
        public EmployeeId Id { get; }

        public Employee(string name)
        {
            Id = new EmployeeId();
            this.name = name;
        }

        public override string ToString() => name;
    }
}
