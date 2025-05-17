using HireFire.Classes.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;

namespace HireFire.Tests
{
    [TestClass]
    public class VacancyValidationTests
    {
        private Vacancy _vacancy;

        [TestInitialize]
        public void Setup()
        {
            _vacancy = new Vacancy
            {
                Id = 1,
                EmployerId = 100,
                Experience = 3,
                Profession = "C# Developer",
                Salary = 2500,
                City = "London",
                CompanyName = "Tech Corp",
                Description = "Mid-level position"
            };
        }

        [TestMethod]
        [DataRow(0, false, "Invalid Employer ID")]
        [DataRow(-5, false, "Invalid Employer ID")]
        [DataRow(1, true, null)]
        public void TestEmployerIdValidation(int value, bool isValid, string error)
        {
            _vacancy.EmployerId = value;
            ValidateProperty(nameof(Vacancy.EmployerId), isValid, error);
        }

        [TestMethod]
        [DataRow("Dev", false, "Profession must be 3-100")]
        [DataRow("C++/Python Developer", true, null)]
        [DataRow("Java@Developer", false, "Invalid profession format")]
        public void TestProfessionValidation(string value, bool isValid, string error)
        {
            _vacancy.Profession = value;
            ValidateProperty(nameof(Vacancy.Profession), isValid, error);
        }

        [TestMethod]
        [DataRow(-1, false, "Experience must be 0-50")]
        [DataRow(51, false, "Experience must be 0-50")]
        [DataRow(25, true, null)]
        public void TestExperienceValidation(int value, bool isValid, string error)
        {
            _vacancy.Experience = value;
            ValidateProperty(nameof(Vacancy.Experience), isValid, error);
        }

        [TestMethod]
        [DataRow("M0scow", false, "Invalid city name")]
        [DataRow("New-York", true, null)]
        public void TestCityValidation(string value, bool isValid, string error)
        {
            _vacancy.City = value;
            ValidateProperty(nameof(Vacancy.City), isValid, error);
        }

        [TestMethod]
        [DataRow("", false, "Company name is required")]
        [DataRow("A&B Technologies", true, null)]
        public void TestCompanyNameValidation(string value, bool isValid, string error)
        {
            _vacancy.CompanyName = value;
            ValidateProperty(nameof(Vacancy.CompanyName), isValid, error);
        }

        private void ValidateProperty(string propertyName, bool expectedValid, string expectedMessage = null)
        {
            var context = new ValidationContext(_vacancy) { MemberName = propertyName };
            var results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateProperty(
                _vacancy.GetType().GetProperty(propertyName).GetValue(_vacancy),
                context,
                results
            );

            Assert.AreEqual(expectedValid, isValid);
            if (!expectedValid)
                Assert.IsTrue(results.Exists(r => r.ErrorMessage.Contains(expectedMessage)));
        }
    }
}