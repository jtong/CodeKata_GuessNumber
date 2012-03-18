using System.Collections.Generic;
using GuessNumber;
using NUnit.Framework;

namespace GuessNumberTest
{
    public class NumberGuessTest
    {                           
        [Test]
        public void should_return_0A0B_given_result_numbers_have_no_same_number_with_input()
        {
            var result = new List<string>{ "5", "6", "7", "8"};
            var input = new List<string>{ "1", "2", "3", "4"};

            string expectSuggest = "0A0B";
    

            string actualSuggest = NumberGuess.suggest(input, result);

            Assert.That(expectSuggest, Is.EqualTo(actualSuggest));
        }

        [Test]
        public void should_return_4A0B_given_result_numbers_are_exactly_same_with_input_numbers()
        {
            var result = new List<string> { "1", "2", "3", "4" };
            var input = new List<string>{ "1", "2", "3", "4"};

            string expectSuggest = "4A0B";

            string actualSuggest = NumberGuess.suggest(input, result);

            Assert.That(expectSuggest, Is.EqualTo(actualSuggest));
        }

        [Test]
        public void should_1A_0B_given_result_numbers_has_one_number_exsit_in_input_numbers_and_in_the_same_place()
        {
            var result = new List<string> { "1", "5", "6", "7" };
            var input = new List<string> { "1", "2", "3", "4" };

            string expectSuggest = "1A0B";
            
            string actualSuggest = NumberGuess.suggest(input, result);

            Assert.That(expectSuggest, Is.EqualTo(actualSuggest));
        }

        [Test]
        public void should_return_0A4B_result_numbers_has_same_number_in_input_numbers_but_not_any_in_same_palce()
        {

            var result = new List<string> { "4", "3", "2", "1" };
            var input = new List<string> { "1", "2", "3", "4" };

            string expectSuggest = "0A4B";

            string actualSuggest = NumberGuess.suggest(input, result);

            Assert.That(expectSuggest, Is.EqualTo(actualSuggest));
        }

        [Test]
        public void should_return_1A2B_result_numbers()
        {

            var result = new List<string> { "4", "3", "2", "1" };
            var input = new List<string> { "4", "2", "3", "5" };

            string expectSuggest = "1A2B";

            string actualSuggest = NumberGuess.suggest(input, result);

            Assert.That(expectSuggest, Is.EqualTo(actualSuggest));
        }

    }
}