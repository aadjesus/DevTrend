using BGMRodotec.Agencia.Modelo;
using System;

class Program
{
    static void Main(string[] args)
    {
        var agencia = new Agencia();
        var telefone = new Telefone();        

        #region agencia
        System.Console.WriteLine("Criar Agencia:");

        System.Console.Write("Numero da agencia:");
        agencia.Numero = Console.ReadKey();

        System.Console.Write("Digito da agencia:");
        agencia.Digito = Console.ReadKey();

        System.Console.Write("Telefone:");
        telefone.Numero = Console.ReadKey();

        agencia.Telefones = new System.Collections.Generic.List<Telefone>(new [] { telefone });


        System.Console.WriteLine("Salvando....");
        var retornoAgencia = new BGMRodotec.Agencia.RegraDeNegocio.AgenciaNegocio().ValidarNegocio(agencia);
        if (retornoAgencia.Sucesso)
            System.Console.WriteLine("Salvo com sucesso....");
        else
            System.Console.WriteLine("Erro ao salvar....");
        ///chamar metodo para salvar

        #endregion

        #region conta
        System.Console.WriteLine("-----------------------------------------------------------");
        System.Console.WriteLine("Criar Conta:");

        System.Console.Write("Numero da conta:");
        var numeroconta = Console.ReadKey();

        System.Console.Write("Tipo da conta:");
        var tipodaconta = Console.ReadKey();

        System.Console.WriteLine("Salvando....");
        var retornoConta = false;// Salvar(agencia.Numero);
        if (retornoConta)
            System.Console.WriteLine("Salvo com sucesso....");
        else
            System.Console.WriteLine("Erro ao salvar....");
        ///chamar metodo para salvar
        #endregion

        #region cliente
        System.Console.WriteLine("-----------------------------------------------------------");
        System.Console.WriteLine("Criar Cliente:");

        System.Console.Write("Nome do cliente:");
        var nomeCliente = Console.ReadKey();

        System.Console.Write("Data nascimento:");
        var dataNascimento = Convert.ToDateTime(Console.ReadLine());

        System.Console.Write("Telefone:");
        //var numero = Console.ReadKey();

        System.Console.WriteLine("Salvando....");
        var retornoCliente = false;// Salvar(agencia.Numero);
        if (retornoCliente)
            System.Console.WriteLine("Salvo com sucesso....");
        else
            System.Console.WriteLine("Erro ao salvar....");
        ///chamar metodo para salvar
        #endregion

        System.Console.ReadKey();
    }
}