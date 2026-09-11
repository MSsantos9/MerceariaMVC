````markdown
# 🛒 MerceariaMVC

Sistema web desenvolvido em **ASP.NET Core MVC** para gerenciamento de clientes e produtos de uma mercearia.

## 📖 Sobre o Projeto

O MerceariaMVC foi desenvolvido com o objetivo de praticar conceitos de desenvolvimento web utilizando **C#**, **ASP.NET Core MVC**, banco de dados e testes automatizados.

O sistema permite realizar o gerenciamento de clientes e produtos através de operações CRUD.

## 🚀 Funcionalidades

### 👤 Clientes

- Cadastro de clientes
- Listagem de clientes
- Edição de clientes
- Visualização de detalhes
- Exclusão de clientes
- Controle de idade
- Controle de cliente ativo

### 📦 Produtos

- Cadastro de produtos
- Listagem de produtos
- Edição de produtos
- Visualização de detalhes
- Exclusão de produtos
- Controle de preço
- Controle de estoque

### 🧪 Testes

O projeto possui testes automatizados para as funcionalidades de clientes e produtos.

- `ClienteTests.cs`
- `ProdutoTests.cs`

## 🛠️ Tecnologias Utilizadas

- C#
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- HTML5
- CSS3
- Razor
- xUnit
- Visual Studio

## 🗄️ Banco de Dados

O sistema utiliza **SQL Server** para armazenamento dos dados e **Entity Framework Core** para comunicação com o banco.

As migrations são utilizadas para criação e atualização da estrutura do banco de dados.

## 📂 Estrutura do Projeto

```text
MerceariaMVC
│
├── wwwroot
│   └── css
│       └── site.css
│
├── Controllers
│   ├── ClienteController.cs
│   └── ProdutoController.cs
│
├── Data
│   └── ApplicationDbContext.cs
│
├── Migrations
│
├── Models
│   ├── Cliente.cs
│   └── Produto.cs
│
├── Views
│   ├── Cliente
│   ├── Produto
│   └── Shared
│
├── appsettings.json
└── Program.cs

MerceariaMVCTests
│
├── ClienteTests.cs
└── ProdutoTests.cs
````

## ⚙️ Como Executar

### 1. Clonar o repositório

```bash
git clone URL_DO_REPOSITORIO
```

### 2. Abrir o projeto

Abra o arquivo:

```text
MerceariaMVC.sln
```

no Visual Studio.

### 3. Configurar o banco de dados

Configure a string de conexão do SQL Server no arquivo:

```text
appsettings.json
```

### 4. Atualizar o banco de dados

No Package Manager Console do Visual Studio:

```powershell
Update-Database
```

### 5. Executar

Pressione:

```text
F5
```

ou:

```text
Ctrl + F5
```

## 🎯 Objetivo

O projeto tem como objetivo aplicar conhecimentos de:

* Programação Orientada a Objetos
* Desenvolvimento Web
* Arquitetura MVC
* Operações CRUD
* Banco de Dados
* Entity Framework Core
* Migrations
* Validação de dados
* Testes automatizados

## 👨‍💻 Autor

**Miguel Marques Santos**

Projeto desenvolvido para fins acadêmicos.

```
```
