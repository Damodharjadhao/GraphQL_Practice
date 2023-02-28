using GraphQl.Api.Dtos;
using GraphQl.Api.Services;

namespace GraphQl.Api.QueryResolver
{
    [ExtendObjectType("Query")]
    public class personQueryResolver
    {
        public Task<IEnumerable<PersonDto>> GetAllPerson([Service] IDbOpeartion DbOpeartion)
        {
            return DbOpeartion.GetAllPerson();
        }
        public Task<IEnumerable<PersonDto>> GetById([Service] IDbOpeartion DbOpeartion)
        {
            return DbOpeartion.GetSinglePerson();
        }    

    }
}
