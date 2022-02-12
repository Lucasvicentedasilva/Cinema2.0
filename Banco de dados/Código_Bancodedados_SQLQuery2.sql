create database db_cinema

use db_cinema

create table tbl_Gerente
(
id_Gerente int primary key identity,
ds_Login varchar(20) not null,
ds_Senha varchar(8) not null
)
insert into tbl_Gerente
(ds_Login, ds_Senha)
Values ('lucassilva', 'minhavag')

select * from tbl_Gerente

create table tbl_Sessoes 
(
id_Sessoes int primary key identity,
hr_Inicio time not null,
hr_Fim time not null,
ds_Audio varchar(10) not null,
tp_Animacao char not null,
vl_Ingresso decimal(2,2) not null,
)
create table tbl_Salas
(
id_Salas int primary key identity,
ds_Nomes varchar(8),
qnt_Assentos int
)
create table tbl_Filme
(
id_Filme int primary key identity,
ds_Titulo varchar(100) not null,
ds_Descricao varchar(500) not null,
ds_Duracao time not null
)select * from tbl_Filme

alter table tbl_Sessoes
add vl_data date;

alter table tbl_Sessoes
add id_Salas int;

alter table tbl_Sessoes 
add constraint fk_Salas foreign key (id_Salas) references tbl_Salas (id_Salas);

alter table tbl_Salas 
add constraint fk_Sessoes foreign key (id_Salas) references tbl_Sessoes (id_Sessoes);

alter table tbl_Sessoes 
add constraint fk_Filme foreign key (id_Filme) references tbl_Filme (id_Filme);

alter table tbl_Filme 
add constraint fk_Sessoes foreign key (id_Filme) references tbl_Sessoes (id_Sessoes);

alter table tbl_Filme
add ds_Imagem image;

alter table tbl_Sessoes
add nm_Sessao varchar;
select * from tbl_Sessoes
