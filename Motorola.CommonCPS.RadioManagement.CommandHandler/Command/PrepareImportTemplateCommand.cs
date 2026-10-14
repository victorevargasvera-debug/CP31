using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000CC RID: 204
	public abstract class PrepareImportTemplateCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000432 RID: 1074 RVA: 0x000479C0 File Offset: 0x00045BC0
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)119996416;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				string[] array;
				for (;;)
				{
					IL_27:
					num = (short)193855488;
					short num3 = num;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ImportTemplatesContext importTemplatesContext;
						try
						{
							num = (short)437780484;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_18F;
								case 1:
									num = (short)1688862720;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<string> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2121334785;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string path = enumerator.Current;
									global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword filePassword = new global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword();
									filePassword.Password = null;
									filePassword.FileName = global::System.IO.Path.GetFileNameWithoutExtension(path);
									importTemplatesContext.FilePasswords.Add(filePassword);
									num = (short)678756354;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_ED;
									}
									continue;
								}
								IL_EF:
								num = (short)237502467;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_ED:
								goto IL_EF;
							}
							IL_18F:
							goto IL_2AE;
						}
						finally
						{
							num = (short)170459137;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<string> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_1FF;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1C6;
									}
									continue;
								case 2:
									IL_1DE:
									enumerator.Dispose();
									num = (short)950272000;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1C6:
								if (enumerator != null)
								{
									num = (short)488439810;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1FF:
								num = (short)1191699873;
								short num4 = num;
								num = (short)381085089;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1DE;
								default:
									goto IL_236;
								}
							}
							IL_236:
							num = (short)422051840;
							if (num != 0)
							{
							}
						}
						goto IL_24E;
						IL_2AE:
						this.ExecuteCommand(importTemplatesContext);
						num = (short)1066860546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::System.Collections.Generic.IList<string> list = array.ToList<string>();
						global::Motorola.CommonCPS.RadioManagement.UIModels.ImportTemplatesContext importTemplatesContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.ImportTemplatesContext();
						importTemplatesContext.FilePasswords = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword>();
						importTemplatesContext.FileNames = list.ToArray<string>();
						global::System.Collections.Generic.IEnumerator<string> enumerator = list.GetEnumerator();
						num = (short)47513600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_2CE;
					case 3:
						goto IL_24E;
					case 4:
						if (array.Length != 0)
						{
							num = (short)1371013121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_318;
					case 5:
						if (array != null)
						{
							num = (short)1553989635;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_318;
					}
					goto IL_6E;
					IL_24E:
					num = (short)1565458433;
					if (num != 0)
					{
					}
					num = (short)907280388;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2CE:
				IL_318:
				return null;
				IL_6E:
				array = global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowOpenFileDialogForImportTemplates();
				num = (short)222429189;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000433 RID: 1075
		protected abstract void ExecuteCommand(global::Motorola.CommonCPS.RadioManagement.UIModels.ImportTemplatesContext context);
	}
}
