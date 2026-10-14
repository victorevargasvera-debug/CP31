using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ACPBrowser;
using AcpFileHandlerLib;
using AcpUI.Common;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.FileOperations
{
	// Token: 0x02000111 RID: 273
	public partial class BrowseForFilePage : PageFunction<DialogResult>
	{
		// Token: 0x06000F00 RID: 3840 RVA: 0x0014E628 File Offset: 0x0014C828
		internal BrowseForFilePage(FileOperationData fileOperationData, Action<BrowseForFilePage> action)
		{
			int a_ = 12;
			base..ctor();
			if (fileOperationData == null)
			{
				throw new ArgumentNullException(RptMgrErrorHandler.b("ﾒ\ud896ﺚﺞ햠쪢쪤즦쪪\ud9ac캮", a_), RptMgrErrorHandler.b("\udf8eﲒﺖﶘﺚ列뾞잠쪢즤슦\udbaa좬\uddae킰잲\udcb4\ud8b6ힸﾺ\udcbc쮾ꃀꛄꛆꟈꗊꋌ믎뇒냔럘껚뇜돞쿠", a_));
			}
			if (action == null)
			{
				throw new ArgumentNullException(RptMgrErrorHandler.b("ﲔ", a_), RptMgrErrorHandler.b("\udf8eﲒﺖﶘﺚ列뾞삠삢톤캦욨얪趬첮킰\uddb2\udbb4\ud8b6춸鮺\udfbc\udabe귂냄ꯆꗈ", a_));
			}
			this.b = action;
			AcpUI.Common.Utility.SetDirection(this);
			this.FileOperationData = fileOperationData;
			this.FileOperationData.CurrentPage = this;
			this.InitializeComponent();
			this.ViewboxTitle.Content = this.FileOperationData.BrowseDialogTitleContent;
			this.TitleContent.Content = this.FileOperationData.HeadingTitleContent;
			this.ActionBtn.Content = this.FileOperationData.BrowseDialogActionButtonContent;
			this.TxtBoxFilePath.Text = this.FileOperationData.FilePath;
			if (Thread.CurrentThread.CurrentCulture.Name.ToLower().StartsWith(RptMgrErrorHandler.b("", a_)))
			{
				this.TxtBoxFilePath.FlowDirection = FlowDirection.LeftToRight;
				this.TxtBoxFilePath.TextAlignment = TextAlignment.Right;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x0014E760 File Offset: 0x0014C960
		// (set) Token: 0x06000F02 RID: 3842 RVA: 0x0014E810 File Offset: 0x0014CA10
		public FileOperationData FileOperationData
		{
			[CompilerGenerated]
			get
			{
				short num = (short)1483669504;
				short num2 = num;
				num = (short)1603375116;
				short num3 = num;
				num = (short)903974924;
				switch (num3 == num)
				{
				}
				num = (short)1296695297;
				if (num != 0)
				{
				}
				num = (short)718143488;
				if (num != 0)
				{
				}
				return this.a;
			}
			[CompilerGenerated]
			set
			{
				short num = (short)2005532672;
				short num2 = num;
				num = (short)842996511;
				short num3 = num;
				num = (short)1998527263;
				switch (num3 == num)
				{
				}
				num = (short)117702657;
				if (num != 0)
				{
				}
				num = (short)1994653696;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x0014E8C0 File Offset: 0x0014CAC0
		public Action<BrowseForFilePage> Action
		{
			[CompilerGenerated]
			get
			{
				short num = (short)1486422016;
				short num2 = num;
				num = (short)49983946;
				short num3 = num;
				num = (short)350204362;
				switch (num3 == num)
				{
				}
				num = (short)119668737;
				if (num != 0)
				{
				}
				num = (short)89194496;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x0014E970 File Offset: 0x0014CB70
		private void OnButtonClickBrowse(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1244332032;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				bool? flag;
				bool flag2;
				AcpOpenFileDialog acpOpenFileDialog;
				for (;;)
				{
					IL_27:
					string fileName;
					switch (num2)
					{
					case 0:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)776142852;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_11F;
					case 2:
					{
						num = (short)1890198414;
						short num3 = num;
						num = (short)1673077646;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_11F;
						default:
							num = (short)1817247744;
							if (num != 0)
							{
							}
							this.TxtBoxFilePath.Text = fileName;
							this.FileOperationData.FilePath = fileName;
							this.FileOperationData.InitialDirectory = System.IO.Path.GetDirectoryName(fileName);
							num = (short)2031091715;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						return;
					case 4:
						fileName = acpOpenFileDialog.FileName;
						num = (short)45088769;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_42;
					IL_11F:
					if (fileName == null)
					{
						break;
					}
					num = (short)1687289857;
					if (num != 0)
					{
					}
					num = (short)586809344;
					short num4 = num;
					num = (short)325910530;
					num2 = (int)((IntPtr)num);
				}
				return;
				IL_42:
				acpOpenFileDialog = new AcpOpenFileDialog();
				acpOpenFileDialog.Filter = this.FileOperationData.Filter;
				AcpFileDialog.InitialDirectory = this.FileOperationData.InitialDirectory;
				flag = acpOpenFileDialog.ShowDialog();
				flag2 = true;
				num = (short)620036096;
				num2 = (int)((IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x0014EB5C File Offset: 0x0014CD5C
		private void OnLoaded(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1985413122;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				num = (short)1609824280;
				short num3 = num;
				num = (short)1351940120;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				case 1:
					break;
				default:
				{
					num = (short)33095680;
					short num4 = num;
					break;
				}
				}
				num = (short)652017664;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					return;
				case 1:
					Keyboard.Focus(this);
					num = (short)828571648;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_A4;
					}
					continue;
				}
				IL_A4:
				num = (short)1029963777;
				if (num != 0)
				{
				}
				if (base.IsKeyboardFocusWithin)
				{
					break;
				}
				num = (short)1485111297;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x0014EC7C File Offset: 0x0014CE7C
		private void OnF1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)765984768;
			short num2 = num;
			num = (short)1891326811;
			short num3 = num;
			num = (short)1369987931;
			switch (num3 == num)
			{
			}
			num = (short)1696006145;
			if (num != 0)
			{
			}
			num = (short)296878080;
			if (num != 0)
			{
			}
			A_1.CanExecute = true;
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x0014ED30 File Offset: 0x0014CF30
		private void OnButtonClickF1Help(object A_0, RoutedEventArgs A_1)
		{
			short num;
			try
			{
				num = (short)407483060;
				short num2 = num;
				num = (short)1088991924;
				switch (num2 == num)
				{
				}
				num = (short)322895872;
				if (num != 0)
				{
				}
				ACPBrowser.Utility.CloseHelpWindowIfOpen();
				ACPBrowser.Utility.DisplayCPSHelpDITA(this.FileOperationData.BrowseDialogHelpTopicId);
			}
			catch (Exception)
			{
			}
			num = (short)108068865;
			if (num != 0)
			{
			}
			num = (short)2119172096;
			short num3 = num;
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x0014EE04 File Offset: 0x0014D004
		private void OnButtonClickCancel(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1301938176;
			short num2 = num;
			num = (short)98499904;
			short num3 = num;
			num = (short)1763704128;
			switch (num3 == num)
			{
			}
			num = (short)533069824;
			if (num != 0)
			{
			}
			num = (short)271450113;
			if (num != 0)
			{
			}
			this.OnReturn(new ReturnEventArgs<DialogResult>(DialogResult.Canceled));
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x0014EEBC File Offset: 0x0014D0BC
		private void OnButtonClickAction(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1344602112;
			short num2 = num;
			num = (short)274327738;
			short num3 = num;
			num = (short)1590159546;
			switch (num3 == num)
			{
			}
			num = (short)505085952;
			if (num != 0)
			{
			}
			num = (short)1504378881;
			if (num != 0)
			{
			}
			this.Action(this);
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x0014EF74 File Offset: 0x0014D174
		public void OnPageReturn(object sender, ReturnEventArgs<DialogResult> e)
		{
			short num = (short)1592131584;
			short num2 = num;
			num = (short)1265781588;
			short num3 = num;
			num = (short)221858644;
			switch (num3 == num)
			{
			}
			num = (short)716046337;
			if (num != 0)
			{
			}
			num = (short)101580800;
			if (num != 0)
			{
			}
			this.OnReturn(e);
		}

		// Token: 0x040007D8 RID: 2008
		[CompilerGenerated]
		private FileOperationData a;

		// Token: 0x040007D9 RID: 2009
		[CompilerGenerated]
		private readonly Action<BrowseForFilePage> b;
	}
}
