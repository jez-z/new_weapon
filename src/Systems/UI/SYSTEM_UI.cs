namespace new_weapon.src.Systems.UI
{
        public static class SYSTEM_UI { }

        public abstract class UI
        {
                public virtual void Instantiate(string message)
                {
                        System.Console.WriteLine(message);
                }

                public virtual void InstantiateCenter(string message)
                {
                        string[] lines = message.Split("\n");
                        int consoleWidth = Console.WindowWidth;

                        foreach (string line in lines)
                        {
                                int padding = (consoleWidth - line.Length) / 2;
                                padding = padding < 0 ? 0 : padding;
                                Console.WriteLine(new string(' ', padding) + line);
                        }
                }
        }
}