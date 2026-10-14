using System;
using System.Globalization;
using System.Linq.Expressions;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000AC RID: 172
	public class ASTROProfileInfo : global::Motorola.CommonCPS.RadioManagement.UIModels.EntityWrapper<global::Motorola.CommonCPS.Server.EntityModel.DataProfileInfo>
	{
		// Token: 0x0600065C RID: 1628 RVA: 0x0005C83C File Offset: 0x0005AA3C
		public ASTROProfileInfo() : base(new global::Motorola.CommonCPS.Server.EntityModel.DataProfileInfo())
		{
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0005C864 File Offset: 0x0005AA64
		public ASTROProfileInfo(global::Motorola.CommonCPS.Server.EntityModel.DataProfileInfo summary) : base(summary ?? new global::Motorola.CommonCPS.Server.EntityModel.DataProfileInfo())
		{
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x0005C898 File Offset: 0x0005AA98
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x0005C948 File Offset: 0x0005AB48
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)689098144;
				short num2 = num;
				num = (short)2073677216;
				switch (num2 == num)
				{
				}
				num = (short)667615233;
				if (num != 0)
				{
				}
				num = (short)1738014720;
				if (num != 0)
				{
				}
				num = (short)1324875776;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)1209583545;
				short num2 = num;
				num = (short)403359673;
				switch (num2 == num)
				{
				}
				num = (short)1596981249;
				if (num != 0)
				{
				}
				num = (short)657129472;
				if (num != 0)
				{
				}
				num = (short)25362432;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x0005C9FC File Offset: 0x0005ABFC
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x0005CAB0 File Offset: 0x0005ACB0
		public string ProfileName
		{
			get
			{
				short num = (short)51230317;
				short num2 = num;
				num = (short)232502893;
				switch (num2 == num)
				{
				}
				num = (short)432406529;
				if (num != 0)
				{
				}
				num = (short)122290176;
				if (num != 0)
				{
				}
				num = (short)63045632;
				short num3 = num;
				return this.EntitySummary.ProfileName;
			}
			set
			{
				while (value == this.EntitySummary.ProfileName)
				{
					short num = (short)2071281123;
					short num2 = num;
					num = (short)1652964835;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1256390656;
						short num3 = num;
						num = (short)1130299392;
						if (num != 0)
						{
						}
						num = (short)479985665;
						if (num != 0)
						{
						}
						return;
					}
					}
				}
				this.EntitySummary.ProfileName = value;
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo.get_ProfileName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x0005CBB4 File Offset: 0x0005ADB4
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x0005CC70 File Offset: 0x0005AE70
		public global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? SystemType
		{
			get
			{
				short num = (short)1826907695;
				short num2 = num;
				num = (short)1641571887;
				switch (num2 == num)
				{
				}
				num = (short)1218445313;
				if (num != 0)
				{
				}
				num = (short)1792671744;
				if (num != 0)
				{
				}
				num = (short)93388800;
				short num3 = num;
				return new global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?((global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType)this.EntitySummary.SystemType);
			}
			set
			{
				short num;
				for (;;)
				{
					num = (short)304021504;
					int num2 = (int)num;
					switch (num2)
					{
					default:
					{
						switch (0)
						{
						case 0:
							goto IL_4B;
						}
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType;
						for (;;)
						{
							IL_28:
							int? num3;
							int systemType;
							int? num4;
							int? num5;
							switch (num2)
							{
							case 0:
								if (!(num3.GetValueOrDefault() == systemType & num3 != null))
								{
									num = (short)1928462339;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1E1;
							case 1:
								num = (short)1909456897;
								if (num != 0)
								{
								}
								if (astroSystemType == null)
								{
									num = (short)1430192132;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)167378946;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								num4 = new int?((int)astroSystemType.GetValueOrDefault());
								goto IL_162;
							case 3:
								this.EntitySummary.SystemType = num5.Value;
								base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo.get_SystemType())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
								num = (short)1895366662;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								num = (short)1733885952;
								short num6 = num;
								num3 = null;
								num = (short)152043525;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								num4 = num3;
								goto IL_162;
							case 6:
								goto IL_15D;
							}
							goto IL_4B;
							IL_162:
							num5 = num4;
							num3 = num5;
							systemType = this.EntitySummary.SystemType;
							num = (short)141557760;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1E1:
						num = (short)1525076445;
						short num7 = num;
						num = (short)1720963549;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_217;
						}
						IL_15D:
						goto IL_1E1;
						IL_4B:
						astroSystemType = value;
						num = (short)1609433089;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_28;
					}
					}
				}
				IL_217:
				num = (short)502857728;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x0005CEAC File Offset: 0x0005B0AC
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x0005CF60 File Offset: 0x0005B160
		public int RadioCount
		{
			get
			{
				short num = (short)719652895;
				short num2 = num;
				num = (short)1258293279;
				switch (num2 == num)
				{
				}
				num = (short)1509097473;
				if (num != 0)
				{
				}
				num = (short)1552089088;
				if (num != 0)
				{
				}
				num = (short)881393664;
				short num3 = num;
				return this.EntitySummary.ReferenceCount;
			}
			set
			{
				short num = (short)1661337601;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_129;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
					{
						num = (short)1715011632;
						short num3 = num;
						num = (short)1474101296;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)436404224;
							if (num != 0)
							{
							}
							num = (short)979435520;
							short num4 = num;
							this.EntitySummary.ReferenceCount = value;
							base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo.get_RadioCount())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							break;
						}
						}
						num = (short)1216348160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_30:
					if (value == this.EntitySummary.ReferenceCount)
					{
						return;
					}
					num = (short)577699842;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_129:
				num = (short)1849950209;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x0005D0C0 File Offset: 0x0005B2C0
		public string CustomID
		{
			get
			{
				int a_ = 12;
				switch (0)
				{
				case 0:
					goto IL_29;
				}
				int num;
				global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType;
				short num2;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						goto IL_F6;
					case 1:
					{
						if (systemType == null)
						{
							num2 = (short)640614401;
							if (num2 != 0)
							{
							}
							num2 = (short)1267728387;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1663500829;
						short num3 = num2;
						num2 = (short)2110784029;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)1941962752;
							if (num2 != 0)
							{
							}
							systemType = this.SystemType;
							break;
						}
						num2 = (short)1313144832;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						goto IL_144;
					case 3:
						num2 = (short)1738342402;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_29;
				}
				IL_F6:
				num2 = (short)271187968;
				short num4 = num2;
				string str = systemType.ToString();
				goto IL_147;
				IL_144:
				str = null;
				IL_147:
				return str + global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("橆", a_) + this.ProfileName;
				IL_29:
				systemType = this.SystemType;
				num2 = (short)715194369;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x0005D230 File Offset: 0x0005B430
		public string RadioAlias
		{
			get
			{
				int a_ = 13;
				short num = (short)1063845888;
				short num2 = num;
				num = (short)1141344035;
				short num3 = num;
				num = (short)1191675683;
				switch (num3 == num)
				{
				}
				num = (short)969015297;
				if (num != 0)
				{
				}
				num = (short)1320812544;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("晇摉手", a_);
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x0005D2F0 File Offset: 0x0005B4F0
		public string SerialNumber
		{
			get
			{
				short num = (short)911736832;
				short num2 = num;
				num = (short)1471348039;
				short num3 = num;
				num = (short)264109383;
				switch (num3 == num)
				{
				}
				num = (short)1258225664;
				if (num != 0)
				{
				}
				num = (short)1668349953;
				if (num != 0)
				{
				}
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_DataProfile_PeudoSerialNumber, this.RadioCount);
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x0005D3B4 File Offset: 0x0005B5B4
		public string RadioStatus
		{
			get
			{
				int a_ = 12;
				short num = (short)1561001984;
				short num2 = num;
				num = (short)1551204279;
				short num3 = num;
				num = (short)1113882551;
				switch (num3 == num)
				{
				}
				num = (short)797310977;
				if (num != 0)
				{
				}
				num = (short)54460416;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("楆杈敊", a_);
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x0005D474 File Offset: 0x0005B674
		public string TemplateName
		{
			get
			{
				int a_ = 7;
				short num = (short)1881800704;
				short num2 = num;
				num = (short)1985285153;
				short num3 = num;
				num = (short)813108257;
				switch (num3 == num)
				{
				}
				num = (short)462028801;
				if (num != 0)
				{
				}
				num = (short)1032257536;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("汁橃桅", a_);
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x0005D534 File Offset: 0x0005B734
		public string ConfigurationName
		{
			get
			{
				int a_ = 11;
				short num = (short)1001914368;
				short num2 = num;
				num = (short)702545921;
				if (num != 0)
				{
				}
				num = (short)2062806408;
				short num3 = num;
				num = (short)880668040;
				switch (num3 == num)
				{
				}
				num = (short)690880512;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("桅晇摉", a_);
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x0005D5F8 File Offset: 0x0005B7F8
		public string AutoGenerateIPs
		{
			get
			{
				int a_ = 0;
				short num = (short)71696384;
				short num2 = num;
				num = (short)1938904952;
				short num3 = num;
				num = (short)121591672;
				switch (num3 == num)
				{
				}
				num = (short)949551105;
				if (num != 0)
				{
				}
				num = (short)1248460800;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᔺጼᄾ", a_);
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x0005D6B8 File Offset: 0x0005B8B8
		public string SubscriberIP
		{
			get
			{
				int a_ = 18;
				short num = (short)699793408;
				short num2 = num;
				num = (short)325664333;
				short num3 = num;
				num = (short)521616973;
				switch (num3 == num)
				{
				}
				num = (short)204406784;
				if (num != 0)
				{
				}
				num = (short)1183055873;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("捌慎罐", a_);
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x0005D778 File Offset: 0x0005B978
		public string PeerIP
		{
			get
			{
				int a_ = 5;
				short num = (short)931463168;
				short num2 = num;
				num = (short)2095982942;
				short num3 = num;
				num = (short)901392734;
				switch (num3 == num)
				{
				}
				num = (short)299565057;
				if (num != 0)
				{
				}
				num = (short)1686503424;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("渿汁橃", a_);
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x0005D838 File Offset: 0x0005BA38
		public string BluetoothDUNSubscriberIP
		{
			get
			{
				int a_ = 12;
				short num = (short)1287258112;
				short num2 = num;
				num = (short)501940225;
				if (num != 0)
				{
				}
				num = (short)1475621657;
				short num3 = num;
				num = (short)58536729;
				switch (num3 == num)
				{
				}
				num = (short)1692532736;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("楆杈敊", a_);
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x0005D8F8 File Offset: 0x0005BAF8
		public string BluetoothDUNPeerIP
		{
			get
			{
				int a_ = 11;
				short num = (short)511180800;
				short num2 = num;
				num = (short)901185537;
				if (num != 0)
				{
				}
				num = (short)1205411497;
				short num3 = num;
				num = (short)351739561;
				switch (num3 == num)
				{
				}
				num = (short)990052352;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("桅晇摉", a_);
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x0005D9B8 File Offset: 0x0005BBB8
		public string AirInterfaceIP
		{
			get
			{
				int a_ = 19;
				short num = (short)125370368;
				short num2 = num;
				num = (short)1027527522;
				short num3 = num;
				num = (short)427348834;
				switch (num3 == num)
				{
				}
				num = (short)1224212480;
				if (num != 0)
				{
				}
				num = (short)932249601;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("恍繏籑", a_);
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x0005DA78 File Offset: 0x0005BC78
		private global::Motorola.CommonCPS.Server.EntityModel.DataProfileInfo EntitySummary
		{
			get
			{
				short num = (short)729743360;
				short num2 = num;
				num = (short)67160808;
				short num3 = num;
				num = (short)344115944;
				switch (num3 == num)
				{
				}
				num = (short)740229121;
				if (num != 0)
				{
				}
				num = (short)1914372096;
				if (num != 0)
				{
				}
				return base.Entity;
			}
		}

		// Token: 0x040002C4 RID: 708
		private global::System.Guid? a = new global::System.Guid?(global::System.Guid.NewGuid());
	}
}
