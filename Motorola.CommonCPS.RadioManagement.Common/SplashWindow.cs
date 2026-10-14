using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Shapes;
using Motorola.Common.Communication.CommonUtil;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x02000028 RID: 40
	public class SplashWindow : global::System.Windows.Window, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000102 RID: 258 RVA: 0x0001324C File Offset: 0x0001144C
		// (set) Token: 0x06000103 RID: 259 RVA: 0x000132FC File Offset: 0x000114FC
		public global::Motorola.CommonCPS.RadioManagement.UIModels.LoadingInfo LoadingInfo
		{
			get
			{
				short num = (short)571976247;
				short num2 = num;
				num = (short)1558882871;
				switch (num2 == num)
				{
				}
				num = (short)837091329;
				if (num != 0)
				{
				}
				num = (short)392495104;
				short num3 = num;
				num = (short)277348352;
				if (num != 0)
				{
				}
				return this._loadingInfo;
			}
			set
			{
				short num = (short)161939456;
				short num2 = num;
				num = (short)2135785652;
				short num3 = num;
				num = (short)932085940;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_8B:
					switch (0)
					{
					case 0:
						goto IL_AF;
					}
					break;
				default:
					num = (short)1935147008;
					if (num != 0)
					{
					}
					num = (short)1733689346;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					IL_95:
					switch (num4)
					{
					case 0:
						if (value != this._loadingInfo)
						{
							num = (short)875364353;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						this._loadingInfo = value;
						num = (short)516554756;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_8B;
					case 3:
						num = (short)2112421889;
						if (num != 0)
						{
						}
						num = (short)59703296;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_10F;
					}
					goto IL_AF;
				}
				IL_10F:
				return;
				IL_AF:
				if (value != null)
				{
					num = (short)2127233027;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_95;
				}
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00013458 File Offset: 0x00011658
		public SplashWindow(string version)
		{
			this.InitializeComponent();
			this._loadingInfo = new global::Motorola.CommonCPS.RadioManagement.UIModels.LoadingInfo(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Loading_StartAppliction, version);
			this.b();
			this.splashCanvas.DataContext = this._loadingInfo;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0001349C File Offset: 0x0001169C
		private void b()
		{
			short num = (short)497221632;
			short num2 = num;
			num = (short)1506026601;
			short num3 = num;
			num = (short)275719273;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_8B:
				switch (0)
				{
				case 0:
					goto IL_AF;
				}
				break;
			default:
				num = (short)2050686976;
				if (num != 0)
				{
				}
				num = (short)1416626178;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				IL_95:
				switch (num4)
				{
				case 0:
					if (global::Motorola.CommonCPS.Server.EntityModel.VersionInfoHelper.IsDFlagExisted(global::Motorola.Common.Communication.CommonUtil.DFlagType.DPCR))
					{
						num = (short)1756102657;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_147;
				case 2:
					goto IL_8B;
				case 3:
					num = (short)646578176;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_E8;
				}
				goto IL_AF;
			}
			IL_E8:
			num = (short)235864065;
			if (num != 0)
			{
			}
			return;
			IL_147:
			goto IL_CD;
			IL_AF:
			if (!global::Motorola.CommonCPS.Server.EntityModel.VersionInfoHelper.IsDFlagExisted(global::Motorola.Common.Communication.CommonUtil.DFlagType.DASTRO))
			{
				num = (short)175767555;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_95;
			}
			IL_CD:
			this.a();
			num = (short)982188036;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_95;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000135F4 File Offset: 0x000117F4
		private void a()
		{
			short num = (short)1128455308;
			short num2 = num;
			num = (short)1269750924;
			switch (num2 == num)
			{
			}
			num = (short)177405953;
			if (num != 0)
			{
			}
			num = (short)888471552;
			short num3 = num;
			num = (short)652017664;
			if (num != 0)
			{
			}
			this.cps2SplashImage.Visibility = global::System.Windows.Visibility.Hidden;
			this.imgSplashImage.Visibility = global::System.Windows.Visibility.Hidden;
			this.imgSplashImage_Vertex.Visibility = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000136C4 File Offset: 0x000118C4
		protected override void OnSourceInitialized(global::System.EventArgs e)
		{
			short num = (short)472711169;
			if (num != 0)
			{
			}
			num = (short)2121345337;
			short num2 = num;
			num = (short)334047545;
			switch (num2 == num)
			{
			}
			num = (short)835584000;
			short num3 = num;
			num = (short)163512320;
			if (num != 0)
			{
			}
			base.OnSourceInitialized(e);
			global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(this);
			windowInteropHelper.EnsureHandle();
			this.Hwnd = windowInteropHelper.Handle;
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000108 RID: 264 RVA: 0x0001378C File Offset: 0x0001198C
		// (set) Token: 0x06000109 RID: 265 RVA: 0x0001383C File Offset: 0x00011A3C
		public global::System.IntPtr Hwnd
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)978595783;
				short num2 = num;
				num = (short)1295069127;
				switch (num2 == num)
				{
				}
				num = (short)1138294785;
				if (num != 0)
				{
				}
				num = (short)412942336;
				short num3 = num;
				num = (short)1292369920;
				if (num != 0)
				{
				}
				return this.<Hwnd>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1370606275;
				short num2 = num;
				num = (short)1857931971;
				switch (num2 == num)
				{
				}
				num = (short)811663361;
				if (num != 0)
				{
				}
				num = (short)1720647680;
				short num3 = num;
				num = (short)1163198464;
				if (num != 0)
				{
				}
				this.<Hwnd>k__BackingField = value;
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000138EC File Offset: 0x00011AEC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 18;
			while (!this._contentLoaded)
			{
				short num = (short)974563762;
				short num2 = num;
				num = (short)899656114;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)724828160;
					if (num != 0)
					{
					}
					num = (short)165216256;
					short num3 = num;
					num = (short)236060673;
					if (num != 0)
					{
					}
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("쯣ꯥ蟧黩菫鳭鿯黱闳\ud8f5믷闹釻鏽濿氁䜃嘅嬇␉帋漍琏笑笓嬕礗琙紛礝䔟伡䄣䠥尧Щ漫䄭崯弱嬳堵̷夹医匽〿ⵁ⩃⍅♇㹉捋㵍⁏㹑㕓╕しⱙ㕛㭝᝟䵡ᝣᙥѧ୩Ὣ٭ݯ᭱ᩳት᝷൹剻ٽ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000139CC File Offset: 0x00011BCC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1376318381;
			short num2 = num;
			num = (short)737932205;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_8A:
				switch (0)
				{
				case 0:
					goto IL_A6;
				}
				break;
			default:
			{
				num = (short)1241120768;
				short num3 = num;
				num = (short)1891237888;
				if (num != 0)
				{
				}
				num = (short)1659895809;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			}
			for (;;)
			{
				IL_94:
				switch (num4)
				{
				case 0:
					goto IL_1C5;
				case 1:
					goto IL_8A;
				case 2:
					num = (short)624295936;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_A6;
			}
			IL_1C5:
			this._contentLoaded = true;
			return;
			IL_A6:
			switch (connectionId)
			{
			case 1:
				this.splashCanvas = (global::System.Windows.Controls.Canvas)target;
				return;
			case 2:
				num = (short)387842049;
				if (num != 0)
				{
				}
				this.imgSplashImage = (global::System.Windows.Controls.Image)target;
				return;
			case 3:
				this.cps2SplashImage = (global::System.Windows.Controls.Image)target;
				return;
			case 4:
				this.radiocentralPSImage = (global::System.Windows.Controls.Image)target;
				return;
			case 5:
				this.rectRadioCentralBorder = (global::System.Windows.Shapes.Rectangle)target;
				return;
			case 6:
				this.imgSplashImage_Vertex = (global::System.Windows.Controls.Image)target;
				return;
			case 7:
				this.progressIndicator = (global::Motorola.CommonCPS.RadioManagement.Controls.ProgressIndicator)target;
				return;
			case 8:
				this.lblProductName = (global::System.Windows.Controls.Label)target;
				return;
			case 9:
				this.pbStatus = (global::System.Windows.Controls.ProgressBar)target;
				return;
			case 10:
				this.lblStatus = (global::System.Windows.Controls.Label)target;
				return;
			case 11:
				this.lblVersion = (global::System.Windows.Controls.Label)target;
				return;
			case 12:
				this.lblInfo = (global::System.Windows.Controls.Label)target;
				return;
			default:
				num = (short)796327938;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_94;
			}
		}

		// Token: 0x040000C5 RID: 197
		private global::Motorola.CommonCPS.RadioManagement.UIModels.LoadingInfo _loadingInfo;

		// Token: 0x040000C7 RID: 199
		internal global::System.Windows.Controls.Canvas splashCanvas;

		// Token: 0x040000C8 RID: 200
		internal global::System.Windows.Controls.Image imgSplashImage;

		// Token: 0x040000C9 RID: 201
		internal global::System.Windows.Controls.Image cps2SplashImage;

		// Token: 0x040000CA RID: 202
		internal global::System.Windows.Controls.Image radiocentralPSImage;

		// Token: 0x040000CB RID: 203
		internal global::System.Windows.Shapes.Rectangle rectRadioCentralBorder;

		// Token: 0x040000CC RID: 204
		internal global::System.Windows.Controls.Image imgSplashImage_Vertex;

		// Token: 0x040000CD RID: 205
		internal global::Motorola.CommonCPS.RadioManagement.Controls.ProgressIndicator progressIndicator;

		// Token: 0x040000CE RID: 206
		internal global::System.Windows.Controls.Label lblProductName;

		// Token: 0x040000CF RID: 207
		internal global::System.Windows.Controls.ProgressBar pbStatus;

		// Token: 0x040000D0 RID: 208
		internal global::System.Windows.Controls.Label lblStatus;

		// Token: 0x040000D1 RID: 209
		internal global::System.Windows.Controls.Label lblVersion;

		// Token: 0x040000D2 RID: 210
		internal global::System.Windows.Controls.Label lblInfo;

		// Token: 0x040000D3 RID: 211
		private bool _contentLoaded;
	}
}
