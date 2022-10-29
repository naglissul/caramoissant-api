using Microsoft.AspNetCore.Mvc;

namespace CaramoissantApi.Models
{
    public class CaramoissantPostModel
    {
        public string? Location { set; get; }
        public DateTime? Date { set; get; } = DateTime.Now;

    }
}