//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Apartment
    {
        public int ID { get; set; }
        public int HouseID { get; set; }
        public string Number { get; set; }
        public double Area { get; set; }
        public int CountOfRooms { get; set; }
        public int Section { get; set; }
        public int Floor { get; set; }
        public bool IsSold { get; set; }
        public int BuildingCost { get; set; }
        public int ApartmentValueAdded { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual House House { get; set; }
    }
}
