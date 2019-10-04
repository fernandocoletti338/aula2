Insert into PlayList
(Nome,Artista,Genero)
Values


('Charlie Brown Jr','Céu Azul','Skate rock'),
('Charlie Brown Jr','Só Os Loucos Sabem','Skate rock'),
('Charlie Brown Jr','Dias de Luta, Dias de Glória','Skate rock'),
('Charlie Brown Jr','Pontes Indestrutíveis','Skate rock'),
('Charlie Brown Jr','Lugar Ao Sol','hardcore melódico'),
('Charlie Brown Jr','Senhor do Tempo','Skate rock'),
('Charlie Brown Jr','Meu Novo Mundo','hardcore melódico'),
('Charlie Brown Jr','Zóio de Lula','Skate rock'),
('Charlie Brown Jr','Como Tudo Deve Ser','Skate rock'),
('Charlie Brown Jr','Vícios E Virtudes','hardcore melódico')


update PlayList set Nome = Artista , Artista = Nome -- inverte os nomes das coluna que nesse 
--caso é "Nome = Artista , Artista = Nome"

select Genero, Count(Artista) from PlayList
group by Genero

select * from PlayList

select Artista, Count(Nome) from PlayList
group by Artista

select Distinct Genero from PlayList