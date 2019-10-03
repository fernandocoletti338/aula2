SELECT * FROM Clientes;
SELECT * FROM Pedidos;

SELECT * FROM Pedidos ped
INNER JOIN Clientes cli ON ped.ClienteId = cli.Id
WHERE cli.Nome = 'Cleiton'

SELECT SUM(ped.Total) FROM Pedidos ped
INNER JOIN Clientes cli ON ped.ClienteId = cli.Id
WHERE cli.Nome = 'Cleiton'

select
IIF(SUM(ped.Total) > 400.00, 'Brinde Xiaomi', 'Não ganhou') as 'Resultado',
SUM(ped.Total ) as 'Total',
cli.Nome
from Pedidos ped
inner join Clientes cli on ped.ClienteId = cli.Id
group by cli.Nome