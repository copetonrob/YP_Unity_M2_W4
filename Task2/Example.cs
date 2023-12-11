//Заменим все числовые значения в коде на переменные.
//Пример объявления перменных.
//Целые числа
int a = 5;
int b = 10;

//Дробные числа:
float c = 3.5f;
float d = 17.3434f;

//Пример замены значений на переменные:

int TailHitDelay = 3;
int DragonHealAmount = 3;
int DragonMinHealth = 2;

float WaitTime = 5.0f;
float MinDistanceToPlayer = 3f;
float FlyUpDistance = 4.5f;

while (здоровья игрока > 0)
{

	if (здоровье дракона < DragonMinHealth)
	{
	Дракон лечит себе DragonHealAmount здоровья;
	ждать WaitTime секунд;
	}

	if (расстояние от дракона до игрока > MinDistanceToPlayer)
	{
		Выстрелить в игрока огнем;
		Ждать DragonFireDelay секунд;
	}
	else
	{
		Ударить игрока хвостом;
		Ждать TailHitDelay секунды;
	}
	
	if (игрок выше дракона)
	{
		Взлететь вверх на FlyUpDistance метра;
	}
	else
	{
		Опустится на землю;
	}
}