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

**Metodo PUT:**
O metodo PUT vai servir pra atualizar algum registro já existente na API, sendo preciso indicar o ID do registro que pode ser obtido pelo metodo GET e também seu corpo json, e logo depois de fazer a atualização é retornado ela

![Fun_Put_1](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/e4c83cc3-62ef-4069-8016-2119dec06ac2)
![Fun_Put_2](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/cae8cedd-0f92-40a0-9fb4-9a03f928430e)

**Metodo DELETE:**
O metodo DELETE apaga o registro no banco, precisando indica o ID do dado

![Func_delete](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/842f8489-6919-49dd-8aa6-f37ade0e25ee)
![Func_delete_1](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/ec14cc48-1458-44e2-bbcf-4be38848b6d5)

**Tabela Poders:**
![Poder_geral](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/bf7cf3ad-98f9-4ec1-8f2c-a5734e445256)
**Metodo GET:**
O metodo GET após ser executado vai trazer todos os registros que tem no banco de dados
![Poder_Get](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/ec116f59-5569-4fbe-a1b2-5cd1348d4756)

**Metodo POST:**
O metodo POST vai fazer a inserção de dados na API, pra isso deve ser seguido o esquema trazido pelo json, indicando o que deve ser inserido

![Poder_Post_1](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/70d04dfa-1629-45b0-b5ae-3245c294af74)

A preencher o dados indicados, menos o ID que vai ser gerado pelo banco, a API vai cadastras essa informação no banco de dados

![Poder_Post_2](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/2893318d-7d96-4667-b8b4-1692b4a62344)

![Poder_Post_3](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/c26b9fac-b917-49ad-9ca2-8d861b5cad91)

**Metodo GET com parametro:**
Esse metodo é igual o GET, mais agora vamos indica um parâmetro para a pesquisa, que nesse caso vai ser pelo ID

![Poder_get_1](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/c14547cb-6ba0-4147-93b4-b1e27938d7e4)

![Poder_get_2](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/7d487dbb-7ff7-448d-8b47-216c22b3641b)

**Metodo PUT:**
O metodo PUT vai servir pra atualizar algum registro já existente na API, sendo preciso indicar o ID do registro que pode ser obtido pelo metodo GET e também seu corpo json, e logo depois de fazer a atualização é retornado ela

![Poder_put_1](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/ebf8c36d-311c-475a-af84-7b67cea2f611)

![Poder_put_2](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/a9d0dc67-f83a-45fd-9e82-1f4f5a0acf7a)


**Metodo DELETE:**
O metodo DELETE apaga o registro no banco, precisando indica o ID do dado

![Poder_delete_1](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/4e09be3b-183c-418f-ba1c-1c5fab682260)
![Poder_delete_2](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/9bd1b40d-fd7f-4238-ac38-6c5165bc1755)

**Tabela Persos:**
![Perso_geral](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/544700ea-253e-4a46-b6d1-e5a687b1073d)
**Metodo GET:**
O metodo GET após ser executado vai trazer todos os registros que tem no banco de dados
![Perso_get1](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/2f5e6775-9053-4b91-8289-4d0dbc88d329)
![Perso_get2](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/1c859a3c-6446-4414-98c3-888598445bb3)

![Perso_get3](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/6fc190b9-36f3-4042-86e5-edbec6729abd)

![Perso_get4](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/5c3bcfd4-ccf1-49d8-b142-b64d6672f72f)

**Metodo POST:**
O metodo POST vai fazer a inserção de dados na API, pra isso deve ser seguido o esquema trazido pelo json, indicando o que deve ser inserido

![Perso_post_1](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/d73786b9-d24b-47ff-b4ab-41743f73b97c)

A preencher o dados indicados, menos o ID que vai ser gerado pelo banco, a API vai cadastras essa informação no banco de dados. **OBS:** PoderId e FuncId são chave estrageiras de outra tabela, então será preciso coloca uma chave existente da outra tabela 


![Perso_post_2](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/735ab7f5-0e1d-4b19-bd88-0b5a707b8435)
![Perso_post_3](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/d55fee3e-47ef-44cc-93e8-e58ea1d94716)

**Metodo GET com parametro:**
Esse metodo é igual o GET, mais agora vamos indica um parâmetro para a pesquisa, que nesse caso vai ser pelo ID

![Perso_get_1](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/0a50d8cc-5b20-408c-849e-4dc7df9304bc)

![Perso_get_2](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/7da48917-f3f5-4534-9381-a951e28e931d)

**Metodo PUT:**
O metodo PUT vai servir pra atualizar algum registro já existente na API, sendo preciso indicar o ID do registro que pode ser obtido pelo metodo GET e também seu corpo json, e logo depois de fazer a atualização é retornado ela. **OBS:** PoderId e FuncId são chave estrageiras de outra tabela, se for atualiza elas é preciso apaga o atributos que vem junto com ela e mudar apenas o ID

![Perso_put_1](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/2e889d11-2ace-404a-a57f-26c260935f15)

![Perso_put_2](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/ebbac578-2c1c-462f-88c5-51daab324373)

![Perso_put_3](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/6aed8682-9e65-40af-8dd7-9ada73b00525)


**Metodo DELETE:**
O metodo DELETE apaga o registro no banco, precisando indica o ID do dado

![Perso_delete_1](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/213c4a86-9ba0-422d-9361-8ddffe00cca9)
![Perso_delete_2](https://github.com/FelipeOropeza/ApiAnime/assets/101806766/cc2ac8cc-f373-431b-ba68-d1a7889dff61)
