# Instalar chocolatey
Set-ExecutionPolicy Bypass -Scope Process -Force; iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))

# Update 
choco upgrade chocolatey -Y

# Instalando Java8
choco install jre8 -Y
choco install javaruntime -Y
choco install jdk8 -Y
#choco install visualstudiocode -Y

# Instalacion de flyway db
choco install flyway.commandline

# Instalando SQL Server
choco install sql-server-management-studio

# Creacion BBDD
#sqlcmd -S <ComputerName>\<InstanceName> -i <MyScript.sql> 
sqlcmd -S localhost\MSSQLSERVER -i \ScriptDB\Create_Data_Base.sql

# Creaci�n de las tablas
sqlcmd -S localhost\MSSQLSERVER -i \ScriptDB\V1__Create_Table_Clients.sql
sqlcmd -S localhost\MSSQLSERVER -i \ScriptDB\V2__Create_Table_Policies.sql



echo "Instalaci�n completada, ya puede utilizar la applicacion sin nig�n problema!"