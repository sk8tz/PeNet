// <copyright file="ImageSectionHeadersParserTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PeNet.Parser.Tests
{
    [TestClass]
    [PexClass(typeof(ImageSectionHeadersParser))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ImageSectionHeadersParserTest
    {
        [PexMethod]
        internal ImageSectionHeadersParser Constructor(
            byte[] buff,
            uint offset,
            ushort numOfSections
            )
        {
            var target = new ImageSectionHeadersParser(buff, offset, numOfSections);
            return target;
            // TODO: add assertions to method ImageSectionHeadersParserTest.Constructor(Byte[], UInt32, UInt16)
        }
    }
}