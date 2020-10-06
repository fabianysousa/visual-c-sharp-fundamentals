USE Activity5;

GO

CREATE TABLE Aluno(
Matricula int not null primary key,
Nome varchar(30) not null,
Curso varchar(30) not null,
Data_nascimento date not null
);

GO

CREATE TABLE Turma(
Nr_turma int not null primary key,
Nome_turma varchar(30) not null,
Sala int not null,
Horario time not null,
);

GO

INSERT INTO Aluno (Matricula, Nome, Curso, Data_nascimento) VALUES (1, 'Daniel', 'Designer Digital', '0001-01-01');
INSERT INTO Aluno (Matricula, Nome, Curso, Data_nascimento) VALUES (2, 'Leticia', 'Ciencia da Computação', '0002-02-02');
INSERT INTO Aluno (Matricula, Nome, Curso, Data_nascimento) VALUES (3, 'Mariana', 'Engenharia de Computação', '0003-03-03');

INSERT INTO Turma (Nr_turma, Nome_turma, Sala, Horario) VALUES (1, 'Designer Digital 2020.1', 01, '01:01:01.0');
INSERT INTO Turma (Nr_turma, Nome_turma, Sala, Horario) VALUES (2, 'Engenharia da Computação 2020.1', 02, '02:02:02.0');
INSERT INTO Turma (Nr_turma, Nome_turma, Sala, Horario) VALUES (3, 'Ciencia da Computação 2020.1', 03, '03:03:03.0');
