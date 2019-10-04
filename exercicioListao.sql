Update Marcas
set UsuInc = 1
where UsuInc = 0;

select * from Marcas

select * from marcas as mar
inner join Usuarios as usu on mar.UsuInc = usu.Id;

select usu.Usuario, * from marcas mar --Trazer somente as marcas que Felipe cadastrou
inner join Usuarios as usu on mar.UsuInc = usu.Id
WHERE Usu.Usuario = 'Felipe';

select usu.Usuario, * from Marcas mar	 --Trazer somente as marcas que Giomar cadastrou
inner join Usuarios usu on mar.UsuInc = usu.Id
where usu.Usuario = 'Giomar';

--Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor 
select Count(Marcas.Nome) from Marcas --"colocar o order by desc   no final do select só isso "
INNER JOIN Usuarios
ON Marcas.UsuInc = Usuarios.Id
Where Usuarios.Usuario = 'Felipe'
Order by Count(Marcas.Nome) Desc;

--Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior
select Count(Marcas.Nome) from Marcas
INNER JOIN Usuarios
ON Marcas.UsuInc = Usuarios.Id
Where Usuarios.usuario = 'Giomar'
Order by Count(Marcas.Nome) asc;

--Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram
Select Count(Marcas.Nome) from Marcas 	
INNER JOIN Usuarios
ON Marcas.UsuInc = Usuarios.Id
Where Usuarios.Usuario = 'Felipe' or Usuarios.Usuario = 'Giomar';
 
--Trazer somente os carros que Felipe cadastrou
select usu.Usuario, * from Carros car	
inner join usuarios usu on car.UsuInc = usu.Id
where usu.Usuario = 'Felipe';

--Trazer somente os carros que Giomar cadastrou
select usu.Usuario, * from Carros car	 
inner join usuarios usu on car.UsuInc = usu.Id
where usu.Usuario = 'Giomar';

--Trazer somente a quantidade de carros que Felipe cadastrou maior para menor
Select Count(Carros.Modelo) from Carros
INNER JOIN Usuarios
ON Carros.UsuInc = Usuarios.Id
where Usuarios.Usuario = 'Felipe'
Order by Count(Carros.Modelo) Desc;

--Trazer somente a quantidade de carros que Giomar cadastrou menor para maior
select Count(Carros.Modelo) from Carros
INNER JOIN Usuarios
ON Carros.UsuInc = Usuarios.Id
where Usuarios.Usuario = 'Giomar'
Order by Count(Carros.Modelo) Asc;

--Trazer somente a quantidade de carros que Felipe e Giomar cadastraram
Select Count(Carros.Modelo) from Carros
INNER JOIN Usuarios
ON Carros.UsuInc = Usuarios.Id
Where Usuarios.usuario = 'Felipe' or Usuarios.Usuario = 'Giomar';

Select Usu.Usuario,* from carros carros --Trazer somente os carros das marcas que Felipe cadastrou
inner join Marcas as mar on carros.Marca = mar.Id
inner join Usuarios as usu on mar.UsuInc= usu.Id
WHERE Usu.Usuario = 'Felipe';

select * from Carros car		--Trazer somente os carros das marcas que Giomar cadastrou
inner join Marcas mar on car.Marca = mar.Id
inner join Usuarios usu on mar.UsuInc = usu.Id
where usu.Usuario = 'Giomar';

--Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor
select Count(Carros.Modelo) from Carros
INNER JOIN Marcas
ON Carros.Marca = Marcas.Id
INNER JOIN Usuarios
ON Marcas.UsuInc = Usuarios.Id
where Usuarios.Usuario = 'Felipe'
Order by Count(Carros.Modelo) DESC;

--Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior
select Count(Carros.Modelo) from Carros
INNER JOIN Marcas
ON Carros.Marca = Marcas.Id
INNER JOIN Usuarios
ON Marcas.UsuInc = Usuarios.Id
Where Usuarios.Usuario = 'Giomar'
Order by Count(Carros.modelo) Asc;

--Trazer o valor total de vendas 2019 isolado
SELECT SUM(Quantidade * Valor)
FROM Vendas
WHERE Vendas.DatInc = '2019';

--Trazer a quantidade total de vendas 2019 isolado
SELECT SUM(Quantidade)
FROM Vendas
WHERE Vendas.DatInc = '2019';

--Trazer o valor total de vendas em cada ano e ordenar do maior para o menor
SELECT SUM(Quantidade * Valor), YEAR(DatInc) FROM VENDAS
GROUP BY YEAR(DatInc)
ORDER BY SUM(Quantidade * Valor) DESC

--SELECT SUM(Quantidade * Valor)
--FROM Vendas
--WHERE Vendas.DatInc = 'year 2018' or Vendas.DatInc = 'year 2019' or Vendas.DatInc = 'year 2020';

	--Trazer a quantidade de vendas em cada ano e ordenar do maior para o menor
	
	--Trazer o mês de cada ano que retornou a maior quantidade de vendas
	--Tradução "Retornar agrupado por mês e ordenar do maior para menor"
	
	--Trazer o mês de cada ano que retornou o maior valor de vendas
	--Tradução "Retornar agrupado por mês e ordenar do maior para menor"
	
	--Trazer o valor total de vendas que Felipe realizou
	--Trazer o valor total de vendas que Giomar realizou
	
	--Trazer a quantidade total de vendas que Felipe realizou
	--Trazer a quantidade de vendas que Giomar realizou
	
	--Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor
	--Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor
	
	--Trazer  a marca mais vendida de todos os anos
	--Tradução "Retornar todas as marcas que foram vendidas mas ordernada da maior para menor"
	--Trazer o valor total da marca mais vendida de todos os anos		
	
	--Trazer a quantidade do carro mais vendido de todos os anos
	--Trazer o valor do carro mais vendido de todos os anos
