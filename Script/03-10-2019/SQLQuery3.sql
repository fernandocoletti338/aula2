select
fun.Nome,
sum(sal.Valor) as 'Total no 3 Meses'
From Funcionarios fun
	INNER JOIN Salario sal on fun.Id = sal.Funcionario
Group by fun.Nome


select
fun.Nome,
Avg(sal.Valor) as 'Total no 3 Meses',
Count(sal.Valor) as 'qtd Pagamentos',
sum(sal.Valor) as 'total'
From Funcionarios fun
	INNER JOIN Salario sal on fun.Id = sal.Funcionario
Group by fun.Nome
order by sum(sal.Valor) asc--desc = decrescente

Select * from Salario
where Id between 3 and 8

select * from Salario
where DataCriacao between '07/06/2019'and '08/07/2019'

select * from salario
where Id >= 3 and Id <= 8

update Funcionarios
set
DataSaida = '10/03/2019',
DataAlteracao = GETDATE(),
Ativo = 0 
where Nome like 'Felipe%'

select * from Funcionarios where Nome like 'Felipe%'

select * from Funcionarios

select 
Nome,
convert(Varchar(10),DataInicio,103) as 'Inicio',
convert(Varchar(10),DataSaida,103) as 'Saida'
from Funcionarios