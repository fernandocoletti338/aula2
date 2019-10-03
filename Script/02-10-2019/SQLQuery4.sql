Select * from Clientes;
INSERT INTO Pedidos
(Numero,ClienteId,Total)
VALUES
(
'N000000001', --numero do pedido
1, --id do nosso cliente
379.46 --valor 
)
GO
INSERT INTO Pedidos
(Numero,ClienteId,Total)
Values
('N123456789', 2, 100.00),
('N987654321', 2, 90.00),
('A123456789', 2, 85.00),
('B123456789', 3, 700.00),
('G123456789', 3, 120.00),
('Q123456789', 3, 12.35),
('R123456789', 4, 157.64),
('H123456789', 4, 197.99),
('E123456789', 4, 876.12)
GO
SELECT * FROM Pedidos
