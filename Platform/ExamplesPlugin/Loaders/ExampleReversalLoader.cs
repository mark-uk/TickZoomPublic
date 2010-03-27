#region Copyright
/*
 * Software: TickZoom Trading Platform
 * Copyright 2009 M. Wayne Walter
 * 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, see <http://www.tickzoom.org/wiki/Licenses>
 * or write to Free Software Foundation, Inc., 51 Franklin Street,
 * Fifth Floor, Boston, MA  02110-1301, USA.
 * 
 */
#endregion

using System;
using System.Collections.Generic;
using TickZoom.Api;
using TickZoom.Common;

namespace TickZoom
{
	/// <summary>
	/// Description of Starter.
	/// </summary>
	public class ExampleReversalLoader : ModelLoaderCommon
	{
		public ExampleReversalLoader() {
			/// <summary>
			/// IMPORTANT: You can personalize the name of each model loader.
			/// </summary>
			category = "Example";
			name = "Reversal Single-Symbol";
		}
		
		public override void OnInitialize(ProjectProperties properties) {
			AddVariable("ExampleReversalStrategy.ExitStrategy.StopLoss",0.01,1.00,0.10,true);
			AddVariable("ExampleReversalStrategy.ExitStrategy.TargetProfit",0.01,1.00,0.10,false);
		}
		
		public override void OnLoad(ProjectProperties model) {
	    	TopModel = GetStrategy("ExampleReversalStrategy");
		}
		
	}
}
