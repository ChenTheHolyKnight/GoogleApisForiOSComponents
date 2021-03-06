﻿using System;
namespace Firebase.MLKit.ModelInterpreter
{
	public class Loader
	{
		static Loader ()
		{
			Firebase.Core.Loader.ForceLoad ();
			Firebase.InstanceID.Loader.ForceLoad ();
			Firebase.MLKit.Common.Loader.ForceLoad ();
		}

		public static void ForceLoad () { }
	}
}

namespace ApiDefinition
{
	partial class Messaging
	{
		static Messaging ()
		{
			Firebase.MLKit.ModelInterpreter.Loader.ForceLoad ();
		}
	}
}
