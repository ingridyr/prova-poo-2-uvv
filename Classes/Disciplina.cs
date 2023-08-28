using System;
class Disciplina
{
    public string nomeDisciplina;
    public int totalHoras;
    public bool disciplinaFinalizada;

    public Disciplina(string nomeDisciplina, int totalHoras)
    {
        this.nomeDisciplina = nomeDisciplina;
        this.totalHoras = totalHoras;
        disciplinaFinalizada = false;
    }

    public void FinalizarDisciplina()
    {
        disciplinaFinalizada = true;
    }

    public void ExibeStatusDisciplina()
    {
        string disciplinaStatus = disciplinaFinalizada ? "Finalizada" : "Em andamento";

        Console.WriteLine($"Status da disciplina {nomeDisciplina}: {disciplinaStatus}.\n");
    }

    public void ExibirCargaHorariaDisciplina()
    {
        Console.WriteLine($"Carga horária da disciplina {nomeDisciplina}: {totalHoras}h\n");
    }
}
