using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using ACPBrowser;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.FieldsReport;
using AcpCommonLib.UndoRedo;
using AcpUI;
using AcpUI.Common;
using AcpUtility;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Ucl.Contact;

namespace SpecialFeatures.UCL.CallListUpdate
{
	// Token: 0x02000224 RID: 548
	public class UpdateUCL : global::System.Windows.Window, global::System.ComponentModel.INotifyPropertyChanged, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x002406DC File Offset: 0x0023E8DC
		public global::System.Collections.Generic.List<global::System.Windows.Controls.ComboBoxItem> SysTypeList
		{
			get
			{
				short num = (short)517472257;
				if (num != 0)
				{
				}
				num = (short)1682046976;
				short num2 = num;
				num = (short)2013678826;
				short num3 = num;
				num = (short)868961514;
				switch (num3 == num)
				{
				}
				num = (short)700907520;
				if (num != 0)
				{
				}
				return this.n;
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x0024078C File Offset: 0x0023E98C
		public global::System.Collections.Generic.List<global::System.Windows.Controls.ComboBoxItem> lstSystemName
		{
			get
			{
				short num = (short)1292762279;
				short num2 = num;
				num = (short)1282604199;
				switch (num2 == num)
				{
				default:
				{
					num = (short)595460096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2079195137;
				if (num != 0)
				{
				}
				num = (short)663093248;
				if (num != 0)
				{
				}
				return this.o;
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x0024083C File Offset: 0x0023EA3C
		// (set) Token: 0x06001BEA RID: 7146 RVA: 0x002408E8 File Offset: 0x0023EAE8
		public global::System.Windows.Controls.ComboBoxItem TypeSelection
		{
			get
			{
				short num = (short)68668793;
				short num2 = num;
				num = (short)996396409;
				switch (num2 == num)
				{
				}
				num = (short)546766849;
				if (num != 0)
				{
				}
				num = (short)1537605632;
				short num3 = num;
				num = (short)45809664;
				if (num != 0)
				{
				}
				return this.p;
			}
			set
			{
				short num = (short)177189350;
				short num2 = num;
				num = (short)402633190;
				switch (num2 == num)
				{
				}
				num = (short)916652032;
				if (num != 0)
				{
				}
				num = (short)1043988480;
				short num3 = num;
				num = (short)47579137;
				if (num != 0)
				{
				}
				this.p = value;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06001BEB RID: 7147 RVA: 0x00240998 File Offset: 0x0023EB98
		// (set) Token: 0x06001BEC RID: 7148 RVA: 0x00240A48 File Offset: 0x0023EC48
		public global::System.Windows.Controls.ComboBoxItem NameSelection
		{
			get
			{
				short num = (short)2062577595;
				short num2 = num;
				num = (short)803041211;
				switch (num2 == num)
				{
				}
				num = (short)501153793;
				if (num != 0)
				{
				}
				num = (short)366739456;
				short num3 = num;
				num = (short)1391853568;
				if (num != 0)
				{
				}
				return this.q;
			}
			set
			{
				short num = (short)1906165465;
				short num2 = num;
				num = (short)365479641;
				switch (num2 == num)
				{
				}
				num = (short)1572864001;
				if (num != 0)
				{
				}
				num = (short)1146290176;
				short num3 = num;
				num = (short)1634795520;
				if (num != 0)
				{
				}
				this.q = value;
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06001BED RID: 7149 RVA: 0x00240AF8 File Offset: 0x0023ECF8
		// (set) Token: 0x06001BEE RID: 7150 RVA: 0x00240BA8 File Offset: 0x0023EDA8
		public int Wacnid
		{
			get
			{
				short num = (short)1553130936;
				short num2 = num;
				num = (short)218490296;
				switch (num2 == num)
				{
				}
				num = (short)1693974529;
				if (num != 0)
				{
				}
				num = (short)1077608448;
				short num3 = num;
				num = (short)1616969728;
				if (num != 0)
				{
				}
				return this.r;
			}
			set
			{
				short num = (short)1458934587;
				short num2 = num;
				num = (short)1902940987;
				switch (num2 == num)
				{
				}
				num = (short)294453248;
				if (num != 0)
				{
				}
				num = (short)1979187200;
				short num3 = num;
				num = (short)1298071553;
				if (num != 0)
				{
				}
				this.r = value;
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06001BEF RID: 7151 RVA: 0x00240C58 File Offset: 0x0023EE58
		// (set) Token: 0x06001BF0 RID: 7152 RVA: 0x00240D08 File Offset: 0x0023EF08
		public int WacnidDecValue
		{
			get
			{
				short num = (short)168868867;
				short num2 = num;
				num = (short)138066947;
				switch (num2 == num)
				{
				}
				num = (short)1151860736;
				if (num != 0)
				{
				}
				num = (short)1549729792;
				short num3 = num;
				num = (short)2045771777;
				if (num != 0)
				{
				}
				return this.s;
			}
			set
			{
				int a_ = 0;
				short num = (short)634847233;
				if (num != 0)
				{
				}
				num = (short)480223459;
				short num2 = num;
				num = (short)75735267;
				switch (num2 == num)
				{
				}
				num = (short)1849688064;
				short num3 = num;
				num = (short)521207808;
				if (num != 0)
				{
				}
				this.s = value;
				this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풂쮎쎔", a_));
				this.d();
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x00240DD8 File Offset: 0x0023EFD8
		// (set) Token: 0x06001BF2 RID: 7154 RVA: 0x00240E98 File Offset: 0x0023F098
		public string WacnidHexValue
		{
			get
			{
				short num = (short)548064992;
				short num2 = num;
				num = (short)39243488;
				switch (num2 == num)
				{
				}
				num = (short)1039859713;
				if (num != 0)
				{
				}
				num = (short)590282752;
				short num3 = num;
				num = (short)1470169088;
				if (num != 0)
				{
				}
				return this.a(this.s, this.e);
			}
			set
			{
				int a_ = 11;
				short num = (short)1697490979;
				short num2 = num;
				num = (short)1755162659;
				switch (num2 == num)
				{
				}
				num = (short)609812481;
				if (num != 0)
				{
				}
				num = (short)942866432;
				short num3 = num;
				num = (short)578945024;
				if (num != 0)
				{
				}
				this.s = this.b(value);
				this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98d望ﾕﲗ튙鍊쎡좣펥춧", a_));
				this.d();
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x00240F70 File Offset: 0x0023F170
		// (set) Token: 0x06001BF4 RID: 7156 RVA: 0x0024101C File Offset: 0x0023F21C
		public int Systemid
		{
			get
			{
				short num = (short)2112487425;
				if (num != 0)
				{
				}
				num = (short)2023657401;
				short num2 = num;
				num = (short)1721405369;
				switch (num2 == num)
				{
				}
				num = (short)342884352;
				short num3 = num;
				num = (short)1732837376;
				if (num != 0)
				{
				}
				return this.t;
			}
			set
			{
				short num = (short)45545818;
				short num2 = num;
				num = (short)1111357786;
				switch (num2 == num)
				{
				}
				num = (short)1885667329;
				if (num != 0)
				{
				}
				num = (short)2135490560;
				short num3 = num;
				num = (short)155189248;
				if (num != 0)
				{
				}
				this.t = value;
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x002410CC File Offset: 0x0023F2CC
		// (set) Token: 0x06001BF6 RID: 7158 RVA: 0x0024117C File Offset: 0x0023F37C
		public int SystemidDecValue
		{
			get
			{
				short num = (short)1407516673;
				if (num != 0)
				{
				}
				num = (short)90591425;
				short num2 = num;
				num = (short)1664372929;
				switch (num2 == num)
				{
				}
				num = (short)805634048;
				short num3 = num;
				num = (short)494206976;
				if (num != 0)
				{
				}
				return this.u;
			}
			set
			{
				int a_ = 16;
				short num = (short)1281297986;
				short num2 = num;
				num = (short)193138242;
				switch (num2 == num)
				{
				}
				num = (short)786890752;
				if (num != 0)
				{
				}
				num = (short)1781727232;
				short num3 = num;
				num = (short)698351617;
				if (num != 0)
				{
				}
				this.u = value;
				this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삒ﺚ얠삤쒦ﾨ쪪솬\udaae풰", a_));
				this.d();
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001BF7 RID: 7159 RVA: 0x00241250 File Offset: 0x0023F450
		// (set) Token: 0x06001BF8 RID: 7160 RVA: 0x00241308 File Offset: 0x0023F508
		public string SystemidHexValue
		{
			get
			{
				short num = (short)544512063;
				short num2 = num;
				num = (short)960469055;
				switch (num2 == num)
				{
				}
				num = (short)833552384;
				if (num != 0)
				{
				}
				num = (short)587071488;
				short num3 = num;
				num = (short)2135883777;
				if (num != 0)
				{
				}
				return this.a(this.u, this.f);
			}
			set
			{
				int a_ = 6;
				short num = (short)1131591856;
				short num2 = num;
				num = (short)702789808;
				switch (num2 == num)
				{
				}
				num = (short)234815489;
				if (num != 0)
				{
				}
				num = (short)1218969600;
				short num3 = num;
				num = (short)1837498368;
				if (num != 0)
				{
				}
				this.u = this.b(value);
				this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda88ﺌﮎﺒﲔ톘ﺚ즞삠쾢키슦", a_));
				this.d();
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001BF9 RID: 7161 RVA: 0x002413E0 File Offset: 0x0023F5E0
		private int CurrentSystemId
		{
			get
			{
				short num;
				for (;;)
				{
					num = (short)1000407041;
					if (num != 0)
					{
					}
					if (!(this.NameSelection.Content.ToString() == this.b))
					{
						goto IL_99;
					}
					num = (short)1631452084;
					short num2 = num;
					num = (short)1507785652;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_7C;
					}
				}
				IL_7C:
				num = (short)419495936;
				if (num != 0)
				{
				}
				return this.SystemidDecValue;
				IL_99:
				num = (short)112787456;
				short num3 = num;
				return this.Systemid;
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001BFA RID: 7162 RVA: 0x002414B8 File Offset: 0x0023F6B8
		private int CurrentWacnId
		{
			get
			{
				short num;
				while (this.NameSelection.Content.ToString() == this.b)
				{
					num = (short)1653422976;
					short num2 = num;
					num = (short)1947089792;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)161284096;
						if (num != 0)
						{
						}
						return this.WacnidDecValue;
					}
				}
				num = (short)1158938625;
				if (num != 0)
				{
				}
				num = (short)520355840;
				short num3 = num;
				return this.Wacnid;
			}
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x0024158C File Offset: 0x0023F78C
		private void d()
		{
			short num = (short)1986854917;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_B4;
				case 1:
				{
					num = (short)1549533184;
					short num3 = num;
					goto IL_219;
				}
				case 2:
				{
					num = (short)402833619;
					short num4 = num;
					num = (short)1048232147;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B4;
					default:
						num = (short)988413952;
						if (num != 0)
						{
						}
						if (this.s < this.c)
						{
							num = (short)1815216132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.CustomWACNIDDec.IsAcpValid = true;
						this.CustomWACNIDHex.IsAcpValid = true;
						num = (short)769327112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_DD;
				case 4:
					goto IL_1C0;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_4E;
					}
					continue;
				case 6:
					num = (short)108658688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)1122369537;
					if (num != 0)
					{
					}
					num = (short)932118530;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_219;
				case 9:
					if (this.u <= this.f)
					{
						num = (short)751501318;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A7;
				}
				IL_4E:
				if (this.s <= this.e)
				{
					num = (short)1675493383;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1C0;
				IL_B4:
				if (this.u < this.d)
				{
					num = (short)412221443;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_25F;
				IL_1C0:
				this.CustomWACNIDDec.IsAcpValid = false;
				this.CustomWACNIDHex.IsAcpValid = false;
				num = (short)484573185;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_219:
				num = (short)428212233;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_DD:
			IL_1A7:
			this.SystemidDec.IsAcpValid = false;
			this.SystemidHex.IsAcpValid = false;
			return;
			IL_25F:
			this.SystemidDec.IsAcpValid = true;
			this.SystemidHex.IsAcpValid = true;
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x00241810 File Offset: 0x0023FA10
		public UpdateUCL()
		{
			int a_ = 1;
			this.b = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢃", a_) + global::CommonResources.AppResources.Customized_Id + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("몃", a_);
			this.c = 1;
			this.d = 1;
			this.e = 1048574;
			this.f = 65535;
			this.g = 1;
			this.h = 1;
			this.m = "";
			base..ctor();
			this.InitializeComponent();
			global::AcpUI.Common.Utility.SetDirection(this);
			this.txtboxAliasesListFilePath.Text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잃벅풇", a_);
			base.DataContext = this;
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x002418C4 File Offset: 0x0023FAC4
		private void UpdateUCL_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 11;
			short num = (short)1808269312;
			switch (num)
			{
			default:
			{
				num = (short)554827777;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general;
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.Controls.ComboBoxItem comboBoxItem;
						if (comboBoxItem != null)
						{
							num = (short)253952009;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5DC;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_80;
						}
						continue;
					case 2:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator = general.TrkSysGeneralSystemType_A9252.Items.GetEnumerator();
						goto IL_596;
					}
					case 3:
						goto IL_4D5;
					case 4:
						try
						{
							num = (short)1875574784;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_18E;
									}
									continue;
								case 1:
								{
									global::System.Windows.Controls.ComboBoxItem comboBoxItem2;
									global::System.Windows.Controls.ComboBoxItem comboBoxItem = comboBoxItem2;
									this.n.Insert(0, comboBoxItem2);
									num = (short)744357891;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpBusinessLayer.ListItem listItem;
									if (listItem.ItemName == global::CommonResources.AcgResources.ID_ASTRO25)
									{
										num = (short)1301807105;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.Controls.ComboBoxItem comboBoxItem2;
									this.n.Add(comboBoxItem2);
									num = (short)1514930187;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpBusinessLayer.ListItem listItem;
									if (listItem.ItemValidity)
									{
										num = (short)1393950725;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::System.Windows.Controls.ComboBoxItem comboBoxItem2 = new global::System.Windows.Controls.ComboBoxItem();
									global::AcpBusinessLayer.ListItem listItem;
									comboBoxItem2.Content = listItem.ItemName;
									num = (short)902823938;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_32F;
								case 7:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)768868361;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.ListItem listItem = enumerator.Current;
									num = (short)2047868936;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::AcpBusinessLayer.ListItem listItem;
									if (listItem.ItemVisibility)
									{
										num = (short)725090314;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									num = (short)455278598;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									num = (short)728432644;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_190:
								num = (short)1650851847;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_18E:
								goto IL_190;
							}
							IL_32F:
							goto IL_B4;
						}
						finally
						{
							num = (short)292421632;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_366;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1736900610;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_39E;
								}
								IL_366:
								if (enumerator == null)
								{
									break;
								}
								num = (short)239271937;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_39E:;
						}
						goto IL_3A1;
					case 5:
						if (general != null)
						{
							num = (short)2139750402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B4;
					case 6:
						goto IL_483;
					case 7:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						general = (featureNode[10157] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General);
						num = (short)2109997061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num = (short)82247681;
						if (num != 0)
						{
						}
						this.btnImport.IsEnabled = true;
						num = (short)658636811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						global::System.Windows.Controls.ComboBoxItem comboBoxItem;
						this.TypeSelection = comboBoxItem;
						num = (short)1611857926;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_3CA;
					case 11:
						goto IL_4D5;
					case 12:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						if (featureNode != null)
						{
							num = (short)1532166151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CA;
					}
					}
					IL_80:
					if (global::System.IO.File.Exists(this.txtboxAliasesListFilePath.Text.Trim()))
					{
						num = (short)1280049160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3A1;
					IL_B4:
					this.e = general.TrkSysGeneralHomeWACNID_A8205.Max;
					this.c = general.TrkSysGeneralHomeWACNID_A8205.Min;
					this.f = general.TrkSysGeneralSystemID_A9239.Max;
					this.d = general.TrkSysGeneralSystemID_A9239.Min;
					this.h = general.TrkSysGeneralSystemID_A9239.StepSize;
					this.g = general.TrkSysGeneralHomeWACNID_A8205.StepSize;
					num = (short)1034682378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A1:
					this.btnImport.IsEnabled = false;
					num = (short)1883242499;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3CA:
					this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8d삓ﾙ킛펟횡", a_));
					num = (short)608698368;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D5:
					num = (short)2020907644;
					short num3 = num;
					num = (short)695966332;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
					{
						IL_596:
						num = (short)935002112;
						short num4 = num;
						num = (short)1734541316;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					default:
					{
						num = (short)479395840;
						if (num != 0)
						{
						}
						this.n = new global::System.Collections.Generic.List<global::System.Windows.Controls.ComboBoxItem>();
						global::System.Windows.Controls.ComboBoxItem comboBoxItem = null;
						global::AcpBusinessLayer.FeatureNode featureNode = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset)[0] as global::AcpBusinessLayer.FeatureNode;
						num = (short)330235916;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_483:
				IL_5DC:
				this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8d얕ﶗ鍊ﶝ풟쮡쮣좥", a_));
				this.u = 1;
				this.s = 1;
				this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98d望ﾕﲗ\ude99鍊ﶝ쎡좣펥춧", a_));
				this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98d望ﾕﲗ튙鍊쎡좣펥춧", a_));
				this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8d\uda9d얟송장쒧\udfa9즫", a_));
				this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8d횝얟\udaa1장쒧\udfa9즫", a_));
				return;
			}
			}
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x00241F3C File Offset: 0x0024013C
		private string a(int A_0, int A_1)
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			int length;
			short num2;
			string text;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (length > 0)
					{
						num2 = (short)1866596353;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14D;
				case 1:
				{
					num2 = (short)1114832897;
					if (num2 != 0)
					{
					}
					num2 = (short)968739810;
					short num3 = num2;
					num2 = (short)274451426;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)2059468800;
						if (num2 != 0)
						{
						}
						text += length.ToString();
						break;
					}
					num2 = (short)353042434;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_14B;
				}
				goto IL_25;
			}
			IL_14B:
			IL_14D:
			return A_0.ToString(text);
			IL_25:
			text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("획", a_);
			length = A_1.ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("획", a_)).Trim().Length;
			num2 = (short)1470038016;
			short num4 = num2;
			num2 = (short)2082406400;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x002420A0 File Offset: 0x002402A0
		private int b(string A_0)
		{
			int result;
			short num;
			for (;;)
			{
				result = 0;
				if (!int.TryParse(A_0, global::System.Globalization.NumberStyles.HexNumber, null, out result))
				{
					goto IL_88;
				}
				num = (short)342163945;
				short num2 = num;
				num = (short)1604714985;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_49;
				}
			}
			IL_49:
			num = (short)1397096449;
			if (num != 0)
			{
			}
			num = (short)886177792;
			if (num != 0)
			{
			}
			return result;
			IL_88:
			num = (short)1617231872;
			short num3 = num;
			return 0;
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x00242160 File Offset: 0x00240360
		private void TextChanged(object A_0, global::System.Windows.Controls.TextChangedEventArgs A_1)
		{
			int a_ = 13;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_55;
				}
				int num;
				global::AcpUI.AcpTextBox acpTextBox;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						if (acpTextBox.Name.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎏ﶗ瞧잡잣", a_)))
						{
							num2 = (short)771293190;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1288175624;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						if (acpTextBox != null)
						{
							num2 = (short)1585381386;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_306;
					case 2:
						goto IL_306;
					case 3:
						this.SystemidDecValue = this.b(this.SystemidHex.Text);
						num2 = (short)1976500235;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						this.WacnidDecValue = this.b(this.CustomWACNIDHex.Text);
						num2 = (short)1411710981;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						goto IL_306;
					case 6:
						this.SystemidHexValue = this.a(global::System.Convert.ToInt32(this.SystemidDec.Text), this.f);
						num2 = (short)686161932;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						goto IL_31D;
					case 8:
						if (acpTextBox.Name.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎏ﶗ瞧잡\udca3", a_)))
						{
							num2 = (short)1562247171;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_306;
					case 9:
						this.WacnidHexValue = this.a(global::System.Convert.ToInt32(this.CustomWACNIDDec.Text), this.e);
						num2 = (short)1740505090;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 10:
						goto IL_193;
					case 11:
						goto IL_306;
					case 12:
						goto IL_306;
					case 13:
					{
						num2 = (short)222994744;
						short num3 = num2;
						num2 = (short)380543288;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_193;
						default:
							num2 = (short)1263730688;
							if (num2 != 0)
							{
							}
							if (acpTextBox.Name.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펏쮛\udf9d쾩쾫", a_)))
							{
								num2 = (short)1706622985;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)1638662158;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 14:
						if (acpTextBox.Name.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펏쮛\udf9d쾩풫", a_)))
						{
							num2 = (short)214171652;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)2124087296;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_55;
					IL_193:
					num2 = (short)586678285;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_306:
					num2 = (short)861011975;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_31D:
				goto IL_322;
				IL_55:
				acpTextBox = (A_0 as global::AcpUI.AcpTextBox);
				num2 = (short)203423745;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			catch
			{
			}
			IL_322:
			num2 = (short)1986658305;
			if (num2 != 0)
			{
			}
			num2 = (short)1344143360;
			short num4 = num2;
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x002424FC File Offset: 0x002406FC
		private void a(global::SpecialFeatures.UCL.CallListUpdate.UpdateUCL.ValueChangeType A_0)
		{
			int a_ = 2;
			short num = (short)1947467780;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.s < this.e)
					{
						num = (short)317587458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AD;
				case 1:
					num = (short)1214513179;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1554186269;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (this.u < this.f)
					{
						num = (short)1889140752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_51C;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_B1;
					}
					continue;
				case 5:
					goto IL_2D0;
				case 6:
					goto IL_1FF;
				case 7:
					goto IL_1AD;
				case 8:
					goto IL_420;
				case 9:
					if (this.s > this.c)
					{
						num = (short)803602453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_33A;
				case 10:
				{
					num = (short)1776025600;
					short num3 = num;
					if (A_0 == global::SpecialFeatures.UCL.CallListUpdate.UpdateUCL.ValueChangeType.downwacnid)
					{
						num = (short)86966302;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)487653401;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
					goto IL_2F6;
				case 12:
					goto IL_570;
				case 13:
					if (this.u < this.d)
					{
						num = (short)1131413518;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.u += this.h;
					num = (short)1002307590;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_51C;
				case 15:
					goto IL_540;
				case 16:
					num = (short)253362189;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_33A;
				case 18:
					num = (short)687210496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					num = (short)1876885530;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					if (this.s > this.e)
					{
						num = (short)2022506513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.s -= this.g;
					goto IL_558;
				case 21:
					num = (short)1739194388;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (A_0 == global::SpecialFeatures.UCL.CallListUpdate.UpdateUCL.ValueChangeType.downsystemid)
					{
						num = (short)1377632257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 23:
					goto IL_3A9;
				case 24:
					goto IL_335;
				case 25:
					if (A_0 == global::SpecialFeatures.UCL.CallListUpdate.UpdateUCL.ValueChangeType.upsystemid)
					{
						num = (short)693960732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1023016982;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					if (this.u > this.f)
					{
						num = (short)102105093;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.u -= this.h;
					num = (short)439549983;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					num = (short)1571946497;
					if (num != 0)
					{
					}
					if (this.u > this.d)
					{
						num = (short)1538195475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D0;
				case 28:
					num = (short)771620867;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					if (this.s < this.c)
					{
						num = (short)854327303;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.s += this.g;
					num = (short)1607794696;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					num = (short)811663369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					goto IL_2F6;
				case 32:
					goto IL_1D0;
				}
				IL_B1:
				if (A_0 == global::SpecialFeatures.UCL.CallListUpdate.UpdateUCL.ValueChangeType.upwacnid)
				{
					num = (short)1480327186;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1089798154;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AD:
				this.s = this.c;
				num = (short)512163872;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D0:
				this.u = this.f;
				num = (short)150470667;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2F6:
				this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횄ﺆ愈ﾊ톔滛춚ﲜ풠욢", a_));
				this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횄ﺆ愈ﾊ\udd94춚ﲜ풠욢", a_));
				num = (short)1341063192;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_33A:
				this.s = this.e;
				num = (short)976815772;
				short num4 = num;
				num = (short)2049050268;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_558:
					num = (short)1156513804;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				default:
					num = (short)94306304;
					if (num != 0)
					{
					}
					num = (short)21299223;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_51C:
				this.u = this.d;
				num = (short)1462435855;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D4:
			this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횄ﺆ愈ﾊ톔滛춚ﲜ풠욢", a_));
			this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횄ﺆ愈ﾊ\udd94춚ﲜ풠욢", a_));
			return;
			IL_143:
			this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튄햐솖爵", a_));
			this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튄\ud990솖爵", a_));
			return;
			IL_1D0:
			goto IL_143;
			IL_1FF:
			goto IL_D4;
			IL_335:
			return;
			IL_3A9:
			goto IL_572;
			IL_420:
			goto IL_143;
			IL_540:
			goto IL_D4;
			IL_570:
			IL_572:
			this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튄햐솖爵", a_));
			this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튄\ud990솖爵", a_));
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x00242B68 File Offset: 0x00240D68
		private void OnClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 15;
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			int num;
			global::System.Windows.Controls.Primitives.RepeatButton repeatButton;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (repeatButton.Name.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("작햕ﾛ\udba1힣튥춧잩얫쪭", a_), global::System.StringComparison.Ordinal))
					{
						num2 = (short)326631430;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)560136193;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)1388511233;
					if (num2 != 0)
					{
					}
					if (repeatButton.Name.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횑ﮓ\ud999쎟즡\udfa5\udba7\udea9즫쎭\ud9af횱", a_), global::System.StringComparison.Ordinal))
					{
						num2 = (short)824311813;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					if (repeatButton != null)
					{
						num2 = (short)1179254788;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					goto IL_14A;
				case 4:
					num2 = (short)1097269258;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					this.a(global::SpecialFeatures.UCL.CallListUpdate.UpdateUCL.ValueChangeType.downsystemid);
					num2 = (short)1110114307;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_11F;
				case 7:
					goto IL_19D;
				case 8:
				{
					if (repeatButton.Name.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횑ﮓ\ud999쎟즡펥\udba7\udea9쎫쎭ﺹ", a_), global::System.StringComparison.Ordinal))
					{
						num2 = (short)631046144;
						short num3 = num2;
						num2 = (short)1076297737;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)359812179;
					short num4 = num2;
					num2 = (short)1710246995;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19D;
					default:
						num2 = (short)335937536;
						if (num2 != 0)
						{
						}
						num2 = (short)700973056;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 9:
					goto IL_297;
				case 10:
					if (repeatButton.Name.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("작햕ﾛ힡힣튥잧잩ﮫﲱﶳ", a_), global::System.StringComparison.Ordinal))
					{
						num2 = (short)957218823;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1786839048;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_45;
			}
			IL_11F:
			this.a(global::SpecialFeatures.UCL.CallListUpdate.UpdateUCL.ValueChangeType.upsystemid);
			return;
			IL_14A:
			return;
			IL_19D:
			this.a(global::SpecialFeatures.UCL.CallListUpdate.UpdateUCL.ValueChangeType.upwacnid);
			return;
			IL_297:
			this.a(global::SpecialFeatures.UCL.CallListUpdate.UpdateUCL.ValueChangeType.downwacnid);
			return;
			IL_45:
			repeatButton = (A_0 as global::System.Windows.Controls.Primitives.RepeatButton);
			num2 = (short)1359609858;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x00242E14 File Offset: 0x00241014
		private void OnKeyPressUpDownEvent(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_6D;
			}
			short num2;
			global::AcpUI.AcpTextBox acpTextBox;
			for (;;)
			{
				IL_13:
				int num;
				global::System.Windows.Input.Key key;
				switch (num)
				{
				case 0:
					if (key == global::System.Windows.Input.Key.Down)
					{
						num2 = (short)719061011;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					num2 = (short)436404237;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_2DF;
				case 3:
					num2 = (short)743505924;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (key == global::System.Windows.Input.Key.Down)
					{
						num2 = (short)2024013841;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
					num2 = (short)615907337;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)1926103054;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)550305803;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (key != global::System.Windows.Input.Key.Up)
					{
						num2 = (short)195559427;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.a(global::SpecialFeatures.UCL.CallListUpdate.UpdateUCL.ValueChangeType.upsystemid);
					A_1.Handled = true;
					num2 = (short)236912660;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (!acpTextBox.Name.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪈ﺊﺌﮎﺐﺒ슔횖\uda98햚풜\udb9e욢욤", a_), global::System.StringComparison.Ordinal))
					{
						num2 = (short)2010644486;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2DF;
				case 10:
					num2 = (short)753467392;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					goto IL_242;
				case 12:
					if (acpTextBox != null)
					{
						num2 = (short)1946222593;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 13:
					if (acpTextBox != null)
					{
						num2 = (short)143523845;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 14:
					if (acpTextBox.Name.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪈ﺊﺌﮎﺐﺒ슔횖\uda98햚풜\udb9e욢\udda4", a_), global::System.StringComparison.Ordinal))
					{
						num2 = (short)1523318786;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1815281679;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					if (!acpTextBox.Name.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda88ﺌﮎﺒﲔ\udd98ﺚﺜ", a_), global::System.StringComparison.Ordinal))
					{
						num2 = (short)154599431;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_FC;
				case 16:
					goto IL_FC;
				case 17:
					goto IL_357;
				case 18:
					if (key != global::System.Windows.Input.Key.Up)
					{
						num2 = (short)1170079754;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_167;
				case 19:
					goto IL_41F;
				case 20:
					goto IL_2CB;
				}
				goto IL_6D;
				IL_FC:
				key = A_1.Key;
				num2 = (short)577765377;
				if (num2 != 0)
				{
				}
				num2 = (short)1442971656;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2DF:
				key = A_1.Key;
				num2 = (short)532545554;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_167:
			this.a(global::SpecialFeatures.UCL.CallListUpdate.UpdateUCL.ValueChangeType.upwacnid);
			A_1.Handled = true;
			return;
			IL_2CB:
			return;
			IL_357:
			this.a(global::SpecialFeatures.UCL.CallListUpdate.UpdateUCL.ValueChangeType.downsystemid);
			A_1.Handled = true;
			return;
			IL_41F:
			this.a(global::SpecialFeatures.UCL.CallListUpdate.UpdateUCL.ValueChangeType.downwacnid);
			A_1.Handled = true;
			return;
			IL_6D:
			acpTextBox = (A_0 as global::AcpUI.AcpTextBox);
			num2 = (short)1858155616;
			short num3 = num2;
			num2 = (short)25834592;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_242:
				num2 = (short)2056847360;
				short num4 = num2;
				if (acpTextBox.Name.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda88ﺌﮎﺒﲔ톘ﺚ", a_), global::System.StringComparison.Ordinal))
				{
					num2 = (short)747700240;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				break;
			}
			default:
			{
				num2 = (short)1643708416;
				if (num2 != 0)
				{
				}
				num2 = (short)955777036;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x00243248 File Offset: 0x00241448
		private void btnImport_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 15;
			short num = (short)520290304;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7F;
				}
				global::System.Collections.Specialized.NameValueCollection nameValueCollection;
				for (;;)
				{
					IL_30:
					bool flag;
					switch (num2)
					{
					case 0:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_27F;
							}
							global::SpecialFeatures.UCL.CallListUpdate.ICSVProvider provider;
							for (;;)
							{
								IL_25C:
								switch (num2)
								{
								case 0:
									global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, global::CommonResources.AppResources.Invalid_CSV_File, false);
									flag = true;
									num = (short)1927086086;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									num = (short)1831650735;
									short num3 = num;
									num = (short)1635239343;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2F3;
									default:
										goto IL_39D;
									}
									break;
								}
								case 2:
									nameValueCollection = provider.getUnitIdAndAliasList();
									num = (short)734527493;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (!flag)
									{
										num = (short)2027814914;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_34D;
								case 4:
									if (!provider.isCsvValid())
									{
										num = (short)1031798784;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2F5;
								case 5:
									goto IL_34D;
								case 6:
									goto IL_2F3;
								}
								goto IL_27F;
								IL_2F5:
								num = (short)591003651;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2F3:
								goto IL_2F5;
								IL_34D:
								num = (short)731381761;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_39D:
							num = (short)1943339008;
							if (num != 0)
							{
							}
							goto IL_5C7;
							IL_27F:
							provider = global::SpecialFeatures.UCL.CallListUpdate.CSVProvider.GetProvider(this.txtboxAliasesListFilePath.Text);
							num = (short)702283780;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_25C;
						}
						catch (global::System.Exception)
						{
							global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, global::CommonResources.AppResources.Import_Call_List_Aborted, false);
							flag = true;
							goto IL_5C7;
						}
						goto IL_3D0;
						IL_5C7:
						num = (short)276365328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1C7;
					case 2:
						if (flag)
						{
							num = (short)1572667406;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D0;
					case 3:
						goto IL_138;
					case 4:
						num = (short)1734344714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						global::AcpUI.Common.Utility.FieldsReportChanged(this, global::AcpCommonLib.FieldReportType.ImpExp);
						num = (short)648413185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return;
					case 7:
						if (global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.HasFields)
						{
							num = (short)485359627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
						if (global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.HasFields)
						{
							num = (short)1188167685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, global::CommonResources.AppResources.Console_Aliases_List_File_Empty, false);
						flag = true;
						num = (short)1606025229;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (nameValueCollection == null)
						{
							num = (short)2009464833;
							if (num != 0)
							{
							}
							num = (short)1783889929;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_564;
					case 11:
						global::AcpUI.Common.Utility.FieldsReportChanged(this, global::AcpCommonLib.FieldReportType.ImpExp);
						num = (short)20840454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						if (global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport == null)
						{
							num = (short)1058996239;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1114243072;
						short num4 = num;
						global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.Clear();
						num = (short)391839761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_564;
					case 14:
						base.Close();
						num = (short)824246280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport = new global::AcpCommonLib.FieldsReport.FieldsReportManager();
						num = (short)487522307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (!flag)
						{
							num = (short)1220870148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_564;
					case 17:
						goto IL_138;
					}
					goto IL_7F;
					IL_138:
					flag = false;
					num = (short)1883176960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D0:
					global::AcpCommonLib.UndoRedo.ContainerTask containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(global::CommonResources.AppResources.Call_List_Import);
					global::AcpBusinessLayer.UndoRedo.ModifyAppInfoStateTask task = new global::AcpBusinessLayer.UndoRedo.ModifyAppInfoStateTask(new global::System.Collections.Generic.Dictionary<string, bool>
					{
						{
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91煉톝킟잡횣장\udca7쎩쎫삭\uddb1\ud9b3욵풷\udfb9좻\udbbd꒿", a_),
							false
						},
						{
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91煉\udd9d쾟튡\udda3\ud8a7쾩\udeab쾭쒯\udbb1\udbb3\ud8b5", a_),
							true
						}
					});
					containerTask.AddTask(task);
					this.j = 0;
					this.k = 0;
					this.l = 0;
					this.UpdateCallList(nameValueCollection, containerTask);
					global::AcpBusinessLayer.UndoRedo.ModifyAppInfoStateTask task2 = new global::AcpBusinessLayer.UndoRedo.ModifyAppInfoStateTask(new global::System.Collections.Generic.Dictionary<string, bool>
					{
						{
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91煉톝킟잡횣장\udca7쎩쎫삭\uddb1\ud9b3욵풷\udfb9좻\udbbd꒿", a_),
							true
						},
						{
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91煉\udd9d쾟튡\udda3\ud8a7쾩\udeab쾭쒯\udbb1\udbb3\ud8b5", a_),
							false
						}
					});
					containerTask.AddTask(task2);
					global::AcpCommonLib.UndoRedo.UndoManager.AddTask(containerTask);
					base.Close();
					global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, global::CommonResources.AppResources.Import_Call_List_Completed, false);
					string message = global::CommonResources.AppResources.Is_Added.AcpStringFormat(new object[]
					{
						this.j
					});
					global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, message, false);
					message = global::CommonResources.AppResources.Is_Deleted.AcpStringFormat(new object[]
					{
						this.k
					});
					global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, message, false);
					message = global::CommonResources.AppResources.Is_Updated.AcpStringFormat(new object[]
					{
						this.l
					});
					global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, message, false);
					num = (short)690290695;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_564:
					num = (short)62259202;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_1C7:
				return;
				IL_7F:
				nameValueCollection = null;
				num = (short)1560150028;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x00243874 File Offset: 0x00241A74
		internal bool AddContactFromAliasList(global::SpecialFeatures.Ucl.Contact.UclContactRecset uclContactRecset, string key, string[] keyValues, global::AcpCommonLib.UndoRedo.ContainerTask importTask)
		{
			short num = (short)535101440;
			short num2 = num;
			global::SpecialFeatures.Ucl.Contact.UclContact uclContact = uclContactRecset.CreateDefaultRecord() as global::SpecialFeatures.Ucl.Contact.UclContact;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_62;
				}
				int num3;
				for (;;)
				{
					IL_40:
					switch (num3)
					{
					case 0:
						this.AddTrkAstroCallID(uclContact, keyValues, importTask);
						num = (short)1369505798;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1CA;
					case 2:
						if (this.TypeSelection.Content.ToString() == global::CommonResources.AcgResources.ID_II)
						{
							num = (short)262340613;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_159;
					case 3:
						goto IL_159;
					case 4:
						if (this.TypeSelection.Content.ToString() == global::CommonResources.AcgResources.ID_ASTRO25)
						{
							num = (short)1512636416;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1072955394;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						this.AddTrkIICallID(uclContact, keyValues, importTask);
						num = (short)925827075;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_159;
					}
					goto IL_62;
					IL_159:
					this.j++;
					num = (short)1295841616;
					short num4 = num;
					num = (short)337181008;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1CA;
					default:
						num = (short)1948254208;
						if (num != 0)
						{
						}
						num = (short)1563688961;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_1CA:
				goto IL_1CF;
				IL_62:
				importTask.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(uclContact));
				uclContact.General.UclGen_ContactAlias_A00009Value = key;
				num = (short)2144468996;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_40;
			}
			catch (global::System.Exception)
			{
			}
			IL_1CF:
			num = (short)2013331457;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x00243A98 File Offset: 0x00241C98
		internal void AddTrkAstroCallID(global::SpecialFeatures.Ucl.Contact.UclContact contact, string[] keyvalue, global::AcpCommonLib.UndoRedo.ContainerTask importTask)
		{
			short num = (short)1658912768;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_60;
				}
				string[] array;
				global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset trunkingCallListRecset;
				for (;;)
				{
					IL_29:
					int num3;
					string[] array2;
					string uclAstro25Trk_IndividualID_A00013_UIValue;
					global::SpecialFeatures.Ucl.Contact.TrunkingCallList trunkingCallList;
					switch (num2)
					{
					case 0:
					{
						global::System.Array.Copy(keyvalue, array, trunkingCallListRecset.CounterToMax);
						string message = global::CommonResources.AppResources.Call_IDs_Max_Reached.AcpStringFormat(new object[]
						{
							contact.KeyField
						});
						global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, message, false);
						num = (short)2060124161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_21E;
					case 2:
						if (num3 >= array2.Length)
						{
							num = (short)830734341;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uclAstro25Trk_IndividualID_A00013_UIValue = array2[num3];
						trunkingCallList = (trunkingCallListRecset.CreateDefaultRecord() as global::SpecialFeatures.Ucl.Contact.TrunkingCallList);
						importTask.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(trunkingCallList));
						num = (short)536281094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_223;
					case 4:
						goto IL_191;
					case 5:
						return;
					case 6:
					{
						num = (short)2116799026;
						short num4 = num;
						num = (short)1125304882;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_21E;
						case 1:
							break;
						default:
						{
							num = (short)1628504064;
							short num5 = num;
							break;
						}
						}
						num = (short)1933639681;
						if (num != 0)
						{
						}
						num = (short)48496640;
						if (num != 0)
						{
						}
						if (this.NameSelection.Content.ToString() != this.b)
						{
							num = (short)1702821898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						trunkingCallList.CallList.UclAstro25Trk_SystemAlias_A00010_UIValue = this.b;
						trunkingCallList.CallList.UclAstro25Trk_CustomizedWACNID_A00015_UIValue = this.WacnidDecValue;
						trunkingCallList.CallList.UclAstro25Trk_CustomizedWACNID_A00015_HexUIValue = this.WacnidHexValue;
						trunkingCallList.CallList.UclAstro25Trk_CustomizedHomeSystemID_A00016_UIValue = this.SystemidDecValue;
						trunkingCallList.CallList.UclAstro25Trk_CustomizedHomeSystemID_A00016_HexUIValue = this.SystemidHexValue;
						num = (short)190644231;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_223;
					case 8:
						goto IL_191;
					case 9:
						if (keyvalue.Length > trunkingCallListRecset.CounterToMax)
						{
							num = (short)2142502912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array = keyvalue;
						num = (short)720306187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						trunkingCallList.CallList.UclAstro25Trk_SystemAlias_A00010_UIValue = this.NameSelection.Content.ToString();
						num = (short)249233411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_364;
					}
					goto IL_60;
					IL_191:
					num = (short)1213333506;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_223:
					trunkingCallList.CallList.UclAstro25Trk_IndividualID_A00013_UIValue = uclAstro25Trk_IndividualID_A00013_UIValue;
					num3++;
					num = (short)1038680072;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_364:
					array2 = array;
					num3 = 0;
					num = (short)1224736772;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21E:
					goto IL_364;
				}
				return;
				IL_60:
				trunkingCallListRecset = (contact.TrunkingCallList.EmbeddedRecset as global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset);
				array = new string[trunkingCallListRecset.CounterToMax];
				num = (short)1016070153;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x00243E2C File Offset: 0x0024202C
		internal void AddTrkIICallID(global::SpecialFeatures.Ucl.Contact.UclContact contact, string[] keyvalue, global::AcpCommonLib.UndoRedo.ContainerTask importTask)
		{
			short num = (short)1467351040;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_60;
				}
				string[] array;
				global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset trunkingT2CallListRecset;
				for (;;)
				{
					IL_29:
					int num3;
					string[] array2;
					string uclT2Trk_IndividualID_A00019_UIValue;
					global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList trunkingT2CallList;
					switch (num2)
					{
					case 0:
					{
						global::System.Array.Copy(keyvalue, array, trunkingT2CallListRecset.CounterToMax);
						string message = global::CommonResources.AppResources.Call_IDs_Max_Reached.AcpStringFormat(new object[]
						{
							contact.KeyField
						});
						global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, message, false);
						num = (short)182059009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_1E4;
					case 2:
						if (num3 >= array2.Length)
						{
							num = (short)650838021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uclT2Trk_IndividualID_A00019_UIValue = array2[num3];
						trunkingT2CallList = (trunkingT2CallListRecset.CreateDefaultRecord() as global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList);
						importTask.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(trunkingT2CallList));
						num = (short)1706164230;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_1E9;
					case 4:
						goto IL_157;
					case 5:
						return;
					case 6:
					{
						num = (short)652737417;
						short num4 = num;
						num = (short)1486814089;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E4;
						case 1:
							break;
						default:
						{
							num = (short)1917386752;
							short num5 = num;
							break;
						}
						}
						num = (short)1858994177;
						if (num != 0)
						{
						}
						num = (short)84148224;
						if (num != 0)
						{
						}
						if (this.NameSelection.Content.ToString() != this.b)
						{
							num = (short)1573912586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						trunkingT2CallList.CallListT2.UclT2Trk_SystemAlias_A00017_UIValue = this.b;
						trunkingT2CallList.CallListT2.UclT2Trk_CustomizedSystemID_A00021_UIValue = this.SystemidDecValue;
						num = (short)1791688711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_1E9;
					case 8:
						goto IL_157;
					case 9:
						if (keyvalue.Length > trunkingT2CallListRecset.CounterToMax)
						{
							num = (short)1694302208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array = keyvalue;
						num = (short)1371340811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						trunkingT2CallList.CallListT2.UclT2Trk_SystemAlias_A00017_UIValue = this.NameSelection.Content.ToString();
						num = (short)1393229827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_32D;
					}
					goto IL_60;
					IL_157:
					num = (short)405471234;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E9:
					trunkingT2CallList.CallListT2.UclT2Trk_IndividualID_A00019_UIValue = uclT2Trk_IndividualID_A00019_UIValue;
					num3++;
					num = (short)1948057608;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32D:
					array2 = array;
					num3 = 0;
					num = (short)663617540;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E4:
					goto IL_32D;
				}
				return;
				IL_60:
				trunkingT2CallListRecset = (contact.TrunkingT2CallList.EmbeddedRecset as global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset);
				array = new string[trunkingT2CallListRecset.CounterToMax];
				num = (short)1071906825;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0024418C File Offset: 0x0024238C
		internal bool UpdateContactID(global::SpecialFeatures.Ucl.Contact.UclContactRecset uclContactRecset, string key, string[] keyValues, global::AcpCommonLib.UndoRedo.ContainerTask importTask)
		{
			short num = (short)1843724288;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A7;
				}
				global::SpecialFeatures.Ucl.Contact.UclContact uclContact;
				global::System.Collections.Generic.List<string> list2;
				for (;;)
				{
					IL_28:
					int num3;
					int num5;
					switch (num2)
					{
					case 0:
						goto IL_543;
					case 1:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset trunkingT2CallListRecset = uclContact.TrunkingT2CallList.EmbeddedRecset as global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset;
						global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
						num3 = 0;
						num = (short)612892672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)715849729;
						if (num != 0)
						{
						}
						num = (short)371720214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)2013134848;
						short num4 = num;
						global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset trunkingCallListRecset;
						global::System.Collections.Generic.List<string> list3;
						list2 = list2.GetRange(0, trunkingCallListRecset.CounterToMax + list3.Count);
						string message = global::CommonResources.AppResources.Call_IDs_Max_Reached.AcpStringFormat(new object[]
						{
							uclContact.KeyField
						});
						global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, message, false);
						num = (short)798883844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_323;
					case 5:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingCallList trunkingCallList;
						if (trunkingCallList.CallList.UclAstro25Trk_WACNID_A00011Value == this.CurrentWacnId)
						{
							num = (short)910688274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17A;
					}
					case 6:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset trunkingT2CallListRecset;
						global::System.Collections.Generic.List<string> list;
						list2 = list2.GetRange(0, trunkingT2CallListRecset.CounterToMax + list.Count);
						string message = global::CommonResources.AppResources.Call_IDs_Max_Reached.AcpStringFormat(new object[]
						{
							uclContact.KeyField
						});
						global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, message, false);
						num = (short)208601103;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)1255800837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_17A;
					case 9:
						try
						{
							global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset trunkingCallListRecset;
							global::System.Collections.Generic.List<string> list3;
							this.UpdateTrkAstroCallID(trunkingCallListRecset, uclContact, list3, list2, importTask);
							return true;
						}
						catch (global::System.Exception)
						{
							return true;
						}
						goto IL_5C9;
					case 10:
						goto IL_29B;
					case 11:
						try
						{
							global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset trunkingT2CallListRecset;
							global::System.Collections.Generic.List<string> list;
							this.UpdateTrkT2CallID(trunkingT2CallListRecset, uclContact, list, list2, importTask);
							return true;
						}
						catch (global::System.Exception)
						{
							return true;
						}
						goto IL_29B;
					case 12:
					{
						global::System.Collections.Generic.List<string> list3;
						if (this.UpdateCallIDsAreNeeded(list3, list2))
						{
							num = (short)1198129161;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 13:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingCallList trunkingCallList;
						if (trunkingCallList.CallList.UclAstro25Trk_HomeSystemID_A00012Value == this.CurrentSystemId)
						{
							num = (short)1666580487;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17A;
					}
					case 14:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset trunkingCallListRecset;
						global::System.Collections.Generic.List<string> list3;
						if (list2.Count > trunkingCallListRecset.CounterToMax + list3.Count)
						{
							num = (short)559087619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_323;
					}
					case 15:
						goto IL_2E0;
					case 16:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset trunkingCallListRecset;
						if (num5 > trunkingCallListRecset.Count - 1)
						{
							num = (short)500957213;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Ucl.Contact.TrunkingCallList trunkingCallList = trunkingCallListRecset[num5] as global::SpecialFeatures.Ucl.Contact.TrunkingCallList;
						num = (short)1579679757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						global::System.Collections.Generic.List<string> list;
						if (this.UpdateCallIDsAreNeeded(list, list2))
						{
							num = (short)634191883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 18:
					{
						global::System.Collections.Generic.List<string> list3;
						global::SpecialFeatures.Ucl.Contact.TrunkingCallList trunkingCallList;
						list3.Add(trunkingCallList.CallList.UclAstro25Trk_IndividualID_A00013Value.ToString());
						num = (short)572194824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						if (this.TypeSelection.Content.ToString() == global::CommonResources.AcgResources.ID_II)
						{
							num = (short)1473576961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 20:
						goto IL_29B;
					case 21:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset trunkingT2CallListRecset;
						if (num3 > trunkingT2CallListRecset.Count - 1)
						{
							num = (short)1828651010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList trunkingT2CallList = trunkingT2CallListRecset[num3] as global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList;
						num = (short)1795686426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset trunkingT2CallListRecset;
						global::System.Collections.Generic.List<string> list;
						if (list2.Count > trunkingT2CallListRecset.CounterToMax + list.Count)
						{
							num = (short)378077190;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E0;
					}
					case 23:
						if (this.TypeSelection.Content.ToString() == global::CommonResources.AcgResources.ID_ASTRO25)
						{
							num = (short)1425342488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C9;
					case 24:
					{
						for (;;)
						{
							num = (short)878581687;
							short num6 = num;
							num = (short)127342519;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_39D;
							}
						}
						IL_39D:
						num = (short)609091584;
						if (num != 0)
						{
						}
						global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset trunkingCallListRecset = uclContact.TrunkingCallList.EmbeddedRecset as global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset;
						global::System.Collections.Generic.List<string> list3 = new global::System.Collections.Generic.List<string>();
						num5 = 0;
						num = (short)1113456650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_11B;
					case 26:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList trunkingT2CallList;
						if (trunkingT2CallList.CallListT2.UclT2Trk_SystemID_A00018Value == this.CurrentSystemId)
						{
							num = (short)323747868;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11B;
					}
					case 27:
						goto IL_543;
					case 28:
					{
						global::System.Collections.Generic.List<string> list;
						global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList trunkingT2CallList;
						list.Add(trunkingT2CallList.CallListT2.UclT2Trk_IndividualID_A00019Value.ToString());
						num = (short)1483079705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						num = (short)242352142;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A7;
					IL_11B:
					num3++;
					num = (short)2042560539;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17A:
					num5++;
					num = (short)1883111444;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29B:
					num = (short)859504656;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E0:
					num = (short)317521937;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_323:
					num = (short)2109079564;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_543:
					num = (short)2033844245;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5C9:
					num = (short)805634067;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_A7:
				uclContact = (uclContactRecset.KeysToNode[key] as global::SpecialFeatures.Ucl.Contact.UclContact);
				list2 = new global::System.Collections.Generic.List<string>(keyValues);
				num = (short)2145910807;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x00244890 File Offset: 0x00242A90
		internal bool UpdateCallIDsAreNeeded(global::System.Collections.Generic.List<string> listCpg, global::System.Collections.Generic.List<string> listConsole)
		{
			short num = (short)135725056;
			switch (num)
			{
			default:
			{
				num = (short)62128129;
				int num2 = (int)((global::System.IntPtr)num);
				bool result;
				for (;;)
				{
					global::System.Collections.Generic.List<string>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						IL_318:
						try
						{
							num = (short)1969684481;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									result = true;
									num = (short)1754595330;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_B9;
									}
									continue;
								case 2:
									goto IL_14A;
								case 3:
									goto IL_168;
								case 4:
								{
									string item;
									if (!listCpg.Contains(item))
									{
										num = (short)525664256;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)173277190;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string item = enumerator.Current;
									num = (short)104988676;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1089470467;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_F8:
								num = (short)1038286853;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B9:
								goto IL_F8;
							}
							IL_14A:
							goto IL_31D;
							IL_168:
							goto IL_27D;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto Block_3;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_55;
						}
						continue;
					case 2:
						enumerator = listCpg.GetEnumerator();
						num = (short)14286851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_17B;
					}
					IL_55:
					if (listCpg != null)
					{
						num = (short)1369047042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
					Block_3:
					try
					{
						IL_17B:
						num = (short)1620639745;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								string item2;
								if (!listConsole.Contains(item2))
								{
									num = (short)417726469;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1BD;
								}
								continue;
							case 2:
								num = (short)631111683;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_26D;
							case 4:
								goto IL_1D6;
							case 5:
								result = true;
								num = (short)699924484;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)2138701826;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								string item2 = enumerator.Current;
								num = (short)1656422400;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_219:
							num = (short)788135942;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1BD:
							goto IL_219;
						}
						IL_1D6:
						goto IL_31D;
						IL_26D:
						goto IL_2CD;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					break;
					IL_2CD:
					num = (short)700514304;
					short num3 = num;
					enumerator = listConsole.GetEnumerator();
					num = (short)1642135552;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_31D:
					num = (short)727452943;
					short num4 = num;
					num = (short)1970081039;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_318;
					default:
						goto IL_351;
					}
				}
				IL_27D:
				num = (short)1992818689;
				if (num != 0)
				{
				}
				return false;
				IL_351:
				num = (short)372899840;
				if (num != 0)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x00244C24 File Offset: 0x00242E24
		internal void UpdateTrkAstroCallID(global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset trkAstroRecset, global::SpecialFeatures.Ucl.Contact.UclContact matchingContact, global::System.Collections.Generic.List<string> list, global::System.Collections.Generic.List<string> callIDsFromConsole, global::AcpCommonLib.UndoRedo.ContainerTask importTask)
		{
			short num = (short)1175846912;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_CB;
				}
				int num4;
				string message;
				for (;;)
				{
					IL_28:
					int num5;
					int num7;
					int num8;
					switch (num2)
					{
					case 0:
					{
						num = (short)1960050688;
						short num3 = num;
						string[] keyvalue = callIDsFromConsole.ToArray();
						num = (short)55443472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						string[] keyvalue;
						this.AddTrkAstroCallID(matchingContact, keyvalue, importTask);
						num = (short)641269780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num4 = trkAstroRecset.Count - 1 - num5;
						num = (short)195166229;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingCallList trunkingCallList;
						string item = trunkingCallList.CallList.UclAstro25Trk_IndividualID_A00013Value.ToString();
						num = (short)287768595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)965935121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						num = (short)781365201;
						short num6 = num;
						num = (short)1798418385;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_228;
						default:
							num = (short)590872576;
							if (num != 0)
							{
							}
							goto IL_20B;
						}
						break;
					}
					case 6:
						goto IL_39B;
					case 7:
						goto IL_20B;
					case 8:
						goto IL_33F;
					case 9:
						goto IL_312;
					case 10:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingCallList trunkingCallList;
						if (trunkingCallList.CallList.UclAstro25Trk_HomeSystemID_A00012Value == this.CurrentSystemId)
						{
							num = (short)1249181720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C5;
					}
					case 11:
					{
						string[] keyvalue2;
						this.AddTrkAstroCallID(matchingContact, keyvalue2, importTask);
						num = (short)1657012233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						if (list != null)
						{
							num = (short)1255079969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] keyvalue2 = callIDsFromConsole.ToArray();
						num = (short)1605042203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingCallList trunkingCallList;
						if (trunkingCallList.CallList.UclAstro25Trk_WACNID_A00011Value == this.CurrentWacnId)
						{
							num = (short)1227030531;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C5;
					}
					case 14:
						goto IL_33F;
					case 15:
						goto IL_1C0;
					case 16:
						if (trkAstroRecset.CounterToMax > 0)
						{
							num = (short)725024769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						message = global::CommonResources.AppResources.Call_IDs_Max_Reached.AcpStringFormat(new object[]
						{
							matchingContact.KeyField
						});
						global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, message, false);
						num = (short)166526991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingCallList trunkingCallList2;
						if (trunkingCallList2.CallList.UclAstro25Trk_WACNID_A00011Value == this.CurrentWacnId)
						{
							num = (short)504889373;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BD;
					}
					case 18:
						num = (short)1231880198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						string item;
						if (!callIDsFromConsole.Contains(item))
						{
							num = (short)347406361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						callIDsFromConsole.Remove(item);
						num = (short)1609826312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						goto IL_33A;
					case 21:
						goto IL_55D;
					case 22:
						goto IL_3E4;
					case 23:
					{
						if (num5 > trkAstroRecset.Count - 1)
						{
							num = (short)1231290402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Ucl.Contact.TrunkingCallList trunkingCallList = trkAstroRecset[num5] as global::SpecialFeatures.Ucl.Contact.TrunkingCallList;
						num = (short)764936202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						num = (short)183107597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingCallList trunkingCallList;
						importTask.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyUIValueTask<string>(trunkingCallList.CallList.UclAstro25Trk_IndividualID_A00013Object, callIDsFromConsole[0]));
						callIDsFromConsole.RemoveAt(0);
						num = (short)850133006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						goto IL_3DF;
					case 27:
						if (trkAstroRecset.CounterToMax > 0)
						{
							num = (short)1265500171;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						message = global::CommonResources.AppResources.Call_IDs_Max_Reached.AcpStringFormat(new object[]
						{
							matchingContact.KeyField
						});
						global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, message, false);
						num = (short)174719002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (num4 > 0)
						{
							num = (short)1292304414;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_772;
					case 29:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingCallList trunkingCallList2;
						importTask.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(trunkingCallList2));
						num = (short)281215014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						num7 = trkAstroRecset.Count - 1;
						num8 = 0;
						num = (short)717488135;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (callIDsFromConsole.Count > 0)
						{
							num = (short)135790592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2031222812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
					{
						if (num8 >= num4)
						{
							goto IL_228;
						}
						global::SpecialFeatures.Ucl.Contact.TrunkingCallList trunkingCallList2 = trkAstroRecset[num7] as global::SpecialFeatures.Ucl.Contact.TrunkingCallList;
						num = (short)382140452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						num5 = 0;
						num = (short)1008402454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						goto IL_55D;
					case 35:
						if (callIDsFromConsole.Count == 0)
						{
							num = (short)739442690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C5;
					case 36:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingCallList trunkingCallList2;
						if (trunkingCallList2.CallList.UclAstro25Trk_HomeSystemID_A00012Value == this.CurrentSystemId)
						{
							num = (short)336855044;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BD;
					}
					case 37:
						goto IL_3E4;
					case 38:
						goto IL_6BD;
					}
					goto IL_CB;
					IL_20B:
					num = (short)332005408;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_228:
					num = (short)751894546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33F:
					num = (short)1878655011;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E4:
					num = (short)1925971991;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C5:
					num5++;
					num = (short)1555169317;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_55D:
					num = (short)1370423327;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6BD:
					num7--;
					num8++;
					num = (short)400752645;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1C0:
				IL_312:
				IL_33A:
				IL_39B:
				IL_3DF:
				IL_772:
				this.l++;
				return;
				IL_CB:
				num4 = 0;
				message = string.Empty;
				num = (short)748290049;
				if (num != 0)
				{
				}
				num = (short)1072758796;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x002453B4 File Offset: 0x002435B4
		internal void UpdateTrkT2CallID(global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset trkIIRecset, global::SpecialFeatures.Ucl.Contact.UclContact matchingContact, global::System.Collections.Generic.List<string> list, global::System.Collections.Generic.List<string> callIDsFromConsole, global::AcpCommonLib.UndoRedo.ContainerTask importTask)
		{
			short num = (short)675020800;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_BA;
				}
				int num4;
				string message;
				for (;;)
				{
					IL_27:
					int num3;
					int num5;
					int num8;
					switch (num2)
					{
					case 0:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList trunkingT2CallList;
						importTask.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyUIValueTask<string>(trunkingT2CallList.CallListT2.UclT2Trk_IndividualID_A00019Object, callIDsFromConsole[0]));
						callIDsFromConsole.RemoveAt(0);
						num = (short)1650655241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						if (num3 >= num4)
						{
							num = (short)1470693410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList trunkingT2CallList2 = trkIIRecset[num3] as global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList;
						num = (short)843120645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num4 = trkIIRecset.Count - 1 - num5;
						num = (short)274896093;
						short num6 = num;
						num = (short)590845149;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3CD;
						default:
							num = (short)216530944;
							if (num != 0)
							{
							}
							num = (short)183959585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_2B3;
					case 4:
					{
						num = (short)24248320;
						short num7 = num;
						goto IL_387;
					}
					case 5:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList trunkingT2CallList2;
						if (trunkingT2CallList2.CallListT2.UclT2Trk_SystemID_A00018Value == this.CurrentSystemId)
						{
							num = (short)1169031200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_696;
					}
					case 6:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList trunkingT2CallList;
						if (trunkingT2CallList.CallListT2.UclT2Trk_SystemID_A00018Value == this.CurrentSystemId)
						{
							num = (short)2046558232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A1;
					}
					case 7:
						goto IL_579;
					case 8:
					{
						if (list != null)
						{
							num = (short)592445469;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] keyvalue = callIDsFromConsole.ToArray();
						num = (short)2079653910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_2B8;
					case 10:
						goto IL_2B8;
					case 11:
					{
						string[] keyvalue2 = callIDsFromConsole.ToArray();
						num = (short)2056912908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (trkIIRecset.CounterToMax > 0)
						{
							num = (short)74317841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						message = global::CommonResources.AppResources.Call_IDs_Max_Reached.AcpStringFormat(new object[]
						{
							matchingContact.KeyField
						});
						global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, message, false);
						num = (short)7143449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_696;
					case 14:
					{
						string item;
						if (!callIDsFromConsole.Contains(item))
						{
							num = (short)1769865216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						callIDsFromConsole.Remove(item);
						num = (short)1742995466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						if (num4 > 0)
						{
							num = (short)1779171348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BF;
					case 16:
						goto IL_28B;
					case 17:
					{
						string[] keyvalue2;
						this.AddTrkIICallID(matchingContact, keyvalue2, importTask);
						num = (short)1574240259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
					{
						if (num5 > trkIIRecset.Count - 1)
						{
							num = (short)161939463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList trunkingT2CallList = trkIIRecset[num5] as global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList;
						num = (short)1541079046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						string[] keyvalue;
						this.AddTrkIICallID(matchingContact, keyvalue, importTask);
						num = (short)752156688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						num8 = trkIIRecset.Count - 1;
						num3 = 0;
						num = (short)1867448347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_387;
					case 22:
						if (trkIIRecset.CounterToMax > 0)
						{
							num = (short)1381761043;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						message = global::CommonResources.AppResources.Call_IDs_Max_Reached.AcpStringFormat(new object[]
						{
							matchingContact.KeyField
						});
						global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, message, false);
						num = (short)1549533214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (callIDsFromConsole.Count > 0)
						{
							num = (short)1688535051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1897136143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList trunkingT2CallList;
						string item = trunkingT2CallList.CallListT2.UclT2Trk_IndividualID_A00019Value.ToString();
						num = (short)238288910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_16B;
					case 26:
						goto IL_4EB;
					case 27:
						goto IL_4EB;
					case 28:
						goto IL_1AF;
					case 29:
						num5 = 0;
						goto IL_3CD;
					case 30:
						goto IL_382;
					case 31:
						if (callIDsFromConsole.Count == 0)
						{
							num = (short)1735065602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A1;
					case 32:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList trunkingT2CallList2;
						importTask.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(trunkingT2CallList2));
						num = (short)1020526605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						goto IL_579;
					case 34:
						num = (short)1811152924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BA;
					IL_2B8:
					num = (short)1185873951;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_387:
					num = (short)471269394;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3CD:
					num = (short)1122697237;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A1:
					num5++;
					num = (short)675807236;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4EB:
					num = (short)537067521;
					if (num != 0)
					{
					}
					num = (short)474480641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_579:
					num = (short)88604695;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_696:
					num8--;
					num3++;
					num = (short)951517210;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_16B:
				IL_1AF:
				IL_28B:
				IL_2B3:
				IL_382:
				IL_6BF:
				this.l++;
				return;
				IL_BA:
				num4 = 0;
				message = string.Empty;
				num = (short)1499267080;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x00245A90 File Offset: 0x00243C90
		internal bool DeleteExtraCallIDs(global::System.Collections.Specialized.NameValueCollection collection, global::AcpCommonLib.UndoRedo.ContainerTask importTask)
		{
			short num = (short)480706560;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				global::SpecialFeatures.Ucl.Contact.UclContactRecset uclContactRecset;
				int num5;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_98;
					case 1:
						goto IL_D5;
					case 2:
						try
						{
							num = (short)1296236574;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								global::SpecialFeatures.Ucl.Contact.UclContact uclContact;
								bool flag;
								int num3;
								int num4;
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_2E5;
								case 1:
									goto IL_81C;
								case 2:
									this.i = uclContact;
									result = false;
									num = (short)1113849868;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (flag)
									{
										num = (short)1932656655;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_8C4;
								case 4:
									goto IL_872;
								case 5:
									if (this.TypeSelection.Content.ToString() == global::CommonResources.AcgResources.ID_II)
									{
										num = (short)800194586;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_872;
								case 6:
									goto IL_6EC;
								case 7:
								{
									global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList trunkingT2CallList;
									if (trunkingT2CallList.CallListT2.UclT2Trk_SystemID_A00018Value == this.CurrentSystemId)
									{
										num = (short)1959067668;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_81C;
								}
								case 8:
									this.l++;
									num = (short)1201471502;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset trunkingCallListRecset;
									if (num3 >= trunkingCallListRecset.Count)
									{
										num = (short)1630732319;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.Ucl.Contact.TrunkingCallList trunkingCallList = trunkingCallListRecset[num3] as global::SpecialFeatures.Ucl.Contact.TrunkingCallList;
									num = (short)863502357;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									if (!flag)
									{
										num = (short)941817864;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_30A;
								case 11:
									num = (short)1278410762;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_8C2;
								case 13:
									goto IL_8DC;
								case 14:
									goto IL_30A;
								case 15:
									num = (short)1071841315;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
								{
									global::SpecialFeatures.Ucl.Contact.TrunkingCallList trunkingCallList;
									if (trunkingCallList.CallList.UclAstro25Trk_WACNID_A00011Value == this.CurrentWacnId)
									{
										num = (short)1504641057;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2E5;
								}
								case 17:
									num = (short)1817313314;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
								{
									bool flag2;
									if (flag2)
									{
										num = (short)362610699;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_30A;
								}
								case 19:
								{
									global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset trunkingCallListRecset = uclContact.TrunkingCallList.EmbeddedRecset as global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset;
									num3 = 0;
									num = (short)1732444188;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 20:
								{
									global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList trunkingT2CallList;
									importTask.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(trunkingT2CallList));
									bool flag2 = true;
									num4--;
									num = (short)304611329;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 21:
								{
									global::SpecialFeatures.Ucl.Contact.TrunkingCallList trunkingCallList;
									if (trunkingCallList.CallList.UclAstro25Trk_HomeSystemID_A00012Value == this.CurrentSystemId)
									{
										num = (short)158859296;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2E5;
								}
								case 22:
								{
									global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset trunkingT2CallListRecset;
									if (num4 >= trunkingT2CallListRecset.Count)
									{
										num = (short)1018036228;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList trunkingT2CallList = trunkingT2CallListRecset[num4] as global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList;
									num = (short)1995374599;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 23:
									try
									{
										num = (short)731774982;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_65F;
											case 1:
												goto IL_679;
											case 2:
												goto IL_65F;
											case 3:
												if (!enumerator.MoveNext())
												{
													num = (short)587202562;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)1669660677;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
												flag = false;
												num = (short)978190336;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
												if (!enumerator.Current._IsEmpty)
												{
													num = (short)203358212;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 6:
												switch (0)
												{
												case 0:
													goto IL_5CC;
												}
												continue;
											}
											IL_608:
											num = (short)1354104835;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_5CC:
											goto IL_608;
											IL_65F:
											num = (short)1780088833;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_679:
										goto IL_4BF;
									}
									finally
									{
										num = (short)1630208002;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												enumerator.Dispose();
												num = (short)587923457;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_6E9;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_6B1;
												}
												continue;
											}
											IL_6B1:
											if (enumerator == null)
											{
												break;
											}
											num = (short)2061238272;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_6E9:;
									}
									goto IL_6EC;
									IL_4BF:
									num = (short)1372848146;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
									goto IL_8C4;
								case 25:
									goto IL_872;
								case 26:
								{
									global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset trunkingT2CallListRecset = uclContact.TrunkingT2CallList.EmbeddedRecset as global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset;
									num4 = 0;
									num = (short)2011889693;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 27:
									goto IL_2A1;
								case 28:
									goto IL_6EC;
								case 29:
									goto IL_2A1;
								case 30:
									switch (0)
									{
									case 0:
										goto IL_1E2;
									}
									continue;
								case 31:
									num = (short)1601634329;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 32:
									num = (short)888733712;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 33:
								{
									global::SpecialFeatures.Ucl.Contact.TrunkingCallList trunkingCallList;
									importTask.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(trunkingCallList));
									bool flag2 = true;
									num3--;
									num = (short)1129250816;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 34:
									if (this.TypeSelection.Content.ToString() == global::CommonResources.AcgResources.ID_ASTRO25)
									{
										num = (short)2078015507;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1899429893;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 35:
								{
									if (uclContactRecset.CounterToMin != 0)
									{
										this.DeleteEmptyContact(uclContact, importTask);
										num5--;
										num = (short)601227288;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)713430543;
									short num6 = num;
									num = (short)1565529615;
									switch ((num6 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_872;
									default:
										num = (short)898564096;
										if (num != 0)
										{
										}
										num = (short)1400569858;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_1E2:
								if (global::System.Array.IndexOf<string>(collection.AllKeys, uclContact.ReferenceKey) == -1)
								{
									num = (short)445775889;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_8C4;
								IL_2A1:
								num = (short)1685520406;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2E5:
								num3++;
								num = (short)1624834054;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_30A:
								num = (short)321585155;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6EC:
								num = (short)422117385;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_81C:
								num4++;
								num = (short)374013979;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_872:
								flag = true;
								enumerator = uclContact.EmbeddedRecordsets.GetEnumerator();
								num = (short)710803479;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8C4:
								num = (short)988217357;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8C2:
							return result;
							IL_8DC:;
						}
						catch (global::System.Exception)
						{
						}
						num5++;
						num = (short)1483145216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						if (num5 >= uclContactRecset.Count)
						{
							num = (short)671678465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Ucl.Contact.UclContact uclContact = uclContactRecset[num5] as global::SpecialFeatures.Ucl.Contact.UclContact;
						bool flag2 = false;
						num = (short)1181024258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)945029121;
						if (num != 0)
						{
						}
						goto IL_98;
					}
					goto IL_43;
					IL_98:
					num = (short)1026818051;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D5:
				num = (short)1269366784;
				short num7 = num;
				return true;
				IL_43:
				uclContactRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2200) as global::SpecialFeatures.Ucl.Contact.UclContactRecset);
				num5 = 0;
				num = (short)795082756;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x002463D8 File Offset: 0x002445D8
		internal bool DeleteEmptyContact(global::AcpBusinessLayer.FeatureNode node, global::AcpCommonLib.UndoRedo.ContainerTask importTask)
		{
			short num = (short)1252786177;
			if (num != 0)
			{
			}
			num = (short)322502664;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_2A4;
				case 1:
					goto IL_25E;
				case 2:
					num = (short)612368388;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					try
					{
						num = (short)1418461188;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_198;
							case 1:
								goto IL_180;
							case 3:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)65142785;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								((global::AcpBusinessLayer.AcpFieldBase)enumerator.Current).ResetToDefaultWithUndo(importTask);
								num = (short)1515051117;
								short num3 = num;
								num = (short)1528420461;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_180;
								default:
									num = (short)1354432512;
									if (num != 0)
									{
									}
									num = (short)1173356546;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 4:
								switch (0)
								{
								case 0:
									goto IL_D2;
								}
								continue;
							}
							IL_D4:
							num = (short)1110638595;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_D2:
							goto IL_D4;
							IL_180:
							num = (short)542572544;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_198:
						goto IL_25E;
					}
					finally
					{
						num = (short)518782978;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1641545729;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_201;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1CE;
								}
								continue;
							}
							IL_1CE:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1532166144;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_201:;
					}
					goto IL_204;
				case 4:
					goto IL_25E;
				case 5:
					if (node.KeyField.ReferencingFields.Count <= 0)
					{
						num = (short)1199570944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_204;
				case 6:
				{
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator = node.KeyField.ReferencingFields[0].Parent.FieldsCollection.GetEnumerator();
					num = (short)1937244163;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					if (node.KeyField.ReferencingFields[0].ParentNode.Parent.CounterToMin == 0)
					{
						num = (short)669253638;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					importTask.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask((global::AcpBusinessLayer.FeatureNode)node.KeyField.ReferencingFields[0].ParentNode));
					num = (short)1717633025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_71;
					}
					continue;
				}
				IL_71:
				if (node.KeyField.IsReferenced)
				{
					num = (short)2080636930;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_204:
				num = (short)314834951;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_25E:
				num = (short)184156165;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2A4:
			num = (short)726269952;
			short num4 = num;
			importTask.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(node));
			this.k++;
			this.i = null;
			return true;
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x00246790 File Offset: 0x00244990
		internal void UpdateCallList(global::System.Collections.Specialized.NameValueCollection collection, global::AcpCommonLib.UndoRedo.ContainerTask importTask)
		{
			short num = (short)1864105984;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3F;
				}
				global::SpecialFeatures.Ucl.Contact.UclContactRecset uclContactRecset;
				for (;;)
				{
					IL_28:
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						this.DeleteExtraCallIDs(collection, importTask);
						num = (short)2001731586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						try
						{
							num = (short)616628235;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (this.ckDeleteExtra.Value)
									{
										num = (short)1936588802;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									goto IL_3B8;
								case 2:
									num = (short)738852878;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_285;
								case 4:
									if (uclContactRecset.CounterToMin > 0)
									{
										num = (short)1244528653;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, global::CommonResources.AppResources.UCL_Max_Reached, false);
									num = (short)341573635;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)785711119;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text = (string)enumerator.Current;
									string[] values = collection.GetValues(text);
									num = (short)1118109705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									num = (short)1871039594;
									short num3 = num;
									num = (short)1444990058;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_21C;
									default:
										num = (short)1622736896;
										if (num != 0)
										{
										}
										num = (short)982974480;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									num = (short)589430788;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									string text;
									if (!uclContactRecset.KeysToNode.Contains(text))
									{
										num = (short)226361351;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string[] values;
									this.UpdateContactID(uclContactRecset, text, values, importTask);
									num = (short)1835335692;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									switch (0)
									{
									case 0:
										goto IL_128;
									}
									continue;
								case 13:
									this.DeleteEmptyContact(this.i, importTask);
									num = (short)71827466;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									if (this.i != null)
									{
										num = (short)1196556296;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 15:
									goto IL_21C;
								case 16:
								{
									if (uclContactRecset.CounterToMax == 0)
									{
										num = (short)375783429;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text;
									string[] values;
									this.AddContactFromAliasList(uclContactRecset, text, values, importTask);
									num = (short)1379860480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1E0:
								num = (short)1158414342;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_128:
								goto IL_1E0;
								IL_21C:
								num = (short)201392129;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_285:
							IL_3B8:
							goto IL_47A;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_3DA;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_3C7:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)661716993;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_42F;
								case 2:
									if (disposable != null)
									{
										num = (short)3932160;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_431;
								}
								goto IL_3DA;
							}
							IL_42F:
							IL_431:
							goto EndFinally_11;
							IL_3DA:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)389218306;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_3C7;
							EndFinally_11:;
						}
						goto IL_432;
					case 2:
						goto IL_432;
					case 3:
					{
						num = (short)1975320576;
						short num4 = num;
						if (this.ckDeleteExtra.Value)
						{
							num = (short)2120089600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_432;
					}
					}
					goto IL_3F;
					IL_432:
					enumerator = collection.GetEnumerator();
					num = (short)2108030977;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_47A:
				num = (short)1568538625;
				if (num != 0)
				{
				}
				return;
				IL_3F:
				uclContactRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2200) as global::SpecialFeatures.Ucl.Contact.UclContactRecset);
				num = (short)138412035;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x00246C5C File Offset: 0x00244E5C
		private void c()
		{
			int a_ = 7;
			short num = (short)874446626;
			short num2 = num;
			num = (short)111017762;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)607387648;
				short num3 = num;
				num = (short)1147666432;
				if (num != 0)
				{
				}
				this.o = new global::System.Collections.Generic.List<global::System.Windows.Controls.ComboBoxItem>();
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset).GetEnumerator();
				try
				{
					num = (short)1371734019;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							global::System.Windows.Controls.ComboBoxItem comboBoxItem = new global::System.Windows.Controls.ComboBoxItem();
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general;
							comboBoxItem.Content = general.TrkSysGeneralKeyofTrunkingSystem_A12658_UIValue;
							this.o.Add(comboBoxItem);
							num = (short)2010644484;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)506724357;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general = enumerator.Current[10157] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General;
							num = (short)1412825090;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general;
							if (general.TrkSysGeneralSystemType_A9252_UIValue == this.TypeSelection.Content.ToString())
							{
								num = (short)400490496;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_DD;
							}
							continue;
						case 5:
							num = (short)1673003014;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_1CD;
						}
						IL_141:
						num = (short)1308360705;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_DD:
						goto IL_141;
					}
					IL_1CD:;
				}
				finally
				{
					num = (short)890830848;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1FF;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)498728962;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_232;
						}
						IL_1FF:
						if (enumerator == null)
						{
							break;
						}
						num = (short)307101697;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_232:;
				}
				break;
			}
			}
			num = (short)792199169;
			if (num != 0)
			{
			}
			this.a = new global::System.Windows.Controls.ComboBoxItem();
			this.a.Content = this.b;
			this.o.Add(this.a);
			this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾋ揄쎏ﶗ튛ﾝ춟잡", a_));
			this.NameSelection = this.o[0];
			this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒉솑歹ﶗ蓮쾟첡", a_));
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x00246F4C File Offset: 0x0024514C
		private void b()
		{
			int a_ = 11;
			short num = (short)1848311809;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num2)
				{
				case 0:
				{
					num = (short)982705544;
					short num3 = num;
					num = (short)1128654216;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4C;
					default:
						goto IL_2B5;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 2:
					num = (short)2125725697;
					if (num != 0)
					{
					}
					if (this.NameSelection != this.a)
					{
						num = (short)91095044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					try
					{
						num = (short)63635459;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)111542278;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_15E;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)2096103424;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general = enumerator.Current[10157] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General;
								num = (short)1848311813;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_CE;
								}
								continue;
							case 4:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general;
								this.r = general.TrkSysGeneralHomeWACNID_A8205Value;
								this.t = general.TrkSysGeneralSystemID_A9239Value;
								this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98d望ﾕﲗ", a_));
								this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8d", a_));
								num = (short)171704321;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general;
								if (general.TrkSysGeneralKeyofTrunkingSystem_A12658_UIValue == this.NameSelection.Content.ToString())
								{
									num = (short)919666692;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								goto IL_1E3;
							}
							IL_D0:
							num = (short)1443364866;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_CE:
							goto IL_D0;
						}
						IL_15E:
						IL_1E3:
						return;
					}
					finally
					{
						num = (short)1567162368;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_218;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)204734466;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_24C;
							}
							IL_218:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1019478017;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_24C:;
					}
					goto IL_24F;
				case 4:
					goto IL_24F;
				}
				goto IL_41;
				IL_4C:
				num = (short)1726414848;
				short num4 = num;
				num = (short)1535246336;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_41:
				if (this.NameSelection == null)
				{
					goto IL_4C;
				}
				num = (short)367460354;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_24F:
				enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset).GetEnumerator();
				num = (short)1497759747;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2B5:
			num = (short)1161297920;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x002472B0 File Offset: 0x002454B0
		private void systemType_SelectionChanged(object A_0, global::System.Windows.Controls.SelectionChangedEventArgs A_1)
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						num2 = (short)15007745;
						if (num2 != 0)
						{
						}
						num2 = (short)926154758;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
					{
						num2 = (short)519283224;
						short num3 = num2;
						num2 = (short)96444952;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_48;
						default:
						{
							num2 = (short)879034368;
							if (num2 != 0)
							{
							}
							num2 = (short)191102976;
							short num4 = num2;
							if (this.TypeSelection.Content.ToString() == global::CommonResources.AcgResources.ID_II)
							{
								num2 = (short)707657730;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							this.txspCustomWACNID.Visibility = global::System.Windows.Visibility.Visible;
							this.LblTrkSysHomeWACNID.Visibility = global::System.Windows.Visibility.Visible;
							this.txWACNID.Visibility = global::System.Windows.Visibility.Visible;
							num2 = (short)1025179655;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 2:
						this.txspCustomWACNID.Visibility = global::System.Windows.Visibility.Hidden;
						this.LblTrkSysHomeWACNID.Visibility = global::System.Windows.Visibility.Hidden;
						this.txWACNID.Visibility = global::System.Windows.Visibility.Hidden;
						num2 = (short)356057091;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						goto IL_E3;
					case 4:
						if (this.txspCustomWACNID != null)
						{
							num2 = (short)33619968;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_225;
					case 5:
						num2 = (short)462094337;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						if (this.LblTrkSysHomeWACNID != null)
						{
							num2 = (short)1597440005;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_225;
					case 7:
						goto IL_223;
					}
					goto IL_30;
				}
				IL_E3:
				IL_223:
				IL_225:
				this.c();
				return;
			}
			IL_30:
			global::System.Windows.Controls.ComboBox comboBox = A_0 as global::System.Windows.Controls.ComboBox;
			this.TypeSelection = (global::System.Windows.Controls.ComboBoxItem)comboBox.SelectedItem;
			IL_48:
			num2 = (short)907608068;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x002474E8 File Offset: 0x002456E8
		private void systemName_SelectionChanged(object A_0, global::System.Windows.Controls.SelectionChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					this.txWACNID.Visibility = global::System.Windows.Visibility.Hidden;
					this.LblTrkSysHomeWACNID.Visibility = global::System.Windows.Visibility.Hidden;
					num2 = (short)1878065154;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_249;
				case 2:
					goto IL_EB;
				case 3:
					this.txWACNID.Visibility = global::System.Windows.Visibility.Hidden;
					this.txSystemID.Visibility = global::System.Windows.Visibility.Hidden;
					this.txspCustomSystemId.Visibility = global::System.Windows.Visibility.Visible;
					this.LblTrkSysHomeWACNID.Content = global::CommonResources.AppResources.Custom_WACN_ID;
					this.LblTrkSysSystemID.Content = global::CommonResources.AppResources.Custom_System_ID;
					num2 = (short)1986658313;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					num2 = (short)1036325248;
					short num3 = num2;
					num2 = (short)1103171968;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EB;
					default:
						goto IL_1D1;
					}
					break;
				}
				case 5:
					goto IL_346;
				case 6:
					if (this.TypeSelection.Content.ToString() == global::CommonResources.AcgResources.ID_II)
					{
						num2 = (short)1040449536;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.txWACNID.Visibility = global::System.Windows.Visibility.Visible;
					this.LblTrkSysHomeWACNID.Visibility = global::System.Windows.Visibility.Visible;
					num2 = (short)71630858;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)1215692801;
					if (num2 != 0)
					{
					}
					if (this.NameSelection == this.a)
					{
						num2 = (short)1800798211;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2071003142;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					this.txspCustomWACNID.Visibility = global::System.Windows.Visibility.Hidden;
					this.LblTrkSysHomeWACNID.Visibility = global::System.Windows.Visibility.Hidden;
					num2 = (short)1548943364;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (this.TypeSelection.Content.ToString() == global::CommonResources.AcgResources.ID_II)
					{
						num2 = (short)1100283912;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.txspCustomWACNID.Visibility = global::System.Windows.Visibility.Visible;
					this.LblTrkSysHomeWACNID.Visibility = global::System.Windows.Visibility.Visible;
					num2 = (short)1972109317;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_1ED;
				}
				goto IL_3C;
				IL_1ED:
				this.txSystemID.Visibility = global::System.Windows.Visibility.Visible;
				this.txspCustomSystemId.Visibility = global::System.Windows.Visibility.Hidden;
				this.txspCustomWACNID.Visibility = global::System.Windows.Visibility.Hidden;
				this.LblTrkSysHomeWACNID.Content = global::CommonResources.AcgResources.ID_HOMEWACNID;
				this.LblTrkSysSystemID.Content = global::CommonResources.AcgResources.ID_SYSTEMID;
				num2 = (short)144965633;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_EB:
				num2 = (short)2017918976;
				short num4 = num2;
				goto IL_1ED;
			}
			IL_1D1:
			num2 = (short)1377501184;
			if (num2 != 0)
			{
			}
			IL_249:
			IL_346:
			this.b();
			return;
			IL_3C:
			global::System.Windows.Controls.ComboBox comboBox = A_0 as global::System.Windows.Controls.ComboBox;
			this.NameSelection = (comboBox.SelectedItem as global::System.Windows.Controls.ComboBoxItem);
			num2 = (short)617480199;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x00247848 File Offset: 0x00245A48
		private void a(string A_0)
		{
			short num = (short)451477504;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
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
				{
					num = (short)1133772800;
					short num3 = num;
					num = (short)1605829964;
					short num4 = num;
					num = (short)1830749516;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)352321536;
						if (num != 0)
						{
						}
						this.v(this, new global::System.ComponentModel.PropertyChangedEventArgs(A_0));
						num = (short)896008194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					return;
				}
				IL_30:
				num = (short)532348929;
				if (num != 0)
				{
				}
				if (this.v == null)
				{
					break;
				}
				num = (short)395509761;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06001C14 RID: 7188 RVA: 0x00247970 File Offset: 0x00245B70
		// (remove) Token: 0x06001C15 RID: 7189 RVA: 0x00247AA4 File Offset: 0x00245CA4
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
					{
						num2 = (short)1471664772;
						short num3 = num2;
						num2 = (short)749130372;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A2;
						default:
							num2 = (short)1609433088;
							if (num2 != 0)
							{
							}
							goto IL_85;
						}
						break;
					}
					case 1:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)665976833;
							if (num2 != 0)
							{
							}
							num2 = (short)1773600770;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_85;
					case 2:
						return;
					}
					goto IL_1C;
					IL_A2:
					num2 = (short)396754944;
					short num4 = num2;
					num2 = (short)1508835329;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_85:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.v, value2, propertyChangedEventHandler2);
					goto IL_A2;
				}
				return;
				IL_1C:
				propertyChangedEventHandler = this.v;
				num2 = (short)1870987264;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
					{
						num2 = (short)1610585121;
						short num3 = num2;
						num2 = (short)234984481;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F3;
						default:
							num2 = (short)2027421696;
							if (num2 != 0)
							{
							}
							goto IL_AC;
						}
						break;
					}
					case 1:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)1061158914;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_AC;
					case 2:
						return;
					}
					goto IL_1C;
					IL_F3:
					num2 = (short)507379713;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_AC:
					num2 = (short)1197015040;
					short num4 = num2;
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.v, value2, propertyChangedEventHandler2);
					goto IL_F3;
				}
				return;
				IL_1C:
				num2 = (short)849739777;
				if (num2 != 0)
				{
				}
				propertyChangedEventHandler = this.v;
				num2 = (short)1349451776;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x00247BD8 File Offset: 0x00245DD8
		private string a()
		{
			int a_ = 8;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)685668275;
					short num3 = num2;
					num2 = (short)243562419;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CA;
					default:
						num2 = (short)108920832;
						if (num2 != 0)
						{
						}
						if (!global::System.IO.File.Exists(this.m))
						{
							num2 = (short)1255604225;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_140;
					}
					break;
				}
				case 1:
					goto IL_CA;
				case 2:
					goto IL_13E;
				}
				goto IL_25;
				IL_CA:
				num2 = (short)1519452160;
				short num4 = num2;
				num2 = (short)429981697;
				if (num2 != 0)
				{
				}
				this.m = global::CommonResources.AppResources.Please_Select_A_Valid_Aliases_List_CSV_file;
				num2 = (short)826146818;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_13E:
			IL_140:
			return this.m;
			IL_25:
			this.m = global::System.IO.Path.Combine(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욊ﮎﺐ杖ﮖ잚\udc9c\ud9a0쒤쪦삨잪풬횸횺킼킾꿀鿂", a_));
			num2 = (short)2129068032;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x00247D2C File Offset: 0x00245F2C
		private void txtboxAliasesListFilePath_SelectionChanged(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			string text;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (!string.IsNullOrEmpty(text))
					{
						num2 = (short)1522401281;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11C;
				case 1:
					goto IL_62;
				case 2:
					if (global::System.IO.File.Exists(text))
					{
						num2 = (short)1992556547;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11C;
				case 3:
				{
					num2 = (short)677496949;
					short num3 = num2;
					num2 = (short)164481141;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_62;
					default:
						goto IL_BE;
					}
					break;
				}
				}
				goto IL_20;
				IL_62:
				num2 = (short)1117388801;
				if (num2 != 0)
				{
				}
				num2 = (short)833224706;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_BE:
			num2 = (short)1565130752;
			if (num2 != 0)
			{
			}
			this.btnImport.IsEnabled = true;
			return;
			IL_11C:
			num2 = (short)1233453056;
			short num4 = num2;
			this.btnImport.IsEnabled = false;
			return;
			IL_20:
			text = this.txtboxAliasesListFilePath.Text;
			num2 = (short)1461518336;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x00247E8C File Offset: 0x0024608C
		private void btnAliasesListFilePathBrowse_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			global::System.Windows.Forms.OpenFileDialog openFileDialog;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_6E;
				case 1:
				{
					num2 = (short)583953574;
					short num3 = num2;
					num2 = (short)1270246566;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6E;
					default:
						num2 = (short)178847744;
						if (num2 != 0)
						{
						}
						this.txtboxAliasesListFilePath.Text = openFileDialog.FileName;
						num2 = (short)694878210;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (global::System.IO.File.Exists(this.txtboxAliasesListFilePath.Text.Trim()))
					{
						num2 = (short)1379532803;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					goto IL_190;
				}
				goto IL_29;
				IL_6E:
				num2 = (short)1715994624;
				short num4 = num2;
				if (openFileDialog.ShowDialog() != global::System.Windows.Forms.DialogResult.OK)
				{
					break;
				}
				num2 = (short)1948450817;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_190:
			num2 = (short)170983425;
			if (num2 != 0)
			{
			}
			this.btnImport.IsEnabled = true;
			return;
			IL_29:
			openFileDialog = new global::System.Windows.Forms.OpenFileDialog();
			openFileDialog.InitialDirectory = this.m;
			openFileDialog.DefaultExt = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_);
			openFileDialog.Filter = global::CommonResources.AppResources.Csv_files_Filter;
			num2 = (short)552271872;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x00248030 File Offset: 0x00246230
		private void btnCancel_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2052668111;
			short num2 = num;
			num = (short)244333263;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1175388160;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)119603201;
			if (num != 0)
			{
			}
			num = (short)1759838208;
			if (num != 0)
			{
			}
			base.Close();
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x002480E0 File Offset: 0x002462E0
		private void btnUpdateUCLHelp_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 10;
			short num;
			try
			{
				num = (short)1794519999;
				short num2 = num;
				num = (short)1595093951;
				switch (num2 == num)
				{
				}
				num = (short)290390016;
				if (num != 0)
				{
				}
				global::ACPBrowser.Utility.CloseHelpWindowIfOpen();
				global::ACPBrowser.Utility.DisplayCPSHelpDITA(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꺌몎ꊐ꾖ꂘ꺚ﮜ", a_));
			}
			catch (global::System.Exception)
			{
			}
			num = (short)533200896;
			short num3 = num;
			num = (short)563085313;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x002481C0 File Offset: 0x002463C0
		private void F1HelpCommandCanExcute(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)1061825240;
			short num2 = num;
			num = (short)221129432;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1073348608;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1031995392;
			if (num != 0)
			{
			}
			num = (short)500236289;
			if (num != 0)
			{
			}
			A_1.CanExecute = true;
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x00248274 File Offset: 0x00246474
		private void UpdateUCLWindowClosing(object A_0, global::System.ComponentModel.CancelEventArgs A_1)
		{
			short num = (short)406402424;
			short num2 = num;
			num = (short)1327838584;
			switch (num2 == num)
			{
			default:
			{
				num = (short)153550848;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1416036352;
			if (num != 0)
			{
			}
			num = (short)109707265;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x00248320 File Offset: 0x00246520
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 9;
			short num = (short)1883867118;
			short num2 = num;
			num = (short)477661166;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)1017511936;
				short num3 = num;
				break;
			}
			}
			num = (short)660668416;
			if (num != 0)
			{
			}
			num = (short)2125856769;
			if (num != 0)
			{
			}
			if (!this.w)
			{
				this.w = true;
				global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎋ\udd8dﾕ聯\uda9bﮝ솟횡톣풥춧\ud9a9鞫춭\udfaf\udfb1쒳\ud9b5횷\udfb9튻쪽ꇁꗃ꫅꓇ﻋﻍ볏믑ꟓꋕ﷗뷝迟賡苣迥迧鿩黫迭蓯鯱鯳飵ퟷ駹鷻鋽泿渁洃甅簇缉簋樍焏昑焓㤕洗標砛缝吟䜡儣䔥䐧Щ含伭崯帱", a_), global::System.UriKind.Relative);
				global::System.Windows.Application.LoadComponent(this, resourceLocator);
				return;
			}
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x00248400 File Offset: 0x00246600
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)2147090433;
			if (num != 0)
			{
			}
			num = (short)943259648;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 1:
					num = (short)1727266818;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_2A9;
				}
				IL_5A:
				switch (connectionId)
				{
				case 1:
					goto IL_4A7;
				case 2:
					goto IL_37F;
				case 3:
					goto IL_1BB;
				case 4:
					goto IL_2D2;
				case 5:
					goto IL_2AE;
				case 6:
					goto IL_157;
				case 7:
					goto IL_21D;
				case 8:
					goto IL_3D2;
				case 9:
					goto IL_2F6;
				case 10:
					goto IL_35B;
				case 11:
					goto IL_341;
				case 12:
					goto IL_285;
				case 13:
					goto IL_334;
				case 14:
					goto IL_3F6;
				case 15:
					goto IL_431;
				case 16:
					goto IL_1F9;
				case 17:
					goto IL_133;
				case 18:
					goto IL_4D6;
				case 19:
					goto IL_34E;
				case 20:
					goto IL_1C8;
				case 21:
					goto IL_F8;
				case 22:
					goto IL_46C;
				case 23:
					goto IL_310;
				case 24:
					goto IL_3AE;
				case 25:
					goto IL_1AE;
				case 26:
					goto IL_303;
				case 27:
					goto IL_22A;
				case 28:
					goto IL_1D5;
				case 29:
					goto IL_4E3;
				case 30:
					goto IL_261;
				default:
					num = (short)1505034241;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_F8:
			this.CustomWACNIDDec = (global::AcpUI.AcpTextBox)target;
			this.CustomWACNIDDec.PreviewKeyDown += this.OnKeyPressUpDownEvent;
			this.CustomWACNIDDec.TextChanged += this.TextChanged;
			return;
			IL_133:
			this.DownClickSystemid = (global::System.Windows.Controls.Primitives.RepeatButton)target;
			this.DownClickSystemid.Click += this.OnClick;
			return;
			IL_157:
			num = (short)515649108;
			short num3 = num;
			num = (short)915156564;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_3D2:
				this.comboSysType = (global::AcpUI.AcpComboBox)target;
				this.comboSysType.SelectionChanged += this.systemType_SelectionChanged;
				return;
			default:
				num = (short)1169424384;
				if (num != 0)
				{
				}
				this.groupBoxSysInfo = (global::System.Windows.Controls.GroupBox)target;
				return;
			}
			IL_1AE:
			this.ckDeleteExtra = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1BB:
			this.lbAliasesListFilePath = (global::AcpUI.AcpLabel)target;
			return;
			IL_1C8:
			this.txspCustomWACNID = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1D5:
			this.btnImport = (global::System.Windows.Controls.Button)target;
			this.btnImport.Click += this.btnImport_Click;
			return;
			IL_1F9:
			this.UpClickSystemid = (global::System.Windows.Controls.Primitives.RepeatButton)target;
			this.UpClickSystemid.Click += this.OnClick;
			return;
			IL_21D:
			this.lbSysType = (global::AcpUI.AcpLabel)target;
			return;
			IL_22A:
			num = (short)358023168;
			short num4 = num;
			this.lbNoteToUser = (global::AcpUI.AcpLabel)target;
			return;
			IL_261:
			this.btnHelp = (global::System.Windows.Controls.Button)target;
			this.btnHelp.Click += this.btnUpdateUCLHelp_Click;
			return;
			IL_285:
			this.txSystemID = (global::AcpUI.AcpTextBox)target;
			return;
			IL_2A9:
			this.w = true;
			return;
			IL_2AE:
			this.btnAliasesListFilePathBrowse = (global::System.Windows.Controls.Button)target;
			this.btnAliasesListFilePathBrowse.Click += this.btnAliasesListFilePathBrowse_Click;
			return;
			IL_2D2:
			this.txtboxAliasesListFilePath = (global::AcpUI.AcpTextBox)target;
			this.txtboxAliasesListFilePath.LostFocus += this.txtboxAliasesListFilePath_SelectionChanged;
			return;
			IL_2F6:
			this.lbSystemName = (global::AcpUI.AcpLabel)target;
			return;
			IL_303:
			this.lbDeleteExtra = (global::AcpUI.AcpLabel)target;
			return;
			IL_310:
			this.UpClickCustomWACNID = (global::System.Windows.Controls.Primitives.RepeatButton)target;
			this.UpClickCustomWACNID.Click += this.OnClick;
			return;
			IL_334:
			this.txspCustomSystemId = (global::System.Windows.Controls.Grid)target;
			return;
			IL_341:
			this.LblTrkSysSystemID = (global::AcpUI.AcpLabel)target;
			return;
			IL_34E:
			this.txWACNID = (global::AcpUI.AcpTextBox)target;
			return;
			IL_35B:
			this.comboSysName = (global::AcpUI.AcpComboBox)target;
			this.comboSysName.SelectionChanged += this.systemName_SelectionChanged;
			return;
			IL_37F:
			((global::System.Windows.Input.CommandBinding)target).Executed += new global::System.Windows.Input.ExecutedRoutedEventHandler(this.btnUpdateUCLHelp_Click);
			((global::System.Windows.Input.CommandBinding)target).CanExecute += this.F1HelpCommandCanExcute;
			return;
			IL_3AE:
			this.DownClickCustomWACNID = (global::System.Windows.Controls.Primitives.RepeatButton)target;
			this.DownClickCustomWACNID.Click += this.OnClick;
			return;
			IL_3F6:
			this.SystemidDec = (global::AcpUI.AcpTextBox)target;
			this.SystemidDec.PreviewKeyDown += this.OnKeyPressUpDownEvent;
			this.SystemidDec.TextChanged += this.TextChanged;
			return;
			IL_431:
			this.SystemidHex = (global::AcpUI.AcpTextBox)target;
			this.SystemidHex.PreviewKeyDown += this.OnKeyPressUpDownEvent;
			this.SystemidHex.TextChanged += this.TextChanged;
			return;
			IL_46C:
			this.CustomWACNIDHex = (global::AcpUI.AcpTextBox)target;
			this.CustomWACNIDHex.PreviewKeyDown += this.OnKeyPressUpDownEvent;
			this.CustomWACNIDHex.TextChanged += this.TextChanged;
			return;
			IL_4A7:
			((global::SpecialFeatures.UCL.CallListUpdate.UpdateUCL)target).Loaded += this.UpdateUCL_Loaded;
			((global::SpecialFeatures.UCL.CallListUpdate.UpdateUCL)target).Closing += this.UpdateUCLWindowClosing;
			return;
			IL_4D6:
			this.LblTrkSysHomeWACNID = (global::AcpUI.AcpLabel)target;
			return;
			IL_4E3:
			this.btnCancel = (global::System.Windows.Controls.Button)target;
			this.btnCancel.Click += this.btnCancel_Click;
		}

		// Token: 0x04000DB8 RID: 3512
		private global::System.Windows.Controls.ComboBoxItem a;

		// Token: 0x04000DB9 RID: 3513
		private string b;

		// Token: 0x04000DBA RID: 3514
		private int c;

		// Token: 0x04000DBB RID: 3515
		private int d;

		// Token: 0x04000DBC RID: 3516
		private int e;

		// Token: 0x04000DBD RID: 3517
		private int f;

		// Token: 0x04000DBE RID: 3518
		private int g;

		// Token: 0x04000DBF RID: 3519
		private int h;

		// Token: 0x04000DC0 RID: 3520
		private global::AcpBusinessLayer.FeatureNode i;

		// Token: 0x04000DC1 RID: 3521
		private int j;

		// Token: 0x04000DC2 RID: 3522
		private int k;

		// Token: 0x04000DC3 RID: 3523
		private int l;

		// Token: 0x04000DC4 RID: 3524
		private string m;

		// Token: 0x04000DC5 RID: 3525
		private global::System.Collections.Generic.List<global::System.Windows.Controls.ComboBoxItem> n;

		// Token: 0x04000DC6 RID: 3526
		private global::System.Collections.Generic.List<global::System.Windows.Controls.ComboBoxItem> o;

		// Token: 0x04000DC7 RID: 3527
		private global::System.Windows.Controls.ComboBoxItem p;

		// Token: 0x04000DC8 RID: 3528
		private global::System.Windows.Controls.ComboBoxItem q;

		// Token: 0x04000DC9 RID: 3529
		private int r;

		// Token: 0x04000DCA RID: 3530
		private int s;

		// Token: 0x04000DCB RID: 3531
		private int t;

		// Token: 0x04000DCC RID: 3532
		private int u;

		// Token: 0x04000DCD RID: 3533
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler v;

		// Token: 0x04000DCE RID: 3534
		internal global::AcpUI.AcpLabel lbAliasesListFilePath;

		// Token: 0x04000DCF RID: 3535
		internal global::AcpUI.AcpTextBox txtboxAliasesListFilePath;

		// Token: 0x04000DD0 RID: 3536
		internal global::System.Windows.Controls.Button btnAliasesListFilePathBrowse;

		// Token: 0x04000DD1 RID: 3537
		internal global::System.Windows.Controls.GroupBox groupBoxSysInfo;

		// Token: 0x04000DD2 RID: 3538
		internal global::AcpUI.AcpLabel lbSysType;

		// Token: 0x04000DD3 RID: 3539
		internal global::AcpUI.AcpComboBox comboSysType;

		// Token: 0x04000DD4 RID: 3540
		internal global::AcpUI.AcpLabel lbSystemName;

		// Token: 0x04000DD5 RID: 3541
		internal global::AcpUI.AcpComboBox comboSysName;

		// Token: 0x04000DD6 RID: 3542
		internal global::AcpUI.AcpLabel LblTrkSysSystemID;

		// Token: 0x04000DD7 RID: 3543
		internal global::AcpUI.AcpTextBox txSystemID;

		// Token: 0x04000DD8 RID: 3544
		internal global::System.Windows.Controls.Grid txspCustomSystemId;

		// Token: 0x04000DD9 RID: 3545
		internal global::AcpUI.AcpTextBox SystemidDec;

		// Token: 0x04000DDA RID: 3546
		internal global::AcpUI.AcpTextBox SystemidHex;

		// Token: 0x04000DDB RID: 3547
		internal global::System.Windows.Controls.Primitives.RepeatButton UpClickSystemid;

		// Token: 0x04000DDC RID: 3548
		internal global::System.Windows.Controls.Primitives.RepeatButton DownClickSystemid;

		// Token: 0x04000DDD RID: 3549
		internal global::AcpUI.AcpLabel LblTrkSysHomeWACNID;

		// Token: 0x04000DDE RID: 3550
		internal global::AcpUI.AcpTextBox txWACNID;

		// Token: 0x04000DDF RID: 3551
		internal global::System.Windows.Controls.Grid txspCustomWACNID;

		// Token: 0x04000DE0 RID: 3552
		internal global::AcpUI.AcpTextBox CustomWACNIDDec;

		// Token: 0x04000DE1 RID: 3553
		internal global::AcpUI.AcpTextBox CustomWACNIDHex;

		// Token: 0x04000DE2 RID: 3554
		internal global::System.Windows.Controls.Primitives.RepeatButton UpClickCustomWACNID;

		// Token: 0x04000DE3 RID: 3555
		internal global::System.Windows.Controls.Primitives.RepeatButton DownClickCustomWACNID;

		// Token: 0x04000DE4 RID: 3556
		internal global::AcpUI.AcpCheckBox ckDeleteExtra;

		// Token: 0x04000DE5 RID: 3557
		internal global::AcpUI.AcpLabel lbDeleteExtra;

		// Token: 0x04000DE6 RID: 3558
		internal global::AcpUI.AcpLabel lbNoteToUser;

		// Token: 0x04000DE7 RID: 3559
		internal global::System.Windows.Controls.Button btnImport;

		// Token: 0x04000DE8 RID: 3560
		internal global::System.Windows.Controls.Button btnCancel;

		// Token: 0x04000DE9 RID: 3561
		internal global::System.Windows.Controls.Button btnHelp;

		// Token: 0x04000DEA RID: 3562
		private bool w;

		// Token: 0x02000225 RID: 549
		private enum ValueChangeType
		{
			// Token: 0x04000DEC RID: 3564
			upwacnid,
			// Token: 0x04000DED RID: 3565
			downwacnid,
			// Token: 0x04000DEE RID: 3566
			upsystemid,
			// Token: 0x04000DEF RID: 3567
			downsystemid
		}
	}
}
