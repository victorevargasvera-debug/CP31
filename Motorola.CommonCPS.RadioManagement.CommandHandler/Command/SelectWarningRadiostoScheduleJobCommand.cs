using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000042 RID: 66
	public abstract class SelectWarningRadiostoScheduleJobCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600026B RID: 619 RVA: 0x00020D40 File Offset: 0x0001EF40
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)114294784;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1523122176;
				short num3 = num;
				num = (short)1200042342;
				short num4 = num;
				num = (short)960901478;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1239482369;
					if (num != 0)
					{
					}
					num = (short)447283200;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_D6;
						}
						continue;
					case 1:
						num = (short)1132199938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (paras.Count<object>() <= 0)
						{
							num = (short)1903951875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_133;
					case 3:
						goto IL_131;
					}
					break;
				}
				IL_D6:
				if (paras == null)
				{
					break;
				}
				num = (short)1577582593;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F4:
			throw new global::System.ArgumentNullException();
			IL_131:
			goto IL_F4;
			IL_133:
			return !(paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext).IsNeedConfirm;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00020E90 File Offset: 0x0001F090
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)2004942848;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext selectWarningRadiostoScheduleJobContext;
			for (;;)
			{
				num = (short)1412825088;
				short num3 = num;
				switch (num2)
				{
				case 0:
				{
					num = (short)1667572258;
					short num4 = num;
					num = (short)67117602;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D7;
					default:
						num = (short)393936897;
						if (num != 0)
						{
						}
						num = (short)383516672;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_D4;
						}
						continue;
					}
					break;
				}
				case 1:
					num = (short)770113539;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_10B;
				case 3:
					if (paras.Count<object>() <= 0)
					{
						num = (short)1920532484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					selectWarningRadiostoScheduleJobContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext);
					num = (short)517406722;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_15A;
				}
				goto IL_D4;
				IL_D7:
				num = (short)738852865;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D4:
				if (paras != null)
				{
					goto IL_D7;
				}
				goto IL_11B;
			}
			IL_10B:
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list = selectWarningRadiostoScheduleJobContext.SelectWarningRadios.Select(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio p)
			{
				short num5 = (short)1336934400;
				short num6 = num5;
				num5 = (short)1793341306;
				short num7 = num5;
				num5 = (short)2012166010;
				switch (num7 == num5)
				{
				}
				num5 = (short)1591148545;
				if (num5 != 0)
				{
				}
				num5 = (short)1707278336;
				if (num5 != 0)
				{
				}
				return p.Radio;
			}).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
			list.AddRange(selectWarningRadiostoScheduleJobContext.NormalRadios);
			selectWarningRadiostoScheduleJobContext.ScheduleJobContext.Radios = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(list);
			this.ExecBatchOP(selectWarningRadiostoScheduleJobContext.ScheduleJobContext);
			return null;
			IL_11B:
			throw new global::System.ArgumentNullException();
			IL_15A:
			goto IL_11B;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00021048 File Offset: 0x0001F248
		protected void RunOperationWrapper(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext context, global::Motorola.CommonCPS.RadioManagement.BatchOp.ScheduleJobBatchOp operation)
		{
			short num = (short)1939341312;
			short num2 = num;
			num = (short)1693638765;
			short num3 = num;
			num = (short)1867243629;
			switch (num3 == num)
			{
			}
			num = (short)1033109505;
			if (num != 0)
			{
			}
			num = (short)1841692672;
			if (num != 0)
			{
			}
			base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(operation);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x000210F8 File Offset: 0x0001F2F8
		protected virtual void ExecBatchOP(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext context)
		{
			short num = (short)811270144;
			short num2 = num;
			num = (short)899972837;
			short num3 = num;
			num = (short)365657829;
			switch (num3 == num)
			{
			}
			num = (short)1674838016;
			if (num != 0)
			{
			}
			num = (short)1454243841;
			if (num != 0)
			{
			}
		}
	}
}
