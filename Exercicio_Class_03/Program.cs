using Exercicio_Class_03;

class Program
{
    static int Opc()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=== Controle de alunos ===");
        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("===Selecione uma opcao:===");
        Console.ResetColor();
        Console.WriteLine("[1] Cadastrar um aluno");
        Console.WriteLine("[2] Excluir um aluno");
        Console.WriteLine("[3] Alterar um aluno");
        Console.WriteLine("[4] Localizar um aluno por nome");
        Console.WriteLine("[5] Listar os alunos por Grau");
        Console.WriteLine("[6] Listar os alunos por Ensino");
        Console.WriteLine("[7] Listar todos os alunos");
        Console.WriteLine("[9] Sair");
        Console.Write("Opcao: ");
        int op = Convert.ToInt32(Console.ReadLine());
        return op;
    }
    static void Main(string[] args)
    {
        ListaDeAlunos listadealunos = new ListaDeAlunos();
        List<Aluno> lista = new List<Aluno>(); //Utilizado nos cases
        String nomealuno = "";
        int matricula = 0;

        //Alunos para teste do sistema
        Aluno aluno = new Aluno(492812, "Rafael", 3241232, TipoGrau.Infantil, TipoEnsino.Basica);
        listadealunos.Inserir(aluno);
        aluno = new Aluno(295821, "Cristiano", 3214232, TipoGrau.Fundamental, TipoEnsino.Basica);
        listadealunos.Inserir(aluno);
        aluno = new Aluno(512284, "Douglas", 3451222, TipoGrau.Medio, TipoEnsino.Basica);
        listadealunos.Inserir(aluno);
        aluno = new Aluno(258122, "Carlos Roberto", 32256432, TipoGrau.Doutorado, TipoEnsino.Outro);
        listadealunos.Inserir(aluno);
        aluno = new Aluno(912852, "Gabriela Ribeiro", 327572124, TipoGrau.Mestrado, TipoEnsino.Outro);
        listadealunos.Inserir(aluno);
        aluno = new Aluno(867621, "Kamila Santana", 32256432, TipoGrau.Medio, TipoEnsino.Outro);
        listadealunos.Inserir(aluno);
        aluno = new Aluno(652212, "Icaro Humberto", 51242232, TipoGrau.Pos, TipoEnsino.Outro);
        listadealunos.Inserir(aluno);
        aluno = new Aluno(151252, "Weyler Jorge", 82737456, TipoGrau.Superior, TipoEnsino.Outro);
        listadealunos.Inserir(aluno);
        aluno = new Aluno(625541, "Paulo Gabriel", 45512562, TipoGrau.Medio, TipoEnsino.Basica);
        listadealunos.Inserir(aluno);
        aluno = new Aluno(734122, "Viviane Alcantra", 55126721, TipoGrau.Pos, TipoEnsino.Outro);
        listadealunos.Inserir(aluno);
        aluno = new Aluno(152991, "Gustavo Diniz", 74231224, TipoGrau.Doutorado, TipoEnsino.Outro);
        listadealunos.Inserir(aluno);

        int op = 0; //valor da operação que o usuário era realizar
        while (op != 9)
        {
            op = Opc();
            Console.Clear();
            switch (op)
            {
                case 1: //inserir
                    Console.WriteLine("Inserir um novo aluno");
                    aluno = new Aluno();
                    Console.Write("Matricula: ");
                    aluno.Matricula = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nome: ");
                    aluno.Nome = Console.ReadLine();
                    Console.Write("Telefone: ");
                    aluno.Telefone = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Informe o Grau Infantil [0], Fundamental [1], Medio [2], Superior [3], Pos [4], Mestrado [5]: ");
                    aluno.Grau = (TipoGrau)Convert.ToInt32(Console.ReadLine());
                    Console.Write("Informe o Ensino Basico [0], Superior [1], Outro [2]: ");
                    aluno.Ensino = (TipoEnsino)Convert.ToInt32(Console.ReadLine());
                    if (listadealunos.Inserir(aluno))
                    {
                        Console.WriteLine("Aluno inserido!!!!");
                    }
                    else
                    {
                        Console.WriteLine("Aluno nao inserido!!!!");
                    }
                    Console.ReadKey();
                    break;
                case 2: //excluir
                    Console.WriteLine("Excluir Aluno");
                    Console.Write("Informe a matricula do Aluno: ");
                    matricula = Convert.ToInt32(Console.ReadLine());
                    if (listadealunos.Excluir(matricula))
                    {
                        Console.WriteLine("Aluno excluido!!!!");
                    }
                    else
                    {
                        Console.WriteLine("Aluno nao excluido!!!!");
                    }
                    Console.ReadKey();
                    break;
                case 3: //Alterar
                    Console.WriteLine("Alterar um aluno");
                    aluno = new Aluno();
                    Console.Write("Matricula: ");
                    aluno.Matricula = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nome: ");
                    aluno.Nome = Console.ReadLine();
                    Console.Write("Telefone: ");
                    aluno.Telefone = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Informe o Grau Infantil [0], Fundamental [1], Medio [2], Superior [3], Pos [4], Mestrado [5]: ");
                    aluno.Grau = (TipoGrau)Convert.ToInt32(Console.ReadLine());
                    Console.Write("Informe o Ensino Basico [0], Superior [1], Outro [2]: ");
                    aluno.Ensino = (TipoEnsino)Convert.ToInt32(Console.ReadLine());
                    if (listadealunos.Inserir(aluno))
                    {
                        Console.WriteLine("Aluno alterado!!!!");
                    }
                    else
                    {
                        Console.WriteLine("Aluno nao alterado!!!!");
                    }
                    Console.ReadKey();
                    break;
                case 4: //Localizar por nome
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Localizar alunos: ");
                    Console.ResetColor();
                    Console.Write("Informe o nome do aluno: ");
                    nomealuno = Console.ReadLine();
                    lista = listadealunos.Localizar(nomealuno);

                    foreach (var j in lista)
                    {
                        Console.Write("Matricula: " + j.Matricula);
                        Console.Write(" - Nome: " + j.Nome);
                        Console.Write(" - Telefone: " + j.Telefone);
                        Console.Write(" - Grau: " + j.Grau);
                        Console.WriteLine(" - Ensino: " + j.Ensino);
                    }
                    Console.WriteLine("Aperte qualquer tecla para continuar");
                    Console.ReadKey();
                    break;
                case 5: //Listar Grau
                    Console.WriteLine("Listar todos os alunos por grau");
                    Console.Write("Informe o Grau: Infantil [0], Fundamental [1], Medio [2], Superior [3], Pos [4], Mestrado [5]: ");
                    TipoGrau grau = (TipoGrau)Convert.ToInt32(Console.ReadLine());
                    lista = listadealunos.ListarPorGrau(grau);

                    foreach (var j in lista)
                    {
                        Console.Write("Matricula: " + j.Matricula);
                        Console.Write(" - Nome: " + j.Nome);
                        Console.Write(" - Telefone: " + j.Telefone);
                        Console.Write(" - Grau: " + j.Grau);
                        Console.WriteLine(" - Ensino: " + j.Ensino);
                    }
                    Console.WriteLine("Aperte qualquer tecla para continuar");
                    Console.ReadKey();
                    break;
                case 6: //Listar Ensino
                    Console.WriteLine("Listar todos os alunos por Tipo de Ensino");
                    Console.Write("Informe o Ensino: Basico [0], Superior [1], Outro [2]: ");
                    TipoEnsino ensino = (TipoEnsino)Convert.ToInt32(Console.ReadLine());
                    lista = listadealunos.ListarPorEnsino(ensino);

                    foreach (var j in lista)
                    {
                        Console.Write("Matricula: " + j.Matricula);
                        Console.Write(" - Nome: " + j.Nome);
                        Console.Write(" - Telefone: " + j.Telefone);
                        Console.Write(" - Grau: " + j.Grau);
                        Console.WriteLine(" - Ensino: " + j.Ensino);
                    }
                    Console.WriteLine("Aperte qualquer tecla para continuar");
                    Console.ReadKey();
                    break;
                case 7: //Listar todos os alunos
                    Console.WriteLine("Listar todos os alunos");
                    foreach (var j in listadealunos.Alunos)
                    {
                        Console.Write("Matricula: " + j.Matricula);
                        Console.Write(" - Nome: " + j.Nome);
                        Console.Write(" - Telefone: " + j.Telefone);
                        Console.Write(" - Grau: " + j.Grau);
                        Console.WriteLine(" - Ensino: " + j.Ensino);
                    }
                    Console.WriteLine("Aperte qualquer tecla para continuar");
                    Console.ReadKey();
                    break;
            }
        }
    }
}