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
                public readonly string template = "START";

                public override void Instantiate(string template)
                {
                        base.Instantiate(template);
                }
        }
}