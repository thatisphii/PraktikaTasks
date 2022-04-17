using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraktikaCar.DTOs
{
    public class CarToListDTO
    {
        
        public int CarId { get; set; }
      
        public string Model { get; set; }
      
        public string Brand { get; set; }
  
        public string Color { get; set; }
   
        public string Year { get; set; }


        public bool isDeleted { get; set; }
    }
}
