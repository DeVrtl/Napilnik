using System;

namespace Napilnik1
{
    class Weapon
    {
        private int _bulletsInMagazine;
        private readonly int _damage;
        private readonly int _bulletsPerShot;
        private readonly int _minBulletsCountInMagazine;

        private Weapon(int bulletsInMagazine, int damage, int bulletsPerShot, int minBulletsCountInMagazine)
        {
            _bulletsInMagazine = bulletsInMagazine;
            _damage = damage;
            _bulletsPerShot = bulletsPerShot;
            _minBulletsCountInMagazine = minBulletsCountInMagazine;
        }

        public void Fire(Player player)
        {
            if (_bulletsInMagazine < _minBulletsCountInMagazine)
                throw new InvalidOperationException();
            
            player.TakeDamage(_damage);
            _bulletsInMagazine -= _bulletsPerShot;
        }
    }

    class Player
    {
        private readonly int _maxHealth;
        private readonly int _minHealth;
        private int _health;

        public void TakeDamage(int damge)
        {
            if (_health > _maxHealth || _health < _minHealth)
                throw new InvalidOperationException();

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
