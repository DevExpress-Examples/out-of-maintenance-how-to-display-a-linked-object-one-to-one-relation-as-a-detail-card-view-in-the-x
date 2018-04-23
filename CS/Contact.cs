using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using DevExpress.Xpo;

namespace LinkedObjectAsCard
{
	public class Contact : XPObject
	{

		public Contact() : base()
		{
		}

		public Contact(Session session) : base(session)
		{
		}

		public Contact(string name, string phone)
		{
			this.FullName = name;
			this.Phone = phone;
		}

		public string FullName;
		public string Phone;

		public Address Address;

		public Contact Itself
		{
			get
			{
				return this;
			}
		}
	}


	public class Address : XPObject
	{

		public Address() : base()
		{
		}

		public Address(Session session) : base(session)
		{
		}

		public Address(string line1, string zip, string country)
		{
			this.Line1 = line1;
			this.ZIP = zip;
			this.Country = country;
		}

		public string Line1;
		public string ZIP;
		public string Country;
	}
} //end of root namespace