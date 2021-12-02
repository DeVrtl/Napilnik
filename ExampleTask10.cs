namespace Napilnik1
{
    class ExampleTask10
    {
        class Weapon
        {
            private readonly int _minBullets;
            private readonly int _ammoCount;
            private int _bullets;

            public bool CanShoot() => _bullets > _minBullets;

            public void Shoot() => _bullets -= _ammoCount;
        }
    }
}
