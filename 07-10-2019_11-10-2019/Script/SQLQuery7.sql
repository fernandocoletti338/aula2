insert into Usuarios --informamos a tabela que avmos registrar o valor
(Nome) --as colunas que vamos carregar as informações
values -- informamos que os valores estarão logo a seguir
('Fernando') --nossas informações na ordem das colunas
go
select * from Usuarios
go
insert into Usuarios
(Nome,Login,Senha)
values
('Rosbervaldo','pulsao','123456')
go
select * from Usuarios