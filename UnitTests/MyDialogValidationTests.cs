using HireFire.Classes.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;

namespace HireFire.UnitTests
{
    [TestClass]
    public class MyDialogValidationTests
    {
        private MyDialog _dialog;

        [TestInitialize]
        public void Setup()
        {
            _dialog = new MyDialog
            {
                Id = 1,
                JobSeekerId = 100,
                EmployerId = 200,
                MessagesIds = new List<int> { 1, 2, 3 },
                JobSeekerInit = "user_100",
                EmployerInit = "empl_200"
            };
        }

        [TestMethod]
        [DataRow(0, false, "Invalid dialog ID")]
        [DataRow(-5, false, "Invalid dialog ID")]
        [DataRow(1, true, null)]
        public void TestIdValidation(int value, bool isValid, string error)
        {
            _dialog.Id = value;
            ValidateProperty(nameof(MyDialog.Id), isValid, error);
        }

        [TestMethod]
        [DataRow(new[] { -1, 2 }, false, "Invalid message IDs")]
        [DataRow(new[] { 0 }, false, "Invalid message IDs")]
        [DataRow(new int[] { }, true, null)]
        public void TestMessagesIdsValidation(int[] ids, bool isValid, string error)
        {
            _dialog.MessagesIds = new List<int>(ids);
            ValidateProperty(nameof(MyDialog.MessagesIds), isValid, error);
        }

        [TestMethod]
        [DataRow("user@123", false, "Invalid JobSeeker init")]
        [DataRow("user-123", true, null)]
        [DataRow("a", true, null)]
        public void TestJobSeekerInitValidation(string value, bool isValid, string error)
        {
            _dialog.JobSeekerInit = value;
            ValidateProperty(nameof(MyDialog.JobSeekerInit), isValid, error);
        }

        [TestMethod]
        [DataRow("empl:200", false, "Invalid Employer init")]
        [DataRow("empl_200", true, null)]
        public void TestEmployerInitValidation(string value, bool isValid, string error)
        {
            _dialog.EmployerInit = value;
            ValidateProperty(nameof(MyDialog.EmployerInit), isValid, error);
        }

        private void ValidateProperty(string propertyName, bool expectedValid, string expectedMessage = null)
        {
            var context = new ValidationContext(_dialog) { MemberName = propertyName };
            var results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateProperty(
                _dialog.GetType().GetProperty(propertyName).GetValue(_dialog),
                context,
                results
            );

            Assert.AreEqual(expectedValid, isValid);
            if (!expectedValid)
                Assert.IsTrue(results.Exists(r => r.ErrorMessage.Contains(expectedMessage)));
        }
    }
}