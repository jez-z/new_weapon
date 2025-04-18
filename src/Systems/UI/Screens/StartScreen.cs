namespace new_weapon.src.Systems.UI.Screens
{
        public class StartScreen : SYSTEM_UI_SCREEN
        {
                private static StartScreen? instance;
                private StartScreen() { }
                public static StartScreen Instance
                {
                        get
                        {
                                instance ??= new StartScreen();
                                return instance;
                        }
                }
                public readonly string message = "START \n----------------------\nWelcome to\nNEW WEAPON";

                public override void Instantiate(string message)
                {
                        base.Instantiate(message);
                }

                public override void InstantiateCenter(string message)
                {
                        base.InstantiateCenter(message);
                }
        }
}