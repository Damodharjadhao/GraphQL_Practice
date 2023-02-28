using Dapper;
using GraphQl.Api.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace GraphQl.Api.Services
{
    public class DbOpeartion : IDbOpeartion
    {
        private readonly IConnection _connect;
        private SqlConnection _connection;
        public DbOpeartion(IConnection connect)
        {
            _connect = connect;
            _connection = _connect.DatabaseConnection();
        }
        public  Task<IEnumerable<PersonDto>> GetAllPerson()
        {
            var getallPerson =  _connection.QueryAsync<PersonDto>("select * from Person");
            return getallPerson;
        }
        public Task<IEnumerable<PersonDto>> GetSinglePerson()
        {
            var Person = _connection.QueryAsync<PersonDto>($"select top 1 * from Person");
            return Person;
        }
        public  int AddPerson(PersonDto person)
        {         
            var Addperson =  _connection.Execute($"INSERT INTO Person(firstName,lastName,age) values('{person.firstName}','{person.lastName}','{person.Age}')", person);
            return Addperson;
        }
        public int updatePerson(PersonDto person)
        {
            var updateData = _connection.Execute($"Update Person set firstName='{person.firstName}',lastName='{person.lastName}',age='{person.Age}' where id='{person.Id}'", person);
            return updateData;
        }
        public  string DeletePerson(int id)
        {
            var delete =  _connection.ExecuteAsync($"delete From Person where id={id} ");
            return "deleted Successfully";
        }
    }
}
