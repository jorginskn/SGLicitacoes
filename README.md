# Sistema de Gerenciamento de Licitações

## Descrição do Projeto
Este é um projeto de sistema de gerenciamento de licitações desenvolvido utilizando ASP.NET MVC e Entity Framework. O sistema oferece operações básicas de CRUD (Create, Read, Update, Delete) para lidar com informações sobre licitações. Além disso, foram implementados filtros para facilitar a busca por descrição e status das licitações.
![image](https://github.com/jorginskn/SGLicitacoes/assets/77112497/07c5e432-0e21-4f4b-8d6b-2621314dd87b)

![image](https://github.com/jorginskn/SGLicitacoes/assets/77112497/62fcd2ee-5e27-4174-a5f5-24b808367601)


## Instruções de Uso

### Pré-requisitos
- Certifique-se de ter o .NET SDK instalado na sua máquina.
- Configure a conexão com o banco de dados no arquivo `appsettings.json`.

### Instalação
1. Clone o repositório para a sua máquina.
   ```bash
   git clone https://github.com/jorginskn/SGLicitacoes)https://github.com/jorginskn/SGLicitacoes
--------------------------------------------------------------------------------------------------------
  1- Navegue até o diretório do projeto.
  cd sistema-de-licitacoes
  
  2- Restaure as dependências do projeto.
  dotnet restore

  3- Aplique as migrações para criar o banco de dados.
  
dotnet ef database update
  4- Execute o projeto.

  dotnet run
  
### Funcionalidades

#### Adicionar Nova Licitação
- No menu principal, clique em "Adicionar nova Licitação".
- Preencha as informações necessárias no formulário.
- Clique em "Salvar" para adicionar a nova licitação.

#### Listar Licitações
- Na página inicial, você verá uma lista de todas as licitações cadastradas.

#### Editar Informações de Licitações
- Na lista de licitações, clique no botão "Editar" correspondente à licitação desejada.
- Faça as alterações necessárias no formulário de edição.
- Clique em "Salvar" para aplicar as alterações.

#### Excluir Licitações
- Na lista de licitações, clique no botão "Apagar" correspondente à licitação que deseja excluir.
- Confirme a exclusão quando solicitado.

#### Filtrar Licitações por Descrição
- No menu principal, utilize o campo de busca por descrição para filtrar as licitações.

#### Filtrar Licitações por Status
- Utilize o seletor de filtro por status no menu principal para visualizar licitações específicas.

  

