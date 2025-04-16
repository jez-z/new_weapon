// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Http.Headers;
using new_weapon.src.Items.Weapons.Guns;
using new_weapon.src.NPCs.Groups.Stalkers;
using new_weapon.src.Systems.UI.Screens;

class Program
{
        static void Main(string[] args)
        {
                StartScreen start = StartScreen.Instance;

                start.Instantiate(start.template);
        }
}

