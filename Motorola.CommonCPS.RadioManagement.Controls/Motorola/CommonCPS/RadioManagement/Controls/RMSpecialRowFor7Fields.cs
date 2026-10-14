using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000C4 RID: 196
	public class RMSpecialRowFor7Fields : global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditor, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000560 RID: 1376 RVA: 0x0005697C File Offset: 0x00054B7C
		public RMSpecialRowFor7Fields()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00056998 File Offset: 0x00054B98
		protected override void SetControlID()
		{
			short num = (short)2036248477;
			short num2 = num;
			num = (short)185970589;
			switch (num2 == num)
			{
			}
			num = (short)100073472;
			short num3 = num;
			num = (short)469303297;
			if (num != 0)
			{
			}
			num = (short)1143078912;
			if (num != 0)
			{
			}
			base.SetControlID(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.Field1Property, this.NI1);
			base.SetControlID(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.Field2Property, this.NI2);
			base.SetControlID(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.ComboBox1Property, this.CB1);
			base.SetControlID(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.ComboBox2Property, this.CB2);
			base.SetControlID(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.ComboBox3Property, this.CB3);
			base.SetControlID(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.ComboBox4Property, this.CB4);
			base.SetControlID(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.Spin1Property, this.NI3);
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00056ABC File Offset: 0x00054CBC
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x00056B74 File Offset: 0x00054D74
		public string Header1
		{
			get
			{
				short num = (short)1553321381;
				short num2 = num;
				num = (short)1111739813;
				switch (num2 == num)
				{
				}
				num = (short)1082523648;
				short num3 = num;
				num = (short)156565505;
				if (num != 0)
				{
				}
				num = (short)12058624;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.Header1Property);
			}
			set
			{
				short num = (short)1679990745;
				short num2 = num;
				num = (short)167485401;
				switch (num2 == num)
				{
				}
				num = (short)2118123520;
				short num3 = num;
				num = (short)1607204865;
				if (num != 0)
				{
				}
				num = (short)818937856;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.Header1Property, value);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x00056C28 File Offset: 0x00054E28
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x00056CE0 File Offset: 0x00054EE0
		public global::Motorola.CommonCPS.RadioManagement.UIModels.IStringEdit Field1
		{
			get
			{
				short num = (short)1481934134;
				short num2 = num;
				num = (short)520914230;
				switch (num2 == num)
				{
				}
				num = (short)1169686528;
				short num3 = num;
				num = (short)561053697;
				if (num != 0)
				{
				}
				num = (short)504168448;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.IStringEdit)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.Field1Property);
			}
			set
			{
				short num = (short)385176610;
				short num2 = num;
				num = (short)562975778;
				switch (num2 == num)
				{
				}
				num = (short)194838528;
				short num3 = num;
				num = (short)72810497;
				if (num != 0)
				{
				}
				num = (short)1634533376;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.Field1Property, value);
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x00056D94 File Offset: 0x00054F94
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x00056E50 File Offset: 0x00055050
		public global::Motorola.CommonCPS.RadioManagement.UIModels.IStringEdit Field2
		{
			get
			{
				short num = (short)1456083433;
				short num2 = num;
				num = (short)592318953;
				switch (num2 == num)
				{
				}
				num = (short)551157760;
				short num3 = num;
				num = (short)2044329984;
				if (num != 0)
				{
				}
				num = (short)2063400961;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.IStringEdit)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.Field2Property);
			}
			set
			{
				short num = (short)512722033;
				short num2 = num;
				num = (short)1483768945;
				switch (num2 == num)
				{
				}
				num = (short)2123563008;
				short num3 = num;
				num = (short)551026688;
				if (num != 0)
				{
				}
				num = (short)1802502145;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.Field2Property, value);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x00056F04 File Offset: 0x00055104
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x00056FBC File Offset: 0x000551BC
		public global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit ComboBox1
		{
			get
			{
				short num = (short)1220652683;
				short num2 = num;
				num = (short)943632011;
				switch (num2 == num)
				{
				}
				num = (short)832438272;
				short num3 = num;
				num = (short)557907968;
				if (num != 0)
				{
				}
				num = (short)322830337;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.ComboBox1Property);
			}
			set
			{
				short num = (short)1947454294;
				short num2 = num;
				num = (short)1835256662;
				switch (num2 == num)
				{
				}
				num = (short)877068288;
				short num3 = num;
				num = (short)1074200576;
				if (num != 0)
				{
				}
				num = (short)601161729;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.ComboBox1Property, value);
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00057070 File Offset: 0x00055270
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x00057128 File Offset: 0x00055328
		public global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit ComboBox2
		{
			get
			{
				short num = (short)668982718;
				short num2 = num;
				num = (short)536927678;
				switch (num2 == num)
				{
				}
				num = (short)168689664;
				short num3 = num;
				num = (short)476839937;
				if (num != 0)
				{
				}
				num = (short)2078998528;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.ComboBox2Property);
			}
			set
			{
				short num = (short)485432223;
				short num2 = num;
				num = (short)1326783391;
				switch (num2 == num)
				{
				}
				num = (short)807600128;
				short num3 = num;
				num = (short)80609281;
				if (num != 0)
				{
				}
				num = (short)986710016;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.ComboBox2Property, value);
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x000571E0 File Offset: 0x000553E0
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x0005729C File Offset: 0x0005549C
		public global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit ComboBox3
		{
			get
			{
				short num = (short)432385431;
				short num2 = num;
				num = (short)1729670551;
				switch (num2 == num)
				{
				}
				num = (short)1307770880;
				short num3 = num;
				num = (short)1363935233;
				if (num != 0)
				{
				}
				num = (short)1019543552;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.ComboBox3Property);
			}
			set
			{
				short num = (short)137784946;
				short num2 = num;
				num = (short)1006923378;
				switch (num2 == num)
				{
				}
				num = (short)95944704;
				short num3 = num;
				num = (short)1819803649;
				if (num != 0)
				{
				}
				num = (short)607584256;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.ComboBox3Property, value);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x00057354 File Offset: 0x00055554
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x0005740C File Offset: 0x0005560C
		public global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit ComboBox4
		{
			get
			{
				short num = (short)1461320036;
				short num2 = num;
				num = (short)538966372;
				switch (num2 == num)
				{
				}
				num = (short)1358495744;
				short num3 = num;
				num = (short)31129600;
				if (num != 0)
				{
				}
				num = (short)145358849;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.ComboBox4Property);
			}
			set
			{
				short num = (short)593493601;
				short num2 = num;
				num = (short)187563617;
				switch (num2 == num)
				{
				}
				num = (short)1190658048;
				short num3 = num;
				num = (short)589561857;
				if (num != 0)
				{
				}
				num = (short)1793392640;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.ComboBox4Property, value);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x000574C4 File Offset: 0x000556C4
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x00057580 File Offset: 0x00055780
		public global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit ComboBox5
		{
			get
			{
				short num = (short)82617163;
				short num2 = num;
				num = (short)2131403595;
				switch (num2 == num)
				{
				}
				num = (short)2120024064;
				short num3 = num;
				num = (short)1098383361;
				if (num != 0)
				{
				}
				num = (short)1569062912;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.ComboBox5Property);
			}
			set
			{
				short num = (short)133601203;
				short num2 = num;
				num = (short)235771827;
				switch (num2 == num)
				{
				}
				num = (short)1516896256;
				short num3 = num;
				num = (short)1477509120;
				if (num != 0)
				{
				}
				num = (short)552271873;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.ComboBox5Property, value);
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x00057634 File Offset: 0x00055834
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x000576EC File Offset: 0x000558EC
		public global::Motorola.CommonCPS.RadioManagement.UIModels.INumericEdit Spin1
		{
			get
			{
				short num = (short)1988157687;
				short num2 = num;
				num = (short)1272963319;
				switch (num2 == num)
				{
				}
				num = (short)806158336;
				short num3 = num;
				num = (short)597229569;
				if (num != 0)
				{
				}
				num = (short)1305542656;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.INumericEdit)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.Spin1Property);
			}
			set
			{
				short num = (short)785203239;
				short num2 = num;
				num = (short)1211383847;
				switch (num2 == num)
				{
				}
				num = (short)1416757248;
				short num3 = num;
				num = (short)456785921;
				if (num != 0)
				{
				}
				num = (short)2019360768;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.Spin1Property, value);
			}
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x000577A0 File Offset: 0x000559A0
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 12;
			short num;
			while (!this._contentLoaded)
			{
				num = (short)414862628;
				short num2 = num;
				num = (short)1281641764;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)910426112;
					if (num != 0)
					{
					}
					num = (short)2051604481;
					if (num != 0)
					{
					}
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("讣잧\udea9쎫\udcad\udfaf\udeb1햳颵﮷햹톻펽꾿곁蟃雅鯇黋꿍듏믑믓鯕맗듙뷛망藟迡臣裥鳧쓩꿫臭黯蛱蛳駵铷觹쟻鷽濿漁球椅昇漉戋稍㼏朑朓猕樗礙猛瀝吟倡䬣䨥嬧ԩ䴫崭䐯䀱嬳ᤵ䨷圹伻丽┿⅁ⵃ❅⑇㡉⍋㥍㙏㵑♓慕㹗㍙㥛㉝џᅡ䩣ṥ१ݩk", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
			num = (short)544145408;
			short num3 = num;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00057880 File Offset: 0x00055A80
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)1275308386;
			short num2 = num;
			num = (short)566929762;
			switch (num2 == num)
			{
			}
			num = (short)775684096;
			short num3 = num;
			num = (short)250281984;
			if (num != 0)
			{
			}
			num = (short)1042284545;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00057930 File Offset: 0x00055B30
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)530120705;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_10D;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
				{
					num = (short)283508736;
					short num3 = num;
					num = (short)1345781760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_B4;
				case 2:
					goto IL_185;
				case 3:
					goto IL_178;
				case 4:
					goto IL_192;
				case 5:
					goto IL_A7;
				case 6:
					goto IL_112;
				case 7:
					goto IL_9A;
				case 8:
					goto IL_E9;
				case 9:
					goto IL_11F;
				default:
					num = (short)1483407362;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_9A:
			this.NI3 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor)target;
			return;
			IL_A7:
			this.CB1 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor)target;
			return;
			IL_B4:
			num = (short)291700737;
			if (num != 0)
			{
			}
			this.Grid1 = (global::System.Windows.Controls.Primitives.UniformGrid)target;
			return;
			IL_E9:
			this.CB3 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor)target;
			return;
			IL_10D:
			goto IL_19F;
			IL_112:
			this.CB2 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor)target;
			return;
			IL_11F:
			num = (short)837694815;
			short num4 = num;
			num = (short)168375647;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_19F:
				this._contentLoaded = true;
				return;
			default:
				num = (short)1638531072;
				if (num != 0)
				{
				}
				this.CB4 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor)target;
				return;
			}
			IL_178:
			this.NI1 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor)target;
			return;
			IL_185:
			this.TB1 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
			return;
			IL_192:
			this.NI2 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor)target;
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00057AE4 File Offset: 0x00055CE4
		// Note: this type is marked as 'beforefieldinit'.
		static RMSpecialRowFor7Fields()
		{
			int a_ = 17;
			short num = (short)1886607757;
			short num2 = num;
			num = (short)139155853;
			switch (num2 == num)
			{
			}
			num = (short)1642070016;
			short num3 = num;
			num = (short)1591607296;
			if (num != 0)
			{
			}
			num = (short)1958543361;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.Header1Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("캪첬쮮풰솲蒴", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.Field1Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("슪좬쎮햰芲", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.IStringEdit), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.Field2Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("슪좬쎮햰膲", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.IStringEdit), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.ComboBox1Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쒪사춮\udeb0\udab4쾶袸", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.ComboBox2Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쒪사춮\udeb0\udab4쾶许", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.ComboBox3Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쒪사춮\udeb0\udab4쾶誸", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.ComboBox4Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쒪사춮\udeb0\udab4쾶趸", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.ComboBox5Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쒪사춮\udeb0\udab4쾶貸", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields), new global::System.Windows.FrameworkPropertyMetadata(null, null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields.Spin1Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("直\udbaa쒬솮肰", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.INumericEdit), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor7Fields), new global::System.Windows.FrameworkPropertyMetadata(null));
		}

		// Token: 0x04000234 RID: 564
		public static readonly global::System.Windows.DependencyProperty Header1Property;

		// Token: 0x04000235 RID: 565
		public static readonly global::System.Windows.DependencyProperty Field1Property;

		// Token: 0x04000236 RID: 566
		public static readonly global::System.Windows.DependencyProperty Field2Property;

		// Token: 0x04000237 RID: 567
		public static readonly global::System.Windows.DependencyProperty ComboBox1Property;

		// Token: 0x04000238 RID: 568
		public static readonly global::System.Windows.DependencyProperty ComboBox2Property;

		// Token: 0x04000239 RID: 569
		public static readonly global::System.Windows.DependencyProperty ComboBox3Property;

		// Token: 0x0400023A RID: 570
		public static readonly global::System.Windows.DependencyProperty ComboBox4Property;

		// Token: 0x0400023B RID: 571
		public static readonly global::System.Windows.DependencyProperty ComboBox5Property;

		// Token: 0x0400023C RID: 572
		public static readonly global::System.Windows.DependencyProperty Spin1Property;

		// Token: 0x0400023D RID: 573
		internal global::System.Windows.Controls.Primitives.UniformGrid Grid1;

		// Token: 0x0400023E RID: 574
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock TB1;

		// Token: 0x0400023F RID: 575
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor NI1;

		// Token: 0x04000240 RID: 576
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor NI2;

		// Token: 0x04000241 RID: 577
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor CB1;

		// Token: 0x04000242 RID: 578
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor CB2;

		// Token: 0x04000243 RID: 579
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor NI3;

		// Token: 0x04000244 RID: 580
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor CB3;

		// Token: 0x04000245 RID: 581
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor CB4;

		// Token: 0x04000246 RID: 582
		private bool _contentLoaded;
	}
}
