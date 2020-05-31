from django.db import models
import datetime
from django.utils import timezone
# Create your models here.

class Person(models.Model):
    name = models.CharField(max_length=20)
    surname = models.CharField(max_length=20)
    GENDER_CHOICES = (
        ('MASCHIO', 'maschio'),
        ('FEMMINA', 'femmina'),
        ('ALTRO', 'altro')
    )
    gender = models.CharField(choices=GENDER_CHOICES, max_length=10)
    age = models.IntegerField(default=0)


