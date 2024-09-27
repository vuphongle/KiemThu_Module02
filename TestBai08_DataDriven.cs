using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeVuPhong_Test_Module02
{
    [TestClass]
    public class TestBai08_DataDriven
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "|DataDirectory|\\Data08.csv", "data#csv",
        DataAccessMethod.Sequential),
        DeploymentItem("Data08.csv"), TestMethod]
        public void TestMethod01()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int chiSoCu = int.Parse(TestContext.DataRow["chiSoCu"].ToString());
            int chiSoMoi = int.Parse(TestContext.DataRow["chiSoMoi"].ToString());
            double tienDien = double.Parse(TestContext.DataRow["tienDien"].ToString());

            double result = o.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(tienDien, result, 1);
        }
    }
}
