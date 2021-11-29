## InsertDB_WForms_PorsgreSQL


Esse projeto utiliza o template do Windows Forms para receber dados em um formulário e utiliza estes dados para fazer um Insert no banco de dados (PostgreSQL).


***

### Tecnologias utilizadas

- .NET 6
- C# 
- ADO NET
- PostgreSQL
- Visual Studio 2022


****

### Como usar

- Clone este projeto

```` 

git clone https://github.com/karinafukuda/InsertDB_WForms_PorsgreSQL.git

````

- Crie um banco de dados em postgreSQL

- Crie uma tabela como no documento 'InstructionDataBase' que há dentro desse reposítório, nesse modelo:



````
CREATE TABLE Cargo 
(
    Id SERIAL PRIMARY KEY,
    Nome VARCHAR (120) NOT NULL,
    Ultima_Alteracao TIMESTAMP DEFAULT NOW(),
    Usuario_Alteracao VARCHAR (200) NOT NULL,
    Ativo BOOLEAN NOT NULL
);
````

- Utilize a senha (Password) e o nome do banco de dados (Database) e os substitua na classe "Conexao.cs"

- Depois é só rodar no VS.

***

### Preview

<img src="https://github.com/karinafukuda/imagens_projetos/blob/main/img_tabela.png" alt="imagem da tabela em forms do projeto"/>



TKs! 😀
