update Usuarios
set Login = 'n�o informado'
where Login is null
go
select * from Usuarios

