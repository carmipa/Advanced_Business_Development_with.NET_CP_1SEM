create table clientes_cp2 (
   id       number primary key,
   nome     varchar2(100),
   cpf      varchar2(14),
   telefone varchar2(20),
   email    varchar2(100)
);


create table locacoes_cp2 (
   id         number primary key,
   clienteid  number
      references clientes_cp2 ( id ),
   carroid    number
      references carros_cp2 ( id ),
   datainicio date,
   datafim    date,
   valortotal number
);


create table pagamentos_cp2 (
   id              number primary key,
   locacaoid       number
      references locacoes_cp2 ( id ),
   valorpago       number,
   datapagamento   date,
   metodopagamento varchar2(50)
);