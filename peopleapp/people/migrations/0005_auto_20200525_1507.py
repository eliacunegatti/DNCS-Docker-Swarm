# Generated by Django 3.0.6 on 2020-05-25 15:07

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('people', '0004_auto_20200525_1405'),
    ]

    operations = [
        migrations.AlterField(
            model_name='person',
            name='gender',
            field=models.CharField(choices=[('MASCHIO', 'maschio'), ('FEMMINA', 'femmina'), ('ALTRO', 'altro')], max_length=10),
        ),
    ]
