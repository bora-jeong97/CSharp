using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
 
    
    class Program
    {

        static void Main(string[] args)
        {

            Player player = new Knight();
            Player player2 = new Archer();
            Monster monster = new Orc();

            // 전투 : 플레이어 vs 몬스터 
            int damage = player.GetAttack();    // 플레이어 공격력
            monster.OnDamaged(damage);  // 몬스터 타격

            // PVP
            player2.OnDamaged(damage);
        }
    }
}
