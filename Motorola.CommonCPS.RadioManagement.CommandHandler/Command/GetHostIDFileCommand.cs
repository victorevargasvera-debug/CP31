using System;
using System.IO;
using System.Windows.Forms;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200007D RID: 125
	internal class GetHostIDFileCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000339 RID: 825 RVA: 0x0003237C File Offset: 0x0003057C
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 8;
			short num;
			try
			{
				num = (short)730595328;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					string value = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.AppLicenseService.GenerateHostID();
					global::System.Windows.Forms.SaveFileDialog saveFileDialog = new global::System.Windows.Forms.SaveFileDialog();
					try
					{
						switch (0)
						{
						case 0:
							goto IL_74;
						}
						for (;;)
						{
							IL_49:
							switch (num2)
							{
							case 0:
								goto IL_14F;
							case 1:
								goto IL_214;
							case 2:
							{
								string fileName;
								if (!string.IsNullOrEmpty(fileName))
								{
									num = (short)1661272071;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_14F;
							}
							case 3:
							{
								string directoryName;
								global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Get_HostID_Folder = directoryName;
								global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
								num = (short)2088566784;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
							{
								string fileName = saveFileDialog.FileName;
								num = (short)1495531522;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								if (saveFileDialog.ShowDialog() == global::System.Windows.Forms.DialogResult.OK)
								{
									num = (short)1095368708;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1FC;
							case 6:
								goto IL_1FC;
							case 7:
							{
								string fileName;
								string directoryName = global::System.IO.Path.GetDirectoryName(fileName);
								num = (short)888733704;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
							{
								string directoryName;
								if (!string.IsNullOrEmpty(directoryName))
								{
									num = (short)1500512259;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_14F;
							}
							}
							goto IL_74;
							IL_14F:
							global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(saveFileDialog.OpenFile());
							streamWriter.WriteLine(value);
							streamWriter.Flush();
							streamWriter.Close();
							num = (short)127008774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1FC:
							num = (short)1492713473;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_214:
						break;
						IL_74:
						saveFileDialog.Filter = global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("그黺藼课℀䔂氄欆氈砊ⴌ猎ㄐ㤒㬔挖愘漚", a_);
						saveFileDialog.InitialDirectory = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.GetValidFolder(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Get_HostID_Folder);
						saveFileDialog.FilterIndex = 1;
						saveFileDialog.DefaultExt = global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("跸菺觼", a_);
						saveFileDialog.FileName = global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("뇸铺軼课䠀䜂⬄猆焈缊", a_);
						num = (short)980746245;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_49;
					}
					finally
					{
						num = (short)621084673;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								num = (short)42229836;
								short num3 = num;
								num = (short)1561419852;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_26C;
								default:
									goto IL_2B5;
								}
								break;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_24C;
								}
								continue;
							case 2:
								((global::System.IDisposable)saveFileDialog).Dispose();
								goto IL_26C;
							}
							IL_24C:
							if (saveFileDialog != null)
							{
								num = (short)122880002;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2CC;
							IL_26C:
							num = (short)1551958016;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2B5:
						num = (short)1336737792;
						if (num != 0)
						{
						}
						IL_2CC:;
					}
					break;
				}
				}
			}
			catch
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_License_GetHostID_Error);
			}
			num = (short)404553728;
			short num4 = num;
			num = (short)1561001985;
			if (num != 0)
			{
			}
			return null;
		}
	}
}
