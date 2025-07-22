# 🖥️ Computer API

> Uma API RESTful feita com ASP.NET Core + Entity Framework para gerenciar computadores 💻

![ASP.NET Core](https://raw.githubusercontent.com/github/explore/main/topics/aspnetcore/aspnetcore.png)

---

## 📚 Descrição

Esta aplicação tem como objetivo cadastrar, consultar, atualizar e remover computadores em um sistema simples de inventário.

Ideal para estudos com .NET 8, Web API e Entity Framework Core.

---

## 🚀 Funcionalidades

- ✅ **GET** `/computer` – Lista todos os computadores
- 🔍 **GET** `/computer/{id}` – Retorna um computador pelo ID
- 📝 **POST** `/computer` – Cadastra um novo computador
- ✏️ **PUT** `/computer/{id}` – Atualiza um computador existente
- ❌ **DELETE** `/computer/{id}` – Remove um computador

---

## 🧱 Tecnologias Utilizadas

| Ferramenta              | Descrição                         |
|------------------------|-----------------------------------|
| `ASP.NET Core 8`       | Backend Web API                   |
| `Entity Framework Core`| ORM para acesso a dados           |
| `SQLite / SQL Server`  | Banco de dados relacional         |
| `Swagger`              | Interface visual para testar APIs |

---

## 🛠️ Como rodar localmente

```bash
# Clonar o repositório
git clone https://github.com/seu-usuario/Computer.git
cd Computer

# Restaurar dependências
dotnet restore

# Aplicar migrations e criar o banco
dotnet ef database update

# Executar a aplicação
dotnet run
