namespace new_weapon.src.Systems.UI
{
        public static class SYSTEM_UI {}

        public abstract class UI
        {
                public virtual void Instantiate(string template)
                {
                        System.Console.WriteLine(template);
                }
        }
}