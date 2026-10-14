using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Ionic.Zlib;
using Microsoft.CSharp;

namespace Ionic.Zip
{
	// Token: 0x0200002D RID: 45
	[global::System.Runtime.InteropServices.Guid("ebc25cf6-9120-4283-b972-0e5520d00005")]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDispatch)]
	public class ZipFile : global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<global::Ionic.Zip.ZipEntry>, global::System.IDisposable
	{
		// Token: 0x06000195 RID: 405 RVA: 0x0000CDCC File Offset: 0x0000AFCC
		public void SaveSelfExtractor(string exeToGenerate, global::Ionic.Zip.SelfExtractorFlavor flavor)
		{
			this.SaveSelfExtractor(exeToGenerate, new global::Ionic.Zip.SelfExtractorSaveOptions
			{
				Flavor = flavor
			});
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000CDF0 File Offset: 0x0000AFF0
		public void SaveSelfExtractor(string exeToGenerate, global::Ionic.Zip.SelfExtractorSaveOptions options)
		{
			if (this._name == null)
			{
				this._writestream = null;
			}
			this._SavingSfx = true;
			this._name = exeToGenerate;
			if (global::System.IO.Directory.Exists(this._name))
			{
				throw new global::Ionic.Zip.ZipException("Bad Directory", new global::System.ArgumentException("That name specifies an existing directory. Please specify a filename.", "exeToGenerate"));
			}
			this._contentsChanged = true;
			this._fileAlreadyExists = global::System.IO.File.Exists(this._name);
			this._SaveSfxStub(exeToGenerate, options);
			this.Save();
			this._SavingSfx = false;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000CE70 File Offset: 0x0000B070
		private static void ExtractResourceToFile(global::System.Reflection.Assembly a, string resourceName, string filename)
		{
			byte[] array = new byte[1024];
			using (global::System.IO.Stream manifestResourceStream = a.GetManifestResourceStream(resourceName))
			{
				if (manifestResourceStream == null)
				{
					throw new global::Ionic.Zip.ZipException(string.Format("missing resource '{0}'", resourceName));
				}
				using (global::System.IO.FileStream fileStream = global::System.IO.File.OpenWrite(filename))
				{
					int num;
					do
					{
						num = manifestResourceStream.Read(array, 0, array.Length);
						fileStream.Write(array, 0, num);
					}
					while (num > 0);
				}
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000CEF8 File Offset: 0x0000B0F8
		private void _SaveSfxStub(string exeToGenerate, global::Ionic.Zip.SelfExtractorSaveOptions options)
		{
			string text = null;
			string text2 = null;
			string dir = null;
			try
			{
				if (global::System.IO.File.Exists(exeToGenerate) && this.Verbose)
				{
					this.StatusMessageTextWriter.WriteLine("The existing file ({0}) will be overwritten.", exeToGenerate);
				}
				if (!exeToGenerate.EndsWith(".exe") && this.Verbose)
				{
					this.StatusMessageTextWriter.WriteLine("Warning: The generated self-extracting file will not have an .exe extension.");
				}
				dir = (this.TempFileFolder ?? global::System.IO.Path.GetDirectoryName(exeToGenerate));
				text = global::Ionic.Zip.ZipFile.GenerateTempPathname(dir, "exe");
				global::System.Reflection.Assembly assembly = typeof(global::Ionic.Zip.ZipFile).Assembly;
				global::System.Collections.Generic.Dictionary<string, string> dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
				if (!string.IsNullOrEmpty(options.CompilerVersion))
				{
					dictionary.Add("CompilerVersion", options.CompilerVersion);
				}
				using (global::Microsoft.CSharp.CSharpCodeProvider csharpCodeProvider = new global::Microsoft.CSharp.CSharpCodeProvider(dictionary))
				{
					global::Ionic.Zip.ZipFile.ExtractorSettings extractorSettings = (from x in global::Ionic.Zip.ZipFile.SettingsList
					where x.Flavor == options.Flavor
					select x).FirstOrDefault<global::Ionic.Zip.ZipFile.ExtractorSettings>();
					if (extractorSettings == null)
					{
						throw new global::Ionic.Zip.BadStateException(string.Format("While saving a Self-Extracting Zip, Cannot find that flavor ({0})?", options.Flavor));
					}
					global::System.CodeDom.Compiler.CompilerParameters compilerParameters = new global::System.CodeDom.Compiler.CompilerParameters();
					compilerParameters.ReferencedAssemblies.Add(assembly.Location);
					if (extractorSettings.ReferencedAssemblies != null)
					{
						foreach (string value in extractorSettings.ReferencedAssemblies)
						{
							compilerParameters.ReferencedAssemblies.Add(value);
						}
					}
					compilerParameters.GenerateInMemory = false;
					compilerParameters.GenerateExecutable = true;
					compilerParameters.IncludeDebugInformation = false;
					compilerParameters.CompilerOptions = "";
					global::System.Reflection.Assembly executingAssembly = global::System.Reflection.Assembly.GetExecutingAssembly();
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					string text3 = global::Ionic.Zip.ZipFile.GenerateTempPathname(dir, "cs");
					using (global::Ionic.Zip.ZipFile zipFile = global::Ionic.Zip.ZipFile.Read(executingAssembly.GetManifestResourceStream("Ionic.Zip.Resources.ZippedResources.zip")))
					{
						text2 = global::Ionic.Zip.ZipFile.GenerateTempPathname(dir, "tmp");
						if (string.IsNullOrEmpty(options.IconFile))
						{
							global::System.IO.Directory.CreateDirectory(text2);
							global::Ionic.Zip.ZipEntry zipEntry = zipFile["zippedFile.ico"];
							if ((zipEntry.Attributes & global::System.IO.FileAttributes.ReadOnly) == global::System.IO.FileAttributes.ReadOnly)
							{
								zipEntry.Attributes ^= global::System.IO.FileAttributes.ReadOnly;
							}
							zipEntry.Extract(text2);
							string arg = global::System.IO.Path.Combine(text2, "zippedFile.ico");
							global::System.CodeDom.Compiler.CompilerParameters compilerParameters2 = compilerParameters;
							compilerParameters2.CompilerOptions += string.Format("/win32icon:\"{0}\"", arg);
						}
						else
						{
							global::System.CodeDom.Compiler.CompilerParameters compilerParameters3 = compilerParameters;
							compilerParameters3.CompilerOptions += string.Format("/win32icon:\"{0}\"", options.IconFile);
						}
						compilerParameters.OutputAssembly = text;
						if (options.Flavor == global::Ionic.Zip.SelfExtractorFlavor.WinFormsApplication)
						{
							global::System.CodeDom.Compiler.CompilerParameters compilerParameters4 = compilerParameters;
							compilerParameters4.CompilerOptions += " /target:winexe";
						}
						if (!string.IsNullOrEmpty(options.AdditionalCompilerSwitches))
						{
							global::System.CodeDom.Compiler.CompilerParameters compilerParameters5 = compilerParameters;
							compilerParameters5.CompilerOptions = compilerParameters5.CompilerOptions + " " + options.AdditionalCompilerSwitches;
						}
						if (string.IsNullOrEmpty(compilerParameters.CompilerOptions))
						{
							compilerParameters.CompilerOptions = null;
						}
						if (extractorSettings.CopyThroughResources != null && extractorSettings.CopyThroughResources.Count != 0)
						{
							if (!global::System.IO.Directory.Exists(text2))
							{
								global::System.IO.Directory.CreateDirectory(text2);
							}
							foreach (string text4 in extractorSettings.CopyThroughResources)
							{
								string text5 = global::System.IO.Path.Combine(text2, text4);
								global::Ionic.Zip.ZipFile.ExtractResourceToFile(executingAssembly, text4, text5);
								compilerParameters.EmbeddedResources.Add(text5);
							}
						}
						compilerParameters.EmbeddedResources.Add(assembly.Location);
						stringBuilder.Append("// " + global::System.IO.Path.GetFileName(text3) + "\n").Append("// --------------------------------------------\n//\n").Append("// This SFX source file was generated by DotNetZip ").Append(global::Ionic.Zip.ZipFile.LibraryVersion.ToString()).Append("\n//         at ").Append(global::System.DateTime.Now.ToString("yyyy MMMM dd  HH:mm:ss")).Append("\n//\n// --------------------------------------------\n\n\n");
						if (!string.IsNullOrEmpty(options.Description))
						{
							stringBuilder.Append("[assembly: System.Reflection.AssemblyTitle(\"" + options.Description.Replace("\"", "") + "\")]\n");
						}
						else
						{
							stringBuilder.Append("[assembly: System.Reflection.AssemblyTitle(\"DotNetZip SFX Archive\")]\n");
						}
						if (!string.IsNullOrEmpty(options.ProductVersion))
						{
							stringBuilder.Append("[assembly: System.Reflection.AssemblyInformationalVersion(\"" + options.ProductVersion.Replace("\"", "") + "\")]\n");
						}
						string str = string.IsNullOrEmpty(options.Copyright) ? "Extractor: Copyright � Dino Chiesa 2008-2011" : options.Copyright.Replace("\"", "");
						if (!string.IsNullOrEmpty(options.ProductName))
						{
							stringBuilder.Append("[assembly: System.Reflection.AssemblyProduct(\"").Append(options.ProductName.Replace("\"", "")).Append("\")]\n");
						}
						else
						{
							stringBuilder.Append("[assembly: System.Reflection.AssemblyProduct(\"DotNetZip\")]\n");
						}
						stringBuilder.Append("[assembly: System.Reflection.AssemblyCopyright(\"" + str + "\")]\n").Append(string.Format("[assembly: System.Reflection.AssemblyVersion(\"{0}\")]\n", global::Ionic.Zip.ZipFile.LibraryVersion.ToString()));
						if (options.FileVersion != null)
						{
							stringBuilder.Append(string.Format("[assembly: System.Reflection.AssemblyFileVersion(\"{0}\")]\n", options.FileVersion.ToString()));
						}
						stringBuilder.Append("\n\n\n");
						string text6 = options.DefaultExtractDirectory;
						if (text6 != null)
						{
							text6 = text6.Replace("\"", "").Replace("\\", "\\\\");
						}
						string text7 = options.PostExtractCommandLine;
						if (text7 != null)
						{
							text7 = text7.Replace("\\", "\\\\");
							text7 = text7.Replace("\"", "\\\"");
						}
						foreach (string text8 in extractorSettings.ResourcesToCompile)
						{
							using (global::System.IO.Stream stream = zipFile[text8].OpenReader())
							{
								if (stream == null)
								{
									throw new global::Ionic.Zip.ZipException(string.Format("missing resource '{0}'", text8));
								}
								using (global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(stream))
								{
									while (streamReader.Peek() >= 0)
									{
										string text9 = streamReader.ReadLine();
										if (text6 != null)
										{
											text9 = text9.Replace("@@EXTRACTLOCATION", text6);
										}
										text9 = text9.Replace("@@REMOVE_AFTER_EXECUTE", options.RemoveUnpackedFilesAfterExecute.ToString());
										text9 = text9.Replace("@@QUIET", options.Quiet.ToString());
										if (!string.IsNullOrEmpty(options.SfxExeWindowTitle))
										{
											text9 = text9.Replace("@@SFX_EXE_WINDOW_TITLE", options.SfxExeWindowTitle);
										}
										text9 = text9.Replace("@@EXTRACT_EXISTING_FILE", ((int)options.ExtractExistingFile).ToString());
										if (text7 != null)
										{
											text9 = text9.Replace("@@POST_UNPACK_CMD_LINE", text7);
										}
										stringBuilder.Append(text9).Append("\n");
									}
								}
								stringBuilder.Append("\n\n");
							}
						}
					}
					string text10 = stringBuilder.ToString();
					global::System.CodeDom.Compiler.CompilerResults compilerResults = csharpCodeProvider.CompileAssemblyFromSource(compilerParameters, new string[]
					{
						text10
					});
					if (compilerResults == null)
					{
						throw new global::Ionic.Zip.SfxGenerationException("Cannot compile the extraction logic!");
					}
					if (this.Verbose)
					{
						foreach (string value2 in compilerResults.Output)
						{
							this.StatusMessageTextWriter.WriteLine(value2);
						}
					}
					if (compilerResults.Errors.Count != 0)
					{
						using (global::System.IO.TextWriter textWriter = new global::System.IO.StreamWriter(text3))
						{
							textWriter.Write(text10);
							textWriter.Write("\n\n\n// ------------------------------------------------------------------\n");
							textWriter.Write("// Errors during compilation: \n//\n");
							string fileName = global::System.IO.Path.GetFileName(text3);
							foreach (object obj in compilerResults.Errors)
							{
								global::System.CodeDom.Compiler.CompilerError compilerError = (global::System.CodeDom.Compiler.CompilerError)obj;
								textWriter.Write(string.Format("//   {0}({1},{2}): {3} {4}: {5}\n//\n", new object[]
								{
									fileName,
									compilerError.Line,
									compilerError.Column,
									compilerError.IsWarning ? "Warning" : "error",
									compilerError.ErrorNumber,
									compilerError.ErrorText
								}));
							}
						}
						throw new global::Ionic.Zip.SfxGenerationException(string.Format("Errors compiling the extraction logic!  {0}", text3));
					}
					this.OnSaveEvent(global::Ionic.Zip.ZipProgressEventType.Saving_AfterCompileSelfExtractor);
					using (global::System.IO.Stream stream2 = global::System.IO.File.OpenRead(text))
					{
						byte[] array = new byte[4000];
						int num = 1;
						while (num != 0)
						{
							num = stream2.Read(array, 0, array.Length);
							if (num != 0)
							{
								this.WriteStream.Write(array, 0, num);
							}
						}
					}
				}
				this.OnSaveEvent(global::Ionic.Zip.ZipProgressEventType.Saving_AfterSaveTempArchive);
			}
			finally
			{
				try
				{
					if (global::System.IO.Directory.Exists(text2))
					{
						try
						{
							global::System.IO.Directory.Delete(text2, true);
						}
						catch (global::System.IO.IOException arg2)
						{
							this.StatusMessageTextWriter.WriteLine("Warning: Exception: {0}", arg2);
						}
					}
					if (global::System.IO.File.Exists(text))
					{
						try
						{
							global::System.IO.File.Delete(text);
						}
						catch (global::System.IO.IOException arg3)
						{
							this.StatusMessageTextWriter.WriteLine("Warning: Exception: {0}", arg3);
						}
					}
				}
				catch (global::System.IO.IOException)
				{
				}
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000DA14 File Offset: 0x0000BC14
		internal static string GenerateTempPathname(string dir, string extension)
		{
			string name = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
			string text2;
			do
			{
				string text = global::System.Guid.NewGuid().ToString();
				string path = string.Format("{0}-{1}-{2}.{3}", new object[]
				{
					name,
					global::System.DateTime.Now.ToString("yyyyMMMdd-HHmmss"),
					text,
					extension
				});
				text2 = global::System.IO.Path.Combine(dir, path);
			}
			while (global::System.IO.File.Exists(text2) || global::System.IO.Directory.Exists(text2));
			return text2;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000DA94 File Offset: 0x0000BC94
		public global::Ionic.Zip.ZipEntry AddItem(string fileOrDirectoryName)
		{
			return this.AddItem(fileOrDirectoryName, null);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000DA9E File Offset: 0x0000BC9E
		public global::Ionic.Zip.ZipEntry AddItem(string fileOrDirectoryName, string directoryPathInArchive)
		{
			if (global::System.IO.File.Exists(fileOrDirectoryName))
			{
				return this.AddFile(fileOrDirectoryName, directoryPathInArchive);
			}
			if (global::System.IO.Directory.Exists(fileOrDirectoryName))
			{
				return this.AddDirectory(fileOrDirectoryName, directoryPathInArchive);
			}
			throw new global::System.IO.FileNotFoundException(string.Format("That file or directory ({0}) does not exist!", fileOrDirectoryName));
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000DAD2 File Offset: 0x0000BCD2
		public global::Ionic.Zip.ZipEntry AddFile(string fileName)
		{
			return this.AddFile(fileName, null);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000DADC File Offset: 0x0000BCDC
		public global::Ionic.Zip.ZipEntry AddFile(string fileName, string directoryPathInArchive)
		{
			string nameInArchive = global::Ionic.Zip.ZipEntry.NameInArchive(fileName, directoryPathInArchive);
			global::Ionic.Zip.ZipEntry ze = global::Ionic.Zip.ZipEntry.CreateFromFile(fileName, nameInArchive);
			if (this.Verbose)
			{
				this.StatusMessageTextWriter.WriteLine("adding {0}...", fileName);
			}
			return this._InternalAddEntry(ze);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000DB1C File Offset: 0x0000BD1C
		public void RemoveEntries(global::System.Collections.Generic.ICollection<global::Ionic.Zip.ZipEntry> entriesToRemove)
		{
			if (entriesToRemove == null)
			{
				throw new global::System.ArgumentNullException("entriesToRemove");
			}
			foreach (global::Ionic.Zip.ZipEntry entry in entriesToRemove)
			{
				this.RemoveEntry(entry);
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000DB74 File Offset: 0x0000BD74
		public void RemoveEntries(global::System.Collections.Generic.ICollection<string> entriesToRemove)
		{
			if (entriesToRemove == null)
			{
				throw new global::System.ArgumentNullException("entriesToRemove");
			}
			foreach (string fileName in entriesToRemove)
			{
				this.RemoveEntry(fileName);
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000DBCC File Offset: 0x0000BDCC
		public void AddFiles(global::System.Collections.Generic.IEnumerable<string> fileNames)
		{
			this.AddFiles(fileNames, null);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000DBD6 File Offset: 0x0000BDD6
		public void UpdateFiles(global::System.Collections.Generic.IEnumerable<string> fileNames)
		{
			this.UpdateFiles(fileNames, null);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000DBE0 File Offset: 0x0000BDE0
		public void AddFiles(global::System.Collections.Generic.IEnumerable<string> fileNames, string directoryPathInArchive)
		{
			this.AddFiles(fileNames, false, directoryPathInArchive);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000DBEC File Offset: 0x0000BDEC
		public void AddFiles(global::System.Collections.Generic.IEnumerable<string> fileNames, bool preserveDirHierarchy, string directoryPathInArchive)
		{
			if (fileNames == null)
			{
				throw new global::System.ArgumentNullException("fileNames");
			}
			this._addOperationCanceled = false;
			this.OnAddStarted();
			if (preserveDirHierarchy)
			{
				using (global::System.Collections.Generic.IEnumerator<string> enumerator = fileNames.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						string text = enumerator.Current;
						if (this._addOperationCanceled)
						{
							break;
						}
						if (directoryPathInArchive != null)
						{
							string fullPath = global::System.IO.Path.GetFullPath(global::System.IO.Path.Combine(directoryPathInArchive, global::System.IO.Path.GetDirectoryName(text)));
							this.AddFile(text, fullPath);
						}
						else
						{
							this.AddFile(text, null);
						}
					}
					goto IL_AC;
				}
			}
			foreach (string fileName in fileNames)
			{
				if (this._addOperationCanceled)
				{
					break;
				}
				this.AddFile(fileName, directoryPathInArchive);
			}
			IL_AC:
			if (!this._addOperationCanceled)
			{
				this.OnAddCompleted();
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000DCD0 File Offset: 0x0000BED0
		public void UpdateFiles(global::System.Collections.Generic.IEnumerable<string> fileNames, string directoryPathInArchive)
		{
			if (fileNames == null)
			{
				throw new global::System.ArgumentNullException("fileNames");
			}
			this.OnAddStarted();
			foreach (string fileName in fileNames)
			{
				this.UpdateFile(fileName, directoryPathInArchive);
			}
			this.OnAddCompleted();
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000DD34 File Offset: 0x0000BF34
		public global::Ionic.Zip.ZipEntry UpdateFile(string fileName)
		{
			return this.UpdateFile(fileName, null);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000DD40 File Offset: 0x0000BF40
		public global::Ionic.Zip.ZipEntry UpdateFile(string fileName, string directoryPathInArchive)
		{
			string fileName2 = global::Ionic.Zip.ZipEntry.NameInArchive(fileName, directoryPathInArchive);
			if (this[fileName2] != null)
			{
				this.RemoveEntry(fileName2);
			}
			return this.AddFile(fileName, directoryPathInArchive);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000DD6D File Offset: 0x0000BF6D
		public global::Ionic.Zip.ZipEntry UpdateDirectory(string directoryName)
		{
			return this.UpdateDirectory(directoryName, null);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000DD77 File Offset: 0x0000BF77
		public global::Ionic.Zip.ZipEntry UpdateDirectory(string directoryName, string directoryPathInArchive)
		{
			return this.AddOrUpdateDirectoryImpl(directoryName, directoryPathInArchive, global::Ionic.Zip.AddOrUpdateAction.AddOrUpdate);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000DD82 File Offset: 0x0000BF82
		public void UpdateItem(string itemName)
		{
			this.UpdateItem(itemName, null);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000DD8C File Offset: 0x0000BF8C
		public void UpdateItem(string itemName, string directoryPathInArchive)
		{
			if (global::System.IO.File.Exists(itemName))
			{
				this.UpdateFile(itemName, directoryPathInArchive);
				return;
			}
			if (global::System.IO.Directory.Exists(itemName))
			{
				this.UpdateDirectory(itemName, directoryPathInArchive);
				return;
			}
			throw new global::System.IO.FileNotFoundException(string.Format("That file or directory ({0}) does not exist!", itemName));
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000DDC2 File Offset: 0x0000BFC2
		public global::Ionic.Zip.ZipEntry AddEntry(string entryName, string content)
		{
			return this.AddEntry(entryName, content, global::System.Text.Encoding.Default);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000DDD4 File Offset: 0x0000BFD4
		public global::Ionic.Zip.ZipEntry AddEntry(string entryName, string content, global::System.Text.Encoding encoding)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(memoryStream, encoding);
			streamWriter.Write(content);
			streamWriter.Flush();
			memoryStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
			return this.AddEntry(entryName, memoryStream);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000DE0C File Offset: 0x0000C00C
		public global::Ionic.Zip.ZipEntry AddEntry(string entryName, global::System.IO.Stream stream)
		{
			global::Ionic.Zip.ZipEntry zipEntry = global::Ionic.Zip.ZipEntry.CreateForStream(entryName, stream);
			zipEntry.SetEntryTimes(global::System.DateTime.Now, global::System.DateTime.Now, global::System.DateTime.Now);
			if (this.Verbose)
			{
				this.StatusMessageTextWriter.WriteLine("adding {0}...", entryName);
			}
			return this._InternalAddEntry(zipEntry);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000DE58 File Offset: 0x0000C058
		public global::Ionic.Zip.ZipEntry AddEntry(string entryName, global::Ionic.Zip.WriteDelegate writer)
		{
			global::Ionic.Zip.ZipEntry ze = global::Ionic.Zip.ZipEntry.CreateForWriter(entryName, writer);
			if (this.Verbose)
			{
				this.StatusMessageTextWriter.WriteLine("adding {0}...", entryName);
			}
			return this._InternalAddEntry(ze);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000DE90 File Offset: 0x0000C090
		public global::Ionic.Zip.ZipEntry AddEntry(string entryName, global::Ionic.Zip.OpenDelegate opener, global::Ionic.Zip.CloseDelegate closer)
		{
			global::Ionic.Zip.ZipEntry zipEntry = global::Ionic.Zip.ZipEntry.CreateForJitStreamProvider(entryName, opener, closer);
			zipEntry.SetEntryTimes(global::System.DateTime.Now, global::System.DateTime.Now, global::System.DateTime.Now);
			if (this.Verbose)
			{
				this.StatusMessageTextWriter.WriteLine("adding {0}...", entryName);
			}
			return this._InternalAddEntry(zipEntry);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000DEDB File Offset: 0x0000C0DB
		public void AddEntry(global::Ionic.Zip.ZipEntry ze)
		{
			if (ze._container != null)
			{
				throw new global::System.InvalidOperationException("Entry already belongs to a zip file");
			}
			ze._container = new global::Ionic.Zip.ZipContainer(this);
			this.InternalAddEntry(ze.FileName, ze);
			this.AfterAddEntry(ze);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000DF10 File Offset: 0x0000C110
		private global::Ionic.Zip.ZipEntry _InternalAddEntry(global::Ionic.Zip.ZipEntry ze)
		{
			ze._container = new global::Ionic.Zip.ZipContainer(this);
			ze.CompressionMethod = this.CompressionMethod;
			ze.CompressionLevel = this.CompressionLevel;
			ze.ExtractExistingFile = this.ExtractExistingFile;
			ze.ZipErrorAction = this.ZipErrorAction;
			ze.SetCompression = this.SetCompression;
			ze.AlternateEncoding = this.AlternateEncoding;
			ze.AlternateEncodingUsage = this.AlternateEncodingUsage;
			ze.Password = this._Password;
			ze.Encryption = this.Encryption;
			ze.EmitTimesInWindowsFormatWhenSaving = this._emitNtfsTimes;
			ze.EmitTimesInUnixFormatWhenSaving = this._emitUnixTimes;
			this.InternalAddEntry(ze.FileName, ze);
			this.AfterAddEntry(ze);
			return ze;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000DFC2 File Offset: 0x0000C1C2
		public global::Ionic.Zip.ZipEntry UpdateEntry(string entryName, string content)
		{
			return this.UpdateEntry(entryName, content, global::System.Text.Encoding.Default);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000DFD1 File Offset: 0x0000C1D1
		public global::Ionic.Zip.ZipEntry UpdateEntry(string entryName, string content, global::System.Text.Encoding encoding)
		{
			this.RemoveEntryForUpdate(entryName);
			return this.AddEntry(entryName, content, encoding);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000DFE3 File Offset: 0x0000C1E3
		public global::Ionic.Zip.ZipEntry UpdateEntry(string entryName, global::Ionic.Zip.WriteDelegate writer)
		{
			this.RemoveEntryForUpdate(entryName);
			return this.AddEntry(entryName, writer);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000DFF4 File Offset: 0x0000C1F4
		public global::Ionic.Zip.ZipEntry UpdateEntry(string entryName, global::Ionic.Zip.OpenDelegate opener, global::Ionic.Zip.CloseDelegate closer)
		{
			this.RemoveEntryForUpdate(entryName);
			return this.AddEntry(entryName, opener, closer);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000E006 File Offset: 0x0000C206
		public global::Ionic.Zip.ZipEntry UpdateEntry(string entryName, global::System.IO.Stream stream)
		{
			this.RemoveEntryForUpdate(entryName);
			return this.AddEntry(entryName, stream);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000E018 File Offset: 0x0000C218
		private void RemoveEntryForUpdate(string entryName)
		{
			if (string.IsNullOrEmpty(entryName))
			{
				throw new global::System.ArgumentNullException("entryName");
			}
			string directoryPathInArchive = null;
			if (entryName.IndexOf('\\') != -1)
			{
				directoryPathInArchive = global::System.IO.Path.GetDirectoryName(entryName);
				entryName = global::System.IO.Path.GetFileName(entryName);
			}
			string fileName = global::Ionic.Zip.ZipEntry.NameInArchive(entryName, directoryPathInArchive);
			if (this[fileName] != null)
			{
				this.RemoveEntry(fileName);
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000E06C File Offset: 0x0000C26C
		public global::Ionic.Zip.ZipEntry AddEntry(string entryName, byte[] byteContent)
		{
			if (byteContent == null)
			{
				throw new global::System.ArgumentException("bad argument", "byteContent");
			}
			global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream(byteContent);
			return this.AddEntry(entryName, stream);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000E09B File Offset: 0x0000C29B
		public global::Ionic.Zip.ZipEntry UpdateEntry(string entryName, byte[] byteContent)
		{
			this.RemoveEntryForUpdate(entryName);
			return this.AddEntry(entryName, byteContent);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000E0AC File Offset: 0x0000C2AC
		public global::Ionic.Zip.ZipEntry AddDirectory(string directoryName)
		{
			return this.AddDirectory(directoryName, null);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000E0B6 File Offset: 0x0000C2B6
		public global::Ionic.Zip.ZipEntry AddDirectory(string directoryName, string directoryPathInArchive)
		{
			return this.AddOrUpdateDirectoryImpl(directoryName, directoryPathInArchive, global::Ionic.Zip.AddOrUpdateAction.AddOnly);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000E0C4 File Offset: 0x0000C2C4
		public global::Ionic.Zip.ZipEntry AddDirectoryByName(string directoryNameInArchive)
		{
			global::Ionic.Zip.ZipEntry zipEntry = global::Ionic.Zip.ZipEntry.CreateFromNothing(directoryNameInArchive);
			zipEntry._container = new global::Ionic.Zip.ZipContainer(this);
			zipEntry.MarkAsDirectory();
			zipEntry.AlternateEncoding = this.AlternateEncoding;
			zipEntry.AlternateEncodingUsage = this.AlternateEncodingUsage;
			zipEntry.SetEntryTimes(global::System.DateTime.Now, global::System.DateTime.Now, global::System.DateTime.Now);
			zipEntry.EmitTimesInWindowsFormatWhenSaving = this._emitNtfsTimes;
			zipEntry.EmitTimesInUnixFormatWhenSaving = this._emitUnixTimes;
			zipEntry._Source = global::Ionic.Zip.ZipEntrySource.Stream;
			this.InternalAddEntry(zipEntry.FileName, zipEntry);
			this.AfterAddEntry(zipEntry);
			return zipEntry;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000E14B File Offset: 0x0000C34B
		private global::Ionic.Zip.ZipEntry AddOrUpdateDirectoryImpl(string directoryName, string rootDirectoryPathInArchive, global::Ionic.Zip.AddOrUpdateAction action)
		{
			if (rootDirectoryPathInArchive == null)
			{
				rootDirectoryPathInArchive = "";
			}
			return this.AddOrUpdateDirectoryImpl(directoryName, rootDirectoryPathInArchive, action, true, 0);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000E162 File Offset: 0x0000C362
		internal void InternalAddEntry(string name, global::Ionic.Zip.ZipEntry entry)
		{
			this._entries.Add(name, entry);
			if (!this._entriesInsensitive.ContainsKey(name))
			{
				this._entriesInsensitive.Add(name, entry);
			}
			this._zipEntriesAsList = null;
			this._contentsChanged = true;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000E19C File Offset: 0x0000C39C
		private global::Ionic.Zip.ZipEntry AddOrUpdateDirectoryImpl(string directoryName, string rootDirectoryPathInArchive, global::Ionic.Zip.AddOrUpdateAction action, bool recurse, int level)
		{
			if (this.Verbose)
			{
				this.StatusMessageTextWriter.WriteLine("{0} {1}...", (action == global::Ionic.Zip.AddOrUpdateAction.AddOnly) ? "adding" : "Adding or updating", directoryName);
			}
			if (level == 0)
			{
				this._addOperationCanceled = false;
				this.OnAddStarted();
			}
			if (this._addOperationCanceled)
			{
				return null;
			}
			string text = rootDirectoryPathInArchive;
			global::Ionic.Zip.ZipEntry zipEntry = null;
			if (level > 0)
			{
				int num = directoryName.Length;
				for (int i = level; i > 0; i--)
				{
					num = directoryName.LastIndexOfAny("/\\".ToCharArray(), num - 1, num - 1);
				}
				text = directoryName.Substring(num + 1);
				text = global::System.IO.Path.Combine(rootDirectoryPathInArchive, text);
			}
			if (level > 0 || rootDirectoryPathInArchive != "")
			{
				zipEntry = global::Ionic.Zip.ZipEntry.CreateFromFile(directoryName, text);
				zipEntry._container = new global::Ionic.Zip.ZipContainer(this);
				zipEntry.AlternateEncoding = this.AlternateEncoding;
				zipEntry.AlternateEncodingUsage = this.AlternateEncodingUsage;
				zipEntry.MarkAsDirectory();
				zipEntry.EmitTimesInWindowsFormatWhenSaving = this._emitNtfsTimes;
				zipEntry.EmitTimesInUnixFormatWhenSaving = this._emitUnixTimes;
				if (!this._entries.ContainsKey(zipEntry.FileName))
				{
					this.InternalAddEntry(zipEntry.FileName, zipEntry);
					this.AfterAddEntry(zipEntry);
				}
				text = zipEntry.FileName;
			}
			if (!this._addOperationCanceled)
			{
				string[] files = global::System.IO.Directory.GetFiles(directoryName);
				if (recurse)
				{
					foreach (string fileName in files)
					{
						if (this._addOperationCanceled)
						{
							break;
						}
						if (action == global::Ionic.Zip.AddOrUpdateAction.AddOnly)
						{
							this.AddFile(fileName, text);
						}
						else
						{
							this.UpdateFile(fileName, text);
						}
					}
					if (!this._addOperationCanceled)
					{
						foreach (string text2 in global::System.IO.Directory.GetDirectories(directoryName))
						{
							global::System.IO.FileAttributes attributes = global::System.IO.File.GetAttributes(text2);
							if (this.AddDirectoryWillTraverseReparsePoints || (attributes & global::System.IO.FileAttributes.ReparsePoint) == (global::System.IO.FileAttributes)0)
							{
								this.AddOrUpdateDirectoryImpl(text2, rootDirectoryPathInArchive, action, recurse, level + 1);
							}
						}
					}
				}
			}
			if (level == 0)
			{
				this.OnAddCompleted();
			}
			return zipEntry;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000E376 File Offset: 0x0000C576
		public static bool CheckZip(string zipFileName)
		{
			return global::Ionic.Zip.ZipFile.CheckZip(zipFileName, false, null);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000E380 File Offset: 0x0000C580
		public static bool CheckZip(string zipFileName, bool fixIfNecessary, global::System.IO.TextWriter writer)
		{
			global::Ionic.Zip.ZipFile zipFile = null;
			global::Ionic.Zip.ZipFile zipFile2 = null;
			bool flag = true;
			try
			{
				zipFile = new global::Ionic.Zip.ZipFile();
				zipFile.FullScan = true;
				zipFile.Initialize(zipFileName);
				zipFile2 = global::Ionic.Zip.ZipFile.Read(zipFileName);
				foreach (global::Ionic.Zip.ZipEntry zipEntry in zipFile)
				{
					foreach (global::Ionic.Zip.ZipEntry zipEntry2 in zipFile2)
					{
						if (zipEntry.FileName == zipEntry2.FileName)
						{
							if (zipEntry._RelativeOffsetOfLocalHeader != zipEntry2._RelativeOffsetOfLocalHeader)
							{
								flag = false;
								if (writer != null)
								{
									writer.WriteLine("{0}: mismatch in RelativeOffsetOfLocalHeader  (0x{1:X16} != 0x{2:X16})", zipEntry.FileName, zipEntry._RelativeOffsetOfLocalHeader, zipEntry2._RelativeOffsetOfLocalHeader);
								}
							}
							if (zipEntry._CompressedSize != zipEntry2._CompressedSize)
							{
								flag = false;
								if (writer != null)
								{
									writer.WriteLine("{0}: mismatch in CompressedSize  (0x{1:X16} != 0x{2:X16})", zipEntry.FileName, zipEntry._CompressedSize, zipEntry2._CompressedSize);
								}
							}
							if (zipEntry._UncompressedSize != zipEntry2._UncompressedSize)
							{
								flag = false;
								if (writer != null)
								{
									writer.WriteLine("{0}: mismatch in UncompressedSize  (0x{1:X16} != 0x{2:X16})", zipEntry.FileName, zipEntry._UncompressedSize, zipEntry2._UncompressedSize);
								}
							}
							if (zipEntry.CompressionMethod != zipEntry2.CompressionMethod)
							{
								flag = false;
								if (writer != null)
								{
									writer.WriteLine("{0}: mismatch in CompressionMethod  (0x{1:X4} != 0x{2:X4})", zipEntry.FileName, zipEntry.CompressionMethod, zipEntry2.CompressionMethod);
								}
							}
							if (zipEntry.Crc == zipEntry2.Crc)
							{
								break;
							}
							flag = false;
							if (writer != null)
							{
								writer.WriteLine("{0}: mismatch in Crc32  (0x{1:X4} != 0x{2:X4})", zipEntry.FileName, zipEntry.Crc, zipEntry2.Crc);
								break;
							}
							break;
						}
					}
				}
				zipFile2.Dispose();
				zipFile2 = null;
				if (!flag && fixIfNecessary)
				{
					string text = global::System.IO.Path.GetFileNameWithoutExtension(zipFileName);
					text = string.Format("{0}_fixed.zip", text);
					zipFile.Save(text);
				}
			}
			finally
			{
				if (zipFile != null)
				{
					zipFile.Dispose();
				}
				if (zipFile2 != null)
				{
					zipFile2.Dispose();
				}
			}
			return flag;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000E5F0 File Offset: 0x0000C7F0
		public static void FixZipDirectory(string zipFileName)
		{
			using (global::Ionic.Zip.ZipFile zipFile = new global::Ionic.Zip.ZipFile())
			{
				zipFile.FullScan = true;
				zipFile.Initialize(zipFileName);
				zipFile.Save(zipFileName);
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000E634 File Offset: 0x0000C834
		public static bool CheckZipPassword(string zipFileName, string password)
		{
			bool result = false;
			try
			{
				using (global::Ionic.Zip.ZipFile zipFile = global::Ionic.Zip.ZipFile.Read(zipFileName))
				{
					foreach (global::Ionic.Zip.ZipEntry zipEntry in zipFile)
					{
						if (!zipEntry.IsDirectory && zipEntry.UsesEncryption)
						{
							zipEntry.ExtractWithPassword(global::System.IO.Stream.Null, password);
						}
					}
				}
				result = true;
			}
			catch (global::Ionic.Zip.BadPasswordException)
			{
			}
			return result;
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0000E6C8 File Offset: 0x0000C8C8
		public string Info
		{
			get
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				stringBuilder.Append(string.Format("          ZipFile: {0}\n", this.Name));
				if (!string.IsNullOrEmpty(this._Comment))
				{
					stringBuilder.Append(string.Format("          Comment: {0}\n", this._Comment));
				}
				if (this._versionMadeBy != 0)
				{
					stringBuilder.Append(string.Format("  version made by: 0x{0:X4}\n", this._versionMadeBy));
				}
				if (this._versionNeededToExtract != 0)
				{
					stringBuilder.Append(string.Format("needed to extract: 0x{0:X4}\n", this._versionNeededToExtract));
				}
				stringBuilder.Append(string.Format("       uses ZIP64: {0}\n", this.InputUsesZip64));
				stringBuilder.Append(string.Format("     disk with CD: {0}\n", this._diskNumberWithCd));
				if (this._OffsetOfCentralDirectory == 4294967295U)
				{
					stringBuilder.Append(string.Format("      CD64 offset: 0x{0:X16}\n", this._OffsetOfCentralDirectory64));
				}
				else
				{
					stringBuilder.Append(string.Format("        CD offset: 0x{0:X8}\n", this._OffsetOfCentralDirectory));
				}
				stringBuilder.Append("\n");
				foreach (global::Ionic.Zip.ZipEntry zipEntry in this._entries.Values)
				{
					stringBuilder.Append(zipEntry.Info);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x0000E83C File Offset: 0x0000CA3C
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x0000E844 File Offset: 0x0000CA44
		public bool FullScan { get; set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x0000E84D File Offset: 0x0000CA4D
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x0000E855 File Offset: 0x0000CA55
		public bool SortEntriesBeforeSaving { get; set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0000E85E File Offset: 0x0000CA5E
		// (set) Token: 0x060001CA RID: 458 RVA: 0x0000E866 File Offset: 0x0000CA66
		public bool AddDirectoryWillTraverseReparsePoints { get; set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001CB RID: 459 RVA: 0x0000E86F File Offset: 0x0000CA6F
		// (set) Token: 0x060001CC RID: 460 RVA: 0x0000E877 File Offset: 0x0000CA77
		public int BufferSize
		{
			get
			{
				return this._BufferSize;
			}
			set
			{
				this._BufferSize = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0000E880 File Offset: 0x0000CA80
		// (set) Token: 0x060001CE RID: 462 RVA: 0x0000E888 File Offset: 0x0000CA88
		public int CodecBufferSize { get; set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0000E891 File Offset: 0x0000CA91
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x0000E899 File Offset: 0x0000CA99
		public bool FlattenFoldersOnExtract { get; set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0000E8A2 File Offset: 0x0000CAA2
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x0000E8AA File Offset: 0x0000CAAA
		public global::Ionic.Zlib.CompressionStrategy Strategy
		{
			get
			{
				return this._Strategy;
			}
			set
			{
				this._Strategy = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000E8B3 File Offset: 0x0000CAB3
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x0000E8BB File Offset: 0x0000CABB
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000E8C4 File Offset: 0x0000CAC4
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x0000E8CC File Offset: 0x0000CACC
		public global::Ionic.Zlib.CompressionLevel CompressionLevel { get; set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000E8D5 File Offset: 0x0000CAD5
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x0000E8DD File Offset: 0x0000CADD
		public global::Ionic.Zip.CompressionMethod CompressionMethod
		{
			get
			{
				return this._compressionMethod;
			}
			set
			{
				this._compressionMethod = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0000E8E6 File Offset: 0x0000CAE6
		// (set) Token: 0x060001DA RID: 474 RVA: 0x0000E8EE File Offset: 0x0000CAEE
		public string Comment
		{
			get
			{
				return this._Comment;
			}
			set
			{
				this._Comment = value;
				this._contentsChanged = true;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000E8FE File Offset: 0x0000CAFE
		// (set) Token: 0x060001DC RID: 476 RVA: 0x0000E906 File Offset: 0x0000CB06
		public bool EmitTimesInWindowsFormatWhenSaving
		{
			get
			{
				return this._emitNtfsTimes;
			}
			set
			{
				this._emitNtfsTimes = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0000E90F File Offset: 0x0000CB0F
		// (set) Token: 0x060001DE RID: 478 RVA: 0x0000E917 File Offset: 0x0000CB17
		public bool EmitTimesInUnixFormatWhenSaving
		{
			get
			{
				return this._emitUnixTimes;
			}
			set
			{
				this._emitUnixTimes = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001DF RID: 479 RVA: 0x0000E920 File Offset: 0x0000CB20
		internal bool Verbose
		{
			get
			{
				return this._StatusMessageTextWriter != null;
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000E92B File Offset: 0x0000CB2B
		public bool ContainsEntry(string name)
		{
			return this.RetrievalEntries.ContainsKey(global::Ionic.Zip.SharedUtilities.NormalizePathForUseInZipFile(name));
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0000E93E File Offset: 0x0000CB3E
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x0000E946 File Offset: 0x0000CB46
		public bool CaseSensitiveRetrieval
		{
			get
			{
				return this._CaseSensitiveRetrieval;
			}
			set
			{
				this._CaseSensitiveRetrieval = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000E94F File Offset: 0x0000CB4F
		private global::System.Collections.Generic.Dictionary<string, global::Ionic.Zip.ZipEntry> RetrievalEntries
		{
			get
			{
				if (!this.CaseSensitiveRetrieval)
				{
					return this._entriesInsensitive;
				}
				return this._entries;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000E966 File Offset: 0x0000CB66
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x0000E96E File Offset: 0x0000CB6E
		public bool IgnoreDuplicateFiles
		{
			get
			{
				return this._IgnoreDuplicateFiles;
			}
			set
			{
				this._IgnoreDuplicateFiles = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x0000E977 File Offset: 0x0000CB77
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x0000E996 File Offset: 0x0000CB96
		[global::System.Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete.  It will be removed in a future version of the library. Your applications should  use AlternateEncoding and AlternateEncodingUsage instead.")]
		public bool UseUnicodeAsNecessary
		{
			get
			{
				return this._alternateEncoding == global::System.Text.Encoding.GetEncoding("UTF-8") && this._alternateEncodingUsage == global::Ionic.Zip.ZipOption.AsNecessary;
			}
			set
			{
				if (value)
				{
					this._alternateEncoding = global::System.Text.Encoding.GetEncoding("UTF-8");
					this._alternateEncodingUsage = global::Ionic.Zip.ZipOption.AsNecessary;
					return;
				}
				this._alternateEncoding = global::Ionic.Zip.ZipFile.DefaultEncoding;
				this._alternateEncodingUsage = global::Ionic.Zip.ZipOption.Default;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x0000E9C5 File Offset: 0x0000CBC5
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x0000E9CD File Offset: 0x0000CBCD
		public global::Ionic.Zip.Zip64Option UseZip64WhenSaving
		{
			get
			{
				return this._zip64;
			}
			set
			{
				this._zip64 = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0000E9D8 File Offset: 0x0000CBD8
		public bool? RequiresZip64
		{
			get
			{
				if (this._entries.Count > 65534)
				{
					return new bool?(true);
				}
				if (!this._hasBeenSaved || this._contentsChanged)
				{
					bool? result = null;
					return result;
				}
				foreach (global::Ionic.Zip.ZipEntry zipEntry in this._entries.Values)
				{
					bool? result = zipEntry.RequiresZip64;
					if (result.Value)
					{
						return new bool?(true);
					}
				}
				return new bool?(false);
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001EB RID: 491 RVA: 0x0000EA7C File Offset: 0x0000CC7C
		public bool? OutputUsedZip64
		{
			get
			{
				return this._OutputUsesZip64;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000EA84 File Offset: 0x0000CC84
		public bool? InputUsesZip64
		{
			get
			{
				if (this._entries.Count > 65534)
				{
					return new bool?(true);
				}
				foreach (global::Ionic.Zip.ZipEntry zipEntry in this)
				{
					if (zipEntry.Source != global::Ionic.Zip.ZipEntrySource.ZipFile)
					{
						return null;
					}
					if (zipEntry._InputUsesZip64)
					{
						return new bool?(true);
					}
				}
				return new bool?(false);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001ED RID: 493 RVA: 0x0000EB0C File Offset: 0x0000CD0C
		// (set) Token: 0x060001EE RID: 494 RVA: 0x0000EB1F File Offset: 0x0000CD1F
		[global::System.Obsolete("use AlternateEncoding instead.")]
		public global::System.Text.Encoding ProvisionalAlternateEncoding
		{
			get
			{
				if (this._alternateEncodingUsage == global::Ionic.Zip.ZipOption.AsNecessary)
				{
					return this._alternateEncoding;
				}
				return null;
			}
			set
			{
				this._alternateEncoding = value;
				this._alternateEncodingUsage = global::Ionic.Zip.ZipOption.AsNecessary;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0000EB2F File Offset: 0x0000CD2F
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x0000EB37 File Offset: 0x0000CD37
		public global::System.Text.Encoding AlternateEncoding
		{
			get
			{
				return this._alternateEncoding;
			}
			set
			{
				this._alternateEncoding = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x0000EB40 File Offset: 0x0000CD40
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x0000EB48 File Offset: 0x0000CD48
		public global::Ionic.Zip.ZipOption AlternateEncodingUsage
		{
			get
			{
				return this._alternateEncodingUsage;
			}
			set
			{
				this._alternateEncodingUsage = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x0000EB51 File Offset: 0x0000CD51
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x0000EB59 File Offset: 0x0000CD59
		public global::System.IO.TextWriter StatusMessageTextWriter
		{
			get
			{
				return this._StatusMessageTextWriter;
			}
			set
			{
				this._StatusMessageTextWriter = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0000EB62 File Offset: 0x0000CD62
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x0000EB6A File Offset: 0x0000CD6A
		public string TempFileFolder
		{
			get
			{
				return this._TempFileFolder;
			}
			set
			{
				this._TempFileFolder = value;
				if (value == null)
				{
					return;
				}
				if (!global::System.IO.Directory.Exists(value))
				{
					throw new global::System.IO.FileNotFoundException(string.Format("That directory ({0}) does not exist.", value));
				}
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000EBB8 File Offset: 0x0000CDB8
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x0000EB90 File Offset: 0x0000CD90
		public string Password
		{
			private get
			{
				return this._Password;
			}
			set
			{
				this._Password = value;
				if (this._Password == null)
				{
					this.Encryption = global::Ionic.Zip.EncryptionAlgorithm.None;
					return;
				}
				if (this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.None)
				{
					this.Encryption = global::Ionic.Zip.EncryptionAlgorithm.PkzipWeak;
				}
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0000EBC0 File Offset: 0x0000CDC0
		// (set) Token: 0x060001FA RID: 506 RVA: 0x0000EBC8 File Offset: 0x0000CDC8
		public global::Ionic.Zip.ExtractExistingFileAction ExtractExistingFile { get; set; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001FB RID: 507 RVA: 0x0000EBD1 File Offset: 0x0000CDD1
		// (set) Token: 0x060001FC RID: 508 RVA: 0x0000EBE8 File Offset: 0x0000CDE8
		public global::Ionic.Zip.ZipErrorAction ZipErrorAction
		{
			get
			{
				if (this.ZipError != null)
				{
					this._zipErrorAction = global::Ionic.Zip.ZipErrorAction.InvokeErrorEvent;
				}
				return this._zipErrorAction;
			}
			set
			{
				this._zipErrorAction = value;
				if (this._zipErrorAction != global::Ionic.Zip.ZipErrorAction.InvokeErrorEvent && this.ZipError != null)
				{
					this.ZipError = null;
				}
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0000EC09 File Offset: 0x0000CE09
		// (set) Token: 0x060001FE RID: 510 RVA: 0x0000EC11 File Offset: 0x0000CE11
		public global::Ionic.Zip.EncryptionAlgorithm Encryption
		{
			get
			{
				return this._Encryption;
			}
			set
			{
				if (value == global::Ionic.Zip.EncryptionAlgorithm.Unsupported)
				{
					throw new global::System.InvalidOperationException("You may not set Encryption to that value.");
				}
				this._Encryption = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0000EC29 File Offset: 0x0000CE29
		// (set) Token: 0x06000200 RID: 512 RVA: 0x0000EC31 File Offset: 0x0000CE31
		public global::Ionic.Zip.SetCompressionCallback SetCompression { get; set; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0000EC3A File Offset: 0x0000CE3A
		// (set) Token: 0x06000202 RID: 514 RVA: 0x0000EC5C File Offset: 0x0000CE5C
		public int MaxOutputSegmentSize
		{
			get
			{
				if (this._maxOutputSegmentSize > 2147483647L)
				{
					throw new global::Ionic.Zip.ZipException("MaxOutputSegmentSize is too large, use MaxOutputSegmentSize64 instead.");
				}
				return (int)this._maxOutputSegmentSize;
			}
			set
			{
				if (value < 65536 && value != 0)
				{
					throw new global::Ionic.Zip.ZipException("The minimum acceptable segment size is 65536.");
				}
				this._maxOutputSegmentSize = (long)value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0000EC7C File Offset: 0x0000CE7C
		// (set) Token: 0x06000204 RID: 516 RVA: 0x0000EC84 File Offset: 0x0000CE84
		public long MaxOutputSegmentSize64
		{
			get
			{
				return this._maxOutputSegmentSize;
			}
			set
			{
				if (value < 65536L && value != 0L)
				{
					throw new global::Ionic.Zip.ZipException("The minimum acceptable segment size is 65536.");
				}
				this._maxOutputSegmentSize = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0000ECA4 File Offset: 0x0000CEA4
		public int NumberOfSegmentsForMostRecentSave
		{
			get
			{
				return (int)(this._numberOfSegmentsForMostRecentSave + 1U);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0000ECD3 File Offset: 0x0000CED3
		// (set) Token: 0x06000206 RID: 518 RVA: 0x0000ECAE File Offset: 0x0000CEAE
		public long ParallelDeflateThreshold
		{
			get
			{
				return this._ParallelDeflateThreshold;
			}
			set
			{
				if (value != 0L && value != -1L && value < 65536L)
				{
					throw new global::System.ArgumentOutOfRangeException("ParallelDeflateThreshold should be -1, 0, or > 65536");
				}
				this._ParallelDeflateThreshold = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0000ECDB File Offset: 0x0000CEDB
		// (set) Token: 0x06000209 RID: 521 RVA: 0x0000ECE3 File Offset: 0x0000CEE3
		public int ParallelDeflateMaxBufferPairs
		{
			get
			{
				return this._maxBufferPairs;
			}
			set
			{
				if (value < 4)
				{
					throw new global::System.ArgumentOutOfRangeException("ParallelDeflateMaxBufferPairs", "Value must be 4 or greater.");
				}
				this._maxBufferPairs = value;
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000ED00 File Offset: 0x0000CF00
		public override string ToString()
		{
			return string.Format("ZipFile::{0}", this.Name);
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600020B RID: 523 RVA: 0x0000ED12 File Offset: 0x0000CF12
		public static global::System.Version LibraryVersion
		{
			get
			{
				return global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000ED23 File Offset: 0x0000CF23
		internal void NotifyEntryChanged()
		{
			this._contentsChanged = true;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000ED2C File Offset: 0x0000CF2C
		internal global::System.IO.Stream StreamForDiskNumber(uint diskNumber)
		{
			if (diskNumber + 1U == this._diskNumberWithCd || (diskNumber == 0U && this._diskNumberWithCd == 0U))
			{
				return this.ReadStream;
			}
			return global::Ionic.Zip.ZipSegmentedStream.ForReading(this._readName ?? this._name, diskNumber, this._diskNumberWithCd);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000ED68 File Offset: 0x0000CF68
		internal void Reset(bool whileSaving)
		{
			if (this._JustSaved)
			{
				using (global::Ionic.Zip.ZipFile zipFile = new global::Ionic.Zip.ZipFile())
				{
					if (global::System.IO.File.Exists(this._readName ?? this._name))
					{
						zipFile._readName = (zipFile._name = (whileSaving ? (this._readName ?? this._name) : this._name));
					}
					else
					{
						if (this._readstream.CanSeek)
						{
							this._readstream.Seek(0L, global::System.IO.SeekOrigin.Begin);
						}
						zipFile._readstream = this._readstream;
					}
					zipFile.AlternateEncoding = this.AlternateEncoding;
					zipFile.AlternateEncodingUsage = this.AlternateEncodingUsage;
					global::Ionic.Zip.ZipFile.ReadIntoInstance(zipFile);
					foreach (global::Ionic.Zip.ZipEntry zipEntry in zipFile)
					{
						global::Ionic.Zip.ZipEntry zipEntry2 = this[zipEntry.FileName];
						if (zipEntry2 != null && !zipEntry2.IsChanged)
						{
							zipEntry2.CopyMetaData(zipEntry);
						}
					}
				}
				this._JustSaved = false;
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000EE84 File Offset: 0x0000D084
		public ZipFile(string fileName)
		{
			if (global::Ionic.Zip.ZipFile.DefaultEncoding == null)
			{
				this._alternateEncoding = global::System.Text.Encoding.UTF8;
				this.AlternateEncodingUsage = global::Ionic.Zip.ZipOption.Always;
			}
			else
			{
				this._alternateEncoding = global::Ionic.Zip.ZipFile.DefaultEncoding;
			}
			try
			{
				this._InitInstance(fileName, null);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Ionic.Zip.ZipException(string.Format("Could not read {0} as a zip file", fileName), innerException);
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000EF30 File Offset: 0x0000D130
		public ZipFile(string fileName, global::System.Text.Encoding encoding)
		{
			try
			{
				this.AlternateEncoding = encoding;
				this.AlternateEncodingUsage = global::Ionic.Zip.ZipOption.Always;
				this._InitInstance(fileName, null);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Ionic.Zip.ZipException(string.Format("{0} is not a valid zip file", fileName), innerException);
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000EFC4 File Offset: 0x0000D1C4
		public ZipFile()
		{
			if (global::Ionic.Zip.ZipFile.DefaultEncoding == null)
			{
				this._alternateEncoding = global::System.Text.Encoding.UTF8;
				this.AlternateEncodingUsage = global::Ionic.Zip.ZipOption.Always;
			}
			else
			{
				this._alternateEncoding = global::Ionic.Zip.ZipFile.DefaultEncoding;
			}
			this._InitInstance(null, null);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000F04C File Offset: 0x0000D24C
		public ZipFile(global::System.Text.Encoding encoding)
		{
			this.AlternateEncoding = encoding;
			this.AlternateEncodingUsage = global::Ionic.Zip.ZipOption.Always;
			this._InitInstance(null, null);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000F0BC File Offset: 0x0000D2BC
		public ZipFile(string fileName, global::System.IO.TextWriter statusMessageWriter)
		{
			if (global::Ionic.Zip.ZipFile.DefaultEncoding == null)
			{
				this._alternateEncoding = global::System.Text.Encoding.UTF8;
				this.AlternateEncodingUsage = global::Ionic.Zip.ZipOption.Always;
			}
			else
			{
				this._alternateEncoding = global::Ionic.Zip.ZipFile.DefaultEncoding;
			}
			try
			{
				this._InitInstance(fileName, statusMessageWriter);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Ionic.Zip.ZipException(string.Format("{0} is not a valid zip file", fileName), innerException);
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000F168 File Offset: 0x0000D368
		public ZipFile(string fileName, global::System.IO.TextWriter statusMessageWriter, global::System.Text.Encoding encoding)
		{
			try
			{
				this.AlternateEncoding = encoding;
				this.AlternateEncodingUsage = global::Ionic.Zip.ZipOption.Always;
				this._InitInstance(fileName, statusMessageWriter);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Ionic.Zip.ZipException(string.Format("{0} is not a valid zip file", fileName), innerException);
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000F1FC File Offset: 0x0000D3FC
		public void Initialize(string fileName)
		{
			try
			{
				this._InitInstance(fileName, null);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Ionic.Zip.ZipException(string.Format("{0} is not a valid zip file", fileName), innerException);
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000F238 File Offset: 0x0000D438
		private void _InitInstance(string zipFileName, global::System.IO.TextWriter statusMessageWriter)
		{
			this._name = zipFileName;
			this._StatusMessageTextWriter = statusMessageWriter;
			this._contentsChanged = true;
			this.AddDirectoryWillTraverseReparsePoints = true;
			this.CompressionLevel = global::Ionic.Zlib.CompressionLevel.Default;
			this.ParallelDeflateThreshold = 524288L;
			this._entries = new global::System.Collections.Generic.Dictionary<string, global::Ionic.Zip.ZipEntry>(global::System.StringComparer.Ordinal);
			this._entriesInsensitive = new global::System.Collections.Generic.Dictionary<string, global::Ionic.Zip.ZipEntry>(global::System.StringComparer.OrdinalIgnoreCase);
			if (global::System.IO.File.Exists(this._name))
			{
				if (this.FullScan)
				{
					global::Ionic.Zip.ZipFile.ReadIntoInstance_Orig(this);
				}
				else
				{
					global::Ionic.Zip.ZipFile.ReadIntoInstance(this);
				}
				this._fileAlreadyExists = true;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0000F2BE File Offset: 0x0000D4BE
		private global::System.Collections.Generic.List<global::Ionic.Zip.ZipEntry> ZipEntriesAsList
		{
			get
			{
				if (this._zipEntriesAsList == null)
				{
					this._zipEntriesAsList = new global::System.Collections.Generic.List<global::Ionic.Zip.ZipEntry>(this._entries.Values);
				}
				return this._zipEntriesAsList;
			}
		}

		// Token: 0x1700007E RID: 126
		public global::Ionic.Zip.ZipEntry this[int ix]
		{
			get
			{
				return this.ZipEntriesAsList[ix];
			}
		}

		// Token: 0x1700007F RID: 127
		public global::Ionic.Zip.ZipEntry this[string fileName]
		{
			get
			{
				global::System.Collections.Generic.Dictionary<string, global::Ionic.Zip.ZipEntry> retrievalEntries = this.RetrievalEntries;
				string text = global::Ionic.Zip.SharedUtilities.NormalizePathForUseInZipFile(fileName);
				if (retrievalEntries.ContainsKey(text))
				{
					return retrievalEntries[text];
				}
				text = text.Replace("/", "\\");
				if (retrievalEntries.ContainsKey(text))
				{
					return retrievalEntries[text];
				}
				return null;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0000F343 File Offset: 0x0000D543
		public global::System.Collections.Generic.ICollection<string> EntryFileNames
		{
			get
			{
				return this._entries.Keys;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0000F350 File Offset: 0x0000D550
		public global::System.Collections.Generic.ICollection<global::Ionic.Zip.ZipEntry> Entries
		{
			get
			{
				return this._entries.Values;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600021C RID: 540 RVA: 0x0000F360 File Offset: 0x0000D560
		public global::System.Collections.Generic.ICollection<global::Ionic.Zip.ZipEntry> EntriesSorted
		{
			get
			{
				global::System.Collections.Generic.List<global::Ionic.Zip.ZipEntry> list = new global::System.Collections.Generic.List<global::Ionic.Zip.ZipEntry>();
				foreach (global::Ionic.Zip.ZipEntry item in this.Entries)
				{
					list.Add(item);
				}
				global::System.StringComparison sc = this.CaseSensitiveRetrieval ? global::System.StringComparison.Ordinal : global::System.StringComparison.OrdinalIgnoreCase;
				list.Sort((global::Ionic.Zip.ZipEntry x, global::Ionic.Zip.ZipEntry y) => string.Compare(x.FileName, y.FileName, sc));
				return list.AsReadOnly();
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000F3E4 File Offset: 0x0000D5E4
		public int Count
		{
			get
			{
				return this._entries.Count;
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000F3F4 File Offset: 0x0000D5F4
		public void RemoveEntry(global::Ionic.Zip.ZipEntry entry)
		{
			if (entry == null)
			{
				throw new global::System.ArgumentNullException("entry");
			}
			string text = global::Ionic.Zip.SharedUtilities.NormalizePathForUseInZipFile(entry.FileName);
			this._entries.Remove(text);
			if (!this.AnyCaseInsensitiveMatches(text))
			{
				this._entriesInsensitive.Remove(text);
			}
			this._zipEntriesAsList = null;
			this._contentsChanged = true;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000F44C File Offset: 0x0000D64C
		private bool AnyCaseInsensitiveMatches(string path)
		{
			using (global::System.Collections.Generic.Dictionary<string, global::Ionic.Zip.ZipEntry>.ValueCollection.Enumerator enumerator = this._entries.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (string.Equals(enumerator.Current.FileName, path, global::System.StringComparison.OrdinalIgnoreCase))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000F4B4 File Offset: 0x0000D6B4
		public void RemoveEntry(string fileName)
		{
			string fileName2 = global::Ionic.Zip.ZipEntry.NameInArchive(fileName, null);
			global::Ionic.Zip.ZipEntry zipEntry = this[fileName2];
			if (zipEntry == null)
			{
				throw new global::System.ArgumentException("The entry you specified was not found in the zip archive.");
			}
			this.RemoveEntry(zipEntry);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000F4E6 File Offset: 0x0000D6E6
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000F4F8 File Offset: 0x0000D6F8
		protected virtual void Dispose(bool disposeManagedResources)
		{
			if (!this._disposed)
			{
				if (disposeManagedResources)
				{
					if (this._ReadStreamIsOurs && this._readstream != null)
					{
						this._readstream.Dispose();
						this._readstream = null;
					}
					if (this._temporaryFileName != null && this._name != null && this._writestream != null)
					{
						this._writestream.Dispose();
						this._writestream = null;
					}
					if (this.ParallelDeflater != null)
					{
						this.ParallelDeflater.Dispose();
						this.ParallelDeflater = null;
					}
				}
				this._disposed = true;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0000F580 File Offset: 0x0000D780
		internal global::System.IO.Stream ReadStream
		{
			get
			{
				if (this._readstream == null && (this._readName != null || this._name != null))
				{
					this._readstream = global::System.IO.File.Open(this._readName ?? this._name, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.ReadWrite);
					this._ReadStreamIsOurs = true;
				}
				return this._readstream;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
		// (set) Token: 0x06000225 RID: 549 RVA: 0x0000F64D File Offset: 0x0000D84D
		private global::System.IO.Stream WriteStream
		{
			get
			{
				if (this._writestream != null)
				{
					return this._writestream;
				}
				if (this._name == null)
				{
					return this._writestream;
				}
				if (this._maxOutputSegmentSize != 0L)
				{
					this._writestream = global::Ionic.Zip.ZipSegmentedStream.ForWriting(this._name, this._maxOutputSegmentSize);
					return this._writestream;
				}
				global::Ionic.Zip.SharedUtilities.CreateAndOpenUniqueTempFile(this.TempFileFolder ?? global::System.IO.Path.GetDirectoryName(this._name), out this._writestream, out this._temporaryFileName);
				return this._writestream;
			}
			set
			{
				if (value != null)
				{
					throw new global::Ionic.Zip.ZipException("Cannot set the stream to a non-null value.");
				}
				this._writestream = null;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0000F664 File Offset: 0x0000D864
		private string ArchiveNameForEvent
		{
			get
			{
				if (this._name == null)
				{
					return "(stream)";
				}
				return this._name;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000227 RID: 551 RVA: 0x0000F67C File Offset: 0x0000D87C
		// (remove) Token: 0x06000228 RID: 552 RVA: 0x0000F6B4 File Offset: 0x0000D8B4
		public event global::System.EventHandler<global::Ionic.Zip.SaveProgressEventArgs> SaveProgress;

		// Token: 0x06000229 RID: 553 RVA: 0x0000F6EC File Offset: 0x0000D8EC
		internal bool OnSaveBlock(global::Ionic.Zip.ZipEntry entry, long bytesXferred, long totalBytesToXfer)
		{
			global::System.EventHandler<global::Ionic.Zip.SaveProgressEventArgs> saveProgress = this.SaveProgress;
			if (saveProgress != null)
			{
				global::Ionic.Zip.SaveProgressEventArgs saveProgressEventArgs = global::Ionic.Zip.SaveProgressEventArgs.ByteUpdate(this.ArchiveNameForEvent, entry, bytesXferred, totalBytesToXfer);
				saveProgress(this, saveProgressEventArgs);
				if (saveProgressEventArgs.Cancel)
				{
					this._saveOperationCanceled = true;
				}
			}
			return this._saveOperationCanceled;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000F730 File Offset: 0x0000D930
		private void OnSaveEntry(int current, global::Ionic.Zip.ZipEntry entry, bool before)
		{
			global::System.EventHandler<global::Ionic.Zip.SaveProgressEventArgs> saveProgress = this.SaveProgress;
			if (saveProgress != null)
			{
				global::Ionic.Zip.SaveProgressEventArgs saveProgressEventArgs = new global::Ionic.Zip.SaveProgressEventArgs(this.ArchiveNameForEvent, before, this._entries.Count, current, entry);
				saveProgress(this, saveProgressEventArgs);
				if (saveProgressEventArgs.Cancel)
				{
					this._saveOperationCanceled = true;
				}
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000F778 File Offset: 0x0000D978
		private void OnSaveEvent(global::Ionic.Zip.ZipProgressEventType eventFlavor)
		{
			global::System.EventHandler<global::Ionic.Zip.SaveProgressEventArgs> saveProgress = this.SaveProgress;
			if (saveProgress != null)
			{
				global::Ionic.Zip.SaveProgressEventArgs saveProgressEventArgs = new global::Ionic.Zip.SaveProgressEventArgs(this.ArchiveNameForEvent, eventFlavor);
				saveProgress(this, saveProgressEventArgs);
				if (saveProgressEventArgs.Cancel)
				{
					this._saveOperationCanceled = true;
				}
			}
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000F7B4 File Offset: 0x0000D9B4
		private void OnSaveStarted()
		{
			global::System.EventHandler<global::Ionic.Zip.SaveProgressEventArgs> saveProgress = this.SaveProgress;
			if (saveProgress != null)
			{
				global::Ionic.Zip.SaveProgressEventArgs saveProgressEventArgs = global::Ionic.Zip.SaveProgressEventArgs.Started(this.ArchiveNameForEvent);
				saveProgress(this, saveProgressEventArgs);
				if (saveProgressEventArgs.Cancel)
				{
					this._saveOperationCanceled = true;
				}
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000F7F0 File Offset: 0x0000D9F0
		private void OnSaveCompleted()
		{
			global::System.EventHandler<global::Ionic.Zip.SaveProgressEventArgs> saveProgress = this.SaveProgress;
			if (saveProgress != null)
			{
				global::Ionic.Zip.SaveProgressEventArgs e = global::Ionic.Zip.SaveProgressEventArgs.Completed(this.ArchiveNameForEvent);
				saveProgress(this, e);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600022E RID: 558 RVA: 0x0000F81C File Offset: 0x0000DA1C
		// (remove) Token: 0x0600022F RID: 559 RVA: 0x0000F854 File Offset: 0x0000DA54
		public event global::System.EventHandler<global::Ionic.Zip.ReadProgressEventArgs> ReadProgress;

		// Token: 0x06000230 RID: 560 RVA: 0x0000F88C File Offset: 0x0000DA8C
		private void OnReadStarted()
		{
			global::System.EventHandler<global::Ionic.Zip.ReadProgressEventArgs> readProgress = this.ReadProgress;
			if (readProgress != null)
			{
				global::Ionic.Zip.ReadProgressEventArgs e = global::Ionic.Zip.ReadProgressEventArgs.Started(this.ArchiveNameForEvent);
				readProgress(this, e);
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000F8B8 File Offset: 0x0000DAB8
		private void OnReadCompleted()
		{
			global::System.EventHandler<global::Ionic.Zip.ReadProgressEventArgs> readProgress = this.ReadProgress;
			if (readProgress != null)
			{
				global::Ionic.Zip.ReadProgressEventArgs e = global::Ionic.Zip.ReadProgressEventArgs.Completed(this.ArchiveNameForEvent);
				readProgress(this, e);
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000F8E4 File Offset: 0x0000DAE4
		internal void OnReadBytes(global::Ionic.Zip.ZipEntry entry)
		{
			global::System.EventHandler<global::Ionic.Zip.ReadProgressEventArgs> readProgress = this.ReadProgress;
			if (readProgress != null)
			{
				global::Ionic.Zip.ReadProgressEventArgs e = global::Ionic.Zip.ReadProgressEventArgs.ByteUpdate(this.ArchiveNameForEvent, entry, this.ReadStream.Position, this.LengthOfReadStream);
				readProgress(this, e);
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000F924 File Offset: 0x0000DB24
		internal void OnReadEntry(bool before, global::Ionic.Zip.ZipEntry entry)
		{
			global::System.EventHandler<global::Ionic.Zip.ReadProgressEventArgs> readProgress = this.ReadProgress;
			if (readProgress != null)
			{
				global::Ionic.Zip.ReadProgressEventArgs e = before ? global::Ionic.Zip.ReadProgressEventArgs.Before(this.ArchiveNameForEvent, this._entries.Count) : global::Ionic.Zip.ReadProgressEventArgs.After(this.ArchiveNameForEvent, entry, this._entries.Count);
				readProgress(this, e);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000234 RID: 564 RVA: 0x0000F976 File Offset: 0x0000DB76
		private long LengthOfReadStream
		{
			get
			{
				if (this._lengthOfReadStream == -99L)
				{
					this._lengthOfReadStream = (this._ReadStreamIsOurs ? global::Ionic.Zip.SharedUtilities.GetFileLength(this._name) : -1L);
				}
				return this._lengthOfReadStream;
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000235 RID: 565 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
		// (remove) Token: 0x06000236 RID: 566 RVA: 0x0000F9E0 File Offset: 0x0000DBE0
		public event global::System.EventHandler<global::Ionic.Zip.ExtractProgressEventArgs> ExtractProgress;

		// Token: 0x06000237 RID: 567 RVA: 0x0000FA18 File Offset: 0x0000DC18
		private void OnExtractEntry(int current, bool before, global::Ionic.Zip.ZipEntry currentEntry, string path)
		{
			global::System.EventHandler<global::Ionic.Zip.ExtractProgressEventArgs> extractProgress = this.ExtractProgress;
			if (extractProgress != null)
			{
				global::Ionic.Zip.ExtractProgressEventArgs extractProgressEventArgs = new global::Ionic.Zip.ExtractProgressEventArgs(this.ArchiveNameForEvent, before, this._entries.Count, current, currentEntry, path);
				extractProgress(this, extractProgressEventArgs);
				if (extractProgressEventArgs.Cancel)
				{
					this._extractOperationCanceled = true;
				}
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000FA64 File Offset: 0x0000DC64
		internal bool OnExtractBlock(global::Ionic.Zip.ZipEntry entry, long bytesWritten, long totalBytesToWrite)
		{
			global::System.EventHandler<global::Ionic.Zip.ExtractProgressEventArgs> extractProgress = this.ExtractProgress;
			if (extractProgress != null)
			{
				global::Ionic.Zip.ExtractProgressEventArgs extractProgressEventArgs = global::Ionic.Zip.ExtractProgressEventArgs.ByteUpdate(this.ArchiveNameForEvent, entry, bytesWritten, totalBytesToWrite);
				extractProgress(this, extractProgressEventArgs);
				if (extractProgressEventArgs.Cancel)
				{
					this._extractOperationCanceled = true;
				}
			}
			return this._extractOperationCanceled;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000FAA8 File Offset: 0x0000DCA8
		internal bool OnSingleEntryExtract(global::Ionic.Zip.ZipEntry entry, string path, bool before)
		{
			global::System.EventHandler<global::Ionic.Zip.ExtractProgressEventArgs> extractProgress = this.ExtractProgress;
			if (extractProgress != null)
			{
				global::Ionic.Zip.ExtractProgressEventArgs extractProgressEventArgs = before ? global::Ionic.Zip.ExtractProgressEventArgs.BeforeExtractEntry(this.ArchiveNameForEvent, entry, path) : global::Ionic.Zip.ExtractProgressEventArgs.AfterExtractEntry(this.ArchiveNameForEvent, entry, path);
				extractProgress(this, extractProgressEventArgs);
				if (extractProgressEventArgs.Cancel)
				{
					this._extractOperationCanceled = true;
				}
			}
			return this._extractOperationCanceled;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000FAFC File Offset: 0x0000DCFC
		internal bool OnExtractExisting(global::Ionic.Zip.ZipEntry entry, string path)
		{
			global::System.EventHandler<global::Ionic.Zip.ExtractProgressEventArgs> extractProgress = this.ExtractProgress;
			if (extractProgress != null)
			{
				global::Ionic.Zip.ExtractProgressEventArgs extractProgressEventArgs = global::Ionic.Zip.ExtractProgressEventArgs.ExtractExisting(this.ArchiveNameForEvent, entry, path);
				extractProgress(this, extractProgressEventArgs);
				if (extractProgressEventArgs.Cancel)
				{
					this._extractOperationCanceled = true;
				}
			}
			return this._extractOperationCanceled;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000FB40 File Offset: 0x0000DD40
		private void OnExtractAllCompleted(string path)
		{
			global::System.EventHandler<global::Ionic.Zip.ExtractProgressEventArgs> extractProgress = this.ExtractProgress;
			if (extractProgress != null)
			{
				global::Ionic.Zip.ExtractProgressEventArgs e = global::Ionic.Zip.ExtractProgressEventArgs.ExtractAllCompleted(this.ArchiveNameForEvent, path);
				extractProgress(this, e);
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000FB6C File Offset: 0x0000DD6C
		private void OnExtractAllStarted(string path)
		{
			global::System.EventHandler<global::Ionic.Zip.ExtractProgressEventArgs> extractProgress = this.ExtractProgress;
			if (extractProgress != null)
			{
				global::Ionic.Zip.ExtractProgressEventArgs e = global::Ionic.Zip.ExtractProgressEventArgs.ExtractAllStarted(this.ArchiveNameForEvent, path);
				extractProgress(this, e);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600023D RID: 573 RVA: 0x0000FB98 File Offset: 0x0000DD98
		// (remove) Token: 0x0600023E RID: 574 RVA: 0x0000FBD0 File Offset: 0x0000DDD0
		public event global::System.EventHandler<global::Ionic.Zip.AddProgressEventArgs> AddProgress;

		// Token: 0x0600023F RID: 575 RVA: 0x0000FC08 File Offset: 0x0000DE08
		private void OnAddStarted()
		{
			global::System.EventHandler<global::Ionic.Zip.AddProgressEventArgs> addProgress = this.AddProgress;
			if (addProgress != null)
			{
				global::Ionic.Zip.AddProgressEventArgs addProgressEventArgs = global::Ionic.Zip.AddProgressEventArgs.Started(this.ArchiveNameForEvent);
				addProgress(this, addProgressEventArgs);
				if (addProgressEventArgs.Cancel)
				{
					this._addOperationCanceled = true;
				}
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000FC44 File Offset: 0x0000DE44
		private void OnAddCompleted()
		{
			global::System.EventHandler<global::Ionic.Zip.AddProgressEventArgs> addProgress = this.AddProgress;
			if (addProgress != null)
			{
				global::Ionic.Zip.AddProgressEventArgs e = global::Ionic.Zip.AddProgressEventArgs.Completed(this.ArchiveNameForEvent);
				addProgress(this, e);
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000FC70 File Offset: 0x0000DE70
		internal void AfterAddEntry(global::Ionic.Zip.ZipEntry entry)
		{
			global::System.EventHandler<global::Ionic.Zip.AddProgressEventArgs> addProgress = this.AddProgress;
			if (addProgress != null)
			{
				global::Ionic.Zip.AddProgressEventArgs addProgressEventArgs = global::Ionic.Zip.AddProgressEventArgs.AfterEntry(this.ArchiveNameForEvent, entry, this._entries.Count);
				addProgress(this, addProgressEventArgs);
				if (addProgressEventArgs.Cancel)
				{
					this._addOperationCanceled = true;
				}
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000242 RID: 578 RVA: 0x0000FCB8 File Offset: 0x0000DEB8
		// (remove) Token: 0x06000243 RID: 579 RVA: 0x0000FCF0 File Offset: 0x0000DEF0
		public event global::System.EventHandler<global::Ionic.Zip.ZipErrorEventArgs> ZipError;

		// Token: 0x06000244 RID: 580 RVA: 0x0000FD28 File Offset: 0x0000DF28
		internal bool OnZipErrorSaving(global::Ionic.Zip.ZipEntry entry, global::System.Exception exc)
		{
			if (this.ZipError != null)
			{
				object @lock = this.LOCK;
				lock (@lock)
				{
					global::Ionic.Zip.ZipErrorEventArgs zipErrorEventArgs = global::Ionic.Zip.ZipErrorEventArgs.Saving(this.Name, entry, exc);
					this.ZipError(this, zipErrorEventArgs);
					if (zipErrorEventArgs.Cancel)
					{
						this._saveOperationCanceled = true;
					}
				}
			}
			return this._saveOperationCanceled;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000FD9C File Offset: 0x0000DF9C
		public void ExtractAll(string path)
		{
			this._InternalExtractAll(path, true);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000FDA6 File Offset: 0x0000DFA6
		public void ExtractAll(string path, global::Ionic.Zip.ExtractExistingFileAction extractExistingFile)
		{
			this.ExtractExistingFile = extractExistingFile;
			this._InternalExtractAll(path, true);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000FDB8 File Offset: 0x0000DFB8
		private void _InternalExtractAll(string path, bool overrideExtractExistingProperty)
		{
			bool flag = this.Verbose;
			this._inExtractAll = true;
			try
			{
				this.OnExtractAllStarted(path);
				int num = 0;
				foreach (global::Ionic.Zip.ZipEntry zipEntry in this._entries.Values)
				{
					if (flag)
					{
						this.StatusMessageTextWriter.WriteLine("\n{1,-22} {2,-8} {3,4}   {4,-8}  {0}", new object[]
						{
							"Name",
							"Modified",
							"Size",
							"Ratio",
							"Packed"
						});
						this.StatusMessageTextWriter.WriteLine(new string('-', 72));
						flag = false;
					}
					if (this.Verbose)
					{
						this.StatusMessageTextWriter.WriteLine("{1,-22} {2,-8} {3,4:F0}%   {4,-8} {0}", new object[]
						{
							zipEntry.FileName,
							zipEntry.LastModified.ToString("yyyy-MM-dd HH:mm:ss"),
							zipEntry.UncompressedSize,
							zipEntry.CompressionRatio,
							zipEntry.CompressedSize
						});
						if (!string.IsNullOrEmpty(zipEntry.Comment))
						{
							this.StatusMessageTextWriter.WriteLine("  Comment: {0}", zipEntry.Comment);
						}
					}
					zipEntry.Password = this._Password;
					this.OnExtractEntry(num, true, zipEntry, path);
					if (overrideExtractExistingProperty)
					{
						zipEntry.ExtractExistingFile = this.ExtractExistingFile;
					}
					zipEntry.Extract(path);
					num++;
					this.OnExtractEntry(num, false, zipEntry, path);
					if (this._extractOperationCanceled)
					{
						break;
					}
				}
				if (!this._extractOperationCanceled)
				{
					foreach (global::Ionic.Zip.ZipEntry zipEntry2 in this._entries.Values)
					{
						if (zipEntry2.IsDirectory || zipEntry2.FileName.EndsWith("/"))
						{
							string fileOrDirectory = zipEntry2.FileName.StartsWith("/") ? global::System.IO.Path.Combine(path, zipEntry2.FileName.Substring(1)) : global::System.IO.Path.Combine(path, zipEntry2.FileName);
							zipEntry2._SetTimes(fileOrDirectory, false);
						}
					}
					this.OnExtractAllCompleted(path);
				}
			}
			finally
			{
				this._inExtractAll = false;
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0001003C File Offset: 0x0000E23C
		public static global::Ionic.Zip.ZipFile Read(string fileName)
		{
			return global::Ionic.Zip.ZipFile.Read(fileName, null, null, null);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00010047 File Offset: 0x0000E247
		public static global::Ionic.Zip.ZipFile Read(string fileName, global::Ionic.Zip.ReadOptions options)
		{
			if (options == null)
			{
				throw new global::System.ArgumentNullException("options");
			}
			return global::Ionic.Zip.ZipFile.Read(fileName, options.StatusMessageWriter, options.Encoding, options.ReadProgress);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00010070 File Offset: 0x0000E270
		private static global::Ionic.Zip.ZipFile Read(string fileName, global::System.IO.TextWriter statusMessageWriter, global::System.Text.Encoding encoding, global::System.EventHandler<global::Ionic.Zip.ReadProgressEventArgs> readProgress)
		{
			global::Ionic.Zip.ZipFile zipFile = new global::Ionic.Zip.ZipFile();
			zipFile.AlternateEncoding = (encoding ?? global::Ionic.Zip.ZipFile.DefaultEncoding);
			zipFile.AlternateEncodingUsage = global::Ionic.Zip.ZipOption.Always;
			zipFile._StatusMessageTextWriter = statusMessageWriter;
			zipFile._name = fileName;
			if (readProgress != null)
			{
				zipFile.ReadProgress = readProgress;
			}
			if (zipFile.Verbose)
			{
				zipFile._StatusMessageTextWriter.WriteLine("reading from {0}...", fileName);
			}
			global::Ionic.Zip.ZipFile.ReadIntoInstance(zipFile);
			zipFile._fileAlreadyExists = true;
			return zipFile;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000100D9 File Offset: 0x0000E2D9
		public static global::Ionic.Zip.ZipFile Read(global::System.IO.Stream zipStream)
		{
			return global::Ionic.Zip.ZipFile.Read(zipStream, null, null, null);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000100E4 File Offset: 0x0000E2E4
		public static global::Ionic.Zip.ZipFile Read(global::System.IO.Stream zipStream, global::Ionic.Zip.ReadOptions options)
		{
			if (options == null)
			{
				throw new global::System.ArgumentNullException("options");
			}
			return global::Ionic.Zip.ZipFile.Read(zipStream, options.StatusMessageWriter, options.Encoding, options.ReadProgress);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0001010C File Offset: 0x0000E30C
		private static global::Ionic.Zip.ZipFile Read(global::System.IO.Stream zipStream, global::System.IO.TextWriter statusMessageWriter, global::System.Text.Encoding encoding, global::System.EventHandler<global::Ionic.Zip.ReadProgressEventArgs> readProgress)
		{
			if (zipStream == null)
			{
				throw new global::System.ArgumentNullException("zipStream");
			}
			global::Ionic.Zip.ZipFile zipFile = new global::Ionic.Zip.ZipFile();
			zipFile._StatusMessageTextWriter = statusMessageWriter;
			zipFile._alternateEncoding = (encoding ?? global::Ionic.Zip.ZipFile.DefaultEncoding);
			zipFile._alternateEncodingUsage = global::Ionic.Zip.ZipOption.Always;
			if (readProgress != null)
			{
				zipFile.ReadProgress += readProgress;
			}
			zipFile._readstream = ((zipStream.Position == 0L) ? zipStream : new global::Ionic.Zip.OffsetStream(zipStream));
			zipFile._ReadStreamIsOurs = false;
			if (zipFile.Verbose)
			{
				zipFile._StatusMessageTextWriter.WriteLine("reading from stream...");
			}
			global::Ionic.Zip.ZipFile.ReadIntoInstance(zipFile);
			return zipFile;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00010194 File Offset: 0x0000E394
		private static void ReadIntoInstance(global::Ionic.Zip.ZipFile zf)
		{
			global::System.IO.Stream readStream = zf.ReadStream;
			try
			{
				zf._readName = zf._name;
				if (!readStream.CanSeek)
				{
					global::Ionic.Zip.ZipFile.ReadIntoInstance_Orig(zf);
					return;
				}
				zf.OnReadStarted();
				if (global::Ionic.Zip.ZipFile.ReadFirstFourBytes(readStream) == 101010256U)
				{
					return;
				}
				int num = 0;
				bool flag = false;
				long num2 = readStream.Length - 64L;
				long num3 = global::System.Math.Max(readStream.Length - 16384L, 10L);
				do
				{
					if (num2 < 0L)
					{
						num2 = 0L;
					}
					readStream.Seek(num2, global::System.IO.SeekOrigin.Begin);
					if (global::Ionic.Zip.SharedUtilities.FindSignature(readStream, 101010256) != -1L)
					{
						flag = true;
					}
					else
					{
						if (num2 == 0L)
						{
							break;
						}
						num++;
						num2 -= (long)(32 * (num + 1) * num);
					}
				}
				while (!flag && num2 > num3);
				if (flag)
				{
					zf._locEndOfCDS = readStream.Position - 4L;
					byte[] array = new byte[16];
					readStream.Read(array, 0, array.Length);
					zf._diskNumberWithCd = (uint)global::System.BitConverter.ToUInt16(array, 2);
					if (zf._diskNumberWithCd == 65535U)
					{
						throw new global::Ionic.Zip.ZipException("Spanned archives with more than 65534 segments are not supported at this time.");
					}
					zf._diskNumberWithCd += 1U;
					int startIndex = 12;
					uint num4 = global::System.BitConverter.ToUInt32(array, startIndex);
					if (num4 == 4294967295U)
					{
						global::Ionic.Zip.ZipFile.Zip64SeekToCentralDirectory(zf);
					}
					else
					{
						zf._OffsetOfCentralDirectory = num4;
						readStream.Seek((long)((ulong)num4), global::System.IO.SeekOrigin.Begin);
					}
					global::Ionic.Zip.ZipFile.ReadCentralDirectory(zf);
				}
				else
				{
					readStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
					global::Ionic.Zip.ZipFile.ReadIntoInstance_Orig(zf);
				}
			}
			catch (global::System.Exception innerException)
			{
				if (zf._ReadStreamIsOurs && zf._readstream != null)
				{
					zf._readstream.Dispose();
					zf._readstream = null;
				}
				throw new global::Ionic.Zip.ZipException("Cannot read that as a ZipFile", innerException);
			}
			zf._contentsChanged = false;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00010344 File Offset: 0x0000E544
		private static void Zip64SeekToCentralDirectory(global::Ionic.Zip.ZipFile zf)
		{
			global::System.IO.Stream readStream = zf.ReadStream;
			byte[] array = new byte[16];
			readStream.Seek(-40L, global::System.IO.SeekOrigin.Current);
			readStream.Read(array, 0, 16);
			long num = global::System.BitConverter.ToInt64(array, 8);
			zf._OffsetOfCentralDirectory = uint.MaxValue;
			zf._OffsetOfCentralDirectory64 = num;
			readStream.Seek(num, global::System.IO.SeekOrigin.Begin);
			uint num2 = (uint)global::Ionic.Zip.SharedUtilities.ReadInt(readStream);
			if (num2 != 101075792U)
			{
				throw new global::Ionic.Zip.BadReadException(string.Format("  Bad signature (0x{0:X8}) looking for ZIP64 EoCD Record at position 0x{1:X8}", num2, readStream.Position));
			}
			readStream.Read(array, 0, 8);
			array = new byte[global::System.BitConverter.ToInt64(array, 0)];
			readStream.Read(array, 0, array.Length);
			num = global::System.BitConverter.ToInt64(array, 36);
			readStream.Seek(num, global::System.IO.SeekOrigin.Begin);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000103FB File Offset: 0x0000E5FB
		private static uint ReadFirstFourBytes(global::System.IO.Stream s)
		{
			return (uint)global::Ionic.Zip.SharedUtilities.ReadInt(s);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00010404 File Offset: 0x0000E604
		private static void ReadCentralDirectory(global::Ionic.Zip.ZipFile zf)
		{
			bool flag = false;
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>(global::System.StringComparer.Ordinal);
			global::Ionic.Zip.ZipEntry zipEntry;
			while ((zipEntry = global::Ionic.Zip.ZipEntry.ReadDirEntry(zf, dictionary)) != null)
			{
				zipEntry.ResetDirEntry();
				zf.OnReadEntry(true, null);
				if (zf.Verbose)
				{
					zf.StatusMessageTextWriter.WriteLine("entry {0}", zipEntry.FileName);
				}
				zf._entries.Add(zipEntry.FileName, zipEntry);
				if (!zf._entriesInsensitive.ContainsKey(zipEntry.FileName))
				{
					zf._entriesInsensitive.Add(zipEntry.FileName, zipEntry);
				}
				if (zipEntry._InputUsesZip64)
				{
					flag = true;
				}
				dictionary.Add(zipEntry.FileName, null);
			}
			if (flag)
			{
				zf.UseZip64WhenSaving = global::Ionic.Zip.Zip64Option.Always;
			}
			if (zf._locEndOfCDS > 0L)
			{
				zf.ReadStream.Seek(zf._locEndOfCDS, global::System.IO.SeekOrigin.Begin);
			}
			global::Ionic.Zip.ZipFile.ReadCentralDirectoryFooter(zf);
			if (zf.Verbose && !string.IsNullOrEmpty(zf.Comment))
			{
				zf.StatusMessageTextWriter.WriteLine("Zip file Comment: {0}", zf.Comment);
			}
			if (zf.Verbose)
			{
				zf.StatusMessageTextWriter.WriteLine("read in {0} entries.", zf._entries.Count);
			}
			zf.OnReadCompleted();
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00010530 File Offset: 0x0000E730
		private static void ReadIntoInstance_Orig(global::Ionic.Zip.ZipFile zf)
		{
			zf.OnReadStarted();
			zf._entries.Clear();
			zf._entriesInsensitive.Clear();
			if (zf.Verbose)
			{
				if (zf.Name == null)
				{
					zf.StatusMessageTextWriter.WriteLine("Reading zip from stream...");
				}
				else
				{
					zf.StatusMessageTextWriter.WriteLine("Reading zip {0}...", zf.Name);
				}
			}
			bool first = true;
			global::Ionic.Zip.ZipContainer zc = new global::Ionic.Zip.ZipContainer(zf);
			global::Ionic.Zip.ZipEntry zipEntry;
			while ((zipEntry = global::Ionic.Zip.ZipEntry.ReadEntry(zc, first)) != null)
			{
				if (zf.Verbose)
				{
					zf.StatusMessageTextWriter.WriteLine("  {0}", zipEntry.FileName);
				}
				zf._entries.Add(zipEntry.FileName, zipEntry);
				if (!zf._entriesInsensitive.ContainsKey(zipEntry.FileName))
				{
					zf._entriesInsensitive.Add(zipEntry.FileName, zipEntry);
				}
				first = false;
			}
			try
			{
				global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>(global::System.StringComparer.Ordinal);
				global::Ionic.Zip.ZipEntry zipEntry2;
				while ((zipEntry2 = global::Ionic.Zip.ZipEntry.ReadDirEntry(zf, dictionary)) != null)
				{
					global::Ionic.Zip.ZipEntry zipEntry3 = zf._entries[zipEntry2.FileName];
					if (zipEntry3 != null)
					{
						zipEntry3._Comment = zipEntry2.Comment;
						if (zipEntry2.IsDirectory)
						{
							zipEntry3.MarkAsDirectory();
						}
					}
					dictionary.Add(zipEntry2.FileName, null);
				}
				if (zf._locEndOfCDS > 0L)
				{
					zf.ReadStream.Seek(zf._locEndOfCDS, global::System.IO.SeekOrigin.Begin);
				}
				global::Ionic.Zip.ZipFile.ReadCentralDirectoryFooter(zf);
				if (zf.Verbose && !string.IsNullOrEmpty(zf.Comment))
				{
					zf.StatusMessageTextWriter.WriteLine("Zip file Comment: {0}", zf.Comment);
				}
			}
			catch (global::Ionic.Zip.ZipException)
			{
			}
			catch (global::System.IO.IOException)
			{
			}
			zf.OnReadCompleted();
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000106D4 File Offset: 0x0000E8D4
		private static void ReadCentralDirectoryFooter(global::Ionic.Zip.ZipFile zf)
		{
			global::System.IO.Stream readStream = zf.ReadStream;
			int num = global::Ionic.Zip.SharedUtilities.ReadSignature(readStream);
			int num2 = 0;
			byte[] array;
			if ((long)num == 101075792L)
			{
				array = new byte[52];
				readStream.Read(array, 0, array.Length);
				long num3 = global::System.BitConverter.ToInt64(array, 0);
				if (num3 < 44L)
				{
					throw new global::Ionic.Zip.ZipException("Bad size in the ZIP64 Central Directory.");
				}
				zf._versionMadeBy = global::System.BitConverter.ToUInt16(array, num2);
				num2 += 2;
				zf._versionNeededToExtract = global::System.BitConverter.ToUInt16(array, num2);
				num2 += 2;
				zf._diskNumberWithCd = global::System.BitConverter.ToUInt32(array, num2);
				num2 += 2;
				array = new byte[num3 - 44L];
				readStream.Read(array, 0, array.Length);
				num = global::Ionic.Zip.SharedUtilities.ReadSignature(readStream);
				if ((long)num != 117853008L)
				{
					throw new global::Ionic.Zip.ZipException("Inconsistent metadata in the ZIP64 Central Directory.");
				}
				array = new byte[16];
				readStream.Read(array, 0, array.Length);
				num = global::Ionic.Zip.SharedUtilities.ReadSignature(readStream);
			}
			if ((long)num != 101010256L)
			{
				readStream.Seek(-4L, global::System.IO.SeekOrigin.Current);
				throw new global::Ionic.Zip.BadReadException(string.Format("Bad signature ({0:X8}) at position 0x{1:X8}", num, readStream.Position));
			}
			array = new byte[16];
			zf.ReadStream.Read(array, 0, array.Length);
			if (zf._diskNumberWithCd == 0U)
			{
				zf._diskNumberWithCd = (uint)global::System.BitConverter.ToUInt16(array, 2);
			}
			global::Ionic.Zip.ZipFile.ReadZipFileComment(zf);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00010818 File Offset: 0x0000EA18
		private static void ReadZipFileComment(global::Ionic.Zip.ZipFile zf)
		{
			byte[] array = new byte[2];
			zf.ReadStream.Read(array, 0, array.Length);
			short num = (short)((int)array[0] + (int)array[1] * 256);
			if (num > 0)
			{
				array = new byte[(int)num];
				zf.ReadStream.Read(array, 0, array.Length);
				string @string = zf.AlternateEncoding.GetString(array, 0, array.Length);
				zf.Comment = @string;
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00010880 File Offset: 0x0000EA80
		public static bool IsZipFile(string fileName)
		{
			return global::Ionic.Zip.ZipFile.IsZipFile(fileName, false);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0001088C File Offset: 0x0000EA8C
		public static bool IsZipFile(string fileName, bool testExtract)
		{
			bool result = false;
			try
			{
				if (!global::System.IO.File.Exists(fileName))
				{
					return false;
				}
				using (global::System.IO.FileStream fileStream = global::System.IO.File.Open(fileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.ReadWrite))
				{
					result = global::Ionic.Zip.ZipFile.IsZipFile(fileStream, testExtract);
				}
			}
			catch (global::System.IO.IOException)
			{
			}
			catch (global::Ionic.Zip.ZipException)
			{
			}
			return result;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000108F8 File Offset: 0x0000EAF8
		public static bool IsZipFile(global::System.IO.Stream stream, bool testExtract)
		{
			if (stream == null)
			{
				throw new global::System.ArgumentNullException("stream");
			}
			bool result = false;
			try
			{
				if (!stream.CanRead)
				{
					return false;
				}
				global::System.IO.Stream @null = global::System.IO.Stream.Null;
				using (global::Ionic.Zip.ZipFile zipFile = global::Ionic.Zip.ZipFile.Read(stream, null, null, null))
				{
					if (testExtract)
					{
						foreach (global::Ionic.Zip.ZipEntry zipEntry in zipFile)
						{
							if (!zipEntry.IsDirectory)
							{
								zipEntry.Extract(@null);
							}
						}
					}
				}
				result = true;
			}
			catch (global::System.IO.IOException)
			{
			}
			catch (global::Ionic.Zip.ZipException)
			{
			}
			return result;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000109BC File Offset: 0x0000EBBC
		private void DeleteFileWithRetry(string filename)
		{
			bool flag = false;
			int num = 3;
			int num2 = 0;
			while (num2 < num && !flag)
			{
				try
				{
					global::System.IO.File.Delete(filename);
					flag = true;
				}
				catch (global::System.UnauthorizedAccessException)
				{
					global::System.Console.WriteLine("************************************************** Retry delete.");
					global::System.Threading.Thread.Sleep(200 + num2 * 200);
				}
				num2++;
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00010A18 File Offset: 0x0000EC18
		public void Save()
		{
			try
			{
				bool flag = false;
				this._saveOperationCanceled = false;
				this._numberOfSegmentsForMostRecentSave = 0U;
				this.OnSaveStarted();
				if (this.WriteStream == null)
				{
					throw new global::Ionic.Zip.BadStateException("You haven't specified where to save the zip.");
				}
				if (this._name != null && this._name.EndsWith(".exe") && !this._SavingSfx)
				{
					throw new global::Ionic.Zip.BadStateException("You specified an EXE for a plain zip file.");
				}
				if (!this._contentsChanged)
				{
					this.OnSaveCompleted();
					if (this.Verbose)
					{
						this.StatusMessageTextWriter.WriteLine("No save is necessary....");
					}
					return;
				}
				this.Reset(true);
				if (this.Verbose)
				{
					this.StatusMessageTextWriter.WriteLine("saving....");
				}
				if (this._entries.Count >= 65535 && this._zip64 == global::Ionic.Zip.Zip64Option.Default)
				{
					throw new global::Ionic.Zip.ZipException("The number of entries is 65535 or greater. Consider setting the UseZip64WhenSaving property on the ZipFile instance.");
				}
				int num = 0;
				global::System.Collections.Generic.ICollection<global::Ionic.Zip.ZipEntry> collection = this.SortEntriesBeforeSaving ? this.EntriesSorted : this.Entries;
				foreach (global::Ionic.Zip.ZipEntry zipEntry in collection)
				{
					this.OnSaveEntry(num, zipEntry, true);
					zipEntry.Write(this.WriteStream);
					if (this._saveOperationCanceled)
					{
						break;
					}
					num++;
					this.OnSaveEntry(num, zipEntry, false);
					if (this._saveOperationCanceled)
					{
						break;
					}
					if (zipEntry.IncludedInMostRecentSave)
					{
						flag |= zipEntry.OutputUsedZip64.Value;
					}
				}
				if (this._saveOperationCanceled)
				{
					return;
				}
				global::Ionic.Zip.ZipSegmentedStream zipSegmentedStream = this.WriteStream as global::Ionic.Zip.ZipSegmentedStream;
				this._numberOfSegmentsForMostRecentSave = ((zipSegmentedStream != null) ? zipSegmentedStream.CurrentSegment : 1U);
				bool flag2 = global::Ionic.Zip.ZipOutput.WriteCentralDirectoryStructure(this.WriteStream, collection, this._numberOfSegmentsForMostRecentSave, this._zip64, this.Comment, new global::Ionic.Zip.ZipContainer(this));
				this.OnSaveEvent(global::Ionic.Zip.ZipProgressEventType.Saving_AfterSaveTempArchive);
				this._hasBeenSaved = true;
				this._contentsChanged = false;
				flag = (flag || flag2);
				this._OutputUsesZip64 = new bool?(flag);
				if (this._fileAlreadyExists && this._readstream != null)
				{
					this._readstream.Close();
					this._readstream = null;
				}
				foreach (global::Ionic.Zip.ZipEntry zipEntry2 in collection)
				{
					global::Ionic.Zip.ZipSegmentedStream zipSegmentedStream2 = zipEntry2._archiveStream as global::Ionic.Zip.ZipSegmentedStream;
					if (zipSegmentedStream2 != null)
					{
						zipSegmentedStream2.Dispose();
					}
					zipEntry2._archiveStream = null;
				}
				if (this._name != null && (this._temporaryFileName != null || zipSegmentedStream != null))
				{
					this.WriteStream.Dispose();
					if (this._saveOperationCanceled)
					{
						return;
					}
					string text = null;
					if (global::System.IO.File.Exists(this._name))
					{
						text = this._name + "." + global::System.IO.Path.GetRandomFileName();
						if (global::System.IO.File.Exists(text))
						{
							this.DeleteFileWithRetry(text);
						}
						global::System.IO.File.Move(this._name, text);
					}
					this.OnSaveEvent(global::Ionic.Zip.ZipProgressEventType.Saving_BeforeRenameTempArchive);
					global::System.IO.File.Move((zipSegmentedStream != null) ? zipSegmentedStream.CurrentTempName : this._temporaryFileName, this._name);
					this.OnSaveEvent(global::Ionic.Zip.ZipProgressEventType.Saving_AfterRenameTempArchive);
					if (text != null)
					{
						try
						{
							if (global::System.IO.File.Exists(text))
							{
								global::System.IO.File.Delete(text);
							}
						}
						catch
						{
						}
					}
					this._fileAlreadyExists = true;
				}
				this._readName = this._name;
				global::Ionic.Zip.ZipFile.NotifyEntriesSaveComplete(collection);
				this.OnSaveCompleted();
				this._JustSaved = true;
			}
			finally
			{
				this.CleanupAfterSaveOperation();
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00010DB4 File Offset: 0x0000EFB4
		private static void NotifyEntriesSaveComplete(global::System.Collections.Generic.ICollection<global::Ionic.Zip.ZipEntry> c)
		{
			foreach (global::Ionic.Zip.ZipEntry zipEntry in c)
			{
				zipEntry.NotifySaveComplete();
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00010DFC File Offset: 0x0000EFFC
		private void RemoveTempFile()
		{
			try
			{
				if (global::System.IO.File.Exists(this._temporaryFileName))
				{
					global::System.IO.File.Delete(this._temporaryFileName);
				}
			}
			catch (global::System.IO.IOException ex)
			{
				if (this.Verbose)
				{
					this.StatusMessageTextWriter.WriteLine("ZipFile::Save: could not delete temp file: {0}.", ex.Message);
				}
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00010E54 File Offset: 0x0000F054
		private void CleanupAfterSaveOperation()
		{
			if (this._name != null)
			{
				if (this._writestream != null)
				{
					try
					{
						this._writestream.Dispose();
					}
					catch (global::System.IO.IOException)
					{
					}
				}
				this._writestream = null;
				if (this._temporaryFileName != null)
				{
					this.RemoveTempFile();
					this._temporaryFileName = null;
				}
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00010EB0 File Offset: 0x0000F0B0
		public void Save(string fileName)
		{
			if (this._name == null)
			{
				this._writestream = null;
			}
			else
			{
				this._readName = this._name;
			}
			this._name = fileName;
			if (global::System.IO.Directory.Exists(this._name))
			{
				throw new global::Ionic.Zip.ZipException("Bad Directory", new global::System.ArgumentException("That name specifies an existing directory. Please specify a filename.", "fileName"));
			}
			this._contentsChanged = true;
			this._fileAlreadyExists = global::System.IO.File.Exists(this._readName);
			this.Save();
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00010F28 File Offset: 0x0000F128
		public void Save(global::System.IO.Stream outputStream)
		{
			if (outputStream == null)
			{
				throw new global::System.ArgumentNullException("outputStream");
			}
			if (!outputStream.CanWrite)
			{
				throw new global::System.ArgumentException("Must be a writable stream.", "outputStream");
			}
			this._name = null;
			if (this._writestream != null)
			{
				this._readstream = this._writestream;
			}
			this._writestream = new global::Ionic.Zip.CountingStream(outputStream);
			this._contentsChanged = true;
			this._fileAlreadyExists = global::System.IO.File.Exists(this._readName);
			this.Save();
			this._fileAlreadyExists = false;
			this._readName = null;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00010FAE File Offset: 0x0000F1AE
		public void AddSelectedFiles(string selectionCriteria)
		{
			this.AddSelectedFiles(selectionCriteria, ".", null, false);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00010FBE File Offset: 0x0000F1BE
		public void AddSelectedFiles(string selectionCriteria, bool recurseDirectories)
		{
			this.AddSelectedFiles(selectionCriteria, ".", null, recurseDirectories);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00010FCE File Offset: 0x0000F1CE
		public void AddSelectedFiles(string selectionCriteria, string directoryOnDisk)
		{
			this.AddSelectedFiles(selectionCriteria, directoryOnDisk, null, false);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00010FDA File Offset: 0x0000F1DA
		public void AddSelectedFiles(string selectionCriteria, string directoryOnDisk, bool recurseDirectories)
		{
			this.AddSelectedFiles(selectionCriteria, directoryOnDisk, null, recurseDirectories);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00010FE6 File Offset: 0x0000F1E6
		public void AddSelectedFiles(string selectionCriteria, string directoryOnDisk, string directoryPathInArchive)
		{
			this.AddSelectedFiles(selectionCriteria, directoryOnDisk, directoryPathInArchive, false);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00010FF2 File Offset: 0x0000F1F2
		public void AddSelectedFiles(string selectionCriteria, string directoryOnDisk, string directoryPathInArchive, bool recurseDirectories)
		{
			this._AddOrUpdateSelectedFiles(selectionCriteria, directoryOnDisk, directoryPathInArchive, recurseDirectories, false);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00011000 File Offset: 0x0000F200
		public void UpdateSelectedFiles(string selectionCriteria, string directoryOnDisk, string directoryPathInArchive, bool recurseDirectories)
		{
			this._AddOrUpdateSelectedFiles(selectionCriteria, directoryOnDisk, directoryPathInArchive, recurseDirectories, true);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0001100E File Offset: 0x0000F20E
		private string EnsureendInSlash(string s)
		{
			if (s.EndsWith("\\"))
			{
				return s;
			}
			return s + "\\";
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0001102C File Offset: 0x0000F22C
		private void _AddOrUpdateSelectedFiles(string selectionCriteria, string directoryOnDisk, string directoryPathInArchive, bool recurseDirectories, bool wantUpdate)
		{
			if (directoryOnDisk == null && global::System.IO.Directory.Exists(selectionCriteria))
			{
				directoryOnDisk = selectionCriteria;
				selectionCriteria = "*.*";
			}
			else if (string.IsNullOrEmpty(directoryOnDisk))
			{
				directoryOnDisk = ".";
			}
			while (directoryOnDisk.EndsWith("\\"))
			{
				directoryOnDisk = directoryOnDisk.Substring(0, directoryOnDisk.Length - 1);
			}
			if (this.Verbose)
			{
				this.StatusMessageTextWriter.WriteLine("adding selection '{0}' from dir '{1}'...", selectionCriteria, directoryOnDisk);
			}
			global::System.Collections.ObjectModel.ReadOnlyCollection<string> readOnlyCollection = new global::Ionic.FileSelector(selectionCriteria, this.AddDirectoryWillTraverseReparsePoints).SelectFiles(directoryOnDisk, recurseDirectories);
			if (this.Verbose)
			{
				this.StatusMessageTextWriter.WriteLine("found {0} files...", readOnlyCollection.Count);
			}
			this.OnAddStarted();
			global::Ionic.Zip.AddOrUpdateAction action = wantUpdate ? global::Ionic.Zip.AddOrUpdateAction.AddOrUpdate : global::Ionic.Zip.AddOrUpdateAction.AddOnly;
			foreach (string text in readOnlyCollection)
			{
				string text2 = (directoryPathInArchive == null) ? null : global::Ionic.Zip.ZipFile.ReplaceLeadingDirectory(global::System.IO.Path.GetDirectoryName(text), directoryOnDisk, directoryPathInArchive);
				if (global::System.IO.File.Exists(text))
				{
					if (wantUpdate)
					{
						this.UpdateFile(text, text2);
					}
					else
					{
						this.AddFile(text, text2);
					}
				}
				else
				{
					this.AddOrUpdateDirectoryImpl(text, text2, action, false, 0);
				}
			}
			this.OnAddCompleted();
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00011160 File Offset: 0x0000F360
		private static string ReplaceLeadingDirectory(string original, string pattern, string replacement)
		{
			string text = original.ToUpper();
			string text2 = pattern.ToUpper();
			if (text.IndexOf(text2) != 0)
			{
				return original;
			}
			return replacement + original.Substring(text2.Length);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00011196 File Offset: 0x0000F396
		public global::System.Collections.Generic.ICollection<global::Ionic.Zip.ZipEntry> SelectEntries(string selectionCriteria)
		{
			return new global::Ionic.FileSelector(selectionCriteria, this.AddDirectoryWillTraverseReparsePoints).SelectEntries(this);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000111AA File Offset: 0x0000F3AA
		public global::System.Collections.Generic.ICollection<global::Ionic.Zip.ZipEntry> SelectEntries(string selectionCriteria, string directoryPathInArchive)
		{
			return new global::Ionic.FileSelector(selectionCriteria, this.AddDirectoryWillTraverseReparsePoints).SelectEntries(this, directoryPathInArchive);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000111C0 File Offset: 0x0000F3C0
		public int RemoveSelectedEntries(string selectionCriteria)
		{
			global::System.Collections.Generic.ICollection<global::Ionic.Zip.ZipEntry> collection = this.SelectEntries(selectionCriteria);
			this.RemoveEntries(collection);
			return collection.Count;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000111E4 File Offset: 0x0000F3E4
		public int RemoveSelectedEntries(string selectionCriteria, string directoryPathInArchive)
		{
			global::System.Collections.Generic.ICollection<global::Ionic.Zip.ZipEntry> collection = this.SelectEntries(selectionCriteria, directoryPathInArchive);
			this.RemoveEntries(collection);
			return collection.Count;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00011208 File Offset: 0x0000F408
		public void ExtractSelectedEntries(string selectionCriteria)
		{
			foreach (global::Ionic.Zip.ZipEntry zipEntry in this.SelectEntries(selectionCriteria))
			{
				zipEntry.Password = this._Password;
				zipEntry.Extract();
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00011260 File Offset: 0x0000F460
		public void ExtractSelectedEntries(string selectionCriteria, global::Ionic.Zip.ExtractExistingFileAction extractExistingFile)
		{
			foreach (global::Ionic.Zip.ZipEntry zipEntry in this.SelectEntries(selectionCriteria))
			{
				zipEntry.Password = this._Password;
				zipEntry.Extract(extractExistingFile);
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x000112B8 File Offset: 0x0000F4B8
		public void ExtractSelectedEntries(string selectionCriteria, string directoryPathInArchive)
		{
			foreach (global::Ionic.Zip.ZipEntry zipEntry in this.SelectEntries(selectionCriteria, directoryPathInArchive))
			{
				zipEntry.Password = this._Password;
				zipEntry.Extract();
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00011310 File Offset: 0x0000F510
		public void ExtractSelectedEntries(string selectionCriteria, string directoryInArchive, string extractDirectory)
		{
			foreach (global::Ionic.Zip.ZipEntry zipEntry in this.SelectEntries(selectionCriteria, directoryInArchive))
			{
				zipEntry.Password = this._Password;
				zipEntry.Extract(extractDirectory);
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0001136C File Offset: 0x0000F56C
		public void ExtractSelectedEntries(string selectionCriteria, string directoryPathInArchive, string extractDirectory, global::Ionic.Zip.ExtractExistingFileAction extractExistingFile)
		{
			foreach (global::Ionic.Zip.ZipEntry zipEntry in this.SelectEntries(selectionCriteria, directoryPathInArchive))
			{
				zipEntry.Password = this._Password;
				zipEntry.Extract(extractDirectory, extractExistingFile);
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000113C8 File Offset: 0x0000F5C8
		static ZipFile()
		{
			global::System.Text.Encoding encoding = null;
			try
			{
				encoding = global::System.Text.Encoding.GetEncoding("IBM437");
			}
			catch (global::System.Exception)
			{
			}
			if (encoding == null)
			{
				try
				{
					encoding = global::System.Text.Encoding.GetEncoding(1252);
				}
				catch (global::System.Exception)
				{
				}
			}
			global::Ionic.Zip.ZipFile._defaultEncoding = encoding;
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00011540 File Offset: 0x0000F740
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00011547 File Offset: 0x0000F747
		public static global::System.Text.Encoding DefaultEncoding
		{
			get
			{
				return global::Ionic.Zip.ZipFile._defaultEncoding;
			}
			set
			{
				if (global::Ionic.Zip.ZipFile._defaultEncodingInitialized)
				{
					return;
				}
				global::Ionic.Zip.ZipFile._defaultEncoding = value;
				global::Ionic.Zip.ZipFile._defaultEncodingInitialized = true;
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0001155D File Offset: 0x0000F75D
		public global::System.Collections.Generic.IEnumerator<global::Ionic.Zip.ZipEntry> GetEnumerator()
		{
			foreach (global::Ionic.Zip.ZipEntry zipEntry in this._entries.Values)
			{
				yield return zipEntry;
			}
			global::System.Collections.Generic.Dictionary<string, global::Ionic.Zip.ZipEntry>.ValueCollection.Enumerator enumerator = default(global::System.Collections.Generic.Dictionary<string, global::Ionic.Zip.ZipEntry>.ValueCollection.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0001156C File Offset: 0x0000F76C
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0001156C File Offset: 0x0000F76C
		[global::System.Runtime.InteropServices.DispId(-4)]
		public global::System.Collections.IEnumerator GetNewEnum()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000189 RID: 393
		private static global::Ionic.Zip.ZipFile.ExtractorSettings[] SettingsList = new global::Ionic.Zip.ZipFile.ExtractorSettings[]
		{
			new global::Ionic.Zip.ZipFile.ExtractorSettings
			{
				Flavor = global::Ionic.Zip.SelfExtractorFlavor.WinFormsApplication,
				ReferencedAssemblies = new global::System.Collections.Generic.List<string>
				{
					"System.dll",
					"System.Windows.Forms.dll",
					"System.Drawing.dll"
				},
				CopyThroughResources = new global::System.Collections.Generic.List<string>
				{
					"Ionic.Zip.WinFormsSelfExtractorStub.resources",
					"Ionic.Zip.Forms.PasswordDialog.resources",
					"Ionic.Zip.Forms.ZipContentsDialog.resources"
				},
				ResourcesToCompile = new global::System.Collections.Generic.List<string>
				{
					"WinFormsSelfExtractorStub.cs",
					"WinFormsSelfExtractorStub.Designer.cs",
					"PasswordDialog.cs",
					"PasswordDialog.Designer.cs",
					"ZipContentsDialog.cs",
					"ZipContentsDialog.Designer.cs",
					"FolderBrowserDialogEx.cs"
				}
			},
			new global::Ionic.Zip.ZipFile.ExtractorSettings
			{
				Flavor = global::Ionic.Zip.SelfExtractorFlavor.ConsoleApplication,
				ReferencedAssemblies = new global::System.Collections.Generic.List<string>
				{
					"System.dll"
				},
				CopyThroughResources = null,
				ResourcesToCompile = new global::System.Collections.Generic.List<string>
				{
					"CommandLineSelfExtractorStub.cs"
				}
			}
		};

		// Token: 0x04000192 RID: 402
		private global::System.IO.TextWriter _StatusMessageTextWriter;

		// Token: 0x04000193 RID: 403
		private bool _CaseSensitiveRetrieval;

		// Token: 0x04000194 RID: 404
		private bool _IgnoreDuplicateFiles;

		// Token: 0x04000195 RID: 405
		private global::System.IO.Stream _readstream;

		// Token: 0x04000196 RID: 406
		private global::System.IO.Stream _writestream;

		// Token: 0x04000197 RID: 407
		private ushort _versionMadeBy;

		// Token: 0x04000198 RID: 408
		private ushort _versionNeededToExtract;

		// Token: 0x04000199 RID: 409
		private uint _diskNumberWithCd;

		// Token: 0x0400019A RID: 410
		private long _maxOutputSegmentSize;

		// Token: 0x0400019B RID: 411
		private uint _numberOfSegmentsForMostRecentSave;

		// Token: 0x0400019C RID: 412
		private global::Ionic.Zip.ZipErrorAction _zipErrorAction;

		// Token: 0x0400019D RID: 413
		private bool _disposed;

		// Token: 0x0400019E RID: 414
		private global::System.Collections.Generic.Dictionary<string, global::Ionic.Zip.ZipEntry> _entries;

		// Token: 0x0400019F RID: 415
		private global::System.Collections.Generic.Dictionary<string, global::Ionic.Zip.ZipEntry> _entriesInsensitive;

		// Token: 0x040001A0 RID: 416
		private global::System.Collections.Generic.List<global::Ionic.Zip.ZipEntry> _zipEntriesAsList;

		// Token: 0x040001A1 RID: 417
		private string _name;

		// Token: 0x040001A2 RID: 418
		private string _readName;

		// Token: 0x040001A3 RID: 419
		private string _Comment;

		// Token: 0x040001A4 RID: 420
		internal string _Password;

		// Token: 0x040001A5 RID: 421
		private bool _emitNtfsTimes = true;

		// Token: 0x040001A6 RID: 422
		private bool _emitUnixTimes;

		// Token: 0x040001A7 RID: 423
		private global::Ionic.Zlib.CompressionStrategy _Strategy;

		// Token: 0x040001A8 RID: 424
		private global::Ionic.Zip.CompressionMethod _compressionMethod = global::Ionic.Zip.CompressionMethod.Deflate;

		// Token: 0x040001A9 RID: 425
		private bool _fileAlreadyExists;

		// Token: 0x040001AA RID: 426
		private string _temporaryFileName;

		// Token: 0x040001AB RID: 427
		private bool _contentsChanged;

		// Token: 0x040001AC RID: 428
		private bool _hasBeenSaved;

		// Token: 0x040001AD RID: 429
		private string _TempFileFolder;

		// Token: 0x040001AE RID: 430
		private bool _ReadStreamIsOurs = true;

		// Token: 0x040001AF RID: 431
		private object LOCK = new object();

		// Token: 0x040001B0 RID: 432
		private bool _saveOperationCanceled;

		// Token: 0x040001B1 RID: 433
		private bool _extractOperationCanceled;

		// Token: 0x040001B2 RID: 434
		private bool _addOperationCanceled;

		// Token: 0x040001B3 RID: 435
		private global::Ionic.Zip.EncryptionAlgorithm _Encryption;

		// Token: 0x040001B4 RID: 436
		private bool _JustSaved;

		// Token: 0x040001B5 RID: 437
		private long _locEndOfCDS = -1L;

		// Token: 0x040001B6 RID: 438
		private uint _OffsetOfCentralDirectory;

		// Token: 0x040001B7 RID: 439
		private long _OffsetOfCentralDirectory64;

		// Token: 0x040001B8 RID: 440
		private bool? _OutputUsesZip64;

		// Token: 0x040001B9 RID: 441
		internal bool _inExtractAll;

		// Token: 0x040001BA RID: 442
		private global::System.Text.Encoding _alternateEncoding;

		// Token: 0x040001BB RID: 443
		private global::Ionic.Zip.ZipOption _alternateEncodingUsage;

		// Token: 0x040001BC RID: 444
		private int _BufferSize = global::Ionic.Zip.ZipFile.BufferSizeDefault;

		// Token: 0x040001BD RID: 445
		internal global::Ionic.Zlib.ParallelDeflateOutputStream ParallelDeflater;

		// Token: 0x040001BE RID: 446
		private long _ParallelDeflateThreshold;

		// Token: 0x040001BF RID: 447
		private int _maxBufferPairs = 16;

		// Token: 0x040001C0 RID: 448
		internal global::Ionic.Zip.Zip64Option _zip64;

		// Token: 0x040001C1 RID: 449
		private bool _SavingSfx;

		// Token: 0x040001C2 RID: 450
		public static readonly int BufferSizeDefault = 32768;

		// Token: 0x040001C5 RID: 453
		private long _lengthOfReadStream = -99L;

		// Token: 0x040001C9 RID: 457
		private static global::System.Text.Encoding _defaultEncoding = null;

		// Token: 0x040001CA RID: 458
		private static bool _defaultEncodingInitialized = false;

		// Token: 0x02000073 RID: 115
		private class ExtractorSettings
		{
			// Token: 0x0400040E RID: 1038
			public global::Ionic.Zip.SelfExtractorFlavor Flavor;

			// Token: 0x0400040F RID: 1039
			public global::System.Collections.Generic.List<string> ReferencedAssemblies;

			// Token: 0x04000410 RID: 1040
			public global::System.Collections.Generic.List<string> CopyThroughResources;

			// Token: 0x04000411 RID: 1041
			public global::System.Collections.Generic.List<string> ResourcesToCompile;
		}
	}
}
