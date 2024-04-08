from django.db import models
from django.contrib.auth.models import AbstractUser


# Модель для хранения информации о клиентах
class Client(AbstractUser):
    name = models.CharField(max_length=100)
    email = models.EmailField()
    phone_number = models.CharField(max_length=15)
    address = models.CharField(max_length=255)


# Модель для типов топлива
class FuelType(models.Model):
    name = models.CharField(max_length=20)

    def __str__(self):
        return self.name


# Модель для заправочной станции
class GasStation(models.Model):
    name = models.CharField(max_length=100)
    address = models.CharField(max_length=255)
    fuel_types = models.ManyToManyField(FuelType)

    def __str__(self):
        return self.name


# Модель для хранения информации о покупках топлива
class FuelPurchase(models.Model):
    client = models.ForeignKey(Client, on_delete=models.CASCADE)
    gas_station = models.ForeignKey(GasStation, on_delete=models.CASCADE)
    fuel_type = models.ForeignKey(FuelType, on_delete=models.CASCADE)
    amount = models.DecimalField(max_digits=6, decimal_places=2)
    purchase_date = models.DateTimeField(auto_now_add=True)


# Модель для дисконтных карт
class DiscountCard(models.Model):
    client = models.OneToOneField(Client, on_delete=models.CASCADE)
    card_number = models.CharField(max_length=20, unique=True)

    def __str__(self):
        return self.card_number


# Модель для бонусных карт и накопления бонусов
class BonusCard(models.Model):
    client = models.OneToOneField(Client, on_delete=models.CASCADE)
    card_number = models.CharField(max_length=20, unique=True)
    bonus_points = models.IntegerField(default=0)

    def __str__(self):
        return self.card_number
