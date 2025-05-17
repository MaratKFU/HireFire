using HireFire.Classes.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System;

namespace HireFire.UnitTests
{
    [TestClass]
    public class UserMessageValidationTests
    {
        private UserMessage _message;

        [TestInitialize]
        public void Setup()
        {
            _message = new UserMessage
            {
                Id = 1,
                MessageText = "Hello! This is a test message.",
                DispatchTime = DateTime.Now.AddHours(-1),
                Sender = "E"
            };
        }

        [TestMethod]
        [DataRow("", false, "Message text is required")]
        [DataRow("   ", false, "Message text is required")]
        [DataRow("Short", true, null)]
        [DataRow("<script>", false, "Invalid message content")]
        public void TestMessageTextValidation(string text, bool isValid, string error)
        {
            _message.MessageText = text;
            ValidateProperty(nameof(UserMessage.MessageText), isValid, error);
        }

        [TestMethod]
        [DataRow("1999-12-31", false)]
        [DataRow("2100-01-01", false)]
        [DataRow("2023-01-01", true)]
        public void TestDispatchTimeValidation(DateTime date, bool isValid)
        {
            _message.DispatchTime = date;
            ValidateProperty(nameof(UserMessage.DispatchTime), isValid);
        }

        [TestMethod]
        [DataRow("A", false, "must be 'E' or 'J'")]
        [DataRow("", false, "Sender identifier")]
        [DataRow("E", true, null)]
        [DataRow("J", true, null)]
        public void TestSenderValidation(string sender, bool isValid, string error)
        {
            _message.Sender = sender;
            ValidateProperty(nameof(UserMessage.Sender), isValid, error);
        }

        private void ValidateProperty(string propertyName, bool expectedValid, string expectedMessage = null)
        {
            var context = new ValidationContext(_message) { MemberName = propertyName };
            var results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateProperty(
                _message.GetType().GetProperty(propertyName).GetValue(_message),
                context,
                results
            );

            Assert.AreEqual(expectedValid, isValid);
            if (!expectedValid)
                Assert.IsTrue(results.Exists(r => r.ErrorMessage.Contains(expectedMessage)));
        }
    }
}