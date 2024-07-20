// <auto-generated> This file has been auto generated. </auto-generated>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;
#if!GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
using Newtonsoft.Json;
#endif

namespace STRATZ
{
    public partial class ModifierType
    {
        public short? Id { get; set; }
        public string Name { get; set; }
        public int? BuffDuration { get; set; }
        public bool? IsRoot { get; set; }
        public bool? IsStun { get; set; }
        public bool? IsSilence { get; set; }
        public bool? IsInvisible { get; set; }
        public bool? IsShackle { get; set; }
        public bool? IsHex { get; set; }
        public bool? IsSleep { get; set; }
        public bool? IsCyclone { get; set; }
        public bool? IsTaunt { get; set; }
        public bool? IsDisarm { get; set; }
        public bool? IsBlind { get; set; }
        public bool? IsEthereal { get; set; }
        public bool? IsMovementSlow { get; set; }
        public bool? IsAttackSlow { get; set; }
        public bool? IsBreak { get; set; }
        public bool? IsArmorReduce { get; set; }
        public bool? IsAttackReduce { get; set; }
        public bool? IsMute { get; set; }
        public bool? IsDamageAmplified { get; set; }
        public bool? IsMovementDebuff { get; set; }
        public bool? IsKnockback { get; set; }
        public bool? IsWeaken { get; set; }
        public bool? IsItem { get; set; }
        public bool? IsBanished { get; set; }
    }
}