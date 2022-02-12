insert into tbl_Filme (ds_Titutlo, ds_Descricao, ds_Duracao)
select 
'Hunter',
'Noob',
'00:52:02'
(

ds_Titutlo varchar(100) not null,
ds_Descricao varchar(500) not null,
ds_Duracao time not null
)


--drop table tbl_Filme



select * from tbl_Filme
DELETE FROM tbl_Filme