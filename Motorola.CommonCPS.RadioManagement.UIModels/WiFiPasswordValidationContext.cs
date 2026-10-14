using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq.Expressions;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000050 RID: 80
	public class WiFiPasswordValidationContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x0600023A RID: 570 RVA: 0x00022E60 File Offset: 0x00021060
		public WiFiPasswordValidationContext(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.APXWiFiNetwork> listAPXWiFiNetwork, global::Motorola.CommonCPS.Server.EntityModel.APXTemplate APXTemplate)
		{
			this.f = false;
			this.e = listAPXWiFiNetwork;
			this.b = APXTemplate;
			this.ApxTemplateName = this.b.Name;
			this.IsCancel = true;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00022EA0 File Offset: 0x000210A0
		public WiFiPasswordValidationContext(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.APXWiFiNetwork> listAPXWiFiNetwork, global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary configurationViewSummary)
		{
			this.f = false;
			this.e = listAPXWiFiNetwork;
			this.a = configurationViewSummary;
			this.ApxTemplateName = this.a.Name;
			this.IsCancel = true;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00022EE0 File Offset: 0x000210E0
		public WiFiPasswordValidationContext(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.APXWiFiNetwork> listAPXWiFiNetwork, global::Motorola.CommonCPS.RadioManagement.UIModels.Set set)
		{
			this.f = false;
			this.e = listAPXWiFiNetwork;
			this.c = set;
			this.ApxTemplateName = this.c.Name;
			this.IsCancel = true;
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00022F20 File Offset: 0x00021120
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00022FCC File Offset: 0x000211CC
		public bool IsValidationPass
		{
			get
			{
				short num = (short)506265600;
				short num2 = num;
				num = (short)1718132297;
				short num3 = num;
				num = (short)478912073;
				switch (num3 == num)
				{
				}
				num = (short)1460666369;
				if (num != 0)
				{
				}
				num = (short)1432616960;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)1348403200;
				short num2 = num;
				num = (short)1346599698;
				short num3 = num;
				num = (short)2080602898;
				switch (num3 == num)
				{
				}
				num = (short)254672897;
				if (num != 0)
				{
				}
				num = (short)2040659968;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600023F RID: 575 RVA: 0x0002307C File Offset: 0x0002127C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.APXWiFiNetwork> ListAPXWiFiNetwork
		{
			get
			{
				short num = (short)151781376;
				short num2 = num;
				num = (short)653287810;
				short num3 = num;
				num = (short)1897226626;
				switch (num3 == num)
				{
				}
				num = (short)452722689;
				if (num != 0)
				{
				}
				num = (short)1083768832;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000240 RID: 576 RVA: 0x0002312C File Offset: 0x0002132C
		public global::Motorola.CommonCPS.Server.EntityModel.APXTemplate APXTemplate
		{
			get
			{
				short num = (short)1250492416;
				short num2 = num;
				num = (short)625567227;
				short num3 = num;
				num = (short)914580987;
				switch (num3 == num)
				{
				}
				num = (short)772734976;
				if (num != 0)
				{
				}
				num = (short)1282670593;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000241 RID: 577 RVA: 0x000231DC File Offset: 0x000213DC
		public global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary ConfigurationViewSummary
		{
			get
			{
				short num = (short)1592393728;
				short num2 = num;
				num = (short)1980768451;
				short num3 = num;
				num = (short)1894195395;
				switch (num3 == num)
				{
				}
				num = (short)606076929;
				if (num != 0)
				{
				}
				num = (short)298057728;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000242 RID: 578 RVA: 0x0002328C File Offset: 0x0002148C
		public global::Motorola.CommonCPS.RadioManagement.UIModels.Set DatawideSet
		{
			get
			{
				short num = (short)761135104;
				short num2 = num;
				num = (short)903592675;
				short num3 = num;
				num = (short)837991139;
				switch (num3 == num)
				{
				}
				num = (short)744030209;
				if (num != 0)
				{
				}
				num = (short)1502609408;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0002333C File Offset: 0x0002153C
		// (set) Token: 0x06000244 RID: 580 RVA: 0x000233F0 File Offset: 0x000215F0
		public global::System.ComponentModel.ICollectionView WiFiNetworks
		{
			get
			{
				short num = (short)440401920;
				short num2 = num;
				num = (short)403938089;
				short num3 = num;
				num = (short)2089589545;
				switch (num3 == num)
				{
				}
				num = (short)1211695104;
				if (num != 0)
				{
				}
				num = (short)114688001;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)927804909;
				short num2 = num;
				num = (short)2118397421;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1903886336;
					if (num != 0)
					{
					}
					num = (short)257490945;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.d = value;
						base.RaisePropertyChanged<global::System.ComponentModel.ICollectionView>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.ComponentModel.ICollectionView>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext.get_WiFiNetworks())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)761200642;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)189399040;
						short num4 = num;
						num = (short)1967587329;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_CC;
						}
						continue;
					}
					case 2:
						return;
					}
					IL_CC:
					if (value == this.d)
					{
						break;
					}
					num = (short)366149632;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00023540 File Offset: 0x00021740
		public bool? WiFiEnable
		{
			get
			{
				short num = (short)1542258688;
				short num2 = num;
				num = (short)251579129;
				short num3 = num;
				num = (short)1130089209;
				switch (num3 == num)
				{
				}
				num = (short)2122186752;
				if (num != 0)
				{
				}
				num = (short)1717698561;
				if (num != 0)
				{
				}
				return this.b.WiFiEnable;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000246 RID: 582 RVA: 0x000235F4 File Offset: 0x000217F4
		// (set) Token: 0x06000247 RID: 583 RVA: 0x000236A4 File Offset: 0x000218A4
		public bool HasInvalidPWD
		{
			get
			{
				short num = (short)291831808;
				short num2 = num;
				num = (short)1793972651;
				short num3 = num;
				num = (short)342677931;
				switch (num3 == num)
				{
				}
				num = (short)702676993;
				if (num != 0)
				{
				}
				num = (short)595787776;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)539557888;
				short num2 = num;
				num = (short)360081500;
				short num3 = num;
				num = (short)1032939612;
				switch (num3 == num)
				{
				}
				num = (short)1870331904;
				if (num != 0)
				{
				}
				num = (short)691994625;
				if (num != 0)
				{
				}
				this.g = value;
				base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext.get_HasInvalidPWD())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0002378C File Offset: 0x0002198C
		// (set) Token: 0x06000249 RID: 585 RVA: 0x0002383C File Offset: 0x00021A3C
		public string ApxTemplateName
		{
			get
			{
				short num = (short)53411840;
				short num2 = num;
				num = (short)607623112;
				short num3 = num;
				num = (short)1834391496;
				switch (num3 == num)
				{
				}
				num = (short)703266817;
				if (num != 0)
				{
				}
				num = (short)811663360;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				int a_ = 7;
				short num = (short)376045568;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)419233793;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					case 1:
						goto IL_DD;
					case 2:
						goto IL_11D;
					case 3:
						this.h = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("㥁瑃㭅片橉㝋罍ⵏ", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.General_Template_Name, value);
						num = (short)184352776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_1A9;
					case 5:
					{
						if (this.c != null)
						{
							num = (short)2044264457;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.h = value;
						num = (short)621215744;
						short num3 = num;
						num = (short)1154154500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						num = (short)1773316694;
						short num4 = num;
						num = (short)1744874070;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1505230848;
							if (num != 0)
							{
							}
							if (this.a != null)
							{
								num = (short)1183776775;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)542769157;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						this.h = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("㥁瑃㭅片橉㝋罍ⵏ", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Configuration_Name, value);
						num = (short)324403202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_15D;
					case 9:
						this.h = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("㥁瑃㭅片橉㝋罍ⵏ", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Configuration_Name, value);
						num = (short)64290817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7D:
					if (this.b != null)
					{
						num = (short)396361731;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)590544902;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_DD:
				IL_11D:
				IL_15D:
				IL_1A9:
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext.get_ApxTemplateName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00023AF4 File Offset: 0x00021CF4
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00023BA0 File Offset: 0x00021DA0
		public bool IsCancel
		{
			get
			{
				short num = (short)1955997050;
				short num2 = num;
				num = (short)2095916410;
				switch (num2 == num)
				{
				}
				num = (short)115867649;
				if (num != 0)
				{
				}
				num = (short)1117847552;
				if (num != 0)
				{
				}
				num = (short)472383488;
				short num3 = num;
				return this.i;
			}
			set
			{
				short num = (short)1194703026;
				short num2 = num;
				num = (short)27441330;
				switch (num2 == num)
				{
				}
				num = (short)875626497;
				if (num != 0)
				{
				}
				num = (short)839516160;
				if (num != 0)
				{
				}
				num = (short)957349888;
				short num3 = num;
				this.i = value;
				base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext.get_IsCancel())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x040000EB RID: 235
		private global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary a;

		// Token: 0x040000EC RID: 236
		private global::Motorola.CommonCPS.Server.EntityModel.APXTemplate b;

		// Token: 0x040000ED RID: 237
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Set c;

		// Token: 0x040000EE RID: 238
		private global::System.ComponentModel.ICollectionView d;

		// Token: 0x040000EF RID: 239
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.APXWiFiNetwork> e;

		// Token: 0x040000F0 RID: 240
		private bool f;

		// Token: 0x040000F1 RID: 241
		private bool g;

		// Token: 0x040000F2 RID: 242
		private string h;

		// Token: 0x040000F3 RID: 243
		private bool i;
	}
}
