using Microsoft.AspNetCore.Mvc;

namespace CaramoissantApi.Controllers
{
    public class CroissantViewModel
    {
        public int Id { set; get; }
        public string? Address { set; get; }
        public DateTime? Date { set; get; } = DateTime.Now;

    }
}