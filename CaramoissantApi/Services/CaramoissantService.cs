using AutoMapper;
using CaramoissantApi.Data;
using CaramoissantApi.Infrastructure;
using CaramoissantApi.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CaramoissantApi.Services
{
    public class CaramoissantService : ICaramoissantService
    {
        private readonly CaramoissantContext _context;
        private readonly IMapper _mapper;

        public CaramoissantService(CaramoissantContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task Add(Caramoissant caramoissant)
        {
            await _context.Caramoissants.AddAsync(caramoissant);
        }

        public async Task<Caramoissant> Get(int id)
        {
            var caramoissant = await _context.Caramoissants.FindAsync(id);
            if (caramoissant == null)
            {
                throw new Exception("Caramoissant not found");
            }
            return caramoissant;
        }

        public async Task<List<Caramoissant>> GetAll()
        {
            return await _context.Caramoissants.ToListAsync();
        }

        public async Task<Caramoissant> Delete(int id)
        {
            var caramoissant = await _context.Caramoissants.FindAsync(id);
            if (caramoissant == null)
            {
                throw new Exception("Caramoissant not found");
            }
            _context.Caramoissants.Remove(caramoissant);

            await _context.SaveChangesAsync();
            return caramoissant;
        }

        public async Task SaveAll()
        {
            await _context.SaveChangesAsync();
        }

    }
}
