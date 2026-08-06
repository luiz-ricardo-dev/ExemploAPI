# Exemplo API

Um projeto de exemplo e base arquitetural para a construção de APIs RESTful. Este repositório serve como um modelo (template) prático para a implementação das melhores práticas de desenvolvimento back-end, estruturação de código e integração de tecnologias no ecossistema Java.

## 🚀 Tecnologias Utilizadas

*   **Java**
*   **Spring Boot** (Spring Web)
*   **Spring Data JPA / Hibernate**
*   **Banco de Dados:** [H2 / MySQL / PostgreSQL - *Escolha o utilizado no projeto*]
*   **Maven** (Gerenciamento de dependências)

## 🎯 Objetivos do Projeto

*   Servir como um ponto de partida estruturado para novos projetos de API.
*   Demonstrar a implementação de operações CRUD completas (Create, Read, Update, Delete).
*   Aplicar o padrão de projeto de Arquitetura em Camadas (Controller, Service, Repository).
*   Fornecer um ambiente configurado para facilitar o entendimento do tráfego de dados e injeção de dependências.

## ⚙️ Estrutura de Diretórios

O projeto está dividido logicamente para separar as responsabilidades:

*   `/controllers`: Gerenciamento das requisições HTTP e roteamento dos endpoints da API.
*   `/services`: Camada onde reside toda a lógica de negócios da aplicação.
*   `/repositories`: Interfaces de comunicação e persistência no banco de dados.
*   `/models` (ou `/entities`): Mapeamento das tabelas e relacionamentos do banco de dados.
*   `/dtos`: Objetos para transferência de dados de forma segura (Data Transfer Objects).

## 🛠️ Como Executar

### Pré-requisitos
*   JDK (Java Development Kit) instalado.
*   Git para clonar o projeto.
*   Postman, Insomnia ou similar para realizar os testes de requisição.

### Instruções de Execução

1.  Clone este repositório para a sua máquina local:
    ```bash
    git clone https://github.com/luiz-ricardo-dev/ExemploAPI.git
    ```
2.  Acesse o diretório do projeto:
    ```bash
    cd ExemploAPI
    ```
3.  Inicie a aplicação utilizando o Maven:
    ```bash
    ./mvnw spring-boot:run
    ```
    *(No Windows, utilize `mvnw.cmd spring-boot:run`)*

A aplicação estará disponível por padrão no endereço `http://localhost:8080`.

## 📚 Endpoints de Exemplo

*(Adapte a tabela abaixo com as rotas que foram implementadas como exemplo na sua API)*

| Método | Endpoint | Descrição |
|---|---|---|
| `GET` | `/api/exemplo` | Retorna todos os registros cadastrados. |
| `GET` | `/api/exemplo/{id}` | Busca um registro específico pelo seu ID. |
| `POST` | `/api/exemplo` | Cria um novo registro no sistema. |
| `PUT` | `/api/exemplo/{id}` | Atualiza os dados de um registro já existente. |
| `DELETE` | `/api/exemplo/{id}` | Remove um registro do banco de dados. |

## 👨‍💻 Autor

**Luiz Ricardo de Campos**

[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/luiz-ricardo-dev/)
[![GitHub](https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/luiz-ricardo-dev)
