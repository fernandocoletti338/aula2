select
car.Modelo, --coluna da nossa tabela carros modelo
mar.Nome, --coluna da nossa tabela marcas nome
car.Placa, --coluna da nossa tabela carros placa
car.Ano --coluna da nossa tabela carros ano
from--indicador que vamos selecionar 
Carros car inner join Marcas mar on car.MarcaCodigo = mar.Codigo