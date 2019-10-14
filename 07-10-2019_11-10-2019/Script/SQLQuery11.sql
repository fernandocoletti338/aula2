insert into Usuarios
(Nome, Login, Senha)
values
('Adagoberto','urineidson','tapanasoraia')
go
select * from Usuarios
update Usuarios set Ativo = 0 where Id = 7