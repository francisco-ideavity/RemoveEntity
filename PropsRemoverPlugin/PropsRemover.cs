using System;
using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes;
using CounterStrikeSharp.API.Modules;
using CounterStrikeSharp.API.Modules.Events;

namespace PropsRemovePlugin
{
    [MinimumApiVersion(147)]
    public class PropsRemove : BasePlugin
    {
        public override string ModuleName => "Props Remove Plugin";
        public override string ModuleVersion => "1.0.0";
        public override string ModuleAuthor => "Seu Nome";
        public override string ModuleDescription => "Remove props no início de cada rodada.";

        public PropsRemove() {}

        public override void OnAllPluginsLoaded(bool hotReload)
        {
            // Using RegisterEventHandler to hook into the round_start event
            RegisterEventHandler<EventRoundStart>(OnRoundStart);
        }

        private HookResult OnRoundStart(EventRoundStart @event, GameEventInfo info)
        {
            ExecuteRemoveProps();
            return HookResult.Continue;
        }

        private void ExecuteRemoveProps()
        {
            // Use the appropriate method to execute console commands
            Server.ExecuteCommand("sv_cheats 1");

            // Remove props using the server command execution method
            Server.ExecuteCommand("ent_remove_all prop_dynamic");
            Server.ExecuteCommand("ent_remove prop.breakable.01");

            // Disable cheats again after removing the props
            Server.ExecuteCommand("sv_cheats 0");
        }
    }

    // Class representing the round_start event
    [EventName("round_start")]
    public class EventRoundStart : GameEvent
    {
        public EventRoundStart(IntPtr pointer) : base(pointer) {}
        public EventRoundStart(bool force) : base("round_start", force) {}
    }
}
