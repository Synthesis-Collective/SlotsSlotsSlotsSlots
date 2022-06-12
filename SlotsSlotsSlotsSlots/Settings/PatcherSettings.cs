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
        [SynthesisTooltip("These records will be excluded from the patch. I hope this is the desired result - I'm too old to know what Yeet means.")]
        public HashSet<IFormLinkGetter<IArmorAddonGetter>> RecordsToYeet { get; set; } = new();
        [SynthesisOrder]
        [SynthesisTooltip("These EditorIDs will be excluded from the patch. I hope this is the desired result - I'm too old to know what Yeet means.")]
        public HashSet<string> EditorIDsToYeet { get; set; } = new();
    }
}
