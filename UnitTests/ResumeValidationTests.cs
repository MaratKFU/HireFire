using HireFire.Classes.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;

namespace HireFire.UnitTests
{
    [TestClass]
    public class ResumeValidationTests
    {
        private Resume _resume;

        [TestInitialize]
        public void Setup()
        {
            _resume = new Resume
            {
                Id = 1,
                JobSeekerId = 100,
                Profession = "Software Developer",
                Education = "Computer Science",
                Experience = 5,
                SoftSkills = "Teamwork, Communication",
                City = "New York",
                Description = "Experienced developer",
                Salary = 5000
            };
        }

        [TestMethod]
        [DataRow(0, false, "Invalid JobSeeker ID")]
        [DataRow(-5, false, "Invalid JobSeeker ID")]
        [DataRow(1, true, null)]
        public void TestJobSeekerIdValidation(int value, bool isValid, string error)
        {
            _resume.JobSeekerId = value;
            ValidateProperty(nameof(Resume.JobSeekerId), isValid, error);
        }

        [TestMethod]
        [DataRow("Dev", false, "Profession must be 3-100 characters")]
        [DataRow("A", false, "Profession must be 3-100 characters")]
        [DataRow("C#/ASP.NET Developer", true, null)]
        [DataRow("Python3 Developer", false, "Invalid profession format")]
        public void TestProfessionValidation(string value, bool isValid, string error)
        {
            _resume.Profession = value;
            ValidateProperty(nameof(Resume.Profession), isValid, error);
        }

        [TestMethod]
        [DataRow(-1, false, "Experience must be 0-70")]
        [DataRow(71, false, "Experience must be 0-70")]
        [DataRow(30, true, null)]
        public void TestExperienceValidation(int value, bool isValid, string error)
        {
            _resume.Experience = value;
            ValidateProperty(nameof(Resume.Experience), isValid, error);
        }

        [TestMethod]
        [DataRow("", false, "City is required")]
        [DataRow("Moscow1", false, "Invalid city name")]
        [DataRow("San Francisco", true, null)]
        public void TestCityValidation(string value, bool isValid, string error)
        {
            _resume.City = value;
            ValidateProperty(nameof(Resume.City), isValid, error);
        }

        [TestMethod]
        [DataRow(-100, false, "Salary must be 0-1,000,000")]
        [DataRow(1_000_001, false, "Salary must be 0-1,000,000")]
        [DataRow(2500.50, true, null)]
        public void TestSalaryValidation(decimal value, bool isValid, string error)
        {
            _resume.Salary = value;
            ValidateProperty(nameof(Resume.Salary), isValid, error);
        }

        private void ValidateProperty(string propertyName, bool expectedValid, string expectedMessage = null)
        {
            var context = new ValidationContext(_resume) { MemberName = propertyName };
            var results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateProperty(
                _resume.GetType().GetProperty(propertyName).GetValue(_resume),
                context,
                results
            );

            Assert.AreEqual(expectedValid, isValid);
            if (!expectedValid)
                Assert.IsTrue(results.Exists(r => r.ErrorMessage.Contains(expectedMessage)));
        }
    }
}