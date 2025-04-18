namespace new_weapon.src.Systems.Input
{
        public static class SYSTEM_INPUT { }

        public class Input
        {
                public bool show_input = false;

                public virtual void CreateInputField(out string put_into, string message = "\t:")
                {
                        Console.Write(string.Concat(" :: ", message));
                        put_into = Console.ReadLine() ?? "no_input_provided";
                        if (string.IsNullOrWhiteSpace(put_into))
                        {
                                //TODO Error handling
                                put_into = "no_input_provided";
                        }

                        if (show_input) Console.WriteLine(string.Concat(" :your choice: ", put_into));
                }
        }
}