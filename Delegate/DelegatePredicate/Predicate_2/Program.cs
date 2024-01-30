using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_2
{
    class Program
    {
        static List<Inventario> listaInventario;

        static void Main(string[] args)
        {
            listaInventario = CriaListaInventario();
            LocalizaInventario(5);
        }

        //public static Inventario LocalizaInventario(int inventarioId)
        //{
        //    foreach (Inventario item in listaInventario)
        //    {
        //        if (item.Id == inventarioId)
        //            return item;
        //    }
        //    return null;
        //}


        //public static Inventario LocalizaInventario(int inventarioId)
        //{
        //    Predicate<Inventario> pred = delegate(Inventario item)
        //    {
        //        return item.Id == inventarioId;
        //    };
        //    return listaInventario.Find(pred);
        //}



        public static Inventario LocalizaInventario(int inventarioId)
        {
            return listaInventario.Find(item => item.Id == inventarioId);
        }



        public class Inventario
        {
            public int Id { get; set; }
            public int Estoque { get; set; }
            public double Preco { get; set; }
        }

        public static List<Inventario> CriaListaInventario()
        {
            List<Inventario> listaInventario = new List<Inventario>();
            listaInventario.Add(new Inventario { Id = 1, Estoque = 5, Preco = 1.99 });
            listaInventario.Add(new Inventario { Id = 2, Estoque = 5, Preco = 2.09 });
            listaInventario.Add(new Inventario { Id = 3, Estoque = 5, Preco = 0.75 });
            listaInventario.Add(new Inventario { Id = 4, Estoque = 5, Preco = 4.25 });
            listaInventario.Add(new Inventario { Id = 5, Estoque = 5, Preco = 5.60 });
            listaInventario.Add(new Inventario { Id = 6, Estoque = 5, Preco = 2.15 });
            return listaInventario;
        }
    }
}
