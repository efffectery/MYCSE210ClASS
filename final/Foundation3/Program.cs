using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("4822 67th E", "alabama", "ohio", "USA");
        Lectures lecture = new Lectures("How to eat", "This is a lecture on how to eat food using a fork and spoon", "03-29-2000", "6:15AM", address1, "Lecture", "Joe Mama", 30);

        Address address2 = new Address("3892 91th N", "Nork", "England", "UK");
        Receptions reception = new Receptions("Wedding of the Barnys", "This is the reception of the Barnys wedding", "08-12-1990", "1:15PM", address1, "Reception", "Barnys@gmail.com");

        Address address3 = new Address("8472 3th S", "idaho falls", "Idaho", "USA");
        OutDoorGatherings outDoorGathering = new OutDoorGatherings("Picnic", "Picnic for the Idahoan 3rd graders", "10-1-2011", "12:00PM", address3, "OutDoorgatherings", "Sunny");

        lecture.StandardDetails();
        lecture.FullDetails();
        lecture.ShortDescription();
        Console.WriteLine();
        
        reception.StandardDetails();
        Console.WriteLine();
        reception.FullDetails();
        reception.ShortDescription();
        Console.WriteLine();

        outDoorGathering.StandardDetails();
        Console.WriteLine();
        outDoorGathering.FullDetails();
        outDoorGathering.ShortDescription();
    }
}