# GeradorDeCartaoDeCreditoVirtual

C sharp NET Core API  Generate CardCredit endpoints
----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
1 Escreva um artigo, em formato de blog post sobre um projeto C# com .NET Core.
Você deverá descrever o passo-a-passo para a criação de uma API REST que fornece um sistema de geração de número de cartão de crédito virtual.
 A API deverá gerar números aleatórios para o pedido de novo cartão. 
----------------------------------------------------------------------------------
2 Cada cartão gerado deve estar associado a um email para identificar a pessoa que está utilizando.
Essencialmente são 2 endpoints. 
Um receberá o email da pessoa e retornará um objeto de resposta com o número do cartão de crédito. 
----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
E o outro endpoint deverá listar, em ordem de criação, todos os cartões de crédito virtuais de um solicitante (passando seu email como parâmetro).
----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
A implementação deverá ser escrita utilizando C# com .Net Core e Entity Framework Core.
----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
IDEIAS PARA O DESENVOLVIMENTO DO DESAFIO/PROJETO
----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
TELA 1 GERADOR DE CARTAO
----------------------------------------------------------------------------------
DIGITIE EMAIL
----------------------------------------------------------------------------------
NOME DO DONO DO CARTAO 
NUMERO CARTAO (DADOS ALETATORIOS)
CVV (DADOS ALETATORIOS)
----------------------------------------------------------------------------------
VAI RECEBER VIA EMAIL O CARTAO
----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
duas api, uma pra enviar email 
 ----------------------------------------------------------------------------------
 ou uma so em um post que gera o cartao e usa uma api que envia email
 ----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
 LISTAR DE ACORDO COM EMAIL NO BANCO DE DADOS
MANDA UM POST
GET PARA LER
----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
DIGITE O EMAIL
POST
----------------------------------------------------------------------------------
API POST
envia email com o cartao gerado!
----------------------------------------------------------------------------------
ou nem precisa enviar email realmente so faz um GET dos cartoes gerados depois
----------------------------------------------------------------------------------
GET
ler gartoes gerados pelo email
----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
referencias
https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio
----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
http://www.macoratti.net/12/05/c_rand1.htm#:~:text=Gerar%20n%C3%BAmeros%20aleat%C3%B3rios%20 //vou ter q encaixar isso
http://www.macoratti.net/20/08/aspnc_email1.htm [11:19, 28/05/2021] // se pa dava ate pra criar um app de ler emails com isso  e enviar
http://www.macoratti.net/18/04/aspcoremvc_email1.htm //vi isso aqui mas acho que nao vai precisar enviar o email em si

exemplo com interface
![image](https://user-images.githubusercontent.com/18118604/120052632-8e009a00-bffc-11eb-90f9-e45fbe72da9a.png)

https://github.com/jessepollak/card //se fosse javascript tava meio caminho andado 
 


