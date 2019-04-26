﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    /// <summary>
    /// Eduardo Colon
    /// Created: 2019/01/30
    /// 
    /// the role dataObjects
    /// </summary>
    public class Role : IMessagable
    {
        public string RoleID { get; set; }

        public string Description { get; set; }

		public List<string> Aliases
		{
			get
			{
				return new List<string> { RoleID };
			}
		}

		public string Alias
		{
			get
			{
				return RoleID;
			}
		}

		//  public bool Active { get; set; }
		
		public override string ToString()
        {
            return RoleID + Environment.NewLine + Environment.NewLine + Description;
        }
    }
}