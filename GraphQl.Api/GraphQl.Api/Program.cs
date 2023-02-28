using GraphQl.Api.MutationResolver;
using GraphQl.Api.QueryResolver;
using GraphQl.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddGraphQLServer()
    .AddQueryType(q=> q.Name("Query"))
    .AddType<personQueryResolver>()
    .AddMutationType(m=>m.Name("mutation"))
    .AddType<personMutationResolver>();

builder.Services.AddSingleton<IConnection, DbConnection>();
builder.Services.AddSingleton<IDbOpeartion, DbOpeartion>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL();

app.Run();
