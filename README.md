## Entity Framework Code First

### Entity Framwork(EF) Core
```
-    Lightweight, extensible, open source, cross-platform 
* EF Core can serve as an object-relational mapper (O/RM), which:

    Enables .NET developers to work with a database using .NET objects.
    Eliminates the need for most of the data-access code that typically needs to be written.

* EF Core supports many database engines such as
    MS SQL Server, MySQL, Oracle, PostgreSQL, SQLite, and In-memory
```

### Migrations
```
* Create a migration
* Update the database
* Remove a migration
* Reverta migration
* Customize migration code
* Generate SQL scripts
```

#### Run From Anywhere
<table>
  <tr>
    <td><strong>!Package Manager Console</strong></td>
    <td><strong>!Command Line Interface</strong></td>
  </tr>  
  <tr>
    <td>Add-Migration InitialCreate</td>
    <td>dotnet ef migrations add InitialCreate</td>
  </tr>
   <tr>
    <td>Update-Database</td>
    <td>dotnet ef database update</td>
  </tr>
   <tr>
    <td>Remove-Migration</td>
    <td>dotnet ef migrations remove</td>
  </tr>
   <tr>
    <td>Update-Database LastGoodMigration</td>
    <td>dotnet ef database update LastGoodMigration</td>
  </tr>
   <tr>
    <td>Script-Migration</td>
    <td>dotnet ef migrations script</td>
  </tr>
</table>
