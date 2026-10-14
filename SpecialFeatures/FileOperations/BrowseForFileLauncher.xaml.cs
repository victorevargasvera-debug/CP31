using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Navigation;
using AcpUI.Common;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.FileOperations
{
	// Token: 0x02000110 RID: 272
	public partial class BrowseForFileLauncher : PageFunction<DialogResult>
	{
		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000EF6 RID: 3830 RVA: 0x0014DDF0 File Offset: 0x0014BFF0
		// (remove) Token: 0x06000EF7 RID: 3831 RVA: 0x0014DF28 File Offset: 0x0014C128
		public event FileOperationReturnEventHandler FileOperationReturn
		{
			[CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				FileOperationReturnEventHandler fileOperationReturnEventHandler;
				FileOperationReturnEventHandler fileOperationReturnEventHandler2;
				short num2;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						return;
					case 1:
						if (fileOperationReturnEventHandler == fileOperationReturnEventHandler2)
						{
							num2 = (short)1997537280;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_AE;
					case 2:
						goto IL_AC;
					}
					goto IL_1C;
				}
				IL_AC:
				IL_AE:
				num2 = (short)997195776;
				short num3 = num2;
				fileOperationReturnEventHandler2 = fileOperationReturnEventHandler;
				FileOperationReturnEventHandler value2 = (FileOperationReturnEventHandler)Delegate.Combine(fileOperationReturnEventHandler2, value);
				fileOperationReturnEventHandler = Interlocked.CompareExchange<FileOperationReturnEventHandler>(ref this.a, value2, fileOperationReturnEventHandler2);
				goto IL_F4;
				IL_1C:
				num2 = (short)1182362862;
				short num4 = num2;
				num2 = (short)2000776430;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_F4:
					num2 = (short)1580138497;
					int num = (int)((IntPtr)num2);
					goto IL_0A;
				}
				default:
				{
					num2 = (short)1105854464;
					if (num2 != 0)
					{
					}
					num2 = (short)1376321537;
					if (num2 != 0)
					{
					}
					fileOperationReturnEventHandler = this.a;
					num2 = (short)2069495810;
					int num = (int)((IntPtr)num2);
					goto IL_0A;
				}
				}
			}
			[CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				short num;
				FileOperationReturnEventHandler fileOperationReturnEventHandler;
				FileOperationReturnEventHandler fileOperationReturnEventHandler2;
				for (;;)
				{
					IL_0A:
					num = (short)105381889;
					if (num != 0)
					{
					}
					int num2;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						if (fileOperationReturnEventHandler == fileOperationReturnEventHandler2)
						{
							num = (short)900530176;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_B0;
					case 2:
						goto IL_AE;
					}
					goto IL_43;
				}
				IL_AE:
				IL_B0:
				num = (short)1651703808;
				short num3 = num;
				fileOperationReturnEventHandler2 = fileOperationReturnEventHandler;
				FileOperationReturnEventHandler value2 = (FileOperationReturnEventHandler)Delegate.Remove(fileOperationReturnEventHandler2, value);
				fileOperationReturnEventHandler = Interlocked.CompareExchange<FileOperationReturnEventHandler>(ref this.a, value2, fileOperationReturnEventHandler2);
				goto IL_F6;
				IL_43:
				num = (short)736983198;
				short num4 = num;
				num = (short)1136883870;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_F6:
					num = (short)1168572417;
					int num2 = (int)((IntPtr)num);
					goto IL_0A;
				}
				default:
				{
					num = (short)974913536;
					if (num != 0)
					{
					}
					fileOperationReturnEventHandler = this.a;
					num = (short)255262722;
					int num2 = (int)((IntPtr)num);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00003370 File Offset: 0x00001570
		public BrowseForFileLauncher(Action<BrowseForFilePage> action, FileOperationData fileOperationData)
		{
			this.b = action;
			this.FileOperationData = fileOperationData;
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x0014E060 File Offset: 0x0014C260
		public Action<BrowseForFilePage> Action
		{
			[CompilerGenerated]
			get
			{
				short num = (short)216793088;
				short num2 = num;
				num = (short)1989655418;
				short num3 = num;
				num = (short)163560314;
				switch (num3 == num)
				{
				}
				num = (short)1866334209;
				if (num != 0)
				{
				}
				num = (short)1433534464;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x0014E110 File Offset: 0x0014C310
		// (set) Token: 0x06000EFB RID: 3835 RVA: 0x0014E1C0 File Offset: 0x0014C3C0
		internal FileOperationData FileOperationData
		{
			[CompilerGenerated]
			get
			{
				short num = (short)285474816;
				short num2 = num;
				num = (short)883097601;
				if (num != 0)
				{
				}
				num = (short)1838246378;
				short num3 = num;
				num = (short)2083351018;
				switch (num3 == num)
				{
				}
				num = (short)2083389440;
				if (num != 0)
				{
				}
				return this.c;
			}
			[CompilerGenerated]
			set
			{
				short num = (short)721485824;
				short num2 = num;
				num = (short)560938318;
				short num3 = num;
				num = (short)2053586254;
				switch (num3 == num)
				{
				}
				num = (short)1227161601;
				if (num != 0)
				{
				}
				num = (short)39583744;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0014E270 File Offset: 0x0014C470
		protected override void Start()
		{
			short num = (short)1133641728;
			short num2 = num;
			num = (short)1391222127;
			short num3 = num;
			num = (short)1433689455;
			switch (num3 == num)
			{
			}
			num = (short)651427841;
			if (num != 0)
			{
			}
			num = (short)445054976;
			if (num != 0)
			{
			}
			Utility.SetDirection(this);
			base.Start();
			base.KeepAlive = true;
			BrowseForFilePage browseForFilePage = new BrowseForFilePage(this.FileOperationData, this.Action);
			browseForFilePage.Return += this.OnBrowseForFileReturn;
			base.NavigationService.Navigate(browseForFilePage);
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x0014E360 File Offset: 0x0014C560
		internal void OnBrowseForFileReturn(object sender, ReturnEventArgs<DialogResult> e)
		{
			short num = (short)1402339329;
			if (num != 0)
			{
			}
			num = (short)52822018;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				num = (short)991625216;
				short num3 = num;
				num = (short)868013777;
				short num4 = num;
				num = (short)190699217;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_120;
				default:
					num = (short)220266496;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_120;
					case 1:
						this.a(this, new FileOperationReturnEventArgs(e.Result, this.FileOperationData));
						num = (short)1569914880;
						num2 = (int)((IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_CA;
						}
						continue;
					}
					IL_CA:
					if (this.a == null)
					{
						goto IL_122;
					}
					num = (short)711655425;
					num2 = (int)((IntPtr)num);
					break;
				}
			}
			IL_120:
			IL_122:
			this.OnReturn(null);
		}

		// Token: 0x040007D4 RID: 2004
		[CompilerGenerated]
		private FileOperationReturnEventHandler a;

		// Token: 0x040007D5 RID: 2005
		[CompilerGenerated]
		private readonly Action<BrowseForFilePage> b;

		// Token: 0x040007D6 RID: 2006
		[CompilerGenerated]
		private FileOperationData c;
	}
}
