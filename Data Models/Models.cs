using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace АИС
{
    [Table("Car")]
    public class Car
    {
        public int CarId { get; set; }
        public string Number { get; set; }
        public string Model { get; set; }
        public double Consumption { get; set; }
        public int DriverId { get; set; }
        public string DriverName { get; set; }
        public Driver Driver { get; set; }
    }

    [Table("User")]
    public class User
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
        public string RoleType { get; set; }
        public Role Role { get; set; }
    }

    [Table("Role")]
    public class Role
    {
        public int RoleId { get; set; }
        public string Type { get; set; }

        public List<User> Users { get; set; }
    }

    [Table("Driver")]
    public class Driver
    {

        public int DriverId { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string PassportId { get; set; }
        public List<Car> Cars { get; set; }
    }

    [Table("Provider")]
    public class Provider
    {
        public int ProviderId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string PassportId { get; set; }
    }

    [Table("Client")]
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string PassportId { get; set; }
    }

    [Table("Tarif")]
    public class Tarif
    {
        public int TarifId { get; set; }
        public string Name { get; set; }
        public int PerKm { get; set; }
        public int PerKg { get; set; }
    }

    [Table("TypeCargo")]
    public class TypeCargo
    {
        public int TypeCargoId { get; set; }
        public string Name { get; set; }

    }

    [Table("Shipment")]
    public class Shipment
    {
        [Key]
        public int ShipmentId { get; set; }
        public int CarId { get; set; }
        public string CarNumber { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int TarifId { get; set; }
        public string TarifName { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string AddressLoad { get; set; }
        public string AddressUnload { get; set; }
        public double Km { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateCreate { get; set; }
        public bool IsConstantCustomer { get; set; }
    
    }
    [Table("Shipment")]
    public class ShipmentOut
    {
        [Key]
        public int ShipmentId { get; set; }
        public int CarId { get; set; }
        public int ClientId { get; set; }
        public int TarifId { get; set; }
        public int UserId { get; set; }
        public string AddressLoad { get; set; }
        public string AddressUnload { get; set; }
        public double Km { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateCreate { get; set; }
        public bool IsConstantCustomer { get; set; }

    }

    [Table("Shipment")]
    public class ShipmentMaxItem
    {
        [Key]
        public int ShipmentId { get; set; }
              
        public int MaxItem { get; set; }

    }
    [Table("Shipment")]
    public class ShipmentImport
    {
        [Key]
        public int ShipmentId { get; set; }

        public string ProviderName { get; set; }

    }

    [Table ("Item")]
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public double Weight { get; set; }
        public int TypeCargoId { get; set; }
        public string TypeCargo { get; set; }
        public int ProviderId { get; set; }
        public string ProviderName { get; set; }
        public int ShipmentId { get; set; }
    }

    [Table("Item")]
    public class ItemMaxId
    {
        [Key]
        public int ItemId { get; set; }
        public int MaxIndex { get; set; }
    }
}
