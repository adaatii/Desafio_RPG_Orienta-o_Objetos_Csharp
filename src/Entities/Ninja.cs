namespace Desafio_RPG_Orientação_Objetos_Csharp.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HP, int MP){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP =MP;
        }

        public override string Attack()
        {
            return ($"{this.Name} Atacou com sua Katana!");
        }

        public string Attack(int bonus){

            if (bonus > 6)
            {
                return ($"{this.Name} Atacou com sua Katana com bonus super efetivo de {bonus}!");
            }
            else
            {
                return ($"{this.Name} Atacou com sua Katana força fraca com bonus de {bonus}!");
            }
        }

            
    }
}