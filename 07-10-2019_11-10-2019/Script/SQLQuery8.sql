update Usuarios
set Login = 'não informado'
where Login is null
go
select * from Usuarios

