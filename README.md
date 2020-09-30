# Configuración de la base de datos

1. En el archivo **appsettings.json** modificar el default connection:

    - Número de puerto
    - Nombre de usuario
    - Contraseña
    - Nombre de base de datos
 
 2. Crear una db para el auth server y ejecutar la siguiente query en la base de datos:
 
 CREATE TABLE \`__EFMigrationsHistory\` 
( 
    \`MigrationId\` nvarchar(150) NOT NULL, 
    \`ProductVersion\` nvarchar(32) NOT NULL, 
     PRIMARY KEY (\`MigrationId\`) 
);

3. Compilar la solución

4. Abrir una terminal e ir a la carpeta del proyecto Skrilla.OAuth

5. Ejecutar:
    - dotnet ef migrations add init -c AppDbContext -o Data/Migrations/AppMigrations
    - dotnet ef database update -c AppDbContext
