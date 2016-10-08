using NUnit.Framework;

namespace Permutation_Validation
{
    [TestFixture]
    class PermutationValidatorTest
    {
        [Test]
        public void CatActTest()
        {
            string wordOne = "cat";
            string wordTwo = "act";
            bool isPermuation = PermutationValidator.IsValidPermutation(wordOne, wordTwo);
            Assert.IsTrue(isPermuation);
        }

        [Test]
        public void CatCatTest()
        {
            string wordOne = "cat";
            string wordTwo = "cat";
            bool isPermuation = PermutationValidator.IsValidPermutation(wordOne, wordTwo);
            Assert.IsTrue(isPermuation);
        }

        [Test]
        public void CatHatTest()
        {
            string wordOne = "cat";
            string wordTwo = "hat";
            bool isPermuation = PermutationValidator.IsValidPermutation(wordOne, wordTwo);
            Assert.IsFalse(isPermuation);
        }

        [Test]
        public void CatEmptyStringTest()
        {
            string wordOne = "cat";
            string wordTwo = "";
            bool isPermuation = PermutationValidator.IsValidPermutation(wordOne, wordTwo);
            Assert.IsFalse(isPermuation);
        }

        [Test]
        public void CatNullTest()
        {
            string wordOne = "cat";
            string wordTwo = null;
            bool isPermuation = PermutationValidator.IsValidPermutation(wordOne, wordTwo);
            Assert.IsFalse(isPermuation);
        }

        // Code won't compile if one of the arguments is not initialized.  A ReSharper protection?

        //[Test]
        //public void CatNotInitializedTest()
        //{
        //    string wordOne = "cat";
        //    string wordTwo;
        //    bool isPermuation = PermutationValidator.IsValidPermutation(wordOne, wordTwo);
        //    Assert.IsFalse(isPermuation);
        //}

        [Test]
        public void EmptyStringNullTest()
        {
            string wordOne = "";
            string wordTwo = null;
            bool isPermuation = PermutationValidator.IsValidPermutation(wordOne, wordTwo);
            Assert.IsTrue(isPermuation);
        }

        // Code won't compile if one of the arguments is not initialized.  A ReSharper protection?

        //[Test]
        //public void EmptyStringNotInitializedTest()
        //{
        //    string wordOne = "";
        //    string wordTwo;
        //    bool isPermuation = PermutationValidator.IsValidPermutation(wordOne, wordTwo);
        //    Assert.IsTrue(isPermuation);
        //}
    }
}
