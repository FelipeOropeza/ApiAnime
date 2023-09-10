# ApiAnime
Dupla: Felipe Carvalho e Rogério Rodrigues

**Configuracoes Iniciais:**

1- Fazer a construção do banco de dados, já que a API está rodando de forma local, isso será feito com o seguinte comando *Update-Database -Context ApiPersoDBContex*, o comando vai ser inserido no *Console do Gerenciador de Pacotes* onde é encontrado pelo seguinte caminho Ferramentas/Gerenciador de Pacotes do NuGet/Console do Gerenciador de Pacotes. **Obs:** O banco precisa ser criado no Sql Server Management, dependendo do computador a Strign de conexão deve ser mudada

2- Depois é preciso executar o script do sql, onde se localiza na pasta Sql dentro do projeto, nele está os inserts onde vai fazer a alimentação da API.

**Dicionario de Dados:**

**Tabela Funcs:**
| Atributo | Tipo | Descrição |
| -------- | ---- |---------- |
| Id | Int | Indentificação da tabela |
| TipoFunc | Strign | Tipo de função que o personagem tem |

**Tabela Poders:**
| Atributo | Tipo | Descrição |
| -------- | ---- |---------- |
| Id | Int | Indentificação da tabela |
| Resp | Strign | A respiração (Indica uma habilidade no Anime) que o personagem tem ou não |

**Tabela Persos:**
| Atributo | Tipo | Descrição |
| -------- | ---- |---------- |
| Id | Int | Indentificação da tabela |
| Nome | Strign | Indica o nome do personagem |
| Origem | Strign | De que Anime o personagem é |
| Apelido | Strign | Apelido do personagem |
| Metas | Strign | Uma meta que o personagem tem no anime |
| FunId | Int | Chave estrgeira da tabela Funcs |
| PoderId | Int | Chave estrgeira da tabela Poders |

**Funcionamento da API:**

Nas tabelas da api estão disponiveis todos os metodos do CRUD, que seriam o GET, POST, PUT, DELETE, que nada mais seria que leitura, inserção, atualizacão e exclusão 

**Tabela Funcs:**
![Func_Geral](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/17ed0aab-3124-4cd4-b763-cd30b024f706)
**Metodo GET:**
O metodo GET após ser executado vai trazer todos os registros que tem no banco de dados
![Fun_Get](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/54ab9aac-51ac-44b7-bfbe-26c98c46f0ea)

**Metodo POST:**
O metodo POST vai fazer a inserção de dados na API, pra isso deve ser seguido o esquema trazido pelo json, indicando o que deve ser inserido

![Func_Post](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/651d9d5d-f453-45e3-a73e-34a939e772a0)

A preencher o dados indicados, menos o ID que vai ser gerado pelo banco, a API vai cadastras essa informação no banco de dados

![Func_Post_2](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/632d31dc-8601-4f97-9098-a886154d1ea9)
![Func_Post_3](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/129e9e02-18ca-44be-bf2c-2e30be2baa15)

**Metodo GET com parametro:**
Esse metodo é igual o GET, mais agora vamos indica um parâmetro para a pesquisa, que nesse caso vai ser pelo ID
![Fun_Get_1](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/375980f0-706b-48c2-b8c3-b602aafffde1)
![Fun_Get_2](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/626aee19-49dc-45de-a770-3dddca5d9b41)

