# auvo-clima-tempo-simples - Database First

![auvo-clima-simples](https://user-images.githubusercontent.com/6588753/192535268-2ea9861f-d7e9-4032-bde3-afd1c2f94ca7.png)

É necessário alterar o connectionDatabase conforme seu database.


insert into dbo.Estado (Id, Nome, UF)
values (1, 'Santa Catarina', 'SC')

insert into dbo.Cidade (Id, Nome, EstadoId)
values (1, 'Urussnga', 1)

insert into dbo.Cidade (Id, Nome, EstadoId)
values (2, 'Blumenau', 1)

insert into dbo.PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
values (2, getdate(), 'ensolarado', 4, 9);

insert into dbo.PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
values (1, getdate(), 'ensolarado', 4, 9);

insert into dbo.PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
values (2, getdate(), 'chuvoso', 33, 35);

insert into dbo.PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
values (2, getdate()+1, 'ensolarado', 27, 29);

insert into dbo.PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
values (2, getdate()+2, 'ensolarado', 30, 35);

insert into dbo.PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
values (2, getdate()+3, 'ensolarado', 28, 34);

insert into dbo.PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
values (2, getdate()+4, 'tempestuoso', 25, 28);

insert into dbo.PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
values (2, getdate()+5, 'tempestuoso', 23, 25);

insert into dbo.PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
values (2, getdate()+6, 'chuvoso', 27, 31);

insert into dbo.PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
values (2, getdate()+7, 'chuvoso', 19, 24);


insert into dbo.PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
values (2, getdate()+8, 'tempestuoso', 17, 22);

insert into dbo.PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
values (2, getdate(), 'ensolarado', 4, 9);

insert into dbo.PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
values (1, getdate(), 'ensolarado', 4, 9);

insert into dbo.PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
values (1, getdate(), 'chuvoso', 33, 35);

insert into dbo.PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
values (1, getdate()+1, 'ensolarado', 27, 29);

insert into dbo.PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
values (1, getdate()+2, 'ensolarado', 30, 35);

insert into dbo.PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
values (1, getdate()+3, 'ensolarado', 28, 34);

insert into dbo.PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
values (1, getdate()+4, 'tempestuoso', 25, 28);

insert into dbo.PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
values (1, getdate()+5, 'tempestuoso', 23, 25);

insert into dbo.PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
values (1, getdate()+6, 'chuvoso', 27, 31);

insert into dbo.PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
values (1, getdate()+7, 'chuvoso', 19, 24);


insert into dbo.PrevisaoClima (CidadeId, DataPrevisao, Clima, TemperaturaMinima, TemperaturaMaxima)
values (1, getdate()+8, 'tempestuoso', 17, 22);
