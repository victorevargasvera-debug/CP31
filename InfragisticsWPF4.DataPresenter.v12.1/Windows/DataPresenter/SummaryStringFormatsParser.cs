using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001D4 RID: 468
	internal class SummaryStringFormatsParser
	{
		// Token: 0x06001B44 RID: 6980 RVA: 0x00074AE8 File Offset: 0x00072CE8
		internal static global::System.Collections.Generic.Dictionary<string, string> Parse(string calcStringFormats)
		{
			global::Infragistics.Windows.DataPresenter.SummaryStringFormatsParser summaryStringFormatsParser = new global::Infragistics.Windows.DataPresenter.SummaryStringFormatsParser();
			summaryStringFormatsParser.ParseHelper(calcStringFormats);
			return summaryStringFormatsParser._calcFormats;
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x00074B08 File Offset: 0x00072D08
		internal static bool IsValid(string calcStringFormats)
		{
			global::System.Collections.Generic.Dictionary<string, string> dictionary = global::Infragistics.Windows.DataPresenter.SummaryStringFormatsParser.Parse(calcStringFormats);
			return dictionary != null && dictionary.Count > 0;
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x00074B2C File Offset: 0x00072D2C
		private void ParseHelper(string calcStringFormats)
		{
			global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex("^(?:([^\\:]+)\\:([^,]+))(?:,(?:([^\\:]+)\\:([^,]+)))*$");
			global::System.Text.RegularExpressions.Match match = regex.Match(calcStringFormats);
			if (!match.Success)
			{
				return;
			}
			this._calcFormats = new global::System.Collections.Generic.Dictionary<string, string>(global::System.StringComparer.CurrentCultureIgnoreCase);
			global::System.Text.RegularExpressions.GroupCollection groups = match.Groups;
			this.ProcessMatch(groups[1].Captures, groups[2].Captures);
			this.ProcessMatch(groups[3].Captures, groups[4].Captures);
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x00074BA8 File Offset: 0x00072DA8
		private void ProcessMatch(global::System.Text.RegularExpressions.CaptureCollection calcNames, global::System.Text.RegularExpressions.CaptureCollection formats)
		{
			int num = global::System.Math.Min(calcNames.Count, formats.Count);
			for (int i = 0; i < num; i++)
			{
				this.AddCalcFormat(calcNames[i].Value, formats[i].Value);
			}
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x00074BF1 File Offset: 0x00072DF1
		private void AddCalcFormat(string calcName, string format)
		{
			this._calcFormats[calcName.Trim()] = format.Trim();
		}

		// Token: 0x04000B3C RID: 2876
		private global::System.Collections.Generic.Dictionary<string, string> _calcFormats;
	}
}
