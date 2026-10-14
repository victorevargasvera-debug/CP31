using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200007D RID: 125
	public class RMSpecialRowFor1ComboBox1TextBox : global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditor, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060002D6 RID: 726 RVA: 0x0002EF3C File Offset: 0x0002D13C
		public RMSpecialRowFor1ComboBox1TextBox()
		{
			int a_ = 3;
			this.VoiceCommandFieldsList = new global::System.Collections.Generic.List<string>
			{
				global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즚ﲜﮞ톢스좦直좪첬솮ﺰ\uddb2\ud9b6ힸ풺좼톾ꋀꛂ꣄ꋆꟈ뿊鯌ꃎ룐냒냔铖뛘뛚냜뻞迠蟢", a_),
				global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즚ﲜﮞ톢스좦直좪첬솮ﺰ햲펴ힸ햺튼쪾꿀ꃂꃄ꫆곈ꗊ만駎뻐뫒뛔닖高듚냜닞胠跢臤", a_),
				global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즚ﲜﮞ톢스좦쒪쎬욮얰\udcb2잴ힸ튼횾ꋀꛂ蛄꣆꓈ꛊ곌ꇎ뗐", a_),
				global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즚ﲜﮞ톢스좦쒪쎬욮얰\udcb2잴\udfb8\uddba킾ꣀꃂꃄ蓆ꛈꛊꃌ껎뿐럒", a_),
				global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즚ﲜﮞ톢스좦슪\udfac쪮튰잲\ud8b6\uddb8\udeba톾韀곂계꓆곈裊ꋌꋎ볐닒믔돖", a_),
				global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즚ﲜﮞ톢스좦슪\udfac쪮튰잲\ud8b6\uddb8\udeba\ud9beꟀ闂꫄껆꫈껊軌ꃎ볐뻒듔맖뷘", a_),
				global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즚ﲜﮞ톢스좦ﶨ펪솮\ud9b0\udab2ힴ\udeb6춸펼껀ꫂꛄꋆ諈꓊ꃌꋎ냐뷒뇔", a_),
				global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즚ﲜﮞ톢스좦ﶨ펪솮\ud9b0\udab2ힴ\udeb6춸\udbbc\ud9be韀곂계꓆곈裊ꋌꋎ볐닒믔돖", a_),
				global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즚ﲜﮞ톢스좦얪캮\uddb0\udfb2쒶\udcb8즺ﲼ펾꓀뇂뇄裆ꟈ鷊ꋌꛎ닐뛒雔룖듘뛚볜뇞藠", a_),
				global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즚ﲜﮞ톢스좦얪캮\uddb0\udfb2쒶\udcb8즺ﲼ펾꓀뇂뇄裆꿈귊鯌ꃎ룐냒냔铖뛘뛚냜뻞迠蟢", a_),
				global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즚ﲜﮞ톢스좦욪좬\uddae횰횲\udbb4풶삸펼껀ꫂꛄꋆ諈꓊ꃌꋎ냐뷒뇔", a_),
				global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즚ﲜﮞ톢스좦直캪캬\udaae쎰횲쾶\udeba톼\udabeꋀ럂諄꧆鿈꓊꓌곎듐郒뫔뫖듘뫚돜믞", a_),
				global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즚ﲜﮞ톢스좦直캪캬\udaae쎰횲쾶\udeba톼\udabeꋀ럂諄ꇆ꿈鷊ꋌꛎ닐뛒雔룖듘뛚볜뇞藠", a_),
				global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즚ﲜﮞ톢스좦ﺨ\ud9aa슬솮횰풴쎶춸\udeba쾼욾韀곂계꓆곈裊ꋌꋎ볐닒믔돖", a_),
				global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즚ﲜﮞ톢스좦캪풬ﾮ킰ힲ\ud8b6ힸ쾺쾼킾귀냂规꣆꫈ꃊ苌ꇎ蟐볒볔듖볘飚닜닞賠苢诤菦", a_),
				global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즚ﲜﮞ톢스좦캪풬ﾮ킰ힲ\ud8b6ힸ쾺쾼킾귀냂规꣆꫈ꃊ苌꧎럐藒뫔뻖뫘뻚黜냞賠転蓤触跨", a_),
				global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즚ﲜﮞ톢스좦\udeaa솬\udbae\ud8b0살\ud9b6춸튺튼톾ꃀ꿂蟄닆뷈뿊ꋌꇎ臐ꇒ볔뫖룘꧚ꓜ鋞軠蟢胤ꓦ蛨", a_),
				global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즚ﲜﮞ톢스좦\udeaa솬\udbae\ud8b0살\ud9b6춸튺튼톾ꃀ꿂蟄닆뷈뿊ꋌꇎ苐뛒뛔룖럘뿚볜귞飠껢諤菦賨", a_),
				global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("솚쒠쮤즦욨\udeaa쎬첮풰\udeb2킴\ud9b6춸튼횾ꋀꛂ蛄꣆꓈ꛊ곌ꇎ뗐", a_)
			};
			base..ctor();
			this.InitializeComponent();
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0002F0E8 File Offset: 0x0002D2E8
		protected override void SetControlID()
		{
			int a_ = 12;
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
					goto IL_158;
				case 1:
					if (this.VoiceCommandFieldsList.Contains(((global::Motorola.CommonCPS.RadioManagement.UIModels.StringField)this.TBX1.DataContext).Name))
					{
						num2 = (short)1147404290;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_15A;
				case 2:
				{
					num2 = (short)52559873;
					if (num2 != 0)
					{
					}
					this.TBX1.Mask = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udfa3얥삧쮩\udeab钭莯螱躳蚵閷莹\uddbb鎽몿菁鳅铇뇋", a_);
					num2 = (short)626241900;
					short num3 = num2;
					num2 = (short)1798222188;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15A;
					default:
						num2 = (short)194510848;
						if (num2 != 0)
						{
						}
						num2 = (short)1668874240;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_25;
			}
			IL_158:
			IL_15A:
			base.SetControlID(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox.TextBox1Property, this.TBX1);
			return;
			IL_25:
			base.SetControlID(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox.ComboBox1Property, this.CB1);
			num2 = (short)574357504;
			short num4 = num2;
			num2 = (short)2120613889;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x0002F260 File Offset: 0x0002D460
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x0002F318 File Offset: 0x0002D518
		public string Header1
		{
			get
			{
				short num = (short)1437665593;
				short num2 = num;
				num = (short)351865145;
				switch (num2 == num)
				{
				}
				num = (short)1343619072;
				short num3 = num;
				num = (short)1675231233;
				if (num != 0)
				{
				}
				num = (short)2143289344;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox.Header1Property);
			}
			set
			{
				short num = (short)1169959082;
				short num2 = num;
				num = (short)603859114;
				switch (num2 == num)
				{
				}
				num = (short)84148224;
				short num3 = num;
				num = (short)1661075457;
				if (num != 0)
				{
				}
				num = (short)1933770752;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox.Header1Property, value);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0002F3D0 File Offset: 0x0002D5D0
		// (set) Token: 0x060002DB RID: 731 RVA: 0x0002F48C File Offset: 0x0002D68C
		public global::System.Windows.Visibility Header1Visibility
		{
			get
			{
				short num = (short)835598993;
				short num2 = num;
				num = (short)441662097;
				switch (num2 == num)
				{
				}
				num = (short)958136320;
				short num3 = num;
				num = (short)1932197888;
				if (num != 0)
				{
				}
				num = (short)608370689;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox.Header1VisibilityProperty);
			}
			set
			{
				short num = (short)741614337;
				short num2 = num;
				num = (short)807543553;
				switch (num2 == num)
				{
				}
				num = (short)1661206528;
				short num3 = num;
				num = (short)338755585;
				if (num != 0)
				{
				}
				num = (short)1893466112;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox.Header1VisibilityProperty, value);
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0002F544 File Offset: 0x0002D744
		// (set) Token: 0x060002DD RID: 733 RVA: 0x0002F5FC File Offset: 0x0002D7FC
		public string Header2
		{
			get
			{
				short num = (short)840894763;
				short num2 = num;
				num = (short)965937451;
				switch (num2 == num)
				{
				}
				num = (short)1324482560;
				short num3 = num;
				num = (short)1663959040;
				if (num != 0)
				{
				}
				num = (short)1621819393;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox.Header2Property);
			}
			set
			{
				short num = (short)1209108480;
				short num2 = num;
				num = (short)1538492416;
				switch (num2 == num)
				{
				}
				num = (short)36503552;
				short num3 = num;
				num = (short)1495990272;
				if (num != 0)
				{
				}
				num = (short)2127495169;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox.Header2Property, value);
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0002F6B0 File Offset: 0x0002D8B0
		// (set) Token: 0x060002DF RID: 735 RVA: 0x0002F768 File Offset: 0x0002D968
		public global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit ComboBox1
		{
			get
			{
				short num = (short)962088549;
				short num2 = num;
				num = (short)2092650085;
				switch (num2 == num)
				{
				}
				num = (short)740753408;
				short num3 = num;
				num = (short)1076756481;
				if (num != 0)
				{
				}
				num = (short)1354170368;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox.ComboBox1Property);
			}
			set
			{
				short num = (short)1695847021;
				short num2 = num;
				num = (short)1700434541;
				switch (num2 == num)
				{
				}
				num = (short)1248657408;
				short num3 = num;
				num = (short)2089025537;
				if (num != 0)
				{
				}
				num = (short)326500352;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox.ComboBox1Property, value);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x0002F820 File Offset: 0x0002DA20
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x0002F8DC File Offset: 0x0002DADC
		public global::Motorola.CommonCPS.RadioManagement.UIModels.IStringEdit TextBox1
		{
			get
			{
				short num = (short)2085746134;
				short num2 = num;
				num = (short)1654912470;
				switch (num2 == num)
				{
				}
				num = (short)1986527232;
				short num3 = num;
				num = (short)1253310465;
				if (num != 0)
				{
				}
				num = (short)326696960;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.IStringEdit)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox.TextBox1Property);
			}
			set
			{
				short num = (short)1673658369;
				if (num != 0)
				{
				}
				num = (short)620450436;
				short num2 = num;
				num = (short)2136035972;
				switch (num2 == num)
				{
				default:
				{
					num = (short)980221952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1951662080;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox.TextBox1Property, value);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x0002F994 File Offset: 0x0002DB94
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x0002FA4C File Offset: 0x0002DC4C
		public bool IsSortRequired
		{
			get
			{
				short num = (short)86537321;
				short num2 = num;
				num = (short)277050473;
				switch (num2 == num)
				{
				}
				num = (short)2132606976;
				short num3 = num;
				num = (short)1778319361;
				if (num != 0)
				{
				}
				num = (short)1266221056;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox.IsSortRequiredProperty);
			}
			set
			{
				short num = (short)1430121305;
				short num2 = num;
				num = (short)938142553;
				switch (num2 == num)
				{
				}
				num = (short)622198784;
				short num3 = num;
				num = (short)1306525696;
				if (num != 0)
				{
				}
				num = (short)129892353;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox.IsSortRequiredProperty, value);
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0002FB04 File Offset: 0x0002DD04
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 12;
			while (this._contentLoaded)
			{
				short num = (short)1914765312;
				short num2 = num;
				num = (short)601070550;
				short num3 = num;
				num = (short)1412144086;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1332871169;
					if (num != 0)
					{
					}
					num = (short)1133510656;
					if (num != 0)
					{
					}
					return;
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("讣잧\udea9쎫\udcad\udfaf\udeb1햳颵﮷햹톻펽꾿곁蟃雅鯇黋꿍듏믑믓鯕맗듙뷛망藟迡臣裥鳧쓩꿫臭黯蛱蛳駵铷觹쟻鷽濿漁球椅昇漉戋稍㼏朑朓猕樗礙猛瀝吟倡䬣䨥嬧ԩ䴫崭䐯䀱嬳ᤵ䨷圹伻丽┿⅁ⵃ❅⑇㡉⍋㥍㙏㵑♓杕㭗㕙ㅛ㱝ཟaୣṥ奧ṩ५᙭ѯၱ᭳๵噷ɹᵻ፽", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0002FBE8 File Offset: 0x0002DDE8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)1294884468;
			short num2 = num;
			num = (short)543645300;
			switch (num2 == num)
			{
			}
			num = (short)696516608;
			short num3 = num;
			num = (short)666959872;
			if (num != 0)
			{
			}
			num = (short)88473601;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0002FC9C File Offset: 0x0002DE9C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1826947073;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_DC;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					num = (short)916520960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				for (;;)
				{
					IL_30:
					switch (connectionId)
					{
					case 1:
						goto IL_114;
					case 2:
						goto IL_B7;
					case 3:
					{
						num = (short)428264020;
						short num3 = num;
						num = (short)683919956;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_95;
						}
						break;
					}
					case 4:
						goto IL_DE;
					}
					break;
				}
				num = (short)692912130;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_95:
			num = (short)2019491840;
			if (num != 0)
			{
			}
			this.CB1 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor)target;
			return;
			IL_B7:
			this.TB1 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
			return;
			IL_DC:
			this._contentLoaded = true;
			return;
			IL_DE:
			num = (short)884670464;
			short num4 = num;
			this.TBX1 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor)target;
			return;
			IL_114:
			num = (short)1295384577;
			if (num != 0)
			{
			}
			this.Grid1 = (global::System.Windows.Controls.Grid)target;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0002FDF8 File Offset: 0x0002DFF8
		// Note: this type is marked as 'beforefieldinit'.
		static RMSpecialRowFor1ComboBox1TextBox()
		{
			int a_ = 0;
			short num = (short)1857212188;
			short num2 = num;
			num = (short)2117259036;
			switch (num2 == num)
			{
			}
			num = (short)911147008;
			short num3 = num;
			num = (short)429719553;
			if (num != 0)
			{
			}
			num = (short)522387456;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox.Header1Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("킗ﾙﶛ瞧얟킡閣", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox.Header1VisibilityProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("킗ﾙﶛ瞧얟킡閣솧\ud9a9얫청\ud9af\udeb1\uddb3습솷", a_), typeof(global::System.Windows.Visibility), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Visible, null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox.Header2Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("킗ﾙﶛ瞧얟킡隣", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox.ComboBox1Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udb97ﲝ쾟쮣\udea5馧", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox.TextBox1Property = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첗ﾙ춡\udca3鞥", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.IStringEdit), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox.IsSortRequiredProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("톗쾛튟횡쎥\ud9a7\udfa9얫\udcad햯횱", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialRowFor1ComboBox1TextBox), new global::System.Windows.FrameworkPropertyMetadata(true));
		}

		// Token: 0x040000DF RID: 223
		private global::System.Collections.Generic.List<string> VoiceCommandFieldsList;

		// Token: 0x040000E0 RID: 224
		public static readonly global::System.Windows.DependencyProperty Header1Property;

		// Token: 0x040000E1 RID: 225
		public static readonly global::System.Windows.DependencyProperty Header1VisibilityProperty;

		// Token: 0x040000E2 RID: 226
		public static readonly global::System.Windows.DependencyProperty Header2Property;

		// Token: 0x040000E3 RID: 227
		public static readonly global::System.Windows.DependencyProperty ComboBox1Property;

		// Token: 0x040000E4 RID: 228
		public static readonly global::System.Windows.DependencyProperty TextBox1Property;

		// Token: 0x040000E5 RID: 229
		public static readonly global::System.Windows.DependencyProperty IsSortRequiredProperty;

		// Token: 0x040000E6 RID: 230
		internal global::System.Windows.Controls.Grid Grid1;

		// Token: 0x040000E7 RID: 231
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock TB1;

		// Token: 0x040000E8 RID: 232
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor CB1;

		// Token: 0x040000E9 RID: 233
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor TBX1;

		// Token: 0x040000EA RID: 234
		private bool _contentLoaded;
	}
}
