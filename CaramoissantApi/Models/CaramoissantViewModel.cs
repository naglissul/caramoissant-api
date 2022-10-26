using Microsoft.AspNetCore.Mvc;

namespace CaramoissantApi.Controllers
{
    public class CaramoissantViewModel
    {
        public int Id { set; get; }
        public string? Location { set; get; }
        public DateTime? Date { set; get; } = DateTime.Now;

    }
}