using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication
{
	// Token: 0x02000019 RID: 25
	public interface IProgressIndicator
	{
		// Token: 0x060000B1 RID: 177
		void StartRecord();

		// Token: 0x060000B2 RID: 178
		void StopRecord();

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000B3 RID: 179
		global::Motorola.Common.Communication.CommonUtil.ProgressStatus CurrentStatus { get; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000B4 RID: 180
		double CurrentProgress { get; }

		// Token: 0x060000B5 RID: 181
		void SetCurrentScope(int start, int end);

		// Token: 0x060000B6 RID: 182
		void UpdateProgress(double percent);

		// Token: 0x060000B7 RID: 183
		void UpdateProgress(double percent, global::Motorola.Common.Communication.CommonUtil.ProgressStatus processStatus);

		// Token: 0x060000B8 RID: 184
		void IncreaseProcess(double increasePercent);

		// Token: 0x060000B9 RID: 185
		void IncreaseProcess(double increasePercent, global::Motorola.Common.Communication.CommonUtil.ProgressStatus processStatus);

		// Token: 0x060000BA RID: 186
		void Reset();
	}
}
