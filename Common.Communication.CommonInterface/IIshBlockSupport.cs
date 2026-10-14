using System;
using System.Collections.Generic;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x02000010 RID: 16
	public interface IIshBlockSupport
	{
		// Token: 0x06000049 RID: 73
		global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks<T>(global::System.Collections.Generic.ICollection<T> blockList);
	}
}
