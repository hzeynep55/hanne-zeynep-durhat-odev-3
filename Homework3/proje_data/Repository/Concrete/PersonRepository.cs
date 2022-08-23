using proje_data.Context;
using proje_data.Model;
using proje_data.Repository.Abstract;
using proje_dto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_data.Repository.Concrete
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(AppDbContext Context) : base(Context)
        {
        }
        public Task<(IEnumerable<Person> records, int total)> GetPaginationAsync(QueryResource pagination, PersonDto filterResource)
        {
            throw new NotImplementedException();
        }

        public Task<int> TotalRecordAsync()
        {
            throw new NotImplementedException();
        }
    }
}
