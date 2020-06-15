namespace PrimeiroPOO
{
    public class Personagem
    {
        
        public string nome;
        
        public int idade;

        public string armadura;


        public float Atacar(float forca , float potencia)
        {
            return forca * potencia; 
        }

        public string Defender()
        {
            return "o personagem atacou!";
        }
        

    }
}