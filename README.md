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

git clone https://github.com/karinafukuda/InsertDB_WForms_PostgreSQL.git

````

- Crie um banco de dados em postgreSQL, vide documentação: <a href="https://www.postgresql.org/docs/" alt="link documentação postgresql" target="_blank">Documentação PostgreSQL<a/>

- Crie uma tabela no banco no modelo abaixo:



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

- Utilize a senha (Password) e o nome do banco de dados (Database) e substitua-os na classe "Conexao.cs"

- Por fim é só rodar no VS.

***

### Preview

<img src="https://github.com/karinafukuda/imagens_projetos/blob/main/img_tabela.png" alt="imagem da tabela em forms do projeto"/>



TKs! 😀
