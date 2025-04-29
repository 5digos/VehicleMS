using Application.Dtos.Response;
using Application.Interfaces.IQuery;
using Application.Interfaces.IServices.ITransmissionTypeServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.TransmissionTypeServices
{
    public class TransmissionTypeGetServices : ITransmissionTypeGetServices
    {
        private readonly ITransmissionTypeQuery _transmissionTypQuery;

        public TransmissionTypeGetServices(ITransmissionTypeQuery transmissionTypQuery)
        {
            _transmissionTypQuery = transmissionTypQuery;
        }

        public async Task<List<GenericResponse>> GetAll()
        {
            var transmissionTypes = await _transmissionTypQuery.GetAll();

            var result = transmissionTypes.Select(v => new GenericResponse
            {
                Id = v.Id,
                Name = v.Name
            }).ToList();

            return result;
        }
    }
}
