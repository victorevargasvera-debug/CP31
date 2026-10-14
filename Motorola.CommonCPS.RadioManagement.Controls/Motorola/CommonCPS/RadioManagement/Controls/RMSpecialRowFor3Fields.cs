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
	// Token: 0x020000C0 RID: 192
	public class RMSpecialRowFor3Fields : global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditor, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600051B RID: 1307 RVA: 0x00053178 File Offset: 0x00051378
		public RMSpecialRowFor3Fields()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00053194 File Offset: 0x00051394
		protected override void SetControlID()
		{
			short num = (short)902702260;
			short num2 = num;
			num = (short)417604788;
			switch (num2 == num)
			{
			default:
			{
				num = (short)836304896;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1749549056;
			if (num != 0)
			{
			}
			num = (short)849936385;
			if (num != 0)
			{
			}
			base.SetControlID(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields.ComboBox1Property, this.CB1);
			base.SetControlID(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields.ComboBox2Property, this.CB2);
			base.SetControlID(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields.ComboBox3Property, this.CB3);
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x00053270 File Offset: 0x00051470
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x00053328 File Offset: 0x00051528
		public string Header1
		{
			get
			{
				short num = (short)40151691;
				short num2 = num;
				num = (short)1035774603;
				switch (num2 == num)
				{
				default:
				{
					num = (short)316473344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1943863296;
				if (num != 0)
				{
				}
				num = (short)945356801;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields.Header1Property);
			}
			set
			{
				short num = (short)1438946135;
				short num2 = num;
				num = (short)11375447;
				switch (num2 == num)
				{
				default:
				{
					num = (short)534839296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)33161217;
				if (num != 0)
				{
				}
				num = (short)2057043968;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields.Header1Property, value);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x000533DC File Offset: 0x000515DC
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x00053494 File Offset: 0x00051694
		public global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit ComboBox1
		{
			get
			{
				short num = (short)498466817;
				if (num != 0)
				{
				}
				num = (short)2132672512;
				short num2 = num;
				num = (short)207629957;
				short num3 = num;
				num = (short)1113927301;
				switch (num3 == num)
				{
				}
				num = (short)1672871936;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields.ComboBox1Property);
			}
			set
			{
				short num = (short)216000173;
				short num2 = num;
				num = (short)1463871149;
				switch (num2 == num)
				{
				default:
				{
					num = (short)77856768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)60555265;
				if (num != 0)
				{
				}
				num = (short)1513816064;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields.ComboBox1Property, value);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x0005354C File Offset: 0x0005174C
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x00053608 File Offset: 0x00051808
		public string Header2
		{
			get
			{
				short num = (short)1402418993;
				short num2 = num;
				num = (short)277362481;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1382416384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)768016385;
				if (num != 0)
				{
				}
				num = (short)32374784;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields.Header2Property);
			}
			set
			{
				short num = (short)792824078;
				short num2 = num;
				num = (short)1141606670;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1010302976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)908394497;
				if (num != 0)
				{
				}
				num = (short)220659712;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields.Header2Property, value);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x000536C0 File Offset: 0x000518C0
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00053778 File Offset: 0x00051978
		public global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit ComboBox2
		{
			get
			{
				short num = (short)1418744915;
				short num2 = num;
				num = (short)1558008915;
				switch (num2 == num)
				{
				default:
				{
					num = (short)570490880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)286785537;
				if (num != 0)
				{
				}
				num = (short)1919680512;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields.ComboBox2Property);
			}
			set
			{
				short num = (short)1359300543;
				short num2 = num;
				num = (short)1685931967;
				switch (num2 == num)
				{
				}
				num = (short)807993344;
				if (num != 0)
				{
				}
				num = (short)497876992;
				short num3 = num;
				num = (short)188874753;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields.ComboBox2Property, value);
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x00053830 File Offset: 0x00051A30
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x000538EC File Offset: 0x00051AEC
		public string Header3
		{
			get
			{
				short num = (short)1812987905;
				if (num != 0)
				{
				}
				num = (short)2058754921;
				short num2 = num;
				num = (short)1964383081;
				switch (num2 == num)
				{
				}
				num = (short)1175126016;
				short num3 = num;
				num = (short)1344733184;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields.Header3Property);
			}
			set
			{
				short num = (short)1524792066;
				short num2 = num;
				num = (short)367033090;
				switch (num2 == num)
				{
				}
				num = (short)1925382145;
				if (num != 0)
				{
				}
				num = (short)1354956800;
				short num3 = num;
				num = (short)1444085760;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields.Header3Property, value);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x000539A4 File Offset: 0x00051BA4
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x00053A5C File Offset: 0x00051C5C
		public global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit ComboBox3
		{
			get
			{
				short num = (short)1584239287;
				short num2 = num;
				num = (short)914199223;
				switch (num2 == num)
				{
				}
				num = (short)1477902337;
				if (num != 0)
				{
				}
				num = (short)1920860160;
				short num3 = num;
				num = (short)313917440;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields.ComboBox3Property);
			}
			set
			{
				short num = (short)484930211;
				short num2 = num;
				num = (short)59929251;
				switch (num2 == num)
				{
				}
				num = (short)186712064;
				if (num != 0)
				{
				}
				num = (short)284360704;
				short num3 = num;
				num = (short)2087387137;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields.ComboBox3Property, value);
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00053B10 File Offset: 0x00051D10
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 11;
			while (!this._contentLoaded)
			{
				short num = (short)667483663;
				short num2 = num;
				num = (short)17497615;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1684209665;
					if (num != 0)
					{
					}
					num = (short)717357056;
					short num3 = num;
					num = (short)840302592;
					if (num != 0)
					{
					}
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("貢좦\udda8쒪\udfac삮\uddb0튲鮴횸횺킼킾꿀胂闄铆駊곌ꯎ룐볒飔뛖럘뫚뫜뫞賠蛢诤鏦쟨꣪苬臮藰臲髴鯶諸샺黼郾氀猂樄椆氈攊礌‎搐怒瀔攖稘琚猜欞匠䰢䤤否ب䨪帬嬮䌰尲ᨴ䔶吸䠺䴼娾≀⩂⑄⭆㭈⑊㩌⥎㹐⅒晔ㅖじ㹚ㅜ㭞በ䵢ᵤ٦Ѩݪ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00053BF0 File Offset: 0x00051DF0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)1317491123;
			short num2 = num;
			num = (short)1436766643;
			switch (num2 == num)
			{
			}
			num = (short)936706049;
			if (num != 0)
			{
			}
			num = (short)376832000;
			short num3 = num;
			num = (short)1521745920;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00053CA0 File Offset: 0x00051EA0
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1756823554;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_12A;
				case 1:
					num = (short)1419771905;
					if (num != 0)
					{
					}
					num = (short)1092943872;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_F9;
				case 2:
					goto IL_170;
				case 3:
					goto IL_163;
				case 4:
					goto IL_EC;
				case 5:
					goto IL_95;
				case 6:
					goto IL_156;
				case 7:
					goto IL_106;
				default:
					num = (short)1495924737;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_95:
			num = (short)1946501399;
			short num3 = num;
			num = (short)857751831;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_12A:
				num = (short)783548416;
				short num4 = num;
				this._contentLoaded = true;
				return;
			}
			default:
				num = (short)769392640;
				if (num != 0)
				{
				}
				this.CB2 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor)target;
				return;
			}
			IL_EC:
			this.TB2 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
			return;
			IL_F9:
			this.Grid1 = (global::System.Windows.Controls.Grid)target;
			return;
			IL_106:
			this.CB3 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor)target;
			return;
			IL_156:
			this.TB3 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
			return;
			IL_163:
			this.CB1 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor)target;
			return;
			IL_170:
			this.TB1 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00053E34 File Offset: 0x00052034
		// Note: this type is marked as 'beforefieldinit'.
		static RMSpecialRowFor3Fields()
		{
			int a_ = 8;
			short num = (short)736898941;
			short num2 = num;
			num = (short)1470377853;
			switch (num2 == num)
			{
			}
			num = (short)1181941761;
			if (num != 0)
			{
			}
			num = (short)239534080;
			short num3 = num;
			num = (short)1946615808;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields.Header1Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("잡얣슥춧\ud8a9鶫", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields.ComboBox1Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춡즣쒥잧쎫횭膯", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields.Header2Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("잡얣슥춧\ud8a9麫", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields.ComboBox2Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춡즣쒥잧쎫횭芯", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields.Header3Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("잡얣슥춧\ud8a9龫", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields.ComboBox3Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춡즣쒥잧쎫횭莯", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor3Fields), new global::System.Windows.FrameworkPropertyMetadata(null));
		}

		// Token: 0x04000202 RID: 514
		public static readonly global::System.Windows.DependencyProperty Header1Property;

		// Token: 0x04000203 RID: 515
		public static readonly global::System.Windows.DependencyProperty ComboBox1Property;

		// Token: 0x04000204 RID: 516
		public static readonly global::System.Windows.DependencyProperty Header2Property;

		// Token: 0x04000205 RID: 517
		public static readonly global::System.Windows.DependencyProperty ComboBox2Property;

		// Token: 0x04000206 RID: 518
		public static readonly global::System.Windows.DependencyProperty Header3Property;

		// Token: 0x04000207 RID: 519
		public static readonly global::System.Windows.DependencyProperty ComboBox3Property;

		// Token: 0x04000208 RID: 520
		internal global::System.Windows.Controls.Grid Grid1;

		// Token: 0x04000209 RID: 521
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock TB1;

		// Token: 0x0400020A RID: 522
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor CB1;

		// Token: 0x0400020B RID: 523
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock TB2;

		// Token: 0x0400020C RID: 524
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor CB2;

		// Token: 0x0400020D RID: 525
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock TB3;

		// Token: 0x0400020E RID: 526
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor CB3;

		// Token: 0x0400020F RID: 527
		private bool _contentLoaded;
	}
}
