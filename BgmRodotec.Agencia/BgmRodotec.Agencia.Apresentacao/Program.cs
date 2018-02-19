using System;
using BgmRodotec.Agencia.Modelos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BgmRodotec.Agencia.AcessoDados;
using BgmRodotec.Agencia.Negocio;

namespace BgmRodotec.Agencia.Apresentacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region LSP-exemplo1
            //var carro = new Camaro();
            //System.Console.ReadLine();
            //#endregion

            //#region LSP-exemplo1-Solucao
            //var camaro = new Camaro();
            //System.Console.ReadLine();
            //var fusca = new Camaro();
            //#endregion

            //#region LSP-exemplo2
            //Agencia.Negocio.LSP.Ex2.Cliente clienteFiel = new Agencia.Negocio.LSP.Ex2.ClienteFiel();
            //clienteFiel.TipoCliente = TipoCliente.Gold;
            //clienteFiel.DataCadastro = new DateTime(2008, 12, 1);
            //clienteFiel.Nome = "Diego";
            //var valorDesconto = clienteFiel.CalcularDesconto(100, clienteFiel.TipoCliente);

            //Console.WriteLine("O cliente {0} pagará o valor de R$ {1} - {2}", clienteFiel.Nome,
            //    valorDesconto, clienteFiel.ClienteEspecial() ? "Cliente Especial" : "Cliente Normal");
            //Console.ReadKey();


            //Agencia.Negocio.LSP.Ex2.Cliente possivelCliente = new Agencia.Negocio.LSP.Ex2.PossivelCliente();
            //possivelCliente.TipoCliente = TipoCliente.Gold;
            //possivelCliente.DataCadastro = new DateTime(2008, 12, 1); //PossivelCliente com data de cadastro?
            //possivelCliente.Nome = "Diego";
            //var valorDescontoP = possivelCliente.CalcularDesconto(100, possivelCliente.TipoCliente);

            //Console.WriteLine("O cliente {0} pagará o valor de R$ {1} - {2}", possivelCliente.Nome,
            //    valorDesconto, possivelCliente.ClienteEspecial() ? "Cliente Especial" : "Cliente Normal");

            //Console.ReadKey();
            //#endregion

            //#region LSP-exemplo2-Solucao
            //Agencia.Negocio.LSP.Ex2.ClienteFielLSP clienteFielLSP = new Agencia.Negocio.LSP.Ex2.ClienteFielLSP();
            //clienteFielLSP.TipoCliente = TipoCliente.Gold;
            //clienteFielLSP.DataCadastro = new DateTime(2008, 12, 1);
            //clienteFielLSP.Nome = "Diego";
            //var valorDesconto = clienteFielLSP.CalcularDesconto(100, clienteFielLSP.TipoCliente);

            //Console.WriteLine("O cliente {0} pagará o valor de R$ {1} - {2}", clienteFielLSP.Nome,
            //    valorDesconto, clienteFielLSP.ClienteEspecial() ? "Cliente Especial" : "Cliente Normal");
            //Console.ReadKey();


            //Agencia.Negocio.LSP.Ex2.PossivelClienteLPS possivelClienteLSP = new Agencia.Negocio.LSP.Ex2.PossivelClienteLPS();
            //possivelClienteLSP.TipoCliente = TipoCliente.Gold;
            ////possivelClienteLSP.DataCadastro = new DateTime(2008, 12, 1);
            //possivelClienteLSP.Nome = "Diego";
            //var valorDescontoP = possivelClienteLSP.CalcularDesconto(100, possivelClienteLSP.TipoCliente);

            //Console.WriteLine("O cliente {0} pagará o valor de R$ {1} - {2}", possivelClienteLSP.Nome,
            //    valorDesconto, "Cliente Normal");

            //Console.ReadKey();
            //#endregion

        }

    }

}
