using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000059 RID: 89
	public interface IDataFormat
	{
		// Token: 0x06000352 RID: 850
		short GetFormat(string format);

		// Token: 0x06000353 RID: 851
		string GetFormat(short index);
	}
}
