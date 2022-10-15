internal class Aluno
{
    private double nota;
    private string nome;
    private int mat;
    public Aluno()
    {
        nome = "";
        nota = 0.00;
        mat = 0;
    }

    public Aluno(double nota, string nome, int mat)
    {
        this.nota = nota;
        this.nome = nome;
        this.mat = mat;
    }
    public int SetNota(int nota)
    {
        return nota;
    }
    public int GetNota(int nota)
    {
        return nota;
    }

    public 
}