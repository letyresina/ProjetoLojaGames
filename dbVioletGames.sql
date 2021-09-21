create database dbVioletGames;
use dbVioletGames;

create table tbCliente(
	CliNome varchar(100) not null,
    CliCPF varchar(80) primary key,
    CliDtNasc datetime not null,
    EmailCli varchar(80) not null,
    CelCli varchar(80) not null,
    EnderecoCli varchar(80) not null
);

create table tbFuncionario(
	FuncCod int primary key,
    FuncNome varchar(100) not null,
    CPFFunc varchar(80) not null,
    RGFunc varchar(80) not null,
    FuncDtNasc datetime not null,
    EmailFunc varchar(80) not null,
    CelFunc varchar(80) not null,
    Cargo varchar(80) not null,
    Endereco varchar(80) not null
);

create table tbJogo(
	JogoCod int primary key,
    JogoNome varchar(80) not null,
    Versao varchar(10) not null,
    JogoDesenvolvedor varchar(50) not null,
    GeneroJogo varchar(30) not null,
    FaixaEtaria varchar(30) not null,
    Plataforma varchar(80) not null,
    AnoLanc varchar(4) not null,
    Sinopse varchar(100) not null
);

create user "gamer"@"localhost" identified with mysql_native_password by "123456";
grant all privileges on dvVioletGames.* to "gamer"@"localhost" with grant option;


