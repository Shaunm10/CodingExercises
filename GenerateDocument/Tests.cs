namespace CodingExercises.GenerateDocument
{
    public class Tests
    {
        public void TestA()
        {
            // arrange:
            var characters = "Bste!hetsi ogEAxpelrt x ";
            var document = "AlgoExpert is the Best!";
            var expectedOutput = true;

            // act:
            var result = Exercise.GenerateDocument(characters, document);

            // assert:
            result.Should().Be(expectedOutput);
        }
    }
}