using System;
using System.Configuration;
using System.Globalization;

namespace NPOI.Util
{
	// Token: 0x02000291 RID: 657
	public class SystemOutLogger : global::NPOI.Util.POILogger
	{
		// Token: 0x0600120D RID: 4621 RVA: 0x00036184 File Offset: 0x00034384
		public override void Initialize(string cat)
		{
			this._cat = cat;
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x0003618D File Offset: 0x0003438D
		public override void Log(int level, object obj1)
		{
			this.Log(level, obj1, null);
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x00036198 File Offset: 0x00034398
		public override void Log(int level, object obj1, global::System.Exception exception)
		{
			if (this.Check(level))
			{
				global::System.Console.WriteLine("[" + this._cat + "] " + ((obj1 != null) ? obj1.ToString() : null));
				if (exception != null)
				{
					global::System.Console.Write(exception.StackTrace);
				}
			}
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x000361D8 File Offset: 0x000343D8
		public override bool Check(int level)
		{
			int num;
			try
			{
				string text = global::System.Configuration.ConfigurationManager.AppSettings["poi.log.level"];
				if (string.IsNullOrEmpty(text))
				{
					text = 5.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
				}
				num = int.Parse(text, global::System.Globalization.CultureInfo.InvariantCulture);
			}
			catch (global::System.Exception)
			{
				num = 1;
			}
			return level >= num;
		}

		// Token: 0x04000779 RID: 1913
		private string _cat;
	}
}
