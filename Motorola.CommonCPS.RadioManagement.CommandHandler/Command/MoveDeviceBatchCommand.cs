using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000B9 RID: 185
	internal class MoveDeviceBatchCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060003F8 RID: 1016 RVA: 0x0004255C File Offset: 0x0004075C
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1586823173;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return false;
				case 1:
					if ((paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.MoveDeviceContext).TargetGroup == null)
					{
						num = (short)1595473920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 2:
					goto IL_174;
				case 3:
					num = (short)1020657668;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (paras.Count<object>() < 1)
					{
						num = (short)741596395;
						short num3 = num;
						num = (short)2141707499;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)191430656;
							if (num != 0)
							{
							}
							num = (short)2087124994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
					}
					num = (short)499187713;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)1512505345;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				}
				IL_63:
				if (paras == null)
				{
					return false;
				}
				num = (short)939851776;
				short num4 = num;
				num = (short)1287192579;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_174:
			return false;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x000426E8 File Offset: 0x000408E8
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)304611328;
			switch (num)
			{
			default:
			{
				global::Motorola.CommonCPS.RadioManagement.BatchOp.MoveDeviceBatchOp op;
				for (;;)
				{
					num = (short)1002176512;
					short num2 = num;
					num = (short)582615048;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							num = (short)1465253889;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (paras.Count<object>() < 1)
							{
								num = (short)1200095234;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1474428938;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_208;
						case 3:
							goto IL_170;
						case 4:
						{
							global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radios;
							if (radios.Count<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>() == 0)
							{
								num = (short)388104199;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							op = null;
							num = (short)1119617036;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.Group targetGroup;
							global::System.Guid? id = targetGroup.ID;
							num = (short)751697926;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							global::System.Guid? id;
							if (id == null)
							{
								num = (short)1870594059;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radios;
							global::Motorola.CommonCPS.RadioManagement.UIModels.Group targetGroup;
							op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.MoveDeviceBatchOp(radios, targetGroup);
							num = (short)2077687817;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_1C6;
						case 8:
							switch (0)
							{
							case 0:
								goto IL_A2;
							}
							continue;
						case 9:
							goto IL_279;
						case 10:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.MoveDeviceContext moveDeviceContext = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.MoveDeviceContext;
							if (moveDeviceContext == null)
							{
								goto Block_3;
							}
							global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radios = moveDeviceContext.Radios;
							global::Motorola.CommonCPS.RadioManagement.UIModels.Group targetGroup = moveDeviceContext.TargetGroup;
							num = (short)593887236;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
						{
							global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radios;
							op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.MoveDeviceBatchOp(radios, null);
							num = (short)2074542083;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.Group targetGroup;
							if (targetGroup != null)
							{
								num = (short)635830277;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_27B;
						}
						}
						IL_A2:
						num = (short)1353711617;
						if (num != 0)
						{
						}
						if (paras == null)
						{
							goto IL_14A;
						}
						num = (short)1498152960;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_27B:
					num = (short)537640465;
					short num4 = num;
					num = (short)1996078609;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_2B0;
					}
					IL_170:
					IL_279:
					goto IL_27B;
				}
				Block_3:
				throw new global::System.ArgumentNullException();
				IL_14A:
				throw new global::System.ArgumentNullException();
				IL_1C6:
				throw new global::System.ArgumentNullException();
				IL_208:
				goto IL_14A;
				IL_2B0:
				num = (short)764215296;
				if (num != 0)
				{
				}
				base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(op);
				return null;
			}
			}
		}
	}
}
