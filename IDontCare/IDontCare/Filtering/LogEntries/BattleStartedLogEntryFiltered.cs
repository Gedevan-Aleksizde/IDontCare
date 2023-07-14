﻿using IDontCare.Menu;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.LogEntries;

namespace IDontCare.Filtering.LogEntries
{
    internal class BattleStartedLogEntryFiltered : FilteredLogBase
    {
        public override bool ShouldPlayerCare(LogEntry logEntry)
        {
            var battleStartedLogEntry = logEntry as BattleStartedLogEntry;

            var attackerFaction = GetLogEntryPrivateField(battleStartedLogEntry, "_attackerFaction") as IFaction;

            return ShouldPlayerCare(IDontCareMenu.Instance.BattleStartedFilterMode.SelectedIndex, attackerFaction);
        }
    }
}
