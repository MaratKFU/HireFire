using HireFire.Classes.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;

namespace HireFire.UnitTests
{
    [TestClass]
    public class UserValidationTests
    {
        private TestUser _user;

        [TestInitialize]
        public void Setup()
        {
            _user = new TestUser
            {
                Id = 1,
                PhotoData = new byte[100],
                Name = "Иван",
                Surname = "Петров",
                Lastname = "Сидорович",
                City = "Москва",
                BirthDate = new DateTime(1990, 1, 1),
                Gender = "Male",
                Email = "test@example.com",
                Login = "user123",
                PasswordHash = "hash123",
                DialogsIds = new List<int> { 1, 2, 3 }
            };
        }

        [TestMethod]
        [DataRow(null, false, "Name is required")]
        [DataRow("A", false, "Name must be 2-50 characters")]
        [DataRow("John1", false, "Invalid characters")]
        [DataRow("Anna-Maria", true, null)]
        public void TestNameValidation(string value, bool isValid, string errorMessage)
        {
            _user.Name = value;
            ValidateProperty(nameof(User.Name), isValid, errorMessage);
        }

        [TestMethod]
        [DataRow("1990-01-01", true)]
        [DataRow("1899-12-31", false)]
        [DataRow("2101-01-01", false)]
        public void TestBirthDateValidation(DateTime date, bool isValid)
        {
            _user.BirthDate = date;
            ValidateProperty(nameof(User.BirthDate), isValid);
        }

        [TestMethod]
        [DataRow("invalid.email", false)]
        [DataRow("valid@example.com", true)]
        public void TestEmailValidation(string email, bool isValid)
        {
            _user.Email = email;
            ValidateProperty(nameof(User.Email), isValid);
        }

        // Аналогичные тесты для других свойств...

        [TestMethod]
        public void TestDialogsIdsValidation()
        {
            _user.DialogsIds = new List<int> { -1, 0 };
            var results = new List<ValidationResult>();
            Validator.TryValidateObject(_user, new ValidationContext(_user), results, true);
            Assert.IsTrue(results.Any(r => r.ErrorMessage.Contains("Invalid dialogs list")));
        }

        [TestMethod]
        public void ToString_ShouldFormatCorrectly()
        {
            _user.Surname = "Иванов";
            _user.Name = "Петр";
            _user.Lastname = "Сергеевич";
            Assert.AreEqual("Иванов П.С.", _user.ToString());
        }

        private void ValidateProperty(string propertyName, bool expectedValid, string expectedMessage = null)
        {
            var context = new ValidationContext(_user) { MemberName = propertyName };
            var results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateProperty(
                _user.GetType().GetProperty(propertyName).GetValue(_user),
                context,
                results
            );

            Assert.AreEqual(expectedValid, isValid);
            if (!expectedValid)
                Assert.IsTrue(results.Any(r => r.ErrorMessage.Contains(expectedMessage)));
        }
    }

    public class TestUser : User { }
}