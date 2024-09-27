using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeVuPhong_Test_Module02
{
    [TestClass]
    public class TestBai08_DataDrivenBase
    {
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
"|DataDirectory|\\data.csv", "data#csv",
DataAccessMethod.Sequential),
DeploymentItem("data.csv"), TestMethod]
        public void TestMethod1()
        {
        }
    }
}