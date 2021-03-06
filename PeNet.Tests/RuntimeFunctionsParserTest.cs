using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeNet.Structures;
// <copyright file="RuntimeFunctionsParserTest.cs">Copyright ©  2016</copyright>

namespace PeNet.Parser.Tests
{
    [TestClass]
    [PexClass(typeof(RuntimeFunctionsParser))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class RuntimeFunctionsParserTest
    {
        [PexMethod]
        internal RuntimeFunctionsParser Constructor(
            byte[] buff,
            uint offset,
            bool is32Bit,
            uint directorySize,
            IMAGE_SECTION_HEADER[] sectionHeaders
            )
        {
            var target
                = new RuntimeFunctionsParser(buff, offset, is32Bit, directorySize, sectionHeaders);
            return target;
            // TODO: add assertions to method RuntimeFunctionsParserTest.Constructor(Byte[], UInt32, Boolean, UInt32, IMAGE_SECTION_HEADER[])
        }
    }
}