using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml;

namespace DevAge.Security.Cryptography
{
	// Token: 0x0200028D RID: 653
	internal class Utilities
	{
		// Token: 0x020004BD RID: 1213
		public class DES
		{
			// Token: 0x060033F0 RID: 13296 RVA: 0x000BB26C File Offset: 0x000B946C
			public static string EncryptString(string p_strInput, string p_Key8chars)
			{
				string result;
				using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
				{
					global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(memoryStream);
					streamWriter.Write(p_strInput);
					streamWriter.Flush();
					memoryStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
					using (global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream())
					{
						global::DevAge.Security.Cryptography.Utilities.DES.EncryptStream(memoryStream, memoryStream2, p_Key8chars);
						memoryStream2.Flush();
						memoryStream2.Seek(0L, global::System.IO.SeekOrigin.Begin);
						result = global::System.Convert.ToBase64String(memoryStream2.ToArray());
						memoryStream2.Close();
					}
					streamWriter.Close();
				}
				return result;
			}

			// Token: 0x060033F1 RID: 13297 RVA: 0x000BB314 File Offset: 0x000B9514
			public static string DecryptString(string p_strInput, string p_Key8chars)
			{
				string result;
				using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
				{
					byte[] array = global::System.Convert.FromBase64String(p_strInput);
					memoryStream.Write(array, 0, array.Length);
					memoryStream.Flush();
					memoryStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
					using (global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream())
					{
						global::DevAge.Security.Cryptography.Utilities.DES.DecryptStream(memoryStream, memoryStream2, p_Key8chars);
						global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(memoryStream2);
						result = streamReader.ReadToEnd();
						streamReader.Close();
					}
					memoryStream.Close();
				}
				return result;
			}

			// Token: 0x060033F2 RID: 13298 RVA: 0x000BB3B4 File Offset: 0x000B95B4
			public static void EncryptStream(global::System.IO.Stream p_StreamInput, global::System.IO.Stream p_StreamOutput, string p_Key8chars)
			{
				global::System.Security.Cryptography.ICryptoTransform transform = new global::System.Security.Cryptography.DESCryptoServiceProvider
				{
					Key = global::System.Text.Encoding.ASCII.GetBytes(p_Key8chars),
					IV = global::System.Text.Encoding.ASCII.GetBytes(p_Key8chars)
				}.CreateEncryptor();
				using (global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(p_StreamOutput, transform, global::System.Security.Cryptography.CryptoStreamMode.Write))
				{
					byte[] array = new byte[p_StreamInput.Length];
					p_StreamInput.Read(array, 0, array.Length);
					cryptoStream.Write(array, 0, array.Length);
					cryptoStream.FlushFinalBlock();
				}
			}

			// Token: 0x060033F3 RID: 13299 RVA: 0x000BB448 File Offset: 0x000B9648
			public static void DecryptStream(global::System.IO.Stream p_StreamInput, global::System.IO.Stream p_StreamOutput, string p_Key8chars)
			{
				global::System.Security.Cryptography.ICryptoTransform transform = new global::System.Security.Cryptography.DESCryptoServiceProvider
				{
					Key = global::System.Text.Encoding.ASCII.GetBytes(p_Key8chars),
					IV = global::System.Text.Encoding.ASCII.GetBytes(p_Key8chars)
				}.CreateDecryptor();
				using (global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(p_StreamOutput, transform, global::System.Security.Cryptography.CryptoStreamMode.Write))
				{
					byte[] array = new byte[p_StreamInput.Length];
					p_StreamInput.Read(array, 0, array.Length);
					cryptoStream.Write(array, 0, array.Length);
					cryptoStream.FlushFinalBlock();
				}
				p_StreamOutput.Seek(0L, global::System.IO.SeekOrigin.Begin);
			}
		}

		// Token: 0x020004BE RID: 1214
		public class SHA1
		{
			// Token: 0x060033F5 RID: 13301 RVA: 0x000BB4EC File Offset: 0x000B96EC
			public static string HashPassword(string p_Password)
			{
				global::System.Security.Cryptography.SHA1CryptoServiceProvider sha1CryptoServiceProvider = new global::System.Security.Cryptography.SHA1CryptoServiceProvider();
				byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes(p_Password);
				byte[] inArray = sha1CryptoServiceProvider.ComputeHash(bytes);
				return global::System.Convert.ToBase64String(inArray);
			}
		}

		// Token: 0x020004BF RID: 1215
		public class XmlDigitalSign
		{
			// Token: 0x060033F7 RID: 13303 RVA: 0x000BB528 File Offset: 0x000B9728
			public static void GenerateKeys(out string keyPubPri, out string keyPub)
			{
				global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider = new global::System.Security.Cryptography.RSACryptoServiceProvider(1024);
				keyPubPri = rsacryptoServiceProvider.ToXmlString(true);
				keyPub = rsacryptoServiceProvider.ToXmlString(false);
				rsacryptoServiceProvider.Clear();
			}

			// Token: 0x060033F8 RID: 13304 RVA: 0x000BB55C File Offset: 0x000B975C
			public static global::System.Xml.XmlElement CreateSignature(global::System.Xml.XmlDocument xmlToSign, string keyPubPri)
			{
				global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider = new global::System.Security.Cryptography.RSACryptoServiceProvider();
				rsacryptoServiceProvider.FromXmlString(keyPubPri);
				global::System.Security.Cryptography.Xml.SignedXml signedXml = new global::System.Security.Cryptography.Xml.SignedXml(xmlToSign);
				signedXml.SigningKey = rsacryptoServiceProvider;
				global::System.Security.Cryptography.Xml.Reference reference = new global::System.Security.Cryptography.Xml.Reference("");
				signedXml.SignedInfo.CanonicalizationMethod = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
				global::System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform transform = new global::System.Security.Cryptography.Xml.XmlDsigEnvelopedSignatureTransform(false);
				reference.AddTransform(transform);
				signedXml.AddReference(reference);
				signedXml.ComputeSignature();
				return signedXml.GetXml();
			}

			// Token: 0x060033F9 RID: 13305 RVA: 0x000BB5C4 File Offset: 0x000B97C4
			public static global::System.Xml.XmlDocument CreateSignedDoc(global::System.Xml.XmlDocument xmlToSign, string keyPubPri)
			{
				global::System.Xml.XmlElement node = global::DevAge.Security.Cryptography.Utilities.XmlDigitalSign.CreateSignature(xmlToSign, keyPubPri);
				global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
				xmlDocument.AppendChild(xmlDocument.ImportNode(xmlToSign.DocumentElement, true));
				xmlDocument.DocumentElement.PrependChild(xmlDocument.ImportNode(node, true));
				return xmlDocument;
			}

			// Token: 0x060033FA RID: 13306 RVA: 0x000BB60C File Offset: 0x000B980C
			public static bool CheckSignature(global::System.Xml.XmlDocument signedDoc, string keyPub)
			{
				global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider = new global::System.Security.Cryptography.RSACryptoServiceProvider();
				rsacryptoServiceProvider.FromXmlString(keyPub);
				global::System.Security.Cryptography.Xml.SignedXml signedXml = new global::System.Security.Cryptography.Xml.SignedXml(signedDoc);
				signedXml.LoadXml(global::DevAge.Security.Cryptography.Utilities.XmlDigitalSign.GetSignatureFromSignedDoc(signedDoc));
				return signedXml.CheckSignature(rsacryptoServiceProvider);
			}

			// Token: 0x060033FB RID: 13307 RVA: 0x000BB644 File Offset: 0x000B9844
			public static global::System.Xml.XmlElement GetSignatureFromSignedDoc(global::System.Xml.XmlDocument signedDoc)
			{
				global::System.Xml.XmlNodeList elementsByTagName = signedDoc.GetElementsByTagName("Signature");
				if (elementsByTagName.Count <= 0)
				{
					throw new global::System.Security.Cryptography.CryptographicException("Verification failed: No Signature was found in the document.");
				}
				if (elementsByTagName.Count >= 2)
				{
					throw new global::System.Security.Cryptography.CryptographicException("Verification failed: More that one signature was found for the document.");
				}
				return (global::System.Xml.XmlElement)elementsByTagName[0];
			}

			// Token: 0x060033FC RID: 13308 RVA: 0x000BB69C File Offset: 0x000B989C
			public static global::System.Xml.XmlDocument CreateDocWithoutSignature(global::System.Xml.XmlDocument signedDoc)
			{
				global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
				xmlDocument.AppendChild(xmlDocument.ImportNode(signedDoc.DocumentElement, true));
				global::System.Xml.XmlElement signatureFromSignedDoc = global::DevAge.Security.Cryptography.Utilities.XmlDigitalSign.GetSignatureFromSignedDoc(xmlDocument);
				signatureFromSignedDoc.ParentNode.RemoveChild(signatureFromSignedDoc);
				return xmlDocument;
			}
		}
	}
}
