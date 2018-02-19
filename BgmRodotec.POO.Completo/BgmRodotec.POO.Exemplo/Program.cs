using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgmRodotec.POO.Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IInterface
    {
        int Cod0 { get; set; }
    }

    public abstract class MyClass : IInterface
    {
        //virtual   	- Permite que um membro da classe a ser substituído em uma classe derivada.
        //override - Substitui um membro(substituível) virtual definido na classe base.
        //ND	- Impede que um membro que está sendo substituído em uma classe herdeira.
        //abstract - Requer que um membro da classe a ser substituído na classe derivada.
        //new Modifier
        public virtual int Cod1 { get; set; }
        public abstract int Cod2 { get; set; }

        public  int Cod3 { get; set; }
        public int Cod0 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public abstract int Teste()
        //{
        //    return 1;
        //}
    }

    public class MyClass1 : MyClass
    {
        public override int Cod1
        {
            get => base.Cod1; set => base.Cod1 = value;
        }

        public override int Cod2
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public new int Cod3 { get; set; }

    }


}
