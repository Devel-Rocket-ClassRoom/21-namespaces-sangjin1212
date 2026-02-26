using System;
Console.WriteLine("=== 캐릭터 시스템 ===");
MyGame.Characters.Player play = new MyGame.Characters.Player();
play.Name = "용사";
play.Attack();
MyGame.Characters.Enemy play1 = new MyGame.Characters.Enemy();
play1.Type = "고블린";
play1.TakeDamage();
Console.WriteLine();
Console.WriteLine("=== 아이템 시스템 ===");
MyGame.Items.Weapon weapon = new MyGame.Items.Weapon();
weapon.Name = "불꽃검";
weapon.GetDamage();
MyGame.Items.Potion potion = new MyGame.Items.Potion();
potion.Name = "체력포션";
potion.Use();

namespace MyGame.Characters
{
    public class Player
    {
        public string Name;

        public void Attack()
        {
            
            Console.WriteLine($"플레이어 {Name}가 공격합니다!");
        }
    }
    public class Enemy
    {
        public string Type;
        public void TakeDamage()
        {
            
            Console.WriteLine($"적 {Type}이 데미지를 받았습니다.");
        }
    }
}

namespace MyGame.Items
{
    public class Weapon
    {
        public string Name;
        public void GetDamage()
        {
            
            Console.WriteLine($"무기 {Name}의 공격력: 50");
        }
    }

    public class Potion
    {
        public string Name;

        public void Use()
        {
    
            Console.WriteLine($"포션 {Name}을 사용했습니다.");
        }
    }
}