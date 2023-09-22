# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto".

Por exemplo:

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

> **Links Úteis**:
>
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> - [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
