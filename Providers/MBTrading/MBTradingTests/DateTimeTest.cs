﻿#region Copyright
/*
 * Copyright 2008 M. Wayne Walter
 * Software: TickZoom Trading Platform
 * User: Wayne Walter
 * 
 * You can use and modify this software under the terms of the
 * TickZOOM General Public License Version 1.0 or (at your option)
 * any later version.
 * 
 * Businesses are restricted to 30 days of use.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * TickZOOM General Public License for more details.
 *
 * You should have received a copy of the TickZOOM General Public
 * License along with this program.  If not, see
 * <http://www.tickzoom.org/wiki/Licenses>.
 */
#endregion

#define FOREX
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using NUnit.Framework;
using TickZoom.Api;
using TickZoom.TickUtil;

namespace TickZoom.Test
{
	[TestFixture]
	public class DateTimeTest
	{
		[Test]
		public void TestDateTime()
		{
			Log log = Factory.Log.GetLogger(typeof(DateTimeTest));
			TimeStamp normalUtcNow = new TimeStamp(DateTime.UtcNow.ToOADate());
			TimeStamp adjustedUtcNow = TimeStamp.UtcNow;
			log.Info( "normal = " + normalUtcNow + ", adjusted = " + adjustedUtcNow);

			normalUtcNow = new TimeStamp(DateTime.UtcNow.ToOADate());
			adjustedUtcNow = TimeStamp.UtcNow;
			log.Info( "normal = " + normalUtcNow + ", adjusted = " + adjustedUtcNow);
		}	
	}
}
