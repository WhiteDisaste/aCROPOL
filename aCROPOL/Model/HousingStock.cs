//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aCROPOL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class HousingStock
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HousingStock()
        {
            this.Manager = new HashSet<Manager>();
        }
    
        public int ID { get; set; }
        public string FloorsBuilding { get; set; }
        public int Occupied { get; set; }
        public System.DateTime YearConstruction { get; set; }
        public int IDLocation { get; set; }
        public int NumberRooms { get; set; }
        public int IDNumberBathrooms { get; set; }
        public bool Conditioners { get; set; }
        public decimal SummaObjectCadastre { get; set; }
        public decimal MarketValueObject { get; set; }
        public decimal RentalCost { get; set; }
        public int IDReantalBuildings { get; set; }
    
        public virtual Bathrooms Bathrooms { get; set; }
        public virtual Location Location { get; set; }
        public virtual RentalBuildings RentalBuildings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Manager> Manager { get; set; }
    }
}
