using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotsSlotsSlotsSlots.Settings
{
    internal class SlotSettings
    {
        public int SlotToModify { get; set; }
        public HashSet<int> AddSlots { get; set; } = new();
        public HashSet<int> RemoveSlots { get; set; } = new();

    }
}
