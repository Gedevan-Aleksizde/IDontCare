﻿using IDontCare.Filtering;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.LogEntries;

namespace IDontCare.Filtering.LogEntries
{
    internal abstract class FilteredLogBase
    {
        public abstract bool ShouldPlayerCare(LogEntry logEntry);

        protected bool ShouldPlayerCare(int filterMode, IEnumerable<IFaction> factionsInvolved)
            => FilteringMethods.ShouldPlayerCare(filterMode, factionsInvolved);

        protected bool ShouldPlayerCare(int filterMode, IFaction factionInvolved)
            => FilteringMethods.ShouldPlayerCare(filterMode, factionInvolved);

        protected bool ShouldPlayerCare(int filterMode, IEnumerable<Hero> heroesInvolved)
            => FilteringMethods.ShouldPlayerCare(filterMode, heroesInvolved);

        protected bool ShouldPlayerCare(int filterMode, Hero heroInvolved)
            => FilteringMethods.ShouldPlayerCare(filterMode, heroInvolved);

        internal static object GetLogEntryPrivateField(object instance, string fieldName)
            => FilteringMethods.GetLogEntryPrivateField(instance, fieldName);
    }
}