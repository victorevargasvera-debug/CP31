using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000086 RID: 134
	public class RMWiFiPasswordList : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000329 RID: 809 RVA: 0x00033368 File Offset: 0x00031568
		public RMWiFiPasswordList()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600032A RID: 810 RVA: 0x00033384 File Offset: 0x00031584
		// (set) Token: 0x0600032B RID: 811 RVA: 0x00033440 File Offset: 0x00031640
		public global::System.ComponentModel.ICollectionView WiFiNetworks
		{
			get
			{
				short num = (short)1272479232;
				short num2 = num;
				num = (short)1927446016;
				switch (num2 == num)
				{
				}
				num = (short)1324810240;
				short num3 = num;
				num = (short)378863617;
				if (num != 0)
				{
				}
				num = (short)50069504;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMWiFiPasswordList.WiFiNetworksProperty) as global::System.ComponentModel.ICollectionView;
			}
			set
			{
				short num = (short)342360065;
				if (num != 0)
				{
				}
				num = (short)1072424457;
				short num2 = num;
				num = (short)595322377;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1026162688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)831651840;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMWiFiPasswordList.WiFiNetworksProperty, value);
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600032C RID: 812 RVA: 0x000334F4 File Offset: 0x000316F4
		// (set) Token: 0x0600032D RID: 813 RVA: 0x000335B0 File Offset: 0x000317B0
		public global::System.Windows.Input.ICommand DeleteTemplatesCommand
		{
			get
			{
				short num = (short)1592456920;
				short num2 = num;
				num = (short)230618840;
				switch (num2 == num)
				{
				}
				num = (short)669450240;
				short num3 = num;
				num = (short)1401683969;
				if (num != 0)
				{
				}
				num = (short)21954560;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMWiFiPasswordList.DeleteTemplatesCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)776427158;
				short num2 = num;
				num = (short)1296651926;
				switch (num2 == num)
				{
				}
				num = (short)1080098816;
				short num3 = num;
				num = (short)633864193;
				if (num != 0)
				{
				}
				num = (short)1701117952;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMWiFiPasswordList.DeleteTemplatesCommandProperty, value);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00033668 File Offset: 0x00031868
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00033724 File Offset: 0x00031924
		public global::System.Windows.Input.ICommand EditTemplateCommand
		{
			get
			{
				short num = (short)280299942;
				short num2 = num;
				num = (short)913901990;
				switch (num2 == num)
				{
				}
				num = (short)2059599872;
				short num3 = num;
				num = (short)1723727873;
				if (num != 0)
				{
				}
				num = (short)351535104;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMWiFiPasswordList.EditTemplateCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)819813399;
				short num2 = num;
				num = (short)1816157207;
				switch (num2 == num)
				{
				}
				num = (short)169869312;
				short num3 = num;
				num = (short)2061565952;
				if (num != 0)
				{
				}
				num = (short)544342017;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMWiFiPasswordList.EditTemplateCommandProperty, value);
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000330 RID: 816 RVA: 0x000337D8 File Offset: 0x000319D8
		// (remove) Token: 0x06000331 RID: 817 RVA: 0x0003388C File Offset: 0x00031A8C
		public event global::System.Windows.RoutedEventHandler EditModeEnding
		{
			add
			{
				short num = (short)379565236;
				short num2 = num;
				num = (short)108180660;
				switch (num2 == num)
				{
				}
				num = (short)488505344;
				short num3 = num;
				num = (short)1981546496;
				if (num != 0)
				{
				}
				num = (short)246087681;
				if (num != 0)
				{
				}
				base.AddHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMWiFiPasswordList.EditModeEndingEvent, value);
			}
			remove
			{
				short num = (short)814497872;
				short num2 = num;
				num = (short)638926928;
				switch (num2 == num)
				{
				}
				num = (short)207093760;
				short num3 = num;
				num = (short)1164902401;
				if (num != 0)
				{
				}
				num = (short)1357447168;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMWiFiPasswordList.EditModeEndingEvent, value);
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00033940 File Offset: 0x00031B40
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 4;
			if (!this._contentLoaded)
			{
				short num = (short)652046450;
				short num2 = num;
				num = (short)314470514;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)956497921;
					if (num != 0)
					{
					}
					num = (short)1340276736;
					if (num != 0)
					{
					}
					num = (short)542048256;
					short num3 = num;
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("뎛펝쾟횡쮣풥잧용춫肭\uddb1\ud9b3\udbb5ힷ풹ﾻ鎿雃Ʂ곇ꏉꏋ菍뇏병뗓뇕뷗럙맛냝铟쳡꟣觥蛧黩黫臭鳯臱쿳闵韷韹賻釽滿朁樃爅✇缉缋欍戏焑笓砕気栙猛爝匟ഡ䔣唥尧堩䌫ĭ䈯弱䌳張帷匹䰻弽㌿ㅁ㍃⥅㩇⹉⁋❍⍏♑穓⹕㥗㝙せ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00033A20 File Offset: 0x00031C20
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)1895862948;
			short num2 = num;
			num = (short)69046948;
			switch (num2 == num)
			{
			}
			num = (short)1009909760;
			short num3 = num;
			num = (short)1356726273;
			if (num != 0)
			{
			}
			num = (short)234618880;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00033AD0 File Offset: 0x00031CD0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId != 1)
			{
				short num = (short)899048782;
				short num2 = num;
				num = (short)552232270;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1996881921;
					if (num != 0)
					{
					}
					num = (short)448921600;
					if (num != 0)
					{
					}
					num = (short)756744192;
					short num3 = num;
					this._contentLoaded = true;
					return;
				}
				}
			}
			this.dgrWiFiPassword = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00033B94 File Offset: 0x00031D94
		// Note: this type is marked as 'beforefieldinit'.
		static RMWiFiPasswordList()
		{
			int a_ = 2;
			short num = (short)1947305286;
			short num2 = num;
			num = (short)797410630;
			switch (num2 == num)
			{
			}
			num = (short)758579200;
			short num3 = num;
			num = (short)36110337;
			if (num != 0)
			{
			}
			num = (short)1039073280;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMWiFiPasswordList.WiFiNetworksProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춙\ud89d즟솣튥\udfa7얩\udeab얭쎯", a_), typeof(global::System.ComponentModel.ICollectionView), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMWiFiPasswordList));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMWiFiPasswordList.DeleteTemplatesCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ude99鍊얟횡솣춧잩\udcab슭톯욱톳억﮷햹톻펽ꆿ곁ꃃ", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMWiFiPasswordList));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMWiFiPasswordList.EditTemplateCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udf99풟솣쮥\ud8a7용춫\udaad햯\udbb3\udbb5햷\udbb9튻\udabd", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMWiFiPasswordList));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMWiFiPasswordList.EditModeEndingEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udf99풟쮣슥춧슫쪭\ud9af\udcb1펳", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMWiFiPasswordList));
		}

		// Token: 0x04000107 RID: 263
		public static readonly global::System.Windows.DependencyProperty WiFiNetworksProperty;

		// Token: 0x04000108 RID: 264
		public static readonly global::System.Windows.DependencyProperty DeleteTemplatesCommandProperty;

		// Token: 0x04000109 RID: 265
		public static readonly global::System.Windows.DependencyProperty EditTemplateCommandProperty;

		// Token: 0x0400010B RID: 267
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrWiFiPassword;

		// Token: 0x0400010C RID: 268
		private bool _contentLoaded;
	}
}
