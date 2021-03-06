// <copyright file="OrdinalSymbolMappingTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PeNet.ImpHash.Tests
{
    [TestClass]
    [PexClass(typeof(OrdinalSymbolMapping))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class OrdinalSymbolMappingTest
    {
        [PexMethod]
        internal string Lookup(OrdinalSymbolMapping.Modul module, uint ordinal)
        {
            var result = OrdinalSymbolMapping.Lookup(module, ordinal);
            return result;
            // TODO: add assertions to method OrdinalSymbolMappingTest.Lookup(Modul, UInt32)
        }
    }
}