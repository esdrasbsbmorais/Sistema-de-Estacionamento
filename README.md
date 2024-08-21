# Sistema de Estacionamento em C#

Este é um sistema de estacionamento simples desenvolvido em C#. Trata-se de um aplicativo de console onde os usuários podem cadastrar e gerenciar veículos em uma lista localmente.

## Desafio

Este desafio faz parte de um bootcamp da Digital Innovation One (DIO) e consistia nas seguintes funcionalidades:

- **Adicionar um veículo**:
  - Permitir que o usuário insira um novo veículo no sistema, validando as informações e adicionando-o à lista de veículos estacionados.

- **Remover um veículo**:
  - Permitir que o usuário remova um veículo da lista de veículos estacionados. O sistema deve calcular e exibir o valor a ser cobrado pelo tempo de estacionamento.

- **Listar os veículos estacionados**:
  - Exibir uma lista dos veículos que estão atualmente estacionados no sistema.

### Bônus

- **Validação de Placas**:
  - Implementei uma validação extra para verificar se a placa inserida está no formato correto. Utilizei expressões regulares (regex) para garantir que a placa segue o padrão brasileiro, incluindo tanto o formato antigo quanto o novo formato MERCOSUL.

## Sobre Regex

Expressões Regulares (regex) são padrões utilizados para corresponder e manipular texto de forma eficiente. No contexto deste projeto, as regex foram usadas para validar se a placa do veículo inserida segue os padrões brasileiros:

- **Formato Antigo**: Três letras seguidas de quatro números (ex.: ABC-1234).
- **Formato MERCOSUL**: Quatro letras seguidas de três números (ex.: ABC1D23).
