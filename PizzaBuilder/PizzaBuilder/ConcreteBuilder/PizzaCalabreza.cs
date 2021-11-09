using PizzaBuilder.Builder;
using PizzaBuilder.Product;
using System.Collections.Generic;

namespace PizzaBuilder.ConcreteBuilder
{
    public sealed class PizzaCalabreza : PizzaBuilder1
    {
        public override void PreparaMassa()
        {
            pizza.TipoMassa = TipoMassa.Grossa;
            pizza.TipoBorda = TipoBorda.Normal;
            pizza.Tamanho = Tamanho.Grande;
        }

        public override void IncluiIngredientes()
        {
            pizza.Ingredientes = new List<string> { "Calabreza em fatias",
                "Molho de tomate" };
        }
    }
}
