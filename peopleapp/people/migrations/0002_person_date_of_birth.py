# Generated by Django 3.0.6 on 2020-05-25 14:02

import datetime
from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('people', '0001_initial'),
    ]

    operations = [
        migrations.AddField(
            model_name='person',
            name='date_of_birth',
            field=models.DateField(default=datetime.datetime(2020, 5, 25, 14, 2, 34, 746549)),
        ),
    ]
