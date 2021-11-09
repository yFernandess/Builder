using PizzaBuilder.Builder;
using PizzaBuilder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder.Director
{
    public class Pizzaria
    {
        private readonly PizzaBuilder1 builder;

        public Pizzaria(PizzaBuilder1 builder)
        {
            this.builder = builder;
        }

        //Construct
        public void MontaPizza()
        {
            builder.CriaPizza();
            builder.PreparaMassa();
            builder.IncluiIngredientes();
        }

        public Pizza GetPizza()
        {
            return builder.GetPizza();
        }
    }
}
