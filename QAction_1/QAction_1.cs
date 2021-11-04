namespace DataXml
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
	[System.SerializableAttribute]
	[System.Diagnostics.DebuggerStepThroughAttribute]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName = "server", Namespace = "", IsNullable = false)]
	public partial class Server
	{
		private ServerDevice[] devicesField;

		private ServerAlarm[] alarmsField;

		private uint bootldrrevField;

		private ushort layoutrevField;

		private uint productidField;

		private string tempunitField;

		private uint buzzerField;

		private string consoleidField;

		private string supportphoneField;

		private string supportemailField;

		private string companyurlField;

		private string companyField;

		private string macaddressField;

		private string versionField;

		private string nameField;

		private string addressbackupField;

		private string addressField;

		private string hostField;

		[System.Xml.Serialization.XmlArrayItemAttribute("device", IsNullable = false)]
		public ServerDevice[] devices
		{
			get
			{
				return this.devicesField;
			}

			set
			{
				this.devicesField = value;
			}
		}

		[System.Xml.Serialization.XmlArrayItemAttribute("alarm", IsNullable = false)]
		public ServerAlarm[] alarms
		{
			get
			{
				return this.alarmsField;
			}

			set
			{
				this.alarmsField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute("bootldr-rev")]
		public uint bootldrrev
		{
			get
			{
				return this.bootldrrevField;
			}

			set
			{
				this.bootldrrevField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute("layout-rev")]
		public ushort layoutrev
		{
			get
			{
				return this.layoutrevField;
			}

			set
			{
				this.layoutrevField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute("product-id")]
		public uint productid
		{
			get
			{
				return this.productidField;
			}

			set
			{
				this.productidField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute]
		public string tempunit
		{
			get
			{
				return this.tempunitField;
			}

			set
			{
				this.tempunitField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute]
		public uint buzzer
		{
			get
			{
				return this.buzzerField;
			}

			set
			{
				this.buzzerField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute("console-id")]
		public string consoleid
		{
			get
			{
				return this.consoleidField;
			}

			set
			{
				this.consoleidField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute("support-phone")]
		public string supportphone
		{
			get
			{
				return this.supportphoneField;
			}

			set
			{
				this.supportphoneField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute("support-email")]
		public string supportemail
		{
			get
			{
				return this.supportemailField;
			}

			set
			{
				this.supportemailField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute("company-url")]
		public string companyurl
		{
			get
			{
				return this.companyurlField;
			}

			set
			{
				this.companyurlField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute]
		public string company
		{
			get
			{
				return this.companyField;
			}

			set
			{
				this.companyField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute("mac-address")]
		public string macaddress
		{
			get
			{
				return this.macaddressField;
			}

			set
			{
				this.macaddressField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute]
		public string version
		{
			get
			{
				return this.versionField;
			}

			set
			{
				this.versionField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute]
		public string name
		{
			get
			{
				return this.nameField;
			}

			set
			{
				this.nameField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute("address-backup")]
		public string addressbackup
		{
			get
			{
				return this.addressbackupField;
			}

			set
			{
				this.addressbackupField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute]
		public string address
		{
			get
			{
				return this.addressField;
			}

			set
			{
				this.addressField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute]
		public string host
		{
			get
			{
				return this.hostField;
			}

			set
			{
				this.hostField = value;
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
	[System.SerializableAttribute]
	[System.Diagnostics.DebuggerStepThroughAttribute]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class ServerDevice
	{
		private serverDeviceField[] fieldField;

		private string nameField;

		private uint indexField;

		private uint availableField;

		private string typeField;

		private string idField;

		[System.Xml.Serialization.XmlElementAttribute("field")]
		public serverDeviceField[] field
		{
			get
			{
				return this.fieldField;
			}

			set
			{
				this.fieldField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute]
		public string name
		{
			get
			{
				return this.nameField;
			}

			set
			{
				this.nameField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute]
		public uint index
		{
			get
			{
				return this.indexField;
			}

			set
			{
				this.indexField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute]
		public uint available
		{
			get
			{
				return this.availableField;
			}

			set
			{
				this.availableField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute]
		public string type
		{
			get
			{
				return this.typeField;
			}

			set
			{
				this.typeField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute]
		public string id
		{
			get
			{
				return this.idField;
			}

			set
			{
				this.idField = value;
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
	[System.SerializableAttribute]
	[System.Diagnostics.DebuggerStepThroughAttribute]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class serverDeviceField
	{
		private uint typeField;

		private int maxField;

		private int minField;

		private string niceNameField;

		private double valueField;

		private string keyField;

		[System.Xml.Serialization.XmlAttributeAttribute]
		public uint type
		{
			get
			{
				return this.typeField;
			}

			set
			{
				this.typeField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute]
		public int max
		{
			get
			{
				return this.maxField;
			}

			set
			{
				this.maxField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute]
		public int min
		{
			get
			{
				return this.minField;
			}

			set
			{
				this.minField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute]
		public string niceName
		{
			get
			{
				return this.niceNameField;
			}

			set
			{
				this.niceNameField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute]
		public double value
		{
			get
			{
				return this.valueField;
			}

			set
			{
				this.valueField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute]
		public string key
		{
			get
			{
				return this.keyField;
			}

			set
			{
				this.keyField = value;
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
	[System.SerializableAttribute]
	[System.Diagnostics.DebuggerStepThroughAttribute]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class ServerAlarm
	{
		private uint cidField;

		private string statusField;

		private uint enabledField;

		private uint emwarnField;

		private uint emtripField;

		private string fieldField;

		private string deviceidField;

		[System.Xml.Serialization.XmlAttributeAttribute]
		public uint cid
		{
			get
			{
				return this.cidField;
			}

			set
			{
				this.cidField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute]
		public string status
		{
			get
			{
				return this.statusField;
			}

			set
			{
				this.statusField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute]
		public uint enabled
		{
			get
			{
				return this.enabledField;
			}

			set
			{
				this.enabledField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute("em-warn")]
		public uint emwarn
		{
			get
			{
				return this.emwarnField;
			}

			set
			{
				this.emwarnField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute("em-trip")]
		public uint emtrip
		{
			get
			{
				return this.emtripField;
			}

			set
			{
				this.emtripField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute]
		public string field
		{
			get
			{
				return this.fieldField;
			}

			set
			{
				this.fieldField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute("device-id")]
		public string deviceid
		{
			get
			{
				return this.deviceidField;
			}

			set
			{
				this.deviceidField = value;
			}
		}
	}
}

namespace XmlMethods
{
	using System;
	using System.IO;
	using Skyline.DataMiner.Scripting;

	public static class MySerialization
	{
		public static string SerializeObject<T>(this T toSerialize)
		{
			using (StringWriter textWriter = new StringWriter())
			{
				System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(toSerialize.GetType());
				xmlSerializer.Serialize(textWriter, toSerialize);
				return textWriter.ToString();
			}
		}

		/// <summary>
		/// Deserializes an XML document back to a class.
		/// </summary>
		/// <typeparam name="T">Class of the object to deserialize into.</typeparam>
		/// <param name="objectData">The XML document in string format.</param>
		/// <returns>The object resulting from the XML deserialization.</returns>
		public static T XmlDeserializeFromString<T>(this string objectData)
		{
			return (T)XmlDeserializeFromString(objectData, typeof(T));
		}

		/// <summary>
		/// Deserializes an XML document contained by the specified string.
		/// </summary>
		/// <param name="objectData">Input string.</param>
		/// <param name="type">Type of object to deserialize.</param>
		/// <returns>The deserialized object.</returns>
		public static object XmlDeserializeFromString(this string objectData, Type type)
		{
			object result;

			try
			{
				using (TextReader reader = new StringReader(objectData))
				{
					System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(type);
					result = serializer.Deserialize(reader);
				}

				return result;
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Deserializes an XML document back to a class. This version is necessary for the XmlDeserializeFromString version to output errors into the node's logs.
		/// </summary>
		/// <typeparam name="T">Class of the object to deserialize into.</typeparam>
		/// <param name="objectData">The XML document in string format.</param>
		/// /// <param name="protocol">The protocol object that will be used to log actions and errors.</param>
		/// <returns>The object resulting from the XML deserialization.</returns>
		public static T XmlDeserializeFromString<T>(this string objectData, SLProtocol protocol)
		{
			return (T)XmlDeserializeFromString(objectData, typeof(T), protocol);
		}

		/// <summary>
		/// Deserializes the XML document contained by the specified string. This version is important because it allows the function to output errors into the node's logs.
		/// Particularly important in case something goes wrong during deserialization, because it allows the user to know exactly what went wrong.
		/// </summary>
		/// <param name="objectData">Input string.</param>
		/// <param name="type">Type of object to deserialize.</param>
		/// <param name="protocol">Link with SLProtocol process.</param>
		/// <returns>The deserialized object.</returns>
		public static object XmlDeserializeFromString(this string objectData, Type type, SLProtocol protocol)
		{
			object result;

			try
			{
				using (TextReader reader = new StringReader(objectData))
				{
					System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(type);
					result = serializer.Deserialize(reader);
				}

				return result;
			}
			catch (Exception e)
			{
				protocol.Log("### QA " + protocol.QActionID + " ### ERROR ### Quick action has thrown the following exception:\n" + e.Message + "\nStack trace: " + e.ToString(), LogType.Allways, LogLevel.LogEverything);
				return null;
			}
		}
	}
}