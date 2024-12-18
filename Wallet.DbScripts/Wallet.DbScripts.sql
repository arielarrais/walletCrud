create database walletdb;

show databases;

use walletdb;

create table ativo (
 id INT auto_increment primary key,
 nome varchar(100) 
);

CREATE TABLE `walletdb`.`carteira` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `id_ativo` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_carteira_ativo_idx` (`id_ativo` ASC) VISIBLE,
  CONSTRAINT `fk_carteira_ativo`
    FOREIGN KEY (`id_ativo`)
    REFERENCES `walletdb`.`ativo` (`id`)
    ON DELETE RESTRICT
    ON UPDATE NO ACTION);


insert into ativo(nome) values ('VGHF11');
select * from ativo;


insert into carteira(id_ativo) values (1);
select * from carteira;

show tables;