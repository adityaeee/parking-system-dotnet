// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using ParkingSystem.Models;

namespace ParkingSystem{
     class Program {
          static ParkingLot parkingLot;

          static void Main(string[] args) {
               // Console.Write("Enter commands : " );

               while (true) {
                    Console.Write("\n ~ ~ Enter commands : " );
                    string commands = Console.ReadLine();
                    string[] commandParts = commands.Split(' ');

                    switch (commandParts[0])
                    {
                         case "create_parking_lot" :
                              int lotCount = int.Parse(commandParts[1]);
                              parkingLot = new ParkingLot(lotCount);
                              Console.WriteLine($"Created a parking lot with {lotCount} slots");
                              break;

                         case "park":
                              string regNo = commandParts[1];
                              string color = commandParts[2];
                              string type = commandParts[3];
                              int slot = parkingLot.ParkVehicle(new Vehicle(regNo, color, type));
                              if (slot == -1) {
                                   Console.WriteLine("Sorry, parking lot is full");
                              } else {
                                    Console.WriteLine($"Allocated slot number: {slot + 1}");
                              }
                              break;

                         case "leave":
                              int slotNumber = int.Parse(commandParts[1]) -1;
                              parkingLot.Leave(slotNumber);
                              Console.WriteLine($"Slot number {slotNumber + 1} is free"); 
                              break;
                         
                         case "status":
                              parkingLot.Status();
                              break;

                         case "type_of_vehicles":
                              string vehicleType= commandParts[1];
                              parkingLot.CountByType(vehicleType);
                              break;

//                       registration_numbers_for_vehicles_with_odd_plate
                         case "registration_numbers_for_vehicles_with_odd_plate":
                              parkingLot.RegNosByOddEven(true);
                              break;

                         case "registration_numbers_for_vehicles_with_even_plate":
                              parkingLot.RegNosByOddEven(false);
                              break;

                         case "registration_numbers_for_vehicles_with_colour":
                              string colorQuery = commandParts[1];
                              parkingLot.RegNosByColor(colorQuery);
                              break;
                         
                         case "slot_numbers_for_vehicles_with_colour":
                              colorQuery = commandParts[1];
                              parkingLot.SlotsByColor(colorQuery);
                              break;

                         case "slot_number_for_registration_number": 
                              regNo = commandParts[1];
                              parkingLot.SlotByRegNo(regNo);
                              break;


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


