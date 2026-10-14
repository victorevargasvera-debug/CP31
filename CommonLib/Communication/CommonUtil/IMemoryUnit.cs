using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000036 RID: 54
	public interface IMemoryUnit
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000144 RID: 324
		string Address { get; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000145 RID: 325
		uint Size { get; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000146 RID: 326
		byte[] Data { get; }

		// Token: 0x06000147 RID: 327
		void ChargeUnit(string address, byte[] data, byte stuff, uint alignment);

		// Token: 0x06000148 RID: 328
		void ChargeUnit(string address, byte[] data);

		// Token: 0x06000149 RID: 329
		bool IsOverlaped(global::Motorola.Common.Communication.CommonUtil.IMemoryUnit otherUnit);

		// Token: 0x0600014A RID: 330
		global::Motorola.Common.Communication.CommonUtil.IMemoryUnit Clone();

		// Token: 0x0600014B RID: 331
		bool GetData(uint addr, uint size, out byte[] buffer);
	}
}
