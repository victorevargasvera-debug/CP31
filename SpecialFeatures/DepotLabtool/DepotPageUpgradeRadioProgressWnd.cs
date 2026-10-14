using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using AcpUI.Common;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Flashport.FlashRadio;

namespace SpecialFeatures.DepotLabtool
{
	// Token: 0x0200013D RID: 317
	public class DepotPageUpgradeRadioProgressWnd : global::System.Windows.Window, global::System.IDisposable, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600106E RID: 4206 RVA: 0x0016F3D0 File Offset: 0x0016D5D0
		public DepotPageUpgradeRadioProgressWnd(global::SpecialFeatures.DepotLabtool.UpgradeRadioData upgradeRadioData)
		{
			global::AcpUI.Common.Utility.SetDirection(this);
			this.c = upgradeRadioData;
			if (this.c == null)
			{
				this.c = new global::SpecialFeatures.DepotLabtool.UpgradeRadioData();
				this.c.UpgradeFile = "";
				this.c.NewFlashCode = "";
			}
			this.a = this.c.UpgradeFile;
			this.b = this.c.NewFlashCode;
			if (this.d == null)
			{
				this.d = new global::System.ComponentModel.BackgroundWorker();
			}
			this.d.WorkerReportsProgress = true;
			this.InitializeComponent();
			this.a();
			this.ProgText.Text = global::CommonResources.AppResources.Upgrading_Radio_Please_be_patient;
			this.CloseBtn.IsEnabled = false;
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x0016F494 File Offset: 0x0016D694
		private void a()
		{
			short num = (short)160000809;
			short num2 = num;
			num = (short)252144425;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1968832512;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)817627137;
			if (num != 0)
			{
			}
			num = (short)918814720;
			if (num != 0)
			{
			}
			this.d.DoWork += this.backgroundWorker1_DoWork;
			this.d.RunWorkerCompleted += this.backgroundWorker1_RunWorkerCompleted;
			this.d.ProgressChanged += this.backgroundWorker1_ProgressChanged;
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x0016F580 File Offset: 0x0016D780
		private void backgroundWorker1_DoWork(object A_0, global::System.ComponentModel.DoWorkEventArgs A_1)
		{
			short num = (short)350224385;
			if (num != 0)
			{
			}
			num = (short)602341376;
			short num2 = num;
			num = (short)1603022150;
			short num3 = num;
			num = (short)599534918;
			switch (num3 == num)
			{
			}
			num = (short)319160320;
			if (num != 0)
			{
			}
			global::System.ComponentModel.BackgroundWorker a_ = A_0 as global::System.ComponentModel.BackgroundWorker;
			A_1.Result = this.FlashRadio((global::SpecialFeatures.DepotLabtool.UpgradeRadioData)A_1.Argument, a_, A_1);
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x0016F64C File Offset: 0x0016D84C
		private void backgroundWorker1_RunWorkerCompleted(object A_0, global::System.ComponentModel.RunWorkerCompletedEventArgs A_1)
		{
			short num = (short)307625988;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)91422720;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_AF;
				case 1:
					this.ProgText.Text = global::CommonResources.AppResources.Upgrade_Radio_completed_successfully;
					num = (short)554172416;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_18E;
				case 3:
					num = (short)1852702721;
					if (num != 0)
					{
					}
					global::System.Windows.MessageBox.Show(A_1.Error.Message);
					num = (short)1540161538;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				case 5:
					if (!A_1.Cancelled)
					{
						num = (short)2102001665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_190;
				}
				IL_65:
				if (A_1.Error != null)
				{
					num = (short)595066883;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1737124828;
					short num4 = num;
					num = (short)1747217372;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_18E;
					default:
						num = (short)2077818880;
						if (num != 0)
						{
						}
						num = (short)676528133;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_AF:
			IL_18E:
			IL_190:
			this.CloseBtn.IsEnabled = true;
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x0016F7F8 File Offset: 0x0016D9F8
		private void backgroundWorker1_ProgressChanged(object A_0, global::System.ComponentModel.ProgressChangedEventArgs A_1)
		{
			short num = (short)219375555;
			short num2 = num;
			num = (short)1329948611;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1850867712;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)93585409;
			if (num != 0)
			{
			}
			num = (short)1170210816;
			if (num != 0)
			{
			}
			this.progressBar2.Value = (double)A_1.ProgressPercentage;
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x0016F8B8 File Offset: 0x0016DAB8
		private long FlashRadio(global::SpecialFeatures.DepotLabtool.UpgradeRadioData A_0, global::System.ComponentModel.BackgroundWorker A_1, global::System.ComponentModel.DoWorkEventArgs A_2)
		{
			int a_ = 4;
			short num = (short)440240830;
			short num2 = num;
			num = (short)1548192446;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D7:
				if (global::System.IO.File.Exists(this.a))
				{
					long result = 0L;
					new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadio(A_1, false).DepotFlashRadio(A_0.UpgradeFile, A_0.NewFlashCode);
					return result;
				}
				num = (short)963313665;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1636368384;
				if (num != 0)
				{
				}
				num = (short)538247170;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					num = (short)1095565315;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_FC;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_8A;
					}
					continue;
				case 3:
					goto IL_D7;
				}
				IL_8A:
				if (string.IsNullOrEmpty(this.a))
				{
					break;
				}
				num = (short)1998192640;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_AD:
			throw new global::System.ArgumentException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캆ﶊ떔ﲚﺞ얠욢薤솦삨잪좬", a_));
			IL_FC:
			num = (short)1503526913;
			if (num != 0)
			{
			}
			num = (short)577699840;
			short num4 = num;
			goto IL_AD;
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x0016FA34 File Offset: 0x0016DC34
		private void Page_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)700489084;
			short num2 = num;
			num = (short)2131598716;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_BE:
				num = (short)459997186;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5E;
			default:
			{
				num = (short)241762304;
				short num4 = num;
				goto IL_5E;
			}
			}
			for (;;)
			{
				IL_7F:
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_B1;
				case 2:
					this.d.RunWorkerAsync(this.c);
					num = (short)1865416705;
					if (num != 0)
					{
					}
					num = (short)661585920;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_91;
			}
			IL_B1:
			if (!this.d.IsBusy)
			{
				goto IL_BE;
			}
			return;
			IL_5E:
			num = (short)988479488;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_91;
			}
			goto IL_7F;
			IL_91:
			this.CloseBtn.IsEnabled = false;
			num = (short)119799809;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7F;
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x0016FB68 File Offset: 0x0016DD68
		private void ObButtonClick_Close(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)881887330;
			short num2 = num;
			num = (short)764446818;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1942618112;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1872625665;
			if (num != 0)
			{
			}
			num = (short)1792278528;
			if (num != 0)
			{
			}
			base.Close();
			base.Owner.Close();
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x0016FC24 File Offset: 0x0016DE24
		public void Dispose()
		{
			short num = (short)1230574207;
			short num2 = num;
			num = (short)938742399;
			switch (num2 == num)
			{
			default:
			{
				num = (short)726007808;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1070661633;
			if (num != 0)
			{
			}
			num = (short)120455168;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x0016FCDC File Offset: 0x0016DEDC
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)863503884;
			short num2 = num;
			num = (short)2080704012;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_60:
				num = (short)1693188097;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_AB;
				}
				break;
			default:
				num = (short)1566048256;
				if (num != 0)
				{
				}
				num = (short)1912930307;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				IL_91:
				switch (num3)
				{
				case 0:
					num = (short)200867844;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_EE;
				case 2:
					this.d.Dispose();
					this.d = null;
					num = (short)1596784641;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_60;
				case 4:
				{
					num = (short)760938496;
					short num4 = num;
					if (this.d != null)
					{
						num = (short)1369571330;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				}
				goto IL_AB;
			}
			IL_EE:
			return;
			IL_AB:
			if (disposing)
			{
				num = (short)864092160;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_91;
			}
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x0016FE3C File Offset: 0x0016E03C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 16;
			short num = (short)430374913;
			if (num != 0)
			{
			}
			if (this.e)
			{
				num = (short)1520573661;
				short num2 = num;
				num = (short)1180966109;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1784610816;
					short num3 = num;
					num = (short)2055077888;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this.e = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("벒요ﲘﺞ춠삤욦\udda8\udeaa\udfac쪮슰袲횴\ud8b6풸쮺튼톾꓀귂뇄귈껊뷌ꃎꗐ뿒듔뗖귘듚닜돞컠蟢胤韦蛨鿪飬鿮雰臲铴鏶鳸觺鳼鯾栀氂甄甆昈氊缌樎成怒戔礖紘㔚攜縞䰠伢", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x0016FF1C File Offset: 0x0016E11C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num;
			for (;;)
			{
				num = (short)1774977025;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_12B;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
					{
						num = (short)1867907072;
						short num3 = num;
						num = (short)2026504192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_31:
					switch (connectionId)
					{
					case 1:
						goto IL_86;
					case 2:
						goto IL_147;
					case 3:
						goto IL_13A;
					case 4:
						goto IL_79;
					case 5:
						goto IL_6C;
					case 6:
						goto IL_12D;
					case 7:
						goto IL_C4;
					default:
						num = (short)1780875266;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_147:
				num = (short)1240002137;
				short num4 = num;
				num = (short)326495833;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_17D;
				}
			}
			IL_6C:
			this.progressBar2 = (global::System.Windows.Controls.ProgressBar)target;
			return;
			IL_79:
			this.ConnectingToRadioLabel = (global::System.Windows.Controls.Label)target;
			return;
			IL_86:
			num = (short)496697345;
			if (num != 0)
			{
			}
			((global::SpecialFeatures.DepotLabtool.DepotPageUpgradeRadioProgressWnd)target).Loaded += this.Page_Loaded;
			return;
			IL_C4:
			this.CloseBtn = (global::System.Windows.Controls.Button)target;
			this.CloseBtn.Click += this.ObButtonClick_Close;
			return;
			IL_12B:
			this.e = true;
			return;
			IL_12D:
			this.ProgText = (global::System.Windows.Controls.TextBox)target;
			return;
			IL_13A:
			this.stackMoreInfo = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_17D:
			num = (short)1577844736;
			if (num != 0)
			{
			}
			this.GrpbxProgress = (global::System.Windows.Controls.GroupBox)target;
		}

		// Token: 0x04000883 RID: 2179
		private string a;

		// Token: 0x04000884 RID: 2180
		private string b;

		// Token: 0x04000885 RID: 2181
		private global::SpecialFeatures.DepotLabtool.UpgradeRadioData c;

		// Token: 0x04000886 RID: 2182
		private global::System.ComponentModel.BackgroundWorker d;

		// Token: 0x04000887 RID: 2183
		internal global::System.Windows.Controls.GroupBox GrpbxProgress;

		// Token: 0x04000888 RID: 2184
		internal global::System.Windows.Controls.StackPanel stackMoreInfo;

		// Token: 0x04000889 RID: 2185
		internal global::System.Windows.Controls.Label ConnectingToRadioLabel;

		// Token: 0x0400088A RID: 2186
		internal global::System.Windows.Controls.ProgressBar progressBar2;

		// Token: 0x0400088B RID: 2187
		internal global::System.Windows.Controls.TextBox ProgText;

		// Token: 0x0400088C RID: 2188
		internal global::System.Windows.Controls.Button CloseBtn;

		// Token: 0x0400088D RID: 2189
		private bool e;
	}
}
