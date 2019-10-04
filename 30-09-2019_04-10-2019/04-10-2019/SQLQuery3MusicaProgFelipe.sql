SELECT gen.Nome as 'Genero',
	   art.Nome as 'Artista',
	   can.Nome as 'Cancao' FROM Generos gen
	   inner join Artistas art on gen.Id = art.GeneroId
	   inner join Cancoes can on art.Id = can.ArtistaId

select gen.Nome as 'Genero',
Count(art.Nome) as'Qtd Artistas'
from Generos gen inner join Artistas art on gen.Id = art.GeneroId
Group by gen.Nome

select gen.Nome as 'Genero',
Count(art.Nome) as'Qtd Artistas'
from Generos gen 
inner join Artistas art on gen.Id = art.GeneroId
inner join Cancoes can on art.Id = can.ArtistaId
Group by gen.Nome