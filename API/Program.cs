using API.Mutations.Questionannaire;
using API.Queries;
using Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPooledDbContextFactory<QuestionnaireDatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Questionnaire"), b => b.MigrationsAssembly("API")));

builder.Services
    .AddGraphQLServer()
    .AddQueryType<QuestionnaireQueries>()
    .AddMutationType<QuestionnaireMutations>();

var app = builder.Build();

app.MapGraphQL("/");

app.Run();
