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
![Fun_Get](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/54ab9aac-51ac-44b7-bfbe-26c98c46f0ea)
O metodo GET após ser executado vai trazer todos os registros que tem no banco de dados
**Metodo POST:**
![Func_Post](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/651d9d5d-f453-45e3-a73e-34a939e772a0)
O metodo POST vai fazer a inserção de dados na API, pra isso deve ser seguido o esquema trazido pelo json, indicando o que deve ser inserido

