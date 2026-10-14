using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000D1 RID: 209
	internal class ImportTemplateCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600043F RID: 1087 RVA: 0x00048A2C File Offset: 0x00046C2C
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)319225856;
			switch (num)
			{
			default:
			{
				num = (short)1853554698;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword> filePasswords;
				global::System.Collections.Generic.IList<string> list;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)835190785;
						if (num != 0)
						{
						}
						num = (short)1828978689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (paras.Count<object>() <= 0)
						{
							num = (short)1625096195;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.ImportTemplatesContext importTemplatesContext = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ImportTemplatesContext;
						filePasswords = importTemplatesContext.FilePasswords;
						num = (short)643104772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ImportTemplatesContext importTemplatesContext;
						if (importTemplatesContext.FileNames != null)
						{
							num = (short)246939656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A7;
					}
					case 3:
						goto IL_315;
					case 4:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ImportTemplatesContext importTemplatesContext;
						if (!string.IsNullOrEmpty(importTemplatesContext.Password))
						{
							num = (short)816381957;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_90;
					}
					case 5:
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword> enumerator = filePasswords.GetEnumerator();
						num = (short)1614151686;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						try
						{
							num = (short)915603460;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1C9;
								case 1:
								{
									num = (short)891543625;
									short num3 = num;
									num = (short)465363017;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)885850112;
										if (num != 0)
										{
										}
										num = (short)1048313856;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)730857473;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.ImportTemplatesContext importTemplatesContext;
									enumerator.Current.Password = importTemplatesContext.Password;
									num = (short)1564147714;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_107;
									}
									continue;
								}
								IL_109:
								num = (short)1159725059;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_107:
								goto IL_109;
							}
							IL_1C9:
							goto IL_90;
						}
						finally
						{
							num = (short)806158338;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1006370817;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_237;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_201;
									}
									continue;
								}
								IL_201:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1321074688;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_237:;
						}
						goto IL_23A;
					case 7:
						goto IL_2B1;
					case 8:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ImportTemplatesContext importTemplatesContext;
						list = importTemplatesContext.FileNames.ToList<string>();
						num = (short)1680015360;
						short num4 = num;
						num = (short)1489633289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (list.Count<string>() > 0)
						{
							num = (short)486408199;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A7;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_70;
						}
						continue;
					}
					IL_70:
					if (paras != null)
					{
						num = (short)1721434112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_90:
					num = (short)1768882178;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_23A:
				throw new global::System.ArgumentNullException();
				IL_2B1:
				global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportTemplateBatchOp importTemplateBatchOp = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportTemplateBatchOp(list, filePasswords);
				base.ExecuteBatchOp<string>(importTemplateBatchOp);
				return importTemplateBatchOp;
				IL_315:
				goto IL_23A;
				IL_3A7:
				return null;
			}
			}
		}
	}
}
