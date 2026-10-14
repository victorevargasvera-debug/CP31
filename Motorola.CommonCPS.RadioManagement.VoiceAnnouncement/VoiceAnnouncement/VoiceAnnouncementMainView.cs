using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.ConfigurationEditor;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.VoiceAnnouncement
{
	// Token: 0x02000003 RID: 3
	[global::System.ComponentModel.Composition.Export("VoiceAnnouncementMainView")]
	public class VoiceAnnouncementMainView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public VoiceAnnouncementMainView()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000003 RID: 3
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002138 File Offset: 0x00000338
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.VoiceAnnouncement.MainViewModel ViewModel
		{
			set
			{
				short num = (short)475500823;
				short num2 = num;
				num = (short)96178455;
				switch (num2 == num)
				{
				}
				num = (short)1013645312;
				if (num != 0)
				{
				}
				num = (short)1151533057;
				if (num != 0)
				{
				}
				num = (short)1353056256;
				short num3 = num;
				base.DataContext = value;
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021E8 File Offset: 0x000003E8
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1274517558;
			short num2 = num;
			num = (short)1242863670;
			switch (num2 == num)
			{
			}
			num = (short)251592705;
			if (num != 0)
			{
			}
			num = (short)1803354112;
			if (num != 0)
			{
			}
			num = (short)1258815488;
			short num3 = num;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002294 File Offset: 0x00000494
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 4;
			short num;
			if (!this._contentLoaded)
			{
				num = (short)913279478;
				short num2 = num;
				num = (short)1079216630;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)524484608;
					if (num != 0)
					{
					}
					num = (short)1779236865;
					if (num != 0)
					{
					}
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ConfigurationEditor.Styles.d("䑪⁬nհᱲݴᡶᕸ᩺卼㱾좊\udd8c\udc8e뾐솒킜ﺞ쾠슢스슦쒨캪쎬\udbae龰\udab4\udeb6\udab8\udebaﲼ톾꿀곂냄꧆꫈껊ꃌ꫎뿐꟒듖뛘뛚규냞迠蛢诤鏦웨蛪賬蛮鿰藲鳴鋶軸헺藼黾氀漂", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
			num = (short)1839464448;
			short num3 = num;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002374 File Offset: 0x00000574
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)361562113;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)3638723;
					short num3 = num;
					num = (short)1303741891;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)808321024;
						if (num != 0)
						{
						}
						num = (short)69926912;
						short num4 = num;
						break;
					}
					}
					num = (short)1020067843;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				case 2:
					if (connectionId != 2)
					{
						num = (short)1302724608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_169;
				case 3:
					goto IL_8E;
				case 4:
					num = (short)882704386;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3A:
				if (connectionId == 1)
				{
					break;
				}
				num = (short)1581318148;
				num2 = (int)((global::System.IntPtr)num);
			}
			this.uscVoiceAnnouncements = (global::Motorola.CommonCPS.RadioManagement.VoiceAnnouncement.VoiceAnnouncementMainView)target;
			this.uscVoiceAnnouncements.Loaded += this.a;
			return;
			IL_8E:
			num = (short)2031091713;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
			return;
			IL_169:
			this.dgrVoiceAnnouncements = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
		}

		// Token: 0x04000003 RID: 3
		internal global::Motorola.CommonCPS.RadioManagement.VoiceAnnouncement.VoiceAnnouncementMainView uscVoiceAnnouncements;

		// Token: 0x04000004 RID: 4
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrVoiceAnnouncements;

		// Token: 0x04000005 RID: 5
		private bool _contentLoaded;
	}
}
