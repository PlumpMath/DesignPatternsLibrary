using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdapterPattern.Library;
using AdapterPattern.Test;
using System.IO;
using System.Linq;

namespace AdapterPattern
{
    [TestClass]
    public class DataRendererShould
    {
        [TestMethod]
        public void RenderOneRowGivenStubDataAdapter()
        {
            var myRenderer = new DataRenderer(new StubDbAdapter());

            var writer = new StringWriter();
            myRenderer.Render(writer);

            string result = writer.ToString();
            Console.Write(result);

            int lineCount = result.Count(c => c == '\n');
            Assert.AreEqual(3, lineCount);
        }
    }
}
