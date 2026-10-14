using System;
using System.Collections;
using System.Linq.Expressions;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000B0 RID: 176
	public abstract class JobBase : global::Motorola.CommonCPS.RadioManagement.UIModels.EntityWrapper<global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity>
	{
		// Token: 0x060006A7 RID: 1703 RVA: 0x00060668 File Offset: 0x0005E868
		public JobBase(global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity emJobSum) : base(emJobSum ?? new global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity())
		{
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x0006068C File Offset: 0x0005E88C
		// (set) Token: 0x060006A9 RID: 1705 RVA: 0x00060744 File Offset: 0x0005E944
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)1389366354;
				short num2 = num;
				num = (short)2117340242;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1897136128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1884356609;
				if (num != 0)
				{
				}
				num = (short)745078784;
				if (num != 0)
				{
				}
				return new global::System.Guid?(this.emJobSum.Uuid);
			}
			set
			{
				short num = (short)1376142344;
				short num2 = num;
				num = (short)670319624;
				switch (num2 == num)
				{
				default:
				{
					num = (short)852099072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)830078977;
				if (num != 0)
				{
				}
				num = (short)535625728;
				if (num != 0)
				{
				}
				this.emJobSum.Uuid = value.Value;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x00060800 File Offset: 0x0005EA00
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x000608B4 File Offset: 0x0005EAB4
		public string Name
		{
			get
			{
				short num = (short)689910927;
				short num2 = num;
				num = (short)375338127;
				switch (num2 == num)
				{
				default:
				{
					num = (short)815857664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1513553920;
				if (num != 0)
				{
				}
				num = (short)743112705;
				if (num != 0)
				{
				}
				return this.emJobSum.Name;
			}
			set
			{
				short num = (short)1116909329;
				short num2 = num;
				num = (short)214216465;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_103:
					base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase.get_Name())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)951517187;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1739980801;
					if (num != 0)
					{
					}
					num = (short)1258291200;
					if (num != 0)
					{
					}
					num = (short)1421017089;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_D5;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_AB;
						}
						continue;
					case 2:
						goto IL_193;
					case 3:
						goto IL_14E;
					case 4:
						if (!base.IsLoading)
						{
							num = (short)1526726658;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_AB:
					if (value == this.emJobSum.Name)
					{
						num = (short)1854144512;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						this.emJobSum.Name = value;
						num = (short)2089811972;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				IL_D5:
				num = (short)2139684864;
				short num4 = num;
				return;
				IL_14E:
				return;
				IL_193:
				goto IL_103;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x00060A5C File Offset: 0x0005EC5C
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobType? JobType
		{
			get
			{
				short num = (short)306642945;
				if (num != 0)
				{
				}
				num = (short)497483776;
				short num2 = num;
				num = (short)302945866;
				short num3 = num;
				num = (short)44078666;
				switch (num3 == num)
				{
				}
				num = (short)457310208;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.Server.CommonDBConstants.JobType?(this.emJobSum.JobType);
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x00060B14 File Offset: 0x0005ED14
		public global::System.Guid? JobContainerSummaryUUID
		{
			get
			{
				short num = (short)215652324;
				short num2 = num;
				num = (short)1194760164;
				switch (num2 == num)
				{
				default:
				{
					num = (short)351404032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)316276737;
				if (num != 0)
				{
				}
				num = (short)2145255424;
				if (num != 0)
				{
				}
				return new global::System.Guid?(this.emJobSum.JobContainerUuid);
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x00060BD0 File Offset: 0x0005EDD0
		// (set) Token: 0x060006AF RID: 1711 RVA: 0x00060C80 File Offset: 0x0005EE80
		public global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? UIJobStatus
		{
			get
			{
				short num = (short)1232862584;
				short num2 = num;
				num = (short)851705208;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1986461696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)5111809;
				if (num != 0)
				{
				}
				num = (short)447152128;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num2;
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_24;
					}
					int num;
					global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? uijobStatus;
					global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? uijobStatus2;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							goto IL_79;
						case 1:
							if (uijobStatus.GetValueOrDefault() == uijobStatus2.GetValueOrDefault() & uijobStatus != null == (uijobStatus2 != null))
							{
								num2 = (short)2129395712;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							this.a = value;
							num2 = (short)1933115396;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 2:
							base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase.get_UIJobStatus())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num2 = (short)822738947;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 3:
							goto IL_C9;
						case 4:
							num2 = (short)74579969;
							if (num2 != 0)
							{
							}
							if (!base.IsLoading)
							{
								num2 = (short)575275010;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return;
						}
						goto IL_24;
					}
					IL_79:
					num2 = (short)1783192252;
					short num3 = num2;
					num2 = (short)356407996;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_170;
					}
					IL_24:
					uijobStatus = value;
					uijobStatus2 = this.a;
					num2 = (short)301203457;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_C9:
				return;
				IL_170:
				num2 = (short)1711079424;
				short num4 = num2;
				num2 = (short)1492779008;
				if (num2 != 0)
				{
				}
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x00060E40 File Offset: 0x0005F040
		public global::System.DateTime? ExecutedDate
		{
			get
			{
				short num = (short)2047846383;
				short num2 = num;
				num = (short)1269540847;
				switch (num2 == num)
				{
				default:
				{
					num = (short)168558592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)385941505;
				if (num != 0)
				{
				}
				num = (short)1627717632;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.ServerDateTimeToUI(this.emJobSum.ExecutedDate);
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00060EFC File Offset: 0x0005F0FC
		public string ErrorCode
		{
			get
			{
				short num = (short)192978437;
				short num2 = num;
				num = (short)1411685893;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)264896513;
					if (num != 0)
					{
					}
					num = (short)1497235456;
					if (num != 0)
					{
					}
					if (this.emJobSum.ErrorCode == null)
					{
						num = (short)1917976576;
						short num3 = num;
						return string.Empty;
					}
					break;
				}
				return this.emJobSum.ErrorCode.ToString();
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x00060FD8 File Offset: 0x0005F1D8
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x00061088 File Offset: 0x0005F288
		public string Reason
		{
			get
			{
				short num = (short)131255075;
				short num2 = num;
				num = (short)205048611;
				switch (num2 == num)
				{
				default:
				{
					num = (short)373686272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1379008512;
				if (num != 0)
				{
				}
				num = (short)2122776577;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1053594121;
				short num2 = num;
				num = (short)1848218121;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_D7:
					base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase.get_Reason())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)340000771;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)1516699648;
					if (num != 0)
					{
					}
					num = (short)137887744;
					short num4 = num;
					num = (short)889651201;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_AD;
						}
						continue;
					case 2:
						goto IL_18C;
					case 3:
						goto IL_122;
					case 4:
						if (!base.IsLoading)
						{
							num = (short)723648514;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_AD:
					if (value == this.b)
					{
						num = (short)2010578944;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						this.b = value;
						num = (short)1102446596;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				return;
				IL_122:
				num = (short)1052246017;
				if (num != 0)
				{
				}
				return;
				IL_18C:
				goto IL_D7;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x00061228 File Offset: 0x0005F428
		public byte[] TimeStamp
		{
			get
			{
				short num = (short)738197504;
				short num2 = num;
				num = (short)1437499363;
				short num3 = num;
				num = (short)1101430755;
				switch (num3 == num)
				{
				}
				num = (short)413466624;
				if (num != 0)
				{
				}
				num = (short)1798373377;
				if (num != 0)
				{
				}
				return this.emJobSum.Timestamp;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x000612DC File Offset: 0x0005F4DC
		private global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity emJobSum
		{
			get
			{
				short num = (short)1431306240;
				short num2 = num;
				num = (short)1967128577;
				if (num != 0)
				{
				}
				num = (short)170930613;
				short num3 = num;
				num = (short)1013330357;
				switch (num3 == num)
				{
				}
				num = (short)2105344000;
				if (num != 0)
				{
				}
				return base.Entity;
			}
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0006138C File Offset: 0x0005F58C
		public override string ToString()
		{
			short num = (short)2014314496;
			short num2 = num;
			num = (short)1744228587;
			short num3 = num;
			num = (short)1669910763;
			switch (num3 == num)
			{
			}
			num = (short)1344667648;
			if (num != 0)
			{
			}
			num = (short)316080129;
			if (num != 0)
			{
			}
			return this.Name;
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00061440 File Offset: 0x0005F640
		public override bool IsNewVersion(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase sourceUIMode)
		{
			short num = (short)1022689280;
			short num2 = num;
			num = (short)876708772;
			short num3 = num;
			num = (short)1810793380;
			switch (num3 == num)
			{
			}
			num = (short)361299968;
			if (num != 0)
			{
			}
			num = (short)1793261569;
			if (num != 0)
			{
			}
			byte[] timeStamp = ((global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase)sourceUIMode).TimeStamp;
			byte[] timeStamp2 = this.TimeStamp;
			return global::System.Collections.StructuralComparisons.StructuralComparer.Compare(timeStamp, timeStamp2) >= 0;
		}

		// Token: 0x040002CF RID: 719
		private global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? a;

		// Token: 0x040002D0 RID: 720
		private string b;
	}
}
