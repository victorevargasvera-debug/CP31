using System;
using System.Windows;
using System.Windows.Controls;
using AcpUI.Common;
using AcpUILib;

namespace AcpUI
{
	// Token: 0x02000014 RID: 20
	public class AcpExpander : global::System.Windows.Controls.Expander, global::AcpUILib.IAcpUICtrlBase
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600010A RID: 266 RVA: 0x000165F8 File Offset: 0x000147F8
		// (set) Token: 0x0600010B RID: 267 RVA: 0x000166B4 File Offset: 0x000148B4
		public bool IsAcpValid
		{
			get
			{
				short num = (short)182799119;
				short num2 = num;
				num = (short)1126058767;
				switch (num2 == num)
				{
				}
				num = (short)3473408;
				short num3 = num;
				num = (short)1536491521;
				if (num != 0)
				{
				}
				num = (short)1047527424;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpExpander.IsAcpValidProperty);
			}
			set
			{
				short num = (short)875335104;
				short num2 = num;
				num = (short)369921472;
				switch (num2 == num)
				{
				}
				num = (short)1762459648;
				short num3 = num;
				num = (short)1101004801;
				if (num != 0)
				{
				}
				num = (short)32440320;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpExpander.IsAcpValidProperty, value);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00016770 File Offset: 0x00014970
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00016828 File Offset: 0x00014A28
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)1066490367;
				short num2 = num;
				num = (short)413555199;
				switch (num2 == num)
				{
				}
				num = (short)2109145088;
				short num3 = num;
				num = (short)1320353792;
				if (num != 0)
				{
				}
				num = (short)270073857;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpExpander.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1685651457;
				if (num != 0)
				{
				}
				num = (short)139660674;
				short num2 = num;
				num = (short)1358564738;
				switch (num2 == num)
				{
				default:
				{
					num = (short)545062912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)192610304;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpExpander.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600010E RID: 270 RVA: 0x000168E0 File Offset: 0x00014AE0
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00016998 File Offset: 0x00014B98
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)33553071;
				short num2 = num;
				num = (short)502725295;
				switch (num2 == num)
				{
				}
				num = (short)1798438912;
				short num3 = num;
				num = (short)1731067904;
				if (num != 0)
				{
				}
				num = (short)1318453249;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpExpander.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)748390195;
				short num2 = num;
				num = (short)784631603;
				switch (num2 == num)
				{
				}
				num = (short)968818688;
				short num3 = num;
				num = (short)1756233728;
				if (num != 0)
				{
				}
				num = (short)1788936193;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpExpander.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00016A50 File Offset: 0x00014C50
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00016B0C File Offset: 0x00014D0C
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)1726742529;
				if (num != 0)
				{
				}
				num = (short)1345714189;
				short num2 = num;
				num = (short)1259206669;
				switch (num2 == num)
				{
				default:
				{
					num = (short)657850368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)772931584;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpExpander.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1297655315;
				short num2 = num;
				num = (short)288597523;
				switch (num2 == num)
				{
				}
				num = (short)1011023872;
				short num3 = num;
				num = (short)801701889;
				if (num != 0)
				{
				}
				num = (short)1397358592;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpExpander.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00016BCC File Offset: 0x00014DCC
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00016C84 File Offset: 0x00014E84
		public bool ShowDiffIcon
		{
			get
			{
				short num = (short)351109131;
				short num2 = num;
				num = (short)1275363339;
				switch (num2 == num)
				{
				}
				num = (short)1065943040;
				short num3 = num;
				num = (short)1807089665;
				if (num != 0)
				{
				}
				num = (short)649068544;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpExpander.ShowDiffIconProperty);
			}
			set
			{
				short num = (short)1104412673;
				if (num != 0)
				{
				}
				num = (short)363760480;
				short num2 = num;
				num = (short)1819904864;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1382350848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1234763776;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpExpander.ShowDiffIconProperty, value);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00016D3C File Offset: 0x00014F3C
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00016DF8 File Offset: 0x00014FF8
		public global::AcpUI.AcpRecNavToolbar ExpToolbar
		{
			get
			{
				short num = (short)1801369293;
				short num2 = num;
				num = (short)1679210189;
				switch (num2 == num)
				{
				}
				num = (short)449642496;
				short num3 = num;
				num = (short)432799745;
				if (num != 0)
				{
				}
				num = (short)1659371520;
				if (num != 0)
				{
				}
				return (global::AcpUI.AcpRecNavToolbar)base.GetValue(global::AcpUI.AcpExpander.ExpToolbarProperty);
			}
			set
			{
				short num = (short)1209008129;
				if (num != 0)
				{
				}
				num = (short)1397438851;
				short num2 = num;
				num = (short)1847671171;
				switch (num2 == num)
				{
				default:
				{
					num = (short)81068032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1348534272;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpExpander.ExpToolbarProperty, value);
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00016EB0 File Offset: 0x000150B0
		public AcpExpander()
		{
			base.IsExpanded = true;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00016ECC File Offset: 0x000150CC
		protected override void OnExpanded()
		{
			short num = (short)1388488583;
			short num2 = num;
			num = (short)266119047;
			switch (num2 == num)
			{
			}
			num = (short)1781923840;
			short num3 = num;
			num = (short)358547457;
			if (num != 0)
			{
			}
			num = (short)2126839808;
			if (num != 0)
			{
			}
			base.OnExpanded();
			global::AcpUI.Common.Utility.SaveFieldWithFocus();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00016F80 File Offset: 0x00015180
		protected override void OnCollapsed()
		{
			short num = (short)1613007387;
			short num2 = num;
			num = (short)709003803;
			switch (num2 == num)
			{
			}
			num = (short)662503424;
			short num3 = num;
			num = (short)1048182785;
			if (num != 0)
			{
			}
			num = (short)74055680;
			if (num != 0)
			{
			}
			base.OnCollapsed();
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0001702C File Offset: 0x0001522C
		// Note: this type is marked as 'beforefieldinit'.
		static AcpExpander()
		{
			int a_ = 10;
			short num = (short)494403585;
			if (num != 0)
			{
			}
			num = (short)1634709787;
			short num2 = num;
			num = (short)677753115;
			switch (num2 == num)
			{
			default:
			{
				num = (short)703594496;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2094399488;
			if (num != 0)
			{
			}
			global::AcpUI.AcpExpander.IsAcpValidProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("톡얥\ud8a7ﲩ춫슭\ud9af횱", a_), typeof(bool), typeof(global::AcpUI.AcpExpander), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpExpander.IsAcpApplicableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("톡얥\ud8a7\udcab\udead\udcaf\udbb1ힳힵ\udab7횹\ud9bb", a_), typeof(bool), typeof(global::AcpUI.AcpExpander), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpExpander.IsAcpEditableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("톡얥\ud8a7좫잭쒯펱횳\udab5\uddb7", a_), typeof(bool), typeof(global::AcpUI.AcpExpander), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpExpander.IsAcpVisibleProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("톡얥\ud8a7ﲩ얫\uddad\ud9af킱\ud8b3펵", a_), typeof(bool), typeof(global::AcpUI.AcpExpander), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpExpander.ShowDiffIconProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("쪡쮣톥쎩쪫좭羚톱\udbb3\ud8b5", a_), typeof(bool), typeof(global::AcpUI.AcpExpander), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpExpander.ExpToolbarProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\udaa1풣잧얩삫청톯삱", a_), typeof(global::AcpUI.AcpRecNavToolbar), typeof(global::AcpUI.AcpExpander), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
		}

		// Token: 0x0400012D RID: 301
		public static readonly global::System.Windows.DependencyProperty IsAcpValidProperty;

		// Token: 0x0400012E RID: 302
		public static readonly global::System.Windows.DependencyProperty IsAcpApplicableProperty;

		// Token: 0x0400012F RID: 303
		public static readonly global::System.Windows.DependencyProperty IsAcpEditableProperty;

		// Token: 0x04000130 RID: 304
		public static readonly global::System.Windows.DependencyProperty IsAcpVisibleProperty;

		// Token: 0x04000131 RID: 305
		public static readonly global::System.Windows.DependencyProperty ShowDiffIconProperty;

		// Token: 0x04000132 RID: 306
		public static readonly global::System.Windows.DependencyProperty ExpToolbarProperty;
	}
}
