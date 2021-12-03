using System;

namespace Napilnik1
{
    class Weapon
    {
        private int _bullet;
        private readonly int _damage;
        private readonly int _bulletsForSubtraction;
        private readonly int _defualtBulletsCount;

        private void CanShoot()
        {
            if (_bullet < _defualtBulletsCount) 
            {
                throw new InvalidOperationException();
            }
        }

        public void Fire(Player player)
        {
            player.TakeDamage(_damage);
            _bullet -= _bulletsForSubtraction;
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
