using System;
using System.Collections.Generic;
using System.IO;
using Motorola.Common.CommonLib;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x02000006 RID: 6
	public abstract class CpsFileSequenceManagerBase : global::Motorola.Common.Communication.ICpsFileSequenceManager
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000066A8 File Offset: 0x000048A8
		// (set) Token: 0x06000022 RID: 34 RVA: 0x0000675C File Offset: 0x0000495C
		protected global::Motorola.Common.Communication.IshHandler.IOController IOController
		{
			get
			{
				short num = (short)236715119;
				short num2 = num;
				num = (short)1999830127;
				switch (num2 == num)
				{
				}
				num = (short)1324613633;
				if (num != 0)
				{
				}
				num = (short)1510277120;
				short num3 = num;
				num = (short)1812660224;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1572600396;
				short num2 = num;
				num = (short)1495792204;
				switch (num2 == num)
				{
				}
				num = (short)197656577;
				if (num != 0)
				{
				}
				num = (short)1057030144;
				short num3 = num;
				num = (short)279773184;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00006824 File Offset: 0x00004A24
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> ReadFilesListInDir(global::Motorola.Common.Communication.Pba.FileItem dir)
		{
			short num = (short)300310800;
			short num2 = num;
			num = (short)232153360;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)360710144;
				if (num != 0)
				{
				}
				num = (short)1188102145;
				if (num != 0)
				{
				}
				num = (short)152502272;
				switch (num)
				{
				}
				break;
			}
			this.UpdateMaxDataTransferSize();
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>();
			using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct>.Enumerator enumerator = this.IOController.ListDirectoryContents(dir.PartionID, dir.FilePath).GetEnumerator())
			{
				num = (short)477429763;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_1DC;
					case 1:
					{
						global::Motorola.Common.Communication.Pba.FileListItemStruct fileListItemStruct;
						if (fileListItemStruct.FileType == global::Motorola.Common.Communication.Pba.FileListItemStruct.TypeOfFile.File)
						{
							num = (short)481689604;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						num = (short)750845952;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_FE;
						}
						continue;
					case 4:
					{
						global::Motorola.Common.Communication.Pba.FileListItemStruct fileListItemStruct;
						global::Motorola.Common.Communication.Pba.FileItem item = new global::Motorola.Common.Communication.Pba.FileItem(dir.PartionID, dir.FilePath + fileListItemStruct.FileName, fileListItemStruct.FileSize, null, null, null);
						list.Add(item);
						num = (short)1330905094;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)517931010;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.Pba.FileListItemStruct fileListItemStruct = enumerator.Current;
						num = (short)1059323905;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_13F:
					num = (short)201523205;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_FE:
					goto IL_13F;
				}
				IL_1DC:;
			}
			num = (short)1902182400;
			short num4 = num;
			return list;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00006A64 File Offset: 0x00004C64
		public void DeleteFile(global::Motorola.Common.Communication.Pba.FileItem file)
		{
			short num = (short)1189651036;
			short num2 = num;
			num = (short)656515676;
			switch (num2 == num)
			{
			}
			num = (short)1599209473;
			if (num != 0)
			{
			}
			num = (short)214368256;
			short num3 = num;
			num = (short)827654144;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			list.Add(file.FilePath);
			this.IOController.DeleteFilesOrDirectory(file.PartionID, list);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00006B34 File Offset: 0x00004D34
		public global::Motorola.Common.Communication.Pba.FileItem ReadFile(global::Motorola.Common.Communication.Pba.FileItem file)
		{
			this.UpdateMaxDataTransferSize();
			global::Motorola.Common.Communication.Pba.FileItem fileItem = new global::Motorola.Common.Communication.Pba.FileItem(file.PartionID, file.FilePath, 0, null, null, null);
			global::System.IO.MemoryStream memoryStream = this.IOController.FileRead(file.PartionID, file.FilePath, null);
			short num;
			try
			{
				fileItem.FileContent = memoryStream.ToArray();
				fileItem.FileSize = (int)memoryStream.Length;
			}
			finally
			{
				for (;;)
				{
					num = (short)733478912;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_87;
							}
							continue;
						case 1:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)1025114114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_BD;
						}
						IL_87:
						if (memoryStream == null)
						{
							goto IL_130;
						}
						num = (short)445972481;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_BD:
					num = (short)1614086145;
					if (num != 0)
					{
					}
					num = (short)1305136031;
					short num3 = num;
					num = (short)1783745439;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_119;
					}
				}
				IL_119:
				num = (short)814481408;
				if (num != 0)
				{
				}
				IL_130:;
			}
			num = (short)426770432;
			short num4 = num;
			return fileItem;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00006CB0 File Offset: 0x00004EB0
		public void WriteFile(global::Motorola.Common.Communication.Pba.FileItem file, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null)
		{
			int a_ = 6;
			short num = (short)1667235840;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_50;
				}
				string path;
				string text;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						if (file.FileContent != null)
						{
							num = (short)208535557;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8E;
					case 1:
						goto IL_112;
					case 2:
						if (file.FileContent.Length != 0)
						{
							num = (short)1963589636;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8E;
					case 3:
						goto IL_162;
					case 4:
					{
						num = (short)226426880;
						short num3 = num;
						goto IL_13E;
					}
					case 5:
						num = (short)1826816002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_50;
					IL_8E:
					num = (short)439428683;
					short num4 = num;
					num = (short)893658699;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
					{
						IL_13E:
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(file.FileContent);
						num = (short)449249283;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					default:
						num = (short)1042939904;
						if (num != 0)
						{
						}
						path = file.URI;
						text = file.URI + global::Motorola.Common.Communication.IshHandler.Validator.b("膮얰\udeb2어", a_);
						num = (short)524419073;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_112:
				num = (short)1322057729;
				if (num != 0)
				{
				}
				try
				{
					num = (short)1263861760;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.IO.FileStream fileStream;
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_212;
							}
							continue;
						case 1:
							try
							{
								this.IOController.FileWrite(file.PartionID, file.FilePath, fileStream, progressIndicator, false);
								goto IL_33D;
							}
							finally
							{
								num = (short)47906818;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										((global::System.IDisposable)fileStream).Dispose();
										num = (short)883884033;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_316;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_2E0;
										}
										continue;
									}
									IL_2E0:
									if (fileStream == null)
									{
										break;
									}
									num = (short)1391656960;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_316:;
							}
							goto IL_319;
							IL_33D:
							num = (short)1133576196;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_23F;
						case 3:
							goto IL_23F;
						case 4:
							goto IL_356;
						case 5:
							global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.DecryptFileToFile(file.URI, text);
							path = text;
							num = (short)1328218115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_212:
						if (global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.IsEncryptedByMe(file.URI))
						{
							num = (short)243138565;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_319;
						IL_23F:
						fileStream = new global::System.IO.FileStream(path, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read);
						num = (short)2135752705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_319:
						path = file.URI;
						num = (short)1988100098;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_356:
					return;
				}
				catch (global::Motorola.Common.CustomException.CommonException)
				{
					throw;
				}
				catch (global::System.Exception systemException)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileIOAccessError, systemException);
				}
				finally
				{
					try
					{
						num = (short)1652883459;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_3F7;
							case 1:
								goto IL_3E2;
							case 2:
								global::System.IO.File.Delete(text);
								num = (short)388104193;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_3A3;
								}
								continue;
							}
							IL_3A3:
							if (global::System.IO.File.Exists(text))
							{
								num = (short)1364590594;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_3E2:
							num = (short)1884684288;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_3F7:;
					}
					catch
					{
					}
				}
				IL_162:
				try
				{
					global::System.IO.MemoryStream memoryStream;
					this.IOController.FileWrite(file.PartionID, file.FilePath, memoryStream, progressIndicator, false);
				}
				finally
				{
					num = (short)2036924418;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.IO.MemoryStream memoryStream;
						switch (num2)
						{
						case 0:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)222625793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_487;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_450;
							}
							continue;
						}
						IL_450:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)412155904;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_487:;
				}
				return;
				IL_50:
				this.UpdateMaxDataTransferSize();
				num = (short)559611904;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000071DC File Offset: 0x000053DC
		public long GetFileOrDirSize(global::Motorola.Common.Communication.Pba.FileItem fileOrDir)
		{
			short num = (short)1760793855;
			short num2 = num;
			num = (short)206542079;
			switch (num2 == num)
			{
			}
			num = (short)1416167424;
			if (num != 0)
			{
			}
			num = (short)99680257;
			if (num != 0)
			{
			}
			num = (short)1068892160;
			short num3 = num;
			this.UpdateMaxDataTransferSize();
			return this.IOController.GetFileOrDirSize(fileOrDir.PartionID, fileOrDir.FilePath);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000072A4 File Offset: 0x000054A4
		protected virtual void UpdateMaxDataTransferSize()
		{
			short num = (short)1948005909;
			short num2 = num;
			num = (short)287389205;
			switch (num2 == num)
			{
			}
			num = (short)1177878529;
			if (num != 0)
			{
			}
			num = (short)1985282048;
			if (num != 0)
			{
			}
			num = (short)1214709760;
			short num3 = num;
		}

		// Token: 0x04000007 RID: 7
		private global::Motorola.Common.Communication.IshHandler.IOController a;
	}
}
