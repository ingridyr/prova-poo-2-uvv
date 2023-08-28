using System;

class Aluno
{
    public string nomeAluno;
    public double nota1;
    public double nota2;
    public double media;
    public string status;
    public bool semestreFinalizado = false;
    public int faltas = 0;
    public int matricula;
    public Disciplina disciplina;
    public Aluno(string nomeAluno, int matricula, Disciplina disciplina)
    {
        this.nomeAluno = nomeAluno;
        this.matricula = matricula;
        this.disciplina = disciplina;
        status = "Cursando";
    }

    public void AtribuirNota1(double nota1)
    {
        this.nota1 = nota1;
    }

    public void AtribuirNota2(double nota2)
    {
        this.nota2 = nota2;
    }

    public void CalcularMedia()
    {
        this.media = (nota1 + nota2) / 2;
    }

    public void AtribuirFalta()
    {
        this.faltas++;
    }

    public void AbonarFalta()
    {
        if (this.faltas > 0)
        {
            faltas--;
        }
    }

    public void FinalizarSemestre()
    {
        this.semestreFinalizado = true;
    }

    public void VerificarStatus()
    {
        double percentFaltas = (double)faltas / disciplina.totalHoras * 100;

        if (percentFaltas > 25)
        {
            status = "Reprovado";
        }
        else if (semestreFinalizado || disciplina.disciplinaFinalizada)
        {
            if (media >= 7)
            {
                status = "Aprovado";
            }
            else
            {
                status = "Reprovado";
            }
        }
        else
        {
            status = "Cursando";
        }

        string prep = status == "Cursando" ? "a" : "na";

        Console.WriteLine($"O aluno {nomeAluno} está {status.ToLower()} {prep} disciplina {disciplina.nomeDisciplina}.");
        disciplina.ExibeStatusDisciplina();
    }

    public void ExibirNotas()
    {
        Console.WriteLine($"Nota 1º bimestre: {nota1:F1}");
        Console.WriteLine($"Nota 2º bimestre: {nota2:F1}");
        Console.WriteLine($"Média semestre: {media:F1}\n");
    }

}
