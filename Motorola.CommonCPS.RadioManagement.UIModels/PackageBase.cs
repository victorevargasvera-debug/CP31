using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq.Expressions;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000044 RID: 68
	public abstract class PackageBase : global::Motorola.CommonCPS.RadioManagement.UIModels.EntityWrapper<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary>, global::System.ComponentModel.IDataErrorInfo
	{
		// Token: 0x06000196 RID: 406 RVA: 0x00017330 File Offset: 0x00015530
		protected PackageBase(global::Motorola.CommonCPS.Server.EntityModel.PackageSummary summary) : base(summary)
		{
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00017344 File Offset: 0x00015544
		string global::System.ComponentModel.IDataErrorInfo.Error
		{
			get
			{
				short num = (short)1701048849;
				short num2 = num;
				num = (short)1725428241;
				switch (num2 == num)
				{
				}
				num = (short)1881538560;
				short num3 = num;
				num = (short)696647681;
				if (num != 0)
				{
				}
				num = (short)1241382912;
				if (num != 0)
				{
				}
				return string.Empty;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000198 RID: 408 RVA: 0x000173F4 File Offset: 0x000155F4
		// (set) Token: 0x06000199 RID: 409 RVA: 0x000174B0 File Offset: 0x000156B0
		public int ConfigurationReferences
		{
			get
			{
				short num = (short)1993474049;
				if (num != 0)
				{
				}
				num = (short)1083082189;
				short num2 = num;
				num = (short)2032502221;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1090060288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)753074176;
				if (num != 0)
				{
				}
				return this.SummaryEntity.ReferenceCount.GetValueOrDefault();
			}
			set
			{
				short num = (short)1938685953;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_94;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
					{
						num = (short)1957285804;
						short num3 = num;
						num = (short)840028076;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_94;
						default:
							goto IL_127;
						}
						break;
					}
					}
					IL_30:
					num = (short)1587412992;
					short num4 = num;
					int? referenceCount = this.SummaryEntity.ReferenceCount;
					if (!(value == referenceCount.GetValueOrDefault() & referenceCount != null))
					{
						num = (short)1801912320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_94:
					this.SummaryEntity.ReferenceCount = new int?(value);
					base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase.get_ConfigurationReferences())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)791216130;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_127:
				num = (short)75628544;
				if (num != 0)
				{
				}
				num = (short)2054094849;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00017624 File Offset: 0x00015824
		// (set) Token: 0x0600019B RID: 411 RVA: 0x000176F8 File Offset: 0x000158F8
		public override string Comments
		{
			get
			{
				if (!string.IsNullOrWhiteSpace(this.SummaryEntity.Comment))
				{
					short num = (short)1516043389;
					short num2 = num;
					num = (short)1821899901;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1214709761;
						if (num != 0)
						{
						}
						num = (short)196214784;
						short num3 = num;
						num = (short)2109538304;
						if (num != 0)
						{
						}
						break;
					}
					}
					return this.SummaryEntity.Comment.Trim();
				}
				return string.Empty;
			}
			set
			{
				short num = (short)1313800196;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_6D;
					case 2:
						num = (short)1389756419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)679131839;
						short num3 = num;
						num = (short)1713158847;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num = (short)766836736;
							if (num != 0)
							{
							}
							num = (short)1366753280;
							short num4 = num;
							if (string.IsNullOrEmpty(value))
							{
								num = (short)1335951365;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_6D;
						}
						}
						break;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 5:
						num = (short)470220801;
						if (num != 0)
						{
						}
						value = string.Empty;
						num = (short)1455030273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3D:
					if (value != this.SummaryEntity.Comment)
					{
						num = (short)939982850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_6D:
					this.SummaryEntity.Comment = value.Trim();
					base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase.get_Comments())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)573898752;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600019C RID: 412 RVA: 0x000178D8 File Offset: 0x00015AD8
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00017A8C File Offset: 0x00015C8C
		public string Name
		{
			get
			{
				short num = (short)600899588;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (string.IsNullOrEmpty(this.SummaryEntity.PackageName))
						{
							num = (short)519372801;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19B;
					case 1:
						goto IL_CB;
					case 2:
					{
						num = (short)551016302;
						short num3 = num;
						num = (short)732944238;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D0;
						default:
						{
							num = (short)1325465601;
							if (num != 0)
							{
							}
							num = (short)1723924480;
							if (num != 0)
							{
							}
							string packageLanguage = (this.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary).PackageLanguage;
							num = (short)1170866179;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
					{
						string packageLanguage;
						if (!string.IsNullOrEmpty(packageLanguage))
						{
							num = (short)1051983877;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D0;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 5:
					{
						string packageLanguage;
						return packageLanguage;
					}
					}
					IL_3D:
					if (this.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary)
					{
						num = (short)1750138882;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1250623488;
						short num4 = num;
						num = (short)454492160;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_CB:
				return string.Empty;
				IL_D0:
				return string.Empty;
				IL_19B:
				return this.SummaryEntity.PackageName;
			}
			set
			{
				short num = (short)1641873416;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string text;
					switch (num2)
					{
					case 0:
						if (value != this.SummaryEntity.PackageName)
						{
							num = (short)1628241925;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						text = value;
						goto IL_1E0;
					case 2:
						goto IL_220;
					case 3:
						goto IL_177;
					case 4:
						num = (short)1324613632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						this.SummaryEntity.PackageName = value;
						num = (short)242941955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)172490753;
						if (num != 0)
						{
						}
						if (this.SummaryEntity != null)
						{
							num = (short)730398724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
						text = string.Empty;
						goto IL_1E0;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_50;
						}
						continue;
					case 9:
					{
						num = (short)1788268487;
						short num3 = num;
						num = (short)175951815;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E2;
						default:
							num = (short)1989410816;
							if (num != 0)
							{
							}
							num = (short)1955135489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						if (this.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary)
						{
							num = (short)427425794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1502806022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_50:
					if (!string.IsNullOrEmpty(value))
					{
						num = (short)399966217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)318636039;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E2:
					num = (short)968294410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E0:
					value = text;
					goto IL_1E2;
				}
				IL_177:
				return;
				IL_220:
				num = (short)1844248576;
				short num4 = num;
				(this.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary).PackageLanguage = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00017CE8 File Offset: 0x00015EE8
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00017DA0 File Offset: 0x00015FA0
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)2114846374;
				short num2 = num;
				num = (short)1418067622;
				switch (num2 == num)
				{
				}
				num = (short)1645674496;
				short num3 = num;
				num = (short)519766016;
				if (num != 0)
				{
				}
				num = (short)215941121;
				if (num != 0)
				{
				}
				return new global::System.Guid?(this.SummaryEntity.Uuid);
			}
			set
			{
				short num = (short)4128769;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_7D;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
					{
						num = (short)979324377;
						short num3 = num;
						num = (short)1292586457;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7D;
						default:
							goto IL_DE;
						}
						break;
					}
					}
					IL_30:
					num = (short)849870848;
					short num4 = num;
					if (value != null)
					{
						num = (short)1191641088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_7D:
					this.SummaryEntity.Uuid = value.Value;
					num = (short)300285954;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_DE:
				num = (short)321060865;
				if (num != 0)
				{
				}
				num = (short)1176436736;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00017ECC File Offset: 0x000160CC
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00017FA4 File Offset: 0x000161A4
		public virtual int References
		{
			get
			{
				if (this.SummaryEntity.ReferenceCount != null)
				{
					short num = (short)609288193;
					if (num != 0)
					{
					}
					num = (short)98544735;
					short num2 = num;
					num = (short)970632287;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2121334784;
						short num3 = num;
						num = (short)185008128;
						if (num != 0)
						{
						}
						break;
					}
					}
					return this.SummaryEntity.ReferenceCount.Value;
				}
				return 0;
			}
			set
			{
				short num = (short)1626679239;
				short num2 = num;
				num = (short)1000548295;
				switch (num2 == num)
				{
				}
				num = (short)316669952;
				short num3 = num;
				num = (short)1888747521;
				if (num != 0)
				{
				}
				num = (short)1257111552;
				if (num != 0)
				{
				}
				this.SummaryEntity.ReferenceCount = new int?(value);
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0001805C File Offset: 0x0001625C
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00018114 File Offset: 0x00016314
		public global::System.Guid Uuid
		{
			get
			{
				short num = (short)417737688;
				short num2 = num;
				num = (short)943795160;
				switch (num2 == num)
				{
				}
				num = (short)949747712;
				short num3 = num;
				num = (short)1309409281;
				if (num != 0)
				{
				}
				num = (short)848429056;
				if (num != 0)
				{
				}
				return this.SummaryEntity.Uuid;
			}
			set
			{
				short num = (short)1187852510;
				short num2 = num;
				num = (short)1049899230;
				switch (num2 == num)
				{
				}
				num = (short)952631296;
				short num3 = num;
				num = (short)1253310464;
				if (num != 0)
				{
				}
				num = (short)2049572865;
				if (num != 0)
				{
				}
				this.SummaryEntity.Uuid = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x000181C8 File Offset: 0x000163C8
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x000182D4 File Offset: 0x000164D4
		public string ImportTime
		{
			get
			{
				int a_ = 8;
				short num;
				if (this.SummaryEntity.CreatedDate != null)
				{
					num = (short)1716680906;
					short num2 = num;
					num = (short)1010006218;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)404946944;
						if (num != 0)
						{
						}
						num = (short)1009778688;
						short num3 = num;
						break;
					}
					}
					return this.SummaryEntity.CreatedDate.Value.ToLocalTime().ToString(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("т", a_), global::System.Globalization.CultureInfo.InvariantCulture);
				}
				num = (short)1839661057;
				if (num != 0)
				{
				}
				return string.Empty;
			}
			set
			{
				short num = (short)1553924099;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_71;
					case 1:
					{
						num = (short)709156350;
						short num3 = num;
						num = (short)1491852798;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5D;
						case 1:
							break;
						default:
						{
							num = (short)206897152;
							short num4 = num;
							break;
						}
						}
						num = (short)2133000193;
						if (num != 0)
						{
						}
						num = (short)564068352;
						if (num != 0)
						{
						}
						num = (short)1399128066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (value != this.a)
						{
							num = (short)1855062020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					case 4:
						goto IL_158;
					}
					IL_39:
					if (value != null)
					{
						num = (short)1740767233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.a = string.Empty;
					IL_5D:
					num = (short)1145962496;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_71:
				return;
				IL_158:
				this.a = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00018440 File Offset: 0x00016640
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x000184F4 File Offset: 0x000166F4
		public byte[] Timestamp
		{
			get
			{
				short num = (short)1343488001;
				if (num != 0)
				{
				}
				num = (short)2098342856;
				short num2 = num;
				num = (short)1422863304;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1191182336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)872808448;
				if (num != 0)
				{
				}
				return this.SummaryEntity.Timestamp;
			}
			set
			{
				short num = (short)1495323196;
				short num2 = num;
				num = (short)1388302908;
				switch (num2 == num)
				{
				}
				num = (short)637665280;
				short num3 = num;
				num = (short)2040791041;
				if (num != 0)
				{
				}
				num = (short)1979318272;
				if (num != 0)
				{
				}
				this.SummaryEntity.Timestamp = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x000185AC File Offset: 0x000167AC
		protected global::Motorola.CommonCPS.Server.EntityModel.PackageSummary SummaryEntity
		{
			get
			{
				short num = (short)329646081;
				if (num != 0)
				{
				}
				num = (short)1877373250;
				short num2 = num;
				num = (short)732918082;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1131806720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)888537088;
				if (num != 0)
				{
				}
				return base.Entity;
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00018658 File Offset: 0x00016858
		public override string ToString()
		{
			short num = (short)974122401;
			short num2 = num;
			num = (short)1503391137;
			switch (num2 == num)
			{
			}
			num = (short)535166976;
			short num3 = num;
			num = (short)1841037312;
			if (num != 0)
			{
			}
			num = (short)3276801;
			if (num != 0)
			{
			}
			return this.Name;
		}

		// Token: 0x040000BB RID: 187
		private string a;
	}
}
