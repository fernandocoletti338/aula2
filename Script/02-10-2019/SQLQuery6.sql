SELECT * FROM Clientes;
SELECT * FROM Pedidos;

SELECT * FROM Pedidos ped
where ped.ClienteId in ( select cli.Id from Clientes cli where cli.Idade > 13)
and total > 10

