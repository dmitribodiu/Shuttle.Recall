﻿using System.Configuration;

namespace Shuttle.Recall
{
	public class EventProcessorSection : ConfigurationSection
	{
		[ConfigurationProperty("modules", IsRequired = false, DefaultValue = null)]
		public ModulesElement Modules
		{
			get { return (ModulesElement)this["modules"]; }
		}
	}
}