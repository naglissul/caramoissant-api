using CaramoissantApi.Models;

namespace CaramoissantApi.Infrastructure
{
    public interface ICaramoissantService
    {
        public Task Add(Caramoissant caramoissant);
        public Task<Caramoissant> Get(int id);
        public Task<List<Caramoissant>> GetAll();
        public Task<Caramoissant> Delete(int id);
        public Task SaveAll();

    }
}
