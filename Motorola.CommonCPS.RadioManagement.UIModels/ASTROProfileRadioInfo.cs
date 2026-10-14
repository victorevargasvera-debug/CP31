using System;
using System.Globalization;
using System.Linq.Expressions;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000AD RID: 173
	public class ASTROProfileRadioInfo : global::Motorola.CommonCPS.RadioManagement.UIModels.EntityWrapper<global::Motorola.CommonCPS.Server.EntityModel.ProfileRadioInfoSummary>
	{
		// Token: 0x06000673 RID: 1651 RVA: 0x0005DB2C File Offset: 0x0005BD2C
		public ASTROProfileRadioInfo() : base(new global::Motorola.CommonCPS.Server.EntityModel.ProfileRadioInfoSummary())
		{
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0005DB44 File Offset: 0x0005BD44
		public ASTROProfileRadioInfo(global::Motorola.CommonCPS.Server.EntityModel.ProfileRadioInfoSummary summary) : base(summary ?? new global::Motorola.CommonCPS.Server.EntityModel.ProfileRadioInfoSummary())
		{
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x0005DB68 File Offset: 0x0005BD68
		// (set) Token: 0x06000676 RID: 1654 RVA: 0x0005DC1C File Offset: 0x0005BE1C
		public string RadioAlias
		{
			get
			{
				short num = (short)753270784;
				short num2 = num;
				num = (short)18620185;
				short num3 = num;
				num = (short)1823350553;
				switch (num3 == num)
				{
				}
				num = (short)1029111809;
				if (num != 0)
				{
				}
				num = (short)2114584576;
				if (num != 0)
				{
				}
				return this.EntitySummary.RadioAlias;
			}
			set
			{
				short num = (short)334561280;
				short num2 = num;
				num = (short)464191490;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						return;
					case 1:
						num = (short)1110245377;
						if (num != 0)
						{
						}
						this.EntitySummary.RadioAlias = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo.get_RadioAlias())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1725759488;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5B;
						}
						continue;
					}
					IL_5B:
					num = (short)1298147704;
					short num4 = num;
					num = (short)1052911992;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)340656128;
						if (num != 0)
						{
						}
						if (!(value != this.EntitySummary.RadioAlias))
						{
							return;
						}
						num = (short)1954349057;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x0005DD84 File Offset: 0x0005BF84
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x0005DE3C File Offset: 0x0005C03C
		public string SerialNumber
		{
			get
			{
				short num = (short)1311637504;
				short num2 = num;
				num = (short)1479523688;
				short num3 = num;
				num = (short)605666664;
				switch (num3 == num)
				{
				}
				num = (short)47382529;
				if (num != 0)
				{
				}
				num = (short)887816192;
				if (num != 0)
				{
				}
				return this.EntitySummary.SerialNumber;
			}
			set
			{
				short num = (short)714801152;
				short num2 = num;
				num = (short)1694302210;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_130;
					case 1:
						this.EntitySummary.SerialNumber = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo.get_SerialNumber())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)29032448;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5C;
						}
						continue;
					}
					IL_5C:
					num = (short)287373711;
					short num4 = num;
					num = (short)1318713743;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_130;
					default:
						num = (short)190775296;
						if (num != 0)
						{
						}
						if (!(value != this.EntitySummary.SerialNumber))
						{
							return;
						}
						num = (short)1791229953;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_130:
				num = (short)605618177;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x0005DFA4 File Offset: 0x0005C1A4
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x0005E060 File Offset: 0x0005C260
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)1334902784;
				short num2 = num;
				num = (short)1868966882;
				short num3 = num;
				num = (short)1115433954;
				switch (num3 == num)
				{
				}
				num = (short)1263009793;
				if (num != 0)
				{
				}
				num = (short)576651264;
				if (num != 0)
				{
				}
				return new global::System.Guid?(this.EntitySummary.RadioUuid);
			}
			set
			{
				short num = (short)428998656;
				short num2 = num;
				num = (short)1540489218;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						return;
					case 1:
						this.EntitySummary.RadioUuid = value.Value;
						num = (short)154402816;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					}
					IL_5A:
					num = (short)981143950;
					short num4 = num;
					num = (short)274534798;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)72286208;
						if (num != 0)
						{
						}
						if (value == null)
						{
							return;
						}
						num = (short)309460993;
						if (num != 0)
						{
						}
						num = (short)1189806081;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x0005E18C File Offset: 0x0005C38C
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x0005E244 File Offset: 0x0005C444
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus? RadioStatus
		{
			get
			{
				short num = (short)1221263360;
				short num2 = num;
				num = (short)1547282838;
				short num3 = num;
				num = (short)2025367958;
				switch (num3 == num)
				{
				}
				num = (short)785580033;
				if (num != 0)
				{
				}
				num = (short)285016064;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus?((global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus)this.EntitySummary.RadioStatus);
			}
			set
			{
				int num;
				global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus? radioStatus;
				short num2;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_0A:
						int? num4;
						int? num7;
						switch (num)
						{
						case 0:
							return;
						case 1:
						{
							if (radioStatus == null)
							{
								num2 = (short)1705443331;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)570924386;
							short num3 = num2;
							num2 = (short)1180015970;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_36;
							default:
								num2 = (short)721158144;
								if (num2 != 0)
								{
								}
								num2 = (short)1644756998;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 2:
							this.EntitySummary.RadioStatus = num4.Value;
							base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo.get_RadioStatus())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num2 = (short)311033856;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 3:
						{
							int? num5 = null;
							num2 = (short)1419771911;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						case 4:
							num2 = (short)1851588616;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 5:
						{
							num2 = (short)933101569;
							if (num2 != 0)
							{
							}
							int radioStatus2 = this.EntitySummary.RadioStatus;
							int? num5 = num4;
							if (!(radioStatus2 == num5.GetValueOrDefault() & num5 != null))
							{
								num2 = (short)574947328;
								short num6 = num2;
								num2 = (short)620953604;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return;
						}
						case 6:
							num7 = new int?((int)radioStatus.GetValueOrDefault());
							goto IL_1A1;
						case 7:
						{
							int? num5;
							num7 = num5;
							goto IL_1A1;
						}
						case 8:
							if (num4 != null)
							{
								num2 = (short)2145583106;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return;
						}
						goto IL_34;
						IL_1A1:
						num4 = num7;
						num2 = (short)758448133;
						num = (int)((global::System.IntPtr)num2);
					}
					return;
				}
				IL_34:
				radioStatus = value;
				IL_36:
				num2 = (short)1508769793;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x0005E49C File Offset: 0x0005C69C
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x0005E554 File Offset: 0x0005C754
		public int ProfileCount
		{
			get
			{
				short num = (short)1458569216;
				short num2 = num;
				num = (short)925856882;
				short num3 = num;
				num = (short)374633586;
				switch (num3 == num)
				{
				}
				num = (short)235077633;
				if (num != 0)
				{
				}
				num = (short)808845312;
				if (num != 0)
				{
				}
				return this.EntitySummary.ReferenceCount;
			}
			set
			{
				short num = (short)1963327488;
				short num2 = num;
				num = (short)1760296962;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_125;
					case 1:
						this.EntitySummary.ReferenceCount = value;
						base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo.get_ProfileCount())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1428684800;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					}
					IL_59:
					num = (short)251315234;
					short num4 = num;
					num = (short)1913635874;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_125;
					default:
						num = (short)1437073408;
						if (num != 0)
						{
						}
						if (value == this.EntitySummary.ReferenceCount)
						{
							return;
						}
						num = (short)1600913409;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_125:
				num = (short)512360449;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x0005E6B0 File Offset: 0x0005C8B0
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x0005E768 File Offset: 0x0005C968
		public string TemplateName
		{
			get
			{
				short num = (short)821297152;
				short num2 = num;
				num = (short)418210403;
				short num3 = num;
				num = (short)177758819;
				switch (num3 == num)
				{
				}
				num = (short)1410269185;
				if (num != 0)
				{
				}
				num = (short)1396506624;
				if (num != 0)
				{
				}
				return this.EntitySummary.TemplateName;
			}
			set
			{
				short num = (short)269211262;
				short num2 = num;
				num = (short)1876743806;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1806630912;
					if (num != 0)
					{
					}
					num = (short)1689976832;
					short num3 = num;
					if (value == this.EntitySummary.TemplateName)
					{
						num = (short)767164417;
						if (num != 0)
						{
						}
						return;
					}
					break;
				}
				}
				this.EntitySummary.TemplateName = value;
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo.get_TemplateName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x0005E868 File Offset: 0x0005CA68
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x0005E91C File Offset: 0x0005CB1C
		public string ConfigurationName
		{
			get
			{
				short num = (short)394133504;
				short num2 = num;
				num = (short)1953332920;
				short num3 = num;
				num = (short)535396024;
				switch (num3 == num)
				{
				}
				num = (short)849281025;
				if (num != 0)
				{
				}
				num = (short)1326710784;
				if (num != 0)
				{
				}
				return this.EntitySummary.ConfigurationName;
			}
			set
			{
				short num = (short)1447503899;
				short num2 = num;
				num = (short)133703707;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1469186048;
					if (num != 0)
					{
					}
					num = (short)2079916032;
					short num3 = num;
					if (value == this.EntitySummary.ConfigurationName)
					{
						num = (short)444203009;
						if (num != 0)
						{
						}
						return;
					}
					break;
				}
				}
				this.EntitySummary.ConfigurationName = value;
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo.get_ConfigurationName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x0005EA1C File Offset: 0x0005CC1C
		public string ProfileName
		{
			get
			{
				short num = (short)1394278400;
				short num2 = num;
				num = (short)969910922;
				short num3 = num;
				num = (short)1188801162;
				switch (num3 == num)
				{
				}
				num = (short)1359282176;
				if (num != 0)
				{
				}
				num = (short)1655308289;
				if (num != 0)
				{
				}
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_DataProfile_PeudoDataProfileName, this.ProfileCount);
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x0005EAE0 File Offset: 0x0005CCE0
		public string SystemType
		{
			get
			{
				int a_ = 14;
				short num = (short)1069875200;
				short num2 = num;
				num = (short)114630120;
				short num3 = num;
				num = (short)165420520;
				switch (num3 == num)
				{
				}
				num = (short)233832449;
				if (num != 0)
				{
				}
				num = (short)1389232128;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("杈敊捌", a_);
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x0005EBA0 File Offset: 0x0005CDA0
		public string AutoGenerateIPs
		{
			get
			{
				int a_ = 13;
				short num = (short)1480130560;
				short num2 = num;
				num = (short)605060980;
				short num3 = num;
				num = (short)500858740;
				switch (num3 == num)
				{
				}
				num = (short)591527937;
				if (num != 0)
				{
				}
				num = (short)1638793216;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("晇摉手", a_);
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x0005EC60 File Offset: 0x0005CE60
		public string SubscriberIP
		{
			get
			{
				int a_ = 8;
				short num = (short)1231486976;
				short num2 = num;
				num = (short)1053389535;
				short num3 = num;
				num = (short)1349415647;
				switch (num3 == num)
				{
				}
				num = (short)310116352;
				if (num != 0)
				{
				}
				num = (short)2119368705;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("浂歄楆", a_);
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x0005ED24 File Offset: 0x0005CF24
		public string PeerIP
		{
			get
			{
				int a_ = 2;
				short num = (short)561250304;
				short num2 = num;
				num = (short)1752432641;
				if (num != 0)
				{
				}
				num = (short)1461195351;
				short num3 = num;
				num = (short)950276695;
				switch (num3 == num)
				{
				}
				num = (short)423624704;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ጼᄾ潀", a_);
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x0005EDE4 File Offset: 0x0005CFE4
		public string BluetoothDUNSubscriberIP
		{
			get
			{
				int a_ = 7;
				short num = (short)857276416;
				short num2 = num;
				num = (short)565743450;
				short num3 = num;
				num = (short)1236045658;
				switch (num3 == num)
				{
				}
				num = (short)813105153;
				if (num != 0)
				{
				}
				num = (short)1611726848;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("汁橃桅", a_);
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x0005EEA4 File Offset: 0x0005D0A4
		public string BluetoothDUNPeerIP
		{
			get
			{
				int a_ = 12;
				short num = (short)1458241536;
				short num2 = num;
				num = (short)702846552;
				short num3 = num;
				num = (short)1115067992;
				switch (num3 == num)
				{
				}
				num = (short)777453569;
				if (num != 0)
				{
				}
				num = (short)269352960;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("楆杈敊", a_);
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x0005EF64 File Offset: 0x0005D164
		public string AirInterfaceIP
		{
			get
			{
				int a_ = 7;
				short num = (short)795213824;
				short num2 = num;
				num = (short)177041416;
				short num3 = num;
				num = (short)77688840;
				switch (num3 == num)
				{
				}
				num = (short)1385758721;
				if (num != 0)
				{
				}
				num = (short)1119027200;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("汁橃桅", a_);
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x0005F024 File Offset: 0x0005D224
		private global::Motorola.CommonCPS.Server.EntityModel.ProfileRadioInfoSummary EntitySummary
		{
			get
			{
				short num = (short)1230503936;
				short num2 = num;
				num = (short)707236654;
				short num3 = num;
				num = (short)843944750;
				switch (num3 == num)
				{
				}
				num = (short)1501364225;
				if (num != 0)
				{
				}
				num = (short)147587072;
				if (num != 0)
				{
				}
				return base.Entity;
			}
		}
	}
}
