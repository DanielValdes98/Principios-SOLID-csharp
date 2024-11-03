namespace InterfaceSegregation
{
    public class Arquitect : IActivities
    {
        public Arquitect()
        {
        }

        public void Plan() 
        {
            Console.WriteLine("I'm planning the project");
        }

        public void Comunicate() 
        {
            Console.WriteLine("I'm talking to the client");
        }

        public void Design() 
        {
            Console.WriteLine("I'm designing the project");
        }

        public void Develop() 
        {
            throw new ArgumentException();
        }

        public void Test() 
        {
            throw new ArgumentException();
        }

        public void Deploy() 
        {
            throw new ArgumentException();
        }
    }
}