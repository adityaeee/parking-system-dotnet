using System;
using System.Linq;

namespace ParkingSystem.Models {
     class ParkingLot {
          private int totalSlots;
          private Vehicle[] slots;

          public ParkingLot(int totalSlots) {
               this.totalSlots = totalSlots;
               this.slots = new Vehicle[totalSlots];
          }

          public int ParkVehicle( Vehicle vehicle) {
               for (int i = 0; i < totalSlots; i++) {
                    if (slots[i] == null) {
                         slots[i] = vehicle;
                         return i;
                    }
               }
               return -1;
          }

          public void Leave (int slotNumber) {
               if (slotNumber >= 0 && slotNumber < totalSlots) {
                    slots[slotNumber] = null;
                    // Console.WriteLine($"Slot number {slotNumber} is freee");
               }
          }

          public void Status () {
                Console.WriteLine("Slot\tNo.\t\tType\tColour");

                for (int i = 0; i < totalSlots; i++) {
                    if(slots[i] != null) {
                         Console.WriteLine($"{i + 1}\t{slots[i].RegistrationNumber}\t{slots[i].Type}\t{slots[i].Color}");
                    }
                }
          }

          public void CountByType (string type) {
               int count = slots.Count(slot => slot != null && slot.Type.ToLower() == type.ToLower());
               Console.WriteLine(count);
          }

          public void RegNosByOddEven (bool isOdd) {
               var regNos = slots
               .Where(slot => slot != null && ((int.Parse(slot.RegistrationNumber.Split('-')[1])% 2 == 1) ==isOdd))
               .Select(slot => slot.RegistrationNumber);

               Console.WriteLine(string.Join(", ", regNos));
          }

          public void RegNosByColor(string color) {
            var regNos = slots
                .Where(slot => slot != null && slot.Color.ToLower() == color.ToLower())
                .Select(slot => slot.RegistrationNumber);

            Console.WriteLine(string.Join(", ", regNos));
          }

          public void SlotsByColor(string color) {
            var slotNumbers = slots
                .Select((slot, index) => new { slot, index })
                .Where(x => x.slot != null && x.slot.Color.ToLower() == color.ToLower())
                .Select(x => x.index + 1);

            Console.WriteLine(string.Join(", ", slotNumbers));
          }

          public void SlotByRegNo(string regNo) {
            int slotNumber = Array.FindIndex(slots, slot => slot != null && slot.RegistrationNumber == regNo);
            if (slotNumber != -1)
            {
                Console.WriteLine(slotNumber + 1);
            }
            else
            {
                Console.WriteLine("Not found");
            }
          }
     }
}