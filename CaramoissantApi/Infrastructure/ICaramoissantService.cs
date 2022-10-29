using CaramoissantApi.Models;

namespace CaramoissantApi.Infrastructure
{
    public interface ICaramoissantService
    {
        public Task Add(Caramoissant caramoissant);
        public Task<CaramoissantViewModel> Get(int id);
        public Task<List<Caramoissant>> GetAll();
        public Task Delete(int id);
        public Task SaveAll();

    }
}
