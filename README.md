# 24 Hour C# .Net API Challenge / Project

## Migrations

When using Code First Migrations, you can use the following commands to create and apply migrations:

```bash
dotnet ef migrations add InitialCreate -s ../SaffronSlice.Api/ --context AppDbContext
dotnet ef database update -s ../SaffronSlice.Api/SaffronSlice.Api.csproj --context AppDbContext
```

However, build errors will occur when after adding a migration, we update the database, because the Migration class generated does not use file based namespaces. To fix this, we need to manually update the namespace in the generated migration file.
