using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Resolver.Util;

namespace Resolver.Test
{
    [TestClass]
    public class ConverterTest
    {
        [TestMethod]
        public void CodeloadToDownload()
        {
            string org    = "fastgitorg",
                   repo   = "PSFastGet",
                   branch = "master";

            string target = "https://download.fastgit.org/fastgitorg/PSFastGet/archive/master.zip";
            
            Assert.IsTrue(Converter.ConvertToDownload(org, repo, branch) == target);
        }
    }
}