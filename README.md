# Sistema de Tarefas

## Descrição

Este projeto consiste em uma **API CRUD de Tarefas**, construída com o **ASP.NET Web API** utilizando **C#**.  
A API permite o cadastro de tarefas e usuários, além de vincular as tarefas aos usuários. O sistema utiliza um banco de dados para armazenar as informações.

O projeto utiliza a abordagem de **ORM (Object-Relational Mapping)** com o **Entity Framework Core**, 
facilitando o mapeamento entre objetos da aplicação e tabelas do banco de dados, reduzindo a necessidade de escrever SQL manualmente.

A aplicação será criada do zero, e o CRUD (Create, Read, Update, Delete) permitirá que as tarefas sejam gerenciadas de forma simples e eficiente.  
O foco é entender como desenvolver uma API RESTful utilizando as melhores práticas e ferramentas do .NET.

---

## Funcionalidades

- **Cadastro de Usuários**: Permite registrar usuários que poderão criar, editar e visualizar tarefas.
- **Cadastro de Tarefas**: Usuários poderão criar tarefas e associá-las a eles mesmos.
- **Vinculação de Usuário e Tarefa**: Cada tarefa estará associada a um usuário específico, permitindo organizar e gerenciar as tarefas de forma personalizada.
- **CRUD de Tarefas**: O sistema permitirá as operações de:
  - **Criar** uma nova tarefa.
  - **Ler** a lista de tarefas.
  - **Atualizar** o status ou descrição das tarefas.
  - **Deletar** tarefas.

---

## Tecnologias Utilizadas

- **ASP.NET Web API**: Framework para desenvolvimento de APIs RESTful.
- **C#**: Linguagem de programação para lógica de backend.
- **Entity Framework Core**: Para interação com o banco de dados, utilizando ORM.
- **SQL Server**: Banco de dados para persistência das informações.
