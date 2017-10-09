using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace LogAn.UnitTests
{
	[TestFixture]
    public class LogAnalyzerTests
    {
		[Test]
        public void IsValidLogFileName_BadExtension_ReturnsFalse()
		{
			LogAnalyzer analyzer = new LogAnalyzer();

			bool result = analyzer.IsValidLogFileName("filewithbadeextension.foo");

			Assert.False(result);
		}

		[Test]
	    public void IsValidLogFileName_GoodExtensionLowecase_ReturnsTrue()
	    {
		    LogAnalyzer analyzer = new LogAnalyzer();

		    bool result = analyzer.IsValidLogFileName("filewithgoodextension.slf");

			Assert.True(result);
	    }


		[Test]
	    public void IsValidLogFileName_GoodExtensionUppercase_ReturnsTrue()
	    {
		    LogAnalyzer analyzer = new LogAnalyzer();

		    bool result = analyzer.IsValidLogFileName("filewithgoodextension.SLF");

			Assert.True(result);
	    }
    }
}
