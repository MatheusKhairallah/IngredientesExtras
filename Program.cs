using System;
using IngredientesExtras.db;
using System.Linq;

namespace IngredientesExtras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista com todos os ingredientes do tipo 'Extra' da Hamburgueria:");

            using (var db= new hamburgueriaContext())
            {
                var ordem= db.Ingrediente.OrderBy(i=> i.Nome).Where(i=> i.TipoIngredienteId==3);
                foreach (var ingre in ordem)
                {
                   Console.WriteLine($"{ingre.Nome}");
                }
            }
        }
    }
}
