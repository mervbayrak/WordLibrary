using FluentValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WordLibrary.Business.Concrete;
using WordLibrary.DataAccess.Abstract;
using WordLibrary.Entities.Concrete;

namespace WordLibrary.Business.TestCoreMs
{
    [TestClass]
    public class WordManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Word_Validation_Check()
        {
            Mock<IWordDal> mock = new Mock<IWordDal>();
            Mock<IUserWordsDal> mock1 = new Mock<IUserWordsDal>();
            WordManager wordManager = new WordManager(mock.Object, mock1.Object);

            wordManager.SaveDb(new Word(), CreateReason.Create);
        }
    }
}
