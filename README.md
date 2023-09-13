# Comandos importantes:

## Gerar as imagens dockers
Dentro da pasta do projeto (ou seja, ItemService ou RestauranteService):
- docker build -t nomeprojeto:v.0

## Rodar imagem
- docker run --name restaurante-service -p 80XX:80 --network restaurante-bridge nomeprojeto:v.0

## Levantar o banco de dados
### SQL Server
- docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Sql12345678" -p 1433:1433 --name sqlserver --hostname sqlserver -d --network restaurante-bridge mcr.microsoft.com/mssql/server:2022-latest
### MySQL
- docker run --name=mysql --network restaurante-bridge -e MYSQL_ROOT_PASSWORD=root -d mysql:5.6
## Subir o rabbitmq
- docker run -d --hostname rabbitmq-service --name rabbitmq-service --network restaurante-bridge rabbitmq:3-management