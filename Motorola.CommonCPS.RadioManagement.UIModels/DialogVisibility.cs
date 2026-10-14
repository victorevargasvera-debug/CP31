using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Global.Properties;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000008 RID: 8
	public class DialogVisibility : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00006798 File Offset: 0x00004998
		// (set) Token: 0x06000052 RID: 82 RVA: 0x0000684C File Offset: 0x00004A4C
		public global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType Operation
		{
			get
			{
				short num = (short)318098102;
				short num2 = num;
				num = (short)1078053558;
				switch (num2 == num)
				{
				}
				num = (short)1533870080;
				short num3 = num;
				num = (short)889126912;
				if (num != 0)
				{
				}
				num = (short)1055457281;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				int a_ = 10;
				short num = (short)1258749952;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1D;
					case 1:
					{
						num = (short)1567217050;
						short num3 = num;
						num = (short)612029850;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D;
						default:
							num = (short)765460481;
							if (num != 0)
							{
							}
							num = (short)1325596672;
							if (num != 0)
							{
							}
							this.a = value;
							this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("੄㝆ⱈ㥊ⱌ㭎㡐㱒㭔", a_));
							num = (short)2111635458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_103;
					}
					goto IL_39;
					IL_1D:
					switch (0)
					{
					case 0:
						IL_39:
						if (value == this.a)
						{
							return;
						}
						num = (short)1363345409;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_103:
				num = (short)519634944;
				short num4 = num;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00006988 File Offset: 0x00004B88
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00006A3C File Offset: 0x00004C3C
		public bool Show
		{
			get
			{
				short num = (short)1394169115;
				short num2 = num;
				num = (short)722228507;
				switch (num2 == num)
				{
				}
				num = (short)194969600;
				short num3 = num;
				num = (short)1437401089;
				if (num != 0)
				{
				}
				num = (short)2003632128;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				int a_ = 16;
				short num = (short)1801453568;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)2016346113;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_1F;
					case 1:
					{
						num = (short)353855281;
						short num3 = num;
						num = (short)1359898417;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1F;
						default:
							num = (short)132317184;
							if (num != 0)
							{
							}
							this.b = value;
							this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᡊ╌⁎♐", a_));
							num = (short)869007362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_100;
					}
					goto IL_62;
					IL_1F:
					switch (0)
					{
					case 0:
						IL_62:
						if (value == this.b)
						{
							return;
						}
						num = (short)1253703681;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_100:
				num = (short)2110259200;
				short num4 = num;
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00006B74 File Offset: 0x00004D74
		public static global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility> GetDialogVisibilitiesSettingFromSerialization(global::Motorola.CommonCPS.RadioManagement.Global.SerializableDialogVisibilities visibilities)
		{
			short num = (short)1115245911;
			short num2 = num;
			num = (short)894913879;
			switch (num2 == num)
			{
			}
			num = (short)1792344064;
			short num3 = num;
			num = (short)1574305793;
			if (num != 0)
			{
			}
			num = (short)1454768128;
			if (num != 0)
			{
			}
			return visibilities.Dialogs.Select(delegate(global::Motorola.CommonCPS.RadioManagement.Global.SerializableDialogVisibilities.SerializableDialog serializableDialog)
			{
				short num4 = (short)1524277074;
				short num5 = num4;
				num4 = (short)2137038674;
				switch (num5 == num4)
				{
				}
				num4 = (short)1056309248;
				short num6 = num4;
				num4 = (short)733347840;
				if (num4 != 0)
				{
				}
				num4 = (short)634257409;
				if (num4 != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility
				{
					Operation = (global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType)global::System.Enum.Parse(typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType), serializableDialog.Operation, true),
					Show = serializableDialog.Show
				};
			});
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00006C4C File Offset: 0x00004E4C
		public static global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility> GetDialogVisibilitiesSetting()
		{
			short num = (short)242918754;
			short num2 = num;
			num = (short)2064164194;
			switch (num2 == num)
			{
			}
			num = (short)1338572800;
			short num3 = num;
			num = (short)195952641;
			if (num != 0)
			{
			}
			num = (short)1575878656;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility.GetDialogVisibilitiesSettingFromSerialization(global::Motorola.CommonCPS.RadioManagement.Global.Properties.Settings.Default.DialogVisibilities);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00006D04 File Offset: 0x00004F04
		public static bool GetDialogVisibilitySetting(global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType operation, global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility> visibilities)
		{
			short num = (short)1541239044;
			short num2 = num;
			num = (short)2085646596;
			global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility> source;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)358219776;
				if (num != 0)
				{
				}
				num = (short)1948712961;
				if (num != 0)
				{
				}
				num = (short)1771307008;
				short num3 = num;
				source = global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility.GetDialogVisibilitiesSetting().Where(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility dialog)
				{
					short num4 = (short)983563212;
					short num5 = num4;
					num4 = (short)200866764;
					switch (num5 == num4)
					{
					}
					num4 = (short)712638464;
					short num6 = num4;
					num4 = (short)906690561;
					if (num4 != 0)
					{
					}
					num4 = (short)2056323072;
					if (num4 != 0)
					{
					}
					return dialog.Operation == operation;
				});
				if (!source.Any<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility>())
				{
					return true;
				}
				break;
			}
			}
			return source.Single<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility>().Show;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00006DE8 File Offset: 0x00004FE8
		public static bool GetDialogVisibilitySetting(global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType operation)
		{
			short num = (short)190911406;
			short num2 = num;
			num = (short)2079986606;
			switch (num2 == num)
			{
			}
			num = (short)851902464;
			short num3 = num;
			num = (short)1298726913;
			if (num != 0)
			{
			}
			num = (short)1674706944;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility.GetDialogVisibilitySetting(operation, global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility.GetDialogVisibilitiesSetting());
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00006E9C File Offset: 0x0000509C
		public static global::Motorola.CommonCPS.RadioManagement.Global.SerializableDialogVisibilities SerializeDialogVisibilities(global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility> visibilities)
		{
			short num = (short)642967053;
			short num2 = num;
			num = (short)611247629;
			switch (num2 == num)
			{
			}
			num = (short)81854464;
			short num3 = num;
			num = (short)1379794945;
			if (num != 0)
			{
			}
			num = (short)1627783168;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Global.SerializableDialogVisibilities serializableDialogVisibilities = new global::Motorola.CommonCPS.RadioManagement.Global.SerializableDialogVisibilities();
			serializableDialogVisibilities.Dialogs = visibilities.Select(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility setting)
			{
				short num4 = (short)765198337;
				if (num4 != 0)
				{
				}
				num4 = (short)1617435884;
				short num5 = num4;
				num4 = (short)1628445932;
				switch (num5 == num4)
				{
				default:
				{
					num4 = (short)146276352;
					short num6 = num4;
					break;
				}
				case true:
					break;
				}
				num4 = (short)344522752;
				if (num4 != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Global.SerializableDialogVisibilities.SerializableDialog
				{
					Operation = setting.Operation.ToString(),
					Show = setting.Show
				};
			}).ToList<global::Motorola.CommonCPS.RadioManagement.Global.SerializableDialogVisibilities.SerializableDialog>();
			return serializableDialogVisibilities;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00006F7C File Offset: 0x0000517C
		public static global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility> MergeDialogVisibilities(global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility> newSettings, global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility> existingSettings)
		{
			short num = (short)2143420416;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType, bool> dictionary;
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility> enumerator;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					try
					{
						num = (short)1846214657;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)1444347908;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_7A;
								}
								continue;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)814022656;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility dialogVisibility = enumerator.Current;
								dictionary[dialogVisibility.Operation] = dialogVisibility.Show;
								num = (short)1805123587;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								goto IL_F6;
							}
							IL_7C:
							num = (short)1515716610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_7A:
							goto IL_7C;
						}
						IL_F6:
						goto IL_261;
					}
					finally
					{
						num = (short)1906507776;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_12B;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)42205186;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_15F;
							}
							IL_12B:
							if (enumerator == null)
							{
								break;
							}
							num = (short)2035679233;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_15F:;
					}
					goto IL_162;
					IL_261:
					num = (short)1055653890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_279;
				}
				goto IL_30;
				IL_162:
				global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility, global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType> keySelector;
				dictionary = existingSettings.ToDictionary(keySelector, delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility d)
				{
					short num5 = (short)162594817;
					if (num5 != 0)
					{
					}
					num5 = (short)1516648371;
					short num6 = num5;
					num5 = (short)1242773427;
					switch (num6 == num5)
					{
					default:
					{
						num5 = (short)1652293632;
						short num7 = num5;
						break;
					}
					case true:
						break;
					}
					num5 = (short)1096613888;
					if (num5 != 0)
					{
					}
					return d.Show;
				});
				enumerator = newSettings.GetEnumerator();
				num = (short)220853752;
				short num3 = num;
				num = (short)787936760;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
				{
					num = (short)960561152;
					short num4 = num;
					num = (short)654508033;
					if (num != 0)
					{
					}
					num = (short)2128347136;
					if (num != 0)
					{
					}
					num = (short)1509163009;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_30:
				if ((keySelector = global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility.<>c.<>9__13_0) == null)
				{
					keySelector = (global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility.<>c.<>9__13_0 = delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility d)
					{
						short num5 = (short)1597754837;
						short num6 = num5;
						num5 = (short)892325333;
						switch (num6 == num5)
						{
						}
						num5 = (short)1676214272;
						short num7 = num5;
						num5 = (short)296157185;
						if (num5 != 0)
						{
						}
						num5 = (short)753926144;
						if (num5 != 0)
						{
						}
						return d.Operation;
					});
					goto IL_162;
				}
				goto IL_162;
			}
			IL_279:
			return dictionary.Select(delegate(global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType, bool> setting)
			{
				short num5 = (short)2079664210;
				short num6 = num5;
				num5 = (short)1825843282;
				switch (num6 == num5)
				{
				}
				num5 = (short)1471086592;
				short num7 = num5;
				num5 = (short)914489345;
				if (num5 != 0)
				{
				}
				num5 = (short)488308736;
				if (num5 != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility
				{
					Operation = setting.Key,
					Show = setting.Value
				};
			});
		}

		// Token: 0x04000007 RID: 7
		private global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType a;

		// Token: 0x04000008 RID: 8
		private bool b;
	}
}
