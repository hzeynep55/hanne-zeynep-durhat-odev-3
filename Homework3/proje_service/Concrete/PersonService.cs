using AutoMapper;
using proje_base.Exception;
using proje_base.Responce;
using proje_base.Response;
using proje_data.Model;
using proje_data.Repository.Abstract;
using proje_data.UnitOfWork;
using proje_dto.Dto;
using proje_service.Abstract;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_service.Concrete
{
    public class PersonService : IBaseService<PersonDto, Person>, IPersonService
    {
        private readonly IPersonRepository personRepository;
        public PersonService(IPersonRepository personRepository, IMapper mapper, IUnitOfWork unitOfWork) : base(personRepository, mapper, unitOfWork)
        {
            this.personRepository = personRepository;
        }

        


        public Task<BaseResponse<IEnumerable<PersonDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<PersonDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse<PersonDto>> InsertAsync(PersonDto insertResource)
        {
            try
            {
                // Mapping Resource to Person
                var person = Mapper.Map<PersonDto, Person>(createPersonResource);


                await personRepository.InsertAsync(person);
                await UnitOfWork.CompleteAsync();

                // Mappping response
                var response = Mapper.Map<Person, PersonDto>(person);

                return new BaseResponse<PersonDto>(response);
            }
            catch (Exception ex)
            {
                throw new MessageResultException("Person_Saving_Error", ex);
            }
        }

        public Task<BaseResponse<PersonDto>> RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<PersonDto>> UpdateAsync(int id, PersonDto updateResource)
        {
            throw new NotImplementedException();
        }

        public Task<PaginationResponse<IEnumerable<PersonDto>>> GetPaginationAsync(QueryResource pagination, PersonDto filterResource)
        {
            throw new NotImplementedException();
        }
    }
}
