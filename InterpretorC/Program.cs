using System;
using InterpretorC.Utils;
using InterpretorC.Statements;
using InterpretorC.FileWork.FileHandlers;
using InterpretorC.FileWork;
using InterpretorC.Expressions;
using InterpretorC.View.Menu;
using InterpretorC.Repository;
namespace InterpretorC
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IMyStack<IStatement> stack1 = new MyStack<IStatement>();
            IMyDict<string, int> dict1 = new MyDict<string, int>();
            IMyList<int> output1 = new MyList<int>();
            FileTable<int, FileData> fileTable1 = new FileTable<int, FileData>();

            IStatement i1 = new OpenRFile("var_f", "../../../intrare.txt");
            IStatement i2 = new ReadFile(new VarExpression("var_f"), "var_c");
            IStatement i3 = new ReadFile(new VarExpression("var_f"), "var_c");
            IStatement i4 = new PrintStatement(new VarExpression("var_c"));
            IStatement i5 = new CompStatement(i3, i4);
            IStatement i6 = new PrintStatement(new ConstExpression(0));

            IStatement i7 = new IfStatement(new VarExpression("var_c"), i5, i6);
            IStatement i8 = new CloseRFile(new VarExpression("var_f"));

            IStatement i9 = new CompStatement(i1, i2);
            IStatement i10 = new CompStatement(i7, i8);
            IStatement i11 = new CompStatement(i9, i10);

            stack1.Push(i11);

            PrgState state1 = new PrgState(dict1, stack1, output1, fileTable1);
            IRepository repo1 = new Repository.Repository();
            repo1.AddProg(state1);
            Controller.Controller ctrl1 = new Controller.Controller(repo1);

            /*Exemplu 111111111111111111111111111111111111111111111*/


            IMyStack<IStatement> stack2 = new MyStack<IStatement>();
            IMyDict<string, int> dict2 = new MyDict<string, int>();
            IMyList<int> output2 = new MyList<int>();
            FileTable<int, FileData> fileTable2 = new FileTable<int, FileData>();

            IStatement j1 = new OpenRFile("a", "../../../intrare.txt");
            IStatement j2 = new CompStatement(new ReadFile(new VarExpression("a"), "p"), new PrintStatement(new VarExpression("p")));
            IStatement j3 = new IfStatement(new VarExpression("p"), new CompStatement(new ReadFile(new VarExpression("a"), "q"),
            new PrintStatement(new VarExpression("q"))), new PrintStatement(new ConstExpression(0)));

            IStatement j4 = new CloseRFile(new VarExpression("a"));
            IStatement j5 = new CompStatement(j2, new CompStatement(j3, j4));
            IStatement j6 = new CompStatement(j1, j5);

            stack2.Push(j6);

            PrgState state2 = new PrgState(dict2, stack2, output2, fileTable2);
            IRepository repo2 = new Repository.Repository();
            repo2.AddProg(state2);
            Controller.Controller ctrl2 = new Controller.Controller(repo2);
            /*Exemplu 222222222222222222222222222222222222222222222*/
            TextMenu menu = new TextMenu();
            menu.AddCommand(new ExitCommand("0", "exit \n"));
            menu.AddCommand(new RunCommand("1", "\t"+ i11.ToString() + "\n", ctrl1));
            menu.AddCommand(new RunCommand("2", "\t"+ j6.ToString() + "\n", ctrl2));
            menu.Show();

        }
    }
}

