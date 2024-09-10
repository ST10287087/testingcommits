using System.ComponentModel.DataAnnotations;

namespace DraftTaskOne.Models
{
    public class Claims
    {
        //employee trying o submit a clam
        // id fn in dates range  start and end
        //hrs worked and rate per hour -- total amount
        //description
        //the attributes -- col in the table

        public int Id { get; set; }
        [Required]
        public string LeturerID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime ClaimPeriodStart { get; set; }
        [Required]
        public DateTime ClaimPeriodEnd { get; set; }
        [Required]
        public double HoursWorked { get; set; }
        [Required]
        public double RatePerHour { get; set; }
        [Required]
        public double TotalAmount { get; set; }
        public string DescriptionOfWork { get; set; }


    }
}
