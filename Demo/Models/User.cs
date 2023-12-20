using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class User
    {
		private int iD;

		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
		private String email;

		public String Email
		{
			get { return email; }
			set { email = value; }
		}
		private String name;

		public String Name
		{
			get { return name; }
			set { name = value; }
		}
		private DateTime birthDay;

		public DateTime BirthDay
		{
			get { return birthDay; }
			set { birthDay = value; }
		}

	}
}