using System;

namespace FisherInsurance.Models

{

    public class Claims 
    {
        public int Id { get; set; }
        public string PolicyTYpe { get; set; }
        public DateTime LossDate { get; set; }
        public decimal LossAmount { get; set; }
    }
    
}