class AlunoPrograma
{
    static void Main(string[] args)
    {
        {
            Disciplina disciplina = new Disciplina("POO II", 80);
            Aluno aluno1 = new Aluno("Ingridy Rodrigues", 202201383, disciplina);

            MenuAluno.ExibirMenu(aluno1);
        }
    }
}
