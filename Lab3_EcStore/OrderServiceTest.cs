using System.Collections.Generic;
using NSubstitute;
using Xunit;

namespace Lab3_EcStore
{
    /// <summary>
    /// OrderServiceTest 的摘要描述
    /// </summary>
    public class OrderServiceTest
    {
        #region 其他測試屬性

        // MsTest
        // 您可以使用下列其他屬性撰寫您的測試:
        //
        // 執行該類別中第一項測試前，使用 ClassInitialize 執行程式碼
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在類別中的所有測試執行後，使用 ClassCleanup 執行程式碼
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在執行每一項測試之前，先使用 TestInitialize 執行程式碼
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在執行每一項測試之後，使用 TestCleanup 執行程式碼
        // [TestCleanup()]
        // public void MyTestCleanup() { }

        // ---

        // NUnit
        // 您可以使用下列其他屬性撰寫您的測試:
        //
        // 執行該類別中第一項測試前，使用 ClassInitialize 執行程式碼
        // [OneTimeSetUp()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在類別中的所有測試執行後，使用 ClassCleanup 執行程式碼
        // [OneTimeTearDown()]
        // public static void MyClassCleanup() { }
        //
        // 在執行每一項測試之前，先使用 TestInitialize 執行程式碼
        // [SetUp()]
        // public void MyTestInitialize() { }
        //
        // 在執行每一項測試之後，使用 TestCleanup 執行程式碼
        // [TearDown()]
        // public void MyTestCleanup() { }

        #endregion 其他測試屬性

        [Fact]
        public void Test_SyncBookOrders_3_Orders_Only_2_book_order()
        {
        }
    }
}