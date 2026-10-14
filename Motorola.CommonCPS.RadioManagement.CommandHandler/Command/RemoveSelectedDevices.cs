using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000088 RID: 136
	internal class RemoveSelectedDevices : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000358 RID: 856 RVA: 0x00034B14 File Offset: 0x00032D14
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1907163136;
			short num2 = num;
			num = (short)1276116998;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext;
				switch (num3)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
				{
					if ((bool)paras[1])
					{
						return true;
					}
					num = (short)609977272;
					short num4 = num;
					num = (short)2123400120;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_88;
					default:
						num = (short)469041152;
						if (num != 0)
						{
						}
						num = (short)271253511;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					return false;
				case 4:
					if (registerRadioLicenseContext.SelectedListBoxSelctedItems.Count == 0)
					{
						num = (short)1335361536;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 5:
					if (registerRadioLicenseContext == null)
					{
						num = (short)910491651;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)486277122;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_6E;
					}
					continue;
				case 7:
					num = (short)1180631041;
					if (num != 0)
					{
					}
					goto IL_88;
				}
				IL_6E:
				if (paras.Length == 0)
				{
					num = (short)762576897;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				registerRadioLicenseContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext);
				num = (short)1854603269;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_88:
				num = (short)2055208964;
				num3 = (int)((global::System.IntPtr)num);
			}
			return false;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00034CDC File Offset: 0x00032EDC
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)869728256;
			switch (num)
			{
			default:
			{
				num = (short)1873084419;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list;
					switch (num2)
					{
					case 0:
					{
						if (!flag)
						{
							list = registerRadioLicenseContext.SelectedListBoxSelctedItems.ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
							num = (short)2141913089;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1254569386;
						short num3 = num;
						num = (short)967390634;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2FC;
						default:
							num = (short)1838481408;
							if (num != 0)
							{
							}
							num = (short)749797384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_B1;
					case 2:
						if (registerRadioLicenseContext == null)
						{
							num = (short)1394868230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						list = null;
						num = (short)1361051648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)844890113;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_8F;
						}
						continue;
					case 4:
						goto IL_CD;
					case 5:
						goto IL_B1;
					case 6:
						goto IL_165;
					case 7:
						goto IL_AC;
					case 8:
						list = registerRadioLicenseContext.SelectedDevices.ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
						num = (short)273940485;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_8F:
					if (paras.Length == 0)
					{
						num = (short)380305415;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					registerRadioLicenseContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext);
					flag = (bool)paras[1];
					num = (short)118423554;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B1:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>.Enumerator enumerator = list.GetEnumerator();
					num = (short)1907949572;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_AC:
				goto IL_247;
				IL_CD:
				num = (short)1404174336;
				short num4 = num;
				try
				{
					num = (short)1316552707;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 1:
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>.Enumerator enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)672333826;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item = enumerator.Current;
							global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext;
							registerRadioLicenseContext.AvailableDevices.Add(item);
							registerRadioLicenseContext.SelectedDevices.Remove(item);
							num = (short)1453916160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num = (short)1408106500;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_1A5;
							}
							continue;
						case 4:
							goto IL_234;
						}
						IL_1A7:
						num = (short)1769799681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1A5:
						goto IL_1A7;
					}
					IL_234:
					goto IL_2FC;
				}
				finally
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>.Enumerator enumerator;
					((global::System.IDisposable)enumerator).Dispose();
				}
				goto IL_247;
				IL_165:
				return null;
				IL_247:
				return null;
				IL_2FC:
				return null;
			}
			}
		}
	}
}
