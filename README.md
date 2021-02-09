# CalculaJurosService

Repositorio de Apis:
- cálculo de juros compostos
- endereço do repositório do projeto

Desenvolvido em:

- .Net Core 3.1
- Docker version 20.10.2

Execução:

- clonar https://github.com/tomasrangel75/CalculaJurosService/tree/master
- no comand prompt, na pasta do projeto, rodar 'docker-compose up --build -d'
- acessar a api de juros compostos:
  api:CalculaJuros
  parâmetros: valorinicial(double), periodo(int)
  exemplo: http://localhost:59991/CalculaJuros?valorinicial=1000&periodo=5
- acessar api do endereço do repositório:
  http://localhost:59991/showmethecode
