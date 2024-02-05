<div align="center">


# DIO - Trilha .NET - Programação orientada a objetos
</div>
<br>

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

## Implementações extras
Além das implementações propostas neste desafio, criei novas funcionalidades para os celulares. 

* **Data()**: esse método foi criado na classe abstrata **Smartphone** para ser herdado por **Nokia** e **Iphone**.
  Nele utilizei o *virtual*, um outro mecanismo de polimorfmismo, para poder sobrescrevê-lo nas classes herdadas, sendo assim, exibindo a data em formatos diferentes em Nokia e Iphone.
* **Relogio()**: esse método foi criado na classe abstrata **Smartphone** para ser herdado por **Nokia** e **Iphone**.
  Nele utilizei o *virtual*, um outro mecanismo de polimorfmismo, para poder sobrescrevê-lo nas classes herdadas, sendo assim, exibindo a hora em formatos diferentes em Nokia e Iphone.
* **List<string> agenda**: essa lista adiciona, remove e exibe seus compromissos. Como o projeto é todo em POO, ela também é criada na classe abstrata e é herdada por **Nokia** e **Iphone**.
  
