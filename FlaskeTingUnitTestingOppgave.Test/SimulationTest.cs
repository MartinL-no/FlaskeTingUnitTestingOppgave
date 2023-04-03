namespace FlaskeTingUnitTestingOppgave.Test
{
    public class SimulationTest
    {
        [Test]
        public void SimulationTestOne()
        {
            // arrange
            var simulation = new Simulation(1, 5, 7);

            // act
            var operationSet = simulation.Run();

            // assert
            var stringToCompare = 
                "1: Fylle flaske 1 fra springen\n" +
                "2: Tømme flaske 1 i flaske 2\n" +
                "3: Fylle flaske 1 fra springen\n" +
                "4: Fylle opp flaske 2 med flaske 1\n" +
                "5: Tømme flaske 2 (kaste vannet)\n" +
                "6: Tømme flaske 1 i flaske 2\n" +
                "7: Fylle flaske 1 fra springen\n" +
                "8: Fylle opp flaske 2 med flaske 1\n";

            Assert.That(operationSet.GetDescription(), Is.EqualTo(stringToCompare));
        }
        [Test]
        public void SimulationTestTwo()
        {
            // arrange
            var simulation = new Simulation(4, 3, 8);

            // act
            var operationSet = simulation.Run();

            // assert
            var stringToCompare =
                "1: Fylle flaske 1 fra springen\n" +
                "2: Tømme flaske 1 i flaske 2\n" +
                "3: Fylle flaske 1 fra springen\n" +
                "4: Tømme flaske 1 i flaske 2\n" +
                "5: Fylle flaske 1 fra springen\n" +
                "6: Fylle opp flaske 2 med flaske 1\n" +
                "7: Tømme flaske 2 (kaste vannet)\n" +
                "8: Tømme flaske 1 i flaske 2\n" +
                "9: Fylle flaske 1 fra springen\n";

            Assert.That(operationSet.GetDescription(), Is.EqualTo(stringToCompare));
        }
        [Test]
        public void SimulationTestThree()
        {
            // arrange
            var simulation = new Simulation(4, 3, 8);

            // act
            var operationSet = simulation.Run();

            // assert
            var stringToCompare =
                "1: Fylle flaske 1 fra springen\n" +
                "2: Tømme flaske 1 i flaske 2\n" +
                "3: Fylle flaske 1 fra springen\n" +
                "4: Fylle opp flaske 2 med flaske 1\n" +
                "5: Tømme flaske 2 (kaste vannet)\n" +
                "6: Tømme flaske 1 i flaske 2\n" +
                "7: Fylle flaske 1 fra springen";

            Assert.That(operationSet.GetDescription(), Is.EqualTo(stringToCompare));
        }
    }
}