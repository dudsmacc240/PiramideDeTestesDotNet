Feature: Realizar Pedido
  Para garantir que um pedido possa ser criado corretamente
  Como usuário da aplicação
  Eu quero adicionar itens e calcular o valor total do pedido

  Scenario: Criar Pedido Válido
    Given que eu tenha um novo pedido
    When eu adicionar um item com quantidade 3 e preço unitário de 40
    Then o valor total do pedido deve ser 120

  Scenario: Pedido com Item de Quantidade Zero
    Given que eu tenha um novo pedido
    When eu adicionar um item com quantidade 0 e preço unitário de 50
    Then o pedido deve ser considerado inválido

  Scenario: Pedido com Frete Grátis
    Given que eu tenha um novo pedido
    When eu adicionar um item com quantidade 6 e preço unitário de 100
    Then o frete deve ser grátis

Scenario: Pedido com Valor Menor que 500
  Given que eu tenha um novo pedido
  When eu adicionar um item com quantidade 2 e preço unitário de 100
  Then o frete deve ser cobrado

  Scenario: Pedido com Item de Quantidade Negativa
  Given que eu tenha um novo pedido
  When eu adicionar um item com quantidade -1 e preço unitário de 50
  Then o pedido deve ser considerado inválido