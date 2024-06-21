// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using ParkingSystem.Models;

namespace ParkingSystem{
     class Program {
          // static ParkingLot parkingLot;

          static void Main(string[] args) {
               // Console.Write("Enter commands : " );

               while (true) {
                    Console.Write("\n ~ ~ Enter commands : " );
                    string commands = Console.ReadLine();
                    string[] commandParts = commands.Split(' ');

                    switch (commandParts[0])
                    {

                         case "exit" :
                              Console.WriteLine("GoodByeee");
                              return;
                         
                         default:
                              Console.WriteLine("Invalid command");
                              break;
                    }
               }
          }
     }
}


