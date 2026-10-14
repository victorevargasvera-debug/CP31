using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using AcpUI.Common;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.FileOperations
{
	// Token: 0x0200010F RID: 271
	public partial class BrowseForFileDialogBox : Window
	{
		// Token: 0x06000EEE RID: 3822 RVA: 0x0014D5F0 File Offset: 0x0014B7F0
		public BrowseForFileDialogBox(Action<BrowseForFilePage> action, FileOperationData fileOperationData, Type expectedProgressPageType)
		{
			this.a = expectedProgressPageType;
			this.FileOperationData = fileOperationData;
			Utility.SetDirection(this);
			this.b = false;
			this.InitializeComponent();
			BrowseForFileLauncher browseForFileLauncher = new BrowseForFileLauncher(action, this.FileOperationData);
			browseForFileLauncher.FileOperationReturn += this.a;
			this.BrowseForFileMainFrame.Navigate(browseForFileLauncher);
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x0014D650 File Offset: 0x0014B850
		// (set) Token: 0x06000EF0 RID: 3824 RVA: 0x0014D700 File Offset: 0x0014B900
		public FileOperationData FileOperationData
		{
			[CompilerGenerated]
			get
			{
				short num = (short)523273300;
				short num2 = num;
				num = (short)1736344660;
				switch (num2 == num)
				{
				}
				num = (short)661585920;
				if (num != 0)
				{
				}
				num = (short)1328480256;
				short num3 = num;
				num = (short)1147731969;
				if (num != 0)
				{
				}
				return this.c;
			}
			[CompilerGenerated]
			private set
			{
				short num = (short)2076067695;
				short num2 = num;
				num = (short)823084911;
				switch (num2 == num)
				{
				}
				num = (short)407896064;
				if (num != 0)
				{
				}
				num = (short)1027211264;
				short num3 = num;
				num = (short)627048449;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x0014D7B0 File Offset: 0x0014B9B0
		private void a(object A_0, FileOperationReturnEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			bool? dialogResult;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_113;
				case 1:
					goto IL_78;
				case 2:
				{
					base.DialogResult = new bool?(A_1.Result == SpecialFeatures.FileOperations.DialogResult.Finished);
					num2 = (short)596400415;
					short num3 = num2;
					num2 = (short)327440671;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_78;
					default:
						num2 = (short)1070596096;
						if (num2 != 0)
						{
						}
						num2 = (short)732430336;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_1C;
				IL_78:
				if (dialogResult != null)
				{
					return;
				}
				num2 = (short)1691418626;
				num = (int)((IntPtr)num2);
			}
			IL_113:
			num2 = (short)132317185;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			this.b = true;
			this.FileOperationData = (A_1.Data as FileOperationData);
			dialogResult = base.DialogResult;
			num2 = (short)66584576;
			short num4 = num2;
			num2 = (short)752877569;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x0014D8FC File Offset: 0x0014BAFC
		private void NavigationWindow_Closing(object A_0, CancelEventArgs A_1)
		{
			short num = (short)1820262402;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!this.b)
					{
						num = (short)402718721;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 1:
					A_1.Cancel = true;
					num = (short)9240580;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				case 3:
				{
					num = (short)1645724207;
					short num3 = num;
					num = (short)207536687;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)415760384;
						if (num != 0)
						{
						}
						num = (short)1850081280;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					return;
				}
				IL_3A:
				num = (short)1966342145;
				if (num != 0)
				{
				}
				num = (short)340262912;
				short num4 = num;
				if (!(this.FileOperationData.CurrentPage.GetType() == this.a))
				{
					break;
				}
				num = (short)787218435;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x0014DA78 File Offset: 0x0014BC78
		private void Window_MouseLeftButtonDown(object A_0, MouseButtonEventArgs A_1)
		{
			for (;;)
			{
				IL_00:
				short num = (short)905576449;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					num = (short)456065024;
					short num3 = num;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						num = (short)1113980929;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_83;
						}
						continue;
					case 2:
					{
						num = (short)919354137;
						short num4 = num;
						num = (short)863320857;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)174260224;
							if (num != 0)
							{
							}
							base.OnMouseLeftButtonDown(A_1);
							base.DragMove();
							num = (short)1201471488;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_83:
					if (A_1.ChangedButton != MouseButton.Left)
					{
						return;
					}
					num = (short)56098818;
					num2 = (int)((IntPtr)num);
				}
			}
		}

		// Token: 0x040007CE RID: 1998
		private readonly Type a;

		// Token: 0x040007CF RID: 1999
		private bool b;

		// Token: 0x040007D0 RID: 2000
		[CompilerGenerated]
		private FileOperationData c;
	}
}
