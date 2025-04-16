using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace new_weapon.src.NPCs
{
        public abstract class Npc(string name, Npc.EGroups group, Npc.ERelationships relationship = Npc.ERelationships.Neutral)
        {
                public enum ERelationships
                {
                        Friend,
                        Enemy,
                        Neutral,
                }
                public enum EGroups
                {
                        Stalker,
                        Bandit,
                        Military,
                }

                public string Name { get; set; } = name;
                public EGroups Group { get; set; } = group;
                public ERelationships Relationship { get; set; } = relationship;

                public override string ToString()
                {
                        return $"{Group}, {Name}, {Relationship}";
                }
        }
}