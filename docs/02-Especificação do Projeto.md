# Especificações do Projeto

Nesta parte do documento, vamos abordar a definição do problema e a ideia de solução sob a perspectiva dos usuários. Para isso, utilizaremos técnicas e ferramentas como a criação de diagramas de personas, histórias de usuários, requisitos funcionais e não funcionais, bem como as restrições do projeto.
Ao utilizar essas técnicas e ferramentas, seremos capazes de definir de forma abrangente o problema a ser resolvido e criar uma ideia de solução que atenda às necessidades e expectativas dos usuários, ao mesmo tempo em que respeita as restrições e requisitos do projeto. Isso servirá como um guia fundamental para o desenvolvimento da aplicação de Recomendação de Filmes baseada nos "100 Melhores Filmes de Todos os Tempos".

## Personas

### Ana Luiza

Como professora de Teorias da Personalidade, utilizo filmes como ferramenta educacional. Um repositório de filmes bem avaliados com análises seria incrivelmente útil para aprimorar minhas aulas e oferecer exemplos mais concretos aos alunos.

Adoro trazer inovação às aulas. Já usei filmes como "Um contratempo" e "Fragmentado" para discutir e ter percepções da turma. Já senti dificuldades em encontrar filmes para aula, apesar de existir uma quantidade significativa que seja útil, mas um site com os 100 melhores filmes seria uma ótima ferramenta.

### Pedro

Como estudante de Cinema e Audiovisual, trabalhando no meu TCC, preciso identificar rapidamente filmes altamente avaliados. Uma plataforma que reúna esses filmes e forneça informações relevantes agilizaria minha pesquisa e análise.

Tenho muito foco na influência cultural do cinema. Me ajudaria a evidenciar como filmes podem ser catalisadores de discussões sociais e transformações.

### Leonardo

Sou economista. Visando minha rotina corrida, em momentos livres, gosto de desfrutar bons filmes. Um site listando os melhores filmes seria perfeito para meus insights sobre como decisões artísticas afetam o sucesso comercial.

Tenho o costume de fazer noite de cinema com minha esposa. Em muitos momentos, ficamos indecisos para escolher o filme, pois para ambos a avaliação do filme é um fator importante. Ter um local para ver os filmes mais bem avaliados seria ideal para o nosso desafio.

### Catarina

Sou professora de Literatura. Clássicos cinematográficos são minha paixão. Recentemente, discuti "E o Vento Levou" com amigos, comparando-o ao romance. Um site com os melhores filmes seria incrível para explorar novos ares do mundo do cinema.

Amo literatura e cinema. Em meu aniversário, adoro fazer festas temáticas. Seria uma fonte valiosa para criar experiências, conectando literatura e cinema de maneira única.

### Bruna

Amo efeitos visuais e narrativas tecnológicas. Explorar como tecnologia e narrativa se fundem no cinema, inspirando minha abordagem como engenheira de software, é algo que me faz ser muito criteriosa com a escolha de filmes que irei assistir.

Além de assistir filmes e séries, meu maior hobby é avaliá-los. Adoraria poder contribuir com minhas perspectivas e pontos de vista, além de conseguir encontrar filmes bem avaliados.

## Histórias de Usuários

| EU COMO...    | QUERO/PRECISO...                                                             | PARA...                                                                                         |
| ------------- | ---------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| **Ana Luiza** | Utilizar filmes como ferramenta educacional                                  | Aprimorar minhas aulas e oferecer exemplos concretos aos alunos.                                |
| **Pedro**     | Identificar rapidamente filmes altamente avaliados para pesquisa e análise   | Agilizar minha pesquisa acadêmica e evidenciar a influência cultural do cinema.                 |
| **Leonardo**  | Encontrar filmes para entretenimento pessoal e noites de cinema com a esposa | Desfrutar de bons filmes e tomar decisões informadas sobre escolhas de filmes.                  |
| **Catarina**  | Explorar clássicos cinematográficos para enriquecer o ensino                 | Criar experiências únicas conectando literatura e cinema.                                       |
| **Bruna**     | Encontrar filmes com narrativas tecnológicas e efeitos visuais               | Explorar como tecnologia e narrativa se fundem no cinema e contribuir com avaliações de filmes. |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

| ID     | Descrição do Requisito                             | Prioridade |
| ------ | -------------------------------------------------- | ---------- |
| RF-001 | Marcar um filme como assistido                     | ALTA       |
| RF-002 | Dar uma nota de 0 a 100 para um filme              | MÉDIA      |
| RF-003 | Escrever um review de um filme                     | ALTA       |
| RF-004 | Filtrar a lista de filmes por diferentes critérios | ALTA       |
| RF-005 | Organizar a lista de filmes                        | MÉDIA      |
| RF-006 | Procurar por filmes através de uma searchbar       | ALTA       |
| RF-007 | Alternar entre modos Dark e Bright                 | MÉDIA      |
| RF-008 | Ler a sinopse de um filme                          | ALTA       |
| RF-009 | Curtir os comentários de outros usuários           | MÉDIA      |
| RF-010 | Descurtir os comentários de outros usuários        | MÉDIA      |

### Requisitos não Funcionais

| ID      | Descrição do Requisito                                                     | Prioridade |
| ------- | -------------------------------------------------------------------------- | ---------- |
| RNF-001 | O aplicativo deve ter um tempo de resposta rápido para operações CRUD      | ALTA       |
| RNF-002 | As operações CRUD devem ser concluídas em um intervalo de tempo aceitável  | ALTA       |
| RNF-003 | O acesso às operações CRUD deve ser restrito apenas a usuários cadastrados | ALTA       |
| RNF-004 | O sistema deve estar disponível a maior parte do tempo                     | MÉDIA      |
| RNF-005 | O aplicativo deve ser responsivo e adaptável a diferentes dispositivos     | ALTA       |
| RNF-006 | O código do aplicativo deve ser modular e bem organizado                   | ALTA       |

## Restrições

| ID  | Restrição                                                                                                                                          |
| --- | -------------------------------------------------------------------------------------------------------------------------------------------------- |
| 01  | A equipe de desenvolvimento está limitada a um número específico de membros.                                                                       |
| 02  | A aplicação deve ser desenvolvida usando tecnologias de código aberto para reduzir os custos de licenciamento.                                     |
| 03  | O projeto deve ser compatível com os navegadores mais comuns, como Chrome, Firefox e Edge, não sendo necessário suportar navegadores mais antigos. |
| 04  | A infraestrutura de hospedagem da aplicação deve ser escolhida de acordo com o orçamento disponível.                                               |
| 05  | O projeto deverá ser entregue até o final do semestre.                                                                                             |

## Diagrama de Casos de Uso

![Diagrama](/src/diagramacasodeusocineview.png)
