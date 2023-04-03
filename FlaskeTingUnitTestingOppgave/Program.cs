namespace FlaskeTingUnitTestingOppgave
{
    class Program
    {
        static void Main(string[] args)
        {
            //var simulation = new Simulation(1, 5, 7);
            //var simulation = new Simulation(4, 3, 8);
            var simulation = new Simulation(5, 4, 7);
            var operationSet = simulation.Run();
            Console.WriteLine(operationSet.GetDescription());
        }
    }
}