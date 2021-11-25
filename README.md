## API REST CRUD para uma lista de produtos e usuários de uma loja. ( Em implementação) 
### Endereço Local para execução: https://localhost:5001
### Swagger com modelos de requisições e documentação : https://localhost:5001/swagger/index.html
### A API foi desenvolvida respeitando os princípios da Arquitetura Limpa, dividido em camadas e utilizando o princípios de inversão de dependências para realizar o tráfego de informações entre camadas.
#### Feita em .NET 5 com EntityFrameWorkCore e Banco de dados SqLite simples sem autenticação, o banco encontra-se funcionando na pasta API. 
#### As senhas são armazenadas de maneira criptografada no banco de dados com algoritimo md5.

## Rotas Implementadas até então (As demais  ainda estão em implementação) : 
###   Produto
####    Cadastrar Produtos POST https://localhost:5001/Produto
####    Formato da requisicao 

####   {
####    "nome": "string",
####     "preco": 0,
####     "produtoEstaAtivo": true
####   }
#### ProdutoEstaAtivo é um booleano, deve ser preenchido true se o produto está ativo ou false se o produto está inativo.


##  Listar todos os produtos : GET https://localhost:5001/Produto 
## Deletar Produtos : DELETE https://localhost:5001/Produto/{id} (Rota autenticada - Necessário fazer login com usuário e enviar o token fornecido por meio do header Authorization)

# - Usuario
## Cadastrar usuários POST https://localhost:5001/Usuario
### Formato da requisicao :
{
  "nome": "string",
  "email": "user@example.com",
  "senha": "string"
}
## Listar Todos os usuários GET https://localhost:5001/Usuario
O método lista os usuários apenas por nome e e-mail, não mostrando informações confidenciais como senha e e-mail.
## Deletar Usuario : DELETE https://localhost:5001/Usuario/{id}
## Login Usuario : POST https://localhost:5001/login 
(Retorna JWT)
{ 
 "email": "user@example.com",
  "senha": "string"
}
## Validações implementadas nos modelos de cadastro:
### Usuário:
####  ■ Nome
####    ● obrigatório.
####    ● mínimo de 3 letras. 
####  ● máximo de 20 letras.
----------------------------
###   ■ Senha
####    ● obrigatório.
####    ● mínimo de 8 letras.
####    ● máximo de 20 letras.
----------------------------
###   ■ E-mail
####    ● obrigatório.
####    ● ser um email com formato válido.
####    ● ser único no banco de dados.
----------------------------
###   ■ Produtos:
####    ■ nome
####    ● obrigatório.
####    ● mínimo de 3 letras.
####    ● máximo de 80 letras.
----------------------------
###   ■ valor
####    ● obrigatório.
####    ● número não negativo.
----------------------------
###   ■ status
####    ● obrigatório.
