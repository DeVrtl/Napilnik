using System;

namespace Napilnik1
{
    class Weapon
    {
        private int _damage;
        private int _bullet;
        private readonly int _minBullets;

        private void BulletsCheaker()
        {
            if (_bullet < _minBullets) 
            {
                throw new InvalidOperationException();
            }
        }

        public void Fire(Player player)
        {
            player.TakeDamage(_damage);
            _bullet -= 1;
        }
    }

    class Player
    {
        private readonly int _maxHealth;
        private readonly int _minHealth;
        private int _health;

        private void HealthCheaker()
        {
            if (_health > _maxHealth || _health < _minHealth)
            {
                throw new InvalidOperationException();
            }
        }

        public void TakeDamage(int damge)
        {
            _health -= damge;
        }
    }

    class Bot
    {
        private Weapon _weapon;

        private void OnSeePlayer(Player player)
        {
            _weapon.Fire(player);
        }
    }
}
