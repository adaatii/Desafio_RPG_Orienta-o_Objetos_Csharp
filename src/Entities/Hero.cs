namespace Desafio_RPG_Orientação_Objetos_Csharp.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int HP, int MP){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP =MP;
        }

        public Hero()
        {            
        }

        public string Name {get ; set; } = null!;
        public int Level {get ; set; } 
        public string HeroType {get ; set; } = null!;
        public int HP {get ; set; }
        public int MP {get ; set; }

        public override string ToString(){
            return ($"{this.Name} {this.Level} {this.HeroType}");
        }

        public virtual string Attack(){
            return ($"{this.Name} Atacou com a sua espada"); 
        }
    }
}