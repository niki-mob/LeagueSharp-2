using LeagueSharp;

namespace AntiToxic
{
    class Program
    {
        private static int _index;
        private static readonly string[] Text = { 
            "Baby, can't you see",
            "I'm calling",
            "A guy like you should wear a warning",
            "It's dangerous",
            "I'm falling",

            "There's no escape",
            "I can't wait",
            "I need a hit",
            "Baby, give me it",
            "You're dangerous",
            "I'm loving it",

            "Too high",
            "Can't come down",
            "Losin' my head",
            "Spinnin' 'round and 'round",
            "Do you feel me now?",

            "With the taste of your lips",
            "I'm on a ride",
            "You're toxic I'm slippin' under (Ohh Ohh)",
            "With a taste of the poison paradise",
            "I'm addicted to you",
            "Don't you know that you're toxic?",
            "And I love what you do",
            "Don't you know that you're toxic?",

            "It's getting late",
            "To give you up",
            "I took a sip",
            "From my devil's cup",
            "Slowly, it's taking over me",

            "Too high",
            "Can't come down",
            "It's in the air and it's all around",
            "Can you feel me now?",

            "With the taste of your lips",
            "I'm on a ride",
            "You're toxic I'm slippin' under",
            "With the taste of the poison paradise",
            "I'm addicted to you",
            "Don't you know that you're toxic?",
            "And I love what you do",
            "Don't you know that you're toxic?",
            "Don't you know that you're toxic?",

            "Taste of your lips I'm on a ride",
            "You're toxic I'm slippin' under",
            "With a the taste of a poison paradise",
            "I'm addicted to you",
            "Don't you know that you're toxic?",

            "With the taste of your lips",
            "I'm on a ride",
            "You're toxic I'm slippin' under (Toxic)",
            "With the taste of the poison paradise",
            "I'm addicted to you",
            "Don't you know that you're toxic?",

            "Intoxicate me now",
            "With your lovin' now",
            "I think I'm ready now",
            "(I think I'm ready now)",
            "Intoxicate me now",
            "With your lovin' now",
            "I think I'm ready now" };

        static void Main(string[] args)
        {
            Game.OnInput += eventArgs =>
            {
                eventArgs.Process = false;

                if (_index >= Text.Length)
                    _index = 0;

                Game.PrintChat(Text[_index++]);
            };
        }
    }
}
