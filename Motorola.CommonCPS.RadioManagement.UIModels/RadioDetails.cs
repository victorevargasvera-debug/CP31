using System;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000E3 RID: 227
	public class RadioDetails : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x06000AC3 RID: 2755 RVA: 0x000A3418 File Offset: 0x000A1618
		public RadioDetails(global::Motorola.CommonCPS.Server.EntityModel.Radio radio)
		{
			this.Radio = radio;
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x000A3434 File Offset: 0x000A1634
		// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x000A34E4 File Offset: 0x000A16E4
		public global::Motorola.CommonCPS.Server.EntityModel.Radio Radio
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1876887377;
				short num2 = num;
				num = (short)1923352401;
				switch (num2 == num)
				{
				}
				num = (short)962265088;
				short num3 = num;
				num = (short)2051080193;
				if (num != 0)
				{
				}
				num = (short)786104320;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1520114267;
				short num2 = num;
				num = (short)1055660635;
				switch (num2 == num)
				{
				}
				num = (short)754974720;
				short num3 = num;
				num = (short)706871297;
				if (num != 0)
				{
				}
				num = (short)1391067136;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x000A3594 File Offset: 0x000A1794
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x000A3644 File Offset: 0x000A1844
		public global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob SelectedHistoricalJob
		{
			get
			{
				short num = (short)1407909889;
				if (num != 0)
				{
				}
				num = (short)7505724;
				short num2 = num;
				num = (short)1912964924;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1023148032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1623851008;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)5767170;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_D1;
					case 1:
					{
						num = (short)367198208;
						short num3 = num;
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails.get_SelectedHistoricalJob())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1029898240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 3:
						if (!base.IsLoading)
						{
							num = (short)764215297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_163;
					case 4:
						return;
					}
					IL_38:
					if (value == this.a)
					{
						num = (short)1563361284;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						this.a = value;
						num = (short)589103107;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				return;
				IL_D1:
				num = (short)1718387988;
				short num4 = num;
				num = (short)1948484884;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1565130752;
					if (num != 0)
					{
					}
					break;
				}
				IL_163:
				num = (short)759889921;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x000A37DC File Offset: 0x000A19DC
		public string RadioAlias
		{
			get
			{
				while (this.WorkingCodeplug != null)
				{
					short num = (short)1247477760;
					short num2 = num;
					num = (short)2053201480;
					short num3 = num;
					num = (short)1625513544;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)2142502913;
						if (num != 0)
						{
						}
						num = (short)521011200;
						if (num != 0)
						{
						}
						return this.WorkingCodeplug.RadioAlias;
					}
				}
				return null;
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x000A389C File Offset: 0x000A1A9C
		public string SerialNumber
		{
			get
			{
				short num = (short)1364979240;
				short num2 = num;
				num = (short)1499590184;
				switch (num2 == num)
				{
				}
				num = (short)1817509888;
				short num3 = num;
				num = (short)750256129;
				if (num != 0)
				{
				}
				num = (short)625737728;
				if (num != 0)
				{
				}
				return this.Radio.SerialNumber;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x000A3954 File Offset: 0x000A1B54
		public global::System.DateTime? LastProgrammedDate
		{
			get
			{
				while (this.WorkingCodeplug != null)
				{
					short num = (short)1605107712;
					short num2 = num;
					num = (short)748447793;
					short num3 = num;
					num = (short)1345611825;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1620705280;
						if (num != 0)
						{
						}
						num = (short)654966785;
						if (num != 0)
						{
						}
						return global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.ServerDateTimeToUI(this.WorkingCodeplug.LastProgrammedDate);
					}
				}
				return null;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x000A3A24 File Offset: 0x000A1C24
		public string RadioSoftwareVersion
		{
			get
			{
				while (this.CurrentCodeplug != null)
				{
					short num = (short)602996736;
					short num2 = num;
					num = (short)771256898;
					short num3 = num;
					num = (short)258961986;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1537998849;
						if (num != 0)
						{
						}
						num = (short)1708851200;
						if (num != 0)
						{
						}
						return this.CurrentCodeplug.FirmwareVersion;
					}
				}
				return null;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x000A3AE4 File Offset: 0x000A1CE4
		public string RadioCodeplugVersion
		{
			get
			{
				while (this.CurrentCodeplug != null)
				{
					short num = (short)665255936;
					short num2 = num;
					num = (short)629389886;
					short num3 = num;
					num = (short)516930110;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1695088641;
						if (num != 0)
						{
						}
						num = (short)431357952;
						if (num != 0)
						{
						}
						return this.CurrentCodeplug.CodeplugVersion;
					}
				}
				return null;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x000A3BA0 File Offset: 0x000A1DA0
		public byte[] RadioFlashCode
		{
			get
			{
				global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
				short num;
				for (;;)
				{
					apxcodeplug = (this.CurrentCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
					if (apxcodeplug == null)
					{
						break;
					}
					num = (short)1879579167;
					short num2 = num;
					num = (short)926620191;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_99;
					}
				}
				num = (short)1581842433;
				if (num != 0)
				{
				}
				num = (short)1577975808;
				short num3 = num;
				return null;
				IL_99:
				num = (short)773455872;
				if (num != 0)
				{
				}
				return apxcodeplug.AstroPurchasedFlashCode;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x000A3C64 File Offset: 0x000A1E64
		public string RadioCFS
		{
			get
			{
				global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug matrixCodeplug;
				short num;
				for (;;)
				{
					matrixCodeplug = (this.CurrentCodeplug as global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug);
					if (matrixCodeplug == null)
					{
						break;
					}
					num = (short)1636803791;
					short num2 = num;
					num = (short)369599695;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_98;
					}
				}
				num = (short)195559425;
				if (num != 0)
				{
				}
				num = (short)225574912;
				short num3 = num;
				return null;
				IL_98:
				num = (short)1663696896;
				if (num != 0)
				{
				}
				return matrixCodeplug.CFS;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x000A3D24 File Offset: 0x000A1F24
		public string ModelNumber
		{
			get
			{
				short num = (short)1709706359;
				short num2 = num;
				num = (short)1560218743;
				switch (num2 == num)
				{
				}
				num = (short)171638784;
				short num3 = num;
				num = (short)347799552;
				if (num != 0)
				{
				}
				num = (short)1909784577;
				if (num != 0)
				{
				}
				return this.Radio.ModelNumber;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x000A3DD8 File Offset: 0x000A1FD8
		public override string Comments
		{
			get
			{
				short num = (short)210559673;
				short num2 = num;
				num = (short)318628537;
				switch (num2 == num)
				{
				}
				num = (short)1012924416;
				short num3 = num;
				num = (short)976486401;
				if (num != 0)
				{
				}
				num = (short)577241088;
				if (num != 0)
				{
				}
				return this.Radio.Comments;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x000A3E8C File Offset: 0x000A208C
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x000A3F3C File Offset: 0x000A213C
		public string TemplateName
		{
			get
			{
				short num = (short)1263158439;
				short num2 = num;
				num = (short)1775649959;
				switch (num2 == num)
				{
				}
				num = (short)2058813440;
				short num3 = num;
				num = (short)366411777;
				if (num != 0)
				{
				}
				num = (short)1733165056;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)4587522;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_D2;
					case 1:
					{
						num = (short)1889533952;
						short num3 = num;
						this.d = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails.get_TemplateName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)386203648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					if (!(this.d != value))
					{
						return;
					}
					num = (short)692781057;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D2:
				num = (short)25568541;
				short num4 = num;
				num = (short)1135355165;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)493813761;
					if (num != 0)
					{
					}
					num = (short)1389494272;
					if (num != 0)
					{
					}
					break;
				}
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x000A4094 File Offset: 0x000A2294
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x000A4144 File Offset: 0x000A2344
		public string ConfigurationName
		{
			get
			{
				short num = (short)224349095;
				short num2 = num;
				num = (short)1284721575;
				switch (num2 == num)
				{
				}
				num = (short)1956839424;
				short num3 = num;
				num = (short)44367873;
				if (num != 0)
				{
				}
				num = (short)605945856;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1688207362;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_D4;
					case 1:
					{
						num = (short)940048384;
						short num3 = num;
						this.e = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails.get_ConfigurationName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)107937792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					if (!(this.e != value))
					{
						return;
					}
					num = (short)958857217;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D4:
				num = (short)2024123692;
				short num4 = num;
				num = (short)44543276;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2132869120;
					if (num != 0)
					{
					}
					num = (short)318242817;
					if (num != 0)
					{
					}
					break;
				}
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x000A4298 File Offset: 0x000A2498
		public virtual bool IsRadioInfoVisible
		{
			get
			{
				short num = (short)1404960771;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_139;
					case 1:
					{
						num = (short)1087307776;
						short num3 = num;
						global::System.Guid? templateUuid = this.Radio.CurrentCodeplug.TemplateUuid;
						num = (short)384434178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::System.Guid? templateUuid;
						if (templateUuid == null)
						{
							num = (short)960692224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					case 4:
						if (this.Radio.CurrentCodeplug != null)
						{
							num = (short)1406664705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						num = (short)2034171908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3C:
					num = (short)27262977;
					if (num != 0)
					{
					}
					if (string.IsNullOrEmpty(this.Radio.ModelNumber))
					{
						return false;
					}
					num = (short)331303763;
					short num4 = num;
					num = (short)1035225939;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)992083968;
						if (num != 0)
						{
						}
						num = (short)335282181;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_139:
				return this.Radio.WorkMode == global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Configuration;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x000A444C File Offset: 0x000A264C
		public bool IsFeatureSetVisible
		{
			get
			{
				short num = (short)67829760;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)425984001;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_6C;
						}
						continue;
					case 1:
						if (this.RadioFeatureOptionStatus != null)
						{
							num = (short)786825223;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 2:
					{
						global::System.Guid? configurationUuid;
						if (configurationUuid != null)
						{
							num = (short)1915158534;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 3:
						if (this.Radio.WorkingCodeplug != null)
						{
							goto IL_17B;
						}
						return false;
					case 4:
						num = (short)124190723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::System.Guid? configurationUuid = this.Radio.WorkingCodeplug.ConfigurationUuid;
						num = (short)1247019010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)908525569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						num = (short)757705110;
						short num3 = num;
						num = (short)182364566;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_17B;
						default:
							goto IL_1CE;
						}
						break;
					}
					}
					IL_6C:
					num = (short)374079488;
					short num4 = num;
					if (!string.IsNullOrEmpty(this.Radio.ModelNumber))
					{
						num = (short)1042546692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
					IL_17B:
					num = (short)189857797;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1CE:
				num = (short)428539904;
				if (num != 0)
				{
				}
				return this.RadioFeatureOptionStatus.Count > 0;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x000A4650 File Offset: 0x000A2850
		public bool IsExtendedFeatureSetVisible
		{
			get
			{
				short num = (short)529989632;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_44;
						}
						continue;
					case 1:
						if (this.ExtendedRadioFeatureOptionStatus != null)
						{
							num = (short)1229062151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 2:
					{
						global::System.Guid? configurationUuid;
						if (configurationUuid != null)
						{
							num = (short)363790342;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 3:
						if (this.Radio.WorkingCodeplug != null)
						{
							goto IL_14F;
						}
						return false;
					case 4:
						num = (short)59441155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::System.Guid? configurationUuid = this.Radio.WorkingCodeplug.ConfigurationUuid;
						num = (short)1790967810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)1227685889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						num = (short)547576070;
						short num3 = num;
						num = (short)726489350;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14F;
						default:
							goto IL_1A0;
						}
						break;
					}
					}
					IL_44:
					if (!string.IsNullOrEmpty(this.Radio.ModelNumber))
					{
						num = (short)1060831232;
						short num4 = num;
						num = (short)432013316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
					IL_14F:
					num = (short)1921843205;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1A0:
				num = (short)2136604673;
				if (num != 0)
				{
				}
				num = (short)315293696;
				if (num != 0)
				{
				}
				return this.ExtendedRadioFeatureOptionStatus.Count > 0;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x000A4848 File Offset: 0x000A2A48
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily ProductFamily
		{
			get
			{
				short num = (short)1537671168;
				short num2 = num;
				num = (short)481352564;
				short num3 = num;
				num = (short)2017778548;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)809304064;
					if (num != 0)
					{
					}
					if (this.Radio.ProductFamily == null)
					{
						num = (short)418971649;
						if (num != 0)
						{
						}
						return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.None;
					}
					break;
				}
				return (global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily)this.Radio.ProductFamily.Value;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x000A491C File Offset: 0x000A2B1C
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x000A49CC File Offset: 0x000A2BCC
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob> HistoricalJobs
		{
			get
			{
				short num = (short)70688409;
				short num2 = num;
				num = (short)1457495705;
				switch (num2 == num)
				{
				}
				num = (short)1465384960;
				if (num != 0)
				{
				}
				num = (short)202440704;
				short num3 = num;
				num = (short)1228734465;
				if (num != 0)
				{
				}
				return this.allJobs;
			}
			set
			{
				short num = (short)1583742977;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)1533280259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_14;
					case 2:
						this.allJobs = value;
						num = (short)94044160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails.get_HistoricalJobs())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)550961153;
						if (num != 0)
						{
						}
						num = (short)1536294916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_115;
					}
					goto IL_38;
					IL_14:
					switch (0)
					{
					case 0:
					{
						IL_38:
						num = (short)1292012937;
						short num3 = num;
						num = (short)1253215625;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
							num = (short)229703680;
							if (num != 0)
							{
							}
							if (value == null)
							{
								return;
							}
							num = (short)1827602434;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						break;
					}
					}
				}
				IL_115:
				num = (short)890830848;
				short num4 = num;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x000A4B5C File Offset: 0x000A2D5C
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x000A4C08 File Offset: 0x000A2E08
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus> RadioFeatureOptionStatus
		{
			get
			{
				short num = (short)2062155777;
				if (num != 0)
				{
				}
				num = (short)1364947850;
				short num2 = num;
				num = (short)1701540746;
				switch (num2 == num)
				{
				}
				num = (short)1182859264;
				short num3 = num;
				num = (short)469368832;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)275383921;
				short num2 = num;
				num = (short)1072694897;
				int num4;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_B1:
					switch (0)
					{
					case 0:
						goto IL_CD;
					}
					break;
				default:
				{
					num = (short)259063808;
					short num3 = num;
					num = (short)1815412736;
					if (num != 0)
					{
					}
					num = (short)767557633;
					if (num != 0)
					{
					}
					num = (short)1308557312;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				}
				for (;;)
				{
					IL_BB:
					switch (num4)
					{
					case 0:
						goto IL_B1;
					case 1:
						goto IL_13F;
					case 2:
						this.b = value;
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails.get_RadioFeatureOptionStatus())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)98566145;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CD;
				}
				IL_13F:
				return;
				IL_CD:
				if (this.b != value)
				{
					num = (short)1534656514;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_BB;
				}
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x000A4D58 File Offset: 0x000A2F58
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x000A4E08 File Offset: 0x000A3008
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus> ExtendedRadioFeatureOptionStatus
		{
			get
			{
				short num = (short)1041002864;
				short num2 = num;
				num = (short)1071083888;
				switch (num2 == num)
				{
				}
				num = (short)2105475073;
				if (num != 0)
				{
				}
				num = (short)698548224;
				short num3 = num;
				num = (short)447152128;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)234889470;
				short num2 = num;
				num = (short)102572286;
				int num4;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_8B:
					switch (0)
					{
					case 0:
						goto IL_A7;
					}
					break;
				default:
				{
					num = (short)1588723712;
					short num3 = num;
					num = (short)861601792;
					if (num != 0)
					{
					}
					num = (short)728432640;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				}
				for (;;)
				{
					IL_95:
					switch (num4)
					{
					case 0:
						goto IL_8B;
					case 1:
						goto IL_144;
					case 2:
						num = (short)136314881;
						if (num != 0)
						{
						}
						this.c = value;
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails.get_ExtendedRadioFeatureOptionStatus())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)907673601;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A7;
				}
				IL_144:
				return;
				IL_A7:
				if (this.c != value)
				{
					num = (short)101842946;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_95;
				}
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x000A4F5C File Offset: 0x000A315C
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x000A5008 File Offset: 0x000A3208
		public long RadioUIChangeIndicator
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1325913636;
				short num2 = num;
				num = (short)562157092;
				switch (num2 == num)
				{
				}
				num = (short)1478033408;
				if (num != 0)
				{
				}
				num = (short)1672347648;
				short num3 = num;
				num = (short)1094975489;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1383727105;
				if (num != 0)
				{
				}
				num = (short)585934737;
				short num2 = num;
				num = (short)1482532753;
				switch (num2 == num)
				{
				}
				num = (short)1045299200;
				short num3 = num;
				num = (short)2118451200;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x000A50B8 File Offset: 0x000A32B8
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x000A5168 File Offset: 0x000A3368
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob> allJobs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)239861761;
				if (num != 0)
				{
				}
				num = (short)560635311;
				short num2 = num;
				num = (short)1674026415;
				switch (num2 == num)
				{
				}
				num = (short)985923584;
				short num3 = num;
				num = (short)1243086848;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1798146116;
				short num2 = num;
				num = (short)1574471748;
				switch (num2 == num)
				{
				}
				num = (short)893255680;
				if (num != 0)
				{
				}
				num = (short)84672512;
				short num3 = num;
				num = (short)474349569;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x000A521C File Offset: 0x000A341C
		protected global::Motorola.CommonCPS.Server.EntityModel.Codeplug CurrentCodeplug
		{
			get
			{
				short num = (short)1426063361;
				if (num != 0)
				{
				}
				num = (short)1178132803;
				short num2 = num;
				num = (short)1123737923;
				switch (num2 == num)
				{
				}
				num = (short)1641218048;
				short num3 = num;
				num = (short)931135488;
				if (num != 0)
				{
				}
				return this.Radio.CurrentCodeplug;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x000A52D0 File Offset: 0x000A34D0
		protected global::Motorola.CommonCPS.Server.EntityModel.Codeplug WorkingCodeplug
		{
			get
			{
				short num = (short)1304004241;
				short num2 = num;
				num = (short)1947829905;
				switch (num2 == num)
				{
				}
				num = (short)20709377;
				if (num != 0)
				{
				}
				num = (short)2041774080;
				short num3 = num;
				num = (short)1034551296;
				if (num != 0)
				{
				}
				return this.Radio.WorkingCodeplug;
			}
		}

		// Token: 0x040003EB RID: 1003
		private global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob a;

		// Token: 0x040003EC RID: 1004
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus> b;

		// Token: 0x040003ED RID: 1005
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus> c;

		// Token: 0x040003EE RID: 1006
		private string d;

		// Token: 0x040003EF RID: 1007
		private string e;

		// Token: 0x040003F0 RID: 1008
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.EntityModel.Radio f;

		// Token: 0x040003F1 RID: 1009
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private long g;

		// Token: 0x040003F2 RID: 1010
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob> h;
	}
}
