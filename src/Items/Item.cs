// Item.cs
namespace new_weapon.src.Items
{
        public abstract class Item(string name, Item.Tags tag)
        {
                public enum Tags
                {
                        Weapon,
                        Food,
                        Consumable,
                }
                // must have - name, tag(category)
                public string Name { get; set; } = name;

                public Tags Tag { get; set; } = tag;

                public abstract void Use();

                public override string ToString()
                {
                        return $"{Tag}, {Name}";
                }
        }
}
