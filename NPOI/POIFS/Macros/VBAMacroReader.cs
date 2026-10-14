using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ICSharpCode.SharpZipLib.Zip;
using NPOI.POIFS.FileSystem;
using NPOI.Util;

namespace NPOI.POIFS.Macros
{
	// Token: 0x020002D0 RID: 720
	public class VBAMacroReader : global::NPOI.Util.ICloseable
	{
		// Token: 0x060013CA RID: 5066 RVA: 0x0003B438 File Offset: 0x00039638
		public VBAMacroReader(global::NPOI.Util.InputStream rstream)
		{
			global::NPOI.Util.PushbackInputStream pushbackInputStream = new global::NPOI.Util.PushbackInputStream(rstream, 8);
			if (global::NPOI.POIFS.FileSystem.NPOIFSFileSystem.HasPOIFSHeader(global::NPOI.Util.IOUtils.PeekFirst8Bytes(pushbackInputStream)))
			{
				this.fs = new global::NPOI.POIFS.FileSystem.NPOIFSFileSystem(pushbackInputStream);
				return;
			}
			this.OpenOOXML(pushbackInputStream);
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x0003B474 File Offset: 0x00039674
		public VBAMacroReader(global::System.IO.FileInfo file)
		{
			try
			{
				this.fs = new global::NPOI.POIFS.FileSystem.NPOIFSFileSystem(file);
			}
			catch (global::NPOI.POIFS.FileSystem.OfficeXmlFileException)
			{
				this.OpenOOXML(file.OpenRead());
			}
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0003B4B4 File Offset: 0x000396B4
		public VBAMacroReader(global::NPOI.POIFS.FileSystem.NPOIFSFileSystem fs)
		{
			this.fs = fs;
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x0003B4C4 File Offset: 0x000396C4
		private void OpenOOXML(global::System.IO.Stream zipFile)
		{
			global::ICSharpCode.SharpZipLib.Zip.ZipInputStream zipInputStream = new global::ICSharpCode.SharpZipLib.Zip.ZipInputStream(zipFile);
			global::ICSharpCode.SharpZipLib.Zip.ZipEntry nextEntry;
			while ((nextEntry = zipInputStream.GetNextEntry()) != null)
			{
				if (nextEntry.Name.EndsWith(global::NPOI.POIFS.Macros.VBAMacroReader.VBA_PROJECT_OOXML, global::System.StringComparison.OrdinalIgnoreCase))
				{
					try
					{
						this.fs = new global::NPOI.POIFS.FileSystem.NPOIFSFileSystem(zipInputStream);
						return;
					}
					catch (global::System.IO.IOException ex)
					{
						zipInputStream.Close();
						throw ex;
					}
					continue;
				}
			}
			zipInputStream.Close();
			throw new global::System.ArgumentException("No VBA project found");
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x0003B530 File Offset: 0x00039730
		public void Close()
		{
			this.fs.Close();
			this.fs = null;
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0003B544 File Offset: 0x00039744
		public global::System.Collections.Generic.Dictionary<string, string> ReadMacros()
		{
			global::NPOI.POIFS.Macros.VBAMacroReader.ModuleMap moduleMap = new global::NPOI.POIFS.Macros.VBAMacroReader.ModuleMap();
			this.FindMacros(this.fs.Root, moduleMap);
			global::System.Collections.Generic.Dictionary<string, string> dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::NPOI.POIFS.Macros.VBAMacroReader.Module> keyValuePair in moduleMap)
			{
				global::NPOI.POIFS.Macros.VBAMacroReader.Module value = keyValuePair.Value;
				if (value.buf != null && value.buf.Length != 0)
				{
					dictionary.Add(keyValuePair.Key, global::NPOI.POIFS.Macros.VBAMacroReader.ModuleMap.charset.GetString(value.buf));
				}
			}
			return dictionary;
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x0003B5E4 File Offset: 0x000397E4
		protected void FindMacros(global::NPOI.POIFS.FileSystem.DirectoryNode dir, global::NPOI.POIFS.Macros.VBAMacroReader.ModuleMap modules)
		{
			if (global::NPOI.POIFS.Macros.VBAMacroReader.VBA_PROJECT_POIFS.Equals(dir.Name, global::System.StringComparison.OrdinalIgnoreCase))
			{
				this.ReadMacros(dir, modules);
				return;
			}
			foreach (global::NPOI.POIFS.FileSystem.Entry entry in dir)
			{
				if (entry is global::NPOI.POIFS.FileSystem.DirectoryNode)
				{
					this.FindMacros((global::NPOI.POIFS.FileSystem.DirectoryNode)entry, modules);
				}
			}
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x0003B658 File Offset: 0x00039858
		private static string ReadString(global::NPOI.Util.InputStream stream, int length, global::System.Text.Encoding charset)
		{
			byte[] array = new byte[length];
			int count = stream.Read(array);
			return charset.GetString(array, 0, count);
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x0003B680 File Offset: 0x00039880
		private static void ReadModule(global::NPOI.Util.RLEDecompressingInputStream in1, string streamName, global::NPOI.POIFS.Macros.VBAMacroReader.ModuleMap modules)
		{
			int num = in1.ReadInt();
			global::NPOI.POIFS.Macros.VBAMacroReader.Module module = modules.Get(streamName);
			if (module == null)
			{
				modules.Put(streamName, new global::NPOI.POIFS.Macros.VBAMacroReader.Module
				{
					offset = new int?(num)
				});
				return;
			}
			global::NPOI.Util.InputStream inputStream = new global::NPOI.Util.RLEDecompressingInputStream(new global::System.IO.MemoryStream(module.buf, num, module.buf.Length - num));
			module.Read(inputStream);
			inputStream.Close();
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x0003B6E4 File Offset: 0x000398E4
		private static void ReadModule(global::NPOI.POIFS.FileSystem.DocumentInputStream dis, string name, global::NPOI.POIFS.Macros.VBAMacroReader.ModuleMap modules)
		{
			global::NPOI.POIFS.Macros.VBAMacroReader.Module module = modules.Get(name);
			if (module == null)
			{
				module = new global::NPOI.POIFS.Macros.VBAMacroReader.Module();
				modules.Put(name, module);
				module.Read(dis);
				return;
			}
			if (module.offset == null)
			{
				throw new global::System.IO.IOException("Module offset for '" + name + "' was never Read.");
			}
			long num = dis.Skip((long)module.offset.Value);
			long num2 = num;
			int? offset = module.offset;
			long? num3 = (offset != null) ? new long?((long)offset.GetValueOrDefault()) : null;
			if (!(num2 == num3.GetValueOrDefault() & num3 != null))
			{
				string[] array = new string[5];
				array[0] = "tried to skip ";
				int num4 = 1;
				offset = module.offset;
				array[num4] = offset.ToString();
				array[2] = " bytes, but actually skipped ";
				array[3] = num.ToString();
				array[4] = " bytes";
				throw new global::System.IO.IOException(string.Concat(array));
			}
			global::NPOI.Util.InputStream inputStream = new global::NPOI.Util.RLEDecompressingInputStream(dis);
			module.Read(inputStream);
			inputStream.Close();
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x0003B7E8 File Offset: 0x000399E8
		private static void TrySkip(global::NPOI.Util.InputStream in1, long n)
		{
			long num = in1.Skip(n);
			if (num == n)
			{
				return;
			}
			if (num < 0L)
			{
				throw new global::System.IO.IOException("Tried skipping " + n.ToString() + " bytes, but no bytes were skipped. The end of the stream has been reached or the stream is closed.");
			}
			throw new global::System.IO.IOException(string.Concat(new string[]
			{
				"Tried skipping ",
				n.ToString(),
				" bytes, but only ",
				num.ToString(),
				" bytes were skipped. This should never happen."
			}));
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x0003B860 File Offset: 0x00039A60
		protected void ReadMacros(global::NPOI.POIFS.FileSystem.DirectoryNode macroDir, global::NPOI.POIFS.Macros.VBAMacroReader.ModuleMap modules)
		{
			foreach (global::NPOI.POIFS.FileSystem.Entry entry in macroDir)
			{
				if (entry is global::NPOI.POIFS.FileSystem.DocumentNode)
				{
					string name = entry.Name;
					global::NPOI.POIFS.FileSystem.DocumentInputStream documentInputStream = new global::NPOI.POIFS.FileSystem.DocumentInputStream((global::NPOI.POIFS.FileSystem.DocumentNode)entry);
					try
					{
						if ("dir".Equals(name, global::System.StringComparison.OrdinalIgnoreCase))
						{
							global::NPOI.Util.RLEDecompressingInputStream rledecompressingInputStream = new global::NPOI.Util.RLEDecompressingInputStream(documentInputStream);
							string streamName = null;
							int num = 0;
							try
							{
								for (;;)
								{
									num = rledecompressingInputStream.ReadShort();
									if (-1 == num || 16 == num)
									{
										break;
									}
									int num2 = rledecompressingInputStream.ReadInt();
									if (num <= 9)
									{
										if (num == 3)
										{
											global::NPOI.POIFS.Macros.VBAMacroReader.ModuleMap.charset = global::System.Text.Encoding.GetEncoding(rledecompressingInputStream.ReadShort());
											continue;
										}
										if (num == 9)
										{
											global::NPOI.POIFS.Macros.VBAMacroReader.TrySkip(rledecompressingInputStream, 6L);
											continue;
										}
									}
									else
									{
										if (num == 26)
										{
											streamName = global::NPOI.POIFS.Macros.VBAMacroReader.ReadString(rledecompressingInputStream, num2, global::NPOI.POIFS.Macros.VBAMacroReader.ModuleMap.charset);
											continue;
										}
										if (num == 49)
										{
											global::NPOI.POIFS.Macros.VBAMacroReader.ReadModule(rledecompressingInputStream, streamName, modules);
											continue;
										}
									}
									global::NPOI.POIFS.Macros.VBAMacroReader.TrySkip(rledecompressingInputStream, (long)num2);
								}
								continue;
							}
							catch (global::System.IO.IOException innerException)
							{
								string[] array = new string[5];
								array[0] = "Error occurred while Reading macros at section id ";
								array[1] = num.ToString();
								array[2] = " (";
								int num3 = 3;
								char[] array2 = global::NPOI.Util.HexDump.ShortToHex(num);
								array[num3] = ((array2 != null) ? array2.ToString() : null);
								array[4] = ")";
								throw new global::System.IO.IOException(string.Concat(array), innerException);
							}
							finally
							{
								rledecompressingInputStream.Close();
							}
						}
						if (!name.StartsWith("__SRP", global::System.StringComparison.OrdinalIgnoreCase) && !name.StartsWith("_VBA_PROJECT", global::System.StringComparison.OrdinalIgnoreCase))
						{
							global::NPOI.POIFS.Macros.VBAMacroReader.ReadModule(documentInputStream, name, modules);
						}
					}
					finally
					{
						documentInputStream.Close();
					}
				}
			}
		}

		// Token: 0x0400083F RID: 2111
		protected static string VBA_PROJECT_OOXML = "vbaProject.bin";

		// Token: 0x04000840 RID: 2112
		protected static string VBA_PROJECT_POIFS = "VBA";

		// Token: 0x04000841 RID: 2113
		private global::NPOI.POIFS.FileSystem.NPOIFSFileSystem fs;

		// Token: 0x04000842 RID: 2114
		private const int EOF = -1;

		// Token: 0x04000843 RID: 2115
		private const int VERSION_INDEPENDENT_TERMINATOR = 16;

		// Token: 0x04000844 RID: 2116
		private const int VERSION_DEPENDENT_TERMINATOR = 43;

		// Token: 0x04000845 RID: 2117
		private const int PROJECTVERSION = 9;

		// Token: 0x04000846 RID: 2118
		private const int PROJECTCODEPAGE = 3;

		// Token: 0x04000847 RID: 2119
		private const int STREAMNAME = 26;

		// Token: 0x04000848 RID: 2120
		private const int MODULEOFFSET = 49;

		// Token: 0x04000849 RID: 2121
		private const int MODULETYPE_PROCEDURAL = 33;

		// Token: 0x0400084A RID: 2122
		private const int MODULETYPE_DOCUMENT_CLASS_OR_DESIGNER = 34;

		// Token: 0x0400084B RID: 2123
		private const int PROJECTLCID = 2;

		// Token: 0x020005A8 RID: 1448
		protected class Module
		{
			// Token: 0x06003483 RID: 13443 RVA: 0x000A34DC File Offset: 0x000A16DC
			public void Read(global::System.IO.Stream in1)
			{
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				global::NPOI.Util.IOUtils.Copy(in1, memoryStream);
				memoryStream.Close();
				this.buf = memoryStream.ToArray();
			}

			// Token: 0x04001920 RID: 6432
			public int? offset;

			// Token: 0x04001921 RID: 6433
			public byte[] buf;
		}

		// Token: 0x020005A9 RID: 1449
		protected class ModuleMap : global::System.Collections.Generic.Dictionary<string, global::NPOI.POIFS.Macros.VBAMacroReader.Module>
		{
			// Token: 0x06003486 RID: 13446 RVA: 0x000A3519 File Offset: 0x000A1719
			public global::NPOI.POIFS.Macros.VBAMacroReader.Module Get(string key)
			{
				if (!base.ContainsKey(key))
				{
					return null;
				}
				return base[key];
			}

			// Token: 0x06003487 RID: 13447 RVA: 0x000A3530 File Offset: 0x000A1730
			public global::NPOI.POIFS.Macros.VBAMacroReader.Module Put(string key, global::NPOI.POIFS.Macros.VBAMacroReader.Module value)
			{
				global::NPOI.POIFS.Macros.VBAMacroReader.Module result = null;
				if (base.ContainsKey(key))
				{
					result = base[key];
					base[key] = value;
				}
				else
				{
					base.Add(key, value);
				}
				return result;
			}

			// Token: 0x04001922 RID: 6434
			public static global::System.Text.Encoding charset = global::System.Text.Encoding.GetEncoding(1252);
		}
	}
}
