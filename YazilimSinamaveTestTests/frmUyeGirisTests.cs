using Microsoft.VisualStudio.TestTools.UnitTesting;
using YazilimSinamaveTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimSinamaveTest.Tests
{
    [TestClass()]
    public class frmUyeGirisTests
    {
        [TestMethod()]
        public void GirisYapTest()
        {
            int beklenenDeger = 1;

            string username = "yakupad";
            string password = "1234";
            
            frmUyeGiris a = new frmUyeGiris();
            
           int sonuc= a.GirisYap(username, password);
            Assert.AreEqual(beklenenDeger, sonuc);
            Assert.Fail();
        }
        [TestMethod()]
        public void GirisYapTest2()
        {
            int beklenenDeger = 0;

            string username = "saaa";
            string password = "21312313";

            frmUyeGiris a = new frmUyeGiris();

            int sonuc = a.GirisYap(username, password);
            Assert.AreEqual(beklenenDeger, sonuc);
            Assert.Fail();
        }


    }
}