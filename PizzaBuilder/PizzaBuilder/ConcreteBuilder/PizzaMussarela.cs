using PizzaBuilder.Builder;
using PizzaBuilder.Product;
using System.Collections.Generic;

namespace PizzaBuilder.ConcreteBuilder
{
    public sealed class PizzaMussarela : PizzaBuilder1
    {
        public override void PreparaMassa()
        {
            pizza.TipoMassa = TipoMassa.Normal;
            pizza.TipoBorda = TipoBorda.Recheada;
            pizza.Tamanho = Tamanho.Grande;
        }

        public override void IncluiIngredientes()
        {
            pizza.Ingredientes = new List<string> { "Mussarela",
                "Molho de tomate", "Orégano"};
        }
    }
}
