namespace Desafio_RPG_Orientação_Objetos_Csharp.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType, int HP, int MP){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP =MP;
        }

        public override string Attack()
        {
            return ($"{this.Name} Lançou Magia das Trevas!");
        }

        public string Attack(int bonus){

            if (bonus > 6)
            {
                return ($"{this.Name} Lançou Magia das Trevas com bonus super efetivo de {bonus}!");
            }
            else
            {
                return ($"{this.Name} Lançou Magia das Trevas força fraca com bonus de {bonus}!");
            }
        }
            
    
    }
}