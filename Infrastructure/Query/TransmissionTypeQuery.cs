using Application.Interfaces.IQuery;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Query
{
    public class TransmissionTypeQuery : ITransmissionTypeQuery
    {
        private readonly AppDbContext _context;


        public TransmissionTypeQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TransmissionType>> GetAll()
        {
            var result = await _context.TransmissionTypes.ToListAsync();

            return result;
        }
    }
}
