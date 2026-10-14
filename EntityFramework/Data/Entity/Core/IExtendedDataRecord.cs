using System;
using System.Data.Common;
using System.Data.Entity.Core.Common;

namespace System.Data.Entity.Core
{
	// Token: 0x020002D7 RID: 727
	public interface IExtendedDataRecord : global::System.Data.IDataRecord
	{
		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x0600231B RID: 8987
		global::System.Data.Entity.Core.Common.DataRecordInfo DataRecordInfo { get; }

		// Token: 0x0600231C RID: 8988
		global::System.Data.Common.DbDataRecord GetDataRecord(int i);

		// Token: 0x0600231D RID: 8989
		global::System.Data.Common.DbDataReader GetDataReader(int i);
	}
}
