using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000D4 RID: 212
	public class FeatureInfo : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::Motorola.CommonCPS.RadioManagement.UIModels.ICopyable
	{
		// Token: 0x06000A10 RID: 2576 RVA: 0x00098DC4 File Offset: 0x00096FC4
		public FeatureInfo(string newFeatureName, string newCapacity, string newUsed, string newStatus, global::Motorola.CommonCPS.Server.EntityModel.ApplicationFeatureSummary featureSummary, global::Motorola.CommonCPS.Server.CommonDBConstants.AppLicenseType type, global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? region)
		{
			int a_ = 8;
			base..ctor();
			this.b = newFeatureName;
			this.d = newCapacity;
			this.c = newUsed;
			this.e = newStatus;
			this.i = featureSummary;
			this.g = type;
			this.h = region;
			switch (this.g)
			{
			case global::Motorola.CommonCPS.Server.CommonDBConstants.AppLicenseType.RadioManagement:
				if (region != null)
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? regionName = region;
					global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName regionName2 = global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.NULL;
					if (!(regionName.GetValueOrDefault() == regionName2 & regionName != null))
					{
						regionName = region;
						regionName2 = global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.NA;
						if (regionName.GetValueOrDefault() == regionName2 & regionName != null)
						{
							this.f = global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo.a[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᅂ⑄⍆⁈⑊L⹎㽐㉒㉔㉖㑘㹚㍜⭞㹠ⵢ⑤", a_)];
							return;
						}
						regionName = region;
						regionName2 = global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.AS;
						if (regionName.GetValueOrDefault() == regionName2 & regionName != null)
						{
							this.f = global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo.a[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᅂ⑄⍆⁈⑊L⹎㽐㉒㉔㉖㑘㹚㍜⭞㹠≢㙤", a_)];
							return;
						}
						regionName = region;
						regionName2 = global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.LA;
						if (regionName.GetValueOrDefault() == regionName2 & regionName != null)
						{
							this.f = global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo.a[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᅂ⑄⍆⁈⑊L⹎㽐㉒㉔㉖㑘㹚㍜⭞㹠⽢⑤", a_)];
							return;
						}
						regionName = region;
						regionName2 = global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.EMEA;
						if (regionName.GetValueOrDefault() == regionName2 & regionName != null)
						{
							this.f = global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo.a[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᅂ⑄⍆⁈⑊L⹎㽐㉒㉔㉖㑘㹚㍜⭞㹠♢⡤≦⡨", a_)];
							return;
						}
						break;
					}
				}
				this.f = global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo.a[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᅂ⑄⍆⁈⑊L⹎㽐㉒㉔㉖㑘㹚㍜⭞", a_)];
				return;
			case global::Motorola.CommonCPS.Server.CommonDBConstants.AppLicenseType.PCR_NPSPAC:
				this.f = global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo.a[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ൂᕄᑆ᥈੊์၎ὐቒ", a_)];
				return;
			case global::Motorola.CommonCPS.Server.CommonDBConstants.AppLicenseType.PCR_RRP:
			{
				global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? regionName = region;
				global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName regionName2 = global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.NA;
				if (regionName.GetValueOrDefault() == regionName2 & regionName != null)
				{
					this.f = global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo.a[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᅂᝄᝆᙈՊౌ", a_)];
					return;
				}
				regionName = region;
				regionName2 = global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.LA;
				if (regionName.GetValueOrDefault() == regionName2 & regionName != null)
				{
					this.f = global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo.a[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᅂᝄᝆᙈ݊ౌ", a_)];
					return;
				}
				regionName = region;
				regionName2 = global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.AS;
				if (regionName.GetValueOrDefault() == regionName2 & regionName != null)
				{
					this.f = global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo.a[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᅂᝄᝆᙈ੊Ṍ", a_)];
					return;
				}
				break;
			}
			case global::Motorola.CommonCPS.Server.CommonDBConstants.AppLicenseType.PCR_25KHZ:
				this.f = global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo.a[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("煂灄ెňᅊቌŎၐ", a_)];
				return;
			case global::Motorola.CommonCPS.Server.CommonDBConstants.AppLicenseType.PCR_NONSPAINFREQ:
				this.f = global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo.a[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ൂ੄ॆᩈᭊౌَὐᕒݔቖࡘњᡜ቞①≢", a_)];
				return;
			case global::Motorola.CommonCPS.Server.CommonDBConstants.AppLicenseType.PCR_NONKOREAANALOGCHAN:
				this.f = global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo.a[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ൂ੄ॆɈъὌ੎ၐቒ᭔ᙖᕘᑚᩜᱞ⥠≢⭤㡦⡨㡪", a_)];
				break;
			default:
				return;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x000990C8 File Offset: 0x000972C8
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)1714410755;
				short num2 = num;
				num = (short)1834013955;
				switch (num2 == num)
				{
				}
				num = (short)1661009921;
				if (num != 0)
				{
				}
				num = (short)1548288000;
				if (num != 0)
				{
				}
				num = (short)1570897920;
				short num3 = num;
				return new global::System.Guid?(this.f);
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x00099180 File Offset: 0x00097380
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x00099230 File Offset: 0x00097430
		public string FeatureName
		{
			get
			{
				short num = (short)1463112289;
				short num2 = num;
				num = (short)786453089;
				switch (num2 == num)
				{
				}
				num = (short)1511981057;
				if (num != 0)
				{
				}
				num = (short)1675034624;
				if (num != 0)
				{
				}
				num = (short)1114898432;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)518914052;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_144;
					case 2:
						if (value == this.FeatureName)
						{
							num = (short)1283129344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.b = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo.get_FeatureName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1206386689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)218890242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_14;
					}
					goto IL_38;
					IL_14:
					switch (0)
					{
					case 0:
					{
						IL_38:
						num = (short)1328936269;
						short num3 = num;
						num = (short)1943795021;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
						{
							num = (short)976289792;
							if (num != 0)
							{
							}
							num = (short)945029120;
							short num4 = num;
							num = (short)1870331905;
							if (num != 0)
							{
							}
							if (value == null)
							{
								return;
							}
							num = (short)1249574915;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
						break;
					}
					}
				}
				IL_144:;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x000993C4 File Offset: 0x000975C4
		public string UIStatus
		{
			get
			{
				if (!string.IsNullOrEmpty(this.d))
				{
					short num;
					for (;;)
					{
						num = (short)1992368741;
						short num2 = num;
						num = (short)1845764709;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_48;
						}
					}
					IL_48:
					num = (short)1182662657;
					if (num != 0)
					{
					}
					num = (short)626130944;
					short num3 = num;
					num = (short)2142765056;
					if (num != 0)
					{
					}
					return this.Used + global::Motorola.CommonCPS.ResourceRepository.Resources.General_ForwardSlash + this.Capacity;
				}
				return this.e;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x0009949C File Offset: 0x0009769C
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x0009954C File Offset: 0x0009774C
		public string Status
		{
			get
			{
				short num = (short)1626457657;
				short num2 = num;
				num = (short)894944825;
				switch (num2 == num)
				{
				}
				num = (short)603979777;
				if (num != 0)
				{
				}
				num = (short)562167808;
				if (num != 0)
				{
				}
				num = (short)597098496;
				short num3 = num;
				return this.e;
			}
			set
			{
				short num = (short)447348740;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1340866561;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_149;
					case 2:
						if (value == this.e)
						{
							num = (short)698679296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo.get_UIStatus())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1705705473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)20971522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_15;
					}
					goto IL_60;
					IL_15:
					switch (0)
					{
					case 0:
					{
						IL_60:
						num = (short)1287168439;
						short num3 = num;
						num = (short)1010147767;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15;
						default:
						{
							num = (short)813105152;
							short num4 = num;
							num = (short)109707264;
							if (num != 0)
							{
							}
							if (value == null)
							{
								return;
							}
							num = (short)1996161027;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
						break;
					}
					}
				}
				IL_149:;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x000996E4 File Offset: 0x000978E4
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x00099794 File Offset: 0x00097994
		public string Capacity
		{
			get
			{
				short num = (short)1717428354;
				short num2 = num;
				num = (short)1362092162;
				switch (num2 == num)
				{
				}
				num = (short)1410007040;
				if (num != 0)
				{
				}
				num = (short)979501057;
				if (num != 0)
				{
				}
				num = (short)670367744;
				short num3 = num;
				return this.d;
			}
			set
			{
				short num = (short)683278340;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_146;
					case 2:
						if (value == this.d)
						{
							num = (short)812253184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.d = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo.get_UIStatus())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1875050497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1134428162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_14;
					}
					goto IL_38;
					IL_14:
					switch (0)
					{
					case 0:
					{
						IL_38:
						num = (short)688475274;
						short num3 = num;
						num = (short)791497866;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
						{
							num = (short)1830092801;
							if (num != 0)
							{
							}
							num = (short)1894121472;
							short num4 = num;
							num = (short)278724608;
							if (num != 0)
							{
							}
							if (value == null)
							{
								return;
							}
							num = (short)367525891;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
						break;
					}
					}
				}
				IL_146:;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00099928 File Offset: 0x00097B28
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x000999D4 File Offset: 0x00097BD4
		public string Used
		{
			get
			{
				short num = (short)2141967054;
				short num2 = num;
				num = (short)161534670;
				switch (num2 == num)
				{
				}
				num = (short)683999232;
				if (num != 0)
				{
				}
				num = (short)278659073;
				if (num != 0)
				{
				}
				num = (short)1096089600;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)194379780;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_145;
					case 2:
						if (value == this.c)
						{
							num = (short)765263872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.c = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo.get_UIStatus())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1268252673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1659305986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_15;
					}
					goto IL_39;
					IL_15:
					switch (0)
					{
					case 0:
					{
						IL_39:
						num = (short)1079338602;
						short num3 = num;
						num = (short)898721386;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15;
						default:
						{
							num = (short)808124416;
							if (num != 0)
							{
							}
							num = (short)1232207872;
							short num4 = num;
							num = (short)79364097;
							if (num != 0)
							{
							}
							if (value == null)
							{
								return;
							}
							num = (short)258080771;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
						break;
					}
					}
				}
				IL_145:;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00099B68 File Offset: 0x00097D68
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? Region
		{
			get
			{
				short num = (short)760027249;
				short num2 = num;
				num = (short)1525094513;
				switch (num2 == num)
				{
				}
				num = (short)1353711616;
				if (num != 0)
				{
				}
				num = (short)1484521473;
				if (num != 0)
				{
				}
				num = (short)669253632;
				short num3 = num;
				return this.h;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x00099C18 File Offset: 0x00097E18
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x00099CCC File Offset: 0x00097ECC
		public string AppComments
		{
			get
			{
				short num = (short)413204481;
				if (num != 0)
				{
				}
				num = (short)265849899;
				short num2 = num;
				num = (short)353799211;
				switch (num2 == num)
				{
				}
				num = (short)1606287360;
				if (num != 0)
				{
				}
				num = (short)824049664;
				short num3 = num;
				return this.i.Comments;
			}
			set
			{
				short num = (short)43843589;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.i.Comments = string.Empty;
						num = (short)427687939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_167;
					case 2:
					{
						if (string.IsNullOrEmpty(value))
						{
							num = (short)1522008064;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)901488188;
						short num3 = num;
						num = (short)580558396;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15;
						default:
							num = (short)94437376;
							if (num != 0)
							{
							}
							this.i.Comments = value.Trim();
							num = (short)1100087297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_B6;
					case 4:
						goto IL_66;
					case 5:
						goto IL_15;
					}
					goto IL_3D;
					IL_15:
					switch (0)
					{
					case 0:
						IL_3D:
						if (value == this.i.Comments)
						{
							num = (short)1339949060;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							num = (short)1981546498;
							num2 = (int)((global::System.IntPtr)num);
						}
						break;
					}
				}
				IL_66:
				num = (short)650903553;
				if (num != 0)
				{
				}
				return;
				IL_B6:
				goto IL_191;
				IL_167:
				num = (short)1810235392;
				short num4 = num;
				IL_191:
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo.get_AppComments())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x00099EA0 File Offset: 0x000980A0
		public string RawFeatureCode
		{
			get
			{
				short num = (short)912719873;
				if (num != 0)
				{
				}
				num = (short)1229604658;
				short num2 = num;
				num = (short)1071990578;
				switch (num2 == num)
				{
				}
				num = (short)249692160;
				if (num != 0)
				{
				}
				num = (short)725155840;
				short num3 = num;
				return this.i.FeatureName;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x00099F54 File Offset: 0x00098154
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x0009A004 File Offset: 0x00098204
		public global::Motorola.CommonCPS.Server.EntityModel.ApplicationFeatureSummary EntitySummary
		{
			get
			{
				short num = (short)780535024;
				short num2 = num;
				num = (short)267388144;
				switch (num2 == num)
				{
				}
				num = (short)2130575360;
				if (num != 0)
				{
				}
				num = (short)821886977;
				if (num != 0)
				{
				}
				num = (short)449249280;
				short num3 = num;
				return this.i;
			}
			set
			{
				short num = (short)1713897476;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.i = value;
						num = (short)1157693441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_A9;
					case 2:
						IL_86:
						if (value != this.i)
						{
							num = (short)1382875136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A9;
					case 3:
						num = (short)1715863554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					}
					IL_39:
					if (value != null)
					{
						num = (short)1898840067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A9:
					num = (short)2129649607;
					short num3 = num;
					num = (short)1360322503;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_86;
					case 1:
						goto IL_109;
					}
					break;
				}
				num = (short)1805451264;
				short num4 = num;
				IL_109:
				num = (short)1501167616;
				if (num != 0)
				{
				}
				num = (short)77135873;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0009A158 File Offset: 0x00098358
		public void CopyFrom(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase source)
		{
			int a_ = 10;
			short num = (short)136980335;
			short num2 = num;
			num = (short)909453167;
			switch (num2 == num)
			{
			}
			num = (short)693370880;
			if (num != 0)
			{
			}
			num = (short)1928855553;
			if (num != 0)
			{
			}
			num = (short)692977664;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo fromObject = (global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo)source;
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CopyObjectPublicProperties(fromObject, this, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፄ♆╈≊⥌⹎═㱒❔", a_));
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0009A228 File Offset: 0x00098428
		// Note: this type is marked as 'beforefieldinit'.
		static FeatureInfo()
		{
			int a_ = 4;
			short num = (short)88429714;
			short num2 = num;
			num = (short)1346851986;
			switch (num2 == num)
			{
			}
			num = (short)1592393729;
			if (num != 0)
			{
			}
			num = (short)1822818304;
			if (num != 0)
			{
			}
			num = (short)1117126656;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo.a = new global::System.Collections.Generic.Dictionary<string, global::System.Guid>
			{
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("派⁀❂ⱄ⡆ш⩊⍌⹎㙐㙒㡔㉖㝘⽚", a_),
					global::System.Guid.NewGuid()
				},
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("派⁀❂ⱄ⡆ш⩊⍌⹎㙐㙒㡔㉖㝘⽚ɜᅞ⁠", a_),
					global::System.Guid.NewGuid()
				},
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("派⁀❂ⱄ⡆ш⩊⍌⹎㙐㙒㡔㉖㝘⽚ɜṞ㉠", a_),
					global::System.Guid.NewGuid()
				},
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("派⁀❂ⱄ⡆ш⩊⍌⹎㙐㙒㡔㉖㝘⽚ɜ፞⁠", a_),
					global::System.Guid.NewGuid()
				},
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("派⁀❂ⱄ⡆ш⩊⍌⹎㙐㙒㡔㉖㝘⽚ɜᩞⱠ♢⑤", a_),
					global::System.Guid.NewGuid()
				},
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ാ瑀ࡂൄᵆᙈՊౌ", a_),
					global::System.Guid.NewGuid()
				},
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("焾ᅀ၂ᕄنੈᑊ͌๎", a_),
					global::System.Guid.NewGuid()
				},
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("派ፀፂᩄॆࡈ", a_),
					global::System.Guid.NewGuid()
				},
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("派ፀፂᩄنᩈ", a_),
					global::System.Guid.NewGuid()
				},
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("派ፀፂᩄ୆ࡈ", a_),
					global::System.Guid.NewGuid()
				},
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("焾เൂᙄᝆࡈɊ͌ॎ͐ᙒєࡖ᱘ᙚᡜṞ", a_),
					global::System.Guid.NewGuid()
				},
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("焾เൂไࡆᭈ๊ౌ๎ὐቒᥔᡖṘᡚᕜṞ⽠㱢⑤㑦", a_),
					global::System.Guid.NewGuid()
				}
			};
		}

		// Token: 0x040003A3 RID: 931
		private static global::System.Collections.Generic.Dictionary<string, global::System.Guid> a;

		// Token: 0x040003A4 RID: 932
		private string b;

		// Token: 0x040003A5 RID: 933
		private string c;

		// Token: 0x040003A6 RID: 934
		private string d;

		// Token: 0x040003A7 RID: 935
		private string e;

		// Token: 0x040003A8 RID: 936
		private global::System.Guid f;

		// Token: 0x040003A9 RID: 937
		private global::Motorola.CommonCPS.Server.CommonDBConstants.AppLicenseType g;

		// Token: 0x040003AA RID: 938
		private global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? h;

		// Token: 0x040003AB RID: 939
		private global::Motorola.CommonCPS.Server.EntityModel.ApplicationFeatureSummary i;
	}
}
