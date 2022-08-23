using proje_data.Model;
using proje_dto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Rest.Autopilot.V1.Assistant;

namespace proje_data.Repository.Abstract
{
    public interface IPersonRepository:IGenericRepository<Person>
    {
        Task<(IEnumerable<Person> records, int total)> GetPaginationAsync(QueryResource pagination, PersonDto filterResource);
        Task<int> TotalRecordAsync();
    }
}
