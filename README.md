# Parking System

Sistem Parkir berbasis .NET 5  yang menggunakan console untuk mengelola tempat parkir. Sistem ini memungkinkan Anda untuk memarkir kendaraan, mencatat nomor polisi, jenis, dan warna kendaraan, serta menghasilkan laporan terkait penggunaan tempat parkir.

**note: disini .NET di device saya terupdate menjadi versi 8, namun dalam pembuatannya masih menggunakan fitur .NET versi 5 sehingga masih relevan untuk di jalankan di tempat yang masih menggunakan .NET 5

## Fitur

-   **Check-In**: Memungkinkan kendaraan masuk dan mencatat nomor polisi, jenis, dan warna kendaraan.
-   **Check-Out**: Mengeluarkan kendaraan dari tempat parkir, membuat lot tersedia untuk kendaraan lain.
-   **Report**: Menghasilkan berbagai laporan terkait penggunaan tempat parkir.

## Instalasi

1. **Kloning repository ini:**

    ```bash
    git clone <URL Repository>
    cd ParkingSystem
    ```

2. **Bangun proyek:**

    ```bash
    dotnet build
    ```

3. **Jalankan proyek:**

    ```bash
    dotnet run
    ```

## Penggunaan

Setelah menjalankan proyek, Anda dapat menggunakan perintah-perintah berikut di console untuk mengelola tempat parkir:

### Perintah Dasar

-   **Membuat Tempat Parkir:**

    ```bash
    create_parking_lot [jumlah_lot]
    ```

    Contoh:

    ```bash
    create_parking_lot 6
    ```

-   **Parkir Kendaraan:**

    ```bash
    park [nomor_polisi] [warna] [jenis_kendaraan]
    ```

    Contoh:

    ```bash
    park B-1234-XYZ Putih Mobil
    ```

-   **Keluar Kendaraan:**

    ```bash
    leave [nomor_lot]
    ```

    Contoh:

    ```bash
    leave 4
    ```

-   **Melihat Status Tempat Parkir:**

    ```bash
    status
    ```

### Perintah Laporan

-   **Jumlah Kendaraan Berdasarkan Jenis:**

    ```bash
    type_of_vehicles [jenis_kendaraan]
    ```

    Contoh:

    ```bash
    type_of_vehicles Motor
    ```

-   **Nomor Registrasi Berdasarkan Plat Ganjil/Genap:**

    ```bash
    registration_numbers_for_vehicles_with_odd_plate
    registration_numbers_for_vehicles_with_even_plate
    ```

    Contoh:

    ```bash
    registration_numbers_for_vehicles_with_odd_plate
    ```

-   **Nomor Registrasi Berdasarkan Warna:**

    ```bash
    registration_numbers_for_vehicles_with_colour [warna]
    ```

    Contoh:

    ```bash
    registration_numbers_for_vehicles_with_colour Putih
    ```

-   **Nomor Lot Berdasarkan Warna Kendaraan:**

    ```bash
    slot_numbers_for_vehicles_with_colour [warna]
    ```

    Contoh:

    ```bash
    slot_numbers_for_vehicles_with_colour Putih
    ```

-   **Nomor Lot Berdasarkan Nomor Registrasi:**

    ```bash
    slot_number_for_registration_number [nomor_polisi]
    ```

    Contoh:

    ```bash
    slot_number_for_registration_number B-1234-XYZ
    ```

## Contoh Penggunaan

```bash
$ create_parking_lot 6
Created a parking lot with 6 slots

$ park B-1234-XYZ Putih Mobil
Allocated slot number: 1

$ park B-9999-XYZ Putih Motor
Allocated slot number: 2

$ park D-0001-HIJ Hitam Mobil
Allocated slot number: 3

$ park B-7777-DEF Red Mobil
Allocated slot number: 4

$ park B-2701-XXX Biru Mobil
Allocated slot number: 5

$ park B-3141-ZZZ Hitam Motor
Allocated slot number: 6

$ leave 4
Slot number 4 is free

$ status
Slot    No.             Type    Registration No Colour
1       B-1234-XYZ      Mobil   B-1234-XYZ      Putih
2       B-9999-XYZ      Motor   B-9999-XYZ      Putih
3       D-0001-HIJ      Mobil   D-0001-HIJ      Hitam
5       B-2701-XXX      Mobil   B-2701-XXX      Biru
6       B-3141-ZZZ      Motor   B-3141-ZZZ      Hitam

$ park B-333-SSS Putih Mobil
Allocated slot number: 4

$ park A-1212-GGG Putih Mobil
Sorry, parking lot is full

$ type_of_vehicles Motor
2

$ type_of_vehicles Mobil
4

$ registration_numbers_for_vehicles_with_odd_plate
B-9999-XYZ, D-0001-HIJ, B-2701-XXX

$ registration_numbers_for_vehicles_with_even_plate
B-1234-XYZ, B-3141-ZZZ

$ registration_numbers_for_vehicles_with_colour Putih
B-1234-XYZ, B-9999-XYZ, B-333-SSS

$ slot_numbers_for_vehicles_with_colour Putih
1, 2, 4

$ slot_number_for_registration_number B-3141-ZZZ
6

$ slot_number_for_registration_number Z-1111-AAA
Not found

$ exit
```
