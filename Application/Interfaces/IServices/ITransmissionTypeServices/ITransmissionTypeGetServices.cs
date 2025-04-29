using Application.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IServices.ITransmissionTypeServices
{
    public interface ITransmissionTypeGetServices
    {
        Task<List<GenericResponse>> GetAll();
    }
}
