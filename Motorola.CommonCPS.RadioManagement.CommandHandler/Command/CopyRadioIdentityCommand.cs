using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000062 RID: 98
	internal class CopyRadioIdentityCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060002F1 RID: 753 RVA: 0x0002C950 File Offset: 0x0002AB50
		public override bool CanExecute(params object[] paras)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::System.Collections.ICollection collection;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (collection.Count != 1)
					{
						num2 = (short)839319557;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = collection.Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>()[0];
					num2 = (short)1173684228;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_12E;
				case 2:
					num2 = (short)329908225;
					if (num2 != 0)
					{
					}
					goto IL_132;
				case 3:
					if (collection != null)
					{
						num2 = (short)685244418;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
				{
					num2 = (short)674450498;
					short num3 = num2;
					num2 = (short)855985218;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_132;
					default:
					{
						num2 = (short)1257701376;
						if (num2 != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
						if (!base.UIValidateService.CanCreateJob(radioBase.JobStatus))
						{
							num2 = (short)695664641;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					}
					}
					break;
				}
				case 5:
					goto IL_16D;
				}
				goto IL_28;
				IL_132:
				num2 = (short)812056576;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_12E:
			num2 = (short)521076736;
			short num4 = num2;
			return false;
			IL_16D:
			return false;
			IL_28:
			collection = (paras[0] as global::System.Collections.ICollection);
			num2 = (short)1598291971;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0002CAF8 File Offset: 0x0002ACF8
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)330814633;
			short num2 = num;
			num = (short)426169513;
			switch (num2 == num)
			{
			default:
			{
				num = (short)97320960;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)875102208;
			if (num != 0)
			{
			}
			num = (short)1823670273;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioToCopy = (paras[0] as global::System.Collections.ICollection).Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>()[0];
			string empty = string.Empty;
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>> copiedRadioIdentityRecordsToCopy = null;
			global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
			base.LocalService.CopyRadioIdentity(radioToCopy, out copiedRadioIdentityRecordsToCopy, out radio);
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Global.CopiedRadioIdentityRecordsToCopy = copiedRadioIdentityRecordsToCopy;
			return null;
		}
	}
}
