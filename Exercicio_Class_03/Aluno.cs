using System.Collections.Generic;

namespace Exercicio_Class_03
{
    public enum TipoGrau { Infantil, Fundamental, Medio, Superior, Pos, Mestrado, Doutorado, Outro}
    public enum TipoEnsino { Basica, Superior, Outro}
    //classe do aluno
    public class Aluno
    {
        public Aluno()
        {
            this.Matricula = 1;
            this.Nome = "";
            this.Telefone = 1;
            this.Grau = TipoGrau.Outro;
            this.Ensino = TipoEnsino.Outro;
        }

        public Aluno(int matricula, String nome, int telefone, TipoGrau grau, TipoEnsino Ensino)
        {
            this.Matricula = matricula;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Grau = grau;
            this.Ensino = Ensino;
        }

        public int matricula;

        public int Matricula
        {
            get { return matricula; }
            set
            {
                if (value > 0) matricula = value;
                else
                {
                    throw new Exception("Permitido apenas numeros positivos!!!!");
                }
            }
        }

        public String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        public int telefone;

        public int Telefone
        {
            get { return telefone; }
            set
            {
                if (value > 0) telefone = value;
                else
                {
                    throw new Exception("Permitido apenas numeros positivos!!!!");
                }
            }
        }

        public TipoEnsino Ensino { get; set; }
        public TipoGrau Grau { get; set; }
    }
    //classe de controle de alunos
    public class ListaDeAlunos
    {

        private List<Aluno> alunos;
        public List<Aluno> Alunos
        {
            get
            {
                return alunos;
            }
        }

        public ListaDeAlunos()
        {
            alunos = new List<Aluno>();
        }

        public Boolean Inserir(Aluno aluno)
        {
            Boolean resultado = true;
            try
            {
                Aluno j = alunos.Find(x => x.Matricula == aluno.Matricula);
                if (j == null)
                {
                    alunos.Add(aluno);
                }
                else
                {
                    resultado = false;
                }
            }
            catch (Exception erro)
            {
                resultado = false;
            }
            return resultado;
        }
        public Boolean Alterar(Aluno aluno)
        {
            Boolean resultado = false;
            Aluno j = alunos.Find(x => x.Matricula == aluno.Matricula);
            if (j != null)
            {
                j.Nome = aluno.Nome;
                j.Telefone = aluno.Telefone;
                j.Grau = aluno.Grau;
                j.Ensino = aluno.Ensino;
                resultado = true;
            }
            return resultado;
        }
        public Boolean Excluir(int matricula)
        {
            Boolean resultado = false;
            Aluno j = alunos.Find(x => x.Matricula == matricula);
            if (j != null)
            {
                resultado = alunos.Remove(j);
            }
            return resultado;
        }
        public List<Aluno> Localizar(String nome)
        {
            List<Aluno> lj = alunos.FindAll(x => x.Nome.Contains(nome.ToUpper()));
            return lj;
        }

        public List<Aluno> ListarPorGrau(TipoGrau grau)
        {
            List<Aluno> lj = alunos.FindAll(x => x.Grau.Equals(grau));
            return lj;
        }

        public List<Aluno> ListarPorEnsino(TipoEnsino ensino)
        {
            List<Aluno> lj = alunos.FindAll(x => x.Ensino.Equals(ensino));
            return lj;
        }

    }
}

