using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StringLib;

namespace StringLibTest
{
    [TestClass]
    public class StringClassTests
    {
        /// <summary>
        /// Проверка поля почты на пустую строку
        /// </summary>
        [TestMethod]
        public void IsEmail_Empty_falseReturned()
        {
            //Arrange
            string textString = "";
            //Act
            StringClass obj = new StringClass();
            bool result = obj.IsEmail(textString);
            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Проверка поля почты на некорректную строку
        /// </summary>
        [TestMethod]
        public void IsEmail_UnCorrectString_falseReturned()
        {
            //Arrange
            string textString = "shproti2005@com";
            //Act
            StringClass obj = new StringClass();
            bool result = obj.IsEmail(textString);
            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Проверка поля почты на некорректную строку
        /// </summary>
        [TestMethod]
        public void IsEmail_UnCorrectString1_falseReturned()
        {
            //Arrange
            string textString = "shproti2005.com";
            //Act
            StringClass obj = new StringClass();
            bool result = obj.IsEmail(textString);
            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Проверка поля почты на корректную строку
        /// </summary>
        [TestMethod]
        public void IsEmail_CorrectString1_trueReturned()
        {
            //Arrange
            string textString = "shproti2005@gmail.com";
            //Act
            StringClass obj = new StringClass();
            bool result = obj.IsEmail(textString);
            //Assert
            Assert.IsTrue(result);
        }



        /// <summary>
        /// Проверка поля телефона на пустую строку
        /// </summary>
        [TestMethod]
        public void IsPhoneNumber_Empty_falseReturned()
        {
            //Arrange
            string textString = "";
            //Act
            StringClass obj = new StringClass();
            bool result = obj.IsPhoneNumber(textString);
            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Проверка поля телефона на некорректный набор
        /// </summary>
        [TestMethod]
        public void IsPhoneNumber_UnCorrectString_falseReturned()
        {
            //Arrange
            string textString = "+7123";
            //Act
            StringClass obj = new StringClass();
            bool result = obj.IsPhoneNumber(textString);
            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Проверка поля телефона на некорректный набор
        /// </summary>
        [TestMethod]
        public void IsPhoneNumber_UnCorrectString1_falseReturned()
        {
            //Arrange
            string textString = "+31234512345";
            //Act
            StringClass obj = new StringClass();
            bool result = obj.IsPhoneNumber(textString);
            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Проверка поля телефона на некорректный набор
        /// </summary>
        [TestMethod]
        public void IsPhoneNumber_UnCorrectString2_falseReturned()
        {
            //Arrange
            string textString = "+7abcde12345";
            //Act
            StringClass obj = new StringClass();
            bool result = obj.IsPhoneNumber(textString);
            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Проверка поля телефона на корректный набор
        /// </summary>
        [TestMethod]
        public void IsPhoneNumber_CorrectString_trueReturned()
        {
            //Arrange
            string textString = "+79555555555";
            //Act
            StringClass obj = new StringClass();
            bool result = obj.IsPhoneNumber(textString);
            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Проверка поля телефона на корректный набор
        /// </summary>
        [TestMethod]
        public void IsPhoneNumber_CorrectString1_trueReturned()
        {
            //Arrange
            string textString = "+7-955-555-55-55";
            //Act
            StringClass obj = new StringClass();
            bool result = obj.IsPhoneNumber(textString);
            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Проверка поля телефона на корректный набор
        /// </summary>
        [TestMethod]
        public void IsPhoneNumber_CorrectString2_trueReturned()
        {
            //Arrange
            string textString = "+7(955) 555-55-55";
            //Act
            StringClass obj = new StringClass();
            bool result = obj.IsPhoneNumber(textString);
            //Assert
            Assert.IsTrue(result);
        }



        /// <summary>
        /// Проверка поля пароля на пустую строку
        /// </summary>
        [TestMethod]
        public void IsPassword_Empty_falseReturned()
        {
            //Arrange
            string textString = "";
            //Act
            StringClass obj = new StringClass();
            bool result = obj.IsPassword(textString);
            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Проверка поля пароля на корректную строку
        /// </summary>
        [TestMethod]
        public void IsPassword_CorrectString_trueReturned()
        {
            //Arrange
            string textString = "Mm$11234_";
            //Act
            StringClass obj = new StringClass();
            bool result = obj.IsPassword(textString);
            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Проверка поля пароля на некорректную строку
        /// </summary>
        [TestMethod]
        public void IsPassword_UnCorrectString_falseReturned()
        {
            //Arrange
            string textString = "MMMMM";
            //Act
            StringClass obj = new StringClass();
            bool result = obj.IsPassword(textString);
            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Проверка поля пароля на некорректную строку
        /// </summary>
        [TestMethod]
        public void IsPassword_UnCorrectString1_falseReturned()
        {
            //Arrange
            string textString = "123123123";
            //Act
            StringClass obj = new StringClass();
            bool result = obj.IsPassword(textString);
            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Проверка поля пароля на некорректную строку
        /// </summary>
        [TestMethod]
        public void IsPassword_UnCorrectString2_falseReturned()
        {
            //Arrange
            string textString = "MMMmmm123$kfkfkfkfkkfefefefefefefefefefefefefefefefeffefefe";
            //Act
            StringClass obj = new StringClass();
            bool result = obj.IsPassword(textString);
            //Assert
            Assert.IsFalse(result);
        }


        public TestContext TestContext { get; set; }
        private UserManager manager = new UserManager();
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            @"testData.xml",
            "User",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void UserManager_Data()
        {
            //Arrange
            string userId = Convert.ToString(TestContext.DataRow["userid"]);
            string password = Convert.ToString(TestContext.DataRow["password"]);
            //Act
            bool result = manager.CorrectData(userId, password);
            //Assert
            Assert.IsTrue(result, "Пользователь не может быть создан");
        }
    }
}
