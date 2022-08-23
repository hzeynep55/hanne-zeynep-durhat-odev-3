using proje_base.Response;
using proje_data.Model;
using proje_dto.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace proje_service.Abstract
{
    public interface IPersonService:IBaseService<PersonDto,Person>
    {
        Task<PaginationResponse<IEnumerable<PersonDto>>> GetPaginationAsync(QueryResource pagination, PersonDto filterResource);
    }
}
