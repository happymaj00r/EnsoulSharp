

namespace Script_Maker
{
    using Easy_Mid.Champions;
    using EnsoulSharp;
    using EnsoulSharp.SDK;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public static class Program
    {
        public static void Main()
        {
            GameEvent.OnGameLoad += OnGameLoad;
        }
        private static void OnGameLoad()
        {
            
            
            if (ObjectManager.Player.CharacterName == ObjectManager.Player.CharacterName)
            {
                ScriptMaker.OnLoad();
                Chat.PrintChat("Welcome to Script Maker :)");
            }
        }
    }
}
