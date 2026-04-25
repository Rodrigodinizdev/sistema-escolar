# sistema-escolar

Regra de Negócio: Sistema Escolar Luminar
A Escola Luminar é uma instituição de ensino que atua há quinze anos oferecendo educação de qualidade no Ensino Fundamental e Médio. Com o crescimento do número de turmas e professores, a coordenação pedagógica decidiu modernizar sua gestão acadêmica com um sistema desenvolvido internamente.
Toda pessoa vinculada à escola — seja ela um aluno ou um professor — possui informações em comum: um nome completo, uma data de nascimento e um CPF único que a identifica no sistema. No entanto, alunos e professores existem de formas distintas dentro da organização e carregam informações e responsabilidades bem diferentes entre si.
Quando um professor é contratado pela Luminar, ele recebe automaticamente um número de registro funcional, único e sequencial dentro do sistema. Além disso, cada professor possui uma área de atuação, que representa sua especialidade — por exemplo, "Matemática", "Língua Portuguesa" ou "Ciências". Um professor pode ser responsável por uma ou mais turmas.
Já um aluno, ao ser matriculado, recebe automaticamente um número de matrícula único e sequencial. Junto à matrícula, o sistema também registra a data de ingresso do aluno na escola. Um aluno pode estar inscrito em várias turmas.
As turmas da Luminar possuem um nome (por exemplo, "9º Ano A") e um turno de funcionamento — Matutino, Vespertino ou Noturno. Cada turma obrigatoriamente tem um professor responsável, sem o qual ela não pode ser cadastrada no sistema. O mesmo professor não pode ser responsável por duas turmas ao mesmo tempo com o mesmo nome.
Quanto à avaliação dos alunos, a Luminar adota um modelo com dois tipos distintos de instrumentos avaliativos: as Provas e os Trabalhos. Ambos registram um título descritivo, a data de realização e a nota obtida pelo aluno — que deve estar obrigatoriamente entre 0,0 e 10,0. A diferença entre eles está no peso que cada um carrega no cálculo do desempenho final do aluno em uma turma: uma Prova contribui com 70% do valor, enquanto um Trabalho contribui com 30%. Um aluno deverá possuir uma Prova e um Trabalho por turma.
O sistema precisa ser capaz de, a qualquer momento, listar todos os alunos, professores e turmas cadastrados. Também deve ser possível buscar um aluno pelo nome — mesmo que a busca seja parcial, o sistema deve retornar todos os alunos cujo nome contenha o trecho digitado, sem distinção entre maiúsculas e minúsculas.
Uma funcionalidade muito valorizada pela coordenação é o Ranking Geral dos Alunos por Turma: dado o nome de uma turma, o sistema deve listar todos os alunos que possuem ao menos uma avaliação naquela turma, exibindo seus desempenhos calculados e ordenando-os do maior para o menor desempenho. Alunos sem nenhuma avaliação naquela turma não devem aparecer no ranking.
Além do ranking, o sistema deve oferecer um Boletim Individual do Aluno: ao selecionar um aluno, o sistema exibe todas as turmas em que ele possui avaliações, com suas respectivas notas, a média calculada e a situação final. A situação segue a seguinte regra: se a média for maior ou igual a 7,0, o aluno está Aprovado; se for maior ou igual a 5,0 e menor que 7,0, está Em Recuperação; caso contrário, está Reprovado. As turmas no boletim devem ser exibidas em ordem alfabética.
Por fim, a coordenação também quer poder filtrar alunos por situação em uma determinada turma — ou seja, dado o nome de uma turma, o sistema deve conseguir exibir separadamente os alunos Aprovados, os Em Recuperação e os Reprovados, cada grupo ordenado alfabeticamente pelo nome do aluno.
Todo o funcionamento do sistema se dá por meio de um menu interativo no console, que permanece ativo até que o usuário escolha explicitamente a opção de encerramento.

As principais equivalências com o sistema Atlas para você mapear mentalmente:

Gestor → Professor (registro funcional, departamento → área de atuação, responsável por projetos → responsável por turmas)
Analista → Aluno (matrícula, data de admissão → data de ingresso, alocado em projetos → inscrito em turmas)
Projeto → Turma (nome, orçamento → turno, exige gestor → exige professor)
Avaliação Técnica (60%) → Prova (70%)
Avaliação Comportamental (40%) → Trabalho (30%)
Promovido / Em Observação / Desligado → Aprovado / Em Recuperação / Reprovado

A lógica de herança, composição, cálculo de média ponderada, rankings e relatórios é idêntica — só muda o contexto. Bons estudos na prova!
