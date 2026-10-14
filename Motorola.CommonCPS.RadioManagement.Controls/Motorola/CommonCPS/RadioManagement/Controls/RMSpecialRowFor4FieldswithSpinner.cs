using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000C3 RID: 195
	public class RMSpecialRowFor4FieldswithSpinner : global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditor, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000550 RID: 1360 RVA: 0x00055C88 File Offset: 0x00053E88
		public RMSpecialRowFor4FieldswithSpinner()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00055CA4 File Offset: 0x00053EA4
		protected override void SetControlID()
		{
			short num = (short)462998611;
			short num2 = num;
			num = (short)1663945811;
			switch (num2 == num)
			{
			}
			num = (short)1798635521;
			if (num != 0)
			{
			}
			num = (short)1170472960;
			short num3 = num;
			num = (short)1141178368;
			if (num != 0)
			{
			}
			base.SetControlID(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner.ComboBox1Property, this.CB1);
			base.SetControlID(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner.Spin1Property, this.NI1);
			base.SetControlID(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner.ComboBox2Property, this.CB2);
			base.SetControlID(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner.ComboBox3Property, this.CB3);
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x00055D90 File Offset: 0x00053F90
		// (set) Token: 0x06000553 RID: 1363 RVA: 0x00055E48 File Offset: 0x00054048
		public string Header1
		{
			get
			{
				short num = (short)751173633;
				if (num != 0)
				{
				}
				num = (short)913050845;
				short num2 = num;
				num = (short)1226181853;
				switch (num2 == num)
				{
				}
				num = (short)1707409408;
				short num3 = num;
				num = (short)570032128;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner.Header1Property);
			}
			set
			{
				short num = (short)1320326661;
				short num2 = num;
				num = (short)1618712069;
				switch (num2 == num)
				{
				}
				num = (short)356188161;
				if (num != 0)
				{
				}
				num = (short)955383808;
				short num3 = num;
				num = (short)1824522240;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner.Header1Property, value);
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x00055F00 File Offset: 0x00054100
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x00055FBC File Offset: 0x000541BC
		public global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit ComboBox1
		{
			get
			{
				short num = (short)1372613507;
				short num2 = num;
				num = (short)1551985539;
				switch (num2 == num)
				{
				}
				num = (short)501153793;
				if (num != 0)
				{
				}
				num = (short)1420230656;
				short num3 = num;
				num = (short)59113472;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner.ComboBox1Property);
			}
			set
			{
				short num = (short)875233281;
				if (num != 0)
				{
				}
				num = (short)113874161;
				short num2 = num;
				num = (short)1144558833;
				switch (num2 == num)
				{
				}
				num = (short)177209344;
				short num3 = num;
				num = (short)1201864704;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner.ComboBox1Property, value);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x00056070 File Offset: 0x00054270
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x00056128 File Offset: 0x00054328
		public global::Motorola.CommonCPS.RadioManagement.UIModels.INumericEdit Spin1
		{
			get
			{
				short num = (short)744086536;
				short num2 = num;
				num = (short)1896995848;
				switch (num2 == num)
				{
				}
				num = (short)206962689;
				if (num != 0)
				{
				}
				num = (short)1467023360;
				short num3 = num;
				num = (short)774045696;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.INumericEdit)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner.Spin1Property);
			}
			set
			{
				short num = (short)1531846191;
				short num2 = num;
				num = (short)1541348911;
				switch (num2 == num)
				{
				}
				num = (short)629997568;
				if (num != 0)
				{
				}
				num = (short)1462894592;
				short num3 = num;
				num = (short)661520385;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner.Spin1Property, value);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x000561DC File Offset: 0x000543DC
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x00056298 File Offset: 0x00054498
		public global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit ComboBox2
		{
			get
			{
				short num = (short)542394789;
				short num2 = num;
				num = (short)249383333;
				switch (num2 == num)
				{
				}
				num = (short)1847066625;
				if (num != 0)
				{
				}
				num = (short)379191296;
				short num3 = num;
				num = (short)1356595200;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner.ComboBox2Property);
			}
			set
			{
				short num = (short)1440022035;
				short num2 = num;
				num = (short)1565720083;
				switch (num2 == num)
				{
				}
				num = (short)171048960;
				if (num != 0)
				{
				}
				num = (short)974323712;
				short num3 = num;
				num = (short)660340737;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner.ComboBox2Property, value);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x0005634C File Offset: 0x0005454C
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x00056404 File Offset: 0x00054604
		public global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit ComboBox3
		{
			get
			{
				short num = (short)139430342;
				short num2 = num;
				num = (short)1891994054;
				switch (num2 == num)
				{
				}
				num = (short)359399424;
				short num3 = num;
				num = (short)2033188865;
				if (num != 0)
				{
				}
				num = (short)370671616;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner.ComboBox3Property);
			}
			set
			{
				short num = (short)1674605500;
				short num2 = num;
				num = (short)1907454908;
				switch (num2 == num)
				{
				}
				num = (short)2097610752;
				short num3 = num;
				num = (short)471072769;
				if (num != 0)
				{
				}
				num = (short)1909325824;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner.ComboBox3Property, value);
			}
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x000564BC File Offset: 0x000546BC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 1;
			short num;
			while (!this._contentLoaded)
			{
				num = (short)1089165054;
				short num2 = num;
				num = (short)1474189054;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)294256641;
					if (num != 0)
					{
					}
					num = (short)2065104896;
					if (num != 0)
					{
					}
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("뚘횚캠톢쪤쮦좨薪삮\udcb0\udeb2\udab4\ud9b6視醾鏀ꋂꇄ껆ꛈ蛊곌ꇎ냐듒냔뫖볘뗚꧜ꋠ賢诤鏦鯨蓪臬鳮쫰郲髴髶觸铺鏼髾漀眂⨄爆稈渊缌氎縐紒愔攖瘘眚渜〞䀠倢儤唦䘨Ъ弬䈮䈰䌲倴吶倸娺儼䴾⹀㑂⍄⡆㭈罊⭌♎㑐㽒ㅔ⑖⹘㉚⥜㝞በ።౤०ݨ๪Ὤ䅮॰ቲᡴ᭶", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
			num = (short)1973354496;
			short num3 = num;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00056598 File Offset: 0x00054798
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)2089427970;
			short num2 = num;
			num = (short)1634149378;
			switch (num2 == num)
			{
			}
			num = (short)1168900096;
			short num3 = num;
			num = (short)1452539905;
			if (num != 0)
			{
			}
			num = (short)896925696;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0005664C File Offset: 0x0005484C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1821376513;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)595537479;
				short num3 = num;
				num = (short)1355099719;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1466368000;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_14F;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7A;
						}
						continue;
					case 2:
						goto IL_110;
					}
					IL_7A:
					switch (connectionId)
					{
					case 1:
						goto IL_F6;
					case 2:
						goto IL_15E;
					case 3:
						goto IL_E9;
					case 4:
						goto IL_B4;
					case 5:
						goto IL_151;
					case 6:
						goto IL_103;
					default:
						num = (short)1773535234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_110:
				num = (short)667942913;
				if (num != 0)
				{
				}
				num = (short)230752256;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B4:
			num = (short)1449132032;
			short num4 = num;
			this.NI1 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor)target;
			return;
			IL_E9:
			this.CB1 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor)target;
			return;
			IL_F6:
			this.Grid1 = (global::System.Windows.Controls.Grid)target;
			return;
			IL_103:
			this.CB3 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor)target;
			return;
			IL_14F:
			this._contentLoaded = true;
			return;
			IL_151:
			this.CB2 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor)target;
			return;
			IL_15E:
			this.TB1 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x000567CC File Offset: 0x000549CC
		// Note: this type is marked as 'beforefieldinit'.
		static RMSpecialRowFor4FieldswithSpinner()
		{
			int a_ = 17;
			short num = (short)969041192;
			short num2 = num;
			num = (short)14574888;
			switch (num2 == num)
			{
			}
			num = (short)378863616;
			short num3 = num;
			num = (short)298123265;
			if (num != 0)
			{
			}
			num = (short)1690107904;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner.Header1Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("캪첬쮮풰솲蒴", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner.ComboBox1Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쒪사춮\udeb0\udab4쾶袸", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner.Spin1Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("直\udbaa쒬솮肰", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.INumericEdit), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner.ComboBox2Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쒪사춮\udeb0\udab4쾶许", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner.ComboBox3Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쒪사춮\udeb0\udab4쾶誸", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor4FieldswithSpinner), new global::System.Windows.FrameworkPropertyMetadata(null));
		}

		// Token: 0x04000228 RID: 552
		public static readonly global::System.Windows.DependencyProperty Header1Property;

		// Token: 0x04000229 RID: 553
		public static readonly global::System.Windows.DependencyProperty ComboBox1Property;

		// Token: 0x0400022A RID: 554
		public static readonly global::System.Windows.DependencyProperty Spin1Property;

		// Token: 0x0400022B RID: 555
		public static readonly global::System.Windows.DependencyProperty ComboBox2Property;

		// Token: 0x0400022C RID: 556
		public static readonly global::System.Windows.DependencyProperty ComboBox3Property;

		// Token: 0x0400022D RID: 557
		internal global::System.Windows.Controls.Grid Grid1;

		// Token: 0x0400022E RID: 558
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock TB1;

		// Token: 0x0400022F RID: 559
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor CB1;

		// Token: 0x04000230 RID: 560
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor NI1;

		// Token: 0x04000231 RID: 561
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor CB2;

		// Token: 0x04000232 RID: 562
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor CB3;

		// Token: 0x04000233 RID: 563
		private bool _contentLoaded;
	}
}
