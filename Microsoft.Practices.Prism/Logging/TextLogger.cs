using System;
using System.Globalization;
using System.IO;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Logging
{
	// Token: 0x02000022 RID: 34
	public class TextLogger : global::Microsoft.Practices.Prism.Logging.ILoggerFacade, global::System.IDisposable
	{
		// Token: 0x060000AF RID: 175 RVA: 0x0000408A File Offset: 0x0000228A
		public TextLogger() : this(global::System.Console.Out)
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00004097 File Offset: 0x00002297
		public TextLogger(global::System.IO.TextWriter writer)
		{
			if (writer == null)
			{
				throw new global::System.ArgumentNullException("writer");
			}
			this.writer = writer;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000040B4 File Offset: 0x000022B4
		public void Log(string message, global::Microsoft.Practices.Prism.Logging.Category category, global::Microsoft.Practices.Prism.Logging.Priority priority)
		{
			string value = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Microsoft.Practices.Prism.Properties.Resources.DefaultTextLoggerPattern, new object[]
			{
				global::System.DateTime.Now,
				category.ToString().ToUpper(global::System.Globalization.CultureInfo.InvariantCulture),
				message,
				priority.ToString()
			});
			this.writer.WriteLine(value);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000411C File Offset: 0x0000231C
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && this.writer != null)
			{
				this.writer.Dispose();
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00004134 File Offset: 0x00002334
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000039 RID: 57
		private readonly global::System.IO.TextWriter writer;
	}
}
