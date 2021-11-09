using PizzaBuilder.Product;

namespace PizzaBuilder.Builder
{
    public abstract class PizzaBuilder1
    {
        protected Pizza pizza;

        public void CriaPizza()
        {
            pizza = new Pizza();
        }

        public Pizza GetPizza()
        {
            return pizza;
        }

        //Aqui se houvesse um objeto mais complexo haveriam mais métodos a serem implementados
        public abstract void PreparaMassa();
        public abstract void IncluiIngredientes();
    }
}
