using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Xml;
using AcpUI.Common;

namespace AcpUI
{
	// Token: 0x0200001C RID: 28
	public partial class AcpListBoxMruFiles : UserControl, IStyleConnector
	{
		// Token: 0x0600018D RID: 397 RVA: 0x0001DAC0 File Offset: 0x0001BCC0
		public AcpListBoxMruFiles()
		{
			this.InitializeComponent();
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600018E RID: 398 RVA: 0x0001DADC File Offset: 0x0001BCDC
		// (remove) Token: 0x0600018F RID: 399 RVA: 0x0001DB94 File Offset: 0x0001BD94
		public event RoutedEventHandler FileClick
		{
			add
			{
				short num = (short)957415424;
				short num2 = num;
				num = (short)195791189;
				short num3 = num;
				num = (short)1023248725;
				switch (num3 == num)
				{
				}
				num = (short)1953234945;
				if (num != 0)
				{
				}
				num = (short)175439872;
				if (num != 0)
				{
				}
				base.AddHandler(AcpListBoxMruFiles.FileClickEvent, value);
			}
			remove
			{
				short num = (short)2055012352;
				short num2 = num;
				num = (short)1317208065;
				if (num != 0)
				{
				}
				num = (short)587416971;
				short num3 = num;
				num = (short)841762187;
				switch (num3 == num)
				{
				}
				num = (short)277413888;
				if (num != 0)
				{
				}
				base.RemoveHandler(AcpListBoxMruFiles.FileClickEvent, value);
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0001DC48 File Offset: 0x0001BE48
		private void OnMruFileClick(object A_0, RoutedEventArgs A_1)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)1622278145;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_E8;
					case 1:
					{
						num = (short)1673414101;
						short num3 = num;
						num = (short)1612465621;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1490026496;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_7E;
							}
							continue;
						}
						break;
					}
					case 2:
						base.RaiseEvent(new SelectedMruFileEventArgs(((XmlAttribute)((StackPanel)A_0).Tag).Value)
						{
							RoutedEvent = AcpListBoxMruFiles.FileClickEvent,
							Source = A_0
						});
						num = (short)1038417920;
						num2 = (int)((IntPtr)num);
						continue;
					}
					IL_7E:
					if (!(A_0 is StackPanel))
					{
						goto IL_113;
					}
					num = (short)1950154754;
					num2 = (int)((IntPtr)num);
				}
			}
			IL_E8:
			num = (short)1182007296;
			short num4 = num;
			IL_113:
			num = (short)1290600449;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0001DF34 File Offset: 0x0001C134
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "5.0.17.0")]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			for (;;)
			{
				IL_00:
				short num = (short)570753025;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)380937106;
						short num3 = num;
						num = (short)337027986;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)32374784;
							if (num != 0)
							{
							}
							num = (short)467533825;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_A4;
							}
							continue;
						}
						break;
					}
					case 2:
					{
						((StackPanel)target).MouseLeftButtonDown += new MouseButtonEventHandler(this.OnMruFileClick);
						num = (short)220463104;
						short num4 = num;
						num = (short)618397696;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					IL_A4:
					if (connectionId != 2)
					{
						return;
					}
					num = (short)85655554;
					num2 = (int)((IntPtr)num);
				}
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0001E058 File Offset: 0x0001C258
		// Note: this type is marked as 'beforefieldinit'.
		static AcpListBoxMruFiles()
		{
			int a_ = 7;
			short num = (short)726597632;
			short num2 = num;
			num = (short)77527005;
			short num3 = num;
			num = (short)43382749;
			switch (num3 == num)
			{
			}
			num = (short)1254293505;
			if (num != 0)
			{
			}
			num = (short)428802048;
			if (num != 0)
			{
			}
			AcpListBoxMruFiles.FileClickEvent = EventManager.RegisterRoutedEvent(Utility.c("\udb9c춠욢쮦삨좪욬", a_), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(AcpListBoxMruFiles));
		}
	}
}
