using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Interactivity.InteractionRequest;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Win32;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000BA RID: 186
	public class RMSaveFileDialog
	{
		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x0004DD78 File Offset: 0x0004BF78
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x0004DE28 File Offset: 0x0004C028
		public string FileName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)950868520;
				short num2 = num;
				num = (short)879893032;
				switch (num2 == num)
				{
				}
				num = (short)898957313;
				if (num != 0)
				{
				}
				num = (short)1451687936;
				if (num != 0)
				{
				}
				num = (short)534315008;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)347057948;
				short num2 = num;
				num = (short)1243721500;
				switch (num2 == num)
				{
				}
				num = (short)990314497;
				if (num != 0)
				{
				}
				num = (short)771620864;
				if (num != 0)
				{
				}
				num = (short)1494024192;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x0004DED8 File Offset: 0x0004C0D8
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x0004DF8C File Offset: 0x0004C18C
		public string Filter
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)635568129;
				if (num != 0)
				{
				}
				num = (short)149996522;
				short num2 = num;
				num = (short)1252705258;
				switch (num2 == num)
				{
				}
				num = (short)1030946816;
				if (num != 0)
				{
				}
				num = (short)1165099008;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1646635802;
				short num2 = num;
				num = (short)853191450;
				switch (num2 == num)
				{
				}
				num = (short)857735168;
				if (num != 0)
				{
				}
				num = (short)1302724609;
				if (num != 0)
				{
				}
				num = (short)1153302528;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x0004E03C File Offset: 0x0004C23C
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x0004E0EC File Offset: 0x0004C2EC
		public string Title
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)684537137;
				short num2 = num;
				num = (short)658650417;
				switch (num2 == num)
				{
				}
				num = (short)1150877696;
				if (num != 0)
				{
				}
				num = (short)214564865;
				if (num != 0)
				{
				}
				num = (short)1986330624;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)33811907;
				short num2 = num;
				num = (short)1017245123;
				switch (num2 == num)
				{
				}
				num = (short)702676993;
				if (num != 0)
				{
				}
				num = (short)1350238208;
				if (num != 0)
				{
				}
				num = (short)1656029184;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x0004E19C File Offset: 0x0004C39C
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x0004E24C File Offset: 0x0004C44C
		public int FilterIndex
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1699551316;
				short num2 = num;
				num = (short)416159828;
				switch (num2 == num)
				{
				}
				num = (short)717029376;
				if (num != 0)
				{
				}
				num = (short)1338048513;
				if (num != 0)
				{
				}
				num = (short)63307776;
				short num3 = num;
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)407464672;
				short num2 = num;
				num = (short)656304864;
				switch (num2 == num)
				{
				}
				num = (short)1104216065;
				if (num != 0)
				{
				}
				num = (short)1978859520;
				if (num != 0)
				{
				}
				num = (short)1687420928;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x0004E2FC File Offset: 0x0004C4FC
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x0004E3B0 File Offset: 0x0004C5B0
		public string InitialDirectory
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1380646913;
				if (num != 0)
				{
				}
				num = (short)794688849;
				short num2 = num;
				num = (short)801111377;
				switch (num2 == num)
				{
				}
				num = (short)1642921984;
				if (num != 0)
				{
				}
				num = (short)1582366720;
				short num3 = num;
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)583467009;
				if (num != 0)
				{
				}
				num = (short)1690751413;
				short num2 = num;
				num = (short)753193397;
				switch (num2 == num)
				{
				}
				num = (short)415039488;
				if (num != 0)
				{
				}
				num = (short)628490240;
				short num3 = num;
				this.e = value;
			}
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0004E460 File Offset: 0x0004C660
		public bool ShowDialog()
		{
			short num = (short)1959110778;
			short num2 = num;
			num = (short)530688122;
			switch (num2 == num)
			{
			}
			num = (short)1944649729;
			if (num != 0)
			{
			}
			num = (short)1386086400;
			if (num != 0)
			{
			}
			num = (short)2005073920;
			short num3 = num;
			global::Microsoft.Win32.SaveFileDialog saveFileDialog = new global::Microsoft.Win32.SaveFileDialog();
			saveFileDialog.FileName = this.FileName;
			saveFileDialog.Filter = this.Filter;
			saveFileDialog.Title = this.Title;
			saveFileDialog.FilterIndex = this.FilterIndex;
			saveFileDialog.AddExtension = true;
			saveFileDialog.InitialDirectory = this.InitialDirectory;
			saveFileDialog.OverwritePrompt = false;
			saveFileDialog.FileOk += this.a;
			return saveFileDialog.ShowDialog().Value;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0004E578 File Offset: 0x0004C778
		private void a(object A_0, global::System.ComponentModel.CancelEventArgs A_1)
		{
			short num = (short)272171008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4E;
				}
				global::Microsoft.Win32.SaveFileDialog saveFileDialog;
				string[] array;
				string extension;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						string str;
						this.FileName += str;
						saveFileDialog.FileName = this.FileName;
						num = (short)432668675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						if (saveFileDialog.FilterIndex >= array.Length)
						{
							goto IL_10B;
						}
						num = (short)2036900390;
						short num3 = num;
						num = (short)1356702246;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_234;
						default:
							num = (short)1407516672;
							if (num != 0)
							{
							}
							num = (short)144703494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						if (global::System.IO.File.Exists(this.FileName))
						{
							num = (short)1219362821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						goto IL_10B;
					case 4:
						return;
					case 5:
						goto IL_234;
					case 6:
					{
						num = (short)912130049;
						if (num != 0)
						{
						}
						num = (short)1878065152;
						short num4 = num;
						string str = array[saveFileDialog.FilterIndex * 2 - 1].Substring(1);
						num = (short)1984102407;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						string str;
						if (!string.Equals(extension, str, global::System.StringComparison.OrdinalIgnoreCase))
						{
							num = (short)1935015936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10B;
					}
					}
					goto IL_4E;
					IL_10B:
					num = (short)1464664066;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_234:
					global::Microsoft.Practices.Prism.Events.IEventAggregator instance = global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Events.IEventAggregator>();
					global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Confirmation confirmation = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Confirmation
					{
						Content = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_File_Already_Exists, this.FileName),
						Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Save_As_Confirm_Title
					};
					instance.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowConfirmationDialogRequestedEvent>().Publish(confirmation);
					A_1.Cancel = !confirmation.Confirmed;
					num = (short)1923809284;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_4E:
				saveFileDialog = (A_0 as global::Microsoft.Win32.SaveFileDialog);
				this.FileName = saveFileDialog.FileName;
				extension = global::System.IO.Path.GetExtension(this.FileName);
				array = saveFileDialog.Filter.Split(new char[]
				{
					'|'
				});
				num = (short)657391617;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x040001D8 RID: 472
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x040001D9 RID: 473
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;

		// Token: 0x040001DA RID: 474
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;

		// Token: 0x040001DB RID: 475
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int d;

		// Token: 0x040001DC RID: 476
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string e;
	}
}
