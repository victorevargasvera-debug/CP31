using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using AcpUI;
using AcpUI.Common;
using CommonResources;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS
{
	// Token: 0x0200002B RID: 43
	public class PageAvailableDevice : global::System.Windows.Controls.Page, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00011DE8 File Offset: 0x0000FFE8
		public PageAvailableDevice()
		{
			int a_ = 17;
			base..ctor();
			this.InitializeComponent();
			global::AcpUI.Common.Utility.SetDirection(this);
			global::AcpUI.AcpTreeViewItem acpTreeViewItem = new global::AcpUI.AcpTreeViewItem();
			acpTreeViewItem.Name = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꗰ臲郴鋶꿸鋺飼裾䠀眂怄樆䠈紊氌明紐爒眔笖簘弚砜椞䠠䀢䀤", a_);
			acpTreeViewItem.Header = global::CommonResources.AppResources.Available_Device;
			acpTreeViewItem.IsExpanded = true;
			this.MyTreeView.Items.Add(acpTreeViewItem);
			global::AcpUI.AcpTreeViewItem acpTreeViewItem2 = new global::AcpUI.AcpTreeViewItem();
			acpTreeViewItem2.Header = new global::System.Windows.Controls.CheckBox
			{
				Content = global::CommonResources.AppResources.XTL5000_588008_000480,
				Name = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꗰ臲郴鋶꿸鋺飼裾䠀眂怄樆儈弊䄌㨎ℐ⌒└", a_)
			};
			acpTreeViewItem.Items.Add(acpTreeViewItem2);
			global::AcpUI.AcpTreeViewItem acpTreeViewItem3 = new global::AcpUI.AcpTreeViewItem();
			acpTreeViewItem3.Header = new global::System.Windows.Controls.CheckBox
			{
				Content = global::CommonResources.AppResources.Radio_ID1,
				Name = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꗰ臲郴鋶꿸鋺飼裾䠀眂怄樆儈弊䄌㨎ℐ⌒└☖", a_)
			};
			acpTreeViewItem2.Items.Add(acpTreeViewItem3);
			global::AcpUI.AcpTreeViewItem acpTreeViewItem4 = new global::AcpUI.AcpTreeViewItem();
			acpTreeViewItem4.Header = new global::System.Windows.Controls.CheckBox
			{
				Content = global::CommonResources.AppResources.Radio_ID2,
				Name = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꗰ臲郴鋶꿸鋺飼裾䠀眂怄樆儈弊䄌㨎ℐ⌒└☖", a_)
			};
			acpTreeViewItem2.Items.Add(acpTreeViewItem4);
			global::AcpUI.AcpTreeViewItem acpTreeViewItem5 = new global::AcpUI.AcpTreeViewItem();
			acpTreeViewItem5.Header = new global::System.Windows.Controls.CheckBox
			{
				Content = global::CommonResources.AppResources.XTL2500_588008_000480,
				Name = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꗰ臲郴鋶꿸鋺飼裾䠀眂怄樆儈弊䄌㴎␐⌒└", a_)
			};
			acpTreeViewItem.Items.Add(acpTreeViewItem5);
			global::AcpUI.AcpTreeViewItem acpTreeViewItem6 = new global::AcpUI.AcpTreeViewItem();
			acpTreeViewItem6.Header = new global::System.Windows.Controls.CheckBox
			{
				Content = global::CommonResources.AppResources.Radio_ID3,
				Name = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꗰ臲郴鋶꿸鋺飼裾䠀眂怄樆儈弊䄌㴎␐⌒└☖", a_)
			};
			acpTreeViewItem5.Items.Add(acpTreeViewItem6);
			global::AcpUI.AcpTreeViewItem acpTreeViewItem7 = new global::AcpUI.AcpTreeViewItem();
			acpTreeViewItem7.Header = new global::System.Windows.Controls.CheckBox
			{
				Content = global::CommonResources.AppResources.XTL1500_588008_000480,
				Name = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꗰ臲郴鋶꿸鋺飼裾䠀眂怄樆儈弊䄌㸎␐⌒└", a_)
			};
			acpTreeViewItem.Items.Add(acpTreeViewItem7);
			global::AcpUI.AcpTreeViewItem acpTreeViewItem8 = new global::AcpUI.AcpTreeViewItem();
			acpTreeViewItem8.Header = new global::System.Windows.Controls.CheckBox
			{
				Content = global::CommonResources.AppResources.Radio_ID4,
				Name = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꗰ臲郴鋶꿸鋺飼裾䠀眂怄樆儈弊䄌㸎␐⌒└☖", a_)
			};
			acpTreeViewItem7.Items.Add(acpTreeViewItem8);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00012030 File Offset: 0x00010230
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 18;
			short num = (short)1235033524;
			short num2 = num;
			num = (short)1709710772;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1535115265;
				if (num != 0)
				{
				}
				num = (short)1688600576;
				short num3 = num;
				num = (short)2118778880;
				if (num != 0)
				{
				}
				if (!this._contentLoaded)
				{
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("\uddf1뗳꛵ꃷ볹鷻鏽槿渁紃䔅堇変㜋洍缏缑搓礕瘗缙爛樝༟䘡䄣倥䄧䤩䤫䌭儯就唳儵崷䠹ጻ丽ℿ╁⅃❅㹇⭉╋≍ㅏけ㡓㍕㱗㽙⩛㝝͟ݡ䩣ṥ१ݩk", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00012110 File Offset: 0x00010310
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1221394432;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 1:
					goto IL_D8;
				case 2:
					goto IL_EF;
				case 3:
					num = (short)990183428;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1054867457;
					if (num != 0)
					{
					}
					if (connectionId != 2)
					{
						num = (short)683147265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14D;
				}
				IL_38:
				if (connectionId != 1)
				{
					num = (short)2089222147;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)638705772;
				short num3 = num;
				num = (short)1451679852;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_8B;
				}
				IL_D8:
				num = (short)577175554;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_8B:
			num = (short)2047803392;
			if (num != 0)
			{
			}
			num = (short)298975232;
			short num4 = num;
			this.button = (global::System.Windows.Controls.Button)target;
			return;
			IL_EF:
			this._contentLoaded = true;
			return;
			IL_14D:
			this.MyTreeView = (global::System.Windows.Controls.TreeView)target;
		}

		// Token: 0x04000070 RID: 112
		internal global::System.Windows.Controls.Button button;

		// Token: 0x04000071 RID: 113
		internal global::System.Windows.Controls.TreeView MyTreeView;

		// Token: 0x04000072 RID: 114
		private bool _contentLoaded;

		// Token: 0x04000073 RID: 115
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
