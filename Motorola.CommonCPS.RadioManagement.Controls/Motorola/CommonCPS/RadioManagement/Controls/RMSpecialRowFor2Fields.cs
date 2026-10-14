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
	// Token: 0x020000BE RID: 190
	public class RMSpecialRowFor2Fields : global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditor, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060004FE RID: 1278 RVA: 0x00051A48 File Offset: 0x0004FC48
		public RMSpecialRowFor2Fields()
		{
			this.InitializeComponent();
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00051A64 File Offset: 0x0004FC64
		protected override void SetControlID()
		{
			short num = (short)1313431955;
			short num2 = num;
			num = (short)357851539;
			switch (num2 == num)
			{
			}
			num = (short)1563492353;
			if (num != 0)
			{
			}
			num = (short)1009516544;
			if (num != 0)
			{
			}
			num = (short)623247360;
			short num3 = num;
			base.SetControlID(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor2Fields.ComboBox1Property, this.CB1);
			base.SetControlID(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor2Fields.ComboBox2Property, this.CB2);
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x00051B30 File Offset: 0x0004FD30
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x00051BE8 File Offset: 0x0004FDE8
		public string Header1
		{
			get
			{
				short num = (short)863966537;
				short num2 = num;
				num = (short)1206785353;
				switch (num2 == num)
				{
				}
				num = (short)402653184;
				if (num != 0)
				{
				}
				num = (short)1258815489;
				if (num != 0)
				{
				}
				num = (short)1382023168;
				short num3 = num;
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor2Fields.Header1Property);
			}
			set
			{
				short num = (short)1146416349;
				short num2 = num;
				num = (short)1810885853;
				switch (num2 == num)
				{
				}
				num = (short)1406795777;
				if (num != 0)
				{
				}
				num = (short)158597120;
				if (num != 0)
				{
				}
				num = (short)1676935168;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor2Fields.Header1Property, value);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x00051C9C File Offset: 0x0004FE9C
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x00051D58 File Offset: 0x0004FF58
		public global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit ComboBox1
		{
			get
			{
				short num = (short)388462994;
				short num2 = num;
				num = (short)1080916370;
				switch (num2 == num)
				{
				}
				num = (short)29753345;
				if (num != 0)
				{
				}
				num = (short)776470528;
				if (num != 0)
				{
				}
				num = (short)833617920;
				short num3 = num;
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor2Fields.ComboBox1Property);
			}
			set
			{
				short num = (short)378980737;
				short num2 = num;
				num = (short)63097217;
				switch (num2 == num)
				{
				}
				num = (short)2076901376;
				if (num != 0)
				{
				}
				num = (short)2009595905;
				if (num != 0)
				{
				}
				num = (short)1295712256;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor2Fields.ComboBox1Property, value);
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x00051E0C File Offset: 0x0005000C
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x00051EC8 File Offset: 0x000500C8
		public global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit ComboBox2
		{
			get
			{
				short num = (short)928130991;
				short num2 = num;
				num = (short)1340155823;
				switch (num2 == num)
				{
				}
				num = (short)2067529729;
				if (num != 0)
				{
				}
				num = (short)317849600;
				if (num != 0)
				{
				}
				num = (short)911736832;
				short num3 = num;
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor2Fields.ComboBox2Property);
			}
			set
			{
				short num = (short)1595801600;
				short num2 = num;
				num = (short)1801362830;
				short num3 = num;
				num = (short)1493343630;
				switch (num3 == num)
				{
				}
				num = (short)337510401;
				if (num != 0)
				{
				}
				num = (short)1971060736;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor2Fields.ComboBox2Property, value);
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00051F80 File Offset: 0x00050180
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x00052038 File Offset: 0x00050238
		public bool IsSortRequired
		{
			get
			{
				short num = (short)839188480;
				short num2 = num;
				num = (short)689678363;
				short num3 = num;
				num = (short)592422939;
				switch (num3 == num)
				{
				}
				num = (short)321519616;
				if (num != 0)
				{
				}
				num = (short)20381697;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor2Fields.IsSortRequiredProperty);
			}
			set
			{
				short num = (short)1697825413;
				short num2 = num;
				num = (short)696763013;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1235943424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)692649985;
				if (num != 0)
				{
				}
				num = (short)1181024256;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor2Fields.IsSortRequiredProperty, value);
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x000520F4 File Offset: 0x000502F4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 18;
			if (this._contentLoaded)
			{
				short num = (short)602724753;
				short num2 = num;
				num = (short)444520849;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1815609345;
					if (num != 0)
					{
					}
					num = (short)482934784;
					short num3 = num;
					num = (short)40763392;
					if (num != 0)
					{
					}
					break;
				}
				}
				return;
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("薩솭쒯\uddb1욳\ud9b5풷\udbb9銻ﶽ꾿꿁꧃꧅ꛇ觉鳋鷍ﻏ胑뗓닕뇗뗙釛뿝軟菡菣菥藧迩苫髭\udeef뇱鯳飵賷裹鏻鋽珿㤁會椅攇稉挋怍甏簑怓㤕洗椙礛氝䌟䴡䨣別娧䔩䀫崭Ἧ匱䜳䈵䨷唹ጻ䰽ⴿㅁ㑃⍅⭇⍉ⵋ≍≏㵑⍓さ㝗⡙湛㡝य़ݡࡣɥ᭧䑩ᑫ཭ᵯṱ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000521D8 File Offset: 0x000503D8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)1573085665;
			short num2 = num;
			num = (short)1426809313;
			switch (num2 == num)
			{
			default:
			{
				num = (short)232062976;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1297285121;
			if (num != 0)
			{
			}
			num = (short)2099118080;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00052288 File Offset: 0x00050488
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1903362049;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)485294082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					goto IL_E0;
				}
				IL_30:
				num = (short)964330498;
				short num3 = num;
				num = (short)923501570;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_E2;
				default:
					num = (short)174391296;
					if (num != 0)
					{
					}
					switch (connectionId)
					{
					case 1:
						goto IL_140;
					case 2:
						goto IL_BC;
					case 3:
						goto IL_AF;
					case 4:
						goto IL_E2;
					default:
						num = (short)530382848;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
			}
			IL_AF:
			this.CB1 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor)target;
			return;
			IL_BC:
			this.TB1 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
			return;
			IL_E0:
			this._contentLoaded = true;
			return;
			IL_E2:
			num = (short)585105408;
			short num4 = num;
			num = (short)345505793;
			if (num != 0)
			{
			}
			this.CB2 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor)target;
			return;
			IL_140:
			this.Grid1 = (global::System.Windows.Controls.Grid)target;
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x000523EC File Offset: 0x000505EC
		// Note: this type is marked as 'beforefieldinit'.
		static RMSpecialRowFor2Fields()
		{
			int a_ = 8;
			short num = (short)1964703745;
			if (num != 0)
			{
			}
			num = (short)1199177728;
			short num2 = num;
			num = (short)1901282364;
			short num3 = num;
			num = (short)603472956;
			switch (num3 == num)
			{
			}
			num = (short)673972224;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor2Fields.Header1Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("잡얣슥춧\ud8a9鶫", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor2Fields), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor2Fields.ComboBox1Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춡즣쒥잧쎫횭膯", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor2Fields), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor2Fields.ComboBox2Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춡즣쒥잧쎫횭芯", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor2Fields), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor2Fields.IsSortRequiredProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("톡즥\udaa7\udea9ﺫ쮭솯잱\uddb3쒵\uddb7\udeb9", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor2Fields), new global::System.Windows.FrameworkPropertyMetadata(true));
		}

		// Token: 0x040001EF RID: 495
		public static readonly global::System.Windows.DependencyProperty Header1Property;

		// Token: 0x040001F0 RID: 496
		public static readonly global::System.Windows.DependencyProperty ComboBox1Property;

		// Token: 0x040001F1 RID: 497
		public static readonly global::System.Windows.DependencyProperty ComboBox2Property;

		// Token: 0x040001F2 RID: 498
		public static readonly global::System.Windows.DependencyProperty IsSortRequiredProperty;

		// Token: 0x040001F3 RID: 499
		internal global::System.Windows.Controls.Grid Grid1;

		// Token: 0x040001F4 RID: 500
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock TB1;

		// Token: 0x040001F5 RID: 501
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor CB1;

		// Token: 0x040001F6 RID: 502
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor CB2;

		// Token: 0x040001F7 RID: 503
		private bool _contentLoaded;
	}
}
