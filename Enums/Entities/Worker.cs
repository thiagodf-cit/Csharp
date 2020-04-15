using System;
using System.Globalization;
using System.Collections.Generic;
using CourseEnums.Entities;
using CourseEnums.Entities.Enums;

namespace CourseEnuns.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary)
        {

        }

        public void AddContract(HourContract contract)
        {

        }

        public void RemoveContract(HourContract contract)
        {

        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;


            return sum;
        }
    }
}