using System;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000411 RID: 1041
	[global::System.Serializable]
	public class LeftoverDataException : global::System.Exception
	{
		// Token: 0x060025EF RID: 9711 RVA: 0x000729F4 File Offset: 0x00070BF4
		public LeftoverDataException(int sid, int remainingByteCount) : base(string.Concat(new string[]
		{
			"Initialisation of record 0x",
			global::NPOI.Util.StringUtil.ToHexString(sid).ToUpper(),
			"(",
			global::NPOI.HSSF.Record.LeftoverDataException.getRecordName(sid),
			") left ",
			remainingByteCount.ToString(),
			" bytes remaining still to be read."
		}))
		{
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x00072A54 File Offset: 0x00070C54
		private static string getRecordName(int sid)
		{
			global::System.Type recordClass = global::NPOI.HSSF.Record.RecordFactory.GetRecordClass(sid);
			if (recordClass == null)
			{
				return null;
			}
			return recordClass.Name;
		}
	}
}
