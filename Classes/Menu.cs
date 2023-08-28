using System;

class MenuAluno
{
    public static void ExibirMenu(Aluno aluno)
    {
        int escolha = 0;

        Console.WriteLine("=================== Menu Aluno ===================");
        Console.WriteLine($"Aluno: {aluno.nomeAluno}");
        Console.WriteLine($"Disciplina: {aluno.disciplina.nomeDisciplina}");
        Console.WriteLine("==================================================");

        do
        {
            try
            {
                Console.WriteLine("[1]  - Exibir boletim");
                Console.WriteLine("[2]  - Atualizar nota 1º bimestre");
                Console.WriteLine("[3]  - Atualizar nota 2º bimestre");
                Console.WriteLine("[4]  - Calcular Média");
                Console.WriteLine("[5]  - Verificar Status do aluno");
                Console.WriteLine("[6]  - Exibir total de faltas");
                Console.WriteLine("[7]  - Atribuir falta");
                Console.WriteLine("[8]  - Abonar falta");
                Console.WriteLine("[9]  - Exibir carga horária da disciplina");
                Console.WriteLine("[10] - Finalizar disciplina");
                Console.WriteLine("[11] - Exibir status da disciplina");
                Console.WriteLine("[0]  - Sair do Menu");
                Console.WriteLine("=============================================");
                Console.Write("Escolha uma opção: ");

                escolha = Convert.ToInt32(Console.ReadLine());//necessário conversão para int devido à natureza do método ReadLine :D

                switch (escolha)
                {
                    case 1:
                        aluno.ExibirNotas();
                        break;

                    case 2:
                        Console.Write("Digite a nota do 1º bimestre: ");
                        if (double.TryParse(Console.ReadLine(), out double nota1))
                        {
                            aluno.AtribuirNota1(nota1);
                            Console.WriteLine($"Nota atribuída com sucesso.\n");
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida para nota.\n");
                        }
                        break;

                    case 3:
                        Console.Write("Digite a nota do 2º bimestre: ");
                        if (double.TryParse(Console.ReadLine(), out double nota2))
                        {
                            aluno.AtribuirNota2(nota2);
                            Console.WriteLine($"Nota atribuída com sucesso.\n");
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida para nota.\n");
                        }
                        break;

                    case 4:
                        aluno.CalcularMedia();
                        Console.WriteLine($"Média calculada: {aluno.media:F1}\n");
                        break;

                    case 5:
                        aluno.VerificarStatus();
                        break;

                    case 6:
                        Console.WriteLine($"Faltas totais: {aluno.faltas} \n");
                        break;

                    case 7:
                        aluno.AtribuirFalta();
                        break;

                    case 8:
                        aluno.AbonarFalta();
                        break;

                    case 9:
                        aluno.disciplina.ExibirCargaHorariaDisciplina();
                        break;

                    case 10:
                        aluno.disciplina.FinalizarDisciplina();
                        aluno.disciplina.ExibeStatusDisciplina();
                        break;

                    case 11:
                        aluno.disciplina.ExibeStatusDisciplina();
                        break;

                    case 0:
                        Console.WriteLine("Saindo do menu.\n");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.\n");
                        break;
                }
            }
            
            catch (Exception)
            {
                Console.WriteLine("Erro: Entrada inválida. Certifique-se de inserir uma opção válida.\n");
                escolha = -1; //para repetir o loop
            }

        } while (escolha != 0);
    }
}
