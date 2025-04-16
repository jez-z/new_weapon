namespace new_weapon.src.Items.Weapons.Guns
{
        public class G17(string name, Item.Tags tag) : Item(name, tag)
        {
                public override void Use()
                {
                        System.Console.WriteLine("G17 used!");
                }
        }
}