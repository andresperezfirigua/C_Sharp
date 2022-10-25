using System;

namespace InheritanceChallenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Andres Perez","Andres",480);
            Boss boss = new Boss("Harold Jenkings", "Harold", 420, "Renault Sandero");
            Trainee trainee = new Trainee("William Hugh", "Wil", 440, 45, 20);
            boss.Lead();
            trainee.Work();

        }
    }
}
