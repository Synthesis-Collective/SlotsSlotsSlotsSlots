using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SlotsSlotsSlotsSlots.Settings
{
    internal class PatcherSettings
    {
        [SynthesisOrder]
        public List<SlotSettings> SlotSettings { get; set; } = new();
        
        [SynthesisOrder]
        [SynthesisSettingName("Records To Yeet")]
        [SynthesisTooltip("These records will be excluded from the patch. I hope this is the desired result - I'm too old to know what Yeet means.")]
        public HashSet<IFormLinkGetter<IArmorAddonGetter>> RecordsToYeet { get; set; } = new();
        
        [SynthesisOrder]
        [SynthesisSettingName("EditorIDs To Yeet")]
        [SynthesisTooltip("These EditorIDs will be excluded from the patch (exact match). I hope this is the desired result - I'm too old to know what Yeet means.")]        
        public HashSet<string> EditorIDsToYeet { get; set; } = new();

        [SynthesisOrder]
        [SynthesisSettingName("EditorIDs To Yeet (Partial Match)")]
        [SynthesisTooltip("EditorIDs containing this text will be excluded from the patch. I hope this is the desired result - I'm too old to know what Yeet means.")]
        public HashSet<string> EditorIDsToYeet_Substrings { get; set; } = new();

        [SynthesisOrder]
        [SynthesisSettingName("ModKeys To Yeet (Source)")]
        [SynthesisTooltip("Armature originating in these plugins will be excluded from the patch. I hope this is the desired result - I'm too old to know what Yeet means.")]
        public HashSet<ModKey> ModKeysToYeet_Root { get; set; } = new();

        [SynthesisOrder]
        [SynthesisSettingName("ModKeys To Yeet (Override)")]
        [SynthesisTooltip("Armature that gets patched by these plugins will be excluded from the patch. I hope this is the desired result - I'm too old to know what Yeet means.")]
        public HashSet<ModKey> ModKeysToYeet_Override { get; set; } = new();
    }
}
