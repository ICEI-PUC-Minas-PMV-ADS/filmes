# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

| **Caso de Teste**       | CT-01 – Marcar um filme como assistido                                                                                        |
| :---------------------- | :---------------------------------------------------------------------------------------------------------------------------- |
| **Requisito Associado** | RF-001                                                                                                                        |
| **Objetivo do Teste**   | Verificar se um usuário pode marcar um filme como assistido.                                                                  |
| **Passos**              | 1. Fazer login na conta de usuário. 2. Acessar uma lista de filmes. 3. Selecionar um filme. 4. Marcar o filme como assistido. |
| **Critério de Êxito**   | O filme é marcado como assistido com sucesso.                                                                                 |

| **Caso de Teste**       | CT-02 – Dar uma nota de 0 a 100 para um filme                                                                         |
| :---------------------- | :-------------------------------------------------------------------------------------------------------------------- |
| **Requisito Associado** | RF-002                                                                                                                |
| **Objetivo do Teste**   | Verificar se um usuário pode dar uma nota de 0 a 100 para um filme.                                                   |
| **Passos**              | 1. Fazer login na conta de usuário. 2. Acessar uma lista de filmes. 3. Selecionar um filme. 4. Dar uma nota ao filme. |
| **Critério de Êxito**   | A nota é atribuída ao filme com sucesso dentro do intervalo de 0 a 100.                                               |

| **Caso de Teste**       | CT-03 – Escrever um review de um filme                                                                                          |
| :---------------------- | :------------------------------------------------------------------------------------------------------------------------------ |
| **Requisito Associado** | RF-003                                                                                                                          |
| **Objetivo do Teste**   | Verificar se um usuário pode escrever um review de um filme.                                                                    |
| **Passos**              | 1. Fazer login na conta de usuário. 2. Acessar uma lista de filmes. 3. Selecionar um filme. 4. Escrever um review para o filme. |
| **Critério de Êxito**   | O review é registrado com sucesso para o filme.                                                                                 |
|                         |

| **Caso de Teste**       | CT-04 – Filtrar a lista de filmes por diferentes critérios                                                                  |
| :---------------------- | :-------------------------------------------------------------------------------------------------------------------------- |
| **Requisito Associado** | RF-004                                                                                                                      |
| **Objetivo do Teste**   | Verificar se um usuário pode filtrar a lista de filmes por diferentes critérios.                                            |
| **Passos**              | 1. Fazer login na conta de usuário. 2. Acessar uma lista de filmes. 3. Aplicar um filtro específico, como gênero, ano, etc. |
| **Critério de Êxito**   | A lista de filmes é filtrada com sucesso de acordo com o critério selecionado.                                              |

| **Caso de Teste**       | CT-05 – Organizar a lista de filmes                                                                             |
| :---------------------- | :-------------------------------------------------------------------------------------------------------------- |
| **Requisito Associado** | RF-005                                                                                                          |
| **Objetivo do Teste**   | Verificar se um usuário pode organizar a lista de filmes.                                                       |
| **Passos**              | 1. Fazer login na conta de usuário. 2. Acessar uma lista de filmes. 3. Reorganizar a ordem dos filmes na lista. |
| **Critério de Êxito**   | A ordem dos filmes na lista é alterada com sucesso.                                                             |

| **Caso de Teste**       | CT-06 – Procurar por filmes através de uma searchbar                                                   |
| :---------------------- | :----------------------------------------------------------------------------------------------------- |
| **Requisito Associado** | RF-006                                                                                                 |
| **Objetivo do Teste**   | Verificar se um usuário pode procurar por filmes através de uma barra de pesquisa.                     |
| **Passos**              | 1. Fazer login na conta de usuário. 2. Utilizar a barra de pesquisa para procurar um filme específico. |
| **Critério de Êxito**   | Os resultados da pesquisa são exibidos com sucesso de acordo com o termo de busca.                     |

| **Caso de Teste**       | CT-07 – Alternar entre modos Dark e Bright                                |
| :---------------------- | :------------------------------------------------------------------------ |
| **Requisito Associado** | RF-007                                                                    |
| **Objetivo do Teste**   | Verificar se um usuário pode alternar entre modos Dark e Bright.          |
| **Passos**              | 1. Acessar as configurações da conta. 2. Selecionar a opção de modo Dark. |
| **Critério de Êxito**   | O modo de exibição da aplicação muda com sucesso para o modo Dark.        |

| **Caso de Teste**       | CT-08 – Ler a sinopse de um filme                                |
| :---------------------- | :------------------------------------------------------------------------ |
| **Requisito Associado** | RF-008                                                                    |
| **Objetivo do Teste**   | Verificar se um usuário pode ler a sinopse de um filme.                   |
| **Passos**              | 1. Fazer login na conta de usuário. 2. Acessar uma lista de meus filmes. 3. Selecionar Detalhes. 4. Ler sinopse. |
| **Critério de Êxito**   | A sinopse correspondente ao filme é exibida com succeso .        |

| **Caso de Teste**       | CT-09 – Curtir os comentários de outros usuários                                                                    |
| :---------------------- | :------------------------------------------------------------------------------------------------------------------ |
| **Requisito Associado** | RF-009                                                                                                              |
| **Objetivo do Teste**   | Verificar se um usuário pode curtir os comentários de outros usuários.                                              |
| **Passos**              | 1. Fazer login na conta de usuário. 2. Visualizar um comentário. 3. Clicar no botão "Curtir" ao lado do comentário. |
| **Critério de Êxito**   | O comentário é curtido com sucesso pelo usuário.                                                                    |

| **Caso de Teste**       | CT-10 – Descurtir os comentários de outros usuários                                                                                        |
| :---------------------- | :----------------------------------------------------------------------------------------------------------------------------------------- |
| **Requisito Associado** | RF-010                                                                                                                                     |
| **Objetivo do Teste**   | Verificar se um usuário pode descurtir os comentários de outros usuários.                                                                  |
| **Passos**              | 1. Fazer login na conta de usuário. 2. Visualizar um comentário previamente curtido. 3. Clicar no botão "Descurtir" ao lado do comentário. |
| **Critério de Êxito**   | O curtir é removido com sucesso do comentário.                                                                                             |
|                         |

Esses casos de teste abrangem os requisitos identificados e ajudarão a verificar se a aplicação está funcionando de acordo com as especificações. Adaptaremos esses casos de teste conforme necessário para refletir as características específicas da aplicação e adicionaremos outros casos de teste, se necessário.

> **Links Úteis**:
>
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> - [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
