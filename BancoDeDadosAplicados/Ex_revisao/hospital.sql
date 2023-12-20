create database hospital;
use hospital;

CREATE TABLE paciente (
    CPF DECIMAL(11),
    RG DECIMAL(8),
    Nome VARCHAR(50),
    rua VARCHAR(50),
    bairro VARCHAR(20),
    cep DECIMAL(8),
    datanasc DATE
);

/*rg poderia ser numeric (8)*/
/*ctrl b - identacao*/

alter table paciente alter bairro set default 'Benfica';
desc paciente;

alter table paciente modify bairro numeric(8);

alter table paciente add cidade varchar(30);
desc paciente;

alter table paciente change Nome nome varchar(60);
desc paciente;

alter table paciente drop RG;
desc paciente;

alter table paciente modify nome varchar(50) not null;
desc paciente;

alter table paciente modify cidade varchar(30) default 'Juiz de Fora';
desc paciente;

alter table paciente add constraint pk_paciente primary key(cpf);
desc paciente;

alter table paciente add column RG decimal(8);
alter table paciente modify RG decimal(8) unique;

CREATE TABLE doenca (
    cid CHAR(5) PRIMARY KEY,
    descricao VARCHAR(100)
);

CREATE TABLE medico(
	CRM decimal(5) primary key,
    cpf decimal(11),
    nome varchar(50),
    rua varchar(50),
    bairro varchar(25),
    cidade varchar(25),
    cep char(10)
);

create table especialidade(
	crm decimal(5),
    rqe varchar(10),
    primary key(crm, rqe),
    foreign key(crm) references medico(crm) on delete cascade on update cascade,
    foreign key(rqe) references especialidade(rqe)
);

