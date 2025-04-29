using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BranchOfficeZone
    {
        public int Id { get; set; }
        public string Name { get; set; } // norte, sur, este, oeste      


        public List<BranchOffice> BranchOffices { get; set; }
    }
}
