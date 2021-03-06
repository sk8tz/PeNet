using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeNet.Structures;

// <copyright file="UtilityTest.cs">Copyright ©  2016</copyright>

namespace PeNet.Tests
{
    [TestClass]
    [PexClass(typeof(Utility))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UtilityTest
    {
        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        public ushort BytesToUInt16(byte[] buff, ulong i)
        {
            var result = buff.BytesToUInt16(i);
            return result;
            // TODO: add assertions to method UtilityTest.BytesToUInt16(Byte[], UInt64)
        }

        [PexMethod]
        public uint BytesToUInt32(byte[] buff, uint i)
        {
            var result = buff.BytesToUInt32(i);
            return result;
            // TODO: add assertions to method UtilityTest.BytesToUInt32(Byte[], UInt32)
        }

        [PexMethod]
        public ulong BytesToUInt64(byte[] buff, ulong i)
        {
            var result = buff.BytesToUInt64(i);
            return result;
            // TODO: add assertions to method UtilityTest.BytesToUInt64(Byte[], UInt64)
        }

        [PexMethod]
        public string GetName(ulong name, byte[] buff)
        {
            var result = Utility.GetName(name, buff);
            return result;
            // TODO: add assertions to method UtilityTest.GetName(UInt64, Byte[])
        }

        [PexMethod]
        public ulong GetNameLength(ulong name, byte[] buff)
        {
            var result = Utility.GetNameLength(name, buff);
            return result;
            // TODO: add assertions to method UtilityTest.GetNameLength(UInt64, Byte[])
        }

        [PexMethod]
        internal ushort GetOrdinal(uint ordinal, byte[] buff)
        {
            var result = Utility.GetOrdinal(ordinal, buff);
            return result;
            // TODO: add assertions to method UtilityTest.GetOrdinal(UInt32, Byte[])
        }

        [PexMethod]
        public bool IsSignatureValid(string filePath)
        {
            var result = Utility.IsSignatureValid(filePath);
            return result;
            // TODO: add assertions to method UtilityTest.IsSignatureValid(String)
        }

        [PexMethod]
        public bool IsSigned(string filePath)
        {
            var result = Utility.IsSigned(filePath);
            return result;
            // TODO: add assertions to method UtilityTest.IsSigned(String)
        }

        [PexMethod]
        public bool IsValidCertChain(string filePath, bool online)
        {
            var result = Utility.IsValidCertChain(filePath, online);
            return result;
            // TODO: add assertions to method UtilityTest.IsValidCertChain(String, Boolean)
        }

        [PexMethod]
        public bool IsValidCertChain01(X509Certificate2 cert, bool online)
        {
            var result = Utility.IsValidCertChain(cert, online);
            return result;
            // TODO: add assertions to method UtilityTest.IsValidCertChain01(X509Certificate2, Boolean)
        }

        [PexMethod]
        public string MD5(string file)
        {
            var result = Utility.MD5(file);
            return result;
            // TODO: add assertions to method UtilityTest.MD5(String)
        }

        [PexMethod]
        public string MD501(byte[] buff)
        {
            var result = Utility.MD5(buff);
            return result;
            // TODO: add assertions to method UtilityTest.MD501(Byte[])
        }

        [PexMethod]
        internal string PropertiesToString(object obj, string format)
        {
            var result = Utility.PropertiesToString(obj, format);
            return result;
            // TODO: add assertions to method UtilityTest.PropertiesToString(Object, String)
        }

        [PexMethod]
        public ulong RVAtoFileMapping(ulong RVA, ICollection<IMAGE_SECTION_HEADER> sh)
        {
            var result = RVA.RVAtoFileMapping(sh);
            return result;
            // TODO: add assertions to method UtilityTest.RVAtoFileMapping(UInt64, ICollection`1<IMAGE_SECTION_HEADER>)
        }

        [PexMethod]
        public uint RVAtoFileMapping01(uint RVA, ICollection<IMAGE_SECTION_HEADER> sh)
        {
            var result = RVA.RVAtoFileMapping(sh);
            return result;
            // TODO: add assertions to method UtilityTest.RVAtoFileMapping01(UInt32, ICollection`1<IMAGE_SECTION_HEADER>)
        }

        [PexMethod]
        public Utility.FileCharacteristics ResolveFileCharacteristics(ushort characteristics)
        {
            var result = Utility.ResolveFileCharacteristics(characteristics);
            return result;
            // TODO: add assertions to method UtilityTest.ResolveFileCharacteristics(UInt16)
        }

        [PexMethod]
        public string ResolveResourceId(uint id)
        {
            var result = Utility.ResolveResourceId(id);
            return result;
            // TODO: add assertions to method UtilityTest.ResolveResourceId(UInt32)
        }

        [PexMethod]
        public List<string> ResolveSectionFlags(uint sectionFlags)
        {
            var result = Utility.ResolveSectionFlags(sectionFlags);
            return result;
            // TODO: add assertions to method UtilityTest.ResolveSectionFlags(UInt32)
        }

        [PexMethod]
        public string ResolveSectionName(byte[] name)
        {
            var result = Utility.ResolveSectionName(name);
            return result;
            // TODO: add assertions to method UtilityTest.ResolveSectionName(Byte[])
        }

        [PexMethod]
        public string ResolveSubsystem(ushort subsystem)
        {
            var result = Utility.ResolveSubsystem(subsystem);
            return result;
            // TODO: add assertions to method UtilityTest.ResolveSubsystem(UInt16)
        }

        [PexMethod]
        public string ResolveTargetMachine(ushort targetMachine)
        {
            var result = Utility.ResolveTargetMachine(targetMachine);
            return result;
            // TODO: add assertions to method UtilityTest.ResolveTargetMachine(UInt16)
        }

        [PexMethod]
        public void SetUInt16(
            ushort value,
            ulong offset,
            byte[] buff
            )
        {
            value.SetUInt16(offset, buff);
            // TODO: add assertions to method UtilityTest.SetUInt16(UInt16, UInt64, Byte[])
        }

        [PexMethod]
        public void SetUInt32(
            uint value,
            uint offset,
            byte[] buff
            )
        {
            value.SetUInt32(offset, buff);
            // TODO: add assertions to method UtilityTest.SetUInt32(UInt32, UInt32, Byte[])
        }

        [PexMethod]
        public void SetUInt64(
            ulong value,
            ulong offset,
            byte[] buff
            )
        {
            value.SetUInt64(offset, buff);
            // TODO: add assertions to method UtilityTest.SetUInt64(UInt64, UInt64, Byte[])
        }

        [PexMethod]
        public string Sha1(string file)
        {
            var result = Utility.Sha1(file);
            return result;
            // TODO: add assertions to method UtilityTest.Sha1(String)
        }

        [PexMethod]
        public string Sha101(byte[] buff)
        {
            var result = Utility.Sha1(buff);
            return result;
            // TODO: add assertions to method UtilityTest.Sha101(Byte[])
        }

        [PexMethod]
        public string Sha256(string file)
        {
            var result = Utility.Sha256(file);
            return result;
            // TODO: add assertions to method UtilityTest.Sha256(String)
        }

        [PexMethod]
        public string Sha25601(byte[] buff)
        {
            var result = Utility.Sha256(buff);
            return result;
            // TODO: add assertions to method UtilityTest.Sha25601(Byte[])
        }

        [PexMethod]
        public long ToIntFromHexString(string hexString)
        {
            var result = hexString.ToIntFromHexString();
            return result;
            // TODO: add assertions to method UtilityTest.ToIntFromHexString(String)
        }

        [PexMethod]
        public string ToHexString(ICollection<byte> bytes)
        {
            var result = bytes.ToHexString();
            return result;
            // TODO: add assertions to method UtilityTest.ToHexString(ICollection`1<Byte>)
        }

        [PexMethod]
        public string ToHexString(ICollection<ushort> values)
        {
            var result = values.ToHexString();
            return result;
            // TODO: add assertions to method UtilityTest.ToHexString(ICollection`1<UInt16>)
        }

        [PexMethod]
        public string ToHexString(ushort value)
        {
            var result = value.ToHexString();
            return result;
            // TODO: add assertions to method UtilityTest.ToHexString(UInt16)
        }

        [PexMethod]
        public string ToHexString(ulong value)
        {
            var result = value.ToHexString();
            return result;
            // TODO: add assertions to method UtilityTest.ToHexString(UInt64)
        }

        [PexMethod]
        public string ToHexString(uint value)
        {
            var result = value.ToHexString();
            return result;
            // TODO: add assertions to method UtilityTest.ToHexString(UInt32)
        }

        [PexMethod]
        public List<string> ToHexString(
            byte[] input,
            ulong from,
            ulong length
            )
        {
            var result = input.ToHexString(from, length);
            return result;
            // TODO: add assertions to method UtilityTest.ToHexString(Byte[], UInt64, UInt64)
        }
    }
}