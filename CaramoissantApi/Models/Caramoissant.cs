using Microsoft.AspNetCore.Mvc;

namespace CaramoissantApi.Models
{
    public class Caramoissant
    {
        public int Id { set; get; }
        public string? Location { set; get; }
        public DateTime? Date { set; get; } = DateTime.Now;

    }
}