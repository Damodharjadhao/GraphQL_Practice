using GraphQl.Api.Dtos;
using GraphQl.Api.Services;

namespace GraphQl.Api.MutationResolver
{
    [ExtendObjectType("mutation")]
    public class personMutationResolver
    {
        public int addPerson(PersonDto person,[Service] IDbOpeartion DbOpeartion)
        {
            return DbOpeartion.AddPerson(person);
        }

        public int updatePerson(PersonDto person, [Service] IDbOpeartion DbOpeartion)
        {
            return DbOpeartion.updatePerson(person);
        }

        public string delete([Service] IDbOpeartion DbOpeartion, int id)
        {
            return DbOpeartion.DeletePerson(id);
        }
    }
}
