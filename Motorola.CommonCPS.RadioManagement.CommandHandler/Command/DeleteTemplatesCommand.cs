using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000CE RID: 206
	internal class DeleteTemplatesCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000437 RID: 1079 RVA: 0x00047DD8 File Offset: 0x00045FD8
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1052704768;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				global::System.Collections.ICollection collection;
				global::System.Collections.IEnumerator enumerator;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_105;
					case 1:
						goto IL_C8;
					case 2:
						if (collection.Count == 0)
						{
							num = (short)1939734528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = collection.GetEnumerator();
						num = (short)737083393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)2035810306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (collection != null)
						{
							num = (short)1532690432;
							short num3 = num;
							num = (short)1987575811;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_43;
				}
				IL_C8:
				bool result;
				try
				{
					num = (short)1854472198;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_218;
						case 1:
							goto IL_282;
						case 2:
							goto IL_1DB;
						case 3:
							if (((global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase)enumerator.Current).RadioReferencedCount > 0)
							{
								num = (short)851116036;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1C2;
						case 4:
							result = false;
							num = (short)282787840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)904986625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_175;
							}
							continue;
						}
						goto IL_175;
						IL_1C2:
						num = (short)3080194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_175:
						num = (short)2133244743;
						short num4 = num;
						num = (short)2089073479;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_1DB:
							if (!enumerator.MoveNext())
							{
								num = (short)1692794885;
								num2 = (int)((global::System.IntPtr)num);
							}
							else
							{
								num = (short)1934950403;
								num2 = (int)((global::System.IntPtr)num);
							}
							break;
						default:
							num = (short)726597632;
							if (num != 0)
							{
							}
							goto IL_1C2;
						}
					}
					IL_218:
					return result;
					IL_282:
					return true;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_2A4;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_291:
						switch (num2)
						{
						case 0:
							disposable.Dispose();
							num = (short)570621953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_2F6;
						case 2:
							if (disposable != null)
							{
								num = (short)933560320;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F8;
						}
						goto IL_2A4;
					}
					IL_2F6:
					IL_2F8:
					goto EndFinally_8;
					IL_2A4:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)2142175234;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_291;
					EndFinally_8:;
				}
				return result;
				IL_105:
				num = (short)1053949953;
				if (num != 0)
				{
				}
				return false;
				IL_43:
				collection = (paras[0] as global::System.Collections.ICollection);
				num = (short)723845124;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x000480FC File Offset: 0x000462FC
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)208797703;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> list;
			for (;;)
			{
				num = (short)228392961;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					if (list == null)
					{
						num = (short)1300365315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1919090693;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1636302852;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_192;
				case 3:
					goto IL_13B;
				case 4:
					if (paras.Count<object>() < 1)
					{
						goto IL_162;
					}
					list = (paras[0] as global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>);
					num = (short)454230016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (base.Interaction.ShowDeleteTemplatesConfirmationDialog(list.Count))
					{
						num = (short)1618149376;
						short num3 = num;
						num = (short)1605500934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EA;
				case 6:
					goto IL_F9;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				}
				IL_6C:
				if (paras != null)
				{
					num = (short)893648897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_192;
				IL_162:
				num = (short)1869283330;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_192:
				num = (short)70889035;
				short num4 = num;
				num = (short)790933067;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_162;
				default:
					goto IL_1C8;
				}
			}
			IL_F9:
			global::Motorola.CommonCPS.RadioManagement.BatchOp.DeleteTemplateBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.DeleteTemplateBatchOp(list);
			base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>(op);
			return true;
			IL_13B:
			throw new global::System.ArgumentNullException();
			IL_1C8:
			num = (short)624820224;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException();
			IL_1EA:
			return false;
		}
	}
}
