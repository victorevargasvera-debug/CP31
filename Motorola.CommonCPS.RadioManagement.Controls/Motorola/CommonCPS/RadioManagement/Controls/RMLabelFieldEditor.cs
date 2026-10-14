using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000099 RID: 153
	public class RMLabelFieldEditor : global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060003B1 RID: 945 RVA: 0x0003CDA0 File Offset: 0x0003AFA0
		public RMLabelFieldEditor()
		{
			this.InitializeComponent();
			base.SetDefaultBindings();
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060003B2 RID: 946 RVA: 0x0003CDC0 File Offset: 0x0003AFC0
		// (remove) Token: 0x060003B3 RID: 947 RVA: 0x0003CE74 File Offset: 0x0003B074
		public event global::System.Windows.RoutedEventHandler RelocateHelpWindowRequested
		{
			add
			{
				short num = (short)1151074304;
				short num2 = num;
				num = (short)1866047334;
				short num3 = num;
				num = (short)134389606;
				switch (num3 == num)
				{
				}
				num = (short)1062010880;
				if (num != 0)
				{
				}
				num = (short)1634795521;
				if (num != 0)
				{
				}
				base.AddHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMLabelFieldEditor.RelocateHelpWindowRequestedEvent, value);
			}
			remove
			{
				short num = (short)654049280;
				short num2 = num;
				num = (short)1644536079;
				short num3 = num;
				num = (short)850174223;
				switch (num3 == num)
				{
				}
				num = (short)29491200;
				if (num != 0)
				{
				}
				num = (short)261881857;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMLabelFieldEditor.RelocateHelpWindowRequestedEvent, value);
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0003CF2C File Offset: 0x0003B12C
		protected void RaiseClickFieldHyperlink()
		{
			int a_ = 10;
			short num = (short)1124073472;
			short num2 = num;
			num = (short)699353676;
			short num3 = num;
			num = (short)1077824076;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1759444992;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase = base.DataContext as global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase;
				if (fieldBase != null)
				{
					num = (short)1689387009;
					if (num != 0)
					{
					}
					string source = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud9a1钣\udba5螧톩鶫펭", a_), (fieldBase.Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.Set).SetType, fieldBase.Name);
					base.RaiseEvent(new global::System.Windows.RoutedEventArgs(global::Motorola.CommonCPS.RadioManagement.Controls.RMLabelFieldEditor.RelocateHelpWindowRequestedEvent, source));
					return;
				}
				break;
			}
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0003D030 File Offset: 0x0003B230
		public override void LabelChanged(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor labelFieldEditor)
		{
			int a_ = 9;
			short num = (short)1769537536;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_48;
				}
				string text;
				string text2;
				global::System.Windows.Controls.TextBlock textBlock;
				int length;
				string text5;
				int length2;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						goto IL_1DD;
					case 1:
						goto IL_1DD;
					case 2:
						if (text.Contains(text2))
						{
							num = (short)1199833088;
							short num3 = num;
							num = (short)2047016963;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_248;
					case 3:
					{
						num = (short)1174725359;
						short num4 = num;
						num = (short)669770479;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)851705857;
							if (num != 0)
							{
							}
							num = (short)1367277568;
							if (num != 0)
							{
							}
							string text3 = text.Substring(0, text.IndexOf(text2, global::System.StringComparison.CurrentCulture));
							textBlock.Inlines.Add(text3);
							string text4 = text.Substring(text.IndexOf(text2, global::System.StringComparison.CurrentCulture) + length, text.IndexOf(text5, global::System.StringComparison.CurrentCulture) - text.IndexOf(text2, global::System.StringComparison.CurrentCulture) - length);
							global::System.Windows.Documents.Hyperlink hyperlink = new global::System.Windows.Documents.Hyperlink(new global::System.Windows.Documents.Run(text4));
							hyperlink.TextDecorations = new global::System.Windows.TextDecorationCollection();
							global::System.Windows.TextDecoration textDecoration = new global::System.Windows.TextDecoration();
							textDecoration.Location = global::System.Windows.TextDecorationLocation.Underline;
							hyperlink.TextDecorations.Add(textDecoration);
							textBlock.Inlines.Add(hyperlink);
							text = text.Substring(text.IndexOf(text5, global::System.StringComparison.CurrentCulture) + length2);
							hyperlink.Click += this.hyperlink_Click;
							num = (short)1887240193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					goto IL_48;
					IL_1DD:
					num = (short)279445506;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_248:
				textBlock.Inlines.Add(text);
				this.LabelPanel.Children.Add(textBlock);
				return;
				IL_48:
				textBlock = new global::System.Windows.Controls.TextBlock();
				text = labelFieldEditor.Label;
				text2 = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("鶠슢鮤", a_);
				length = text2.Length;
				text5 = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("鶠貢쒤馦", a_);
				length2 = text5.Length;
				num = (short)66191360;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0003D2A4 File Offset: 0x0003B4A4
		private void hyperlink_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)439353344;
			short num2 = num;
			num = (short)802881537;
			if (num != 0)
			{
			}
			num = (short)634959514;
			short num3 = num;
			num = (short)584562330;
			switch (num3 == num)
			{
			}
			num = (short)1062141952;
			if (num != 0)
			{
			}
			this.RaiseClickFieldHyperlink();
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0003D354 File Offset: 0x0003B554
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 16;
			short num = (short)1412236211;
			short num2 = num;
			num = (short)1767244723;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1221066753;
				if (num != 0)
				{
				}
				num = (short)1653342208;
				if (num != 0)
				{
				}
				if (!this._contentLoaded)
				{
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("螧쎫\udaad\udfaf삱\udbb3\udab5\ud9b7钹ﾻ톽궿꿁ꯃꣅ诇髉鿋苏돑냓뿕럗韙뷛냝臟藡臣该跧蓩飫샭돯鷱髳苵諷闹郻跽㯿愁欃欅砇攉戋欍縏昑㬓挕欗缙減紝伟䰡倣吥䜧䘩弫ĭ嘯嬱儳娵尷弹堻圽㐿ⵁ㙃㕅杇㡉⅋≍ㅏけㅓ㩕㹗㍙㥛㉝џݡcཥᱧթṫ䁭࡯፱ᥳ᩵", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
			num = (short)2041839616;
			short num3 = num;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0003D438 File Offset: 0x0003B638
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)1152337488;
			short num2 = num;
			num = (short)1558529616;
			switch (num2 == num)
			{
			}
			num = (short)1061093377;
			if (num != 0)
			{
			}
			num = (short)1247870976;
			short num3 = num;
			num = (short)11206656;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0003D4E8 File Offset: 0x0003B6E8
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				short num = (short)1194655745;
				if (num != 0)
				{
				}
				num = (short)919420127;
				short num2 = num;
				num = (short)88095967;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1889206272;
					short num3 = num;
					num = (short)1071972352;
					if (num != 0)
					{
					}
					this.LabelPanel = (global::System.Windows.Controls.StackPanel)target;
					return;
				}
				}
			}
			this._contentLoaded = true;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0003D5B0 File Offset: 0x0003B7B0
		// Note: this type is marked as 'beforefieldinit'.
		static RMLabelFieldEditor()
		{
			int a_ = 3;
			short num = (short)89165788;
			short num2 = num;
			num = (short)222662620;
			switch (num2 == num)
			{
			}
			num = (short)1017511937;
			if (num != 0)
			{
			}
			num = (short)330956800;
			short num3 = num;
			num = (short)1403060224;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMLabelFieldEditor.RelocateHelpWindowRequestedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즚캠삢쒤펦첨좬쎮솰\udcb4\ud9b6\uddb8풺쪼꓀닂냄ꋆ뫈뿊꣌ꯎ", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMLabelFieldEditor));
		}

		// Token: 0x04000139 RID: 313
		internal global::System.Windows.Controls.StackPanel LabelPanel;

		// Token: 0x0400013A RID: 314
		private bool _contentLoaded;
	}
}
