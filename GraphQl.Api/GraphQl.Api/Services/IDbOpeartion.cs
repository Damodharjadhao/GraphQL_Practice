using GraphQl.Api.Dtos;

namespace GraphQl.Api.Services
{
    public interface IDbOpeartion
    {
        public Task<IEnumerable<PersonDto>> GetAllPerson();
        public Task<IEnumerable<PersonDto>> GetSinglePerson();
        public int AddPerson(PersonDto person);
        public int updatePerson(PersonDto person);
        public  string DeletePerson(int id);
    }
}
