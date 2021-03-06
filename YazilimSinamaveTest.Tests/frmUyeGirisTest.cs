using System.Reflection;
// <copyright file="frmUyeGirisTest.cs">Copyright ©  2016</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YazilimSinamaveTest;

namespace YazilimSinamaveTest.Tests
{
    /// <summary>This class contains parameterized unit tests for frmUyeGiris</summary>
    [PexClass(typeof(frmUyeGiris))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class frmUyeGirisTest
    {
        public frmUyeGirisTest()
        {

        }

        [PexMethod]
        [PexMethodUnderTest("btnGiris_Click(Object, EventArgs)")]
        internal void btnGiris_Click(
            [PexAssumeUnderTest]frmUyeGiris target,
            object sender,
            EventArgs e
        )
        {
            object[] args = new object[2];
            args[0] = sender;
            args[1] = (object)e;
            Type[] parameterTypes = new Type[2];
            parameterTypes[0] = typeof(object);
            parameterTypes[1] = typeof(EventArgs);
            object result = ((MethodBase)(typeof(frmUyeGiris).GetMethod("btnGiris_Click",
                                                                        BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                        CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                .Invoke((object)target, args);
            // TODO: add assertions to method frmUyeGirisTest.btnGiris_Click(frmUyeGiris, Object, EventArgs)
        }
    }
}
