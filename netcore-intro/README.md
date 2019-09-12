# Bem vindos ao .Net Core!

Público alvo desse treinamento:

* Iniciantes em .Net Core
* Dev's de outra linguagem e que desejam aprender uma nova tecnologia

Após esses encontros:

* Vamos criar uma API básica com entity framework core e SQL

## Configurando o ambiente:

### .NET CORE

O primeiro passo é instalar o .Net Core em seu computador.
o .Net Core nada mais é do que um SDK gratuito, Open Source e multi-plataforma (Windows, Linux e MAC) da microsoft.

O download pode ser feito em: https://www.microsoft.com/net

![alt text](images/aspnetcore.gif)
  
Em seguida vamos configurar o Docker para prover nosso acesso ao banco de dados SQL SERVER. Não vamos estudar todas as possibilidades e facilidades que o Docker pode oferecer, nesse momento, utilizaremos o mesmo apenas para auxiliar no ambiente de desenvolvimento.
 
O download pode ser realizado em: https://www.docker.com
 
Em conjunto com o Docker vamos utilizar o Kitematic, para auxiliar visualmente a instalação/configuração dos containers, ele pode ser encontrado em: https://kitematic.com/
 
![alt text](images/docker.gif)
  
Para finalizar o ambiente vamos instalar o VSCommunity, uma IDE de desenvolvimento gratuira e extensível para criação de aplicações. Seu download pode ser feito em: https://visualstudio.microsoft.com/pt-br/vs/community

## Estrutura do projeto:

Para iniciar nossos encontros, vamos montar a estrutura inicial do nosso projeto, para isso:

1. Executar o VS Comunnity e criar nossa solução: Parking.Sln
2. Criar o projeto da API: Parking.Web
3. Criar o projeto: Parking.Application
4. Criar a camada de domínio: Parking.Domain
5. Criar o projeto: Parking.Dto
6. Criar o projeto: Parking.Infra

![alt text](images/project.gif)

No próximo encontro vamos iniciar com:

* Modelagem de dados
* Entity Framework Core
* Mapeamento objeto relacional
  
  
 



