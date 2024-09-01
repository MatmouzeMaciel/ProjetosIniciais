namespace Classes.Herança
{
    public class Ponto
    {
        public int x, y;
        private int distancia;
        
        public Ponto(int x, int y)
        {
            //Quando a classe é criada os valores adicionados são direcionados aos x e y permitindo a utilização deles dentro dos métodos criados para este objeto
            this.x = x;
            this.y = y;
        }
        //Apenas aqueles referenciados/herdados deste void poderá receber seu método
        protected void CalcularDistancia()
        {
            //Faz alguma coisa...
            CalcularDistancia2();
        }

        //Apenas aqueles dentro da classe Ponto poderá interagir com este método
        private void CalcularDistancia2()
        {
            //Faz alguma coisa...
        }

        //um método virtual é feito de base para poder ser sobrescrito, "override" em outra classe utilizando seu método.
        public virtual void CalcularDistancia3()
        {
            //Faz alguma coisa...
        }
    }
}