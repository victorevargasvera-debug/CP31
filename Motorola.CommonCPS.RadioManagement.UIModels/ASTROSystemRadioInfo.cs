using System;
using System.Globalization;
using System.Linq.Expressions;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000F0 RID: 240
	public class ASTROSystemRadioInfo : global::Motorola.CommonCPS.RadioManagement.UIModels.EntityWrapper<global::Motorola.CommonCPS.Server.EntityModel.APXSystemRadioInfoSummary>
	{
		// Token: 0x06000BA5 RID: 2981 RVA: 0x000AF6F4 File Offset: 0x000AD8F4
		public ASTROSystemRadioInfo() : base(new global::Motorola.CommonCPS.Server.EntityModel.APXSystemRadioInfoSummary())
		{
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x000AF70C File Offset: 0x000AD90C
		public ASTROSystemRadioInfo(global::Motorola.CommonCPS.Server.EntityModel.APXSystemRadioInfoSummary summary) : base(summary ?? new global::Motorola.CommonCPS.Server.EntityModel.APXSystemRadioInfoSummary())
		{
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x000AF730 File Offset: 0x000AD930
		// (set) Token: 0x06000BA8 RID: 2984 RVA: 0x000AF7E4 File Offset: 0x000AD9E4
		public string RadioAlias
		{
			get
			{
				short num = (short)921471498;
				short num2 = num;
				num = (short)243632650;
				switch (num2 == num)
				{
				}
				num = (short)462815233;
				if (num != 0)
				{
				}
				num = (short)360251392;
				if (num != 0)
				{
				}
				num = (short)1320812544;
				short num3 = num;
				return this.EntitySummary.RadioAlias;
			}
			set
			{
				short num = (short)1683095553;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1912059692;
						short num3 = num;
						num = (short)828946220;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)544407553;
							if (num != 0)
							{
							}
							num = (short)1084686336;
							if (num != 0)
							{
							}
							num = (short)1466105856;
							short num4 = num;
							break;
						}
						}
						this.EntitySummary.RadioAlias = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo.get_RadioAlias())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)367460354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						return;
					}
					IL_30:
					if (!(value != this.EntitySummary.RadioAlias))
					{
						break;
					}
					num = (short)1411121152;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x000AF944 File Offset: 0x000ADB44
		// (set) Token: 0x06000BAA RID: 2986 RVA: 0x000AF9F8 File Offset: 0x000ADBF8
		public string SerialNumber
		{
			get
			{
				short num = (short)1477425754;
				short num2 = num;
				num = (short)126466650;
				switch (num2 == num)
				{
				}
				num = (short)2077360129;
				if (num != 0)
				{
				}
				num = (short)483590144;
				if (num != 0)
				{
				}
				num = (short)2102853632;
				short num3 = num;
				return this.EntitySummary.SerialNumber;
			}
			set
			{
				short num = (short)12648449;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)646571256;
						short num3 = num;
						num = (short)860939512;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)279379968;
							if (num != 0)
							{
							}
							break;
						}
						num = (short)529858560;
						short num4 = num;
						this.EntitySummary.SerialNumber = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo.get_SerialNumber())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)903151618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
						goto IL_12A;
					}
					IL_31:
					if (!(value != this.EntitySummary.SerialNumber))
					{
						return;
					}
					num = (short)177405952;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12A:
				num = (short)1651048449;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x000AFB58 File Offset: 0x000ADD58
		// (set) Token: 0x06000BAC RID: 2988 RVA: 0x000AFC10 File Offset: 0x000ADE10
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)1640597007;
				short num2 = num;
				num = (short)914589199;
				switch (num2 == num)
				{
				}
				num = (short)88408065;
				if (num != 0)
				{
				}
				num = (short)1337982976;
				if (num != 0)
				{
				}
				num = (short)943521792;
				short num3 = num;
				return new global::System.Guid?(this.EntitySummary.RadioUuid);
			}
			set
			{
				short num = (short)1669922817;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1597243393;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						num = (short)187416687;
						short num3 = num;
						num = (short)507887727;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)1276903424;
							if (num != 0)
							{
							}
							num = (short)1431109632;
							short num4 = num;
							break;
						}
						}
						this.EntitySummary.RadioUuid = value.Value;
						num = (short)1213857794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_57;
						}
						continue;
					case 2:
						return;
					}
					IL_57:
					if (value == null)
					{
						break;
					}
					num = (short)195756032;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000BAD RID: 2989 RVA: 0x000AFD34 File Offset: 0x000ADF34
		// (set) Token: 0x06000BAE RID: 2990 RVA: 0x000AFE10 File Offset: 0x000AE010
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus? RadioStatus
		{
			get
			{
				short num;
				int? radioStatus;
				for (;;)
				{
					num = (short)657522689;
					if (num != 0)
					{
					}
					radioStatus = this.EntitySummary.RadioStatus;
					if (radioStatus == null)
					{
						num = (short)690989122;
						short num2 = num;
						num = (short)1261414466;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						case 1:
							goto IL_A1;
						}
						break;
					}
					goto IL_C0;
				}
				num = (short)1538064384;
				short num3 = num;
				IL_A1:
				num = (short)6750208;
				if (num != 0)
				{
				}
				return null;
				IL_C0:
				return new global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus?((global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus)radioStatus.GetValueOrDefault());
			}
			set
			{
				short num = (short)960102400;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)683540481;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_72;
					}
					int? num4;
					for (;;)
					{
						IL_4F:
						int? num3;
						int? num5;
						int? num6;
						switch (num2)
						{
						case 0:
							return;
						case 1:
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus? radioStatus;
							num3 = new int?((int)radioStatus.GetValueOrDefault());
							goto IL_1A8;
						}
						case 2:
							goto IL_FB;
						case 3:
							if (!(num4.GetValueOrDefault() == num5.GetValueOrDefault() & num4 != null == (num5 != null)))
							{
								num = (short)614334470;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 4:
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus? radioStatus;
							if (radioStatus == null)
							{
								num = (short)911933442;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1053687809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num3 = num4;
							goto IL_1A8;
						case 6:
							this.EntitySummary.RadioStatus = num6;
							base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo.get_RadioStatus())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1531510784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_72;
						IL_1A8:
						num6 = num3;
						num4 = this.EntitySummary.RadioStatus;
						num5 = num6;
						num = (short)998375427;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_FB:
					num = (short)1045299200;
					short num7 = num;
					num4 = null;
					goto IL_12F;
					IL_72:
					num = (short)1839946190;
					short num8 = num;
					num = (short)1401248206;
					switch ((num8 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_12F:
						num = (short)1371144197;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_4F;
					default:
					{
						num = (short)84934656;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus? radioStatus = value;
						num = (short)100597764;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_4F;
					}
					}
					break;
				}
				}
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000BAF RID: 2991 RVA: 0x000B0058 File Offset: 0x000AE258
		// (set) Token: 0x06000BB0 RID: 2992 RVA: 0x000B0110 File Offset: 0x000AE310
		public int SystemCount
		{
			get
			{
				short num = (short)589778668;
				short num2 = num;
				num = (short)726617836;
				switch (num2 == num)
				{
				}
				num = (short)72810497;
				if (num != 0)
				{
				}
				num = (short)1527054336;
				if (num != 0)
				{
				}
				num = (short)1457389568;
				short num3 = num;
				return this.EntitySummary.SystemCount;
			}
			set
			{
				short num = (short)650248193;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1813446656;
					short num3 = num;
					switch (num2)
					{
					case 0:
						IL_80:
						num = (short)790364161;
						if (num != 0)
						{
						}
						this.EntitySummary.SystemCount = value;
						base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo.get_SystemCount())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1687289858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					case 2:
						goto IL_105;
					}
					IL_5A:
					if (value != this.EntitySummary.SystemCount)
					{
						num = (short)728170496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_105:
					num = (short)1566662714;
					short num4 = num;
					num = (short)1384996922;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_80;
					default:
						goto IL_13A;
					}
				}
				IL_13A:
				num = (short)1904672768;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x000B0270 File Offset: 0x000AE470
		// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x000B0328 File Offset: 0x000AE528
		public string TemplateName
		{
			get
			{
				short num = (short)238743049;
				short num2 = num;
				num = (short)132050441;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1509490688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)391053313;
				if (num != 0)
				{
				}
				num = (short)415301632;
				if (num != 0)
				{
				}
				return this.EntitySummary.TemplateName;
			}
			set
			{
				short num = (short)1491337217;
				if (num != 0)
				{
				}
				if (value == this.EntitySummary.TemplateName)
				{
					for (;;)
					{
						num = (short)2056348301;
						short num2 = num;
						num = (short)1497653901;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_70;
						}
					}
					IL_70:
					num = (short)1800798208;
					short num3 = num;
					num = (short)1412235264;
					if (num != 0)
					{
					}
					return;
				}
				this.EntitySummary.TemplateName = value;
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo.get_TemplateName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x000B0428 File Offset: 0x000AE628
		// (set) Token: 0x06000BB4 RID: 2996 RVA: 0x000B04DC File Offset: 0x000AE6DC
		public string ConfigurationName
		{
			get
			{
				short num = (short)1785302164;
				short num2 = num;
				num = (short)483953812;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1840971776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)799145984;
				if (num != 0)
				{
				}
				num = (short)717684737;
				if (num != 0)
				{
				}
				return this.EntitySummary.ConfigurationName;
			}
			set
			{
				if (value == this.EntitySummary.ConfigurationName)
				{
					short num;
					for (;;)
					{
						num = (short)2137238369;
						short num2 = num;
						num = (short)1583655777;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_4C;
						}
					}
					IL_4C:
					num = (short)477036545;
					if (num != 0)
					{
					}
					num = (short)1062928384;
					short num3 = num;
					num = (short)344784896;
					if (num != 0)
					{
					}
					return;
				}
				this.EntitySummary.ConfigurationName = value;
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo.get_ConfigurationName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x000B05DC File Offset: 0x000AE7DC
		public string SystemName
		{
			get
			{
				short num = (short)1960050689;
				if (num != 0)
				{
				}
				num = (short)237305856;
				short num2 = num;
				num = (short)1584255142;
				short num3 = num;
				num = (short)1251397798;
				switch (num3 == num)
				{
				}
				num = (short)378732544;
				if (num != 0)
				{
				}
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ASTROSystem_PeudoSystemName, this.SystemCount);
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x000B06A0 File Offset: 0x000AE8A0
		public string RadioID
		{
			get
			{
				int a_ = 5;
				short num = (short)1674223521;
				short num2 = num;
				num = (short)1457102753;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1684733952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1660485632;
				if (num != 0)
				{
				}
				num = (short)496762881;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("渿汁橃", a_);
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x000B0760 File Offset: 0x000AE960
		public string SystemId
		{
			get
			{
				int a_ = 14;
				short num = (short)890244625;
				short num2 = num;
				num = (short)1072172561;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1116209152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1589837825;
				if (num != 0)
				{
				}
				num = (short)396099584;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("杈敊捌", a_);
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x000B0820 File Offset: 0x000AEA20
		public string SystemType
		{
			get
			{
				int a_ = 10;
				short num = (short)2028503230;
				short num2 = num;
				num = (short)1280999614;
				switch (num2 == num)
				{
				default:
				{
					num = (short)97648640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)758644736;
				if (num != 0)
				{
				}
				num = (short)620625921;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("歄楆杈", a_);
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x000B08E0 File Offset: 0x000AEAE0
		public string SubSystemType
		{
			get
			{
				int a_ = 18;
				short num = (short)422079449;
				short num2 = num;
				num = (short)1349282777;
				switch (num2 == num)
				{
				}
				num = (short)1243348992;
				if (num != 0)
				{
				}
				num = (short)1385627649;
				if (num != 0)
				{
				}
				num = (short)318046208;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("捌慎罐", a_);
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x000B09A0 File Offset: 0x000AEBA0
		private global::Motorola.CommonCPS.Server.EntityModel.APXSystemRadioInfoSummary EntitySummary
		{
			get
			{
				short num = (short)887969167;
				short num2 = num;
				num = (short)1247630735;
				switch (num2 == num)
				{
				}
				num = (short)1476657153;
				if (num != 0)
				{
				}
				num = (short)1052770304;
				if (num != 0)
				{
				}
				num = (short)1750204416;
				short num3 = num;
				return base.Entity;
			}
		}
	}
}
