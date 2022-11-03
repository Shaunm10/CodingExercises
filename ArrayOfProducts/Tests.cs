namespace CodingExercises.ArrayOfProducts
{
    public class Tests
    {
        [Fact]
        public void TestA()
        {
            // arrange:
            int[] array = { 5, 1, 4, 2 };

            // 8 is equal to 1 x 4 x 2
            // 40 is equal to 5 x 4 x 2
            // 10 is equal to 5 x 1 x 2
            // 20 is equal to 5 x 1 x 4
            int[] expectedOutput = { 8, 40, 10, 20 };

            // act:
            var result = Exercise.ArrayOfProducts(array);

            // assert:
            result.Should().BeEquivalentTo(expectedOutput);
        }

        [Fact]
        public void TestB()
        {
            // arrange:
            int[] array = { 9, 3, 2, 1, 9, 5, 3, 2 };

            // 8 is equal to 1 x 4 x 2
            // 40 is equal to 5 x 4 x 2
            // 10 is equal to 5 x 1 x 2
            // 20 is equal to 5 x 1 x 4
            int[] expectedOutput = { 1620, 4860, 7290, 14580, 1620, 2916, 4860, 7290 };

            // act:
            var result = Exercise.ArrayOfProductsNonLinq(array);

            // assert:
            result.Should().BeEquivalentTo(expectedOutput);
        }
    }
}