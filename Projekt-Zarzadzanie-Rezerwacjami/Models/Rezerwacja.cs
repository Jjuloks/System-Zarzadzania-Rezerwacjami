
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Projekt_Zarzadzanie_Rezerwacjami.Models
  
{
    public class Rezerwacja
    {
        public int Id { get; set; }
        public string? Name { get; set; }


        [DisplayName("Reservation Date")]
        public DateTime ReservationDate { get; set; }
        [DataType(DataType.Date)]

        public DateTime Duration { get; set; }

        public int Rozmiar { get; set; }
        
        public Boolean IsExclusive { get; set; }
    }
}
