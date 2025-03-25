# 🚀 CP1 2025 - FIAP - Advanced Business Development with .NET

**Paulo André carminati RM557881**  

---

## Introdução

Bem-vindo à sua CP1 de C#! O objetivo desta avaliação é testar seus conhecimentos em instruções básicas da linguagem, entrada e saída de dados, estrutura condicional e orientação a objetos.

## 🎯 Objetivo
Você deve desenvolver um programa em C# que simule um sistema de controle de produtos. O programa deve permitir cadastrar dois produtos, calcular o valor total de cada um com base na quantidade e no preço unitário, aplicar um desconto se o valor total for maior que R$ 5000, e indicar qual produto tem o maior custo final.


**Pontuação Máxima:** 100%

---

## 📜 Regras do programa

### 1.	O usuário deve informar os dados de dois produtos:
- o	Nome do produto (exemplo: "Notebook")
- o	Preço unitário (exemplo: 2500.00)
- o	Quantidade em estoque (exemplo: 3)
- o	Desconto percentual a ser aplicado (exemplo: 10%)

### 2.	O programa deve calcular o custo total de cada produto usando a fórmula:
- Custo Total = Preço Unitário * Quantidade

### 3.	Se o custo total for maior que R$ 5000, um desconto deve ser aplicado conforme informado pelo usuário:
- Custo Final = Custo Total - (Custo Total * (Desconto / 100))

### 4.	O sistema deve exibir os valores calculados e indicar qual produto teve o maior custo final.

### 5.	O código deve ser estruturado utilizando uma classe para representar os produtos.

### 6.	A classe deve conter:
-	Atributos privados para armazenar os dados do produto.
-	Construtor para inicializar os valores do produto.
-	Método público para calcular o custo total.
-	Método público para calcular o custo final com desconto.
-	Método para exibir os detalhes do produto.
