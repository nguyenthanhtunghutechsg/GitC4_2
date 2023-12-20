using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Lecture:User
    {
		private int mSGV;

		public int MSGV
		{
			get { return mSGV; }
			set { mSGV = value; }
		}

	}
}