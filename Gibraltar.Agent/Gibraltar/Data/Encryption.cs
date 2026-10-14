using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Data
{
	// Token: 0x02000253 RID: 595
	internal class Encryption
	{
		// Token: 0x06001DBB RID: 7611 RVA: 0x00068C3C File Offset: 0x00066E3C
		public Encryption(string keyContainerName, bool machineStore)
		{
			if (string.IsNullOrEmpty(keyContainerName))
			{
				throw new global::System.ArgumentNullException("keyContainerName");
			}
			this.m_KeyContainerName = keyContainerName;
			this.m_MachineStore = machineStore;
			using (global::System.Security.Cryptography.RSACryptoServiceProvider localKey = this.GetLocalKey(true))
			{
				this.m_PublicKey = localKey.ExportCspBlob(false);
				this.m_ExternalPublicKey = global::System.Convert.ToBase64String(this.m_PublicKey);
				if (string.IsNullOrEmpty(this.m_ExternalPublicKey))
				{
					throw new global::System.InvalidOperationException("Unable to get public key for key container, encryption and decryption are not possible.");
				}
			}
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x00068CD8 File Offset: 0x00066ED8
		public Encryption(string publicKey)
		{
			if (string.IsNullOrEmpty(publicKey))
			{
				throw new global::System.ArgumentNullException("publicKey");
			}
			this.m_ExternalPublicKey = publicKey;
			this.m_PublicKey = global::System.Convert.FromBase64String(publicKey);
			this.m_EncryptOnly = true;
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x00068D10 File Offset: 0x00066F10
		public byte[] Decrypt(byte[] encryptedData)
		{
			if (this.m_EncryptOnly)
			{
				throw new global::System.InvalidOperationException("The encryption object is configured for encryption only to an external private key");
			}
			return this.PerformDecrypt(encryptedData);
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x00068D30 File Offset: 0x00066F30
		public byte[] Decrypt(string encryptedString)
		{
			byte[] bytes = global::System.Text.Encoding.Unicode.GetBytes(encryptedString);
			return this.Decrypt(bytes);
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x00068D54 File Offset: 0x00066F54
		public string DecryptString(byte[] encryptedData)
		{
			if (this.m_EncryptOnly)
			{
				throw new global::System.InvalidOperationException("The encryption object is configured for encryption only to an external private key");
			}
			byte[] bytes = this.PerformDecrypt(encryptedData);
			return global::System.Text.Encoding.Unicode.GetString(bytes);
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x00068D90 File Offset: 0x00066F90
		public byte[] Encrypt(string data)
		{
			byte[] bytes = global::System.Text.Encoding.Unicode.GetBytes(data);
			return this.PerformEncrypt(bytes, this.m_PublicKey);
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x00068DBC File Offset: 0x00066FBC
		public byte[] Encrypt(byte[] data)
		{
			return this.PerformEncrypt(data, this.m_PublicKey);
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x00068DCC File Offset: 0x00066FCC
		public string PublicKey
		{
			get
			{
				return this.m_ExternalPublicKey;
			}
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x00068DD4 File Offset: 0x00066FD4
		public void ClearKey()
		{
			using (global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider = new global::System.Security.Cryptography.RSACryptoServiceProvider(new global::System.Security.Cryptography.CspParameters
			{
				KeyContainerName = this.m_KeyContainerName,
				Flags = global::System.Security.Cryptography.CspProviderFlags.UseMachineKeyStore
			}))
			{
				rsacryptoServiceProvider.PersistKeyInCsp = false;
				rsacryptoServiceProvider.Clear();
			}
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x00068E30 File Offset: 0x00067030
		public void ExportKey(string fileNamePath)
		{
			if (string.IsNullOrEmpty(fileNamePath))
			{
				throw new global::System.ArgumentNullException("fileNamePath");
			}
			global::System.IO.File.WriteAllBytes(fileNamePath, this.ExportKeyToArray());
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x00068E54 File Offset: 0x00067054
		public byte[] ExportKeyToArray()
		{
			byte[] result;
			using (global::System.Security.Cryptography.RSACryptoServiceProvider localKey = this.GetLocalKey(false))
			{
				if (localKey != null)
				{
					result = localKey.ExportCspBlob(true);
				}
				else
				{
					result = new byte[0];
				}
			}
			return result;
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x00068EA8 File Offset: 0x000670A8
		public void ImportKey(string fileNamePath)
		{
			if (string.IsNullOrEmpty(fileNamePath))
			{
				throw new global::System.ArgumentNullException("fileNamePath");
			}
			byte[] array = global::System.IO.File.ReadAllBytes(fileNamePath);
			if (array.Length == 0)
			{
				throw new global::System.InvalidOperationException("No key data found in the file");
			}
			this.ImportKey(array);
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00068EF0 File Offset: 0x000670F0
		public void ImportKey(byte[] keyBlob)
		{
			using (global::System.Security.Cryptography.RSACryptoServiceProvider localKey = this.GetLocalKey(false))
			{
				if (localKey != null)
				{
					localKey.ImportCspBlob(keyBlob);
				}
			}
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x00068F34 File Offset: 0x00067134
		private global::System.Security.Cryptography.RSACryptoServiceProvider GetLocalKey(bool logDetails = false)
		{
			global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider = null;
			global::System.Security.Cryptography.CspKeyContainerInfo cspKeyContainerInfo = null;
			global::System.Security.Cryptography.CspParameters cspParameters = new global::System.Security.Cryptography.CspParameters();
			cspParameters.KeyContainerName = this.m_KeyContainerName;
			cspParameters.Flags = (this.m_MachineStore ? (global::System.Security.Cryptography.CspProviderFlags.UseMachineKeyStore | global::System.Security.Cryptography.CspProviderFlags.UseExistingKey) : global::System.Security.Cryptography.CspProviderFlags.UseExistingKey);
			try
			{
				rsacryptoServiceProvider = new global::System.Security.Cryptography.RSACryptoServiceProvider(cspParameters);
				cspKeyContainerInfo = rsacryptoServiceProvider.CspKeyContainerInfo;
				int keySize = rsacryptoServiceProvider.KeySize;
				bool publicOnly = rsacryptoServiceProvider.PublicOnly;
				bool flag = false;
				if (cspKeyContainerInfo.Accessible)
				{
					bool exportable = cspKeyContainerInfo.Exportable;
					bool hardwareDevice = cspKeyContainerInfo.HardwareDevice;
					bool @protected = cspKeyContainerInfo.Protected;
					bool removable = cspKeyContainerInfo.Removable;
					bool randomlyGenerated = cspKeyContainerInfo.RandomlyGenerated;
					if (logDetails)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Data.Encryption.LogCategory, "Cryptography key found in container " + this.m_KeyContainerName, "A {0}-bit {1} key was found with accessible info.\r\n{2}, {3}, {4}, {5}, {6} key found.\r\n", new object[]
						{
							keySize,
							publicOnly ? "public" : "private",
							exportable ? "Exportable" : "Non-exportable",
							randomlyGenerated ? "randomly-generated" : "non-random",
							removable ? "removable" : "non-removable",
							@protected ? "protected" : "unencrypted",
							hardwareDevice ? "hardware device" : "internal"
						});
					}
					if (publicOnly || @protected || hardwareDevice)
					{
						flag = true;
					}
					if (keySize != 1024 && keySize != 2048 && keySize != 1536)
					{
						flag = true;
					}
				}
				else
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Data.Encryption.LogCategory, "Cryptography key found in container " + this.m_KeyContainerName, "A {0}-bit {1} key was found with inaccessible info.\r\n", new object[]
					{
						keySize,
						publicOnly ? "public" : "private"
					});
					flag = true;
				}
				if (flag)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Data.Encryption.LogCategory, "Improper local cryptography key, generating new one", "Unique key store name: {0}", new object[]
					{
						this.m_KeyContainerName
					});
					rsacryptoServiceProvider.PersistKeyInCsp = false;
					rsacryptoServiceProvider.Clear();
					((global::System.IDisposable)rsacryptoServiceProvider).Dispose();
					rsacryptoServiceProvider = null;
					cspKeyContainerInfo = null;
				}
			}
			catch (global::System.Exception ex)
			{
				if (rsacryptoServiceProvider == null)
				{
					if (!this.m_MachineStore && ex.Message.StartsWith("Key not valid for use in specified state", global::System.StringComparison.OrdinalIgnoreCase))
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, global::Gibraltar.Data.Encryption.LogCategory, "Local cryptography key found is broken and unusable, attempting to replace", "Unique key store name: {0}", new object[]
						{
							this.m_KeyContainerName
						});
						global::Gibraltar.Data.Encryption.RemoveUserBadKeyFile(this.m_KeyContainerName);
					}
					else
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, global::Gibraltar.Data.Encryption.LogCategory, "Local cryptography key not found, generating one", "Unique key store name: {0}", new object[]
						{
							this.m_KeyContainerName
						});
					}
				}
				else
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, global::Gibraltar.Data.Encryption.LogCategory, "Error examining cryptography key, generating new one", "Unique key store name: {0}", new object[]
					{
						this.m_KeyContainerName
					});
					rsacryptoServiceProvider.PersistKeyInCsp = false;
					rsacryptoServiceProvider.Clear();
					((global::System.IDisposable)rsacryptoServiceProvider).Dispose();
					rsacryptoServiceProvider = null;
					cspKeyContainerInfo = null;
				}
			}
			if (rsacryptoServiceProvider == null)
			{
				cspParameters.CryptoKeySecurity = null;
				cspParameters.Flags = (this.m_MachineStore ? (global::System.Security.Cryptography.CspProviderFlags.UseMachineKeyStore | global::System.Security.Cryptography.CspProviderFlags.UseArchivableKey) : global::System.Security.Cryptography.CspProviderFlags.UseArchivableKey);
				rsacryptoServiceProvider = new global::System.Security.Cryptography.RSACryptoServiceProvider(1024, cspParameters);
				cspKeyContainerInfo = rsacryptoServiceProvider.CspKeyContainerInfo;
				this.m_TriedFixKeyPermissions = true;
				global::Gibraltar.Data.Encryption.FixKeyPermissions(cspKeyContainerInfo.UniqueKeyContainerName, this.m_KeyContainerName, true, logDetails);
			}
			else if (!this.m_TriedFixKeyPermissions)
			{
				this.m_TriedFixKeyPermissions = true;
				global::Gibraltar.Data.Encryption.FixKeyPermissions(cspKeyContainerInfo.UniqueKeyContainerName, this.m_KeyContainerName, true, logDetails);
			}
			return rsacryptoServiceProvider;
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x000692CC File Offset: 0x000674CC
		private static void FixKeyPermissions(string uniqueKeyName, string label, bool persisting, bool logDetails = false)
		{
			if (string.IsNullOrEmpty(uniqueKeyName))
			{
				return;
			}
			string str;
			if (string.IsNullOrEmpty(label))
			{
				str = string.Empty;
			}
			else
			{
				str = string.Format(" for {0} key", label);
			}
			try
			{
				string text = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData);
				text = global::System.IO.Path.Combine(text, "Microsoft");
				if (global::System.IO.Directory.Exists(text))
				{
					text = global::System.IO.Path.Combine(text, "Crypto");
					if (global::System.IO.Directory.Exists(text))
					{
						text = global::System.IO.Path.Combine(text, "RSA");
						if (global::System.IO.Directory.Exists(text))
						{
							text = global::System.IO.Path.Combine(text, "MachineKeys");
							if (global::System.IO.Directory.Exists(text))
							{
								string[] files = global::System.IO.Directory.GetFiles(text, uniqueKeyName);
								if (files.Length == 1)
								{
									if (persisting && logDetails)
									{
										global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Data.Encryption.LogCategory, "Checking key permissions" + str, null, new object[0]);
									}
									global::System.Security.Principal.SecurityIdentifier securityIdentifier = new global::System.Security.Principal.SecurityIdentifier(global::System.Security.Principal.WellKnownSidType.BuiltinUsersSid, null);
									global::System.Security.Principal.SecurityIdentifier securityIdentifier2 = new global::System.Security.Principal.SecurityIdentifier(global::System.Security.Principal.WellKnownSidType.BuiltinAdministratorsSid, null);
									global::System.Security.Principal.IdentityReference identity = new global::System.Security.Principal.SecurityIdentifier(global::System.Security.Principal.WellKnownSidType.CreatorOwnerSid, null);
									global::System.Security.AccessControl.FileSystemAccessRule rule = new global::System.Security.AccessControl.FileSystemAccessRule(securityIdentifier, global::System.Security.AccessControl.FileSystemRights.Modify, global::System.Security.AccessControl.AccessControlType.Allow);
									global::System.Security.AccessControl.FileSystemAccessRule rule2 = new global::System.Security.AccessControl.FileSystemAccessRule(securityIdentifier2, global::System.Security.AccessControl.FileSystemRights.Modify, global::System.Security.AccessControl.AccessControlType.Allow);
									global::System.Security.AccessControl.FileSystemAccessRule rule3 = new global::System.Security.AccessControl.FileSystemAccessRule(identity, global::System.Security.AccessControl.FileSystemRights.FullControl, global::System.Security.AccessControl.AccessControlType.Allow);
									foreach (string path in files)
									{
										try
										{
											if (!persisting)
											{
												global::System.Security.AccessControl.FileSecurity accessControl = global::System.IO.File.GetAccessControl(path);
												accessControl.GetAccessRules(true, false, typeof(global::System.Security.Principal.SecurityIdentifier));
												accessControl.AddAccessRule(rule3);
												global::System.IO.File.SetAccessControl(path, accessControl);
											}
											else if (global::System.IO.File.Exists(path))
											{
												bool flag = true;
												bool flag2 = true;
												global::System.Security.AccessControl.FileSecurity accessControl = global::System.IO.File.GetAccessControl(path);
												foreach (object obj in accessControl.GetAccessRules(true, false, typeof(global::System.Security.Principal.SecurityIdentifier)))
												{
													global::System.Security.AccessControl.FileSystemAccessRule fileSystemAccessRule = ((global::System.Security.AccessControl.AuthorizationRule)obj) as global::System.Security.AccessControl.FileSystemAccessRule;
													if (fileSystemAccessRule != null && fileSystemAccessRule.AccessControlType == global::System.Security.AccessControl.AccessControlType.Allow && (fileSystemAccessRule.FileSystemRights & global::System.Security.AccessControl.FileSystemRights.Modify) == global::System.Security.AccessControl.FileSystemRights.Modify)
													{
														if (fileSystemAccessRule.IdentityReference == securityIdentifier)
														{
															flag = false;
														}
														else if (fileSystemAccessRule.IdentityReference == securityIdentifier2)
														{
															flag2 = false;
														}
													}
												}
												if (flag || flag2)
												{
													accessControl.AddAccessRule(rule3);
													accessControl.AddAccessRule(rule);
													accessControl.AddAccessRule(rule2);
													global::System.IO.File.SetAccessControl(path, accessControl);
													if (logDetails)
													{
														global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Data.Encryption.LogCategory, "Key permissions successfully set" + str, null, new object[0]);
													}
												}
												else if (logDetails)
												{
													global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Data.Encryption.LogCategory, "Key permissions already set" + str, null, new object[0]);
												}
											}
											else
											{
												global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, global::Gibraltar.Data.Encryption.LogCategory, "Key permissions could not be checked" + str, null, new object[0]);
											}
										}
										catch
										{
											if (persisting)
											{
												global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Data.Encryption.LogCategory, "Key permissions could not be set" + str, null, new object[0]);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			catch
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, global::Gibraltar.Data.Encryption.LogCategory, "Key permissions could not be found" + str, null, new object[0]);
			}
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x00069670 File Offset: 0x00067870
		private static void RemoveUserBadKeyFile(string keyContainerName)
		{
			if (string.IsNullOrEmpty(keyContainerName))
			{
				return;
			}
			string text;
			if (keyContainerName == "Gibraltar_Credentials_User")
			{
				text = "7233e1ab2a599ff9a1d76ffcf1b7e93a_*";
			}
			else
			{
				if (!(keyContainerName == "Gibraltar_Test_Credentials_User"))
				{
					return;
				}
				text = "05a0c0ce7d6b6b6663f15e5fd2a1b366_*";
			}
			string text2 = null;
			try
			{
				string text3 = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.ApplicationData);
				text3 = global::System.IO.Path.Combine(text3, "Microsoft");
				if (global::System.IO.Directory.Exists(text3))
				{
					text3 = global::System.IO.Path.Combine(text3, "Crypto");
					if (global::System.IO.Directory.Exists(text3))
					{
						text3 = global::System.IO.Path.Combine(text3, "RSA");
						if (global::System.IO.Directory.Exists(text3))
						{
							string[] directories = global::System.IO.Directory.GetDirectories(text3, "S-*", global::System.IO.SearchOption.TopDirectoryOnly);
							int num = directories.Length;
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Data.Encryption.LogCategory, null, "Found {0} user key store folder{1}{2}.", new object[]
							{
								num,
								(num == 1) ? string.Empty : "s",
								(num > 0) ? ".  Searching.." : string.Empty
							});
							foreach (string text4 in directories)
							{
								string[] files = global::System.IO.Directory.GetFiles(text4, text);
								if (files.Length >= 1)
								{
									if (!string.IsNullOrEmpty(text2))
									{
										global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Data.Encryption.LogCategory, null, "More than one user key store folder has container files matching:\r\n'{0}'\r\nUnable to proceed with deletion", new object[]
										{
											text
										});
										text2 = null;
										break;
									}
									if (files.Length > 1)
									{
										global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Data.Encryption.LogCategory, null, "Multiple key container files matching '{0}'\r\nfound in: '{1}'\r\nUnable to proceed with deletion.", new object[]
										{
											text,
											text4
										});
										text2 = null;
										break;
									}
									text2 = files[0];
								}
							}
							if (!string.IsNullOrEmpty(text2))
							{
								global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, global::Gibraltar.Data.Encryption.LogCategory, null, "Deleting bad key container: {0}", new object[]
								{
									text2
								});
								global::System.IO.File.Delete(text2);
							}
						}
					}
				}
			}
			catch (global::System.Exception)
			{
				global::Gibraltar.Monitor.Log.Write(string.IsNullOrEmpty(text2) ? global::Loupe.Extensibility.Data.LogMessageSeverity.Information : global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Data.Encryption.LogCategory, null, "Unable to delete key bad container file for {0}", new object[]
				{
					keyContainerName
				});
			}
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x000698AC File Offset: 0x00067AAC
		private byte[] PerformEncrypt(byte[] data, byte[] publicKey)
		{
			byte[] result;
			using (global::System.Security.Cryptography.RijndaelManaged rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged())
			{
				rijndaelManaged.BlockSize = 128;
				rijndaelManaged.KeySize = 128;
				rijndaelManaged.Mode = global::System.Security.Cryptography.CipherMode.CFB;
				rijndaelManaged.Padding = global::System.Security.Cryptography.PaddingMode.None;
				rijndaelManaged.FeedbackSize = 8;
				rijndaelManaged.GenerateKey();
				rijndaelManaged.GenerateIV();
				byte[] key = rijndaelManaged.Key;
				byte[] iv = rijndaelManaged.IV;
				byte[] array = new byte[iv.Length + key.Length];
				global::System.Array.Copy(iv, array, 16);
				global::System.Array.Copy(key, 0, array, 16, key.Length);
				byte[] array2 = null;
				using (global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider = new global::System.Security.Cryptography.RSACryptoServiceProvider(new global::System.Security.Cryptography.CspParameters
				{
					CryptoKeySecurity = null,
					Flags = (global::System.Security.Cryptography.CspProviderFlags.UseMachineKeyStore | global::System.Security.Cryptography.CspProviderFlags.NoPrompt)
				}))
				{
					try
					{
						rsacryptoServiceProvider.PersistKeyInCsp = false;
						rsacryptoServiceProvider.ImportCspBlob(publicKey);
					}
					catch (global::System.Exception exception)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, exception, global::Gibraltar.Data.Encryption.LogCategory, "Invalid machine public key submitted.", "Failed to import as CSP Blob.\r\nPublic key string: {0}\r\n", new object[]
						{
							publicKey
						});
						throw;
					}
					array2 = rsacryptoServiceProvider.Encrypt(array, false);
				}
				byte[] array3 = global::Gibraltar.Data.BinarySerializer.SerializeValue(array2.Length);
				using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
				{
					memoryStream.Write(array3, 0, array3.Length);
					memoryStream.Write(array2, 0, array2.Length);
					using (global::System.Security.Cryptography.ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor())
					{
						using (global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream, cryptoTransform, global::System.Security.Cryptography.CryptoStreamMode.Write))
						{
							cryptoStream.Write(data, 0, data.Length);
							cryptoStream.Close();
						}
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x00069AD0 File Offset: 0x00067CD0
		private byte[] PerformDecrypt(byte[] encryptedData)
		{
			if (encryptedData == null || encryptedData.Length == 0)
			{
				return new byte[0];
			}
			int num2;
			byte[] buffer;
			byte[] array2;
			try
			{
				using (global::System.Security.Cryptography.RSACryptoServiceProvider localKey = this.GetLocalKey(false))
				{
					localKey.PersistKeyInCsp = true;
					byte[] array;
					using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(encryptedData))
					{
						int num;
						global::Gibraltar.Data.BinarySerializer.DeserializeValue(memoryStream, out num);
						array = new byte[num];
						memoryStream.Read(array, 0, num);
						num2 = encryptedData.Length - (int)memoryStream.Position;
						buffer = new byte[num2];
						memoryStream.Read(buffer, 0, num2);
					}
					array2 = localKey.Decrypt(array, false);
				}
			}
			catch (global::System.OverflowException ex)
			{
				throw new global::System.Security.Cryptography.CryptographicException("Unable to decrypt data due to " + ex.GetType(), ex);
			}
			byte[] array3 = new byte[16];
			int num3 = array2.Length - 16;
			byte[] array4 = new byte[num3];
			global::System.Array.Copy(array2, array3, 16);
			global::System.Array.Copy(array2, 16, array4, 0, num3);
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream())
			{
				using (global::System.Security.Cryptography.RijndaelManaged rijndaelManaged = new global::System.Security.Cryptography.RijndaelManaged())
				{
					rijndaelManaged.BlockSize = 128;
					rijndaelManaged.Key = array4;
					rijndaelManaged.IV = array3;
					rijndaelManaged.Mode = global::System.Security.Cryptography.CipherMode.CFB;
					rijndaelManaged.Padding = global::System.Security.Cryptography.PaddingMode.None;
					rijndaelManaged.FeedbackSize = 8;
					using (global::System.Security.Cryptography.ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor())
					{
						using (global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream2, cryptoTransform, global::System.Security.Cryptography.CryptoStreamMode.Write))
						{
							cryptoStream.Write(buffer, 0, num2);
							cryptoStream.Close();
						}
					}
				}
				result = memoryStream2.ToArray();
			}
			return result;
		}

		// Token: 0x04000B11 RID: 2833
		private static string LogCategory = "Loupe.Encryption";

		// Token: 0x04000B12 RID: 2834
		private const int RijndaelBlockSize = 16;

		// Token: 0x04000B13 RID: 2835
		private const int RijndaelKeySize = 16;

		// Token: 0x04000B14 RID: 2836
		private readonly string m_KeyContainerName;

		// Token: 0x04000B15 RID: 2837
		private readonly byte[] m_PublicKey;

		// Token: 0x04000B16 RID: 2838
		private readonly string m_ExternalPublicKey;

		// Token: 0x04000B17 RID: 2839
		private readonly bool m_EncryptOnly;

		// Token: 0x04000B18 RID: 2840
		private readonly bool m_MachineStore;

		// Token: 0x04000B19 RID: 2841
		private bool m_TriedFixKeyPermissions;
	}
}
