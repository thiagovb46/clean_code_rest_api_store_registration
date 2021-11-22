# API-REST-PRODUTOS-USUÁRIOS
# - API REST CRUD(Create Read Update Delete) para uma lista de produtos e usuários de uma loja. ( Em implementação) 
## Rodando no endereço(Local): https://localhost:5001
## Documentação disponível em(Local) : https://localhost:5001/swagger/index.html
## A API foi desenvolvida respeitando os princípios da Arquitetura Limpa, dividido em camadas e utilizando o princípios de inversão de dependências para realizar o tráfego de informações entre camadas.
## Feita em .NET 5 com EntityFrameWorkCore e Banco de dados SqLite simples sem autenticação, o banco encontra-se funcionando na pasta API. 
## Criptografia da senha para armazenar em banco de dados ainda está em implementação.

# - Rotas Implementadas até então (As demais  ainda estão em implementação) : 
# - Produto
## Cadastrar Produtos POST https://localhost:5001/Produto
##  Listar todos os produtos : GET https://localhost:5001/Produto
## Deletar Produtos : DELETE POST https://localhost:5001/Produto/{id} (Rota autenticada - Necessário fazer login com usuário e enviar o token fornecido por meio do header Authorization)

# - Usuario
## Cadastrar usuários POST https://localhost:5001/Usuario
## Listar Todos os usuários GET https://localhost:5001/Usuario
## Deletar Usuario : DELETE https://localhost:5001/Usuario/{id}
