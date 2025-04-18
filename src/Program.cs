// See https://aka.ms/new-console-template for more information

using new_weapon.src.Systems.UI.Screens;
using new_weapon.src.Systems.Input;

class Program
{
        static void Main(string[] args)
        {
                StartScreen start = StartScreen.Instance;
                start.InstantiateCenter(start.message);

                Input input = new()
                {
                        show_input = true
                };
                input.CreateInputField(out _, "Enter something: ");
        }
}

