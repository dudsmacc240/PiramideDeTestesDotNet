Feature: Realizar Pedido
  Para garantir que um pedido possa ser criado corretamente
  Como usu�rio da aplica��o
  Eu quero adicionar itens e calcular o valor total do pedido

  Scenario: Criar Pedido V�lido
    Given que eu tenha um novo pedido
    When eu adicionar um item com quantidade 3 e pre�o unit�rio de 40
    Then o valor total do pedido deve ser 120

  Scenario: Pedido com Item de Quantidade Zero
    Given que eu tenha um novo pedido
    When eu adicionar um item com quantidade 0 e pre�o unit�rio de 50
    Then o pedido deve ser considerado inv�lido

  Scenario: Pedido com Frete Gr�tis
    Given que eu tenha um novo pedido
    When eu adicionar um item com quantidade 6 e pre�o unit�rio de 100
    Then o frete deve ser gr�tis

Scenario: Pedido com Valor Menor que 500
  Given que eu tenha um novo pedido
  When eu adicionar um item com quantidade 2 e pre�o unit�rio de 100
  Then o frete deve ser cobrado

  Scenario: Pedido com Item de Quantidade Negativa
  Given que eu tenha um novo pedido
  When eu adicionar um item com quantidade -1 e pre�o unit�rio de 50
  Then o pedido deve ser considerado inv�lido