# 🚀 CP2 2025 - FIAP - Advanced Business Development with .NET - Controle de produtos

**Paulo André carminati RM557881**  
**Turma: 2TDSPZ**

---

## 🚗 CP2 - Locadora de Carros com API REST em ASP.NET Core

## Introdução

Bem-vindo à sua CP2 de ASP.NET Core Web API! O objetivo desta avaliação é testar seus conhecimentos em ASP.NET Core, Entity Framework Core com Oracle e lógica de programação orientada a objetos, com foco na construção de uma API RESTful funcional e bem estruturada.

## 🎯 Objetivo
Implementar uma API que:

1. Cadastre carros no banco Oracle.  
2. Exponha um *endpoint* que calcule o valor de uma locação — **não é necessário persistir a locação**.  
3. Aplique descontos automáticos conforme o período alugado.  
4. Retorne um relatório completo do cálculo.

---

## 📜 Regras do Projeto

### 🚘 Entidade `Carro`
| Campo         | Tipo / Exemplo | Descrição                |
| ------------- | -------------- | ------------------------ |
| `Id`          | `long`         | Chave primária           |
| `Modelo`      | `"Civic"`      | Modelo do veículo        |
| `Marca`       | `"Honda"`      | Fabricante               |
| `Ano`         | `2020`         | Ano de fabricação        |
| `ValorDiaria` | `150.00`       | Preço da diária em reais |

---

### 🔢 Endpoint de Locação
`POST /api/locacoes/calcular`

**Request JSON**
```json
{
  "carroId": 1,
  "dataInicio": "2025-04-25",
  "dataFim":   "2025-04-30"
}
```
---

## Regras de calculo (C#)

int dias = (dataFim - dataInicio).Days;
double subtotal = dias * valorDiaria;

double desconto = 0;
if (dias >= 7)
    desconto = 0.10;          // 10 %
else if (dias >= 3)
    desconto = 0.05;          // 5 %

---

## 📍 Endpoints obrigatórios

| Verbo  | Rota                     | Ação                               |
| ------ | ------------------------ | ---------------------------------- |
| GET    | `/api/carros`            | Listar todos os carros             |
| GET    | `/api/carros/{id}`       | Detalhar carro                     |
| POST   | `/api/carros`            | Cadastrar carro                    |
| PUT    | `/api/carros/{id}`       | Atualizar carro                    |
| DELETE | `/api/carros/{id}`       | Remover carro                      |
| POST   | `/api/locacoes/calcular` | Calcular locação (somente cálculo) |

---

## 🗃️ Banco de Dados

- Oracle configurado via **Entity Framework Core**.  
- Ajuste **`appsettings.json`** e **`Program.cs`** com a string de conexão adequada.

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```
---

## 🔍 Critérios de Avaliação

| Critério                                                        | Pontos  |
| --------------------------------------------------------------- | :-----: |
| Estrutura do projeto e organização                              | **1.0** |
| Entidade **Carro** implementada com EF Core + Oracle            | **2.0** |
| Endpoint **`/locacoes/calcular`** com lógica e retorno corretos | **4.0** |
| Descontos aplicados conforme número de dias                     | **2.0** |
| Boas práticas (nomes, comentários, *clean code*)                | **1.0** |
| **Total**                                                       | **10**  |

---

## 📤 Exemplo de Entrada

```http
POST /api/locacoes/calcular
Content-Type: application/json

{
  "carroId":   1,
  "dataInicio": "2025-04-25",
  "dataFim":    "2025-04-30"
}
```
---

## 📥 Exemplo de Saída

```json
{
  "carro":       "Civic",
  "marca":       "Honda",
  "dataInicio":  "2025-04-25",
  "dataFim":     "2025-04-30",
  "valorDiaria": 150.00,
  "subtotal":    900.00,
  "desconto":    "10%",
  "valorFinal":  810.00
}
```
---

## ⚠️ Observações Importantes

- Projeto **individual** e entregue em **ZIP** (mesmo padrão da CP1).  
- **Proibido** uso de ferramentas de IA durante o desenvolvimento.  
- Projetos **idênticos** resultarão em **nota 0**.  
- Código que **não compilar ou rodar** também receberá **nota 0**.

---

## 🛠️ Dicas

1. Use nomes claros e comentários sucintos.  
2. Valide datas e IDs recebidos no endpoint **`/calcular`**.  
3. Escreva **testes unitários** para a lógica de cálculo e descontos.  
4. Documente rotas com **Swagger** (`Swashbuckle.AspNetCore`).

---

**Boa CP2! 🚀** Capriche no código e mostre seu domínio em APIs, EF Core e lógica orientada a objetos.

---
**link para a documentação***: [![Documentação – DOCX](https://img.shields.io/badge/Documenta%C3%A7%C3%A3o-DOCX-blue?style=for-the-badge&logo=microsoftword&logoColor=white)](https://github.com/carmipa/Advanced_Business_Development_with.NET_CP_1SEM/blob/main/cp2/README.md)


**Repositório no GitHub**: [CP1 - Locadora de Carros com API REST em ASP.NET Core](https://github.com/carmipa/Advanced_Business_Development_with.NET_CP_1SEM/tree/main/cp2)

