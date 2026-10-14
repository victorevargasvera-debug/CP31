using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000046 RID: 70
	public interface IObservable
	{
		// Token: 0x060000DC RID: 220
		void Register(global::Motorola.Common.Communication.CommonUtil.IObserver anObserver);

		// Token: 0x060000DD RID: 221
		void UnRegister(global::Motorola.Common.Communication.CommonUtil.IObserver anObserver);
	}
}
