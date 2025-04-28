using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Response
{
    public class GenericResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public static explicit operator GenericResponse(VehicleStatus vehicleStatus)
        {
            return ConvertToGenericResponse(vehicleStatus);
        }

        public static explicit operator GenericResponse(TransmissionType transmissionType)
        {
            return ConvertToGenericResponse(transmissionType);
        }

        private static GenericResponse ConvertToGenericResponse<T>(T entity) where T : class
        {
            var idProperty = typeof(T).GetProperty("Id");
            var nameProperty = typeof(T).GetProperty("Name");

            if (idProperty == null || nameProperty == null)
            {
                throw new InvalidOperationException("The entity does not have the required properties.");
            }

            var idValue = idProperty.GetValue(entity);
            var nameValue = nameProperty.GetValue(entity);

            if (idValue == null || nameValue == null)
            {
                throw new InvalidOperationException("The entity properties cannot be null.");
            }

            return new GenericResponse
            {
                Id = (int)idValue,
                Name = (string)nameValue
            };
        }
    }
}
