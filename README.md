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
