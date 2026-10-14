using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000076 RID: 118
	internal class AddSelectedDevices : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000327 RID: 807 RVA: 0x0003092C File Offset: 0x0002EB2C
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1747058690;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext;
				switch (num2)
				{
				case 0:
				{
					if (registerRadioLicenseContext != null)
					{
						num = (short)462553092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)701703579;
					short num3 = num;
					num = (short)1611670939;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AA;
					default:
						num = (short)1792606208;
						if (num != 0)
						{
						}
						num = (short)2001207301;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					num = (short)1007550470;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 3:
					return false;
				case 4:
					if (!(bool)paras[1])
					{
						num = (short)545259521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_191;
				case 5:
					return false;
				case 6:
					if (registerRadioLicenseContext.AvailableListBoxSelectedItems.Count == 0)
					{
						goto IL_AA;
					}
					goto IL_191;
				case 7:
					return false;
				}
				IL_44:
				num = (short)1649082369;
				if (num != 0)
				{
				}
				if (paras.Length == 0)
				{
					num = (short)1901723651;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				registerRadioLicenseContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext);
				num = (short)517799936;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AA:
				num = (short)315752455;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_191:
			num = (short)28835840;
			short num4 = num;
			return true;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00030AF4 File Offset: 0x0002ECF4
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)2140536832;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)771031040;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_83;
				}
				int reduceCount;
				for (;;)
				{
					IL_50:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list;
					switch (num2)
					{
					case 0:
						goto IL_1F5;
					case 1:
						goto IL_291;
					case 2:
					{
						if (paras.Length == 0)
						{
							num = (short)1110048774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext;
						bool flag = (bool)paras[1];
						num = (short)1501495299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext;
						if (registerRadioLicenseContext == null)
						{
							num = (short)730267657;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1869283338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext;
						list = registerRadioLicenseContext.AvailableDevices.ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
						num = (short)2042036232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						bool flag;
						if (flag)
						{
							num = (short)1550450692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext;
						list = registerRadioLicenseContext.AvailableListBoxSelectedItems.ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
						num = (short)441516033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_B7;
					case 7:
						goto IL_2B2;
					case 8:
						goto IL_291;
					case 9:
						goto IL_102;
					case 10:
					{
						num = (short)587726849;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext;
						global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> source = registerRadioLicenseContext.EIDDetails.Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>().Where(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail ed)
						{
							short num5 = (short)70057984;
							short num6 = num5;
							num5 = (short)1908320608;
							short num7 = num5;
							num5 = (short)490449248;
							switch (num7 == num5)
							{
							}
							num5 = (short)1190199296;
							if (num5 != 0)
							{
							}
							num5 = (short)1112670209;
							if (num5 != 0)
							{
							}
							return ed.IsSelected;
						}).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>();
						list = null;
						bool flag;
						if (flag)
						{
							list = registerRadioLicenseContext.AvailableDevices.ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
						}
						else
						{
							list = registerRadioLicenseContext.AvailableListBoxSelectedItems.ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
						}
						int count = registerRadioLicenseContext.SelectedDevices.Count;
						int count2 = list.Count;
						reduceCount = count + count2;
						if (source.Where(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail eidDetail)
						{
							short num5 = (short)1646264320;
							short num6 = num5;
							num5 = (short)1448712719;
							short num7 = num5;
							num5 = (short)527014415;
							switch (num7 == num5)
							{
							}
							num5 = (short)527761409;
							if (num5 != 0)
							{
							}
							num5 = (short)1921777664;
							if (num5 != 0)
							{
							}
							return eidDetail.AvailableCount - reduceCount < 0;
						}).Count<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>() > 0)
						{
							num = (short)2053701632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)635109381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_83;
					IL_291:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>.Enumerator enumerator = list.GetEnumerator();
					num = (short)1937047559;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B7:
				return null;
				IL_102:
				return null;
				IL_1F5:
				global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.InvalidMovingToSelectedDevice, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
				return null;
				IL_2B2:
				try
				{
					num = (short)760152064;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_2EF;
							}
							continue;
						case 1:
							num = (short)450887682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_3D0;
						case 4:
						{
							IL_38F:
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>.Enumerator enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1983381505;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item = enumerator.Current;
							global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext;
							registerRadioLicenseContext.SelectedDevices.Add(item);
							registerRadioLicenseContext.AvailableDevices.Remove(item);
							num = (short)24313859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_32D:
						num = (short)2083387046;
						short num4 = num;
						num = (short)1906439846;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_38F;
						default:
							num = (short)1201471488;
							if (num != 0)
							{
							}
							num = (short)1154547716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_2EF:
						goto IL_32D;
					}
					IL_3D0:;
				}
				finally
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>.Enumerator enumerator;
					((global::System.IDisposable)enumerator).Dispose();
				}
				return null;
				IL_83:
				num = (short)911540226;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}
	}
}
