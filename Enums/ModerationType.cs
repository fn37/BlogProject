using System.ComponentModel;

namespace CodeWithFilza.Enums
{
    public enum ModerationType
    {

        [Description("Political propoganda")]
        Political,

        [Description("Offensive language")]
        Language,

        [Description("Drug reference")]
        Drugs,

        [Description("Threatening speech")]
        Threatening,

        [Description("Sexual content")]
        Sexual,

        [Description("Hate Speech")]
        HateSpeech,

        [Description("Targeted Shaming")]
        Shaming
    }
}
